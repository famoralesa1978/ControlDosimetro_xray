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

namespace ControlDosimetro
{
	public partial class frmModificarPersonalMasivo : Form
	{

		#region "Definicion variable"
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		Clases.ClassEvento clsEvento = new Clases.ClassEvento();
		classFuncionesBD.ClsFunciones ClaseFunciones = new classFuncionesBD.ClsFunciones();
		bool bolDesdeCodigo;
		bool bolInicializacion;
		bool Lectura;
		bool Nuevo;
		bool Modificacion;
		bool Eliminar;
		DataSet dt;
		DataSet dtPersonal;
		public int Id_Menu { get; private set; }

		public object[] Parametros
		{
			set
			{
				if (value != null)
				{
					Id_Menu = (int)value[0];
				}
			}
		}
		#endregion

		public frmModificarPersonalMasivo()
		{
			InitializeComponent();

			AsignarEvento();
		}

		private void frmModificarPersonalMasivo_Load(object sender, EventArgs e)
		{
			bolDesdeCodigo = true;
			AsignarPermiso();
			grdDatos.AutoGenerateColumns = false;
		}

		#region "Llamada de carga"

		private void AsignarPermiso()
		{
			ClaseFunciones.Cargar_Permiso(Clases.clsUsuario.Id_perfil, Id_Menu, ref Lectura, ref Nuevo, ref Modificacion, ref Eliminar);
			tsbGuardar.Visible = Modificacion;
		}

		private void Listar_Cliente(Int64 intCliente)
		{
			//SqlCommand cmd = new SqlCommand();
			SqlCommand cmd = new SqlCommand();
			//MessageBox.Show("Conectado al servidor");

			if (intCliente != 0)
			{
				cmd.CommandText = "select id_cliente,run,razon_social,Direccion,telefono " +
						"from tbl_cliente " +
						"where  (id_cliente=" + intCliente.ToString() + ") or run ='" + txt_Rut.Text + "' " +
						" and id_estado=1 " +
						"order by id_cliente";
				txt_ref_cliente.Text = intCliente.ToString();
			}
			if (intCliente == 0)
				cmd.CommandText = "select id_cliente,run,razon_social,Direccion,telefono " +
						"from tbl_cliente " +
						"where run  ='" + txt_Rut.Text + "' " + " and id_estado=1 " +
						"order by id_cliente";
			cmd.CommandType = CommandType.Text;

			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			if (dt.Tables[0].Rows.Count == 0)
			{
				txt_ref_cliente.Text = "";
				txt_Rut.Text = "";
				txt_RazonSocial.Text = "";
				tsbGuardar.Visible = false;
			}
			else
			{
				txt_ref_cliente.Text = dt.Tables[0].Rows[0]["id_cliente"].ToString();
				txt_Rut.Text = dt.Tables[0].Rows[0]["run"].ToString();
				txt_RazonSocial.Text = dt.Tables[0].Rows[0]["razon_social"].ToString();
				txt_ref_cliente.ReadOnly = true;
				txt_Rut.ReadOnly = true;
				tsbGuardar.Visible = Modificacion;
				txt_RazonSocial.ReadOnly = true;
				Cargar_Seccion();
				Cargar_CodServicio();
				Listar_Personal();
			}
		}

		private void Listar_Personal()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "pa_ListarPersonal_sel '" + txt_Rut.Text + "'";
			cmd.CommandType = CommandType.Text;

			dtPersonal = Conectar.Listar(Clases.clsBD.BD, cmd);
			grdDatos.DataSource = dtPersonal.Tables[0];
		}

		private void Cargar_Seccion()
		{
			SqlCommand cmd = new SqlCommand();
			//  SqlCommand cmd = new SqlCommand();

			cmd.CommandText = "select ' ' as seccion, 0 as id_seccion union" +
							 "		SELECT seccion,id_seccion " +
							" FROM tbl_seccion  WHERE Id_cliente= " + txt_ref_cliente.Text.ToString() + " and id_estado=1";
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			DataGridViewComboBoxColumn comboboxColumn = grdDatos.Columns[ColSeccion.Index] as DataGridViewComboBoxColumn;
			comboboxColumn.DataSource = dt.Tables[0];
			comboboxColumn.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
			comboboxColumn.ValueMember = dt.Tables[0].Columns[1].Caption.ToString();
		}

		private void Cargar_CodServicio()
		{
			ComboBox cb = new ComboBox();
			ClaseComun.Listar_Parametro(Clases.clsBD.BD, ref cb, 16);

			DataGridViewComboBoxColumn comboboxColumn = grdDatos.Columns[ColServicio.Index] as DataGridViewComboBoxColumn;

			comboboxColumn.DataSource = cb.DataSource;
			comboboxColumn.DisplayMember = cb.DisplayMember;
			comboboxColumn.ValueMember = cb.ValueMember;

		}

		private void AsignarEvento()
		{
			clsEvento.AsignarRutSinGuion(ref txt_Rut);
			clsEvento.AsignarRutSinGuion(ref txt_RunPersonal);
			clsEvento.AsignarNumero(ref txt_ref_cliente);
			clsEvento.AsignarKeyPress(ref txt_RazonSocial);
		}



		#endregion

		#region "button"       


		private void btn_cargarCliente_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			bolDesdeCodigo = true;
			if (txt_ref_cliente.Text == "")
				Listar_Cliente(0);
			else
				Listar_Cliente(Convert.ToInt64(txt_ref_cliente.Text.ToString()));

			if (txt_RazonSocial.Text == "")
			{

				tsbGuardar.Visible = false;
			}

			Cursor = Cursors.Default;

		}

		private void btn_Filtro_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			txt_ref_cliente.ReadOnly = false;
			txt_ref_cliente.Text = "";
			txt_Rut.Text = "";
			txt_RazonSocial.Text = "";
			Listar_Cliente(0);
			Listar_Personal();
			txt_ref_cliente.Focus();

			Cursor = Cursors.Default;
		}

		private void picFiltrarpersonal_Click(object sender, EventArgs e)
		{
			classFuncionesGenerales.Filtro.FiltroPersonal(ref grdDatos, txt_NombrePersonal.Text, txt_RunPersonal.Text);
		}

		#endregion

		#region "grilla"

		private void grdDatos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			DataGridView dgv = sender as DataGridView;
			if (null == dgv || null == dgv.CurrentCell || !dgv.IsCurrentCellDirty)
			{
				return;
			}

			if ((dgv.CurrentCell is DataGridViewComboBoxCell || dgv.CurrentCell is DataGridViewCheckBoxCell))
			{
				grdDatos.CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		private void grdDatos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				if (e.ColumnIndex == ColServicio.Index)
				{
					grdDatos.Rows[e.RowIndex].Cells[ColServicio.Index].Value = ((DataTable)grdDatos.DataSource).Rows[e.RowIndex]["Id_CodServicio"];
					((DataTable)grdDatos.DataSource).Rows[e.RowIndex].AcceptChanges();
				}
				else
				if (e.ColumnIndex == ColSeccion.Index)
				{
					grdDatos.Rows[e.RowIndex].Cells[ColSeccion.Index].Value = ((DataTable)grdDatos.DataSource).Rows[e.RowIndex]["Id_Seccion"];
					((DataTable)grdDatos.DataSource).Rows[e.RowIndex].AcceptChanges();
				}


				((DataTable)grdDatos.DataSource).Rows[e.RowIndex].RejectChanges();
				((DataTable)grdDatos.DataSource).Rows[e.RowIndex].SetModified();
			}
		}


		#endregion

		#region Barra

		private void tsbGuardar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			SqlCommand cmd = new SqlCommand();
			//foreach (DataRow dr in ((DataTable)grdDatos.DataSource).Rows)
			foreach (DataRow dr in ((DataTable)grdDatos.DataSource).GetChanges(DataRowState.Modified).Rows)
			{
				//	if (dr["Id_CodServicio"] != dr["Id_CodServicio",DataRowVersion.Original])
				if (dr.RowState == DataRowState.Modified)
				{
					String strParametro = "";
					if (dr["Id_CodServicio"] == DBNull.Value)
						strParametro = "Null" + ",";
					else
						strParametro = dr["Id_CodServicio"].ToString() + ",";

					if (dr["Id_Seccion"] == DBNull.Value)
						strParametro = "Null";
					else
						strParametro = strParametro + dr["Id_Seccion"].ToString();


					cmd.CommandText = "pa_PersonalMasivo_Upd " + dr["Id_Personal"] + "," + strParametro;
					cmd.CommandType = CommandType.Text;
					Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);
				}

			}
			Cursor = Cursors.Default;

		}


		#endregion



	}
}
