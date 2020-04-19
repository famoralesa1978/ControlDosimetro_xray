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
    public partial class frmObservacionCliente : Form
    {
        #region "Definicion variable"
        clsConectorSqlServer Conectar = new clsConectorSqlServer();
		  clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
        #endregion


        public frmObservacionCliente(string idCliente, string strfechaInicio)
        {
            InitializeComponent();
				dtp_FechaInicio.Text  = strfechaInicio;
                
            lbl_Id_Cliente.Text = idCliente;
            Cargar_Cliente();
            Cargar_Fecha();
        }

        #region "Llamada de carga"

        private void Cargar_Fecha()
        {
            SqlCommand cmd = new SqlCommand();

            //	  SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "pa_ListarPeriodoFechaTermino_sel";
            DataSet dt;
            dt = Conectar.Listar(cmd);

            cbx_id_periodo.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
            cbx_id_periodo.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
            cbx_id_periodo.DataSource = dt.Tables[0];
            dtp_FechaTermino.Text = cbx_id_periodo.SelectedValue.ToString();
        }

        private void Cargar_Cliente()
        {
          //  SqlCommand cmd = new SqlCommand();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT run,Razon_Social,Direccion,Id_Region,Id_Provincia,Id_Comuna,Telefono, Id_TipoFuente " +
                        " FROM tbl_cliente WHERE Id_cliente= " + lbl_Id_Cliente.Text.ToString();
            DataSet dt;
            dt = Conectar.Listar(cmd);

            lbl_nombre.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
            lbl_rut.Text = dt.Tables[0].Rows[0]["run"].ToString();
        }

        #endregion
        #region "button"
 

        private void btn_Grabar_Click(object sender, EventArgs e)
        {
			  Boolean bolResult;
			  bolResult = false;
					if (rtb_Observacion.Text.Trim()  == "")
						MessageBox.Show("Debe ingresar una observación");
					else 
						if (MessageBox.Show("Desea grabar la observación", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
						{
							
							ClaseComun.Insertar(tbl_observacioncliente,ref bolResult);
							if (bolResult == true)
							{
                                SqlCommand cmd = new SqlCommand();
                                cmd.CommandText = "update tbl_cliente_Historial set FechaTermino=" + dtp_FechaTermino.Text + " where FechaTermino is null and id_cliente=" + lbl_Id_Cliente.Text + " and run='" + lbl_rut.Text+ "'";
                                cmd.CommandType = CommandType.Text;

                                Conectar.AgregarModificarEliminar(cmd);
								MessageBox.Show("Observación  Ingresada");
								this.Close();
							}

						}
                
            }

        private void cbx_id_periodo_SelectedIndexChanged(object sender, EventArgs e)
        {

            dtp_FechaTermino.Text = cbx_id_periodo.SelectedValue.ToString();
        }
             
        }

        #endregion
        



    
}
