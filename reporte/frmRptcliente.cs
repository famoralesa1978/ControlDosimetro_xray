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
    public partial class frmRptcliente : Form
    {
        #region "Definicion variable"
        clsConectorSqlServer Conectar = new clsConectorSqlServer();
        clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
        clsEventoControl ClaseEvento = new clsEventoControl();

        #endregion

        public frmRptcliente()
        {
            InitializeComponent();           
            txt_NCliente.KeyPress += new KeyPressEventHandler(ClaseEvento.Rut_KeyPress);
            txt_NCliente.KeyDown += new KeyEventHandler(ClaseEvento.Rut_KeyDown);
            //if (tabControl1.SelectedIndex == 0)
            //{
            //    label4.Visible = false;
            //    cbx_anno.Visible = false;
            //}           
        }

        private void frmRpDosimetria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistiamc_controlDataSet2.rtpDosimetria' Puede moverla o quitarla según sea necesario.
            //this.rtpDosimetriaTableAdapter.Fill(this.sistiamc_controlDataSet2.rtpDosimetria);

            //this.reportViewer1.RefreshReport();
        }
        public void Llamado_reporte(DataSet ds,String NombreReporte)
        {
            DataSet dtformato;
            SqlCommand cmdArchivo = new SqlCommand();
            cmdArchivo.CommandText = "" +
              "SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=7 order by orden ";
            cmdArchivo.CommandType = CommandType.Text;
            dtformato = Conectar.Listar(Clases.clsBD.BD,cmdArchivo);
            // string targetPath = @ConfigurationManager.AppSettings["Archivo"] + "Cliente " + lbl_id_cliente.Text;
            string targetPath = @dtformato.Tables[0].Rows[0]["Glosa"].ToString();
            reportViewer1.LocalReport.ReportEmbeddedResource = "ControlDosimetro.reporte." + NombreReporte;
            //reportViewer1.LocalReport.ReportPath = targetPath + "rptDosimetria.rdlc"; 
            ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);

            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(datasource);

            this.reportViewer1.RefreshReport();

        }

        private DataSet Cargar_PorCliente()
        {
            SqlCommand cmd = new SqlCommand();

            //  SqlCommand cmd = new SqlCommand();
            String intCliente;

            intCliente = txt_NCliente.Text;
            cmd.CommandText = "rtpClientePorPersonal '" + intCliente.ToString() + "'";
            //cmd.CommandText = "SELECT Id_Periodo,Anno, Mes,Id_TipoPeriodo FROM conf_periodo WHERE Id_TipoPeriodo=3";
            DataSet dt;
            dt = Conectar.Listar(Clases.clsBD.BD,cmd);

            return dt;

        }
        private void btn_ReporteNDosimetro_Click(object sender, EventArgs e)
        {
              DataSet dt;

              dt = Cargar_PorCliente();
              Llamado_reporte(dt, "rptPorClientePersonal.rdlc");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
