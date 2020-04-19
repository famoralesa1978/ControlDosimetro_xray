using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dllConectorMysql;
using dllLibreriaEvento;
using dllLibreriaMysql;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;


namespace ControlDosimetro
{
    public partial class frmRptPorEstado : Form
    {
        #region "Definicion variable"
        clsConectorSqlServer Conectar = new clsConectorSqlServer();
        clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
        clsEventoControl ClaseEvento = new clsEventoControl();

        #endregion

        public frmRptPorEstado()
        {
            InitializeComponent();
            Cargar_Anno();
            Cargar_Periodo();
            Cargar_Estado();
        }

        #region "Llamada de carga"

        private void Cargar_Anno()
        {
            SqlCommand cmd = new SqlCommand();

            //	  SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT distinct Anno FROM conf_periodo WHERE Id_TipoPeriodo=3";
            //cmd.CommandText = "SELECT Id_Periodo,Anno, Mes,Id_TipoPeriodo FROM conf_periodo WHERE Id_TipoPeriodo=3";
            DataSet dt;
            dt = Conectar.Listar(cmd);

            cbx_anno.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
            cbx_anno.DataSource = dt.Tables[0];

        }

        private void Cargar_Periodo()
        {
            SqlCommand cmd = new SqlCommand();

            //	  SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT Id_Periodo,Mes, cast((mes/3) as varchar(10))+ '°T' FROM conf_periodo WHERE Id_TipoPeriodo=3 and Anno=" + cbx_anno.Text;
            DataSet dt;
            dt = Conectar.Listar(cmd);

            cbx_periodo.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
            cbx_periodo.DisplayMember = dt.Tables[0].Columns[2].Caption.ToString();
            cbx_periodo.DataSource = dt.Tables[0];

        }

        private void Cargar_Estado()
        {
            SqlCommand cmd = new SqlCommand();

            //	  SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT Id,Descripcion FROM glo_estadodosimetro";
            DataSet dt;
            dt = Conectar.Listar(cmd);

            cbx_Estado.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
            cbx_Estado.DisplayMember = dt.Tables[0].Columns[1].Caption.ToString();
            cbx_Estado.DataSource = dt.Tables[0];

        }

        private void AsignarEvento()
        {
            //this.txt_Rut.KeyPress += new KeyPressEventHandler(ClaseEvento.Rut_KeyPress);
            //txt_Rut.KeyDown += new KeyEventHandler(ClaseEvento.Rut_KeyDown);
            //txt_Rut.Validated += new EventHandler(ClaseEvento.validarut_Validated);

            //            txt_CodCliente.KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
            //            txt_CodCliente.KeyDown += new KeyEventHandler(ClaseEvento.Numero_KeyDown);

            //txt_NDocumento.KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
            //txt_NDocumento.KeyDown += new KeyEventHandler(ClaseEvento.Numero_KeyDown);

            //txt_RazonSocial.KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);


        }

        #endregion

        private void frmRpDosimetria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistiamc_controlDataSet2.rtpDosimetria' Puede moverla o quitarla según sea necesario.
            //this.rtpDosimetriaTableAdapter.Fill(this.sistiamc_controlDataSet2.rtpDosimetria);

            //this.reportViewer1.RefreshReport();
        }

         private void btn_reporteNCliente_Click(object sender, EventArgs e)
        {
            //  DataSet dt;
            //int intanno;

            

            //intanno = Convert.ToInt64(cbx_anno.Text);
            //if (txt_NumeroCliente.Text.Trim() != "")
            //{
            //    dt = ClaseComun.RptDosimetria(Convert.ToInt64(txt_NumeroCliente.Text) ,0, "0", intanno);
            //    Llamado_reporte(dt);
            //}
            //else
            //    MessageBox.Show("Debe Ingresar el Número de cliente");
            
        }

         private void cbx_anno_SelectedIndexChanged(object sender, EventArgs e)
         {
             Cargar_Periodo();
         }

         private void btn_Reporte_Click(object sender, EventArgs e)
         {
             DataSet dt;
             dt = Llamadoreporte();

             frmreporte frm = new frmreporte(dt, dt, 3);
             frm.Show(this);
         }

         public DataSet Llamadoreporte()
         {
             DataSet ds = new DataSet();
             SqlCommand cmd = new SqlCommand();
             // SqlCommand cmd = new SqlCommand();
             //MessageBox.Show("Conectado al servidor");

             cmd.CommandText = "rtpEstadoDosimetro " + cbx_Estado.SelectedValue.ToString() + "," + cbx_periodo.SelectedValue.ToString() + ",0"; 

             //"SELECT * FROM " +tabla.Name.ToString();// WHERE TABLE_SCHEMA = 'bd_sistema' AND "// +
             // "TABLE_NAME = '" + tabla.Name.ToString()    + "'";
             cmd.CommandType = CommandType.Text;

             ds = Conectar.Listar(cmd);
             return ds;
         }
        //public void Llamado_reporte(DataSet ds)
        //{
        //    DataSet dtformato;
        //    SqlCommand cmdArchivo = new SqlCommand();
        //    cmdArchivo.CommandText = "" +
        //      "SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=7 order by orden ";
        //    cmdArchivo.CommandType = CommandType.Text;
        //    dtformato = Conectar.Listar(cmdArchivo);
        //    // string targetPath = @ConfigurationManager.AppSettings["Archivo"] + "Cliente " + lbl_id_cliente.Text;
        //    string targetPath = @dtformato.Tables[0].Rows[0]["Glosa"].ToString();
        //    reportViewer1.LocalReport.ReportEmbeddedResource = "ControlDosimetro.reporte.rptDosimetria.rdlc"; 
        //    //reportViewer1.LocalReport.ReportPath = targetPath + "rptDosimetria.rdlc"; 
        //    ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);

        //    this.reportViewer1.LocalReport.DataSources.Clear();

        //    this.reportViewer1.LocalReport.DataSources.Add(datasource);

        //    this.reportViewer1.RefreshReport();

        //}

        //private void btn_ReporteRegion_Click(object sender, EventArgs e)
        //{
        //    DataSet dt;
        //    int intanno;



        //    intanno = Convert.ToInt64(cbx_anno.Text);
        //    if (cbx_Region.Text.Trim() != "")
        //    {
        //        dt = ClaseComun.RptDosimetria(0, Convert.ToInt64(cbx_Region.Text), "0", intanno);
        //        Llamado_reporte(dt);
        //    }
        //    else
        //        MessageBox.Show("Debe Ingresar el Número de cliente");
        //}

       
    }
}
