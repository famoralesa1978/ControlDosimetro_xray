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
    public partial class frmCambiarFechaControl : Form
    {
        #region "Definición de variables"

        clsConectorSqlServer Conectar = new clsConectorSqlServer();
        clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
        clsEventoControl ClaseEvento = new clsEventoControl();

        #endregion

        #region "Inicio"

        public frmCambiarFechaControl()
        {
            InitializeComponent();
        }

        #endregion


        #region "Llamado a Carga"
        private void Cargar_Cliente(Int64 intCodCliente)
        {
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "select run,Razon_Social,N_Cliente_Ref,region + ','+ comuna +','+Direccion as Direccion, Id_Region, Id_Provincia, Id_Comuna,Telefono, Id_TipoFuente,Id_estado,Fechainicio " +
            //                "  FROM tbl_cliente WHERE Id_cliente= " + intCodCliente.ToString();
            //DataSet dt;

            //dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);
            //if (dt.Tables[0].Rows.Count > 0)
            //{
            //    lbl_id_cliente.Text = intCodCliente.ToString();
            //    lbl_run.Text = dt.Tables[0].Rows[0]["run"].ToString();
            //    lbl_nombreCliente.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
            //    //btn_cargar.Enabled = true;
            //    //btn_Cargar_cliente.Enabled = false;
            //    //lbl_id_cliente.Enabled = false;
            //    //cbx_anno.Enabled = true;
            //    //cbx_id_periodo.Enabled = true;
            //}
            //else
            //{
            //    btn_CargarCliente.Enabled = true;
            //    //lbl_id_cliente.Text = "";
            //    //btn_cargar.Enabled = false;
            //    lbl_id_cliente.Enabled = true;
            //    //lbl_nombreCliente.Text = "";
            //    lbl_run.Text = "";
            //    if (intCodCliente != 0)
            //        MessageBox.Show("El cliente no existe");

            //}



            //
        }

        #endregion

        #region "Botones"
        private void btn_CargarCliente_Click(object sender, EventArgs e)
        {
            //Cursor = Cursors.WaitCursor;
            //Cargar_Cliente(Convert.ToInt64(lbl_id_cliente.Text));
            Cursor = Cursors.Default;
        }

        #endregion


    }
}

