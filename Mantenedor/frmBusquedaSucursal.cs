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
	public partial class frmBusquedaSucursal : Form
	{

		#region "Definicion variable"
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();
		int tmpintId_Cliente;
		#endregion

		public frmBusquedaSucursal(int intId_Cliente)
		{
			InitializeComponent();
			AsignarEvento();
			Listar_Cliente(intId_Cliente);
			tmpintId_Cliente = intId_Cliente;
			grdDatos.AutoGenerateColumns = false;

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
				btn_Agregar.Visible = false;
			}
			else
			{
				txt_ref_cliente.Text = dt.Tables[0].Rows[0]["id_cliente"].ToString();
				txt_Rut.Text = dt.Tables[0].Rows[0]["run"].ToString();
				txt_RazonSocial.Text = dt.Tables[0].Rows[0]["razon_social"].ToString();
				txt_ref_cliente.ReadOnly = true;
				txt_Rut.ReadOnly = true;
				btn_Agregar.Visible = true;
				txt_RazonSocial.ReadOnly = true;
				Listar_grilla();
			}
		}

		private void Listar_grilla()
		{
			SqlCommand cmd = new SqlCommand();

			//  SqlCommand cmd = new SqlCommand();
			//MessageBox.Show("Conectado al servidor");

			if (txt_ref_cliente.Text == "")
				cmd.CommandText = "SELECT s.id_sucursal,s.direccion,r.region,p.provincia,co.comuna,s.telefono,est.Descripcion as Estado,s.Id_Estado " +
													"FROM  [dbo].[tbl_cliente] c inner join tbl_sucursal s on s.id_cliente=c.id_cliente " +
													"inner join glo_region r on r.Id_region=s.id_region " +
													"inner join glo_provincia p on p.id_provincia=s.id_provincia " +
													"inner join glo_comuna co on co.id_comuna=s.id_comuna " +
													" inner join glo_estado est on est.Id_Estado=s.Id_Estado " +
													" WHERE c.run ='" + txt_Rut.Text + "'" +
				" order by direccion";
			else
				cmd.CommandText = "SELECT s.id_sucursal,s.direccion,r.region,p.provincia,co.comuna,s.telefono,est.Descripcion as Estado,s.Id_Estado " +
													"FROM  [dbo].[tbl_cliente] c inner join tbl_sucursal s on s.id_cliente=c.id_cliente and s.run=c.run " +
													"inner join glo_region r on r.Id_region=s.id_region " +
													"inner join glo_provincia p on p.id_provincia=s.id_provincia " +
													"inner join glo_comuna co on co.id_comuna=s.id_comuna " +
													" inner join glo_estado est on est.Id_Estado=s.Id_Estado " +
						" WHERE c.id_cliente= " + txt_ref_cliente.Text +
												" order by direccion";
			cmd.CommandType = CommandType.Text;

			//			  SELECT 
			//`Id_Personal`, `Rut`, `Nombres`, `Paterno`, `Maternos`, `Id_Seccion`, `Id_estado`
			//FROM `tbl_personal` inner join tbl_clipers
			//on tbl_clipers.Id_personal =tbl_personal.Id_Personal 

			//WHERE tbl_clipers.Id_Cliente=1 and id_estado=1
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);
			grdDatos.DataSource = dt.Tables[0];

			if (dt.Tables[0].Rows.Count == 0)
			{
				MessageBox.Show("No se han cargado ninguna sucursal");
			}
			//else
			//{
			//    MessageBox.Show("Se encontraron sucursal asociado al cliente");				
			//}
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

			frmSucursalMant frm = new frmSucursalMant(0, Convert.ToInt64(txt_ref_cliente.Text));
			frm.ShowDialog(this);
			Listar_grilla();

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
				MessageBox.Show("El cliente puede estar inactivo o no existe");
				btn_Agregar.Visible = false;
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
			Listar_grilla();
			txt_ref_cliente.Focus();

			Cursor = Cursors.Default;
		}



		#endregion

		#region "grilla"

		private void grdDatos_DoubleClick(object sender, EventArgs e)
		{
			frmSucursalMant frm = new frmSucursalMant(Convert.ToInt64(grdDatos.SelectedCells[0].Value.ToString()), Convert.ToInt64(txt_ref_cliente.Text));
			frm.ShowDialog(this);
			Listar_grilla();
		}
		private void grdDatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			if (e.ListChangedType == ListChangedType.Reset)
			{
				foreach (DataGridViewRow item in grdDatos.Rows)
				{

					DataRow dtrFila = ((DataRowView)item.DataBoundItem).Row;
					if (Convert.ToInt32(dtrFila["Id_estado"].ToString()) != 1)
					{
						item.DefaultCellStyle.BackColor = Color.Red;
					}
				}

			}
		}



		#endregion

	}
}
