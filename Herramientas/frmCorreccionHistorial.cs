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

namespace ControlDosimetro
{
	public partial class frmCorreccionHistorial : Form
	{

		#region "Definicion variable"
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();
		clsUtiles clsUtiles1 = new dllLibreriaMysql.clsUtiles();
		#endregion

		public frmCorreccionHistorial()
		{
			InitializeComponent();

		}

		#region "Llamada de carga"      

		private void Listar_Grilla()
		{
			SqlCommand cmd = new SqlCommand();
			DataSet dt;
			cmd.CommandText = String.Format("pa_ConsultaCorregirHistorial_sel {0}",lbl_id_cliente.Text);
			// pa_OrdenTrabajo_sel
			cmd.CommandType = CommandType.Text;

			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			grdCliente.DataSource = dt.Tables[0];
			dtgHistorial.DataSource = dt.Tables[1];
			//if(txt_CodCliente.Text!="0")
			if (dt.Tables[0].Rows.Count == 0)
			{
				MessageBox.Show("No se ha ingresado información");
			}



		}

		private void AsignarEvento()
		{
			lbl_id_cliente.KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
			lbl_id_cliente.KeyDown += new KeyEventHandler(ClaseEvento.Numero_KeyDown);
		}

		#endregion

		#region "button"

		private void Btn_filtro_Click(object sender, EventArgs e)
		{
			lbl_id_cliente.Text = "0";
			Btn_cargar_Click(sender, e);
			lbl_id_cliente.Text = "";
		}

		private void Btn_cargar_Click(object sender, EventArgs e)
		{
			if (lbl_id_cliente.Text.ToString().Trim() != "")
			{
				Listar_Grilla();
			}


		}

		private void Btn_Cerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void btnGrabarAgregarHistorial_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Esta seguro de agregar el cliente al historial?", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
			{
				SqlCommand cmd = new SqlCommand();
				DataSet ds;

				cmd.CommandText = String.Format("pa_ConsultaCorregirHistorial_ins {0}",lbl_id_cliente.Text);
				cmd.CommandType = CommandType.Text;
				ds = Conectar.Listar(Clases.clsBD.BD, cmd);


				MessageBox.Show(ds.Tables[0].Rows[0][0].ToString());

			}
		}

		#endregion

		#region "combobox"


		#endregion

		#region "grilla"

		#endregion


	}
}
