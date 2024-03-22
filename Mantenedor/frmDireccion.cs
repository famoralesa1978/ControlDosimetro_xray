using Clases;
using NPOI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlDosimetro
{
	public partial class frmDireccion : Form
	{
		#region "Definicion variable"

		TextBox txtBox = new TextBox();
		DataTable dtMenu = null;
		clsConectorSqlServerV2 Conectar = new clsConectorSqlServerV2();
		public int intMenu;

		private bool Lectura, Agregar, Modificar, Eliminar;

		private bool bolInicializar = true;

		#endregion

		#region "Inicio"
		public frmDireccion()
		{
			InitializeComponent();
			dtgPrincipal.AutoGenerateColumns = false;

		}
		private void frmDireccion_Load(object sender, EventArgs e)
		{
			AsignarPermiso();
			AsignarEvento();
			Iniciarparametro();
			bolInicializar = false;
		}
		private void CargarDatosInicial()
		{
			CargarGrilla();
		}

		#endregion

		#region Barra
		private void tsbAgregar_Click(object sender, EventArgs e)
		{
			frmDireccionAct frm = new frmDireccionAct();
			frm.Id = 0;
			frm.RutEmpresa = txtRut.Text;
			frm.RazonSocial = txtRazonSocial.Text;
			frm.IdCliente = txtNCliente.DevuelveEntero();
			frm.intMenu = intMenu;
			frm.ShowDialog(this);
		}
		private void tsbModificar_Click(object sender, EventArgs e)
		{
			frmDireccionAct frm = new frmDireccionAct();
			frm.Id = (int)dtgPrincipal.ObtenerID();
			frm.RutEmpresa = txtRut.Text;
			frm.IdCliente = txtNCliente.DevuelveEntero();
			frm.intMenu = intMenu;
			frm.ShowDialog(this);
		}
		private void tsbRefrescar_Click(object sender, EventArgs e)
		{
			if (txtNCliente.DevuelveCadenaNulo() == null) return;
			CargarDatosInicial();
		}
		private void tsbGuardar_Click(object sender, EventArgs e)
		{
			string strMensajeError = "";
			bool bolError = false;
			Cursor = Cursors.WaitCursor;
			//if (((DataTable)dtgPrincipal.DataSource).GetChanges(DataRowState.Modified) != null || ((DataTable)dtgPrincipal.DataSource).GetChanges(DataRowState.Added) != null)
			//{


			foreach (DataRow row in ((DataTable)dtgPrincipal.DataSource).Rows)
			{

				if (row.RowState == DataRowState.Added)
				{
					SqlCommand cmd = new SqlCommand();
					cmd.CommandText = "DireccionIns";
					cmd.Parameters.Add("@Id_Usuario", SqlDbType.Int);
					cmd.Parameters["@Id_Usuario"].Value = row["Id_Usuario"]; //ParameterDirection.Output;
					cmd.Parameters.Add("@Rut", SqlDbType.VarChar, 10);
					cmd.Parameters["@Rut"].Value = row["Rut"];
					cmd.Parameters.Add("@Nombres", SqlDbType.VarChar, 100);
					cmd.Parameters["@Nombres"].Value = row["Nombres"];
					cmd.Parameters.Add("@Paterno", SqlDbType.VarChar, 100);
					cmd.Parameters["@Paterno"].Value = row["Paterno"];
					cmd.Parameters.Add("@Maternos", SqlDbType.VarChar, 100);
					cmd.Parameters["@Maternos"].Value = row["Maternos"];
					cmd.Parameters.Add("@Id_perfil", SqlDbType.Int);
					cmd.Parameters["@Id_perfil"].Value = row["Id_perfil"];
					cmd.Parameters.Add("@Estado", SqlDbType.Bit);
					cmd.Parameters["@Estado"].Value = (bool)row["Estado"];
					cmd.Parameters.Add("@Email", SqlDbType.VarChar, 200);
					cmd.Parameters["@Email"].Value = row["Email"];
					cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 30);
					cmd.Parameters["@Usuario"].Value = row["Usuario"];
					cmd.Parameters.Add("@Contraseña", SqlDbType.VarChar, 100);
					cmd.Parameters["@Contraseña"].Value = row["Contraseña"].ToString();
					cmd.Parameters.Add("@IdUsuarioMod", SqlDbType.Int);
					cmd.Parameters["@IdUsuarioMod"].Value = Clases.clsUsuario.Id_Usuario;
					cmd.CommandType = CommandType.StoredProcedure;
					Conectar.Agregar(ClaseGeneral.Conexion, cmd, "Id_Usuario", ref strMensajeError);

					row.RowError = strMensajeError;
					if (!string.IsNullOrWhiteSpace(strMensajeError))
					{
						bolError = true;
						Cursor = Cursors.Default;
						ClaseGeneral.GuardarLOG(this.Name, "DireccionIns", "Grabar");
						return;
					}
				}
				else
				if (row.RowState == DataRowState.Modified)
				{
					SqlCommand cmd = new SqlCommand();
					cmd.CommandText = "DireccionUpd";
					cmd.Parameters.Add("@Id_Usuario", SqlDbType.Int);
					cmd.Parameters["@Id_Usuario"].Value = row["Id_Usuario"];
					cmd.Parameters.Add("@Rut", SqlDbType.VarChar, 10);
					cmd.Parameters["@Rut"].Value = row["Rut"];
					cmd.Parameters.Add("@Nombres", SqlDbType.VarChar, 100);
					cmd.Parameters["@Nombres"].Value = row["Nombres"];
					cmd.Parameters.Add("@Paterno", SqlDbType.VarChar, 100);
					cmd.Parameters["@Paterno"].Value = row["Paterno"];
					cmd.Parameters.Add("@Maternos", SqlDbType.VarChar, 100);
					cmd.Parameters["@Maternos"].Value = row["Maternos"];
					cmd.Parameters.Add("@Id_perfil", SqlDbType.Int);
					cmd.Parameters["@Id_perfil"].Value = row["Id_perfil"];
					cmd.Parameters.Add("@Estado", SqlDbType.Bit);
					cmd.Parameters["@Estado"].Value = (bool)row["Estado"];
					cmd.Parameters.Add("@Email", SqlDbType.VarChar, 200);
					cmd.Parameters["@Email"].Value = row["Email"];
					cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 30);
					cmd.Parameters["@Usuario"].Value = row["Usuario"];
					cmd.Parameters.Add("@Contraseña", SqlDbType.VarChar, 100);
					cmd.Parameters["@Contraseña"].Value = row["Contraseña"].ToString();
					cmd.Parameters.Add("@IdUsuarioMod", SqlDbType.Int);
					cmd.Parameters["@IdUsuarioMod"].Value = Clases.clsUsuario.Id_Usuario;

					cmd.CommandType = CommandType.StoredProcedure;
					Conectar.Modificar(ClaseGeneral.Conexion, cmd, ref strMensajeError);
					row.RowError = strMensajeError;
					if (!string.IsNullOrWhiteSpace(strMensajeError))
					{
						bolError = true;
						Cursor = Cursors.Default;
						ClaseGeneral.GuardarLOG(this.Name, "DireccionUpd", "Grabar");
						return;
					}
				}
				//}
			}
			if (!bolError)
				CargarGrilla();
			Cursor = Cursors.Default;
		}

		private void tsbEliminar_Click(object sender, EventArgs e)
		{
			DataTable dt = ((DataTable)dtgPrincipal.DataSource);
			List<string> lista = dt.AsEnumerable().Where(s => (bool)s["Seleccionar"]).Select(s => s[0].ToString()).ToList();
			if (lista.Count == 0)
				"Debe Seleccionar registro para eliminar".XMensajeError();
			else
			{
				if ("¿Esta seguro eliminar los registros?".XMensajeConfirmacionSiNo())
				{
					string strMensajeError = "";
					StringBuilder sbMensaje = new StringBuilder();
					for (int intLista = 0; intLista < lista.Count; intLista++)
					{
						SqlCommand cmd = new SqlCommand();
						cmd.CommandText = "DireccionDel";
						cmd.Parameters.Add("@Id_sucursal", SqlDbType.Int);
						cmd.Parameters["@Id_sucursal"].Value = lista[intLista];


						cmd.CommandType = CommandType.StoredProcedure;
						Conectar.AgregarModificarEliminar(ClaseGeneral.Conexion, cmd, ref strMensajeError);
						if (!string.IsNullOrWhiteSpace(strMensajeError))
						{
							Cursor = Cursors.Default;
							sbMensaje.AppendLine(string.Format("-{0}{1}", lista[intLista], strMensajeError));
							ClaseGeneral.GuardarLOG(this.Name, "DireccionDel", "Grabar");
						}
					}
					if (string.IsNullOrWhiteSpace(sbMensaje.ToString()))
						sbMensaje.ToString().XMensajeError();
					CargarDatosInicial();
				}
			}
		}

		#endregion

		#region Accion
		private void AsignarEvento()
		{
			txtNCliente.EventoAsignarNumero(999);
		}
		private void Iniciarparametro()
		{
			btnCargar.Enabled = false;
			tsbModificar.Enabled = false;
			tsbEliminar.Enabled = false;
			tsbAgregar.Enabled = false;
		}
		private void AsignarPermiso()
		{
			Cursor = Cursors.WaitCursor;
			Conectar.PermisoFormulario(intMenu, ref Lectura, ref Agregar, ref Modificar, ref Eliminar);
			Cursor = Cursors.Default;

			tsbGuardar.Visible = false;

			dtgPrincipal.ReadOnly = Lectura ? true : !(Eliminar);
			dtgPrincipal.DefaultCellStyle.BackColor = ClaseGeneral.ColorCeldaBloqueado;
			Cursor = Cursors.Default;
		}
		private void CargarGrilla()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "DireccionGrid";
			cmd.Parameters.Add("@id_cliente", SqlDbType.Int);
			cmd.Parameters["@id_cliente"].Value = txtNCliente.Text;
			cmd.Parameters.Add("@run", SqlDbType.VarChar);
			cmd.Parameters["@run"].Value = txtRut.Text;
			cmd.CommandType = CommandType.StoredProcedure;

			DataSet dt;
			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

			if (dt != null)
			{
				dtgPrincipal.DataSource = dt.Tables[0];
				tsbEliminar.Enabled = Lectura == false && Eliminar && dt.Tables[0].Rows.Count > 0;
				tsbModificar.Enabled = Lectura == false && Modificar && dt.Tables[0].Rows.Count > 0;
			}


		}
		#endregion

		#region Boton
		private void btnCargar_Click(object sender, EventArgs e)
		{
			CargarGrilla();
		}

		private void dtgPrincipal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;
			tsbModificar_Click(null, null);
		}

		private void btn_cargarCliente_Click(object sender, EventArgs e)
		{
			if (txtNCliente.DevuelveCadenaNulo() == null) return;

			Cursor = Cursors.WaitCursor;

			frmAyudaCliente frm = new frmAyudaCliente(txtNCliente.DevuelveEntero());

			if (frm.ShowDialog() == DialogResult.OK)
			{
				txtRazonSocial.Text = txtNCliente.DevuelveCadenaNulo() != null ? Clases.ClsCliente.Nombres : "";
				txtRut.Text = txtNCliente.DevuelveCadenaNulo() != null ? Clases.ClsCliente.Rut : "";
				txtNCliente.Enabled = false;
				btnCargar.Enabled = true;
				btn_cargarCliente.Enabled = false;
				tsbAgregar.Enabled = Lectura == false && Agregar;
				btnCargar_Click(null,null);
			}
			Cursor = Cursors.Default;
		}
		private void btn_Filtro_Click(object sender, EventArgs e)
		{
			txtNCliente.Clear();
			txtRut.Clear();
			txtRazonSocial.Clear();
			txtNCliente.Enabled = true;
			btnCargar.Enabled = false;
			btn_cargarCliente.Enabled = true;
			tsbAgregar.Enabled = tsbEliminar.Enabled = tsbModificar.Enabled = false;
			dtgPrincipal.LimpiarDataGridView();
		}
		#endregion

		#region Grilla
		private void dtgPrincipal_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			if (dtgPrincipal.DataSource == null) return;

			if (e.ListChangedType == ListChangedType.Reset)
			{
				foreach (DataGridViewRow item in dtgPrincipal.Rows)
				{
					DataRow dtrFila = ((DataRowView)item.DataBoundItem).Row;
					item.DefaultCellStyle.BackColor = ClaseGeneral.ColorCeldaBloqueado;


					item.Cells[colSeleccionar.Index].ReadOnly = !Eliminar;
					item.Cells[colSeleccionar.Index].Style.BackColor = (bool)Eliminar ? SystemColors.Window : ClaseGeneral.ColorCeldaBloqueado;
				}
			}
		}
		#endregion
	}
}
