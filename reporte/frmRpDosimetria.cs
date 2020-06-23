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
using System.IO;
using SpreadsheetLight;

namespace ControlDosimetro
{
    public partial class frmRpDosimetria : Form
    {
        #region "Definicion variable"
        clsConectorSqlServer Conectar = new clsConectorSqlServer();
        clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
        clsEventoControl ClaseEvento = new clsEventoControl();

        #endregion

        public frmRpDosimetria()
        {
            InitializeComponent();
            cbx_Region.SelectedText = "1";
            txt_Rut.KeyPress += new KeyPressEventHandler(ClaseEvento.Rut_KeyPress);
            txt_Rut.KeyDown += new KeyEventHandler(ClaseEvento.Rut_KeyDown);
            txt_Rut.Validated += new EventHandler(ClaseEvento.validarut_Validated);
            txt_NumeroCliente.KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
            txt_NumeroCliente.KeyDown += new KeyEventHandler(ClaseEvento.Numero_KeyDown);
            txt_NDosimetro.KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
            txt_NDosimetro.KeyDown += new KeyEventHandler(ClaseEvento.Numero_KeyDown);
            if (tabControl1.SelectedIndex == 0)
            {
                label4.Visible = false;
                cbx_anno.Visible = false;
            }
            Cargar_Anno();
        }

        private void Cargar_Anno()
        {
            SqlCommand cmd = new SqlCommand();

            //  SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT distinct Anno FROM conf_periodo WHERE Id_TipoPeriodo=3";
            //cmd.CommandText = "SELECT Id_Periodo,Anno, Mes,Id_TipoPeriodo FROM conf_periodo WHERE Id_TipoPeriodo=3";
            DataSet dt;
            dt = Conectar.Listar(Clases.clsBD.BD,cmd);

            cbx_anno.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
            cbx_anno.DataSource = dt.Tables[0];

        }

        private void frmRpDosimetria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistiamc_controlDataSet2.rtpDosimetria' Puede moverla o quitarla según sea necesario.
            //this.rtpDosimetriaTableAdapter.Fill(this.sistiamc_controlDataSet2.rtpDosimetria);

            //this.reportViewer1.RefreshReport();
        }

        private void btn_ReporteRut_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            DataSet dt;
            Int64 intanno;

            

            intanno = Convert.ToInt64(cbx_anno.Text);
            if (txt_Rut.Text.Trim() != "")
            {
                dt = ClaseComun.RptDosimetriaPa(Clases.clsBD.BD, 0, 0, txt_Rut.Text, intanno);
                Llamado_reporte(dt, "rptDosimetria.rdlc");
            }
            else
                MessageBox.Show("Debe Ingresar el Rut");

            Cursor = Cursors.Default;
            
        }

         private void btn_reporteNCliente_Click(object sender, EventArgs e)
        {
             Cursor = Cursors.WaitCursor;

              DataSet dt;
              Int64 intanno;

            

            intanno = Convert.ToInt64(cbx_anno.Text);
            if (txt_NumeroCliente.Text.Trim() != "")
            {
                dt = ClaseComun.RptDosimetria(Clases.clsBD.BD,Convert.ToInt64(txt_NumeroCliente.Text) ,0, "0", intanno);
                Llamado_reporte(dt, "rptDosimetria.rdlc");
            }
            else
                MessageBox.Show("Debe Ingresar el Número de cliente");

            Cursor = Cursors.Default;
            
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

        private void btn_ReporteRegion_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            DataSet dt;
            Int64 intanno;
               
            
            intanno = Convert.ToInt64(cbx_anno.Text);
            if (cbx_Region.Text.Trim() != "")
            {
                dt = ClaseComun.RptDosimetria(Clases.clsBD.BD,0, Convert.ToInt64(cbx_Region.Text), "0", intanno);
                Llamado_reporte(dt,"rptDosimetria.rdlc");
            }
            else
                MessageBox.Show("Debe ingresar una región");

            Cursor = Cursors.Default;
        }

        private DataSet Cargar_DosimetrioAnual()
        {
            Cursor = Cursors.WaitCursor;

            SqlCommand cmd = new SqlCommand();

            //  SqlCommand cmd = new SqlCommand();
            Int64 intanno;

            intanno = Convert.ToInt64(cbx_anno.Text);
            cmd.CommandText = "rtpDosimetriaAnual " + intanno.ToString();
            //cmd.CommandText = "SELECT Id_Periodo,Anno, Mes,Id_TipoPeriodo FROM conf_periodo WHERE Id_TipoPeriodo=3";
            DataSet dt;
            dt = Conectar.Listar(Clases.clsBD.BD, cmd);

            Cursor = Cursors.Default;

            return dt;
            
        }

        private DataSet Cargar_DosimetrioAnualPorSucursal()
        {
            Cursor = Cursors.WaitCursor;

            SqlCommand cmd = new SqlCommand();

            //  SqlCommand cmd = new SqlCommand();
            Int64 intanno;

            intanno = Convert.ToInt64(cbx_anno.Text);
            cmd.CommandText = "rtpDosimetriaAnualPorSucursal " + intanno.ToString();
            //cmd.CommandText = "SELECT Id_Periodo,Anno, Mes,Id_TipoPeriodo FROM conf_periodo WHERE Id_TipoPeriodo=3";
            DataSet dt;
            dt = Conectar.Listar(Clases.clsBD.BD,cmd);

            Cursor = Cursors.Default;

            return dt;

        }

        private DataSet Cargar_PorDosimetro()
        {
            SqlCommand cmd = new SqlCommand();

            //  SqlCommand cmd = new SqlCommand();
            Int64 intDosimetro;

            intDosimetro = Convert.ToInt64(txt_NDosimetro.Text);
            cmd.CommandText = "rtpListadoPorDosimetro " + intDosimetro.ToString();
            //cmd.CommandText = "SELECT Id_Periodo,Anno, Mes,Id_TipoPeriodo FROM conf_periodo WHERE Id_TipoPeriodo=3";
            DataSet dt;
            dt = Conectar.Listar(Clases.clsBD.BD,cmd);

            return dt;

        }

        private void btn_AnualCliente_Click(object sender, EventArgs e)
        {
            DataSet dt;
           
            dt = Cargar_DosimetrioAnual();
            Llamado_reporte(dt, "rptDosimetriaAnual.rdlc");
        }

        private void btn_ReporteNDosimetro_Click(object sender, EventArgs e)
        {
              DataSet dt;

              dt = Cargar_PorDosimetro();
              Llamado_reporte(dt, "rptPorNumeroDosimetro.rdlc");
        }

        private void btnReporteAnualPorSucursal_Click(object sender, EventArgs e)
        {
            DataSet dt;

            dt =   Cargar_DosimetrioAnualPorSucursal();
            Llamado_reporte(dt, "rptDosimetriaAnualPorSucursal.rdlc");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                label4.Visible = false;
                cbx_anno.Visible = false;
            }
            else {
                label4.Visible = true;
                cbx_anno.Visible = true;
            }
        }
    }
}
