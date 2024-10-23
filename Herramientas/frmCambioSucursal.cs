using System;
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

namespace ControlDosimetro
{
    public partial class frmCambioSucursal : Form
    {

        #region "Definicion variable"
				clsConectorSqlServer Conectar = new clsConectorSqlServer();
				clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
            clsEventoControl ClaseEvento = new clsEventoControl();
        clsUtiles clsUtiles1 = new dllLibreriaMysql.clsUtiles();
        ClsFunciones clsFunc = new ClsFunciones();
        #endregion

		public frmCambioSucursal()
		{
			InitializeComponent();
			AsignarEvento();
			tabPrincipal.TabPages.RemoveAt(2);
			Btn_filtro_Click(null,null);
		}

		#region "Llamada de carga"      
		private void Cargar_Documento(Int64 intNDocumento)
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "select P.Id_cliente,run,Razon_Social,Id_sucursal " +
								 "  FROM ges_DosimetriaPersonal P inner join tbl_cliente C on P.Id_cliente=C.Id_cliente WHERE N_Documento= " + intNDocumento.ToString();
			DataSet dt;

			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);
			if (dt.Tables[0].Rows.Count == 1)
			{
				lbl_NCliente.Text = dt.Tables[0].Rows[0]["Id_cliente"].ToString();
				lbl_NombreCliente.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
				Cargar_Sucursal(dt.Tables[0].Rows[0]["run"].ToString(), lbl_NCliente.Text);
				cbx_SucActual.SelectedValue = dt.Tables[0].Rows[0]["Id_sucursal"];
				btn_Cargar.Enabled = false;
				txt_NDoc.Enabled = false;
				btn_Guardar.Enabled = true;
			}
			else
			if (dt.Tables[0].Rows.Count > 1)
			{
				lbl_NCliente.Text = "";
				lbl_NombreCliente.Text = "";
				btn_Guardar.Enabled = false;

				MessageBox.Show("Existe mas cliente con el mismo N° documento");

			}
			else
			if (dt.Tables[0].Rows.Count == 0)
			{
				lbl_NCliente.Text = "";
				lbl_NombreCliente.Text = "";
				btn_Guardar.Enabled = false;
				MessageBox.Show("Documento no existe");

			}

		}
		private void Cargar_DocumentoPorDosimetria(Int64 intNDocumento, Int64 intNDosimetro)
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "select P.Id_cliente,run,Razon_Social,Id_sucursal " +
								 "  FROM ges_DosimetriaPersonal P inner join tbl_cliente C on P.Id_cliente=C.Id_cliente " +
								 " Inner Join ges_dosimetro_estado on ges_dosimetro_estado.N_Documento=P.N_Documento " +
								 "WHERE N_Documento= " + intNDocumento.ToString() + " and ges_dosimetro_estado.n_dosimetro="+ intNDosimetro.ToString();
			DataSet dt;

			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);
			if (dt.Tables[0].Rows.Count == 1)
			{
				lbl_nombrePorDos.Text = dt.Tables[0].Rows[0]["Id_cliente"].ToString();
				lbl_nombrePorDos.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
				Cargar_SucursalPorDos(dt.Tables[0].Rows[0]["run"].ToString(), lbl_nombrePorDos.Text);
				ddlSucursalActualPorSuc.SelectedValue = dt.Tables[0].Rows[0]["Id_sucursal"];
				btn_Cargar.Enabled = false;
				txt_NDoc.Enabled = false;
				btn_Guardar.Enabled = true;
			}
			else
			if (dt.Tables[0].Rows.Count > 1)
			{
				lbl_NCliente.Text = "";
				lbl_NombreCliente.Text = "";
				btn_Guardar.Enabled = false;

				MessageBox.Show("Existe mas cliente con el mismo N° documento");

			}
			else
			if (dt.Tables[0].Rows.Count == 0)
			{
				lbl_NCliente.Text = "";
				lbl_NombreCliente.Text = "";
				btn_Guardar.Enabled = false;
				MessageBox.Show("Documento no existe");

			}

		}
		private void Cargar_SucursalPorDos(string rut, string id_Cliente)
		{
			SqlCommand cmd = new SqlCommand();

			cmd.CommandText = "select id_sucursal, direccion + ','+co.comuna as Dato " +
				 "from [dbo].[tbl_sucursal] s " +
				 "inner join glo_region r on r.Id_region=s.Id_Region " +
				 "inner join glo_comuna co on co.id_comuna=s.Id_Comuna " +
				 "where run='" + rut + "' and Id_cliente=" + id_Cliente;
			DataSet dt;
			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);
			DataSet dtCopia;
			dtCopia = dt.Copy();
			ddlSucursalActualPorSuc.DisplayMember = dt.Tables[0].Columns[1].Caption.ToString();
			ddlSucursalActualPorSuc.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
			ddlSucursalActualPorSuc.DataSource = dt.Tables[0];

			ddlSucursalModPorSuc.DisplayMember = dtCopia.Tables[0].Columns[1].Caption.ToString();
			ddlSucursalModPorSuc.ValueMember = dtCopia.Tables[0].Columns[0].Caption.ToString();
			ddlSucursalModPorSuc.DataSource = dtCopia.Tables[0];
		}
		private void Cargar_Sucursal(string rut,string id_Cliente)
		{
			SqlCommand cmd = new SqlCommand();

			cmd.CommandText = "select id_sucursal, direccion + ','+co.comuna as Dato " +
				 "from [dbo].[tbl_sucursal] s " +
				 "inner join glo_region r on r.Id_region=s.Id_Region " +
				 "inner join glo_comuna co on co.id_comuna=s.Id_Comuna " +
				 "where run='" + rut + "' and Id_cliente="+ id_Cliente;
			DataSet dt;
			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);
			DataSet dtCopia;
			dtCopia = dt.Copy();
			cbx_SucActual.DisplayMember = dt.Tables[0].Columns[1].Caption.ToString();
			cbx_SucActual.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
			cbx_SucActual.DataSource = dt.Tables[0];

			cbx_SucCambio.DisplayMember = dtCopia.Tables[0].Columns[1].Caption.ToString();
			cbx_SucCambio.ValueMember = dtCopia.Tables[0].Columns[0].Caption.ToString();
			cbx_SucCambio.DataSource = dtCopia.Tables[0];
		}

		private void AsignarEvento()
		{
			txt_NDoc.EventoAsignarNumero(9);
			lbl_id_cliente.EventoAsignarNumero(9);
			txtNDocPorSuc.EventoAsignarNumero(9);
			txtNDosPorSuc.EventoAsignarNumero(9);
		}
		private void Cargar_Cliente(Int64 intCodCliente)
		{
			Cursor = Cursors.WaitCursor;

			frmAyudaCliente frm = new frmAyudaCliente(Convert.ToInt64(lbl_id_cliente.Text));

			if (frm.ShowDialog() == DialogResult.OK)
			{
				lblRazonSocialTLD.Text = (Convert.ToInt64(lbl_id_cliente.Text) > 1) ? Clases.ClsCliente.Nombres : "";
				lbl_rut_cliente.Text = (Convert.ToInt64(lbl_id_cliente.Text) > 1) ? Clases.ClsCliente.Rut : "";

				SqlCommand cmd = new SqlCommand
				{
					CommandText = String.Format("CargarClientePorRun '{0}',{1}", lbl_rut_cliente.Text, lbl_id_cliente.Text)
				};
				DataSet dt;
				dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

				if (dt != null)
				{
					cbx_Sucursal.DataSource = dt.Tables[2];
					cbx_SucursalCambiar.DataSource = dt.Tables[2];

					btn_CargarCli.Enabled = false;
				}

			}
			Cursor = Cursors.Default;
		}

		#endregion

		#region "button"

		private void btn_Cargar_Click(object sender, EventArgs e)
		{
			Cargar_Documento(Convert.ToInt64(txt_NDoc.Text));
		}
		private void btn_CargarPorSuc_Click(object sender, EventArgs e)
		{
			Cargar_DocumentoPorDosimetria(Convert.ToInt64(txtNDocPorSuc.Text), Convert.ToInt64(txtNDosPorSuc.Text));
		}
		private void btnModificarTLD_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand();
			DataSet ds;
			string strParametro = String.Format("{0},'{1}',{2},{3}", lbl_id_cliente.Text, lbl_rut_cliente.Text,cbx_SucActual.SelectedValue, cbx_SucCambio.SelectedValue);
			cmd.CommandText = "pa_ModificarSucursalTLD_upd " + strParametro;
			cmd.CommandType = CommandType.Text;


			ds = Conectar.Listar(ClaseGeneral.Conexion, cmd);
			if (Convert.ToInt16(ds.Tables[0].Rows[0][0].ToString()) != 0)
			{
				MessageBox.Show("Error en actualizar la información");
			}

			else
				MessageBox.Show(ds.Tables[0].Rows[0][1].ToString());
		}
		private void Btn_Guardar_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand();
			DataSet ds;
			string strParametro = String.Format("{0},{1}", txt_NDoc.Text,  cbx_SucCambio.SelectedValue);
			cmd.CommandText = "pa_ModificarSucursal_upd " + strParametro;
			cmd.CommandType = CommandType.Text;


			ds = Conectar.Listar(ClaseGeneral.Conexion, cmd);
			if (Convert.ToInt16(ds.Tables[0].Rows[0][0].ToString()) != 0)
			{
				MessageBox.Show("Error en actualizar la información");
			}

			else
				MessageBox.Show(ds.Tables[0].Rows[0][1].ToString());
		}
		private void btnModificarSucDos_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand();
			DataSet ds;
			string strParametro = String.Format("{0},{1}", txt_NDoc.Text, cbx_SucCambio.SelectedValue);
			cmd.CommandText = "pa_ModificarSucursalPorDosimetro_upd " + strParametro;
			cmd.CommandType = CommandType.Text;


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
			btn_Cargar.Enabled = true;
			txt_NDoc.Enabled = true;
			lbl_NCliente.Text = "";
			lbl_NombreCliente.Text = "";
			btn_Guardar.Enabled = false;
		}
		private void btn_CargarCli_Click(object sender, EventArgs e)
		{
			if (!String.IsNullOrWhiteSpace(lbl_id_cliente.Text))
				Cargar_Cliente(Convert.ToInt64(lbl_id_cliente.Text));
		}




		#endregion

		#region "combobox"


		#endregion

		#region "grilla"

		#endregion


	}
}
