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
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.IO;
using System.Configuration;
using OpenXmlPowerTools;
using System.Xml;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO.Packaging;
using System.Diagnostics;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;

namespace ControlDosimetro
{
	public partial class frmEmpresaMant : Form
	{
		#region "Definicion variable"
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();
		Clases.ClassEvento clsEvento = new Clases.ClassEvento();

		dllLibreriaMysql.clsUtiles clsUtiles1 = new dllLibreriaMysql.clsUtiles();
		#endregion



		public frmEmpresaMant(Int64 intCodigo)
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
				cbx_id_estado.Enabled = false;
				txt_Clave1.Enabled = true;
				txt_Clave1.Visible = true;
				txt_Clave.Visible = true;
				lbl_Clave.Visible = true;
				dtp_FechaInicio.Text = cbx_id_periodo.Text;
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
				txt_Clave1.Enabled = false;
				// SqlCommand cmd = new SqlCommand();
				SqlCommand cmd = new SqlCommand();

				cmd.CommandText = "SELECT run,Razon_Social,N_Cliente_Ref,Direccion,Id_Region,Id_Provincia,Id_Comuna,Telefono, Id_TipoFuente,Id_estado,Fechainicio,Email,clave,servicio, " +
								"Id_Sector, id_Ministerio, Director, Opr,Id_TipoEntidad,nombre_fantasia " +
								" FROM tbl_cliente WHERE Id_cliente= " + intCodigo.ToString();
				DataSet dt;
				dt = Conectar.Listar(Clases.clsBD.BD, cmd);

				txt_Director.Text = dt.Tables[0].Rows[0]["Director"].ToString();
				txt_Opr.Text = dt.Tables[0].Rows[0]["Opr"].ToString();
				try
				{
					cbx_Id_Sector.SelectedValue = dt.Tables[0].Rows[0]["Id_Sector"].ToString();
				}
				catch
				{
					cbx_Id_Sector.SelectedIndex = -1;
				}
				try
				{
					cbx_Id_TipoEntidad.SelectedValue = dt.Tables[0].Rows[0]["Id_TipoEntidad"].ToString();
				}
				catch
				{
					cbx_Id_TipoEntidad.SelectedIndex = -1;
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
					cbx_id_Ministerio.SelectedValue = dt.Tables[0].Rows[0]["id_Ministerio"].ToString();
				}
				catch
				{
					cbx_id_Ministerio.SelectedIndex = -1;
				}

				txt_run.Text = dt.Tables[0].Rows[0]["run"].ToString();
				txt_N_Cliente_Ref.Text = dt.Tables[0].Rows[0]["N_Cliente_Ref"].ToString();
				txt_Nombre_fantasia.Text = dt.Tables[0].Rows[0]["Nombre_Fantasia"].ToString();
				txt_Razon_Social.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
				txt_direccion.Text = dt.Tables[0].Rows[0]["Direccion"].ToString();
				txt_telefono.Text = dt.Tables[0].Rows[0]["Telefono"].ToString();
				cbx_id_region.SelectedValue = dt.Tables[0].Rows[0]["Id_Region"].ToString();
				Cargar_Provincia();
				cbx_id_provincia.SelectedValue = dt.Tables[0].Rows[0]["Id_Provincia"].ToString();
				Cargar_Comuna();
				cbx_id_comuna.SelectedValue = dt.Tables[0].Rows[0]["Id_Comuna"].ToString();
				txt_Email.Text = dt.Tables[0].Rows[0]["Email"].ToString();
				cbx_id_estado.SelectedValue = dt.Tables[0].Rows[0]["Id_estado"].ToString();
				lbl_Estado_mod.Text = cbx_id_estado.Text;
				dtp_FechaInicio.Value = Convert.ToDateTime(dt.Tables[0].Rows[0]["Fechainicio"]);

				cbx_id_periodo.Text = dt.Tables[0].Rows[0]["Fechainicio"].ToString();
				txt_Clave.Text = dt.Tables[0].Rows[0]["clave"].ToString();
				txt_Clave1.Visible = false;
				txt_Clave.Visible = false;
				lbl_Clave.Visible = false;
				try
				{
					txt_Clave1.Text = clsUtiles1.DecryptTripleDES(dt.Tables[0].Rows[0]["clave"].ToString());
				}
				catch (Exception)
				{

					txt_Clave1.Text = dt.Tables[0].Rows[0]["clave"].ToString();
					txt_Clave.Text = clsUtiles1.GenerateHashMD5(dt.Tables[0].Rows[0]["clave"].ToString());
				}


				txt_Servicio.Text = dt.Tables[0].Rows[0]["servicio"].ToString();
				if (dt.Tables[0].Rows[0]["Id_estado"].ToString() == "1")
				{
					txt_run.Enabled = false;
					cbx_id_periodo.Enabled = true;
				}
				else
				{
					txt_run.Enabled = true;
					cbx_id_periodo.Enabled = false;
				}

			}
		}

		#region "Llamada de carga"  

		private void Cargar_Estado()
		{
			ClaseComun.Listar_Estado(Clases.clsBD.BD, ref cbx_id_estado, ref cbx_id_estado);
		}

		private void Cargar_parametro()
		{
			ClaseComun.Listar_Parametro(Clases.clsBD.BD, ref cbx_Id_TipoFuente, 3);
		}

		private void Cargar_tipoEntidad()
		{
			ClaseComun.Listar_Parametro(Clases.clsBD.BD, ref cbx_Id_TipoEntidad, 11);
		}

		private void Cargar_Ministerio()
		{
			ClaseComun.Listar_Parametro(Clases.clsBD.BD, ref cbx_id_Ministerio, 15);
		}

		private void Cargar_Sector()
		{
			ClaseComun.Listar_Parametro(Clases.clsBD.BD, ref cbx_Id_Sector, 12);
		}

		private void Cargar_Region()
		{
			ClaseComun.Listar_Region(Clases.clsBD.BD, ref cbx_id_region, ref cbx_id_region);
		}

		private void Cargar_Provincia()
		{
			ClaseComun.Listar_Provincia(Clases.clsBD.BD, ref cbx_id_provincia, ref cbx_id_provincia, Convert.ToInt32(cbx_id_region.SelectedValue));
		}

		private void Cargar_Comuna()
		{
			ClaseComun.Listar_Comuna(Clases.clsBD.BD, ref cbx_id_comuna, ref cbx_id_comuna, Convert.ToInt32(cbx_id_region.SelectedValue), Convert.ToInt32(cbx_id_provincia.SelectedValue));
		}

		private void AsignarEvento()
		{
			clsEvento.AsignarNumero(ref txt_id_cliente);
			clsEvento.AsignarNumero(ref txt_N_Cliente_Ref);
			clsEvento.AvanzarComboBox_KeyPress(ref cbx_id_region);
			clsEvento.AvanzarComboBox_KeyPress(ref cbx_id_provincia);
			clsEvento.AvanzarComboBox_KeyPress(ref cbx_id_comuna);
			clsEvento.AvanzarComboBox_KeyPress(ref cbx_Id_TipoEntidad);
			clsEvento.AvanzarComboBox_KeyPress(ref cbx_id_Ministerio);
			clsEvento.AvanzarComboBox_KeyPress(ref cbx_Id_Sector);
			clsEvento.AvanzarComboBox_KeyPress(ref cbx_id_estado);
			clsEvento.AvanzarComboBox_KeyPress(ref cbx_id_periodo);
			clsEvento.AsignarRut(ref txt_run);
			clsEvento.AsignarRut(ref txt_OPR_RUT);
			clsEvento.AsignarMailMultiple(ref txt_Email);
			clsEvento.AsignarMailMultiple(ref txt_Emailfacturacion);
			clsEvento.AsignarDireccion(ref txt_direccion);

			//txt_Email.Validated += new EventHandler(ClaseEvento.validaEmail_Validated);
		}

		private bool valida_cliente(Int64 intCodigo)
		{
			//			  SqlCommand cmd = new SqlCommand();
			SqlCommand cmd = new SqlCommand();

			cmd.CommandText = "SELECT run,Razon_Social,N_Cliente_Ref,Direccion,Id_Region,Id_Provincia,Id_Comuna,Telefono, Id_TipoFuente,Id_estado,Fechainicio " +
							" FROM tbl_cliente WHERE Id_cliente= " + intCodigo.ToString();
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			if (dt.Tables[0].Rows.Count > 0)
				return true;
			else
				return false;

		}

		private bool valida_cliente_activo(Int64 intCodigo)
		{
			//			  SqlCommand cmd = new SqlCommand();
			SqlCommand cmd = new SqlCommand();

			cmd.CommandText = "SELECT run,Razon_Social,N_Cliente_Ref,Direccion,Id_Region,Id_Provincia,Id_Comuna,Telefono, Id_TipoFuente,Id_estado,Fechainicio " +
								 " FROM tbl_cliente WHERE Id_cliente= " + intCodigo.ToString() + " and id_estado=1";
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			if (dt.Tables[0].Rows.Count > 0)
				return true;
			else
				return false;

		}

		private void Cargar_Fecha()
		{
			SqlCommand cmd = new SqlCommand();

			//	  SqlCommand cmd = new SqlCommand();

			cmd.CommandText = "ListarPeriodo";
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			cbx_id_periodo.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
			cbx_id_periodo.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
			cbx_id_periodo.DataSource = dt.Tables[0];
			dtp_FechaInicio.Text = cbx_id_periodo.Text;
		}

		private void Grabar()
		{

			Boolean bolResult;
			bolResult = false;
			//if (Convert.ToDateTime(cbx_id_periodo.Text.ToString()) > DateTime.Now.Date)
			//{
			//	Cursor = Cursors.Default;
			//	MessageBox.Show("FEcha inicio control es mayor que la fecha actual", ControlDosimetro.Properties.Resources.msgCaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	return;
			//}
			//   if (MessageBox.Show("Desea grabar la información", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
			//  {
			if (btn_Grabar.Text == "Modificar")
			{

				ClaseComun.Modificar(Clases.clsBD.BD, tbl_cliente, ref bolResult);
				if (bolResult == true)
				{
					if (cbx_id_estado.SelectedValue.ToString() == "0")
					{
						if (lbl_Estado_mod.Text != cbx_id_estado.Text)
						{
							SqlCommand cmd1 = new SqlCommand();
							cmd1.CommandText = "pa_ClienteHistorial_upd " + txt_id_cliente.Text + ",'" + dtp_FechaInicio.Value.ToShortDateString().Replace("-", "/") + "'";
							cmd1.CommandType = CommandType.Text;
							DataSet ds = Conectar.Listar(Clases.clsBD.BD, cmd1);

							if ((int)ds.Tables[0].Rows[0]["Resultado"] == 0)
								MessageBox.Show(ds.Tables[0].Rows[0]["Mensaje"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


							MessageBox.Show("Dato modificado,Debe ingresar una observación porque se dejo inactivo");
							frmObservacionCliente frm1 = new frmObservacionCliente(txt_id_cliente.Text, dtp_FechaInicio.Text);
							frm1.ShowDialog(this);
							this.Close();
						}
						else
						{
							SqlCommand cmd1 = new SqlCommand();
							cmd1.CommandText = "pa_ClienteHistorial_upd " + txt_id_cliente.Text + ",'" + dtp_FechaInicio.Value.ToShortDateString().Replace("-", "/") + "'";
							cmd1.CommandType = CommandType.Text;
							DataSet ds = Conectar.Listar(Clases.clsBD.BD, cmd1);

							if ((int)ds.Tables[0].Rows[0]["Resultado"] == 0)
								MessageBox.Show(ds.Tables[0].Rows[0]["Mensaje"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							else
								if ((int)ds.Tables[0].Rows[0]["Resultado"] == 1)
								MessageBox.Show(ds.Tables[0].Rows[0]["Mensaje"].ToString(), "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}

					}
					else
					{

						SqlCommand cmd1 = new SqlCommand();
						cmd1.CommandText = "pa_ClienteHistorial_upd " + txt_id_cliente.Text + ",'" + dtp_FechaInicio.Value.ToShortDateString().Replace("-", "/") + "'";
						cmd1.CommandType = CommandType.Text;
						DataSet ds = Conectar.Listar(Clases.clsBD.BD, cmd1);

						if ((int)ds.Tables[0].Rows[0]["Resultado"] == 0)
							MessageBox.Show(ds.Tables[0].Rows[0]["Mensaje"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						else
							if ((int)ds.Tables[0].Rows[0]["Resultado"] == 1)
							MessageBox.Show(ds.Tables[0].Rows[0]["Mensaje"].ToString(), "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}


					this.Close();
				}

			}
			else
			{
				if (valida_cliente(Convert.ToInt64(txt_id_cliente.Text)) == false)
				{
					ClaseComun.Insertar(Clases.clsBD.BD, tbl_cliente, ref bolResult);
					if (bolResult == true)
					{



						SqlCommand cmd = new SqlCommand();
						cmd.CommandText = "pa_Cliente_ins " + lbl_id_cliente.Text;
						cmd.CommandType = CommandType.Text;
						Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);

						SqlCommand cmdArchivo = new SqlCommand();
						DataSet dtArchivo;
						cmdArchivo.CommandText = "" +
							"SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=6 order by orden ";
						cmdArchivo.CommandType = CommandType.Text;
						dtArchivo = Conectar.Listar(Clases.clsBD.BD, cmdArchivo);

						DataSet dtformato;
						cmdArchivo.CommandText = "" +
							"SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=5 order by orden ";
						cmdArchivo.CommandType = CommandType.Text;
						dtformato = Conectar.Listar(Clases.clsBD.BD, cmdArchivo);
						string targetPath = dtArchivo.Tables[0].Rows[0]["Glosa"].ToString() + "Cliente " + lbl_id_cliente.Text;

						MessageBox.Show("Dato Guardado ");//y se va a generar documento de Certificado
																							//if (!System.IO.Directory.Exists(targetPath))
																							//{
																							//    System.IO.Directory.CreateDirectory(targetPath);
																							//}



						//String strArchivo = "C://Formato//" + "CERT CON FIRMA INCLUIDA.docx";//dtformato.Tables[0].Rows[0]["Glosa"].ToString() + "CERT CON FIRMA INCLUIDA.docx";
						//String strArchivoCopiar = "C://Formato//" +  "Certificado Cliente" + lbl_id_cliente.Text + ".docx";

						//#region Update Document Bookmarks Openxml
						//String strcampoMarcador = "empresa";

						//using (WordprocessingDocument doc = WordprocessingDocument.Open(strArchivoCopiar, true))
						//{
						//    string strSemetre1 = "";
						//    int intMes = Convert.ToInt32(dtp_FechaInicio.MaxDate.Month) / 3;
						//    if (intMes >= 1 && intMes <= 3)
						//        strSemetre1 = "primer";
						//    if (intMes >= 4 && intMes <= 6)
						//        strSemetre1 = "segundo";
						//    if (intMes >= 7 && intMes <= 9)
						//        strSemetre1 = "tercer";
						//    if (intMes >= 10 && intMes <= 12)
						//        strSemetre1 = "cuarto";

						//    strcampoMarcador = "Ciudad";
						//    BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), cbx_id_provincia.Text);
						//    strcampoMarcador = "Direccion";
						//    BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), txt_direccion.Text);
						//    strcampoMarcador = "Rut";
						//    BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), txt_run.Text);
						//    strcampoMarcador = "empresa";
						//    BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), txt_Razon_Social.Text);
						//    strcampoMarcador = "comuna";
						//    BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), cbx_id_comuna.Text);
						//    strcampoMarcador = "anno";
						//    BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), dtp_FechaInicio.MaxDate.Year.ToString());
						//    strcampoMarcador = "trimestre";
						//    BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), strSemetre1);




						//}


						//#endregion

						//this.Close();
					}
					else
						MessageBox.Show("El número de cliente ya existe, verificar");

				}
				else
				{
					if (valida_cliente_activo(Convert.ToInt64(txt_id_cliente.Text)) == true)
						MessageBox.Show("El número de cliente ya existe, verificar");
					else
					{

						ClaseComun.Modificar(Clases.clsBD.BD, tbl_cliente, ref bolResult);
						if (bolResult == true)
						{

							MessageBox.Show("Dato Guardado");

							SqlCommand cmd = new SqlCommand();
							cmd.CommandText = "pa_Sucursal_ins '" + txt_run.Text + "','" + txt_direccion.Text + "'," + cbx_id_region.SelectedValue + "," +
														cbx_id_provincia.SelectedValue + "," + cbx_id_comuna.SelectedValue + ",'" + txt_telefono.Text + "',1,1," + txt_id_cliente.Text + ",'" + txt_Email.Text + "','" + txt_Razon_Social.Text + "'";
							cmd.CommandType = CommandType.Text;
							Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);



							SqlCommand cmd1 = new SqlCommand();
							cmd1.CommandText = "pa_ClienteHistorial_ins " + txt_id_cliente.Text;
							cmd1.CommandType = CommandType.Text;
							Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd1);


							SqlCommand cmdArchivo = new SqlCommand();
							//SqlCommand cmdcombo = new SqlCommand();
							DataSet dtArchivo;
							cmdArchivo.CommandText = "" +
								"SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=6 order by orden ";
							cmdArchivo.CommandType = CommandType.Text;
							dtArchivo = Conectar.Listar(Clases.clsBD.BD, cmdArchivo);

							DataSet dtformato;
							cmdArchivo.CommandText = "" +
								"SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=5 order by orden ";
							cmdArchivo.CommandType = CommandType.Text;
							dtformato = Conectar.Listar(Clases.clsBD.BD, cmdArchivo);

							//string targetPath = dtArchivo.Tables[0].Rows[0]["Glosa"].ToString() + "Cliente " + lbl_id_cliente.Text;

							//if (!System.IO.Directory.Exists(targetPath))
							//{
							//    System.IO.Directory.CreateDirectory(targetPath);
							//}



							//string strArchivo = dtformato.Tables[0].Rows[0]["Glosa"].ToString() + "CERT CON FIRMA INCLUIDA.docx";
							//String strArchivoCopiar = targetPath + "Certificado Cliente" + lbl_id_cliente.Text + ".docx";

							//#region Update Document Bookmarks Openxml
							//String strcampoMarcador = "empresa";

							//using (WordprocessingDocument doc = WordprocessingDocument.Open(strArchivoCopiar, true))
							//{
							//    string strSemetre1 = "";
							//    int intMes = Convert.ToInt32(dtp_FechaInicio.MaxDate.Month) / 3;
							//    if (intMes >= 1 && intMes <= 3)
							//        strSemetre1 = "primer";
							//    if (intMes >= 4 && intMes <= 6)
							//        strSemetre1 = "segundo";
							//    if (intMes >= 7 && intMes <= 9)
							//        strSemetre1 = "tercer";
							//    if (intMes >= 10 && intMes <= 12)
							//        strSemetre1 = "cuarto";

							//    strcampoMarcador = "Ciudad";
							//    BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), cbx_id_provincia.Text);
							//    strcampoMarcador = "Direccion";
							//    BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), txt_direccion.Text);
							//    strcampoMarcador = "Rut";
							//    BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), txt_run.Text);
							//    strcampoMarcador = "empresa";
							//    BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), txt_Razon_Social.Text);
							//    strcampoMarcador = "comuna";
							//    BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), cbx_id_comuna.Text);
							//    strcampoMarcador = "anno";
							//    BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), dtp_FechaInicio.MaxDate.Year.ToString());
							//    strcampoMarcador = "trimestre";
							//    BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), strSemetre1);




							//}


							//#endregion

							//this.Close();
						}
					}
				}

			}

			//  }

			Cursor = Cursors.Default;
		}

		#endregion

		#region "button"

		private void btn_cerrar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			this.Close();

			Cursor = Cursors.Default;
		}

		private void btn_Grabar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			string strMensaje = "";
			Boolean bolResult;
			bolResult = false;
			if (!ClaseComun.ValidarFormulario(Clases.clsBD.BD, tbl_cliente, ref bolResult, ref strMensaje))
			{
				Cursor = Cursors.Default;
				classFuncionesGenerales.mensajes.MensajeError(strMensaje);
			}
			else
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

		private void label12_Click(object sender, EventArgs e)
		{

		}

		private void cbx_id_estado_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbx_id_estado.Text == "1")
				cbx_id_periodo.Enabled = true;
			else
				cbx_id_periodo.Enabled = false;

		}

		private void txt_Clave1_TextChanged(object sender, EventArgs e)
		{
			txt_Clave.Text = clsUtiles1.GenerateHashMD5(txt_Clave1.Text);
		}

		private void cbx_id_periodo_SelectedIndexChanged(object sender, EventArgs e)
		{
			dtp_FechaInicio.Text = cbx_id_periodo.Text;
		}

		private void lbl_Id_TipoFuente_Click(object sender, EventArgs e)
		{

		}

		private void lbl_Servicio_Click(object sender, EventArgs e)
		{

		}

		private void lbl_id_estado_Click(object sender, EventArgs e)
		{

		}
		private void LeerExcel(string archivo, string extension)
		{
			//	HSSFWorkbook hssfwb;
			IWorkbook hssfwb = null;
			string Sheet_name = "";
			classFuncionesGenerales.ExcelNpoin ExcelNpoin = new classFuncionesGenerales.ExcelNpoin();

			ISheet sheet = ExcelNpoin.LeerExcel(archivo, extension, 0, ref Sheet_name);
			txt_run.Text = sheet.GetRow(10).GetCell(1).StringCellValue;
			txt_Razon_Social.Text = sheet.GetRow(8).GetCell(2).StringCellValue;
			txt_Nombre_fantasia.Text = sheet.GetRow(9).GetCell(2).StringCellValue;
			txt_direccion.Text = sheet.GetRow(13).GetCell(1).StringCellValue;
			txt_Email.Text = sheet.GetRow(10).GetCell(5).StringCellValue;
			txt_telefono.Text = sheet.GetRow(11).GetCell(5).ToString();
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

	}
}
