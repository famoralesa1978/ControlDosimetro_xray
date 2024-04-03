using System;
using System.Data;
using System.Windows.Forms;
using dllConectorMysql;
using dllLibreriaEvento;
using dllLibreriaMysql;
using System.Data.SqlClient;
using Clases;
using System.Text;
using DocumentFormat.OpenXml.Office.Word;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using NPOI.SS.Formula.Functions;
using System.Web.Services.Description;

namespace ControlDosimetro
{
	public partial class frmDireccionAct : Form
	{
		#region "Definicion variable"
		clsConectorSqlServerV2 Conectar = new clsConectorSqlServerV2();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		public int Id;
		public string RutEmpresa;
		public string RazonSocial;
		public int IdCliente;
		int casa_matriz_ins;
		public int intMenu;
		private bool Lectura, Agregar, Modificar, Eliminar;
		#endregion

		#region "Inicio"
		public frmDireccionAct()
		{
			InitializeComponent();
			AsignarEvento();
		}
		private void frmDireccionAct_Load(object sender, EventArgs e)
		{
			AsignarPermiso();
			Cargar_Region();
			if (Id == 0)
				LimpiarFormulario();
			else
			{
				CargarDatos();
			}
		}

		#endregion

		#region Accion
		private void AsignarEvento()
		{
			txtIdCliente.EventoAsignarAvanzar();
			txtRun.EventoAsignarAvanzar();
			txtRunSuc.EventoAsignarRut();
			txtRazonSocial.EventoAsignarAvanzar();
			txtDireccion.EventoAsignarDireccion();
			txtTelefono.EventoAsignarAvanzar();
			txtEmail.EventoAsignarValidarEmail();
			txtDirector.EventoAsignarAvanzar();
			txtOpr.EventoAsignarAvanzar();
			txtOPRRUT.EventoAsignarRut();
			txtServicio.EventoAsignarAvanzar();
			chkEstado.EventoAsignarAvanzar();
			ddlIdRegion.EventoAsignarAvanzar();
			ddlIdProvincia.EventoAsignarAvanzar();
			ddlIdComuna.EventoAsignarAvanzar();
		}
		private void LimpiarFormulario()
		{
			Id = 0;
			txtIdCliente.Text = IdCliente.ToString();
			txtRun.Text = RutEmpresa;
			txtRazonSocial.Text = RazonSocial;
			txtRunSuc.Clear();
			txtRazonSocial.Clear();
			txtDireccion.Clear();
			txtTelefono.Clear();
			txtEmail.Clear();
			txtDirector.Clear();
			txtOpr.Clear();
			txtOPRRUT.Clear();
			txtServicio.Clear();
			chkEstado.Checked = true;
			chk_CasaMatriz.Checked = false;
			ddlIdRegion.SelectedIndex = 0;
			btnCopiar.Visible = false;
			btnEliminar.Enabled = false;
			btnGrabar.Enabled = (Lectura == false && Agregar);
			this.Text = "Agregar Sucursal";
		}
		private void AsignarPermiso()
		{
			Cursor = Cursors.WaitCursor;
			Conectar.PermisoFormulario(intMenu, ref Lectura, ref Agregar, ref Modificar, ref Eliminar);
			Cursor = Cursors.Default;

			btnGrabar.Enabled = ((Lectura == false && Modificar) || (Lectura == false && Agregar));
			btnEliminar.Enabled = Lectura == false && Eliminar;

			Cursor = Cursors.Default;
		}
		private void CargarDatos()
		{

			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "DireccionSel_Id";
			cmd.Parameters.Add("@Id_sucursal", SqlDbType.Int);
			cmd.Parameters["@Id_sucursal"].Value = Id;
			cmd.CommandType = CommandType.StoredProcedure;

			DataSet dt;
			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

			if (dt != null)
			{
				if (dt.Tables[0].Rows.Count > 0)
				{

					txtIdCliente.Text = dt.Tables[0].Rows[0]["id_cliente"].ToString();
					IdCliente = Convert.ToInt16(dt.Tables[0].Rows[0]["id_cliente"].ToString());
					RutEmpresa = txtRun.Text = dt.Tables[0].Rows[0]["run"].ToString();
					RazonSocial = dt.Tables[0].Rows[0]["RazonSocialCliente"].ToString();
					txtRunSuc.Text = dt.Tables[0].Rows[0]["runsuc"].ToString();
					txtRazonSocial.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
					txtDireccion.Text = dt.Tables[0].Rows[0]["Direccion"].ToString();
					txtTelefono.Text = dt.Tables[0].Rows[0]["Telefono"].ToString();
					txtEmail.Text = dt.Tables[0].Rows[0]["Email"].ToString();
					txtDirector.Text = dt.Tables[0].Rows[0]["Director"].ToString();
					txtOpr.Text = dt.Tables[0].Rows[0]["Opr"].ToString();
					txtOPRRUT.Text = dt.Tables[0].Rows[0]["OPR_RUT"].ToString();
					txtServicio.Text = dt.Tables[0].Rows[0]["Servicio"].ToString();
					chkEstado.Checked = (bool)dt.Tables[0].Rows[0]["Estado"];
					chk_CasaMatriz.Checked = Convert.ToBoolean( dt.Tables[0].Rows[0]["estado_casa_matriz"]);
					ddlIdRegion.SelectedValue = Convert.ToInt16(dt.Tables[0].Rows[0]["Id_Region"].ToString());
					ddlIdProvincia.SelectedValue = Convert.ToInt16(dt.Tables[0].Rows[0]["Id_Provincia"].ToString());
					ddlIdComuna.SelectedValue = Convert.ToInt16(dt.Tables[0].Rows[0]["Id_Comuna"].ToString());
					btnCopiar.Enabled = true;
					btnEliminar.Enabled = Lectura == false && Eliminar;
					btnGrabar.Enabled = (Lectura == false && Modificar);
					this.Text = "Modificar Sucursal";
				}
			}

		}

		private void Grabar()
		{
			bool Resultado = false;
			if (Id == 0)
				Resultado = Insertar();
			else
				Resultado = Actualizar();

			if (Resultado)
				CargarDatos();
		}

		private bool Insertar()
		{
			string strMensajeError = "";
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "DireccionIns";
			cmd.Parameters.Add("@Id_sucursal", SqlDbType.Int);
			cmd.Parameters["@Id_sucursal"].Value = Id;
			cmd.Parameters.Add("@id_cliente", SqlDbType.Int);
			cmd.Parameters["@id_cliente"].Value = IdCliente;
			cmd.Parameters.Add("@run", SqlDbType.VarChar, 11);
			cmd.Parameters["@run"].Value = RutEmpresa;
			cmd.Parameters.Add("@runsuc", SqlDbType.VarChar, 11);
			cmd.Parameters["@runsuc"].Value = txtRunSuc.Text;
			cmd.Parameters.Add("@Razon_Social", SqlDbType.VarChar, 60);
			cmd.Parameters["@Razon_Social"].Value = txtRazonSocial.Text;
			cmd.Parameters.Add("@Direccion", SqlDbType.VarChar, 100);
			cmd.Parameters["@Direccion"].Value = txtDireccion.Text;
			cmd.Parameters.Add("@Id_Region", SqlDbType.Int);
			cmd.Parameters["@Id_Region"].Value = ddlIdRegion.SelectedValue;
			cmd.Parameters.Add("@Id_Provincia", SqlDbType.Int);
			cmd.Parameters["@Id_Provincia"].Value = ddlIdProvincia.SelectedValue;
			cmd.Parameters.Add("@Id_Comuna", SqlDbType.Int);
			cmd.Parameters["@Id_Comuna"].Value = ddlIdComuna.SelectedValue;
			cmd.Parameters.Add("@Telefono", SqlDbType.VarChar, 15);
			cmd.Parameters["@Telefono"].Value = txtTelefono.Text;
			cmd.Parameters.Add("@estado_casa_matriz", SqlDbType.Int);
			cmd.Parameters["@estado_casa_matriz"].Value = chk_CasaMatriz.Checked ? 1 : 0;
			cmd.Parameters.Add("@Email", SqlDbType.VarChar, 100);
			cmd.Parameters["@Email"].Value = txtEmail.DevuelveCadenaNulo();
			cmd.Parameters.Add("@Director", SqlDbType.VarChar, 50);
			cmd.Parameters["@Director"].Value = txtDireccion.DevuelveCadenaNulo();
			cmd.Parameters.Add("@Opr", SqlDbType.VarChar, 50);
			cmd.Parameters["@Opr"].Value = txtOpr.DevuelveCadenaNulo();
			cmd.Parameters.Add("@OPR_RUT", SqlDbType.VarChar, 11);
			cmd.Parameters["@OPR_RUT"].Value = txtOPRRUT.DevuelveCadenaNulo();
			cmd.Parameters.Add("@Servicio", SqlDbType.VarChar, 100);
			cmd.Parameters["@Servicio"].Value = txtOPRRUT.DevuelveCadenaNulo();
			cmd.Parameters.Add("@Estado", SqlDbType.Bit);
			cmd.Parameters["@Estado"].Value =chkEstado.Checked;

			cmd.CommandType = CommandType.StoredProcedure;
			Conectar.Agregar(ClaseGeneral.Conexion, cmd, "Id_sucursal", ref strMensajeError);

			if (!string.IsNullOrWhiteSpace(strMensajeError))
			{
				Cursor = Cursors.Default;
				ClaseGeneral.GuardarLOG(this.Name, "DireccionIns", "Grabar");
				return false;
			}
			return true;
		}
		private bool Actualizar()
		{
			string strMensajeError = "";
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "DireccionUpd";
			cmd.Parameters.Add("@Id_sucursal", SqlDbType.Int);
			cmd.Parameters["@Id_sucursal"].Value = Id;
			cmd.Parameters.Add("@id_cliente", SqlDbType.Int);
			cmd.Parameters["@id_cliente"].Value = IdCliente;
			cmd.Parameters.Add("@run", SqlDbType.VarChar, 11);
			cmd.Parameters["@run"].Value = RutEmpresa;
			cmd.Parameters.Add("@runsuc", SqlDbType.VarChar, 11);
			cmd.Parameters["@runsuc"].Value = txtRunSuc.Text;
			cmd.Parameters.Add("@Razon_Social", SqlDbType.VarChar, 60);
			cmd.Parameters["@Razon_Social"].Value = txtRazonSocial.Text;
			cmd.Parameters.Add("@Direccion", SqlDbType.VarChar, 100);
			cmd.Parameters["@Direccion"].Value = txtDireccion.Text;
			cmd.Parameters.Add("@Id_Region", SqlDbType.Int);
			cmd.Parameters["@Id_Region"].Value = ddlIdRegion.SelectedValue;
			cmd.Parameters.Add("@Id_Provincia", SqlDbType.Int);
			cmd.Parameters["@Id_Provincia"].Value = ddlIdProvincia.SelectedValue;
			cmd.Parameters.Add("@Id_Comuna", SqlDbType.Int);
			cmd.Parameters["@Id_Comuna"].Value = ddlIdComuna.SelectedValue;
			cmd.Parameters.Add("@Telefono", SqlDbType.VarChar, 15);
			cmd.Parameters["@Telefono"].Value = txtTelefono.Text;
			cmd.Parameters.Add("@estado_casa_matriz", SqlDbType.Int);
			cmd.Parameters["@estado_casa_matriz"].Value = chk_CasaMatriz.Checked ? 1 : 0;
			cmd.Parameters.Add("@Email", SqlDbType.VarChar, 100);
			cmd.Parameters["@Email"].Value = txtEmail.DevuelveCadenaNulo();
			cmd.Parameters.Add("@Director", SqlDbType.VarChar, 50);
			cmd.Parameters["@Director"].Value = txtDireccion.DevuelveCadenaNulo();
			cmd.Parameters.Add("@Opr", SqlDbType.VarChar, 50);
			cmd.Parameters["@Opr"].Value = txtOpr.DevuelveCadenaNulo();
			cmd.Parameters.Add("@OPR_RUT", SqlDbType.VarChar, 11);
			cmd.Parameters["@OPR_RUT"].Value = txtOPRRUT.DevuelveCadenaNulo();
			cmd.Parameters.Add("@Servicio", SqlDbType.VarChar, 100);
			cmd.Parameters["@Servicio"].Value = txtOPRRUT.DevuelveCadenaNulo();
			cmd.Parameters.Add("@Estado", SqlDbType.Bit);
			cmd.Parameters["@Estado"].Value = chkEstado.Checked;

			cmd.CommandType = CommandType.StoredProcedure;
			Conectar.Modificar(ClaseGeneral.Conexion, cmd,  ref strMensajeError);

			if (!string.IsNullOrWhiteSpace(strMensajeError))
			{
				Cursor = Cursors.Default;
				ClaseGeneral.GuardarLOG(this.Name, "DireccionUpd", "Grabar");
				return false;
			}
			return true;
		}
		#endregion

		#region "Llamada de carga"  
		private void Cargar_Region()
		{
			ClaseComun.Listar_Region(Clases.clsBD.BD, ref ddlIdRegion, ref ddlIdRegion);
		}

		private void Cargar_Provincia()
		{
			ClaseComun.Listar_Provincia(Clases.clsBD.BD, ref ddlIdProvincia, ref ddlIdProvincia, Convert.ToInt16(ddlIdRegion.SelectedValue));
		}

		private void Cargar_Comuna()
		{
			ClaseComun.Listar_Comuna(Clases.clsBD.BD, ref ddlIdComuna, ref ddlIdComuna, Convert.ToInt16(ddlIdRegion.SelectedValue), Convert.ToInt16(ddlIdProvincia.SelectedValue));
		}

		#endregion

		#region "button"
		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if ("¿Esta seguro eliminar los registros?".XMensajeConfirmacionSiNo())
			{
				string strMensajeError = "";
				SqlCommand cmd = new SqlCommand();
				cmd.CommandText = "DireccionDel";
				cmd.Parameters.Add("@Id_sucursal", SqlDbType.Int);
				cmd.Parameters["@Id_sucursal"].Value = Id;


				cmd.CommandType = CommandType.StoredProcedure;
				Conectar.AgregarModificarEliminar(ClaseGeneral.Conexion, cmd, ref strMensajeError);
				if (!string.IsNullOrWhiteSpace(strMensajeError))
				{
					Cursor = Cursors.Default;
					strMensajeError.ToString().XMensajeError();
					ClaseGeneral.GuardarLOG(this.Name, "DireccionDel", "Grabar");
					return;
				}
				else
					Id = 0;
			}
			LimpiarFormulario();
		}

		private void btnCopiar_Click(object sender, EventArgs e)
		{
			this.Text = "Agregar Sucursal";
			Id = 0;	
			btnCopiar.Visible = false;
			casa_matriz_ins = 0;
		}

		private void btn_cerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_Grabar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			StringBuilder sb = new StringBuilder();
			if (pnlSucursal.XValidarPanel(ref sb))
			{
				Cursor = Cursors.Default;
				sb.Insert(0, "Lista de errores :");
				sb.ToString().XMensajeError();
				return;
			}
			Grabar();

			Cursor = Cursors.Default;

		}

		#endregion

		#region "combobox"

		private void cbx_id_region_SelectedIndexChanged(object sender, EventArgs e)
		{
			Cargar_Provincia();

		}

		private void cbx_provincia_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cbx_id_provincia_SelectedIndexChanged(object sender, EventArgs e)
		{
			Cargar_Comuna();
		}
		#endregion

		#region TextBox
		private void txt_direccion_Leave(object sender, EventArgs e)
		{
			txtDireccion.Text = txtDireccion.Text.ToString().Replace("/", "").ToString();
		}

		#endregion

	}
}
