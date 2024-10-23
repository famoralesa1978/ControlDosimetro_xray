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
    public partial class frmCambioContrasena : Form
    {
        #region "Definicion variable"
        clsConectorSqlServer Conectar = new clsConectorSqlServer();
		  clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
        clsEventoControl ClaseEvento = new clsEventoControl();
        dllLibreriaMysql.clsUtiles clsUtiles1 = new dllLibreriaMysql.clsUtiles();
        #endregion


        public frmCambioContrasena()
        {
            InitializeComponent();
            lbl_Id_Usuario.Text = Clases.clsUsuario.Id_Usuario.ToString();
        }

        #region "Llamada de carga"  
        private void Cargar_Usuario(Int64 intCodUsuario)
        {
            SqlCommand cmd = new SqlCommand();
			//  SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT [Id_Usuario],[Rut],[Nombres],[Paterno],[Maternos],[Id_perfil],[Id_estado],[Usuario],[Contraseña],[Fecha_agregado],[Fecha_Modificacion]" +
                              " FROM [dbo].[tbl_Usuario] WHERE Id_Usuario= " + intCodUsuario.ToString();
			  DataSet dt;
			  dt = Conectar.Listar(ClaseGeneral.Conexion,cmd);

              // cbx_id_estado.SelectedValue  = cbx_id_estado.SelectedIndex;
              txt_Contraseña.Text = dt.Tables[0].Rows[0]["Contraseña"].ToString();
              try
              {
                  txt_Contraseña1.Text = clsUtiles1.DecryptTripleDES(dt.Tables[0].Rows[0]["Contraseña"].ToString());
              }
              catch (Exception)
              {

                  txt_Contraseña1.Text = clsUtiles1.GenerateHashMD5(dt.Tables[0].Rows[0]["Contraseña"].ToString());
                  txt_Contraseña.Text = dt.Tables[0].Rows[0]["Contraseña"].ToString();
              }
        }

        #endregion

        #region "button"
        private void btn_Grabar_Click(object sender, EventArgs e)
        {
            if(verificar_Grabado()==true)
            { 
                Boolean bolResult;
                bolResult = false;
                if (MessageBox.Show("Desea modifica la contraseña", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    ClaseComun.ModificarDatos(ClaseGeneral.Conexion,tbl_Usuario, ref bolResult);
                    if (bolResult == true)
                    {

                        MessageBox.Show("Dato modificado");
                        if (MessageBox.Show("Desea salir del formulario", "Confirmar", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                        {
                            this.Close();
                        }
                    }
                }
            }
        }

          private Boolean verificar_Grabado()
          {
            Boolean resultado = true;
              if (btn_Grabar.Enabled == true)
              {
                if (txt_ContrasenaActual.Text != "" || txt_Contraseña.Text != "")
                {
                    if (txt_ContrasenaActual.Text != clsUtiles1.DecryptTripleDES(Clases.clsUsuario.Contraseña))
                    {
                        resultado = false;
                        MessageBox.Show("La contraseña actual es distinta con la contraseña ingresada");
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar la contraseña actual o la contraseña modificada");
                    resultado = false;
                }
            }

            return resultado;

          }
        #endregion

        #region "combobox"


        #endregion

        #region textbox
                private void txt_Contraseña1_TextChanged(object sender, EventArgs e)
                {
                    txt_Contraseña.Text = clsUtiles1.GenerateHashMD5(txt_Contraseña1.Text);
                }

        #endregion

    }
}
