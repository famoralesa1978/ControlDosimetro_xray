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

            AsignarEvento();
            dtp_FechaDestino.Enabled = false;
            lbl_FechaDestino.Enabled = false;
            btn_Guardar.Enabled = false;
            btn_Modificar.Enabled = false;
            dtp_FechaDestino.Visible = false;
            lbl_FechaDestino.Visible = false;
            btn_Guardar.Visible = false;
            btn_Modificar.Visible = false;
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
                dtp_FechaInicio.Text = dt.Tables[0].Rows[0]["FechaInicio"].ToString();
                ;
                btn_Modificar.Visible = true;
                btn_Modificar.Enabled = true;
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

        private void AsignarEvento()
        {
            lbl_id_cliente.KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
            lbl_id_cliente.KeyDown += new KeyEventHandler(ClaseEvento.Numero_KeyDown);
        }

        private void LimpiarControl()
        {

            lbl_id_cliente.Text = "";
            lbl_nombrecliente.Text = "Razón Social";
            lbl_run.Text = "12345678-9";
            dtp_FechaInicio.Enabled = true;
            dtp_FechaDestino.Enabled = false;
            lbl_FechaDestino.Enabled = false;
            btn_Guardar.Enabled = false;
            btn_Modificar.Enabled = false;
            dtp_FechaDestino.Visible = false;
            lbl_FechaDestino.Visible = false;
            btn_Guardar.Visible = false;
            btn_Modificar.Visible = false;
        }

        #endregion

        #region "Botones"

        private void btn_CargarCliente_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
          
            if (!String.IsNullOrEmpty(lbl_id_cliente.Text))
            {
                Cargar_Cliente(Convert.ToInt64(lbl_id_cliente.Text));
            }
            else
            {
                MessageBox.Show("Debe ingresar el N° de Cliente");
            }
            Cursor = Cursors.Default;

        }

        private void btn_Modificar_Click_1(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            dtp_FechaInicio.Enabled = false;
            dtp_FechaDestino.Enabled = true;
            lbl_FechaDestino.Enabled = true;
            btn_Guardar.Enabled = true;
            dtp_FechaDestino.Visible = true;
            lbl_FechaDestino.Visible = true;
            btn_Guardar.Visible = true;
            Cursor = Cursors.Default;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string fecha = dtp_FechaDestino.Value.ToShortDateString();

            SqlCommand cmd = new SqlCommand();
            DataSet ds;
            string strParametro = String.Format("{0},'{1}','{2}','{3}','{4}'", lbl_id_cliente.Text, lbl_run.Text, lbl_nombrecliente.Text, dtp_FechaInicio.Text, dtp_FechaDestino.Text);
            cmd.CommandText = "pa_CambiarFecha_upd " + strParametro;
            cmd.CommandType = CommandType.Text;
            

            ds = Conectar.Listar(Clases.clsBD.BD, cmd);
            if (Convert.ToInt16( ds.Tables[0].Rows[0][0].ToString()) != 0)
            {
                MessageBox.Show("Error en actualizar la información");
            }

            else
                MessageBox.Show(ds.Tables[0].Rows[0][1].ToString());

            LimpiarControl();

        }


        #endregion



        private void dtp_FechaDestino_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dtp_FechaDestino.Value;
        }

      
    }
}