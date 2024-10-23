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
	public partial class frmBusquedaReferencia : Form
	{

		#region "Definicion variable"
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		String strRun;
		#endregion

		public frmBusquedaReferencia(Int64 intCodigo, String Run)
		{
			InitializeComponent();
			lbl_Codigo.Text = intCodigo.ToString();
			Cargar_Estado();
			strRun = Run;
			Cargar_Cliente();
			// Listar_Referencia();
		}

		#region "Llamada de carga"

		private void Listar_Referencia()
		{
			//SqlCommand cmd = new SqlCommand();
			SqlCommand cmd = new SqlCommand();
			//MessageBox.Show("Conectado al servidor");


			cmd.CommandText = "select id_referencia,encargado,fono,email " +
									"from tbl_encargado " +
									"where id_estado = " + cbx_EstadoId.SelectedValue + " and id_cliente= " + lbl_Codigo.Text + " and (run ='" + strRun + "' or run is null)" + 
									"order by id_cliente";
			cmd.CommandType = CommandType.Text;


			DataSet dt;
			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

			grdDatos.DataSource = dt.Tables[0];
		}

		private void Cargar_Estado()
		{
			ClaseComun.Listar_Estado(ClaseGeneral.Conexion, ref cbx_EstadoId, ref cbx_EstadoId);
		}

		private void Cargar_Cliente()
		{
			SqlCommand cmd = new SqlCommand();

			//            SqlCommand cmd = new SqlCommand();

			cmd.CommandText = "SELECT run,Razon_Social,Direccion,Id_Region,Id_Provincia,Id_Comuna,Telefono, Id_TipoFuente " +
									" FROM tbl_cliente WHERE Id_cliente= " + lbl_Codigo.Text.ToString() + " and run='" + strRun +"'";
			DataSet dt;
			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

			lbl_nombre.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
		}

		#endregion

		#region "button"
		private void btn_Buscar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			Listar_Referencia();
			MessageBox.Show("Busqueda Realizada");

			Cursor = Cursors.Default;
		}


		private void btn_Agregar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			frmReferenciaMant frm = new frmReferenciaMant(0, lbl_Codigo.Text,strRun);
			frm.ShowDialog(this);
			Listar_Referencia();

			Cursor = Cursors.Default;

		}

		#endregion

		#region "grilla"

		private void grdDatos_DoubleClick(object sender, EventArgs e)
		{
			frmReferenciaMant frm = new frmReferenciaMant(Convert.ToInt64(grdDatos.SelectedCells[0].Value.ToString()), lbl_Codigo.Text,strRun);
			frm.ShowDialog(this);
			Listar_Referencia();
		}
		#endregion

		#region" Combobox"

		private void cbx_EstadoId_SelectedIndexChanged(object sender, EventArgs e)
		{
			Listar_Referencia();
		}

		#endregion



	}
}
