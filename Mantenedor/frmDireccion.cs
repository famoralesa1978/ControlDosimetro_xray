using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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
			LlenarDDls();

		}
		private void frmDireccion_Load(object sender, EventArgs e)
		{
			AsignarPermiso();
			
			CargarDatosInicial();
			
			bolInicializar = false;
		}
		private void CargarDatosInicial()
		{
			CargarGrilla();
		}

		#endregion

		#region Barra

		private void tsbRefrescar_Click(object sender, EventArgs e)
		{
			if (dtgPrincipal.XHayCambio())
			{
				if ("Hay datos modificado,¿Desea aactualizar los datos?".XMensajeConfirmacionSiNo())
				{
					tsbGuardar_Click(null, null);
				}
				else
					CargarDatosInicial();
			}
			else
				CargarDatosInicial();
		}
		private void tsbAgregar_Click(object sender, EventArgs e)
		{
			DataTable dt = (DataTable)dtgPrincipal.DataSource;


			DataRow row = dt.NewRow();

			row["Id_Usuario"] = 0;
			row["Rut"] = "";
			row["Nombres"] = "";
			row["Paterno"] = "";
			row["Maternos"] = "";
			row["Id_perfil"] = DBNull.Value;
			row["Email"] = "";
			row["Estado"] = true;
			row["Usuario"] = "";
			row["Contraseña"] = "";
			ValidarFila(ref row);
			dt.Rows.Add(row);

			dtgPrincipal.DataSource = dt;

		}
		private void tsbGuardar_Click(object sender, EventArgs e)
		{
			if (ValidarFormulario()) return;


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
					cmd.Parameters["@Maternos"].Value =  row["Maternos"];
					cmd.Parameters.Add("@Id_perfil", SqlDbType.Int);
					cmd.Parameters["@Id_perfil"].Value = row["Id_perfil"];
					cmd.Parameters.Add("@Estado", SqlDbType.Bit);
					cmd.Parameters["@Estado"].Value = (bool)row["Estado"];
					cmd.Parameters.Add("@Email", SqlDbType.VarChar,200);
					cmd.Parameters["@Email"].Value = row["Email"];
					cmd.Parameters.Add("@Usuario", SqlDbType.VarChar,30);
					cmd.Parameters["@Usuario"].Value = row["Usuario"];
					cmd.Parameters.Add("@Contraseña", SqlDbType.VarChar,100);
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
					for (int intLista = 0; intLista < lista.Count; intLista++)
					{
						SqlCommand cmd = new SqlCommand();
						cmd.CommandText = "DireccionDel";
						cmd.Parameters.Add("@Id_Usuario", SqlDbType.Int);
						cmd.Parameters["@Id_Usuario"].Value = lista[intLista];


						cmd.CommandType = CommandType.StoredProcedure;
						Conectar.AgregarModificarEliminar(ClaseGeneral.Conexion, cmd, ref strMensajeError);
						if (!string.IsNullOrWhiteSpace(strMensajeError))
						{
							Cursor = Cursors.Default;
							ClaseGeneral.GuardarLOG(this.Name, "DireccionDel", "Grabar");
						}
					}
					CargarDatosInicial();
				}
			}
		}

		#endregion

		#region Accion

		private void LlenarDDls()
		{
			DataGridViewComboBoxColumn comboboxColumn = dtgPrincipal.Columns[colId_perfil.Index] as DataGridViewComboBoxColumn;

			comboboxColumn.DataSource = ClaseGeneral.CargarPerfil().Tables[0];
			comboboxColumn.DisplayMember = "Descripcion";
			comboboxColumn.ValueMember = "Id_Perfil";			
		}

		private bool ValidarFormulario()
		{
			if (dtgPrincipal.XHayError())
			{
				"Hay errores en las filas. Revise la información".XMensajeError();
				return true;
			}
			else
				return false;
		}
		private void ValidarFila(ref DataRow row)
		{
			string Mensaje = "";
			row.ClearErrors();
			if (string.IsNullOrWhiteSpace(row["Rut"].ToString()))
				Mensaje += "- campo obligatorio: Rut."+ Environment.NewLine;
			else
				if (row["Rut"].ToString().XValidarRut())
				Mensaje += "- Error:  Rut incorrecto." + Environment.NewLine;
			if (string.IsNullOrWhiteSpace(row["Nombres"].ToString()))
				Mensaje += "- campo obligatorio: Nombres." + Environment.NewLine;
			if (string.IsNullOrWhiteSpace(row["Paterno"].ToString()))
				Mensaje += "- campo obligatorio:  Paterno." + Environment.NewLine;
			if (string.IsNullOrWhiteSpace(row["Maternos"].ToString()))
				Mensaje += "- campo obligatorio:  Maternos." + Environment.NewLine;
			if (string.IsNullOrWhiteSpace(row["Id_perfil"].ToString()))
				Mensaje += "- campo obligatorio:  Perfil." + Environment.NewLine;
			if (string.IsNullOrWhiteSpace(row["Email"].ToString()))
				Mensaje += "- campo obligatorio:  Email." + Environment.NewLine;
			else
				if (row["Email"].ToString().XValidarEmail())
				Mensaje += "- Error:  Formato incorrecto del Email." + Environment.NewLine;
			if (string.IsNullOrWhiteSpace(row["Usuario"].ToString()))
				Mensaje += "- campo obligatorio:  Usuario." + Environment.NewLine;
			if (string.IsNullOrWhiteSpace(row["Contraseña"].ToString()))
				Mensaje += "- campo obligatorio:  Contraseña." + Environment.NewLine;
			if (!string.IsNullOrWhiteSpace(Mensaje))
				row.RowError = string.Format("Lista de error: {0}{1}", Environment.NewLine, Mensaje);

		}
		private void AsignarPermiso()
		{
			Cursor = Cursors.WaitCursor;
			Conectar.PermisoFormulario(intMenu, ref Lectura, ref Agregar, ref Modificar, ref Eliminar);
			Cursor = Cursors.Default;
			tsbModificar.Visible = false;
			tsbGuardar.Enabled = Lectura == false && (Agregar || Modificar);
			dtgPrincipal.ReadOnly = Lectura ? true : !(Agregar || Modificar || Eliminar);
			dtgPrincipal.DefaultCellStyle.BackColor = !Lectura && (Agregar || Modificar) ? SystemColors.Window : ClaseGeneral.ColorCeldaBloqueado;
			tsbAgregar.Enabled = Lectura == false && Agregar;
			tsbEliminar.Enabled = Lectura == false && Eliminar;
			Cursor = Cursors.Default;
		}



		private void CargarGrilla()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "DireccionGrid";

			cmd.CommandType = CommandType.StoredProcedure;

			DataSet dt;
			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

			if (dt != null)
				dtgPrincipal.DataSource = dt.Tables[0];
		}

		#endregion

		#region Grilla
		private void dtgPrincipal_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (dtgPrincipal.DataSource == null) return;

			DataRow row = ((DataRowView)dtgPrincipal.Rows[e.RowIndex].DataBoundItem).Row;

			bool bolEstado = row.RowState == DataRowState.Added;


			row.AcceptChanges();
			if (bolEstado)
				row.SetAdded();
			else
				row.SetModified();
		}
		private void dtgPrincipal_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			if (dtgPrincipal.DataSource == null) return;

			if (e.ListChangedType == ListChangedType.Reset)
			{
				foreach (DataGridViewRow item in dtgPrincipal.Rows)
				{
					DataRow dtrFila = ((DataRowView)item.DataBoundItem).Row;
					item.ReadOnly = !Modificar || (!Modificar);
					item.DefaultCellStyle.BackColor = Modificar ? SystemColors.Window : ClaseGeneral.ColorCeldaBloqueado;


					item.Cells[colSeleccionar.Index].ReadOnly = !Eliminar;
					item.Cells[colSeleccionar.Index].Style.BackColor = (bool)Eliminar ? SystemColors.Window : ClaseGeneral.ColorCeldaBloqueado;
					item.Cells[colContraseña.Index].Style.BackColor =  ClaseGeneral.ColorCeldaBloqueado;
					item.Cells[colContraseña.Index].ReadOnly = true;
				}
			}
		}



		private void dtgPrincipal_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
		{
			if (!bolInicializar)
			{
				if (e.RowIndex == -1) return;
				DataRow row = ((DataRowView)dtgPrincipal.Rows[e.RowIndex].DataBoundItem).Row;
				ValidarFila(ref row);
			}

		}
		private void dtgPrincipal_RowValidated(object sender, DataGridViewCellEventArgs e)
		{
			if (!bolInicializar)
			{
				if (e.RowIndex == -1) return;
				DataRow row = ((DataRowView)dtgPrincipal.Rows[e.RowIndex].DataBoundItem).Row;
				ValidarFila(ref row);
			}
		}
		#endregion
	}
}
