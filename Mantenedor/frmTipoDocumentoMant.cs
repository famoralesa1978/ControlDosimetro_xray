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
    public partial class frmTipoDocumentoMant : Form
    {
        #region "Definicion variable"
        clsConectorSqlServer Conectar = new dllConectorMysql.clsConectorSqlServer();
        clsEventoControl ClaseEvento = new clsEventoControl();

        clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
        #endregion

        public frmTipoDocumentoMant(Int64 intCodigo)
        {
            InitializeComponent();           
            Cargar_Estado();
            AsignarEvento();
            if (intCodigo == 0)
            {
                btn_Grabar.Text = "Grabar";
                this.Text = "Agregar Tipo de Documentos";
                //
            }
            else
            {
                btn_Grabar.Text = "Modificar";
                this.Text = "Modificar Tipo de Documentos";
                txt_id_tipo_doc.Text = intCodigo.ToString();
                SqlCommand cmd = new SqlCommand();
                //	 SqlCommand cmd = new SqlCommand();

                // cmd.CommandText = "SELECT descripcion,orden,id_estado FROM conf_parametro where id_parametro= " + intCodigo.ToString();

                cmd.CommandText = "select  detalle_tipo_documento,id_tipo_doc,orden,id_estado from glo_TipoDocumentos where id_tipo_doc= " + intCodigo.ToString();

                
                DataSet dt;
                dt = Conectar.Listar(Clases.clsBD.BD,cmd);

                txt_detalle_tipo_documento.Text = dt.Tables[0].Rows[0][0].ToString();
                txt_orden.Text = dt.Tables[0].Rows[0][2].ToString();
                cbx_id_estado.SelectedValue = dt.Tables[0].Rows[0][3].ToString();
            }
        }

        private void Cargar_Estado()
        {
            ClaseComun.Listar_Estado(Clases.clsBD.BD,ref cbx_id_estado, ref cbx_id_estado);
        }


        private void btn_Grabar_Click(object sender, EventArgs e)
        {
            Boolean bolResult;
            bolResult = false;
            if (MessageBox.Show("Desea grabar la información", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (btn_Grabar.Text == "Modificar")
                {

                    ClaseComun.Modificar(Clases.clsBD.BD,glo_TipoDocumentos, ref bolResult);
                    if (bolResult == true)
                    {

                        MessageBox.Show("Dato modificado");

                        this.Close();
                    }

                }
                else
                {

                    ClaseComun.Insertar(Clases.clsBD.BD,glo_TipoDocumentos, ref bolResult);
                    if (bolResult == true)
                    {

                        MessageBox.Show("Dato Guardado");

                        this.Close();


                    }

                }

            }
        }


        private void AsignarEvento()
        {
            SqlCommand cmd = new SqlCommand();

            //	SqlCommand cmd = new SqlCommand();
            DataSet dt;
            string strname;
            foreach (System.Windows.Forms.Control c in glo_TipoDocumentos.Controls)
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
        

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
