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
	public partial class frmAyudaCliente : Form
	{

		#region "Definicion variable"

		Clases.ClassEvento clsEvt = new Clases.ClassEvento();
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();

		Int64 IdCliente;

		#endregion

		public frmAyudaCliente(Int64 intId_Cliente)
		{
			InitializeComponent();
			AsignarEvento();
			grdDatos.AutoGenerateColumns = false;
			IdCliente = intId_Cliente;

		}

		private void frmAyudaCliente_Load(object sender, EventArgs e)
		{
			Listar_Cliente(IdCliente);
		}

		#region "Llamada de carga"

		private void Listar_Cliente(Int64 intCliente)
		{
			SqlCommand cmd = new SqlCommand();
			////MessageBox.Show("Conectado al servidor");

			cmd.CommandText = String.Format("pa_AyudaCliente_sel {0}", intCliente);
			txt_IdCliente.Text = intCliente.ToString();
			cmd.CommandType = CommandType.Text;

			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			if (dt.Tables[0].Rows.Count > 0)
			{
				if (dt.Tables[0].Rows.Count == 1)
				{
					Clases.ClsCliente.Rut = dt.Tables[0].Rows[0]["run"].ToString();
					Clases.ClsCliente.Direccion = dt.Tables[0].Rows[0]["Direccion"].ToString();
					Clases.ClsCliente.Nombres = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
					Clases.ClsCliente.Id_Cliente = Convert.ToInt16(dt.Tables[0].Rows[0]["Id_cliente"].ToString());

					DialogResult = System.Windows.Forms.DialogResult.OK;
				}
				else
				if (dt.Tables[0].Rows.Count > 1)
				{
					grdDatos.DataSource = dt.Tables[0];

				}
			}
			else
			{
				if (intCliente > 0)
				{
					classFuncionesGenerales.mensajes.MensajeError("El número de cliente no existe");
					DialogResult = System.Windows.Forms.DialogResult.Cancel;
				}
				else
					DialogResult = System.Windows.Forms.DialogResult.OK;

			}
		}

		private void Listar_Personal()
		{
			//SqlCommand cmd = new SqlCommand();
			//if (txt_ref_cliente.Text == "")
			//	cmd.CommandText = "SELECT Id_Personal,Rut, Nombres,Paterno,Maternos,fecha_nac,Descripcion as id_estado,Fecha_inicio,fecha_termino  " +
			//									  " FROM tbl_personal P inner join glo_estado est on est.Id_estado=p.Id_estado WHERE id_cliente= 0 and" +
			//									  " rut_cliente='" + txt_Rut.Text + "'" +
			//			 " order by Nombres,Paterno,Maternos";
			//else
			//	cmd.CommandText = "SELECT Id_Personal,Rut, Nombres,Paterno,Maternos,fecha_nac,Descripcion  as id_estado,Fecha_inicio,fecha_termino  " +
			//									  " FROM tbl_personal P inner join glo_estado est on est.Id_estado=p.Id_estado  WHERE id_cliente= " + txt_ref_cliente.Text +
			//										 " and rut_cliente='" + txt_Rut.Text + "'" +
			//			 " order by Nombres,Paterno,Maternos";
			//cmd.CommandType = CommandType.Text;
			//DataSet dt;
			//dt = Conectar.Listar(Clases.clsBD.BD, cmd);
			//grdDatos.DataSource = dt.Tables[0];

			//if (dt.Tables[0].Rows.Count == 0)
			//{
			//	MessageBox.Show("No se han cargado ningun personal");
			//}
		}

		private void AsignarEvento()
		{
			clsEvt.AsignarNumero(ref txt_IdCliente);
		}



		#endregion

		#region "button"       

		private void btn_cargarCliente_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			//if (txt_ref_cliente.Text == "")
			//	Listar_Cliente(0);
			//else
			//	Listar_Cliente(Convert.ToInt64(txt_ref_cliente.Text.ToString()));

			//if (txt_RazonSocial.Text == "")
			//{
			//	MessageBox.Show("El cliente puede estar inactivo o no existe"); //este mensaje aparece con campos vacios
			//	tsb_Agregar.Visible = false;
			//}

			Cursor = Cursors.Default;

		}

		private void btn_Filtro_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			//txt_ref_cliente.ReadOnly = false;
			//txt_Rut.ReadOnly = false;
			//txt_ref_cliente.Text = "";
			//txt_Rut.Text = "";
			//txt_RazonSocial.Text = "";
			//Listar_Cliente(0);
			//Listar_Personal();
			//txt_ref_cliente.Focus();

			Cursor = Cursors.Default;
		}

		#endregion

		#region "grilla"

		private void grdDatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			if (e.ListChangedType == ListChangedType.Reset)
			{
				foreach (DataGridViewRow item in grdDatos.Rows)
				{
					DataRow dtrFila = ((DataRowView)item.DataBoundItem).Row;
					if (Convert.ToInt32(dtrFila["Id_estado"].ToString()) == 0)
					{
						item.DefaultCellStyle.BackColor = Color.Red;
					}
				}

			}
		}

		private void grdDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				Clases.ClsCliente.Rut = grdDatos.Rows[e.RowIndex].Cells[0].Value.ToString();
				Clases.ClsCliente.Direccion = grdDatos.Rows[e.RowIndex].Cells[2].Value.ToString();
				Clases.ClsCliente.Nombres = grdDatos.Rows[e.RowIndex].Cells[1].Value.ToString();
				Clases.ClsCliente.Id_Cliente = Convert.ToInt16(txt_IdCliente.Text);

				DialogResult = System.Windows.Forms.DialogResult.OK;
			}
		}



		#endregion

		#region Barra

		#endregion

	
	}
}
