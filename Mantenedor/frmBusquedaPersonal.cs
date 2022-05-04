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
	public partial class frmBusquedaPersonal : Form
	{

		#region "Definicion variable"
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		Clases.ClassEvento clsEvento = new Clases.ClassEvento();
		#endregion

		public frmBusquedaPersonal(Int64 intId_Cliente)
		{
			InitializeComponent();
			grdDatos.AutoGenerateColumns = false;
			AsignarEvento();
			Listar_Cliente(intId_Cliente);

		}

		#region "Llamada de carga"

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
				grpPersonal.Enabled = false;
				tsb_Eliminar.Visible = tsb_Agregar.Visible = tsbAsignarSucursal.Visible = tsbAsignarSeccion.Visible= false;
			}
			else
			{
				txt_ref_cliente.Text = dt.Tables[0].Rows[0]["id_cliente"].ToString();
				txt_Rut.Text = dt.Tables[0].Rows[0]["run"].ToString();
				txt_RazonSocial.Text = dt.Tables[0].Rows[0]["razon_social"].ToString();
				txt_ref_cliente.ReadOnly = true;
				txt_Rut.ReadOnly = true;
				tsbAsignarSucursal.Visible = tsbAsignarSeccion.Visible = tsb_Eliminar.Visible = tsb_Agregar.Visible = true;
				txt_RazonSocial.ReadOnly = true;
				Listar_Personal();
			}
		}

		private void Listar_Personal()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = String.Format("pa_ListarPersonal_sel {0},'{1}'", (String.IsNullOrWhiteSpace(txt_ref_cliente.Text)?"0": txt_ref_cliente.Text),txt_Rut.Text);
			cmd.CommandType = CommandType.Text;
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);
			grpPersonal.Enabled = true;
			dt.Tables[0].DefaultView.RowFilter = "Id_estado=1";
			grdDatos.DataSource = dt.Tables[0].DefaultView.ToTable();
		}

		private void AsignarEvento()
		{
			clsEvento.AsignarRutSinGuion(ref txt_Rut);
			clsEvento.AsignarRutSinGuion(ref txt_RunPersonal);
			clsEvento.AsignarNumero(ref txt_ref_cliente);
			clsEvento.AsignarKeyPress(ref txt_RazonSocial);
		}



		#endregion

		#region Textbox

		private void txt_ref_cliente_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Return)
				btn_cargarCliente_Click(null, null);
		}

		private void txt_RunPersonal_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
				picFiltrarpersonal_Click(null, null);
		}

		private void txt_NombrePersonal_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
				picFiltrarpersonal_Click(null, null);
		}

		#endregion

		#region "button"       

		private void btn_Agregar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			frmPersonalMant frm = new frmPersonalMant(Convert.ToInt64(txt_ref_cliente.Text), 0, txt_Rut.Text);
			frm.ShowDialog(this);
			Listar_Personal();

			Cursor = Cursors.Default;
		}

		private void btn_cargarCliente_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			if (txt_ref_cliente.Text == "")
				Listar_Cliente(0);
			else
				Listar_Cliente(Convert.ToInt64(txt_ref_cliente.Text.ToString()));

			if (txt_RazonSocial.Text == "")
			{

				tsbAsignarSucursal.Visible = tsbAsignarSeccion.Visible = tsb_Eliminar.Visible = tsb_Agregar.Visible = false;
				grpPersonal.Enabled = false;
			}

			Cursor = Cursors.Default;

		}

		private void btn_Filtro_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			txt_ref_cliente.ReadOnly = false;
			txt_Rut.ReadOnly = false;
			txt_ref_cliente.Text = "";
			txt_Rut.Text = "";
			txt_RazonSocial.Text = "";
			Listar_Cliente(0);
			Listar_Personal();
			txt_ref_cliente.Focus();
			grpPersonal.Enabled = false;
			Cursor = Cursors.Default;
		}

		private void picFiltrarpersonal_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			classFuncionesGenerales.Filtro.FiltroPersonal(ref grdDatos, txt_NombrePersonal.Text, txt_RunPersonal.Text);
			Cursor = Cursors.Default;
		}

		#endregion

		#region "grilla"

		private void grdDatos_DoubleClick(object sender, EventArgs e)
		{
			frmPersonalMant frm = new frmPersonalMant(Convert.ToInt64(txt_ref_cliente.Text), Convert.ToInt64(grdDatos.SelectedCells[0].Value.ToString()), txt_Rut.Text);
			frm.ShowDialog(this);
			Listar_Personal();
		}

		private void grdDatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			if (e.ListChangedType == ListChangedType.Reset)
			{
				foreach (DataGridViewRow item in grdDatos.Rows)
				{
					DataRow dtrFila = ((DataRowView)item.DataBoundItem).Row;
					if (Convert.ToInt32(dtrFila["Id_estado"].ToString())==0)
					{
						item.DefaultCellStyle.BackColor = Color.Red;
					}
				}

			}

		}

		#endregion

		#region Barra
		private void tsbAsignarSeccion_Click(object sender, EventArgs e)
		{
			frmAsignarSeccionPersonal frm = new frmAsignarSeccionPersonal(Convert.ToInt32(txt_ref_cliente.Text), txt_Rut.Text);
			frm.ShowDialog(this);
		}
		private void tsbAsignarSucursal_Click(object sender, EventArgs e)
		{
			frmAsignarDireccionPersonal frm = new frmAsignarDireccionPersonal(Convert.ToInt32(txt_ref_cliente.Text), txt_Rut.Text);
			frm.ShowDialog(this);
		}

		private void tsb_Eliminar_Click(object sender, EventArgs e)
		{
			string strMensaje = "";
			if (MessageBox.Show("Desea eliminar el personal?", "Eliminación del personal", MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				//for (int intFila = 0; intFila < grdDatos.SelectedRows.Count; intFila++)
				//{
					int intIdPersonal = Convert.ToUInt16(grdDatos.SelectedCells[0].Value);
					SqlCommand cmd = new SqlCommand();
					cmd.CommandText = "pa_EliminarPersonal_del " + intIdPersonal.ToString();
					cmd.CommandType = CommandType.Text;
					DataSet dt;
					dt = Conectar.Listar(Clases.clsBD.BD, cmd);
					if (dt.Tables[0].Rows.Count == 0)
					{
						MessageBox.Show("No se han cargado ningun personal");
					}
					else
					{
						if (dt.Tables[0].Rows[0][1].ToString() == "0")
							strMensaje += strMensaje == "" ? grdDatos.SelectedCells[1].Value : ", " + grdDatos.SelectedCells[1].Value;
					}
				//}

				if (strMensaje != "")
					MessageBox.Show("No se puede eliminar los siguiente rut, hay datos relacionados : \n" + strMensaje);

				btn_cargarCliente_Click(null, null);
			}
		}


		#endregion

		
	}
}
