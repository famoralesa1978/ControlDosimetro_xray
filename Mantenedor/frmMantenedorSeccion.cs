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
	public partial class frmMantenedorSeccion : Form
	{
		#region "Definicion variable"

		TextBox txtBox = new TextBox();
		int Id_Cliente;
		bool Lectura;
		bool Nuevo;
		bool Modificacion;
		bool Eliminar;


		public int Id_Menu { get; private set; }
		classFuncionesBD.ClsFunciones Func = new classFuncionesBD.ClsFunciones();

		enum ConfGrilla : int
		{
			id_Seccion = 0,
			seccion = 1,
			Id_estado = 2
		};

		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();
		dllLibreriaMysql.clsUtiles clsUtiles1 = new dllLibreriaMysql.clsUtiles();
		classFuncionesBD.ClsFunciones ClaseFunciones = new classFuncionesBD.ClsFunciones();

		#endregion

		#region "Inicio"

		public frmMantenedorSeccion(int intId_Cliente)
		{
			InitializeComponent();
			Id_Menu = (int)MDIPrincipal.MENU.mnuMantSeccion;
			Id_Cliente = intId_Cliente;
			Func.Cargar_Cliente((long)Id_Cliente,ref lbl_Run, ref lbl_Nombre);
			lbl_id_cliente.Text = intId_Cliente.ToString();
		}

		private void frmMantenedorSeccion_Load(object sender, EventArgs e)
		{
			scPrincipal.Panel2Collapsed = true;
			AsignarPermiso();
			Cargar_Reporte();
			Cargar_Estado();
			dgvGrilla.AutoGenerateColumns = false;
			CargarGrilla(Id_Cliente);
		}

		#endregion

		#region Procedimiento

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
			btn_Guardar.Visible = tsbGuardar.Visible = Nuevo || Modificacion;
			tsmEliminar.Visible = Eliminar;
		}

		private void Cargar_Estado()
		{
			ClaseComun.Listar_Estado(Clases.clsBD.BD, ref cbx_id_estado_Buscar, ref cbx_id_estado_Buscar);
			ClaseComun.Listar_Estado(Clases.clsBD.BD, ref cbx_id_estado, ref cbx_id_estado);
		}

		private void LimpiarFormulario()
		{
			txt_seccion.Clear();
			txt_id_seccion.Clear();
			cbx_id_estado.SelectedIndex = 0;
			tsbGuardar.Visible = Modificacion || Nuevo;
		}

		private void Grabar()
		{
			Boolean bolResult;
			bolResult = false;
			string strMensaje = "";

			ClaseComun.ValidarFormulario(Clases.clsBD.BD, tbl_seccion, ref bolResult, ref strMensaje);
			if (!String.IsNullOrEmpty( strMensaje))
			{
				classFuncionesGenerales.mensajes.MensajeError(strMensaje);
				return;
			}

			if (MessageBox.Show("Desea grabar la información", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
			{
				if ((tssEstado.Text == "Nuevo") && (txt_id_seccion.Text == "0"))
				{
					ClaseComun.Insertar(Clases.clsBD.BD, tbl_seccion, ref bolResult);
					if (bolResult == true)
					{
						CargarGrilla(Id_Cliente);
						MessageBox.Show("Dato Guardado");
					}
				}
				else
				if (tssEstado.Text == "Modificar")
				{
					ClaseComun.Modificar(Clases.clsBD.BD, tbl_seccion, ref bolResult);
					if (bolResult == true)
					{
						CargarGrilla(Id_Cliente);
						MessageBox.Show("Dato modificado");
					}
				}
			}
		}

		private void CargarGrilla(int intId_Cliente)
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = String.Format("select id_Seccion,seccion,Id_Estado,id_cliente from tbl_seccion  where id_estado={0} and id_cliente={1} and run='{2}' order by seccion", cbx_id_estado_Buscar.SelectedValue, intId_Cliente, lbl_Run.Text);

			cmd.CommandType = CommandType.Text;

			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			dgvGrilla.DataSource = dt.Tables[0];

		}

		private void LlamadoAModificar(int intFila)
		{
			DataTable dt = (DataTable)dgvGrilla.DataSource;
			DataRow currentRow = dt.Rows[intFila];
			txt_id_seccion.Text = currentRow[ConfGrilla.id_Seccion.ToString()].ToString();
			txt_seccion.Text = currentRow[ConfGrilla.seccion.ToString()].ToString();
			cbx_id_estado.SelectedValue = currentRow[ConfGrilla.Id_estado.ToString()].ToString();
			tssEstado.Text = "Modificar";
			btn_Guardar.Visible= tsbGuardar.Visible = Modificacion;
			scPrincipal.Panel2Collapsed = false;
		}

		#endregion

		#region " grilla"

		private void dgvGrilla_Paint(object sender, PaintEventArgs e)
		{
			int columnIndex = 0;
			Point headerCellLocation = this.dgvGrilla.GetCellDisplayRectangle(columnIndex, -1, true).Location;
			txtBox.Location = new Point(headerCellLocation.X, headerCellLocation.Y + 20);
			txtBox.BackColor = Color.AliceBlue;
			txtBox.Width = Colperfil1.Width;
			txtBox.TextChanged += new EventHandler(TextBox_Changed);
			dgvGrilla.Controls.Add(txtBox);
		}

		private void dgvGrilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int intFila = e.RowIndex;
			LlamadoAModificar(intFila);
		}

		private void TextBox_Changed(object sender, EventArgs e)
		{
			BindingSource bs = new BindingSource();
			bs.DataSource = dgvGrilla.DataSource;
			bs.Filter = "seccion like '%" + (sender as TextBox).Text + "%'";
			dgvGrilla.DataSource = bs;
		}

		#endregion

		#region "boton"
		private void btn_Limpiar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			LimpiarFormulario();
			tssEstado.Text = "Nuevo";
			txt_id_seccion.Text = "0";

			Cursor = Cursors.Default;
		}

		private void btn_Buscar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			CargarGrilla(Id_Cliente);

			Cursor = Cursors.Default;
		}

		private void btn_Guardar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "pa_ValidarSeccionEliminar_del " + txt_id_seccion.Text ;

			cmd.CommandType = CommandType.Text;

			DataSet dt1;
			dt1 = Conectar.Listar(Clases.clsBD.BD, cmd);

			if ((dt1.Tables[0].Rows.Count>0)&&((int)cbx_id_estado.SelectedValue==0))
			{
				if(Convert.ToInt16(dt1.Tables[0].Rows[0]["Cantidad"].ToString())>0)
				{
					classFuncionesGenerales.mensajes.MensajeError(String.Format("Existen {0} personal con esta seccion, Cambie de sección antes dejarlo inactivo ", dt1.Tables[0].Rows[0]["Cantidad"]));
					Cursor = Cursors.Default;
				}
				else
				{
					Grabar();
					LimpiarFormulario();
					tssEstado.Text = "Nuevo";
					txt_id_seccion.Text = "0";
				}
			}
			else
			{
				Grabar();
				LimpiarFormulario();
				tssEstado.Text = "Nuevo";
				txt_id_seccion.Text = "0";
			}

		

			Cursor = Cursors.Default;
		}

		private void btn_Minimizar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			scPrincipal.Panel2Collapsed = true;

			Cursor = Cursors.Default;
		}

		private void tsmEliminar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			if (MessageBox.Show("¿Desea Eliminar la información?", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
			{
				DataTable dt = ((DataTable)((BindingSource)((BindingSource)dgvGrilla.DataSource).DataSource).DataSource);
				DataRow currentRow = dt.Rows[dgvGrilla.CurrentRow.Index];
				SqlCommand cmd = new SqlCommand();
				cmd.CommandText = "pa_Seccion_del " + currentRow[ConfGrilla.id_Seccion.ToString()].ToString();

				cmd.CommandType = CommandType.Text;

				DataSet dt1;
				dt1 = Conectar.Listar(Clases.clsBD.BD, cmd);

				MessageBox.Show(dt1.Tables[0].Rows[0][1].ToString());
				if (dt1.Tables[0].Rows[0][0].ToString() == "0")
					CargarGrilla(Id_Cliente);
			}

			Cursor = Cursors.Default;
		}

		private void tsmActualizar_Click(object sender, EventArgs e)
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
				LimpiarFormulario();
				btn_Guardar.Visible = tsbGuardar.Visible = Nuevo;
			txt_id_seccion.Text = "0";
			}
			else
			{
				tssEstado.Text = "";
				txt_id_seccion.Text = "";
			}

			Cursor = Cursors.Default;

		}


		#endregion

		private void dgvGrilla_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
		{
			txtBox.Width = Colperfil1.Width;
		}
	}
}
