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
		Clases.ClassEvento classEvento = new Clases.ClassEvento();

		#endregion

		public frmRptcliente()
		{
			InitializeComponent();
	
			classEvento.AsignarRut(ref txt_RutCliente);
			classEvento.AsignarNumero(ref txtNCliente);
			//if (tabControl1.SelectedIndex == 0)
			//{
			//    label4.Visible = false;
			//    cbx_anno.Visible = false;
			//}           
		}

		private void frmRpDosimetria_Load(object sender, EventArgs e)
		{

			cbxComuna.DataSource = Cargar_Comuna().Tables[0];

		}
		public void Llamado_reporte(DataSet ds, String NombreReporte)
		{
			DataSet dtformato;
			SqlCommand cmdArchivo = new SqlCommand();
			cmdArchivo.CommandText = "" +
				"SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=7 order by orden ";
			cmdArchivo.CommandType = CommandType.Text;
			dtformato = Conectar.Listar(ClaseGeneral.Conexion, cmdArchivo);
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

			intCliente = txt_RutCliente.Text;
			cmd.CommandText = "rtpClientePorPersonal '" + intCliente.ToString() + "'";
			//cmd.CommandText = "SELECT Id_Periodo,Anno, Mes,Id_TipoPeriodo FROM conf_periodo WHERE Id_TipoPeriodo=3";
			DataSet dt;
			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

			return dt;

		}
		private DataSet Cargar_PorDireccion()
		{
			SqlCommand cmd = new SqlCommand();

			cmd.CommandText = "rtpCuadraturaDireccion";
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Clear();
			cmd.Parameters.Add("@Id_cliente", SqlDbType.Int);
			cmd.Parameters["@Id_cliente"].Value = string.IsNullOrWhiteSpace(txtNCliente.Text)?null: txtNCliente.Text;
			cmd.Parameters.Add("@Id_Comuna", SqlDbType.Int);
			cmd.Parameters["@Id_Comuna"].Value = string.IsNullOrWhiteSpace(cbxComuna.SelectedValue.ToString())?null: cbxComuna.SelectedValue;
			DataSet dt;
			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

			return dt;

		}

		private DataSet Cargar_Comuna()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "ddl_Comuna";
			DataSet dt;
			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

			return dt;

		}
		private void btn_ReporteNDosimetro_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			DataSet dt;

			dt = Cargar_PorCliente();
			Llamado_reporte(dt, "rptPorClientePersonal.rdlc");

			Cursor = Cursors.Default;
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnReporte_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			DataSet dt;

			dt = Cargar_PorDireccion();
			Llamado_reporte(dt, "rptPorClienteDireccion.rdlc");

			Cursor = Cursors.Default;
		}
	}
}
