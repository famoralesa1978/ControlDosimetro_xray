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
    public partial class frmRestablecerContrasenaCliente : Form
    {
        #region "Definicion variable"
        clsConectorSqlServer Conectar = new clsConectorSqlServer();
		  clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
        clsEventoControl ClaseEvento = new clsEventoControl();
        dllLibreriaMysql.clsUtiles clsUtiles1 = new dllLibreriaMysql.clsUtiles();
        #endregion


        public frmRestablecerContrasenaCliente()
        {
            InitializeComponent();
            AsignarEvento();
        }

        #region "Llamada de carga"  
      
        private void AsignarEvento()
        {
            SqlCommand cmd = new SqlCommand();

            //	SqlCommand cmd = new SqlCommand();
            DataSet dt;
            string strname;
            foreach (System.Windows.Forms.Control c in tbl_Usuario.Controls)
            {
                //foreach (Control childc in c.Controls)
                //{
                if (c is TextBox)
                {

                    strname = ((TextBox)c).Name;

                    cmd.CommandText = "SELECT  requerido, validacion " +
                                        " FROM glo_configuracioncampo WHERE campo= '" + strname.Replace("txt_", "") + "'";

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
                if (c is DateTimePicker)
                    ((DateTimePicker)c).KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);

            }

        }

        #endregion

        #region "button"
        private void btn_Grabar_Click(object sender, EventArgs e)
        {
          
            //     if (MessageBox.Show("Desea modifica la contraseña", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            //    {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "pa_RestablecercontrasenaCliente_upd '" + txt_run.Text +"','" + txt_Clave.Text + "'";
            DataSet ds=Conectar.Listar(Clases.clsBD.BD, cmd);

            if(ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    SqlCommand cmd1 = new SqlCommand
                    {
                        CommandText = "pa_ConfCorreo_sel"
                    };
                    DataSet dt;

                    dt = Conectar.Listar(Clases.clsBD.BD, cmd1);
                    if (dt.Tables[0].Rows.Count > 0)
                    {
                        RichTextBox rtbCuerpo = new RichTextBox();
                        ListBox listBox2 = new ListBox();
                        rtbCuerpo.Text = "Restablecer clave \n Usuario : " + txt_run.Text +" \n Clave:" + txt_Clave1.Text;

                        clsUtiles1.SendMailGmail(rtbCuerpo,"Xray", "Restablecer clave", txt_Email.Text, listBox2, dt.Tables[0].Rows[0]["Desde"].ToString(),
                                dt.Tables[0].Rows[0]["Credencial"].ToString(), dt.Tables[0].Rows[0]["Clave"].ToString(), dt.Tables[0].Rows[0]["Host"].ToString(),
                                Convert.ToInt16(dt.Tables[0].Rows[0]["Port"].ToString()));
                    }
                }
            }
        }

        private void btn_RestablecerContrasena_Click(object sender, EventArgs e)
        {
            txt_Clave1.Text = txt_run.Text.Substring(txt_run.Text.Length - 8, 6);
        }

        #endregion

        #region "combobox"


        #endregion

        #region textbox
        private void txt_Contraseña1_TextChanged(object sender, EventArgs e)
        {
            txt_Clave.Text = clsUtiles1.GenerateHashMD5(txt_Clave1.Text);
        }

        private void txt_run_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txt_run.Text.Trim() != "")
                {
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "SELECT run,Razon_Social,Email " +
                           " FROM tbl_cliente WHERE run= '" + txt_run.Text + "'" +
                           " union " +
                           " SELECT run,Razon_Social,Email " +
                           " FROM tbl_cliente_Historial WHERE run= '" + txt_run.Text + "'";
                    DataSet dt;
                    dt = Conectar.Listar(Clases.clsBD.BD,cmd);

                    if (dt != null)
                    {
                        if (dt.Tables[0].Rows.Count > 0)
                        {
                            txt_Email.Text = dt.Tables[0].Rows[0]["Email"].ToString();
                            txt_Razon_Social.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
                            txt_run.Enabled = false;
                            btn_Grabar.Enabled = txt_Email.Text != "" ? true : false;
                            btn_RestablecerContrasena.Enabled = true;
                        }
                        else
                        {
                            btn_Grabar.Enabled = false;
                            btn_RestablecerContrasena.Enabled = false;
                        }
                    }
                }
            }
        }

        #endregion
    }
}
