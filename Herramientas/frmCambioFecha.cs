using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using dllConectorMysql;
using dllLibreriaEvento;
using dllLibreriaMysql;

namespace ControlDosimetro.Herramientas
{
    public partial class frmCambioFecha : Form
    {
        #region "Definición de variables"

        clsConectorSqlServer Conectar = new clsConectorSqlServer();
        clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
        clsEventoControl ClaseEvento = new clsEventoControl();

        #endregion

        #region "Inicio"

        public frmCambioFecha(Int64 intId_Cliente)
        {
            InitializeComponent();
        }

        #endregion


        #region "Llamado a Carga"
        private void Cargar_Cliente(Int64 intCodCliente)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select run,Razon_Social,N_Cliente_Ref, Fechainicio " +
                            "  FROM tbl_cliente WHERE Id_cliente= " + intCodCliente.ToString();
            DataSet dt;

            dt = Conectar.Listar(Clases.clsBD.BD, cmd);
            if (dt.Tables[0].Rows.Count > 0)
            {
                lbl_id_cliente.Text = intCodCliente.ToString();
                lbl_run.Text = dt.Tables[0].Rows[0]["run"].ToString();
                lbl_nombrecliente.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
                dtp_FechaInicio.Text= dt.Tables[0].Rows[0]["FechaInicio"].ToString();
            }
            else
            {
                lbl_id_cliente.Text = "";
                lbl_nombrecliente.Text = "";
                lbl_run.Text = "";
                dtp_FechaInicio.Text = "";
                if (intCodCliente != 0)
                    MessageBox.Show("El cliente no existe");

            }

        }



        #endregion

        #region "Botones"

        private void btn_CargarCliente_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Cargar_Cliente(Convert.ToInt64(lbl_id_cliente.Text));
            Cursor = Cursors.Default;
        }


        #endregion
        
     
    }
}