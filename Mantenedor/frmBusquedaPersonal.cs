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
		clsEventoControl ClaseEvento = new clsEventoControl();
		#endregion

		public frmBusquedaPersonal(Int64 intId_Cliente)
		{
			InitializeComponent();
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
				tsb_Eliminar.Visible = tsb_Agregar.Visible = false;
			}
			else
			{
				txt_ref_cliente.Text = dt.Tables[0].Rows[0]["id_cliente"].ToString();
				txt_Rut.Text = dt.Tables[0].Rows[0]["run"].ToString();
				txt_RazonSocial.Text = dt.Tables[0].Rows[0]["razon_social"].ToString();
				txt_ref_cliente.ReadOnly = true;
				txt_Rut.ReadOnly = true;
				tsb_Eliminar.Visible = tsb_Agregar.Visible = true;
				txt_RazonSocial.ReadOnly = true;
				Listar_Personal();
			}
		}

		private void Listar_Personal()
		{
			SqlCommand cmd = new SqlCommand();
			if (txt_ref_cliente.Text == "")
				cmd.CommandText = "SELECT Id_Personal,Rut, Nombres,Paterno,Maternos,fecha_nac,Descripcion as id_estado,Fecha_inicio,fecha_termino  " +
																	" FROM tbl_personal P inner join glo_estado est on est.Id_estado=p.Id_estado WHERE id_cliente= 0 and" +
																	" rut_cliente='" + txt_Rut.Text + "'" +
				" order by Paterno,Maternos,Nombres";
			else
				cmd.CommandText = "SELECT Id_Personal,Rut, Nombres,Paterno,Maternos,fecha_nac,Descripcion  as id_estado,Fecha_inicio,fecha_termino  " +
																	" FROM tbl_personal P inner join glo_estado est on est.Id_estado=p.Id_estado  WHERE id_cliente= " + txt_ref_cliente.Text +
																		" and rut_cliente='" + txt_Rut.Text + "'" +
				" order by Paterno,Maternos,Nombres";
			cmd.CommandType = CommandType.Text;
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);
			grpPersonal.Enabled = true;
			grdDatos.DataSource = dt.Tables[0];
		}

		private void AsignarEvento()
		{


			this.txt_Rut.KeyPress += new KeyPressEventHandler(ClaseEvento.Rut_KeyPress);
			txt_Rut.KeyDown += new KeyEventHandler(ClaseEvento.Rut_KeyDown);
			txt_Rut.Validated += new EventHandler(ClaseEvento.validarut_Validated);

			txt_ref_cliente.KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
			txt_ref_cliente.KeyDown += new KeyEventHandler(ClaseEvento.Numero_KeyDown);

			txt_RazonSocial.KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);


		}



		#endregion

		#region "button"       

		private void btn_Agregar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			frmPersonalMant frm = new frmPersonalMant(Convert.ToInt64(txt_ref_cliente.Text), 0);
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

				tsb_Eliminar.Visible = tsb_Agregar.Visible = false;
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
			string strFiltro = "";
			DataTable dt = ((DataTable)(grdDatos.DataSource));
			//Rut, Nombres,Paterno,Maternos
			strFiltro = !String.IsNullOrEmpty(txt_RunPersonal.Text) ? "Rut like '%" + txt_RunPersonal.Text + "%'" : "";
			strFiltro = strFiltro + (!String.IsNullOrEmpty(txt_NombrePersonal.Text) ? "(Nombres + Paterno+Maternos) like '%" + txt_NombrePersonal.Text + "%'" : "");
			dt.DefaultView.RowFilter = strFiltro;
		}

		#endregion

		#region "grilla"

		private void grdDatos_DoubleClick(object sender, EventArgs e)
		{
			frmPersonalMant frm = new frmPersonalMant(Convert.ToInt64(txt_ref_cliente.Text), Convert.ToInt64(grdDatos.SelectedCells[0].Value.ToString()));
			frm.ShowDialog(this);
			Listar_Personal();
		}


		#endregion

		#region Barra

		private void tsb_Eliminar_Click(object sender, EventArgs e)
		{
			string strMensaje = "";
			if (MessageBox.Show("Desea eliminar el personal?", "Eliminación del personal", MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				for (int intFila = 0; intFila < grdDatos.SelectedRows.Count; intFila++)
				{
					int intIdPersonal = Convert.ToUInt16(grdDatos.Rows[intFila].Cells[0].Value);
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
							strMensaje += strMensaje == "" ? grdDatos.Rows[intFila].Cells[1].Value : ", " + grdDatos.Rows[intFila].Cells[1].Value;
					}
				}

				if (strMensaje != "")
					MessageBox.Show("No se puede eliminar los siguiente rut, hay datos relacionados : \n" + strMensaje);

				btn_cargarCliente_Click(null, null);
			}
		}

		#endregion

		private void txt_Rut_TextChanged(object sender, EventArgs e)
		{

		}

	}
}
