using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dllConectorMysql;
using dllLibreriaEvento;
using dllLibreriaMysql;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ControlDosimetro
{
	public partial class frmMantenedorTipoDocumento : Form
	{
		#region "Definicion variable"

		Clases.ClassEvento clsEvento = new Clases.ClassEvento();
		TextBox txtBox = new TextBox();
		Button btnColBuscara = new Button();
		bool bolInicializacion;
		bool Lectura;
		bool Nuevo;
		bool Modificacion;
		bool Eliminar;


		public int Id_Menu { get; private set; }

		public object[] Parametros
		{
			set
			{
				if (value != null)
				{
					Id_Menu = (int)value[0];
				}
			}
		}


		enum ConfGrilla : int
		{
			id = 0,
			detalle_tipo_documento = 1,
			Id_estado = 2,
			orden = 3
		};

		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();
		BindingSource bs = new BindingSource();
		dllLibreriaMysql.clsUtiles clsUtiles1 = new dllLibreriaMysql.clsUtiles();
		classFuncionesBD.ClsFunciones ClaseFunciones = new classFuncionesBD.ClsFunciones();

		#endregion

		#region "Inicio"

		public frmMantenedorTipoDocumento()
		{
			InitializeComponent();
			
		}

		private void frmMantenedorPerfil_Load(object sender, EventArgs e)
		{

			scPrincipal.Panel2Collapsed = true;
			AsignarPermiso();
			Cargar_Reporte();

			Cargar_Estado();
			dgvGrilla.AutoGenerateColumns = false;
			tsbGuardar.Enabled = false;
			bolInicializacion = true;
			CargarGrilla();

		}

		#endregion

		#region Procedimiento

		private void AsignarEvento()
		{
			clsEvento.AsignarNumero(ref txt_orden);
			clsEvento.AsignarKeyPress(ref txt_detalle_tipo_documento);
			//	clsEvento.K(ref txt_orden);
		}


		private void Cargar_Reporte()
		{
			ToolStripMenuItem tsiMenu;
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "pa_ListarReporte_Sel " + Id_Menu.ToString();
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);
			if (dt == null)
				tsdReporte.Visible = false;
			else
			{
				tsdReporte.Visible = dt.Tables[0].Rows.Count == 0 ? false : true;
				if (dt.Tables[0].Rows.Count > 0)
				{
					for (int intFila = 0; intFila <= dt.Tables[0].Rows.Count - 1; intFila++)
					{
						tsiMenu = new ToolStripMenuItem();
						tsiMenu.Text = dt.Tables[0].Rows[intFila]["Nombre"].ToString();
						tsiMenu.Name = dt.Tables[0].Rows[intFila]["nameMenu"].ToString();
						tsiMenu.Tag = dt.Tables[0].Rows[intFila]["N_Reporte"].ToString();
						tsiMenu.Click += new EventHandler(this.LLamadoReporte_Click);

						tsdReporte.DropDownItems.Add(tsiMenu);
					}
				}
			}

		}

		private void LLamadoReporte_Click(object sender, EventArgs e)
		{
			MDIPrincipal.LlamadaReporte(Convert.ToUInt16(((System.Windows.Forms.ToolStripItem)sender).Tag.ToString()));

		}

		private void AsignarPermiso()
		{
			ClaseFunciones.Cargar_Permiso(Clases.clsUsuario.Id_perfil, Id_Menu, ref Lectura, ref Nuevo, ref Modificacion, ref Eliminar);
			tsbAgregar.Visible = Nuevo;
			tsbGuardar.Visible = Nuevo || Modificacion;
			tsmEliminar.Visible = Eliminar;
		}

		private void Cargar_Estado()
		{
			ClaseComun.Listar_Estado(Clases.clsBD.BD, ref cbx_id_estado_Buscar, ref cbx_id_estado_Buscar);
			ClaseComun.Listar_Estado(Clases.clsBD.BD, ref cbx_id_estado, ref cbx_id_estado);
		}
		private void LimpiarFormulario()
		{
			txt_detalle_tipo_documento.Clear();
			txt_id_tipo_doc.Clear();
			txt_orden.Clear();
			cbx_id_estado.SelectedIndex = 0;
			btn_Guardar.Enabled = Modificacion || Nuevo;
			tsbGuardar.Visible = Modificacion || Nuevo;
		}
		private void Grabar()
		{
			Boolean bolResult;
			bolResult = false;
			if (MessageBox.Show("Desea grabar la información", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
			{
				if ((tssEstado.Text == "Nuevo") && (txt_id_tipo_doc.Text == "0"))
				{

					if (!String.IsNullOrEmpty(txt_detalle_tipo_documento.Text) && !String.IsNullOrEmpty(txt_orden.Text))
					{

						ClaseComun.Insertar(Clases.clsBD.BD, glo_TipoDocumentos, ref bolResult);
						if (bolResult == true)
						{
							CargarGrilla();
							MessageBox.Show("Dato Guardado");
						}
					}
					else
					{
						MessageBox.Show("Completar todos los campos");
					}
				}
				else
				if (tssEstado.Text == "Modificar")
				{
					if (!String.IsNullOrEmpty(txt_detalle_tipo_documento.Text) && !String.IsNullOrEmpty(txt_orden.Text))
					{
						ClaseComun.Modificar(Clases.clsBD.BD, glo_TipoDocumentos, ref bolResult);
						if (bolResult == true)
						{
							CargarGrilla();
							MessageBox.Show("Dato modificado");
						}

					}
					else
					{
						MessageBox.Show("Completar todos los campos");
					}
				}
			}
		}

		private void CargarGrilla()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "select id_tipo_doc as id, detalle_tipo_documento,id_estado,orden from glo_TipoDocumentos where id_estado= " + cbx_id_estado_Buscar.SelectedValue + "  order by orden";

			cmd.CommandType = CommandType.Text;

			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			bs.DataSource = dt.Tables[0];
			dgvGrilla.DataSource = bs;
			Filtro();
		}
		private void LlamadoAModificar(int intFila)
		{
			BindingSource bs1 = new BindingSource();
			bs1 = (BindingSource)dgvGrilla.DataSource;
			var currentRow = bs1.List[intFila];

			txt_id_tipo_doc.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.id].ToString();
			txt_detalle_tipo_documento.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.detalle_tipo_documento].ToString();
			txt_orden.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.orden].ToString();
			cbx_id_estado.SelectedValue = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Id_estado].ToString();
			tssEstado.Text = "Modificar";
			btn_Guardar.Enabled = Modificacion || Nuevo;
			tsbGuardar.Visible = Modificacion || Nuevo;
			btn_Guardar.Text = "Modificar";

			scPrincipal.Panel2Collapsed = false;
		}

		private void Filtro()
		{
			bs = new BindingSource();
			bs.DataSource = dgvGrilla.DataSource;
			bs.Filter = Coldetalle_tipo_documento.DataPropertyName + " like '%" + txtBox.Text + "%'";
			dgvGrilla.DataSource = bs;
		}

		#endregion

		#region " grilla"

		private void dgvGrilla_Paint(object sender, PaintEventArgs e)
		{
			if (bolInicializacion == true)
			{
				int columnIndex = 0;
				Point headerCellLocation = this.dgvGrilla.GetCellDisplayRectangle(columnIndex, -1, true).Location;
				txtBox.Location = new Point(headerCellLocation.X, headerCellLocation.Y + 20);
				txtBox.BackColor = Color.AliceBlue;
				txtBox.Width = Coldetalle_tipo_documento.Width - 2;
				txtBox.TextAlign = HorizontalAlignment.Left;
				dgvGrilla.Controls.Add(txtBox);

				columnIndex = -1;
				headerCellLocation = this.dgvGrilla.GetCellDisplayRectangle(columnIndex, -1, true).Location;
				btnColBuscara.Location = new Point(headerCellLocation.X, headerCellLocation.Y + 0);
				btnColBuscara.Image = ControlDosimetro.Properties.Resources.Buscar;

				btnColBuscara.FlatStyle = FlatStyle.Standard;
				btnColBuscara.Height = 41;
				btnColBuscara.Width = 41;
				btnColBuscara.Click += new EventHandler(BtnColBuscar_Click);

				dgvGrilla.Controls.Add(btnColBuscara);
			}
			bolInicializacion = false;
		}

		private void dgvGrilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int intFila = e.RowIndex;
			LlamadoAModificar(intFila);
		}

		private void dgvGrilla_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
		{
			txtBox.Width = Coldetalle_tipo_documento.Width - 4;
			int columnIndex = 0;
			Point headerCellLocation = this.dgvGrilla.GetCellDisplayRectangle(columnIndex, -1, true).Location;
			txtBox.Location = new Point(headerCellLocation.X, headerCellLocation.Y + 20);
		}

		#endregion

		#region "boton"
		private void BtnColBuscar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			Filtro();
			Cursor = Cursors.Default;
		}

		private void btn_Limpiar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			LimpiarFormulario();
			tssEstado.Text = "Nuevo";
			txt_id_tipo_doc.Text = "0";

			Cursor = Cursors.Default;
		}

		private void Btn_Buscar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			CargarGrilla();

			Cursor = Cursors.Default;
		}

		private void Btn_Guardar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			Grabar();
			// LimpiarFormulario();
			tssEstado.Text = "Nuevo";
			txt_id_tipo_doc.Text = "0";

			Cursor = Cursors.Default;
		}

		private void Btn_Minimizar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			scPrincipal.Panel2Collapsed = true;
			tsbGuardar.Enabled = false;

			Cursor = Cursors.Default;
		}

		private void TsmEliminar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			if (MessageBox.Show("¿Desea Eliminar la información?", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
			{
				DataTable dt = (DataTable)dgvGrilla.DataSource;
				DataRow currentRow = dt.Rows[dgvGrilla.CurrentRow.Index];
				SqlCommand cmd = new SqlCommand();
				cmd.CommandText = "pa_TipoDocumento_del " + currentRow[ConfGrilla.id.ToString()].ToString();

				cmd.CommandType = CommandType.Text;

				DataSet dt1;
				dt1 = Conectar.Listar(Clases.clsBD.BD, cmd);

				MessageBox.Show(dt1.Tables[0].Rows[0][1].ToString());
				if (dt1.Tables[0].Rows[0][0].ToString() == "0")
					CargarGrilla();
			}

			Cursor = Cursors.Default;
		}

		private void TsmActualizar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			LlamadoAModificar(dgvGrilla.CurrentRow.Index);

			Cursor = Cursors.Default;
		}

		#endregion

		#region Barra

		private void tsbGuardar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			Grabar();

			Cursor = Cursors.Default;
		}
		private void tsbAgregar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			if (scPrincipal.Panel2Collapsed == true)
				scPrincipal.Panel2Collapsed = false;

			if (scPrincipal.Panel2Collapsed == false)
			{
				tssEstado.Text = "Nuevo";
				tsbGuardar.Enabled = Nuevo || Modificacion;
				LimpiarFormulario();
				txt_id_tipo_doc.Text = "0";

				btn_Guardar.Text = "Grabar";
			}
			else
			{
				tssEstado.Text = "";
				txt_id_tipo_doc.Text = "";
			}

			Cursor = Cursors.Default;
		}


		#endregion


	}
}
