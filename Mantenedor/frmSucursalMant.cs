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
    public partial class frmSucursalMant : Form
    {
        #region "Definicion variable"
		 clsConectorSqlServer Conectar = new clsConectorSqlServer();
		 clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
        clsEventoControl ClaseEvento = new clsEventoControl();
        int casa_matriz_ins;

        dllLibreriaMysql.clsUtiles clsUtiles1 = new dllLibreriaMysql.clsUtiles();
        #endregion


        public frmSucursalMant(Int64 intCodigo, Int64 codcliente)
        {
            InitializeComponent();
            AsignarEvento();
            Cargar_Region();
            Cargar_Estado();
            Cargar_Cliente(codcliente);
            lbl_id_Sucursal.Text = intCodigo.ToString();
            if (intCodigo == 0)
            {
                btn_Grabar.Text = "Grabar";
                this.Text = "Agregar Sucursal";
                txt_id_cliente.Enabled = false;
				cbx_id_estado.Enabled = false;
                casa_matriz_ins = 0;
                //cargar_valor_maximo();
                //
            }
            else
            {
                btn_Grabar.Text = "Modificar";
                this.Text = "Modificar Sucursal";
                txt_id_cliente.Text = codcliente.ToString();
                txt_id_cliente.Enabled = false;
               // SqlCommand cmd = new SqlCommand();
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "SELECT s.run,s.runsuc,s.razon_social,s.Direccion,s.Id_Region,s.Id_Provincia,s.Id_Comuna,s.Telefono,s.Id_estado,estado_casa_matriz,email " +
                            " FROM tbl_sucursal s  WHERE Id_sucursal= " + intCodigo.ToString();
                DataSet dt;
                dt = Conectar.Listar(Clases.clsBD.BD,cmd);

                txt_run.Text = dt.Tables[0].Rows[0]["run"].ToString();
              //  txt_Razon_Social.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
                txt_direccion.Text = dt.Tables[0].Rows[0]["Direccion"].ToString();
                txt_telefono.Text = dt.Tables[0].Rows[0]["Telefono"].ToString();
                cbx_id_region.SelectedValue = dt.Tables[0].Rows[0]["Id_Region"].ToString();
               // cbx_region.SelectedIndex = cbx_id_region.SelectedIndex;
                Cargar_Provincia();
                cbx_id_provincia.SelectedValue = dt.Tables[0].Rows[0]["Id_Provincia"].ToString();
                Cargar_Comuna();
               // cbx_provincia.SelectedIndex = cbx_id_provincia.SelectedIndex;
                cbx_id_comuna.SelectedValue  = dt.Tables[0].Rows[0]["Id_Comuna"].ToString();
             //   cbx_comuna.SelectedIndex = cbx_id_comuna.SelectedIndex;
                cbx_id_estado.SelectedValue = dt.Tables[0].Rows[0]["Id_estado"].ToString();
                casa_matriz_ins = Convert.ToInt16(dt.Tables[0].Rows[0]["estado_casa_matriz"].ToString());
                if (dt.Tables[0].Rows[0]["estado_casa_matriz"].ToString() == "1")
                    chk_CasaMatriz.Checked = true;
                else
                    chk_CasaMatriz.Checked = false;
                if(dt.Tables[0].Rows[0]["razon_social"].ToString().Trim() != "")
                {
                    txt_Razon_Social.Text = dt.Tables[0].Rows[0]["razon_social"].ToString();
                }

                if (dt.Tables[0].Rows[0]["runsuc"].ToString().Trim() != "")
                {
                    txt_runsuc.Text = dt.Tables[0].Rows[0]["runsuc"].ToString();
                }
                else
                    txt_runsuc.Text = txt_run.Text;

                txt_runsuc.Enabled = false;
                txt_Email.Text = dt.Tables[0].Rows[0]["email"].ToString().Trim() != "" ? dt.Tables[0].Rows[0]["email"].ToString() : "";
            }
        }

        #region "Llamada de carga"  

        private void Cargar_Cliente(Int64 intCodCliente)
        {
            SqlCommand cmd = new SqlCommand();
            //	SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT id_cliente,run,Razon_Social,N_Cliente_Ref,Direccion,Id_Region,Id_Provincia,Id_Comuna,Telefono, Id_TipoFuente,Id_estado,Fechainicio " +
                            " FROM tbl_cliente WHERE Id_cliente= " + intCodCliente.ToString();
            DataSet dt;
            dt = Conectar.Listar(Clases.clsBD.BD,cmd);

            //lbl_id_cliente.Text = intCodCliente.ToString();
            txt_run.Text = dt.Tables[0].Rows[0]["run"].ToString();
            txt_id_cliente.Text = dt.Tables[0].Rows[0]["id_cliente"].ToString();
            txt_Razon_Social.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();            
        }
      
        private void Cargar_Estado()
        {
            ClaseComun.Listar_Estado(Clases.clsBD.BD,ref cbx_id_estado, ref cbx_id_estado);
        }     

        private void Cargar_Region()
        {
            ClaseComun.Listar_Region(Clases.clsBD.BD,ref cbx_id_region, ref cbx_id_region);
        }

        private void Cargar_Provincia()
        {
            ClaseComun.Listar_Provincia(Clases.clsBD.BD,ref cbx_id_provincia, ref cbx_id_provincia, Convert.ToInt16(cbx_id_region.SelectedValue));
        }

        private void Cargar_Comuna()
        {
            ClaseComun.Listar_Comuna(Clases.clsBD.BD,ref cbx_id_comuna, ref cbx_id_comuna, Convert.ToInt16(cbx_id_region.SelectedValue), Convert.ToInt16(cbx_id_provincia.SelectedValue));
        }

        private void AsignarEvento()
		{
            SqlCommand cmd = new SqlCommand();

		//	SqlCommand cmd = new SqlCommand();
			DataSet dt;
			string strname;
			foreach (System.Windows.Forms.Control c in tbl_sucursal.Controls )
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
							((TextBox)c).Leave += new EventHandler(ClaseEvento.run_Leave);
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

		  private bool valida_cliente(int intCodigo)
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

			  Boolean bolResult;
			  bolResult = false;
            if (MessageBox.Show("Desea grabar la información", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (btn_Grabar.Text == "Modificar")
                {

						 ClaseComun.Modificar(Clases.clsBD.BD,tbl_sucursal, ref bolResult);
						 if (bolResult == true)
						 {
                             cambia_direccion();
								 MessageBox.Show("Dato modificado");

							 this.Close();
						 }
						
                }
                else
                {
						
							 ClaseComun.Insertar(Clases.clsBD.BD,tbl_sucursal, ref bolResult);
							 if (bolResult == true)
							 {

								 MessageBox.Show("Dato Guardado");

                                 this.Close();


							 }
					
                }
					
            }

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

        private void txt_direccion_Leave(object sender, EventArgs e)
        {
            txt_direccion.Text = txt_direccion.Text.ToString().Replace("/", "").ToString();
        }

        private void chk_CasaMatriz_CheckedChanged(object sender, EventArgs e)
        {
            casa_matriz_ins = 0;
            if (chk_CasaMatriz.Checked == true)
            {
                casa_matriz_ins = 1;
            }
        }

  private void cambia_direccion()
        {

      
            string dir = txt_direccion.ToString();
            long id_sucu = Convert.ToInt32(lbl_id_Sucursal.Text);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "pa_CambiaDireccionClientesuc_upd '" + txt_run.Text + "','" + txt_direccion.Text + "'," + txt_id_cliente.Text  + "," + id_sucu + "," + casa_matriz_ins;
            
            cmd.CommandType = CommandType.Text;
            DataSet ds;

            ds = Conectar.Listar(Clases.clsBD.BD,cmd);

        }
      


    }
}
