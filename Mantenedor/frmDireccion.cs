using Clases;
using dllLibreriaEvento;
using DocumentFormat.OpenXml.Office.Word;
using NPOI.Util;
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
		clsEventoControl ClaseEvento = new clsEventoControl();
		public int intMenu;

		private bool Lectura, Agregar, Modificar, Eliminar;
		private bool bolInicializar = true;

		#endregion

		#region "Inicio"
		public frmDireccion()
		{
			InitializeComponent();
			AsignarEvento();
			dtgPrincipal.AutoGenerateColumns = false;
		}
		private void frmDireccion_Load(object sender, EventArgs e)
		{
			AsignarPermiso();
			bolInicializar = true;

			CargarDatosInicial();

			bolInicializar = false;
		}
		private void CargarDatosInicial()
		{
			if (txt_cliente.DevuelveEnteroNulo() == null && txt_Rut.DevuelveCadenaNulo() == null)
				btnFiltrar.Enabled = false;
			CargarGrilla();
		}

		#endregion

		#region Barra

		private void tsbRefrescar_Click(object sender, EventArgs e)
		{
			if (txt_cliente.DevuelveEnteroNulo() == null && txt_Rut.DevuelveCadenaNulo() == null)
			{
				btnFiltrar.Enabled = false;
				if (!bolInicializar)
					"Debe tener Datos en el n° cliente y rut".XMensajeError();
				return;
			}
			CargarDatosInicial();
		}
		private void tsbAgregar_Click(object sender, EventArgs e)
		{
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
						cmd.Parameters.Add("@Id_sucursal", SqlDbType.Int);
						cmd.Parameters["@Id_sucursal"].Value = lista[intLista];


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
		private void AsignarPermiso()
		{
			Cursor = Cursors.WaitCursor;
			Conectar.PermisoFormulario(intMenu, ref Lectura, ref Agregar, ref Modificar, ref Eliminar);
			Cursor = Cursors.Default;
			tsbModificar.Visible = false;
			tsbGuardar.Enabled = false;//Lectura == false && (Agregar || Modificar);

			dtgPrincipal.DefaultCellStyle.BackColor = ClaseGeneral.ColorCeldaBloqueado;
			tsbAgregar.Enabled = Lectura == false && Agregar;
			tsbModificar.Enabled = Lectura == false && Modificar;
			tsbEliminar.Enabled = Lectura == false && Eliminar;
			Cursor = Cursors.Default;
		}
		private void AsignarEvento()
		{
			txt_cliente.EventoAsignarNumero(9999999);
			txt_RazonSocial.EventoAsignarAvanzar();
		}
		private void CargarGrilla()
		{
			Cursor = Cursors.WaitCursor;
			SqlCommand cmd = new SqlCommand();

			cmd.CommandText = "DireccionGrid";
			cmd.Parameters.Add("@id_cliente", SqlDbType.Int);
			cmd.Parameters["@id_cliente"].Value = txt_cliente.DevuelveEnteroNulo();
			cmd.Parameters.Add("@run", SqlDbType.VarChar, 11);
			cmd.Parameters["@run"].Value = txt_Rut.DevuelveCadenaNulo();
			cmd.CommandType = CommandType.StoredProcedure;

			DataSet dt;
			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

			if (dt != null)
				dtgPrincipal.DataSource = dt.Tables[0];

			tsbEliminar.Enabled = Lectura == false && Eliminar && dtgPrincipal.Rows.Count>0;
			Cursor = Cursors.Default;
		}



		#endregion

		#region Boton

		private void btn_cargarCliente_Click(object sender, EventArgs e)
		{
			if (txt_cliente.DevuelveEnteroNulo() == null && txt_Rut.DevuelveCadenaNulo() == null)
			{
				btnFiltrar.Enabled = false;
				if (!bolInicializar)
					"Debe tener Datos en el n° cliente y rut".XMensajeError();
				return;
			}
			Cursor = Cursors.WaitCursor;
			btnFiltrar.Enabled = false;
			txt_cliente.ReadOnly = false;
			txt_Rut.ReadOnly = false;
			if (txt_cliente.DevuelveEnteroNulo() != null)
			{
				frmAyudaCliente frm = new frmAyudaCliente(Convert.ToInt64(txt_cliente.Text));

				if (frm.ShowDialog() == DialogResult.OK)
				{
					txt_RazonSocial.Text = (Convert.ToInt64(txt_cliente.Text) > 1) ? Clases.ClsCliente.Nombres : "";
					txt_Rut.Text = (Convert.ToInt64(txt_cliente.Text) > 1) ? Clases.ClsCliente.Rut : "";
					btnFiltrar.Enabled = true;
					txt_cliente.ReadOnly = true;
					txt_Rut.ReadOnly = true;
				}
			}
			else if (txt_Rut.DevuelveCadenaNulo() == null)
			{
				SqlCommand cmd = new SqlCommand();
				cmd.CommandText = "select id_cliente,run,razon_social,Direccion,telefono " +
						"from tbl_cliente " +
						"where run  ='" + txt_Rut.Text + "' " + " and id_estado=1 " +
						"order by id_cliente";
				cmd.CommandType = CommandType.Text;

				DataSet dt;
				dt = Conectar.Listar(Clases.clsBD.BD, cmd);

				if (dt.Tables[0].Rows.Count == 0)
				{
					txt_cliente.Text = "";
					txt_Rut.Text = "";
					txt_RazonSocial.Text = "";
				}
				else
				{
					txt_cliente.Text = dt.Tables[0].Rows[0]["id_cliente"].ToString();
					txt_Rut.Text = dt.Tables[0].Rows[0]["run"].ToString();
					txt_RazonSocial.Text = dt.Tables[0].Rows[0]["razon_social"].ToString();
					txt_cliente.ReadOnly = true;
					txt_Rut.ReadOnly = true;
					btnFiltrar.Enabled = true;
				}
			}

			Cursor = Cursors.Default;
		}
		private void btnFiltrar_Click(object sender, EventArgs e)
		{
			if (txt_cliente.DevuelveEnteroNulo() == null && txt_Rut.DevuelveCadenaNulo() == null)
			{
				if (!bolInicializar)
					"Debe tener Datos en el filtro".XMensajeError();
				return;
			}
			CargarGrilla();
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

					for(int intColumna=0; intColumna< dtgPrincipal.Rows.Count; intColumna++)
					{
						if(intColumna== colSeleccionar.Index)
						{
							item.Cells[colSeleccionar.Index].ReadOnly = !Eliminar;
							item.Cells[colSeleccionar.Index].Style.BackColor = (bool)Eliminar ? SystemColors.Window : ClaseGeneral.ColorCeldaBloqueado;
						}
						else
						{
							item.Cells[intColumna].ReadOnly = true;
							item.DefaultCellStyle.BackColor = (bool)dtrFila["Estado"] ? ClaseGeneral.ColorCeldaBloqueado: System.Drawing.Color.Red;
						}
					}
				}
			}
		}
		#endregion
	}
}
