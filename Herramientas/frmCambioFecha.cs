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
            Cargar_FechaInicio();
            Cargar_PeriodoTermino();
            dtp_FechaDestino.Visible = false;
            dtp_FechaDestinoTermino.Visible = false;

            btn_Guardar.Visible = false;
            btn_GuardarTermino.Visible = false;

            btn_Modificar.Visible = false;
            btn_ModificarTermino.Visible = false;

            cbx_id_periodo.Visible = false;
            cbx_id_periodoTermino.Visible = false;
            
        }

        #endregion
        
        #region "Llamado a Carga"
        private void Cargar_Cliente(Int64 intCodCliente)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select run,Razon_Social,N_Cliente_Ref, Fechainicio " +
                            "  FROM tbl_cliente WHERE Id_cliente= " + intCodCliente.ToString();
            DataSet dt;

            dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);
            if (dt.Tables[0].Rows.Count > 0)
            {
                lbl_id_cliente.Text = intCodCliente.ToString();
                lbl_run.Text = dt.Tables[0].Rows[0]["run"].ToString();
                lbl_nombrecliente.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
                dtp_FechaInicio.Text = dt.Tables[0].Rows[0]["FechaInicio"].ToString();
                btn_Modificar.Visible = true;
                btn_ModificarTermino.Visible = true;
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

        private void Cargar_FechaInicio()
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT Fecha_Inicio FROM conf_periodo Order by id_periodo desc";
            DataSet dt;
            dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

            cbx_id_periodo.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
            cbx_id_periodo.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
            cbx_id_periodo.DataSource = dt.Tables[0];
            dtp_FechaDestino.Text = cbx_id_periodo.Text;
        }

        private void Cargar_FechaTermino(string intCodCliente, string fechaInicio)
        {
            SqlCommand cmd = new SqlCommand();
            
            cmd.CommandText = "Select FechaTermino FROM tbl_observacioncliente where id_cliente = " + intCodCliente.ToString() + "and FechaInicio = '" + dtp_FechaInicio.Text+"'";
            cmd.CommandType = CommandType.Text;
            DataSet dt;
            dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

            if (dt.Tables[0].Rows.Count > 0)
            {
                dtp_FechaTermino.Enabled = true;
                dtp_FechaTermino.Text = dt.Tables[0].Rows[0]["FechaTermino"].ToString();
            }
            else {
                dtp_FechaTermino.Text = "No asignada";
                btn_ModificarTermino.Visible = false;
            }

        }

        private void Cargar_PeriodoTermino()
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "pa_ListarPeriodoFechaTermino_sel";
            DataSet dt;
            dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

            cbx_id_periodoTermino.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
            cbx_id_periodoTermino.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
            cbx_id_periodoTermino.DataSource = dt.Tables[0];
            dtp_FechaDestinoTermino.Text = cbx_id_periodo.SelectedValue.ToString();
        }

        private void LimpiarControl()
        {

            lbl_id_cliente.Text = "";
            lbl_nombrecliente.Text = "Razón Social";
            lbl_run.Text = "12345678-9";
            // dtp_FechaInicio.Value = DateTime.Now;
            //  dtp_FechaTermino.Value = DateTime.Now;
            dtp_FechaDestino.Visible = false;
            dtp_FechaDestinoTermino.Visible = false;
            dtp_FechaInicio.Text = "Fecha Inicio";
            dtp_FechaDestino.Text = "";
            dtp_FechaTermino.Text = "Fecha Termino";
            dtp_FechaDestinoTermino.Text = "";
            btn_Guardar.Visible = false;
            btn_GuardarTermino.Visible = false;

            btn_Modificar.Visible = false;
            btn_ModificarTermino.Visible = false;

            cbx_id_periodo.Visible = false;
            cbx_id_periodoTermino.Visible = false;
        }

        private void Limpiar() {
            btn_Guardar.Visible = false;
            btn_GuardarTermino.Visible = false;
            cbx_id_periodo.Visible = false;
            cbx_id_periodoTermino.Visible = false;
            dtp_FechaDestino.Visible = false;
            dtp_FechaDestinoTermino.Visible = false;
        }

        #endregion

        #region "Botones"

        private void btn_CargarCliente_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            Limpiar();       
            if (!String.IsNullOrEmpty(lbl_id_cliente.Text) && (Convert.ToInt64(lbl_id_cliente.Text)) != 0)
            {
                Cargar_Cliente(Convert.ToInt64(lbl_id_cliente.Text));
                Cargar_FechaTermino(lbl_id_cliente.Text, dtp_FechaInicio.Text);
            }
            else
            {
                MessageBox.Show("Debe ingresar el N° de Cliente");
            }

              Cursor = Cursors.Default;
            
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            dtp_FechaDestino.Visible = true;
            cbx_id_periodo.Visible = true;
            btn_Guardar.Visible = true;
            dtp_FechaDestino.Text = cbx_id_periodo.Text;
            Cursor = Cursors.Default;
        }

        private void btn_ModificarTermino_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

                dtp_FechaDestinoTermino.Visible = true;
                cbx_id_periodoTermino.Visible = true;
                btn_GuardarTermino.Visible = true;
                dtp_FechaDestinoTermino.Text = cbx_id_periodoTermino.Text;
            
            Cursor = Cursors.Default;
        }


        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds;
            string strParametro = String.Format("{0},'{1}','{2}','{3}','{4}'", lbl_id_cliente.Text, lbl_run.Text, lbl_nombrecliente.Text, dtp_FechaInicio.Text, dtp_FechaDestino.Text);
            cmd.CommandText = "pa_CambiarFecha_upd " + strParametro;
            cmd.CommandType = CommandType.Text;


            ds = Conectar.Listar(ClaseGeneral.Conexion, cmd);
            if (Convert.ToInt16(ds.Tables[0].Rows[0][0].ToString()) != 0)
            {
                MessageBox.Show("Error en actualizar la información");
            }

            else
                MessageBox.Show(ds.Tables[0].Rows[0][1].ToString());

            LimpiarControl();
        }
        private void btn_GuardarTermino_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            //    Boolean bolResult;
            //    bolResult = false;

            //    if (MessageBox.Show("Desea modificar?", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            //    {

            //        ClaseComun.Insertar(ClaseGeneral.Conexion, tbl_observacioncliente, ref bolResult);
            //        //    //if (bolResult == true)
            //        //    //{
            //        //    //    SqlCommand cmd = new SqlCommand();
            //        //    //    cmd.CommandText = "update tbl_cliente_Historial set FechaTermino=" + dtp_FechaTermino.Text + " where FechaTermino is null and id_cliente=" + lbl_Id_Cliente.Text + " and run='" + lbl_rut.Text + "'";
            //        //    //    cmd.CommandType = CommandType.Text;

            //        //    //    Conectar.AgregarModificarEliminar(ClaseGeneral.Conexion, cmd);
            //        //    //    MessageBox.Show("Observación  Ingresada");
            //        //    //    this.Close();
            //        //    //}

            //    }

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "Update tbl_observacioncliente set FechaTermino='" + dtp_FechaDestinoTermino.Text + "' where id_cliente = " + lbl_id_cliente.Text + "and FechaInicio = '" + dtp_FechaInicio.Text + "'";
            cmd.CommandType = CommandType.Text;
            DataSet dt;
            dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

            MessageBox.Show("Fecha de Término modificada");

            LimpiarControl();

            Cursor = Cursors.Default;
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LimpiarControl();
            Cursor = Cursors.Default;
        }

        #endregion
        

        private void cbx_id_periodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtp_FechaDestino.Text = cbx_id_periodo.Text;
        }

        private void cbx_id_periodoTermino_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtp_FechaDestinoTermino.Text = cbx_id_periodoTermino.Text;
        }

      
    }
}