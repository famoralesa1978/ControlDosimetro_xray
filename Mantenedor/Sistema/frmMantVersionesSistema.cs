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
	public partial class frmMantVersionesSistema : Form
	{
		#region "Definicion variable"

		TextBox txtBox = new TextBox();
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
			PK_SISTEMA = 0,
			GVS_NOMBRE = 1,
			GVS_DESCRIPCION = 2,
			GVS_N_VERSION = 3,
			GVS_AMBIENTE = 4,
			GVS_FECHA = 5,
			PK_VSISTEMA = 6
		};

		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		Libreria.clsSqlComun ClaseComun = new Libreria.clsSqlComun();
		LibAdmSistema.ClsConector ConectarAdm = new LibAdmSistema.ClsConector();
		clsEventoControl ClaseEvento = new clsEventoControl();
		dllLibreriaMysql.clsUtiles clsUtiles1 = new dllLibreriaMysql.clsUtiles();
		classFuncionesBD.ClsFunciones ClaseFunciones = new classFuncionesBD.ClsFunciones();

		#endregion

		#region "Inicio"

		public frmMantVersionesSistema()
		{
			InitializeComponent();
		}

		private void frmMantVersionesSistema_Load(object sender, EventArgs e)
		{
			scPrincipal.Panel2Collapsed = true;
			AsignarPermiso();
			Cargar_Reporte();
			Cargar_Ambientes();
			Carga_Propiedades_Controles();
			Cargar_Id_Version_Sistema();
			CargarGrilla();
		}

		#endregion

		#region Procedimiento

		private void Cargar_Reporte()
		{
			ToolStripMenuItem tsiMenu;
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "pa_ListarReporte_Sel " + Id_Menu.ToString();
			DataSet dt;
			dt = null; // Conectar.Listar(Clases.clsBD.BD, cmd);
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

		private void Cargar_Ambientes()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "PA_AMBIENTES_LISTAR";
			DataSet ds;
			ds = ConectarAdm.Listar(null, cmd);

			cbx_GVS_AMBIENTE_Buscar.DataSource = ds.Tables[0];
			cbx_GVS_AMBIENTE_Buscar.ValueMember = ds.Tables[0].Columns[0].Caption.ToString();
			cbx_GVS_AMBIENTE_Buscar.DisplayMember = ds.Tables[0].Columns[1].Caption.ToString();

			cbx_GVS_AMBIENTE.DataSource = ds.Tables[0];
			cbx_GVS_AMBIENTE.ValueMember = ds.Tables[0].Columns[0].Caption.ToString();
			cbx_GVS_AMBIENTE.DisplayMember = ds.Tables[0].Columns[1].Caption.ToString();
		}

		private void Cargar_Id_Version_Sistema()
		{
			txt_PK_SISTEMA.Text = ControlDosimetro.Properties.Settings.Default.Pk_Sistema;

			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "Select isnull(max(PK_VSISTEMA),0)+1 PK_VSISTEMA FROM GES_VERSIONES_SISTEMA";
			DataSet ds;
			ds = ConectarAdm.Listar(null, cmd);
			txt_PK_VSISTEMA.Text = ds.Tables[0].Rows[0]["PK_VSISTEMA"].ToString();
		}

		private void Carga_Propiedades_Controles()
		{
			tsbGuardar.Enabled = false;

			txt_GVS_DESCRIPCION.ScrollBars = ScrollBars.Both;
			txt_GVS_DESCRIPCION.WordWrap = false;

			txt_PK_SISTEMA.Visible = false;
			lbl_PK_SISTEMA.Visible = false;
			txt_PK_VSISTEMA.Visible = false;
			lbl_PK_VSISTEMA.Visible = false;

			dgvGrilla.AutoGenerateColumns = false;
		}

		private void LimpiarFormulario()
		{
			txt_GVS_NOMBRE.Clear();
			txt_GVS_DESCRIPCION.Clear();
			txt_GVS_N_VERSION.Clear();
			txt_PK_VSISTEMA.Clear();
			txt_PK_SISTEMA.Clear();
			cbx_GVS_AMBIENTE.SelectedIndex = 0;
			btn_Guardar.Enabled = Modificacion || Nuevo;
			tsbGuardar.Visible = Modificacion || Nuevo;
			Cargar_Id_Version_Sistema();
		}

		private void Grabar()
		{
			Boolean bolResult;
			bolResult = false;
			string strMensaje="";

			ClaseComun.ValidarFormulario(Clases.clsBD.BD, GES_VERSIONES_SISTEMA, ref bolResult,ref strMensaje);
			if (!bolResult)
			{
				classFuncionesGenerales.mensajes.MensajeError(strMensaje);
				return;
			}

			if (MessageBox.Show("Desea grabar la información", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
			{
				if (tssEstado.Text == "Nuevo")
				{
					ClaseComun.Insertar(Clases.clsBD.BD, GES_VERSIONES_SISTEMA, ref bolResult);
					if (bolResult == true)
					{
						CargarGrilla();
						MessageBox.Show("Dato Guardado");
					}
				}
				else
				if (tssEstado.Text == "Modificar")
				{
					ClaseComun.Modificar(Clases.clsBD.BD, GES_VERSIONES_SISTEMA, ref bolResult);
					if (bolResult == true)
					{
						CargarGrilla();
						MessageBox.Show("Dato modificado");
					}
				}
			}
		}

		private void CargarGrilla()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "PA_GES_VERSIONES_SISTEMA_LISTAR_POR_AMBIENTE " + cbx_GVS_AMBIENTE_Buscar.SelectedValue;
			cmd.CommandType = CommandType.Text;

			DataSet dt;
			dt = ConectarAdm.Listar(null, cmd);
			dgvGrilla.DataSource = dt.Tables[0];
		}

		private void LlamadoAModificar(int intFila)
		{
			DataTable dt = (DataTable)dgvGrilla.DataSource;
			DataRow currentRow = dt.Rows[intFila];

			txt_PK_SISTEMA.Text = currentRow[ConfGrilla.PK_SISTEMA.ToString()].ToString();
			txt_PK_VSISTEMA.Text = currentRow[ConfGrilla.PK_VSISTEMA.ToString()].ToString();

			txt_GVS_NOMBRE.Text = currentRow[ConfGrilla.GVS_NOMBRE.ToString()].ToString();
			txt_GVS_DESCRIPCION.Text = currentRow[ConfGrilla.GVS_DESCRIPCION.ToString()].ToString();
			txt_GVS_N_VERSION.Text = currentRow[ConfGrilla.GVS_N_VERSION.ToString()].ToString();
			cbx_GVS_AMBIENTE.SelectedValue = currentRow[ConfGrilla.GVS_AMBIENTE.ToString()].ToString();


			txt_GVS_NOMBRE.Text = currentRow[ConfGrilla.GVS_NOMBRE.ToString()].ToString();

			tssEstado.Text = "Modificar";
			if (txt_GVS_DESCRIPCION.Text == "")
			{
				btn_Guardar.Enabled = Modificacion || Nuevo;
				tsbGuardar.Visible = Modificacion || Nuevo;
			}
			else
			{
				btn_Guardar.Enabled = Modificacion || Nuevo;
				tsbGuardar.Enabled = Modificacion || Nuevo;
			}
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
			txtBox.Width = GVS_NOMBRE.Width;
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
			bs.Filter = "GVS_NOMBRE like '%" + (sender as TextBox).Text + "%'";
			dgvGrilla.DataSource = bs;
		}

		#endregion

		#region "boton"

		private void btn_Limpiar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			LimpiarFormulario();
			tssEstado.Text = "Nuevo";
			Cursor = Cursors.Default;
		}

		private void btn_Buscar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			CargarGrilla();
			Cursor = Cursors.Default;
		}

		private void btn_Guardar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			Grabar();
			LimpiarFormulario();
			tssEstado.Text = "Nuevo";
			Cursor = Cursors.Default;
		}

		private void btn_Minimizar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			scPrincipal.Panel2Collapsed = true;
			tsbGuardar.Enabled = false;

			Cursor = Cursors.Default;
		}

		private void tsmEliminar_Click(object sender, EventArgs e)
		{
			//Cursor = Cursors.WaitCursor;
			//
			//if (MessageBox.Show("¿Desea Eliminar la información?", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
			//{
			//	DataTable dt = ((DataTable)((BindingSource)((BindingSource)dgvGrilla.DataSource).DataSource).DataSource);
			//	DataRow currentRow = dt.Rows[dgvGrilla.CurrentRow.Index];
			//	SqlCommand cmd = new SqlCommand();
			//	cmd.CommandText = "pa_Perfil_del " + currentRow[ConfGrilla.id.ToString()].ToString();
			//
			//	cmd.CommandType = CommandType.Text;
			//
			//	DataSet dt1;
			//	dt1 = Conectar.Listar(Clases.clsBD.BD, cmd);
			//
			//	MessageBox.Show(dt1.Tables[0].Rows[0][1].ToString());
			//	if (dt1.Tables[0].Rows[0][0].ToString() == "0")
			//		CargarGrilla();
			//}
			//
			//Cursor = Cursors.Default;
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
				tsbGuardar.Enabled = true;
				LimpiarFormulario();
			}
			else
			{
				tssEstado.Text = "";
				txt_GVS_DESCRIPCION.Text = "";
			}

			Cursor = Cursors.Default;

		}

		#endregion

		private void dgvGrilla_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
		{
			txtBox.Width = GVS_NOMBRE.Width;
		}
	}
}
