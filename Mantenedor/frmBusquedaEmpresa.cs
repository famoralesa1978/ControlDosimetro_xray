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
	public partial class frmBusquedaEmpresa : Form
	{

		#region "Definicion variable"
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();
		Clases.ClassEvento clsEvento = new Clases.ClassEvento();
		classFuncionesBD.ClsFunciones ClaseFunciones = new classFuncionesBD.ClsFunciones();

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

		#endregion

		public frmBusquedaEmpresa()
		{
			InitializeComponent();
			AsignarEvento();
			
		}

		private void frmBusquedaEmpresa_Load(object sender, EventArgs e)
		{
			HablitarBarra(false);
			AsignarPermiso();
			Cargar_Reporte();
			Cargar_Estado();
			
		}

		#region "Llamada de carga"

		private void AsignarPermiso()
		{
			ClaseFunciones.Cargar_Permiso(Clases.clsUsuario.Id_perfil, Id_Menu, ref Lectura, ref Nuevo, ref Modificacion, ref Eliminar);
			tsbAgregarCliente.Visible = Nuevo;
			tsbAgregarPersonal.Visible = Nuevo;
			tsmEliminar.Visible= tsb_Eliminar.Visible = Eliminar;
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


		string FormarFiltro()
		{
			string Filtro = "";

			if (!String.IsNullOrWhiteSpace(txt_Rut.Text))
				Filtro += Filtro != "" ? " and run like '%" + txt_Rut.Text + "%'" : " run like '%" + txt_Rut.Text + "%'";
			if (!String.IsNullOrWhiteSpace(txt_RazonSocial.Text))
				Filtro += Filtro != "" ? " and razon_social like '%" + txt_RazonSocial.Text + "%'" : "razon_social like '%" + txt_RazonSocial.Text + "%'";
			if (!String.IsNullOrWhiteSpace(txt_RazonSocial.Text))
				Filtro += Filtro != "" ? " and razon_social like '%" + txt_RazonSocial.Text + "%'" : "razon_social like '%" + txt_RazonSocial.Text + "%'";
			if (!String.IsNullOrWhiteSpace(txt_N_Cliente_Ref.Text))
				Filtro += Filtro != "" ? " and id_cliente =" + txt_N_Cliente_Ref.Text + "" : "id_cliente =" + txt_N_Cliente_Ref.Text + "";
			if (!String.IsNullOrWhiteSpace(txt_Direccion.Text))
				Filtro += Filtro != "" ? " and Direccion like '%" + txt_Direccion.Text + "%'" : "Direccion like '%" + txt_Direccion.Text + "%'";
			if (!String.IsNullOrWhiteSpace(txt_NombreFantasia.Text))
				Filtro += Filtro != "" ? " and Nombre_fantasia like '%" + txt_NombreFantasia.Text + "%'" : "Nombre_fantasia like '%" + txt_NombreFantasia.Text + "%'";

			return Filtro != "" ? " and " + Filtro : " " + Filtro;
		}

		private void Listar_Cliente()
		{
			Cursor = Cursors.WaitCursor;
			//  SqlCommand cmd = new SqlCommand()
			SqlCommand cmd = new SqlCommand();

			cmd.CommandText = "select id_cliente,run,razon_social,Direccion,telefono,Nombre_fantasia " +
													"from tbl_cliente " +
													"where  id_estado=" + cbx_Estado.SelectedValue + FormarFiltro() + " order by id_cliente";
			cmd.CommandType = CommandType.Text;


			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			grdDatos.DataSource = dt.Tables[0];

			HablitarBarra(dt.Tables[0].Rows.Count > 0 ? true : false);
			Cursor = Cursors.Default;
		}

		void HablitarBarra(bool bolEstado)
		{
			tsbAgregarReferencia.Enabled = bolEstado;
			tsbAgregarPersonal.Enabled = bolEstado;
			tsbIngresoDosimetro.Enabled = bolEstado;
			tsbEmail.Enabled = bolEstado;
			btnIngresarDosisISP.Enabled = bolEstado;
		}

		private void AsignarEvento()
		{
			this.txt_Rut.KeyPress += new KeyPressEventHandler(ClaseEvento.Rut_KeyPress);
			txt_Rut.KeyDown += new KeyEventHandler(ClaseEvento.Rut_KeyDown);
			txt_Rut.Validated += new EventHandler(ClaseEvento.validarut_Validated);


			this.txt_N_Cliente_Ref.KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
			txt_N_Cliente_Ref.KeyDown += new KeyEventHandler(ClaseEvento.Numero_KeyDown);

			txt_RazonSocial.KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);

			cbx_Estado.KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);
			clsEvento.AsignarDireccion(ref txt_Direccion);
		}

		private void Cargar_Estado()
		{
			ClaseComun.Listar_Estado(Clases.clsBD.BD, ref cbx_Estado, ref cbx_Estado);
		}

		private void Configurar_Grilla()
		{

		}

		private void Modificar(){
			frmEmpresaMant frm = new frmEmpresaMant(Convert.ToInt64(grdDatos.SelectedCells[0].Value.ToString()));
			frm.ShowDialog(this);
			Listar_Cliente();
		}

		#endregion

		#region "button"
		private void btn_Buscar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			Listar_Cliente();

			Cursor = Cursors.Default;


		}

		private void btn_Agregar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			frmEmpresaMant frm = new frmEmpresaMant(0);
			frm.ShowDialog(this);
			Listar_Cliente();

			Cursor = Cursors.Default;
		}

		private void tsbAgregarReferencia_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			frmBusquedaReferencia frm = new frmBusquedaReferencia(Convert.ToInt64(grdDatos.SelectedCells[0].Value.ToString()));
			frm.ShowDialog(this);

			Cursor = Cursors.Default;
		}

		private void tsbAgregarPersonal_Click(object sender, EventArgs e)
		{

			Cursor = Cursors.WaitCursor;

			frmBusquedaPersonal frm = new frmBusquedaPersonal(Convert.ToInt64(grdDatos.SelectedCells[0].Value.ToString()));
			frm.ShowDialog(this);

			Cursor = Cursors.Default;
		}

		private void tsbIngresoDosimetro_Click(object sender, EventArgs e)
		{

			Cursor = Cursors.WaitCursor;

			frmIngresoDosimetria frm = new frmIngresoDosimetria(Convert.ToInt64(grdDatos.SelectedCells[0].Value.ToString()));
			frm.ShowDialog(this);

			Cursor = Cursors.Default;
		}

		private void btnIngresarDosisISP_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			frmDosimetriaISP frm = new frmDosimetriaISP(Convert.ToInt64(grdDatos.SelectedCells[0].Value.ToString()));
			frm.ShowDialog(this);

			Cursor = Cursors.Default;
		}

		private void btnIngresarPelicula_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			frmIngresoPelicula frm = new frmIngresoPelicula(Convert.ToInt64(grdDatos.SelectedCells[0].Value.ToString()));
			frm.ShowDialog(this);

			Cursor = Cursors.Default;

		}

		#endregion

		#region "combobox"
		private void cbx_id_estado_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbx_Estado.SelectedValue.ToString() == "1")
				tsbIngresoDosimetro.Visible = true;
			else
				tsbIngresoDosimetro.Visible = false;
		}

		#endregion

		#region "grilla"

		private void grdDatos_DoubleClick(object sender, EventArgs e)
		{
			Modificar();
		}

		#endregion

		#region "barra"

		private void tsb_Eliminar_Click(object sender, EventArgs e)
		{
			string strMensaje = "";
			if (MessageBox.Show("Desea eliminar el cliente?", "Eliminación del cliente", MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				for (int intFila = 0; intFila < grdDatos.SelectedRows.Count; intFila++)
				{
					int intIdPersonal = Convert.ToUInt16(grdDatos.Rows[intFila].Cells[0].Value);
					SqlCommand cmd = new SqlCommand();
					cmd.CommandText = "pa_EliminarCliente_del " + intIdPersonal.ToString();
					cmd.CommandType = CommandType.Text;
					DataSet dt;
					dt = Conectar.Listar(Clases.clsBD.BD, cmd);
					if (dt.Tables[0].Rows.Count == 0)
					{
						MessageBox.Show("No se han cargado ningun cliente");
					}
					else
					{
						if (dt.Tables[0].Rows[0][1].ToString() == "0")
							strMensaje += strMensaje == "" ? grdDatos.Rows[intFila].Cells[1].Value : ", " + grdDatos.Rows[intFila].Cells[1].Value;
					}
				}

				if (strMensaje != "")
					MessageBox.Show("No se puede eliminar los siguiente rut, hay datos relacionados : \n" + strMensaje);

				btn_Buscar_Click(null, null);
			}
		}

		private void tsbSeccion_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			frmMantenedorSeccion frm = new frmMantenedorSeccion(Convert.ToInt16(grdDatos.SelectedCells[0].Value.ToString()));
			frm.ShowDialog(this);

			Cursor = Cursors.Default;
		}
		private void tsmEliminar_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand();

			cmd.CommandText = "pa_EliminarCliente_del " + grdDatos.SelectedCells[0].Value.ToString() ;
			cmd.CommandType = CommandType.Text;
			DataSet ds;

			ds = Conectar.Listar(Clases.clsBD.BD, cmd);
			if (ds.Tables[0].Rows.Count > 0)
			{

				if ((int)ds.Tables[0].Rows[0]["Resultado"] == 0)
				{
					classFuncionesGenerales.mensajes.MensajeAdvertencia("Cliente se dejo Inactivo, Debe ingresar una observación porque se dejo inactivo");
					frmObservacionCliente frm1 = new frmObservacionCliente(grdDatos.SelectedCells[0].Value.ToString(), ds.Tables[0].Rows[0]["FechaInicio"].ToString());
					frm1.ShowDialog(this);
				}
				else
					classFuncionesGenerales.mensajes.MensajeAdvertencia(ds.Tables[0].Rows[0]["Mensaje"].ToString());



			}
			Listar_Cliente();
		}

		private void txt_Rut_TextChanged(object sender, EventArgs e)
		{

		}

		private void tsmModificar_Click(object sender, EventArgs e)
		{
			Modificar();
		}

		private void tsbEmail_Click(object sender, EventArgs e)
		{
			object[] objParams = { grdDatos.SelectedCells[1].Value.ToString() };
			frmMantenedorClienteCorreo frm = new frmMantenedorClienteCorreo();
			frm.Parametros = objParams;
			frm.ShowDialog();

		}


		#endregion

	}
}
