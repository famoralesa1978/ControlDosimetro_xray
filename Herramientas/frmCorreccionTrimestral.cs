﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dllConectorMysql;
using dllLibreriaEvento;
using dllLibreriaMysql;
using System.Data.SqlClient;
using System.Data.Sql;
using Microsoft.Reporting.WinForms;
using System.Net.Mime;
using System.Net;
using System.Net.Mail;

namespace ControlDosimetro
{
	public partial class frmCorreccionTrimestral : Form
	{

		#region "Definicion variable"
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();
		clsUtiles clsUtiles1 = new dllLibreriaMysql.clsUtiles();
		#endregion

		public frmCorreccionTrimestral(int intId_Cliente)
		{
			InitializeComponent();
			Cargar_Anno(ref cbx_anno);
			Cargar_Anno(ref cbx_annoCambio);
			Cargar_Anno(ref cbx_annoCambioTLD);
			Cargar_Periodo();

		}

		#region "Llamada de carga"      

		private void Cargar_Anno(ref ComboBox cbxAnno)
		{
			SqlCommand cmd = new SqlCommand
			{
				CommandText = "SELECT distinct Anno FROM conf_periodo WHERE Id_TipoPeriodo=3"
			};
			//cmd.CommandText = "SELECT Id_Periodo,Anno, Mes,Id_TipoPeriodo FROM conf_periodo WHERE Id_TipoPeriodo=3";
			DataSet dt;
			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

			cbxAnno.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
			cbxAnno.DataSource = dt.Tables[0];

		}

		private void Cargar_Periodo()
		{
			SqlCommand cmd = new SqlCommand
			{
				CommandText = "SELECT Id_Periodo,Mes, cast((mes/3) as varchar(10))+ '°T' FROM conf_periodo WHERE Id_TipoPeriodo=3 and Anno=" + cbx_annoCambio.Text
			};
			DataSet dt;
			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

			cbx_id_periodoCambio.DisplayMember = dt.Tables[0].Columns[2].Caption.ToString();
			cbx_id_periodoCambio.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
			cbx_id_periodoCambio.DataSource = dt.Tables[0];

			cbx_id_periodoCambioTLD.DisplayMember = dt.Tables[0].Columns[2].Caption.ToString();
			cbx_id_periodoCambioTLD.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
			cbx_id_periodoCambioTLD.DataSource = dt.Tables[0];
		}

		private void Cargar_PeriodoExistente()
		{
			SqlCommand cmd = new SqlCommand
			{
				CommandText = String.Format("pa_ConsultaCorregirTrimestreo_sel {0},{1}", lbl_id_cliente.Text, cbx_anno.Text)
			};
			DataSet dt;
			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

			if (dt.Tables[0].Rows.Count > 0)
			{
				grpPrincipal.Enabled = true;
				cbx_anno.Enabled = false;
				lbl_id_cliente.Enabled = false;
				btn_cargar.Enabled = false;
				cbx_id_periodo.DisplayMember = dt.Tables[0].Columns[2].Caption.ToString();
				cbx_id_periodo.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
				cbx_id_periodo.DataSource = dt.Tables[0];
			}
			else
			{
				cbx_anno.Enabled = true;
				lbl_id_cliente.Enabled = true;
				btn_cargar.Enabled = true;
				grpPrincipal.Enabled = false;
				cbx_id_periodo.DisplayMember = dt.Tables[0].Columns[2].Caption.ToString();
				cbx_id_periodo.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
				cbx_id_periodo.DataSource = dt.Tables[0];
			}
			if (dt.Tables[1].Rows.Count > 0)
			{
				grpPrincipal.Enabled = true;
				cbx_anno.Enabled = false;
				lbl_id_cliente.Enabled = false;
				btn_cargar.Enabled = false;
				cbx_id_periodoTLD.DisplayMember = dt.Tables[1].Columns[2].Caption.ToString();
				cbx_id_periodoTLD.ValueMember = dt.Tables[1].Columns[0].Caption.ToString();
				cbx_id_periodoTLD.DataSource = dt.Tables[1];
			}
			else
			{
				cbx_anno.Enabled = true;
				lbl_id_cliente.Enabled = true;
				btn_cargar.Enabled = true;
				grpPrincipal.Enabled = false;
				cbx_id_periodoTLD.DisplayMember = dt.Tables[1].Columns[2].Caption.ToString();
				cbx_id_periodoTLD.ValueMember = dt.Tables[1].Columns[0].Caption.ToString();
				cbx_id_periodoTLD.DataSource = dt.Tables[1];
			}
		}

		private void AsignarEvento()
		{
			lbl_id_cliente.KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
			lbl_id_cliente.KeyDown += new KeyEventHandler(ClaseEvento.Numero_KeyDown);
			cbx_anno.KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);
			cbx_id_periodo.KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);
			cbx_id_periodoCambio.KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);
			cbx_annoCambio.KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);
		}

		#endregion

		#region "button"

		private void Btn_cargar_Click(object sender, EventArgs e)
		{
			if (lbl_id_cliente.Text.ToString().Trim() != "")
			{
				//Listar_Grilla();

				Cargar_PeriodoExistente();
			}


		}

		private void Btn_Cerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		#endregion

		#region "combobox"


		#endregion

		#region "grilla"

		#endregion

		private void FrmIngresoPelicula_Load(object sender, EventArgs e)
		{

		}

		private void Btn_Cargar_cliente_Click(object sender, EventArgs e)
		{
			//   Cargar_Cliente(Convert.ToInt64(lbl_id_cliente.Text));
		}

		private void Cbx_annoCambio_SelectedIndexChanged(object sender, EventArgs e)
		{
			Cargar_Periodo();
		}

		private void Btn_Guardar_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Esta seguro de cambiar de trimestre?", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
			{
				SqlCommand cmd = new SqlCommand();
				DataSet ds;

				cmd.CommandText = "pa_CambiarNDocumentoTrimestre_upd " + lbl_id_cliente.Text + "," + cbx_id_periodo.SelectedValue + "," + cbx_id_periodoCambio.SelectedValue;
				cmd.CommandType = CommandType.Text;
				ds = Conectar.Listar(ClaseGeneral.Conexion, cmd);


				MessageBox.Show(ds.Tables[0].Rows[0][1].ToString());

				Btn_filtro_Click(null, null);

			}
		}

		private void Btn_filtro_Click(object sender, EventArgs e)
		{
			lbl_id_cliente.Text = "0";
			Btn_cargar_Click(sender, e);
			lbl_id_cliente.Text = "";
		}

		private void btn_GuardarTLD_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Esta seguro de cambiar de trimestre?", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
			{
				SqlCommand cmd = new SqlCommand();
				DataSet ds;

				cmd.CommandText = "pa_CambiarNDocumentoTrimestreTLD_upd " + lbl_id_cliente.Text + "," + cbx_id_periodoTLD.SelectedValue + "," + cbx_id_periodoCambioTLD.SelectedValue;
				cmd.CommandType = CommandType.Text;
				ds = Conectar.Listar(ClaseGeneral.Conexion, cmd);


				MessageBox.Show(ds.Tables[0].Rows[0][1].ToString());

				Btn_filtro_Click(null, null);

			}
		}
	}
}
