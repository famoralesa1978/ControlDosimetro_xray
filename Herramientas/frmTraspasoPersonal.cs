﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dllConectorMysql;
using dllLibreriaEvento;
using dllLibreriaMysql;

namespace ControlDosimetro
{
	public partial class frmTraspasoPersonal : Form
	{
		#region "Definicion variable"
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();
		string rut;
		//    Int64 intTempId_Estado;
		//   Int64 intTempId_Cliente;
		//   Int64 intTempPeriodo;
		//    int intContar = 0;
		#endregion

		private void frmTraspasoPersonal_Load(object sender, EventArgs e)
		{
			lbl_Id_cliente.Text = lbl_Id_clienteDestino.Text = "";
			lbl_RazonSocial.Text = lbl_RazonSocialDestino.Text = "";
			btn_Traspaso.Enabled = false;
			rut = "";
		}
		public frmTraspasoPersonal()
		{
			InitializeComponent();
			dtgDestino.AutoGenerateColumns = dtgOrigen.AutoGenerateColumns = false;
		}

		private void btn_Cargar_cliente_Click(object sender, EventArgs e)
		{
			if (((Button)sender).Name == btn_Cargar_cliente.Name)
				Cargar_Cliente(true);
			if (((Button)sender).Name == btn_Cargar_clienteDestino.Name)
				Cargar_Cliente(false);
		}

		private void Cargar_Cliente(Boolean bolOrigen)
		{
			string strRut = bolOrigen == true ? txt_Rut.Text : txt_RutDestino.Text;

			SqlCommand cmd = new SqlCommand
			{
				CommandText = "select id_cliente,run,Razon_Social,N_Cliente_Ref,region + ','+ comuna +','+Direccion as Direccion ,r.Id_Region,c.Id_Provincia,c.Id_Comuna,Telefono, Id_TipoFuente,Id_estado,Fechainicio " +
														"  FROM tbl_cliente c inner join [dbo].[glo_region] r on c.Id_Region=r.Id_Region inner join glo_comuna co on co.id_comuna=c.id_comuna" +
														" WHERE run= '" + strRut + "'" +
														" union " +
														"select id_cliente,run,Razon_Social,N_Cliente_Ref,region + ','+ comuna +','+Direccion as Direccion ,r.Id_Region,c.Id_Provincia,c.Id_Comuna,Telefono, Id_TipoFuente,Id_estado,Fechainicio " +
														"  FROM tbl_cliente_historial c inner join [dbo].[glo_region] r on c.Id_Region=r.Id_Region inner join glo_comuna co on co.id_comuna=c.id_comuna" +
														" WHERE run= '" + strRut + "'"
			};
			DataSet dt;

			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);
			if (dt.Tables[0].Rows.Count > 0)
			{
				if (bolOrigen == true)
				{
					txt_Rut.Text = strRut;
					lbl_RazonSocial.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
					lbl_Id_cliente.Text = dt.Tables[0].Rows[0]["id_cliente"].ToString();
				}
				else
				{
					txt_RutDestino.Text = strRut;
					lbl_RazonSocialDestino.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
					lbl_Id_clienteDestino.Text = dt.Tables[0].Rows[0]["id_cliente"].ToString();
				}
				String intIdCliente = bolOrigen == true ? lbl_Id_cliente.Text : lbl_Id_clienteDestino.Text;
				SqlCommand cmdPersonal = new SqlCommand
				{
					CommandText = String.Format("pa_ListarPersonal_sel {0},'{1}'",intIdCliente, strRut)
				};
				DataSet dtPersonal;

				dtPersonal = Conectar.Listar(ClaseGeneral.Conexion, cmdPersonal);
				if (bolOrigen == true)
					dtgOrigen.DataSource = dtPersonal.Tables[0];
				else
					dtgDestino.DataSource = dtPersonal.Tables[0];
			}
			else
			{
				if (bolOrigen == true)
				{
					btn_Cargar_cliente.Enabled = true;

					txt_Rut.Enabled = true;
					lbl_Id_cliente.Text = "";
					lbl_RazonSocial.Text = "";
				}
				else
				{
					btn_Cargar_clienteDestino.Enabled = true;

					txt_RutDestino.Enabled = true;
					lbl_Id_clienteDestino.Text = "";
					lbl_RazonSocialDestino.Text = "";
				}
			}

			btn_Traspaso.Enabled = lbl_Id_cliente.Text != "" && lbl_Id_clienteDestino.Text != "";
			if (bolOrigen == true)
			{
				if ((lbl_Id_cliente.Text == ""))
					MessageBox.Show("El cliente no existe");
			}
			else
			{
				if ((lbl_Id_clienteDestino.Text == ""))
					MessageBox.Show("El cliente no existe");
			}


		}

		private void btn_Traspaso_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			SqlCommand cmd = new SqlCommand();
			DataSet ds = null;
			string strRutPersonal = "";

			DataGridViewSelectedRowCollection Seleccionados = dtgOrigen.SelectedRows;

			foreach (DataGridViewRow item in Seleccionados)
			{
				cmd = new SqlCommand();
				strRutPersonal = item.Cells[0].Value.ToString();
				cmd = new SqlCommand();
				cmd.CommandText = "pa_Traspasopersonal_ins '" + txt_Rut.Text + "','" + txt_RutDestino.Text + "','" + strRutPersonal + "'," + lbl_Id_cliente.Text + "," + lbl_Id_clienteDestino.Text;
				ds = Conectar.Listar(ClaseGeneral.Conexion, cmd);
			}


			if (ds != null)
			{
				if (ds.Tables[0].Rows.Count > 0)
				{
					MessageBox.Show("El traspaso del personal fue exitoso");
					btn_Cargar_cliente_Click(null, null);
				}

			}

			Cursor = Cursors.Default;
		}
	}
}
