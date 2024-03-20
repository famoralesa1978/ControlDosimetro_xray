using System;
using System.Data;
using System.Windows.Forms;
using dllConectorMysql;
using dllLibreriaEvento;
using dllLibreriaMysql;
using System.Data.SqlClient;
using Clases;

namespace ControlDosimetro
{
	public partial class frmDireccionAct : Form
	{
		#region "Definicion variable"
		clsConectorSqlServerV2 Conectar = new clsConectorSqlServerV2();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();
		Clases.ClassEvento clsEvento = new Clases.ClassEvento();
		public int Id;
		public string RutEmpresa;
		public string IdCliente;
		int casa_matriz_ins;
		#endregion


		private void frmDireccionAct_Load(object sender, EventArgs e)
		{
			Cargar_Cliente(codcliente);
			if (intCodigo == 0)
			{
				btn_Grabar.Text = "Grabar";
				this.Text = "Agregar Sucursal";
				txtIdCliente.Enabled = false;
				chkEstado.Checked = true;
				btnCopiar.Visible = false;
				casa_matriz_ins = 0;
				//cargar_valor_maximo();
				//
			}
			else
			{
				btn_Grabar.Text = "Modificar";
				this.Text = "Modificar Sucursal";
				txtIdCliente.Text = codcliente.ToString();
				txtIdCliente.Enabled = false;
				// SqlCommand cmd = new SqlCommand();
				SqlCommand cmd = new SqlCommand();

				cmd.CommandText = "SELECT s.run,s.runsuc,s.razon_social,s.Direccion,s.Id_Region,s.Id_Provincia,s.Id_Comuna,s.Telefono,s.Id_estado,estado_casa_matriz,email " +
										" FROM tbl_sucursal s  WHERE Id_sucursal= " + intCodigo.ToString();
				DataSet dt;
				dt = Conectar.Listar(Clases.clsBD.BD, cmd);

				txtRun.Text = dt.Tables[0].Rows[0]["run"].ToString();
				//  txt_Razon_Social.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
				txtDireccion.Text = dt.Tables[0].Rows[0]["Direccion"].ToString();
				txtTelefono.Text = dt.Tables[0].Rows[0]["Telefono"].ToString();
				ddlIdRegion.SelectedValue = dt.Tables[0].Rows[0]["Id_Region"].ToString();
				// cbx_region.SelectedIndex = cbx_id_region.SelectedIndex;
				Cargar_Provincia();
				ddlIdProvincia.SelectedValue = dt.Tables[0].Rows[0]["Id_Provincia"].ToString();
				Cargar_Comuna();
				// cbx_provincia.SelectedIndex = cbx_id_provincia.SelectedIndex;
				ddlIdComuna.SelectedValue = dt.Tables[0].Rows[0]["Id_Comuna"].ToString();
				//   cbx_comuna.SelectedIndex = cbx_id_comuna.SelectedIndex;
				chkEstado.Checked = (bool)dt.Tables[0].Rows[0]["Estado"];
				casa_matriz_ins = Convert.ToInt16(dt.Tables[0].Rows[0]["estado_casa_matriz"].ToString());
				if (dt.Tables[0].Rows[0]["estado_casa_matriz"].ToString() == "1")
					chk_CasaMatriz.Checked = true;
				else
					chk_CasaMatriz.Checked = false;
				if (dt.Tables[0].Rows[0]["razon_social"].ToString().Trim() != "")
				{
					txtRazonSocial.Text = dt.Tables[0].Rows[0]["razon_social"].ToString();
				}

				if (dt.Tables[0].Rows[0]["runsuc"].ToString().Trim() != "")
				{
					txtRunSuc.Text = dt.Tables[0].Rows[0]["runsuc"].ToString();
				}
				else
					txtRunSuc.Text = txtRun.Text;

				//txt_runsuc.Enabled = false;
				txtEmail.Text = dt.Tables[0].Rows[0]["email"].ToString().Trim() != "" ? dt.Tables[0].Rows[0]["email"].ToString() : "";
				btnCopiar.Visible = true;
			}

		}
		public frmDireccionAct(Int64 intCodigo, Int64 codcliente)
		{
			InitializeComponent();
			AsignarEvento();
			Cargar_Region();
		}

		#region "Llamada de carga"  

		private void Cargar_Cliente(Int64 intCodCliente)
		{
			SqlCommand cmd = new SqlCommand();
			//	SqlCommand cmd = new SqlCommand();

			cmd.CommandText = "SELECT id_cliente,run,Razon_Social,N_Cliente_Ref,Direccion,Id_Region,Id_Provincia,Id_Comuna,Telefono, Id_TipoFuente,Id_estado,Fechainicio " +
											" FROM tbl_cliente WHERE Id_cliente= " + intCodCliente.ToString();
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			//lbl_id_cliente.Text = intCodCliente.ToString();
			txtRun.Text = dt.Tables[0].Rows[0]["run"].ToString();
			txtIdCliente.Text = dt.Tables[0].Rows[0]["id_cliente"].ToString();
			txtRazonSocial.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
		}
		private void Cargar_Region()
		{
			ClaseComun.Listar_Region(Clases.clsBD.BD, ref ddlIdRegion, ref ddlIdRegion);
		}

		private void Cargar_Provincia()
		{
			ClaseComun.Listar_Provincia(Clases.clsBD.BD, ref ddlIdProvincia, ref ddlIdProvincia, Convert.ToInt16(ddlIdRegion.SelectedValue));
		}

		private void Cargar_Comuna()
		{
			ClaseComun.Listar_Comuna(Clases.clsBD.BD, ref ddlIdComuna, ref ddlIdComuna, Convert.ToInt16(ddlIdRegion.SelectedValue), Convert.ToInt16(ddlIdProvincia.SelectedValue));
		}

		private void AsignarEvento()
		{
			txtIdCliente.EventoAsignarAvanzar();
			txtRun.EventoAsignarAvanzar();
			txtRunSuc.EventoAsignarRut();
			txtRazonSocial.EventoAsignarAvanzar();
			txtDireccion.EventoAsignarAvanzar();
			txtTelefono.EventoAsignarAvanzar();
			txtEmail.EventoAsignarAvanzar();
			txtDirector.EventoAsignarAvanzar();
			txtOpr.EventoAsignarAvanzar();
			txtOPRRUT.EventoAsignarRut();
			txtServicio.EventoAsignarAvanzar();
			chkEstado.EventoAsignarAvanzar();
			ddlIdRegion.EventoAsignarAvanzar();
			ddlIdProvincia.EventoAsignarAvanzar();
			ddlIdComuna.EventoAsignarAvanzar();
			txtEmail.EventoAsignarValidarEmail();
			txtDireccion.EventoAsignarDireccion();
		}

		private bool valida_cliente(int intCodigo)
		{
			//			  SqlCommand cmd = new SqlCommand();
			SqlCommand cmd = new SqlCommand();

			cmd.CommandText = "SELECT run,Razon_Social,N_Cliente_Ref,Direccion,Id_Region,Id_Provincia,Id_Comuna,Telefono, Id_TipoFuente,Id_estado,Fechainicio " +
							" FROM tbl_cliente WHERE Id_cliente= " + intCodigo.ToString();
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			if (dt.Tables[0].Rows.Count > 0)
				return true;
			else
				return false;

		}

		#endregion

		#region "button"

		private void btnCopiar_Click(object sender, EventArgs e)
		{
			btn_Grabar.Text = "Grabar";
			this.Text = "Agregar Sucursal";
			Id = 0;
			txtIdCliente.Enabled = false;
			chkEstado.Checked = true;
			btnCopiar.Visible = false;
			casa_matriz_ins = 0;
		}

		private void btn_cerrar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			this.Close();

			Cursor = Cursors.Default;
		}

		private void btn_Grabar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			Boolean bolResult;
			bolResult = false;
			if (MessageBox.Show("Desea grabar la información", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
			{
				if (btn_Grabar.Text == "Modificar")
				{

					ClaseComun.Modificar(Clases.clsBD.BD, tbl_sucursal, ref bolResult);
					if (bolResult == true)
					{
						cambia_direccion();
						MessageBox.Show("Dato modificado");

						this.Close();
					}

				}
				else
				{

					ClaseComun.Insertar(Clases.clsBD.BD, tbl_sucursal, ref bolResult);
					if (bolResult == true)
					{

						MessageBox.Show("Dato Guardado");

						this.Close();


					}

				}

			}

			Cursor = Cursors.Default;

		}

		#endregion

		#region "combobox"

		private void cbx_id_region_SelectedIndexChanged(object sender, EventArgs e)
		{
			Cargar_Provincia();

		}

		private void cbx_provincia_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cbx_id_provincia_SelectedIndexChanged(object sender, EventArgs e)
		{
			Cargar_Comuna();
		}
		#endregion

		private void label12_Click(object sender, EventArgs e)
		{

		}

		private void txt_direccion_Leave(object sender, EventArgs e)
		{
			txtDireccion.Text = txtDireccion.Text.ToString().Replace("/", "").ToString();
		}

		private void chk_CasaMatriz_CheckedChanged(object sender, EventArgs e)
		{
			casa_matriz_ins = 0;
			if (chk_CasaMatriz.Checked == true)
			{
				casa_matriz_ins = 1;
			}
		}

		private void cambia_direccion()
		{


			string dir = txtDireccion.ToString();
			long id_sucu = Convert.ToInt32(lbl_id_Sucursal.Text);
			SqlCommand cmd = new SqlCommand();

			cmd.CommandText = "pa_CambiaDireccionClientesuc_upd '" + txtRun.Text + "','" + txtDireccion.Text + "'," + txtIdCliente.Text + "," + id_sucu + "," + casa_matriz_ins;

			cmd.CommandType = CommandType.Text;
			DataSet ds;

			ds = Conectar.Listar(Clases.clsBD.BD, cmd);

		}

	}
}
