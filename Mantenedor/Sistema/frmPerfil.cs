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
	public partial class frmPerfil : Form
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
		public frmPerfil()
		{
			InitializeComponent();
			dtgPrincipal.AutoGenerateColumns = false;
		}
		private void frmPerfil_Load(object sender, EventArgs e)
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

			row["Id_perfil"] = 0;
			row["Estado"] = true;
			row["Modificar"] = true;
			row["Eliminar"] = false;
			ValidarFila(ref row);
			dt.Rows.Add(row);

			dtgPrincipal.DataSource = dt;

		}
		private void tsbGuardar_Click(object sender, EventArgs e)
		{
			dtgPrincipal.FinalizaEdicion();
			if (ValidarFormulario()) return;


			string strMensajeError = "";
			bool bolError = false;
			Cursor = Cursors.WaitCursor;
			if (((DataTable)dtgPrincipal.DataSource).GetChanges(DataRowState.Modified) != null || ((DataTable)dtgPrincipal.DataSource).GetChanges(DataRowState.Added) != null
				|| ((DataTable)dtgPrincipal.DataSource).GetChanges(DataRowState.Deleted) != null)
			{


				foreach (DataRow row in ((DataTable)dtgPrincipal.DataSource).Rows)
				{

					if (row.RowState == DataRowState.Added)
					{
						SqlCommand cmd = new SqlCommand();
						cmd.CommandText = "Sist_perfilIns";
						cmd.Parameters.Add("@Id_perfil", SqlDbType.Int);
						cmd.Parameters["@Id_perfil"].Value = ParameterDirection.Output;
						cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 100);
						cmd.Parameters["@Descripcion"].Value = row["Descripcion"];
						cmd.Parameters.Add("@Estado", SqlDbType.Bit);
						cmd.Parameters["@Estado"].Value = (bool)row["Estado"];
						cmd.CommandType = CommandType.StoredProcedure;
						Conectar.Agregar(ClaseGeneral.Conexion, cmd, "Id_perfil", ref strMensajeError);

						row.RowError = strMensajeError;
						if (!string.IsNullOrWhiteSpace(strMensajeError))
						{
							bolError = true;
							Cursor = Cursors.Default;
							ClaseGeneral.GuardarLOG(this.Name, "Sist_perfilIns", "Grabar");
							return;
						}
					}
					else
					if (row.RowState == DataRowState.Modified)
					{
						SqlCommand cmd = new SqlCommand();
						cmd.CommandText = "Sist_perfilUpd";
						cmd.Parameters.Add("@Id_perfil", SqlDbType.Int);
						cmd.Parameters["@Id_perfil"].Value = row["Id_perfil"];
						cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 100);
						cmd.Parameters["@Descripcion"].Value = row["Descripcion"];
						cmd.Parameters.Add("@Estado", SqlDbType.Bit);
						cmd.Parameters["@Estado"].Value = (bool)row["Estado"];

						cmd.CommandType = CommandType.StoredProcedure;
						Conectar.Modificar(ClaseGeneral.Conexion, cmd, ref strMensajeError);
						row.RowError = strMensajeError;
						if (!string.IsNullOrWhiteSpace(strMensajeError))
						{
							bolError = true;
							Cursor = Cursors.Default;
							ClaseGeneral.GuardarLOG(this.Name, "Sist_perfilUpd", "Grabar");
							return;
						}
					}
					else
					if (row.RowState == DataRowState.Deleted || row.RowState == DataRowState.Detached)
					{
						SqlCommand cmd = new SqlCommand();
						cmd.CommandText = "Sist_perfilDel";
						cmd.Parameters.Add("@Id_perfil", SqlDbType.Int);
						cmd.Parameters["@Id_perfil"].Value = row["Id_perfil", DataRowVersion.Original];


						cmd.CommandType = CommandType.StoredProcedure;
						Conectar.AgregarModificarEliminar(ClaseGeneral.Conexion, cmd, ref strMensajeError);
						row.RowError = strMensajeError;
						if (!string.IsNullOrWhiteSpace(strMensajeError))
						{
							bolError = true;
							Cursor = Cursors.Default;
							ClaseGeneral.GuardarLOG(this.Name, "Sist_perfilDel", "Grabar");
							return;
						}
					}
				}
			}
			if (!bolError)
				CargarGrilla();
			Cursor = Cursors.Default;
		}

		private void tsbEliminar_Click(object sender, EventArgs e)
		{
			dtgPrincipal.FinalizaEdicion();
			DataTable dt = ((DataTable)dtgPrincipal.DataSource);
			List<string> lista = dt.AsEnumerable().Where(s => (bool)s["Eliminar"]).Select(s => s[0].ToString()).ToList();
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
						cmd.CommandText = "Sist_perfilDel";
						cmd.Parameters.Add("@Id_perfil", SqlDbType.Int);
						cmd.Parameters["@Id_perfil"].Value = lista[intLista];


						cmd.CommandType = CommandType.StoredProcedure;
						Conectar.AgregarModificarEliminar(ClaseGeneral.Conexion, cmd, ref strMensajeError);
						if (!string.IsNullOrWhiteSpace(strMensajeError))
						{
							Cursor = Cursors.Default;
							sbMensaje.AppendLine(string.Format("{0}{1}", lista[intLista], strMensajeError));
							ClaseGeneral.GuardarLOG(this.Name, "Sist_perfilDel", "Grabar");
						}
					}
					if (!string.IsNullOrWhiteSpace(sbMensaje.ToString()))
						sbMensaje.ToString().XMensajeError();
					CargarDatosInicial();
				}
			}
		}

		#endregion

		#region Accion

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
			if (string.IsNullOrWhiteSpace(row["Descripcion"].ToString()))
				Mensaje = "- campo obligatorio: Descripción.";

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
			cmd.CommandText = "Sist_perfilGrid";

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

			if (e.ColumnIndex == colDescripcion.Index || e.ColumnIndex == colEstado.Index)
			{
				DataRow row = ((DataRowView)dtgPrincipal.Rows[e.RowIndex].DataBoundItem).Row;

				bool bolEstado = row.RowState == DataRowState.Added;
				row.AcceptChanges();
				if (bolEstado)
					row.SetAdded();
				else
					row.SetModified();
			}
		}
		private void dtgPrincipal_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			if (dtgPrincipal.DataSource == null) return;

			if (e.ListChangedType == ListChangedType.Reset)
			{
				foreach (DataGridViewRow item in dtgPrincipal.Rows)
				{
					DataRow dtrFila = ((DataRowView)item.DataBoundItem).Row;
					item.ReadOnly = !(bool)dtrFila["Modificar"] || (!Modificar);
					item.DefaultCellStyle.BackColor = (bool)dtrFila["Modificar"] ? SystemColors.Window : ClaseGeneral.ColorCeldaBloqueado;

					item.Cells[colEliminar.Index].ReadOnly = !(bool)dtrFila["Modificar"] || !Eliminar;
					item.Cells[colEliminar.Index].Style.BackColor = (bool)Eliminar && (bool)dtrFila["Modificar"] ? SystemColors.Window : ClaseGeneral.ColorCeldaBloqueado;
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
