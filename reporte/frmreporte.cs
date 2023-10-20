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
	public partial class frmreporte : Form
	{
		#region "Definicion variable"
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();

		#endregion

		public frmreporte(DataSet ds, DataSet ds2, int caseSwitch)
		{
			InitializeComponent();
			// dt = ClaseComun.RptDosimetria(Clases.clsBD.BD,Convert.ToInt64(txt_NumeroCliente.Text), 0, "0", intanno);
			Llamado_reporte2Dataset(ds, ds2, caseSwitch);

		}


		private void frmRpDosimetria_Load(object sender, EventArgs e)
		{
			// TODO: esta línea de código carga datos en la tabla 'dataSet1.rptOrdenTrabajo' Puede moverla o quitarla según sea necesario.
			//this.rptOrdenTrabajoTableAdapter.Fill(this.dataSet1.rptOrdenTrabajo);
			// TODO: esta línea de código carga datos en la tabla 'sistiamc_controlDataSet2.rtpDosimetria' Puede moverla o quitarla según sea necesario.
			//this.rtpDosimetriaTableAdapter.Fill(this.sistiamc_controlDataSet2.rtpDosimetria);

			//this.reportViewer1.RefreshReport();
		}


		public void Llamado_reporte2Dataset(DataSet ds, DataSet ds2, int caseSwitch)
		{
			ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);
			DataSet dtformato;
			SqlCommand cmdArchivo = new SqlCommand();
			cmdArchivo.CommandText = "" +
			  "SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=7 order by orden ";
			cmdArchivo.CommandType = CommandType.Text;
			dtformato = Conectar.Listar(Clases.clsBD.BD, cmdArchivo);
			// string targetPath = @ConfigurationManager.AppSettings["Archivo"] + "Cliente " + lbl_id_cliente.Text;
			string targetPath = @dtformato.Tables[0].Rows[0]["Glosa"].ToString();
			switch (caseSwitch)
			{
				case 1:
					//reportViewer1.LocalReport.ReportEmbeddedResource = "ControlDosimetro.reporte.rptDosimetriaEnc.rdlc"; 
					reportViewer1.LocalReport.ReportPath = targetPath + "rptDosimetriaEnc.rdlc";
					ReportDataSource datasource1 = new ReportDataSource("DataSet2", ds2.Tables[0]);

					this.reportViewer1.LocalReport.DataSources.Clear();

					this.reportViewer1.LocalReport.DataSources.Add(datasource);
					this.reportViewer1.LocalReport.DataSources.Add(datasource1);
					break;
				case 2:
					//reportViewer1.LocalReport.ReportEmbeddedResource = "ControlDosimetro.reporte.rptSobre.rdlc";
					reportViewer1.LocalReport.ReportPath = targetPath + "rptSobre.rdlc";
					this.reportViewer1.LocalReport.DataSources.Clear();

					this.reportViewer1.LocalReport.DataSources.Add(datasource);

					break;
				case 3:
					//reportViewer1.LocalReport.ReportPath = targetPath + "rptEstadoDosimetro.rdlc";
					reportViewer1.LocalReport.ReportEmbeddedResource = "ControlDosimetro.reporte.rptEstadoDosimetro.rdlc";
					this.reportViewer1.LocalReport.DataSources.Clear();

					this.reportViewer1.LocalReport.DataSources.Add(datasource);
					break;
				case 4:
					//reportViewer1.LocalReport.ReportPath = targetPath + "rptEstadoDosimetro.rdlc";
					reportViewer1.LocalReport.ReportEmbeddedResource = "ControlDosimetro.reporte.rptOrdenTrabajo.rdlc";
					this.reportViewer1.LocalReport.DataSources.Clear();

					this.reportViewer1.LocalReport.DataSources.Add(datasource);
					break;
				case 5:
					//reportViewer1.LocalReport.ReportPath = targetPath + "rptEstadoDosimetro.rdlc";
					reportViewer1.LocalReport.ReportEmbeddedResource = "ControlDosimetro.reporte.rptVerificacion.rdlc";
					this.reportViewer1.LocalReport.DataSources.Clear();

					this.reportViewer1.LocalReport.DataSources.Add(datasource);
					break;
				case 6:
					//reportViewer1.LocalReport.ReportPath = targetPath + "rptEstadoDosimetro.rdlc";
					reportViewer1.LocalReport.ReportEmbeddedResource = "ControlDosimetro.reporte.rptEntidades.rdlc";
					this.reportViewer1.LocalReport.DataSources.Clear();

					this.reportViewer1.LocalReport.DataSources.Add(datasource);
					break;
				case 7:
					datasource = new ReportDataSource("DataSet1", ds.Tables[1]);
					reportViewer1.LocalReport.ReportEmbeddedResource = "ControlDosimetro.reporte.rptToes.rdlc";
					this.reportViewer1.LocalReport.DataSources.Clear();

					this.reportViewer1.LocalReport.DataSources.Add(datasource);
					break;
				case 8:
					datasource = new ReportDataSource("DataSet1", ds.Tables[2]);
					reportViewer1.LocalReport.ReportEmbeddedResource = "ControlDosimetro.reporte.rptDosis.rdlc";
					this.reportViewer1.LocalReport.DataSources.Clear();

					this.reportViewer1.LocalReport.DataSources.Add(datasource);
					break;
				case 9:
					reportViewer1.LocalReport.ReportEmbeddedResource = "ControlDosimetro.reporte.rptListadoTLD.rdlc";
					this.reportViewer1.LocalReport.DataSources.Clear();

					this.reportViewer1.LocalReport.DataSources.Add(datasource);
					break;
				case 10:
					reportViewer1.LocalReport.ReportEmbeddedResource = "ControlDosimetro.reporte.rptPersonalActivo.rdlc";
					this.reportViewer1.LocalReport.DataSources.Clear();

					this.reportViewer1.LocalReport.DataSources.Add(datasource);
					break;
				case 11:
					reportViewer1.LocalReport.ReportEmbeddedResource = "ControlDosimetro.reporte.rptDctoFilmico.rdlc";
					ReportDataSource rdsDerDctoFilmico = new ReportDataSource("DataSet2", ds2.Tables[1]);
					ReportDataSource rdsDerDctoFilmicoRef = new ReportDataSource("DataSet3", ds2.Tables[2]);
					this.reportViewer1.LocalReport.DataSources.Clear();

					this.reportViewer1.LocalReport.DataSources.Add(datasource);
					this.reportViewer1.LocalReport.DataSources.Add(rdsDerDctoFilmico);
					this.reportViewer1.LocalReport.DataSources.Add(rdsDerDctoFilmicoRef);
					break;
				//rptDctoFilmico
				default:
					Console.WriteLine("Default case");
					break;
			}





			this.reportViewer1.RefreshReport();

		}


	}
}
