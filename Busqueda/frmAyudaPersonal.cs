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
	public partial class frmAyudaPersonal : Form
	{

		#region "Definicion variable"

		Clases.ClassEvento clsEvt = new Clases.ClassEvento();
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();
		


		#endregion

		public frmAyudaPersonal(Int64 intId_Cliente)
		{
			InitializeComponent();
			AsignarEvento();
			txt_ref_cliente.Text = intId_Cliente.ToString();
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
				tsb_Agregar.Visible = false;
			}
			else
			{
				txt_ref_cliente.Text = dt.Tables[0].Rows[0]["id_cliente"].ToString();
				txt_Rut.Text = dt.Tables[0].Rows[0]["run"].ToString();
				txt_RazonSocial.Text = dt.Tables[0].Rows[0]["razon_social"].ToString();
				txt_ref_cliente.ReadOnly = true;
				txt_Rut.ReadOnly = true;
				tsb_Agregar.Visible = true;
				txt_RazonSocial.ReadOnly = true;
				Listar_Personal();
			}

			Clases.ClsPersonal.Id_Personal = 0;
			Clases.ClsPersonal.Materno = "";
			Clases.ClsPersonal.Nombres = "";
			Clases.ClsPersonal.Paterno ="";
			Clases.ClsPersonal.Rut = "";
		}

		private void Listar_Personal()
		{
			SqlCommand cmd = new SqlCommand();
			if (txt_ref_cliente.Text == "")
				cmd.CommandText = "SELECT Id_Personal,Rut, Nombres,Paterno,Maternos,fecha_nac,Descripcion as id_estado,Fecha_inicio,fecha_termino  " +
												  " FROM tbl_personal P inner join glo_estado est on est.Id_estado=p.Id_estado WHERE id_cliente= 0 and" +
												  " rut_cliente='" + txt_Rut.Text + "'" +
						 " order by Nombres,Paterno,Maternos";
			else
				cmd.CommandText = "SELECT Id_Personal,Rut, Nombres,Paterno,Maternos,fecha_nac,Descripcion  as id_estado,Fecha_inicio,fecha_termino  " +
												  " FROM tbl_personal P inner join glo_estado est on est.Id_estado=p.Id_estado  WHERE id_cliente= " + txt_ref_cliente.Text +
													 " and rut_cliente='" + txt_Rut.Text + "'" +
						 " order by Nombres,Paterno,Maternos";
			cmd.CommandType = CommandType.Text;
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);
			grdDatos.DataSource = dt.Tables[0];

			if (dt.Tables[0].Rows.Count == 0)
			{
				MessageBox.Show("No se han cargado ningun personal");
			}
		}

		private void AsignarEvento()
		{
			clsEvt.AsignarNumero(ref txt_ref_cliente);
			clsEvt.AsignarRut(ref txt_Rut);
			clsEvt.AsignarKeyPress(ref txt_RazonSocial);
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
				MessageBox.Show("El cliente puede estar inactivo o no existe"); //este mensaje aparece con campos vacios
				tsb_Agregar.Visible = false;
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

			Cursor = Cursors.Default;
		}

		#endregion

		#region "grilla"

		private void grdDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				Clases.ClsPersonal.Id_Personal = (int)grdDatos.Rows[e.RowIndex].Cells[0].Value;
				Clases.ClsPersonal.Materno = grdDatos.Rows[e.RowIndex].Cells[4].Value.ToString();
				Clases.ClsPersonal.Nombres = grdDatos.Rows[e.RowIndex].Cells[2].Value.ToString();
				Clases.ClsPersonal.Paterno = grdDatos.Rows[e.RowIndex].Cells[3].Value.ToString();
				Clases.ClsPersonal.Rut = grdDatos.Rows[e.RowIndex].Cells[1].Value.ToString();

				DialogResult = System.Windows.Forms.DialogResult.OK;
			}
		}


		#endregion

		#region Barra

		#endregion
	}
}
