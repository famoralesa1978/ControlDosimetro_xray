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
	public partial class frmAsignarDireccionPersonal : Form
	{
		#region "Definicion variable"
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();
		Clases.ClassEvento Evento = new Clases.ClassEvento();
		classFuncionesBD.ClsFunciones ClaseFunciones = new classFuncionesBD.ClsFunciones();
		string run;
		#endregion


		public frmAsignarDireccionPersonal(Int64 intCodCliente, string srtRun)
		{
			InitializeComponent();
			run = srtRun;
			Cargar_Cliente(intCodCliente);
			Cargar_Sucursal();
		}

		#region "Llamada de carga"  

		private void Cargar_Cliente(Int64 intCodCliente)
		{
			SqlCommand cmd = new SqlCommand();
			//  SqlCommand cmd = new SqlCommand();

			cmd.CommandText = "SELECT run,Razon_Social,N_Cliente_Ref,Direccion,Id_Region,Id_Provincia,Id_Comuna,Telefono, Id_TipoFuente,Id_estado,Fechainicio " +
							" FROM tbl_cliente WHERE Id_cliente= " + intCodCliente.ToString();
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			lbl_id_cliente.Text = intCodCliente.ToString();
			lbl_nombreCliente.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
		}

		private void Cargar_Personal()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = String.Format("pa_ListarPersonalPorSucursal {0},'{1}',{2}", lbl_id_cliente.Text,run,cbxDireccion.SelectedValue);
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			((ListBox)chkLista).DataSource = dt.Tables[0];
			((ListBox)chkLista).DisplayMember = "Personal";
			((ListBox)chkLista).ValueMember = "Id_personal";

			for (int intFilaLista = 0; intFilaLista < chkLista.Items.Count; intFilaLista++)
			{
				var dr = ((DataRowView)chkLista.Items[intFilaLista]).Row;
				bool bolMarca = (bool)dr.ItemArray[3];

				chkLista.SetItemChecked(intFilaLista, bolMarca);
			}
		}

		private void Cargar_Sucursal()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "select id_sucursal, direccion + ','+co.comuna as Dato " +
					"from [dbo].[tbl_sucursal] s " +
					"inner join glo_region r on r.Id_region=s.Id_Region " +
					"inner join glo_comuna co on co.id_comuna=s.Id_Comuna " +
					"where run='" + run + "'  and id_cliente= " + lbl_id_cliente.Text + "";
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			cbxDireccion.DisplayMember = dt.Tables[0].Columns[1].Caption.ToString();
			cbxDireccion.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
			cbxDireccion.DataSource = dt.Tables[0];

		}

		void GrabarSucursal()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = String.Format("SucursalPersonalUpd {0},'{1}'", 
																			cbxDireccion.SelectedValue, xmlSucursal());
			cmd.CommandType = CommandType.Text;
			Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);
		}
		private string xmlSucursal()
		{
			StringBuilder strbSucursal = new StringBuilder();
			
			int intId;

			foreach (object itemChecked in chkLista.CheckedItems)
			{
				DataRowView ItemFila = itemChecked as DataRowView;
				intId = (int)ItemFila["Id_personal"];
				strbSucursal.AppendFormat(@"<a e=""{0}""/>",
					intId
				);
			}
			return String.IsNullOrWhiteSpace(strbSucursal.ToString())?"": strbSucursal.ToString();

		}

		#endregion

		#region "button"

		private void btn_cerrar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			//verificar_Grabado();
			this.Close();

			Cursor = Cursors.Default;
		}

		private void btnMarcarTodos_Click(object sender, EventArgs e)
		{
			for (int intFilaLista = 0; intFilaLista < chkLista.Items.Count; intFilaLista++)
			{
				var dr = ((DataRowView)chkLista.Items[intFilaLista]).Row;

				chkLista.SetItemChecked(intFilaLista, true);
			}
		}

		private void btnDesmarcar_Click(object sender, EventArgs e)
		{
			for (int intFilaLista = 0; intFilaLista < chkLista.Items.Count; intFilaLista++)
			{
				var dr = ((DataRowView)chkLista.Items[intFilaLista]).Row;
				chkLista.SetItemChecked(intFilaLista, false);
			}
		}

		private void btnInvertir_Click(object sender, EventArgs e)
		{
			for (int intFilaLista = 0; intFilaLista < chkLista.Items.Count; intFilaLista++)
			{
				chkLista.SetItemChecked(intFilaLista, !chkLista.GetItemChecked(intFilaLista));
			}
		}

		private void btn_Grabar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			GrabarSucursal();

			Cursor = Cursors.Default;

		}

		#endregion

		#region "combobox"
		private void cbxDireccion_SelectedIndexChanged(object sender, EventArgs e)
		{
			Cargar_Personal();
		}
		#endregion

		#region "Textbox"

		#endregion


	}
}
