﻿using System;
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
	public partial class FrmRpDosimetriaTLD : Form
	{
		#region "Definicion variable"
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();
		classFuncionesBD.ClsFunciones ClaseFunciones = new classFuncionesBD.ClsFunciones();

		#endregion

		public FrmRpDosimetriaTLD()
		{
			InitializeComponent();
			cbx_Region.SelectedText = "1";
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
			ClaseFunciones.Cargar_Año(ref cbx_anno, 3);
		}

		private void FrmRpDosimetria_Load(object sender, EventArgs e)
		{
			// TODO: esta línea de código carga datos en la tabla 'sistiamc_controlDataSet2.rtpDosimetria' Puede moverla o quitarla según sea necesario.
			//this.rtpDosimetriaTableAdapter.Fill(this.sistiamc_controlDataSet2.rtpDosimetria);

			//this.reportViewer1.RefreshReport();
		}

		private void Btn_ReporteRut_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			DataSet dt;
			Int64 intanno;

			intanno = Convert.ToInt64(cbx_anno.Text);
			if (!String.IsNullOrWhiteSpace(txt_Rut.Text))
			{
				dt = ClaseComun.RptDosimetriaPa(ClaseGeneral.Conexion, 0, 0, txt_Rut.Text, intanno);
				Llamado_reporte(dt, "rptDosimetria.rdlc");
			}
			else
				MessageBox.Show("Debe Ingresar el Rut");

			Cursor = Cursors.Default;

		}

		private void Btn_reporteNCliente_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			DataSet dt;
			Int64 intanno;

			intanno = Convert.ToInt64(cbx_anno.Text);
			if (!String.IsNullOrWhiteSpace(txt_NumeroCliente.Text))
			{
				dt = ClaseComun.RptDosimetria(ClaseGeneral.Conexion, Convert.ToInt64(txt_NumeroCliente.Text), 0, "0", intanno);
				Llamado_reporte(dt, "rptDosimetria.rdlc");
			}
			else
				MessageBox.Show("Debe Ingresar el Número de cliente");

			Cursor = Cursors.Default;

		}
		public void Llamado_reporte(DataSet ds, String NombreReporte)
		{
			DataSet dtformato;
			SqlCommand cmdArchivo = new SqlCommand
			{
				CommandText = "" +
				"SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=7 order by orden ",
				CommandType = CommandType.Text
			};
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

		private void Btn_ReporteRegion_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			DataSet dt;
			Int64 intanno;


			intanno = Convert.ToInt64(cbx_anno.Text);
			if (!String.IsNullOrWhiteSpace(cbx_Region.Text))
			{
				dt = ClaseComun.RptDosimetria(ClaseGeneral.Conexion, 0, Convert.ToInt64(cbx_Region.Text), "0", intanno);
				Llamado_reporte(dt, "rptDosimetria.rdlc");
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
			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

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
			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

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
			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

			return dt;
		}

		private void btn_AnualCliente_Click(object sender, EventArgs e)
		{
			DataSet dt;

			dt = Cargar_DosimetrioAnual();
			Llamado_reporte(dt, "rptDosimetriaAnual.rdlc");
		}

		private void Btn_ReporteNDosimetro_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			if (!String.IsNullOrWhiteSpace(txt_NDosimetro.Text))
			{
				DataSet dt;

				dt = Cargar_PorDosimetro();
				Llamado_reporte(dt, "rptPorNumeroDosimetro.rdlc");
			}
			else
				MessageBox.Show("Debe ingresar un valor");

			Cursor = Cursors.Default;

		}

		private void BtnReporteAnualPorSucursal_Click(object sender, EventArgs e)
		{
			DataSet dt;

			dt = Cargar_DosimetrioAnualPorSucursal();
			Llamado_reporte(dt, "rptDosimetriaAnualPorSucursal.rdlc");
		}

		private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tabControl1.SelectedIndex == 0)
			{
				label4.Visible = false;
				cbx_anno.Visible = false;
			}
			else
			{
				label4.Visible = true;
				cbx_anno.Visible = true;
			}
		}
	}
}
