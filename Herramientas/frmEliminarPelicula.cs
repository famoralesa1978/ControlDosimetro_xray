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
using Microsoft.Reporting.WinForms;
using System.Net.Mime;
using System.Net;
using System.Net.Mail;
using classFuncionesBD;

namespace ControlDosimetro
{
	public partial class frmEliminarPelicula : Form
	{

		#region "Definicion variable"
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();
		clsUtiles clsUtiles1 = new dllLibreriaMysql.clsUtiles();
		ClsFunciones clsFunc = new ClsFunciones();
		#endregion

		public frmEliminarPelicula()
		{
			InitializeComponent();
			AsignarEvento();
		}

		#region "Llamada de carga"      

		private void AsignarEvento()
		{
			txt_NTLD.KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
			txt_NTLD.KeyDown += new KeyEventHandler(ClaseEvento.Numero_KeyDown);
		}

		#endregion

		#region "button"


		private void Btn_Cerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void btnBuscarTLD_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(txt_NTLD.Text))
			{
				classFuncionesGenerales.mensajes.MensajeError("Debe ingrsar un número de TLD");
				return;
			}
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = String.Format("pa_ConsultaDatosTLD_sel {0}", String.IsNullOrEmpty(txt_NTLD.Text) ? "0" : txt_NTLD.Text);
			DataSet dt;

			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);
			if (dt.Tables[0].Rows.Count == 1)
			{
				lblDirección.Text = dt.Tables[0].Rows[0]["Direccion"].ToString();
				lblNCliente.Text = dt.Tables[0].Rows[0]["Id_cliente"].ToString();
				lblRut.Text = dt.Tables[0].Rows[0]["RutPersona"].ToString();
				int intPeriodo = Convert.ToInt16(dt.Tables[0].Rows[0]["id_periodo"].ToString());
				clsFunc.Cargar_Cliente(intPeriodo, Convert.ToInt64(lblNCliente.Text.ToString()), ref lbl_rut_cliente, ref lbl_nombreCliente);

				btnBuscarTLD.Enabled = false;
				txt_NTLD.Enabled = false;
				btn_Guardar.Enabled = true;
			}
			else
			if (dt.Tables[0].Rows.Count > 1)
			{
				lblDirección.Text = "";
				lblNCliente.Text = "";
				lblRut.Text = "";
				txt_NTLD.Enabled = false;
				btn_Guardar.Enabled = false;

				MessageBox.Show("Existe mas cliente con el mismo N° documento");

			}
			else
			if (dt.Tables[0].Rows.Count == 0)
			{
				lblDirección.Text = "";
				lblNCliente.Text = "";
				lblRut.Text = "";
				btn_Guardar.Enabled = false;
				txt_NTLD.Enabled = false;
				MessageBox.Show("Documento no existe");

			}
		}
		private void Btn_Guardar_Click(object sender, EventArgs e)
		{
			if (txt_NTLD.Text == "")
				MessageBox.Show("Todos los campos son obligatorios");
			else
			 if (MessageBox.Show("Esta seguro de  eliminar el TLD?", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
			{
				SqlCommand cmd = new SqlCommand();
				DataSet ds;
				string strParametro = String.Format("{0}", txt_NTLD.Text);
				cmd.CommandText = "pa_EliminarTLD_del " + strParametro;
				cmd.CommandType = CommandType.Text;


				ds = Conectar.Listar(ClaseGeneral.Conexion, cmd);
				if (Convert.ToInt16(ds.Tables[0].Rows[0][1].ToString()) == 0)
				{
					MessageBox.Show("Error en eliminar la información");
				}

				else
				{
					MessageBox.Show(ds.Tables[0].Rows[0][0].ToString());
					btn_filtro_Click(null, null);
				}
					
			}
		}

		private void btn_filtro_Click(object sender, EventArgs e)
		{
			txt_NTLD.Clear();
			lblDirección.Text = "";
			lblNCliente.Text = "";
			lblRut.Text = "";
			txt_NTLD.Enabled = true;
			btn_Guardar.Enabled = false;
		}


		#endregion

		#region "combobox"


		#endregion

		#region "grilla"

		#endregion


	}
}
