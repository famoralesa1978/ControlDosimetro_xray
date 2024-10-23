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
    public partial class frmParametroMant : Form
    {
        #region "Definicion variable"
		 clsConectorSqlServer clsConector = new dllConectorMysql.clsConectorSqlServer();


		 clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
        #endregion

         public frmParametroMant(Int64 intCodigo)
        {
            InitializeComponent();
            Cargar_Estado();
            if (intCodigo == 0)
            {
                btn_Grabar.Text = "Grabar";
                this.Text = "Agregar Configuración de parametro";
                cargar_valor_maximo();
                //
            }
            else
            {
                btn_Grabar.Text = "Modificar";
                this.Text = "Modificar Configuración de parametro";
                txt_ID.Text =intCodigo.ToString() ;
                SqlCommand cmd = new SqlCommand();
				//	 SqlCommand cmd = new SqlCommand();
           
                cmd.CommandText = "SELECT descripcion,orden,id_estado FROM conf_parametro where id_parametro= " + intCodigo.ToString() ;
                DataSet dt;
					 dt = clsConector.Listar(ClaseGeneral.Conexion,cmd);

                txt_Descripcion.Text = dt.Tables[0].Rows[0][0].ToString();
                txt_Orden.Text = dt.Tables[0].Rows[0][1].ToString();
                cbx_EstadoId.Text = dt.Tables[0].Rows[0][2].ToString();
                cbx_Estado.SelectedIndex = cbx_EstadoId.SelectedIndex; 
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        #region "Llamada de carga"

        private void cargar_valor_maximo()
        {
            SqlCommand cmd = new SqlCommand();

	//		  SqlCommand cmd = new SqlCommand();
            //MessageBox.Show("Conectado al servidor");


			  cmd.CommandText = "SELECT max(ID_PARAMETRO)+1 as valor FROM conf_parametro";
     

            DataSet dt;
				dt = clsConector.Listar(ClaseGeneral.Conexion,cmd);

            txt_ID.Text = dt.Tables[0].Rows[0][0].ToString();    
        }

        private void Cargar_Estado()
        {
            ClaseComun.Listar_Estado(ClaseGeneral.Conexion,ref cbx_Estado, ref cbx_EstadoId);
        }

        #endregion

        #region"Button"
            private void btn_Cerrar_Click(object sender, EventArgs e)
            {
                Cursor = Cursors.WaitCursor;

                this.Close();

                Cursor = Cursors.Default;
            }

            private void btn_Grabar_Click(object sender, EventArgs e)
            {

                Cursor = Cursors.WaitCursor;
                
                if (MessageBox.Show("Desea grabar la información", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    SqlCommand cmd = new SqlCommand();

//						 SqlCommand cmd = new SqlCommand();
                    
                    cmd.CommandType = CommandType.Text ;                  

                    if (btn_Grabar.Text == "Modificar")
                    {
							  cmd.CommandText = "update conf_parametro set Descripcion='" + txt_Descripcion.Text.ToString() + "',Orden=" + txt_Orden.Text.ToString() + 
													", Id_Estado=" + cbx_EstadoId.Text.ToString() +
													" where Id_Parametro=" + txt_ID.Text.ToString();

								clsConector.AgregarModificarEliminar(ClaseGeneral.Conexion,cmd);

                        MessageBox.Show("Dato Modificado"); 
                    }
                    else
                    {
							  cmd.CommandText = "INSERT INTO conf_parametro (Id_Parametro, Descripcion, Orden,Id_Estado) " +
													"VALUES (" + txt_ID.Text.ToString() + ",'" + txt_Descripcion.Text.ToString() + "', " + txt_Orden.Text.ToString() + ", " + cbx_EstadoId.Text.ToString() + ")";

								clsConector.AgregarModificarEliminar(ClaseGeneral.Conexion,cmd);

                        MessageBox.Show("Dato Guardado"); 

                    }
                    this.Close();
                }

                 Cursor = Cursors.Default;
            }

        #endregion

           

       
    }
}
