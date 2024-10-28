using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using dllLibreriaMysql;
using System.Data.SqlClient;
using System.IO;

namespace ControlDosimetro
{
	public partial class frmEmpresaMant : Form
	{
		#region "Definicion variable"
		clsConectorSqlServerV2 Conectar2 = new clsConectorSqlServerV2();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		Clases.ClassEvento clsEvento = new Clases.ClassEvento();
		public int intMenu;
		private bool Lectura, Agregar, Modificar, Eliminar;
		dllLibreriaMysql.clsUtiles clsUtiles1 = new dllLibreriaMysql.clsUtiles();
		#endregion

		#region Inicio
		public frmEmpresaMant(Int64 intCodigo, string Rut)
		{
			InitializeComponent();
			AsignarEvento();
			Cargar_parametro();
			Cargar_tipoEntidad();
			Cargar_Ministerio();
			Cargar_Region();
			Cargar_Estado();
			Cargar_Fecha();
			Cargar_Sector();
			btn_Excel.Visible = false;
			if (intCodigo == 0)
			{
				btn_Grabar.Text = "Grabar";
				this.Text = "Agregar Cliente";
				txt_id_cliente.Enabled = true;
				ddl_id_estado.Enabled = false;
				txt_Clave.Visible = true;
				lbl_Clave.Visible = true;
				dtp_FechaInicio.Text = ddl_id_periodo.Text;
				btn_Excel.Visible = true;
				//cargar_valor_maximo();
				//
			}
			else
			{
				btn_Grabar.Text = "Modificar";
				this.Text = "Modificar Cliente";
				txt_id_cliente.Text = intCodigo.ToString();
				txt_id_cliente.Tag = intCodigo.ToString();
				txt_id_cliente.Enabled = false;
				txt_Clave.Visible = false;
				lbl_Clave.Visible = false;
				txt_run.Text = Rut;
				// SqlCommand cmd = new SqlCommand();
				SqlCommand cmd = new SqlCommand();

				cmd.CommandText = "pa_Cliente_selId";
				cmd.Parameters.Clear();
				cmd.Parameters.Add("@Id_cliente", SqlDbType.Int);
				cmd.Parameters["@Id_cliente"].Value = intCodigo;
				cmd.Parameters.Add("@run", SqlDbType.VarChar, 12);
				cmd.Parameters["@run"].Value = Rut;

				cmd.CommandType = CommandType.StoredProcedure;
				DataSet dt;
				dt = Conectar2.Listar(ClaseGeneral.Conexion, cmd);

				txt_Director.Text = dt.Tables[0].Rows[0]["Director"].ToString();
				txt_Opr.Text = dt.Tables[0].Rows[0]["Opr"].ToString();
				txt_OPR_RUT.Text = dt.Tables[0].Rows[0]["OPR_RUT"].ToString();
				try
				{
					ddl_Id_Sector.SelectedValue = dt.Tables[0].Rows[0]["Id_Sector"].ToString();
				}
				catch
				{
					ddl_Id_Sector.SelectedIndex = -1;
				}
				try
				{
					ddl_Id_TipoEntidad.SelectedValue = dt.Tables[0].Rows[0]["Id_TipoEntidad"].ToString();
				}
				catch
				{
					ddl_Id_TipoEntidad.SelectedIndex = -1;
				}
				try
				{
					cbx_Id_TipoFuente.SelectedValue = dt.Tables[0].Rows[0]["Id_TipoFuente"].ToString();
				}
				catch
				{
					cbx_Id_TipoFuente.SelectedIndex = -1;
				}
				try
				{
					ddl_id_Ministerio.SelectedValue = dt.Tables[0].Rows[0]["id_Ministerio"].ToString();
				}
				catch
				{
					ddl_id_Ministerio.SelectedIndex = -1;
				}

				txt_run.Text = dt.Tables[0].Rows[0]["run"].ToString();
				txt_N_Cliente_Ref.Text = dt.Tables[0].Rows[0]["N_Cliente_Ref"].ToString();
				txt_Nombre_fantasia.Text = dt.Tables[0].Rows[0]["Nombre_Fantasia"].ToString();
				txt_Razon_Social.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
				txt_direccion.Text = dt.Tables[0].Rows[0]["Direccion"].ToString();
				txt_telefono.Text = dt.Tables[0].Rows[0]["Telefono"].ToString();
				ddl_id_region.SelectedValue = dt.Tables[0].Rows[0]["Id_Region"].ToString();
				Cargar_Provincia();
				ddl_id_provincia.SelectedValue = dt.Tables[0].Rows[0]["Id_Provincia"].ToString();
				Cargar_Comuna();
				ddl_id_comuna.SelectedValue = dt.Tables[0].Rows[0]["Id_Comuna"].ToString();
				txt_Email.Text = dt.Tables[0].Rows[0]["Email"].ToString();
				txt_Emailfacturacion.Text = dt.Tables[0].Rows[0]["EmailFacturacion"].ToString(); 
				ddl_id_estado.SelectedValue = dt.Tables[0].Rows[0]["Id_estado"].ToString();
				lbl_Estado_mod.Text = ddl_id_estado.Text;
				dtp_FechaInicio.Value = Convert.ToDateTime(dt.Tables[0].Rows[0]["Fechainicio"]);

				ddl_id_periodo.Text = dt.Tables[0].Rows[0]["Fechainicio"].ToString();
				txt_Clave.Text = dt.Tables[0].Rows[0]["clave"].ToString();
				txt_Clave.Visible = false;
				lbl_Clave.Visible = false;

				txt_Servicio.Text = dt.Tables[0].Rows[0]["servicio"].ToString();
				if (dt.Tables[0].Rows[0]["Id_estado"].ToString() == "1")
				{
					txt_run.Enabled = false;
					ddl_id_periodo.Enabled = true;
				}
				else
				{
					txt_run.Enabled = true;
					ddl_id_periodo.Enabled = false;
				}

			}
		}

		private void frmEmpresaMant_Load(object sender, EventArgs e)
		{
			AsignarPermiso();
		}
		#endregion


		#region "Llamada de carga"  
		private void AsignarPermiso()
		{
			Cursor = Cursors.WaitCursor;
			Conectar2.PermisoFormulario(intMenu, ref Lectura, ref Agregar, ref Modificar, ref Eliminar);
			Cursor = Cursors.Default;

			btn_Grabar.Enabled = ((Lectura == false && Modificar) || (Lectura == false && Agregar));

			Cursor = Cursors.Default;
		}
		private void Cargar_Estado()
		{
			ClaseComun.Listar_Estado(ClaseGeneral.Conexion, ref ddl_id_estado, ref ddl_id_estado);
		}

		private void Cargar_parametro()
		{
			ClaseComun.Listar_Parametro(ClaseGeneral.Conexion, ref cbx_Id_TipoFuente, 3);
		}

		private void Cargar_tipoEntidad()
		{
			ClaseComun.Listar_Parametro(ClaseGeneral.Conexion, ref ddl_Id_TipoEntidad, 11);
		}

		private void Cargar_Ministerio()
		{
			ClaseComun.Listar_Parametro(ClaseGeneral.Conexion, ref ddl_id_Ministerio, 15);
		}

		private void Cargar_Sector()
		{
			ClaseComun.Listar_Parametro(ClaseGeneral.Conexion, ref ddl_Id_Sector, 12);
		}

		private void Cargar_Region()
		{
			ClaseComun.Listar_Region(ClaseGeneral.Conexion, ref ddl_id_region, ref ddl_id_region);
		}

		private void Cargar_Provincia()
		{
			ClaseComun.Listar_Provincia(ClaseGeneral.Conexion, ref ddl_id_provincia, ref ddl_id_provincia, Convert.ToInt32(ddl_id_region.SelectedValue));
		}

		private void Cargar_Comuna()
		{
			ClaseComun.Listar_Comuna(ClaseGeneral.Conexion, ref ddl_id_comuna, ref ddl_id_comuna, Convert.ToInt32(ddl_id_region.SelectedValue), Convert.ToInt32(ddl_id_provincia.SelectedValue));
		}

		private void AsignarEvento()
		{
			txt_id_cliente.EventoAsignarNumero(9);
			txt_N_Cliente_Ref.EventoAsignarNumero(9);
			clsEvento.AvanzarComboBox_KeyPress(ref ddl_id_region);
			clsEvento.AvanzarComboBox_KeyPress(ref ddl_id_provincia);
			clsEvento.AvanzarComboBox_KeyPress(ref ddl_id_comuna);
			clsEvento.AvanzarComboBox_KeyPress(ref ddl_Id_TipoEntidad);
			clsEvento.AvanzarComboBox_KeyPress(ref ddl_id_Ministerio);
			clsEvento.AvanzarComboBox_KeyPress(ref ddl_Id_Sector);
			clsEvento.AvanzarComboBox_KeyPress(ref ddl_id_estado);
			clsEvento.AvanzarComboBox_KeyPress(ref ddl_id_periodo);
			txt_run.EventoAsignarRut();
			txt_OPR_RUT.EventoAsignarRut();
			txt_Email.EventoAsignarValidarEmail();
			txt_Emailfacturacion.EventoAsignarValidarEmail();
			txt_direccion.EventoAsignarDireccion();
		}
		private void Cargar_Fecha()
		{
			SqlCommand cmd = new SqlCommand();

			//	  SqlCommand cmd = new SqlCommand();

			cmd.CommandText = "ListarPeriodo";
			DataSet dt;
			dt = Conectar2.Listar(ClaseGeneral.Conexion, cmd);

			ddl_id_periodo.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
			ddl_id_periodo.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
			ddl_id_periodo.DataSource = dt.Tables[0];
			dtp_FechaInicio.Text = ddl_id_periodo.Text;
		}

		private void Grabar()
		{

			Boolean bolResult;
			string strMensajeError = "";
			bolResult = false;
			if (btn_Grabar.Text == "Modificar")
			{
				SqlCommand cmdMod = new SqlCommand();
				cmdMod.Parameters.Clear();
				cmdMod.Parameters.Add("@Id_cliente", SqlDbType.Int);
				cmdMod.Parameters["@Id_cliente"].Value = txt_id_cliente.Text;
				cmdMod.Parameters.Add("@N_Cliente_Ref", SqlDbType.Int);
				cmdMod.Parameters["@N_Cliente_Ref"].Value = txt_N_Cliente_Ref.Text;
				cmdMod.Parameters.Add("@run", SqlDbType.VarChar, 11);
				cmdMod.Parameters["@run"].Value = txt_run.Text;
				cmdMod.Parameters.Add("@Razon_Social", SqlDbType.VarChar, 60);
				cmdMod.Parameters["@Razon_Social"].Value = txt_Razon_Social.Text;
				cmdMod.Parameters.Add("@Direccion", SqlDbType.VarChar, 60);
				cmdMod.Parameters["@Direccion"].Value = txt_direccion.Text;
				cmdMod.Parameters.Add("@Id_Region", SqlDbType.Int);
				cmdMod.Parameters["@Id_Region"].Value = ddl_id_region.SelectedValue;
				cmdMod.Parameters.Add("@Id_Provincia", SqlDbType.Int);
				cmdMod.Parameters["@Id_Provincia"].Value = ddl_id_provincia.SelectedValue;
				cmdMod.Parameters.Add("@Id_Comuna", SqlDbType.Int);
				cmdMod.Parameters["@Id_Comuna"].Value = ddl_id_comuna.SelectedValue;
				cmdMod.Parameters.Add("@Telefono", SqlDbType.VarChar, 15);
				cmdMod.Parameters["@Telefono"].Value = txt_telefono.Text;
				cmdMod.Parameters.Add("@Id_TipoFuente", SqlDbType.Int);
				cmdMod.Parameters["@Id_TipoFuente"].Value = null;
				cmdMod.Parameters.Add("@Id_estado", SqlDbType.Int);
				cmdMod.Parameters["@Id_estado"].Value = ddl_id_estado.SelectedValue;
				cmdMod.Parameters.Add("@FechaInicio", SqlDbType.VarChar, 15);
				cmdMod.Parameters["@FechaInicio"].Value = ddl_id_periodo.SelectedValue;
				cmdMod.Parameters.Add("@Email", SqlDbType.VarChar, 200);
				cmdMod.Parameters["@Email"].Value = txt_Email.Text;
				cmdMod.Parameters.Add("@EmailFacturacion", SqlDbType.VarChar, 200);
				cmdMod.Parameters["@EmailFacturacion"].Value = txt_Emailfacturacion.Text;
				cmdMod.Parameters.Add("@Servicio", SqlDbType.VarChar, 100);
				cmdMod.Parameters["@Servicio"].Value = txt_Servicio.Text;
				cmdMod.Parameters.Add("@Id_TipoEntidad", SqlDbType.Int);
				cmdMod.Parameters["@Id_TipoEntidad"].Value = ddl_Id_TipoEntidad.SelectedValue;
				cmdMod.Parameters.Add("@Id_Sector", SqlDbType.Int);
				cmdMod.Parameters["@Id_Sector"].Value = ddl_Id_Sector.SelectedValue;
				cmdMod.Parameters.Add("@id_Ministerio", SqlDbType.Int);
				cmdMod.Parameters["@id_Ministerio"].Value = ddl_id_Ministerio.SelectedValue;
				cmdMod.Parameters.Add("@Director", SqlDbType.VarChar, 50);
				cmdMod.Parameters["@Director"].Value = txt_Director.Text;
				cmdMod.Parameters.Add("@Opr", SqlDbType.VarChar, 50);
				cmdMod.Parameters["@Opr"].Value = txt_Opr.Text;
				cmdMod.Parameters.Add("@nombre_fantasia", SqlDbType.VarChar, 100);
				cmdMod.Parameters["@nombre_fantasia"].Value = txt_Nombre_fantasia.Text;
				cmdMod.Parameters.Add("@OPR_RUT", SqlDbType.VarChar, 1);
				cmdMod.Parameters["@OPR_RUT"].Value = txt_OPR_RUT.DevuelveCadenaNulo();
				cmdMod.CommandText = "pa_Cliente_Upd";

				cmdMod.CommandType = CommandType.StoredProcedure;
				Conectar2.AgregarModificarEliminar(ClaseGeneral.Conexion, cmdMod, ref strMensajeError);

				if (string.IsNullOrWhiteSpace(strMensajeError))
				{
					if (ddl_id_estado.SelectedValue.ToString() == "0")
					{
						if (lbl_Estado_mod.Text != ddl_id_estado.Text)
						{
							MessageBox.Show("Dato modificado,Debe ingresar una observación porque se dejo inactivo");
							frmObservacionCliente frm1 = new frmObservacionCliente(txt_id_cliente.Text, dtp_FechaInicio.Text);
							frm1.ShowDialog(this);
							this.Close();
						}

						this.Close();
					}

				}
			}
			else
			{

				SqlCommand cmd = new SqlCommand();
				cmd.Parameters.Clear();
				cmd.Parameters.Add("@Id_cliente", SqlDbType.Int);
				cmd.Parameters["@Id_cliente"].Value = txt_id_cliente.Text;
				cmd.Parameters.Add("@N_Cliente_Ref", SqlDbType.Int);
				cmd.Parameters["@N_Cliente_Ref"].Value = txt_N_Cliente_Ref.Text;
				cmd.Parameters.Add("@run", SqlDbType.VarChar, 11);
				cmd.Parameters["@run"].Value = txt_run.Text;
				cmd.Parameters.Add("@Razon_Social", SqlDbType.VarChar, 60);
				cmd.Parameters["@Razon_Social"].Value = txt_Razon_Social.Text;
				cmd.Parameters.Add("@Direccion", SqlDbType.VarChar, 60);
				cmd.Parameters["@Direccion"].Value = txt_direccion.Text;
				cmd.Parameters.Add("@Id_Region", SqlDbType.Int);
				cmd.Parameters["@Id_Region"].Value = ddl_id_region.SelectedValue;
				cmd.Parameters.Add("@Id_Provincia", SqlDbType.Int);
				cmd.Parameters["@Id_Provincia"].Value = ddl_id_provincia.SelectedValue;
				cmd.Parameters.Add("@Id_Comuna", SqlDbType.Int);
				cmd.Parameters["@Id_Comuna"].Value = ddl_id_comuna.SelectedValue;
				cmd.Parameters.Add("@Telefono", SqlDbType.VarChar, 15);
				cmd.Parameters["@Telefono"].Value = txt_telefono.Text;
				cmd.Parameters.Add("@Id_TipoFuente", SqlDbType.Int);
				cmd.Parameters["@Id_TipoFuente"].Value = null;
				cmd.Parameters.Add("@Id_estado", SqlDbType.Int);
				cmd.Parameters["@Id_estado"].Value = ddl_id_estado.SelectedValue;
				cmd.Parameters.Add("@FechaInicio", SqlDbType.VarChar, 15);
				cmd.Parameters["@FechaInicio"].Value = ddl_id_periodo.SelectedValue;
				cmd.Parameters.Add("@Email", SqlDbType.VarChar, 200);
				cmd.Parameters["@Email"].Value = txt_Email.Text;
				cmd.Parameters.Add("@EmailFacturacion", SqlDbType.VarChar, 200);
				cmd.Parameters["@EmailFacturacion"].Value = txt_Emailfacturacion.Text;
				cmd.Parameters.Add("@Clave", SqlDbType.VarChar, 100);
				cmd.Parameters["@Clave"].Value = txt_Clave.Text.XGenerateHashMD5();
				cmd.Parameters.Add("@Servicio", SqlDbType.VarChar, 100);
				cmd.Parameters["@Servicio"].Value = txt_Servicio.Text;
				cmd.Parameters.Add("@Id_TipoEntidad", SqlDbType.Int);
				cmd.Parameters["@Id_TipoEntidad"].Value = ddl_Id_TipoEntidad.SelectedValue;
				cmd.Parameters.Add("@Id_Sector", SqlDbType.Int);
				cmd.Parameters["@Id_Sector"].Value = ddl_Id_Sector.SelectedValue;
				cmd.Parameters.Add("@id_Ministerio", SqlDbType.Int);
				cmd.Parameters["@id_Ministerio"].Value = ddl_id_Ministerio.SelectedValue;
				cmd.Parameters.Add("@Director", SqlDbType.VarChar, 50);
				cmd.Parameters["@Director"].Value = txt_Director.Text;
				cmd.Parameters.Add("@Opr", SqlDbType.VarChar, 50);
				cmd.Parameters["@Opr"].Value = txt_Opr.Text;
				cmd.Parameters.Add("@nombre_fantasia", SqlDbType.VarChar, 100);
				cmd.Parameters["@nombre_fantasia"].Value = txt_Nombre_fantasia.Text;
				cmd.Parameters.Add("@OPR_RUT", SqlDbType.VarChar, 1);
				cmd.Parameters["@OPR_RUT"].Value = txt_OPR_RUT.DevuelveCadenaNulo();
				cmd.CommandText = "pa_Cliente_ins";
				cmd.CommandType = CommandType.StoredProcedure;
				Conectar2.AgregarModificarEliminar(ClaseGeneral.Conexion, cmd, ref strMensajeError);
				if (string.IsNullOrWhiteSpace(strMensajeError))
					"Cliente registrado".XMensajeProcesoOK();
				else
					strMensajeError.XMensajeError();

			}

			Cursor = Cursors.Default;

			//pa_ClienteVerificar
		}

		#endregion

		#region "button"
		private void LeerExcel(string archivo, string extension)
		{
			////	HSSFWorkbook hssfwb;
			//IWorkbook hssfwb = null;
			//string Sheet_name = "";
			//classFuncionesGenerales.ExcelNpoin ExcelNpoin = new classFuncionesGenerales.ExcelNpoin();

			//ISheet sheet = ExcelNpoin.LeerExcel(archivo, extension, 0, ref Sheet_name);
			//txt_run.Text = sheet.GetRow(10).GetCell(1).StringCellValue;
			//txt_Razon_Social.Text = sheet.GetRow(8).GetCell(2).StringCellValue;
			//txt_Nombre_fantasia.Text = sheet.GetRow(9).GetCell(2).StringCellValue;
			//txt_direccion.Text = sheet.GetRow(13).GetCell(1).StringCellValue;
			//txt_Email.Text = sheet.GetRow(10).GetCell(5).StringCellValue;
			//txt_telefono.Text = sheet.GetRow(11).GetCell(5).ToString();
		}

		private void btn_Excel_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Excel (*.xlsx;*.xls)|*.xlsx;*.xls";
				openFileDialog.FilterIndex = 1;
				openFileDialog.RestoreDirectory = true;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					FileInfo fi = new FileInfo(openFileDialog.FileName);
					LeerExcel(openFileDialog.FileName, fi.Extension);
				}
			}
		}
		private void btn_cerrar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			this.Close();

			Cursor = Cursors.Default;
		}

		private void btn_Grabar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			StringBuilder strMensaje = new StringBuilder();
			if (tbl_cliente.XValidarPanel(ref strMensaje))
			{
				Cursor = Cursors.Default;
				classFuncionesGenerales.mensajes.MensajeError(strMensaje.ToString());
			}
			else
				Grabar();
			Cursor = Cursors.Default;
		}
		#endregion

		#region "combobox"
		private void cbx_id_estado_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ddl_id_estado.Text == "1")
				ddl_id_periodo.Enabled = true;
			else
				ddl_id_periodo.Enabled = false;

		}
		private void cbx_id_periodo_SelectedIndexChanged(object sender, EventArgs e)
		{
			dtp_FechaInicio.Text = ddl_id_periodo.Text;
		}
		private void cbx_id_region_SelectedIndexChanged(object sender, EventArgs e)
		{
			Cargar_Provincia();

		}
		private void cbx_id_provincia_SelectedIndexChanged(object sender, EventArgs e)
		{
			Cargar_Comuna();
		}
		#endregion

	
	}
}
