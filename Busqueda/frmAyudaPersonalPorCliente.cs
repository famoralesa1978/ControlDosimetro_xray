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
	public partial class frmAyudaPersonalPorCliente : Form
	{

		#region "Definicion variable"

		Clases.ClassEvento clsEvt = new Clases.ClassEvento();
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();
		


		#endregion

		public frmAyudaPersonalPorCliente()
		{
			InitializeComponent();
			AsignarEvento();
			//Listar_Cliente();

		}
		private void frmAyudaPersonalPorCliente_Load(object sender, EventArgs e)
		{
			Listar_Personal();
		}
		#region "Llamada de carga"

		private void Listar_Cliente()
		{
			//SqlCommand cmd = new SqlCommand();
			SqlCommand cmd = new SqlCommand();
			//MessageBox.Show("Conectado al servidor");

			//if (intCliente != 0)
			//{
			//	cmd.CommandText = "select id_cliente,run,razon_social,Direccion,telefono " +
			//			"from tbl_cliente " +
			//			"where  (id_cliente=" + txt_ref_cliente.Text + ") or run ='" + txt_Rut.Text + "' " +
			//			" and id_estado=1 " +
			//			"order by id_cliente";
			//	txt_ref_cliente.Text = intCliente.ToString();
			//}
			//if (intCliente == 0)
			//	cmd.CommandText = "select id_cliente,run,razon_social,Direccion,telefono " +
			//			"from tbl_cliente " +
			//			"where run  ='" + txt_Rut.Text + "' " + " and id_estado=1 " +
			//			"order by id_cliente";
			//cmd.CommandType = CommandType.Text;

			//DataSet dt;
			//dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

			//if (dt.Tables[0].Rows.Count == 0)
			//{
			//	txt_ref_cliente.Text = "";
			//	txt_Rut.Text = "";
			//	txt_RazonSocial.Text = "";
			//	tsb_Agregar.Visible = false;
			//}
			//else
			//{
			//	txt_ref_cliente.Text = dt.Tables[0].Rows[0]["id_cliente"].ToString();
			//	txt_Rut.Text = dt.Tables[0].Rows[0]["run"].ToString();
			//	txt_RazonSocial.Text = dt.Tables[0].Rows[0]["razon_social"].ToString();
			//	txt_ref_cliente.ReadOnly = true;
			//	txt_Rut.ReadOnly = true;
			//	tsb_Agregar.Visible = true;
			//	txt_RazonSocial.ReadOnly = true;
			//	Listar_Personal();
			//}
			Listar_Personal();
			Clases.ClsPersonal.Id_Personal = 0;
			Clases.ClsPersonal.Materno = "";
			Clases.ClsPersonal.Nombres = "";
			Clases.ClsPersonal.Paterno ="";
			Clases.ClsPersonal.Rut = "";
		}

		private void Listar_Personal()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = string.Format("BusPersonalPorSeccion '{0}',{1},{2}", txt_Rut.Text, txt_ref_cliente.Text, txtSeccion.Tag);

			cmd.CommandType = CommandType.Text;
			DataSet dt;
			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);
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

			frmPersonalMant frm = new frmPersonalMant(Convert.ToInt64(txt_ref_cliente.Text), 0, txt_Rut.Text);
			frm.ShowDialog(this);
			Listar_Personal();

			Cursor = Cursors.Default;
		}

		private void btn_cargarCliente_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			Listar_Personal();

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
			//Listar_Cliente(0);
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
