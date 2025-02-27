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
using classFuncionesBD;
using OpenXmlPowerTools;
using XRAY.Clases;

namespace ControlDosimetro
{
	public partial class frmCambioPersonalTLD : Form
	{

		#region "Definicion variable"
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();
		clsUtiles clsUtiles1 = new dllLibreriaMysql.clsUtiles();
		ClsFunciones clsFunc = new ClsFunciones();
		#endregion

		public frmCambioPersonalTLD()
		{
			InitializeComponent();
			AsignarEvento();
			Btn_filtro_Click(null, null);
		}

		#region "Llamada de carga"      

		private void Cargar_TLD(Int64 intNTLD)
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "pa_ListarDatosTLD_sel " + intNTLD.ToString();
			DataSet dt;

			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);
			if (dt.Tables[0].Rows.Count == 1)
			{
				lbl_NCliente.Text = dt.Tables[0].Rows[0]["Id_cliente"].ToString();
				lbl_NombreCliente.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
				lblRut.Text = dt.Tables[0].Rows[0]["run"].ToString();
				lblPersonalEliminar.Text=lblNombrePersonal.Text = dt.Tables[1].Rows[0]["NombreCompleto"].ToString();
				lblEstadoActual.Text = dt.Tables[1].Rows[0]["Estado"].ToString();
				lblPeriodoActual.Text = dt.Tables[1].Rows[0]["GlosaTrimestre"].ToString();

				Cargar_Personal(dt.Tables[0].Rows[0]["Id_cliente"].ToString(), lblRut.Text);
				Cargar_Seccion();
				Cargar_Direccion();
				Cargar_Estado();
				cbx_PersonalActual.SelectedValue = dt.Tables[1].Rows[0]["Id_Personal"];
				cbx_id_seccion.SelectedValue = dt.Tables[1].Rows[0]["Id_SeccionTLD"];
				cbxDireccionActual.SelectedValue = dt.Tables[1].Rows[0]["Id_sucursal"];
				cbxDireccionDctoActual.SelectedValue = dt.Tables[1].Rows[0]["Id_sucursal"];
				lblRecupMensajeTLD.Text = "El TLD no se ha ido eliminado.";
				btnRecuperarTLD.Enabled = dt.Tables[2].Rows.Count > 0;
				


				btn_Cargar.Enabled = false;
				txt_NDoc.Enabled = false;
				btn_Guardar.Enabled = true;
				btn_ModificarSeccion.Enabled = true;
				grpDatos.Enabled = true;
			}
			if (dt.Tables[0].Rows.Count > 1)
			{
				lbl_NCliente.Text = "";
				lbl_NombreCliente.Text = "";
				lblRut.Text = "";
				btn_Guardar.Enabled = false;
				grpDatos.Enabled = false;
			//	MessageBox.Show("No existe el número TLD");

			}
			else
			if (dt.Tables[0].Rows.Count == 0)
			{
				lbl_NCliente.Text = "";
				lbl_NombreCliente.Text = "";
				lblRut.Text = "";
				grpDatos.Enabled = false;
				btnCambioPeriodo.Enabled=btn_Guardar.Enabled = false;
				//MessageBox.Show("TLD no existe");

			}
			if (dt.Tables[2].Rows.Count > 0)
			{
				lblRecupMensajeTLD.Text = "";
				txtNTLDRecuperar.Text = dt.Tables[2].Rows[0]["n_dosimetro"].ToString();
				txtPersonal.Text = dt.Tables[2].Rows[0]["Personal"].ToString();
				txtCliente.Text = dt.Tables[2].Rows[0]["Cliente"].ToString();
				grpDatos.Enabled = true;
			}
			if (dt.Tables[3].Rows.Count > 0)
			{
				ddlPeriodoCambiarPeriodo.DataSource=dt.Tables[3];
			}
			
		}

		private void Cargar_Personal(string Id_Cliente, string rut)
		{
			SqlCommand cmd = new SqlCommand();

			cmd.CommandText = String.Format("select P.Nombres + ' ' + P.Paterno + ' ' + P.Maternos  as NombreCompleto,P.Id_Personal " +
									 " from tbl_personal P where id_cliente={0} and rut_cliente='{1}' order by P.Nombres + ' ' + P.Paterno + ' ' + P.Maternos", Id_Cliente, rut);
			DataSet dt;
			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);
			DataSet dtCopia;
			dtCopia = dt.Copy();
			cbx_PersonalActual.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
			cbx_PersonalActual.ValueMember = dt.Tables[0].Columns[1].Caption.ToString();
			cbx_PersonalActual.DataSource = dt.Tables[0];

			cbx_PersonalCambio.DisplayMember = dtCopia.Tables[0].Columns[0].Caption.ToString();
			cbx_PersonalCambio.ValueMember = dtCopia.Tables[0].Columns[1].Caption.ToString();
			cbx_PersonalCambio.DataSource = dtCopia.Tables[0];

		}
		private void Cargar_Seccion()
		{

			DataSet dt = clsFunc.Cargar_SeccionMasivoPorRun(Convert.ToInt16(lbl_NCliente.Text.ToString()), lblRut.Text);
			DataSet dtCopia = dt.Copy();

			cbx_id_seccion.DisplayMember = dt.Tables[1].Columns[0].Caption.ToString();
			cbx_id_seccion.ValueMember = dt.Tables[1].Columns[1].Caption.ToString();
			cbx_id_seccion.DataSource = dt.Tables[1];

			cbx_id_seccionMod.DisplayMember = dtCopia.Tables[0].Columns[0].Caption.ToString();
			cbx_id_seccionMod.ValueMember = dtCopia.Tables[0].Columns[1].Caption.ToString();
			cbx_id_seccionMod.DataSource = dtCopia.Tables[0];
		}
		private void Cargar_Estado()
		{

			DataSet dt = clsFunc.Cargar_EstadoTLD(1);
			DataSet dtCopia = dt.Copy();

			cbxEstado.DisplayMember = dt.Tables[0].Columns[1].Caption.ToString();
			cbxEstado.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
			cbxEstado.DataSource = dt.Tables[0];
		}
		private void Cargar_Direccion()
		{
			SqlCommand cmd = new SqlCommand();

			cmd.CommandText = String.Format("pa_CargarSucursalPorRun_Sel {0},'{1}'", lbl_NCliente.Text, lblRut.Text);
			DataSet dt;
			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);
			DataSet dtCopia = dt.Copy();

			cbxDireccionActual.DataSource = dt.Tables[0];
			cbxDireccionMod.DataSource = dtCopia.Tables[1];
			cbxDireccionDctoActual.DataSource = dt.Tables[0].Copy();
			cbxDireccionDctoCambiar.DataSource = dt.Tables[0].Copy();
		}
		private void AsignarEvento()
		{
			txt_NDoc.EventoAsignarNumero(9999999);
			txtNDocumento.EventoAsignarNumero(9999999);
			txtNDocumentoCambiarPeriodo.EventoAsignarNumero(9999999);
		}
		#endregion

		#region "button"
		private void btnAsociarTLDConElOriginal_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand();
			DataSet ds;
			string strParametro = String.Format("{0},{1}", txt_NDoc.Text, nudTLDEnviadoAlCliente.Value);
			cmd.CommandText = "pa_AsociarTLDEnviadoAlCliente_upd " + strParametro;
			cmd.CommandType = CommandType.Text;//pa_ModificarSeccionTLD_upd


			ds = Conectar.Listar(ClaseGeneral.Conexion, cmd);
			if (Convert.ToInt16(ds.Tables[0].Rows[0][0].ToString()) != 0)
			{
				MessageBox.Show("Error en actualizar la información");
			}

			else
				MessageBox.Show(ds.Tables[0].Rows[0][1].ToString());
		}
		private void btn_Cargar_Click(object sender, EventArgs e)
		{
			Cargar_TLD(Convert.ToInt64(txt_NDoc.Text));
		}

		private void Btn_Guardar_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand();
			DataSet ds;
			string strParametro = String.Format("{0},{1},{2}", txt_NDoc.Text, (cbx_PersonalActual.SelectedValue == null ? 0 : cbx_PersonalActual.SelectedValue), cbx_PersonalCambio.SelectedValue);
			cmd.CommandText = "pa_ModificarPersonalTLD_upd " + strParametro;
			cmd.CommandType = CommandType.Text;//pa_ModificarSeccionTLD_upd


			ds = Conectar.Listar(ClaseGeneral.Conexion, cmd);
			if (Convert.ToInt16(ds.Tables[0].Rows[0][0].ToString()) != 0)
			{
				MessageBox.Show("Error en actualizar la información");
			}

			else
				MessageBox.Show(ds.Tables[0].Rows[0][1].ToString());
		}
		private void btnCambioestado_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand();
			DataSet ds;
			string strParametro = String.Format("{0},{1}", txt_NDoc.Text, cbxEstado.SelectedValue);
			cmd.CommandText = "pa_ModificarEstadoTLD_upd " + strParametro;
			cmd.CommandType = CommandType.Text;//pa_ModificarSeccionTLD_upd


			ds = Conectar.Listar(ClaseGeneral.Conexion, cmd);
			if (Convert.ToInt16(ds.Tables[0].Rows[0][0].ToString()) != 0)
			{
				MessageBox.Show("Error en actualizar la información");
			}

			else
				MessageBox.Show(ds.Tables[0].Rows[0][1].ToString());
		}

		private void Btn_Cerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Btn_filtro_Click(object sender, EventArgs e)
		{
			txt_NDoc.Clear();
			lbl_NombreCliente.Text = "";
			lbl_NCliente.Text = "";
			lblRut.Text = "";
			btn_Cargar.Enabled = true;
			txt_NDoc.Enabled = true;
			lbl_NCliente.Text = "";
			lbl_NombreCliente.Text = "";
			txtNDocumento.Clear();
			grpDatos.Enabled = false;
			btn_Guardar.Enabled = false;
			btn_ModificarSeccion.Enabled = false;
		}
		private void btn_ModificarSeccion_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand();
			DataSet ds;
			string strParametro = String.Format("{0},{1}", txt_NDoc.Text, cbx_id_seccionMod.SelectedValue);
			cmd.CommandText = "pa_ModificarSeccionTLD_upd";
			cmd.Parameters.Add("@N_TLD", SqlDbType.Int);
			cmd.Parameters["@N_TLD"].Value = txt_NDoc.Text;
			cmd.Parameters.Add("@Id_SeccionCambio", SqlDbType.Int);
			cmd.Parameters["@Id_SeccionCambio"].Value = cbx_id_seccionMod.SelectedValue;
			cmd.CommandType = CommandType.StoredProcedure;//


			ds = Conectar.Listar(ClaseGeneral.Conexion, cmd);
			if (Convert.ToInt16(ds.Tables[0].Rows[0][0].ToString()) != 0)
			{
				MessageBox.Show("Error en actualizar la información");
			}

			else
				MessageBox.Show(ds.Tables[0].Rows[0][1].ToString());
		}
		private void btnDireccionMod_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand();
			DataSet ds;
			cmd.CommandText = "pa_ModificarDireccionTLD_upd";
			cmd.Parameters.Add("@N_TLD", SqlDbType.Int);
			cmd.Parameters["@N_TLD"].Value = txt_NDoc.Text;
			cmd.Parameters.Add("@IdDireccionActual", SqlDbType.Int);
			cmd.Parameters["@IdDireccionActual"].Value = string.IsNullOrWhiteSpace(cbxDireccionActual.Text) ? null : cbxDireccionActual.SelectedValue;
			cmd.Parameters.Add("@IdDireccionCambio", SqlDbType.Int);
			cmd.Parameters["@IdDireccionCambio"].Value = cbxDireccionMod.SelectedValue;
			cmd.CommandType = CommandType.StoredProcedure;


			ds = Conectar.Listar(ClaseGeneral.Conexion, cmd);
			if (Convert.ToInt16(ds.Tables[0].Rows[0][0].ToString()) != 0)
			{
				MessageBox.Show("Error en actualizar la información");
			}

			else
				MessageBox.Show(ds.Tables[0].Rows[0][1].ToString());
		}

		private void btnGuardarDireccionNDcto_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtNDocumento.Text))
			{
				classFuncionesGenerales.mensajes.MensajeError("Ingrese número de documento.");
				return;
			}
			if (string.IsNullOrWhiteSpace(cbxDireccionMod.Text))
			{
				classFuncionesGenerales.mensajes.MensajeError("Debe seleccionar la dirección a modificar.");
				return;
			}

			SqlCommand cmd = new SqlCommand();
			DataSet ds;
			cmd.CommandText = "pa_ModificarDireccionPorNumeroDctoTLD_upd";
			cmd.Parameters.Add("@N_Dcto", SqlDbType.Int);
			cmd.Parameters["@N_Dcto"].Value = txtNDocumento.Text;
			cmd.Parameters.Add("@IdDireccionActual", SqlDbType.Int);
			cmd.Parameters["@IdDireccionActual"].Value = string.IsNullOrWhiteSpace(cbxDireccionActual.Text) ? null : cbxDireccionActual.SelectedValue;
			cmd.Parameters.Add("@IdDireccionCambio", SqlDbType.Int);
			cmd.Parameters["@IdDireccionCambio"].Value = cbxDireccionMod.SelectedValue;
			cmd.Parameters.Add("@NTdl", SqlDbType.Int);
			cmd.Parameters["@NTdl"].Value = txt_NDoc.Text;
			
			cmd.CommandType = CommandType.StoredProcedure;


			ds = Conectar.Listar(ClaseGeneral.Conexion, cmd);
			if (Convert.ToInt16(ds.Tables[0].Rows[0][0].ToString()) != 0)
			{
				MessageBox.Show(ds.Tables[0].Rows[0][1].ToString());
			}

			else
				MessageBox.Show(ds.Tables[0].Rows[0][1].ToString());
		}
		private void btnRecuperarTLD_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand();
			DataSet ds;
			cmd.CommandText = "pa_AgregarEliminarTLD_upd";
			cmd.Parameters.Add("@N_TLD", SqlDbType.Int);
			cmd.Parameters["@N_TLD"].Value = txtNTLDRecuperar.Text;
			cmd.CommandType = CommandType.StoredProcedure;


			ds = Conectar.Listar(ClaseGeneral.Conexion, cmd);
			if (Convert.ToInt16(ds.Tables[0].Rows[0][0].ToString()) != 0)
			{
				MessageBox.Show("Error en actualizar la información");
			}

			else
				MessageBox.Show(ds.Tables[0].Rows[0][1].ToString());
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand();
			DataSet ds;
			cmd.CommandText = "pa_EliminarTLD_upd";
			cmd.Parameters.Add("@N_TLD", SqlDbType.Int);
			cmd.Parameters["@N_TLD"].Value = txt_NDoc.Text;
			cmd.CommandType = CommandType.StoredProcedure;


			ds = Conectar.Listar(ClaseGeneral.Conexion, cmd);
			if (Convert.ToInt16(ds.Tables[0].Rows[0][0].ToString()) != 0)
			{
				MessageBox.Show("Error en actualizar la información");
			}

			else
				MessageBox.Show(ds.Tables[0].Rows[0][1].ToString());
		}
		private void btnCambioPeriodo_Click(object sender, EventArgs e)
		{
			StringBuilder stbError= new StringBuilder();
			if (pnlCambiarPeriodo.XValidarPanel(ref stbError))
			{
				stbError.ToString().XMensajeError();
				return;
			}
			SqlCommand cmd = new SqlCommand();
			DataSet ds;
			cmd.CommandText = "pa_CambiarPeriodoTLD_upd";
			cmd.Parameters.Add("@N_Documento", SqlDbType.Int);
			cmd.Parameters["@N_Documento"].Value = txtNDocumentoCambiarPeriodo.Text;
			cmd.Parameters.Add("@TLD", SqlDbType.VarChar,300);
			cmd.Parameters["@TLD"].Value = txtListaTLD.Text;
			cmd.Parameters.Add("@IdPeriodoCambiar", SqlDbType.Int);
			cmd.Parameters["@IdPeriodoCambiar"].Value =ddlPeriodoCambiarPeriodo.SelectedValue;
			cmd.CommandType = CommandType.StoredProcedure;


			ds = Conectar.Listar(ClaseGeneral.Conexion, cmd);
			if (Convert.ToInt16(ds.Tables[0].Rows[0][0].ToString()) != 0)
			{
				MessageBox.Show("Error en actualizar la información");
			}

			else
				MessageBox.Show(ds.Tables[0].Rows[0][1].ToString());
		}

		#endregion

		#region "combobox"


		#endregion

		#region "grilla"

		#endregion


	}
}
