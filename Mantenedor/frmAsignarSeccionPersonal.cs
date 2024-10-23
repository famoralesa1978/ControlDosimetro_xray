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
	public partial class frmAsignarSeccionPersonal : Form
	{
		#region "Definicion variable"
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();
		Clases.ClassEvento Evento = new Clases.ClassEvento();
		classFuncionesBD.ClsFunciones ClaseFunciones = new classFuncionesBD.ClsFunciones();
		string run;
		#endregion


		public frmAsignarSeccionPersonal(Int64 intCodCliente, string srtRun)
		{
			InitializeComponent();
			lblCantidad.Text = "";
			run = srtRun;
			Cargar_Cliente(intCodCliente);
			Cargar_seccion();
		}

		#region "Llamada de carga"  

		private void Cargar_Cliente(Int64 intCodCliente)
		{
			SqlCommand cmd = new SqlCommand();
			//  SqlCommand cmd = new SqlCommand();

			cmd.CommandText = "SELECT run,Razon_Social,N_Cliente_Ref,Direccion,Id_Region,Id_Provincia,Id_Comuna,Telefono, Id_TipoFuente,Id_estado,Fechainicio " +
							" FROM tbl_cliente WHERE Id_cliente= " + intCodCliente.ToString();
			DataSet dt;
			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

			lbl_id_cliente.Text = intCodCliente.ToString();
			lbl_nombreCliente.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
		}

		private void Cargar_Personal()
		{
			int intMarcado = 0;
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = String.Format("pa_ListarPersonalPorSeccion {0},'{1}',{2}", lbl_id_cliente.Text,run,cbxSeccion.SelectedValue);
			DataSet dt;
			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

			((ListBox)chkLista).DataSource = dt.Tables[0];
			((ListBox)chkLista).DisplayMember = "Personal";
			((ListBox)chkLista).ValueMember = "Id_personal";

			for (int intFilaLista = 0; intFilaLista < chkLista.Items.Count; intFilaLista++)
			{
				var dr = ((DataRowView)chkLista.Items[intFilaLista]).Row;
				bool bolMarca = (bool)dr.ItemArray[3];
				intMarcado += bolMarca ? 1 : 0;
				chkLista.SetItemChecked(intFilaLista, bolMarca);
			}
			lblCantidad.Text = string.Format("Cantidad Marcado: {0}", intMarcado);
		}

		private void Cargar_seccion()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = String.Format("select id_seccion,Seccion from tbl_seccion where id_Cliente={0}  and Run='{1}'", lbl_id_cliente.Text, run);
			DataSet dt;
			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

			cbxSeccion.DisplayMember = dt.Tables[0].Columns[1].Caption.ToString();
			cbxSeccion.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
			cbxSeccion.DataSource = dt.Tables[0];

		}

		void GrabarSucursal()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = String.Format("SeccionPersonalUpd {0},'{1}'", 
																			cbxSeccion.SelectedValue, xmlSucursal());
			cmd.CommandType = CommandType.Text;
			Conectar.AgregarModificarEliminar(ClaseGeneral.Conexion, cmd);
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
		private int ContarMarcado()
		{
			StringBuilder strbSucursal = new StringBuilder();

			int intCantidad=0;

			foreach (object itemChecked in chkLista.CheckedItems)
			{
				intCantidad += 1;
			}
			return intCantidad;
		}

		#endregion

		#region "button"

		private void btn_Agregar_Click(object sender, EventArgs e)
		{
			frmSeccionMant frm = new frmSeccionMant(Convert.ToInt64(lbl_id_cliente.Text), 0, run);
			frm.ShowDialog(this);
			Cargar_seccion();
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

		private void btn_cerrar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			//verificar_Grabado();
			this.Close();

			Cursor = Cursors.Default;
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
		private void chkLista_SelectedValueChanged(object sender, EventArgs e)
		{
			lblCantidad.Text = string.Format("Cantidad Marcado: {0}", ContarMarcado());
		}

		#endregion

		#region "Textbox"

		#endregion


	}
}
