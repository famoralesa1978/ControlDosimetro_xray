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

namespace ControlDosimetro
{
    public partial class frmEmpresaMant : Form
    {
        #region "Definicion variable"
		 clsConectorSqlServer Conectar = new clsConectorSqlServer();
		 clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
        clsEventoControl ClaseEvento = new clsEventoControl();

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
                //cargar_valor_maximo();
                //
            }
            else
            {
                btn_Grabar.Text = "Modificar";
                this.Text = "Modificar Cliente";
                txt_id_cliente.Text = intCodigo.ToString();
                txt_id_cliente.Enabled = false;
                txt_Clave1.Enabled = false;
               // SqlCommand cmd = new SqlCommand();
                SqlCommand cmd = new SqlCommand();

					 cmd.CommandText = "SELECT run,Razon_Social,N_Cliente_Ref,Direccion,Id_Region,Id_Provincia,Id_Comuna,Telefono, Id_TipoFuente,Id_estado,Fechainicio,Email,clave,servicio, " +
                            "Id_Sector, id_Ministerio, Director, Opr,Id_TipoEntidad " + 
                            " FROM tbl_cliente WHERE Id_cliente= " + intCodigo.ToString();
                DataSet dt;
                dt = Conectar.Listar(Clases.clsBD.BD,cmd);

                txt_Director.Text= dt.Tables[0].Rows[0]["Director"].ToString();
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
                txt_Razon_Social.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
                txt_direccion.Text = dt.Tables[0].Rows[0]["Direccion"].ToString();
                txt_telefono.Text = dt.Tables[0].Rows[0]["Telefono"].ToString();
                cbx_id_region.SelectedValue = dt.Tables[0].Rows[0]["Id_Region"].ToString();
                Cargar_Provincia();
                cbx_id_provincia.SelectedValue = dt.Tables[0].Rows[0]["Id_Provincia"].ToString();
                Cargar_Comuna();
                cbx_id_comuna.SelectedValue  = dt.Tables[0].Rows[0]["Id_Comuna"].ToString();
                txt_Email.Text = dt.Tables[0].Rows[0]["Email"].ToString();
                cbx_id_estado.SelectedValue = dt.Tables[0].Rows[0]["Id_estado"].ToString();
				lbl_Estado_mod.Text = cbx_id_estado.Text; 
				dtp_FechaInicio.Text = dt.Tables[0].Rows[0]["Fechainicio"].ToString();
                cbx_id_periodo.Text = dtp_FechaInicio.Text;
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
            ClaseComun.Listar_Estado(Clases.clsBD.BD,ref cbx_id_estado, ref cbx_id_estado);
        }

        private void Cargar_parametro()
        {
            ClaseComun.Listar_Parametro(Clases.clsBD.BD,ref cbx_Id_TipoFuente, 3);
        }

        private void Cargar_tipoEntidad()
        {
            ClaseComun.Listar_Parametro(Clases.clsBD.BD,ref cbx_Id_TipoEntidad, 11);
        }

        private void Cargar_Ministerio()
        {
            ClaseComun.Listar_Parametro(Clases.clsBD.BD,ref cbx_id_Ministerio, 15);
        }

        private void Cargar_Sector()
        {
            ClaseComun.Listar_Parametro(Clases.clsBD.BD,ref cbx_Id_Sector, 12);
        }

        private void Cargar_Region()
        {
            ClaseComun.Listar_Region(Clases.clsBD.BD,ref cbx_id_region, ref cbx_id_region);
        }

        private void Cargar_Provincia()
        {
            ClaseComun.Listar_Provincia(Clases.clsBD.BD,ref cbx_id_provincia, ref cbx_id_provincia, Convert.ToInt32(cbx_id_region.SelectedValue));
        }

        private void Cargar_Comuna()
        {
            ClaseComun.Listar_Comuna(Clases.clsBD.BD,ref cbx_id_comuna, ref cbx_id_comuna, Convert.ToInt32(cbx_id_region.SelectedValue), Convert.ToInt32(cbx_id_provincia.SelectedValue));
        }

        private void AsignarEvento()
		{
            SqlCommand cmd = new SqlCommand();

		//	SqlCommand cmd = new SqlCommand();
			DataSet dt;
			string strname;
			foreach (System.Windows.Forms.Control c in tbl_cliente.Controls )
			{
				//foreach (Control childc in c.Controls)
				//{
					if (c is TextBox)
					{

						strname = ((TextBox)c).Name ;

						cmd.CommandText = "SELECT  requerido, validacion " +
											" FROM glo_configuracioncampo WHERE campo= '" + strname.Replace("txt_","")  + "'";

						dt = Conectar.Listar(Clases.clsBD.BD,cmd);
						if (dt.Tables[0].Rows.Count == 0)
							((TextBox)c).KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);
						else
						{
							if (dt.Tables[0].Rows[0]["validacion"].ToString() == "rut")
							{
								((TextBox)c).KeyPress += new KeyPressEventHandler(ClaseEvento.Rut_KeyPress);
								((TextBox)c).KeyDown += new KeyEventHandler(ClaseEvento.Rut_KeyDown);
								((TextBox)c).Validated += new EventHandler(ClaseEvento.validarut_Validated);
							}
							if (dt.Tables[0].Rows[0]["validacion"].ToString() == "numerico")
							{
								((TextBox)c).KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
								((TextBox)c).KeyDown += new KeyEventHandler(ClaseEvento.Numero_KeyDown);
							}
						}
					}
					if (c is ComboBox)											
						((ComboBox)c).KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);
					if (c is DateTimePicker )
						((DateTimePicker)c).KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);

			}
            txt_Email.Validated += new EventHandler(ClaseEvento.validaEmail_Validated);
        }

        private bool valida_cliente(Int64 intCodigo)
		  {
			 //			  SqlCommand cmd = new SqlCommand();
                          SqlCommand cmd = new SqlCommand();

			  cmd.CommandText = "SELECT run,Razon_Social,N_Cliente_Ref,Direccion,Id_Region,Id_Provincia,Id_Comuna,Telefono, Id_TipoFuente,Id_estado,Fechainicio " +
							  " FROM tbl_cliente WHERE Id_cliente= " + intCodigo.ToString();
			  DataSet dt;
			  dt = Conectar.Listar(Clases.clsBD.BD,cmd);

			  if (dt.Tables[0].Rows.Count >0)
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
            dt = Conectar.Listar(Clases.clsBD.BD,cmd);

            if (dt.Tables[0].Rows.Count > 0)
                return true;
            else
                return false;

        }

        private void Cargar_Fecha()
        {
            SqlCommand cmd = new SqlCommand();

            //	  SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT Fecha_Inicio FROM conf_periodo Order by id_periodo desc";
            DataSet dt;
            dt = Conectar.Listar(Clases.clsBD.BD,cmd);

            cbx_id_periodo.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
            cbx_id_periodo.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
            cbx_id_periodo.DataSource = dt.Tables[0];
            dtp_FechaInicio.Text = cbx_id_periodo.Text;
        }
        
        #endregion

        #region "button"

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Grabar_Click(object sender, EventArgs e)
        {
            Boolean bolResult;
            bolResult = false;
         //   if (MessageBox.Show("Desea grabar la información", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
          //  {
                if (btn_Grabar.Text == "Modificar")
                {

                    ClaseComun.Modificar(Clases.clsBD.BD,tbl_cliente, ref bolResult);
                    if (bolResult == true)
                    {
                        if (cbx_id_estado.SelectedValue.ToString() == "0")
                        {
                            if (lbl_Estado_mod.Text != cbx_id_estado.Text)
                            {
                                MessageBox.Show("Dato modificado,Debe ingresar una observación porque se dejo inactivo");
                                frmObservacionCliente frm1 = new frmObservacionCliente(txt_id_cliente.Text, dtp_FechaInicio.Text);
                                frm1.ShowDialog(this);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Dato modificado");
                        }
                        else
                            MessageBox.Show("Dato modificado");

                        this.Close();
                    }

                }
                else
                {
                    if (valida_cliente(Convert.ToInt64(txt_id_cliente.Text)) == false)
                    {
                        ClaseComun.Insertar(Clases.clsBD.BD,tbl_cliente, ref bolResult);
                        if (bolResult == true)
                        {

                            MessageBox.Show("Dato Guardado y se va a generar documento de Certificado");

                            SqlCommand cmd = new SqlCommand();
                            cmd.CommandText = "pa_Sucursal_ins '" + txt_run.Text + "','" + txt_direccion.Text + "'," + cbx_id_region.SelectedValue + "," +
                                                   cbx_id_provincia.SelectedValue + "," + cbx_id_comuna.SelectedValue + ",'" + txt_telefono.Text + "',1,1";
                            cmd.CommandType = CommandType.Text;
                            Conectar.AgregarModificarEliminar(Clases.clsBD.BD,cmd);

                             SqlCommand cmd1 = new SqlCommand();
                                cmd1.CommandText = "insert into tbl_cliente_Historial " +
                                  "(Id_cliente,N_Cliente_Ref,run,Razon_Social,Direccion,Id_Region,Id_Provincia,Id_Comuna,Telefono,Id_TipoFuente,Id_estado,FechaInicio,Email,Clave,Servicio)"+
                                  "SELECT Id_cliente,N_Cliente_Ref,run,Razon_Social,Direccion,Id_Region,Id_Provincia,Id_Comuna,Telefono,Id_TipoFuente,Id_estado,FechaInicio,Email,Clave,Servicio " +
                                  ",Id_TipoEntidad,Id_Sector,id_Ministerio,Director,Opr " +
                                  "FROM [dbo].[tbl_cliente] where id_cliente=" + txt_id_cliente.Text ;
                                cmd1.CommandType = CommandType.Text;
                                Conectar.AgregarModificarEliminar(Clases.clsBD.BD,cmd1);

                            SqlCommand cmdArchivo = new SqlCommand();
                            //SqlCommand cmdcombo = new SqlCommand();
                            DataSet dtArchivo;
                            cmdArchivo.CommandText = "" +
                              "SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=6 order by orden ";
                            cmdArchivo.CommandType = CommandType.Text;
                            dtArchivo = Conectar.Listar(Clases.clsBD.BD,cmdArchivo);

                            DataSet dtformato;
                            cmdArchivo.CommandText = "" +
                              "SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=5 order by orden ";
                            cmdArchivo.CommandType = CommandType.Text;
                            dtformato = Conectar.Listar(Clases.clsBD.BD,cmdArchivo);
                        string targetPath = dtArchivo.Tables[0].Rows[0]["Glosa"].ToString() + "Cliente " + lbl_id_cliente.Text;

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

                            ClaseComun.Modificar(Clases.clsBD.BD,tbl_cliente, ref bolResult);
                            if (bolResult == true)
                            {

                                MessageBox.Show("Dato Guardado y se va a generar documento de Certificado");

                                SqlCommand cmd = new SqlCommand();
                                cmd.CommandText = "pa_Sucursal_ins '" + txt_run.Text + "','" + txt_direccion.Text + "'," + cbx_id_region.SelectedValue + "," +
                                                       cbx_id_provincia.SelectedValue + "," + cbx_id_comuna.SelectedValue + ",'" + txt_telefono.Text + "',1";
                                cmd.CommandType = CommandType.Text;
                                Conectar.AgregarModificarEliminar(Clases.clsBD.BD,cmd);



                                 SqlCommand cmd1 = new SqlCommand();
                                cmd1.CommandText = "insert into tbl_cliente_Historial " +
                                  "(Id_cliente,N_Cliente_Ref,run,Razon_Social,Direccion,Id_Region,Id_Provincia,Id_Comuna,Telefono,Id_TipoFuente,Id_estado,FechaInicio,Email,Clave,Servicio,Id_TipoEntidad,Id_Sector,id_Ministerio,Director,Opr)" +
                                  "SELECT Id_cliente,N_Cliente_Ref,run,Razon_Social,Direccion,Id_Region,Id_Provincia,Id_Comuna,Telefono,Id_TipoFuente,Id_estado,FechaInicio,Email,Clave,Servicio " +
                                  ",Id_TipoEntidad,Id_Sector,id_Ministerio,Director,Opr " +
                                  "FROM [dbo].[tbl_cliente] where id_cliente=" + txt_id_cliente.Text ;
                                cmd1.CommandType = CommandType.Text;
                                Conectar.AgregarModificarEliminar(Clases.clsBD.BD,cmd1);
                                


                                SqlCommand cmdArchivo = new SqlCommand();
                                //SqlCommand cmdcombo = new SqlCommand();
                                DataSet dtArchivo;
                                cmdArchivo.CommandText = "" +
                                  "SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=6 order by orden ";
                                cmdArchivo.CommandType = CommandType.Text;
                                dtArchivo = Conectar.Listar(Clases.clsBD.BD,cmdArchivo);

                                DataSet dtformato;
                                cmdArchivo.CommandText = "" +
                                  "SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=5 order by orden ";
                                cmdArchivo.CommandType = CommandType.Text;
                                dtformato = Conectar.Listar(Clases.clsBD.BD,cmdArchivo);

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
				if(cbx_id_estado.Text =="1")
                    cbx_id_periodo.Enabled = true;
				else
                    cbx_id_periodo.Enabled = false;

		}

        private void txt_Clave1_TextChanged(object sender, EventArgs e)
        {
            txt_Clave.Text = clsUtiles1.GenerateHashMD5(txt_Clave1.Text );  
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
    }
}
