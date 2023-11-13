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



namespace ControlDosimetro
{
	public partial class frmimprimeDocFilmico : Form
	{
		#region "Definicion variable"
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		Clases.ClassEvento clsEvento = new Clases.ClassEvento();
		//   int intContar = 0;
		//  int tmpintId_Cliente;

		#endregion

		public frmimprimeDocFilmico()
		{
			InitializeComponent();
			clsEvento.AsignarNumero(ref lbl_NDocumento);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(lbl_NDocumento.Text))
			{
				classFuncionesGenerales.mensajes.MensajeError("Falta el número de documento.");
				return;
			}

			DataSet dt;
			dt = RptInforme();
			frmreporte frm = new frmreporte(dt, dt, 11);
			frm.Show(this);
		}

		private void Btn_cerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		public DataSet RptInforme()
		{
			DataSet ds = new DataSet();
			SqlCommand cmd = new SqlCommand();
			// SqlCommand cmd = new SqlCommand();
			//MessageBox.Show("Conectado al servidor");

			cmd.CommandText = "rptDctoFilmico";
			cmd.Parameters.Add("@id_cliente", SqlDbType.Int);
			cmd.Parameters["@id_cliente"].Value = null;
			cmd.Parameters.Add("@Rut", SqlDbType.VarChar, 20);
			cmd.Parameters["@Rut"].Value = null;
			cmd.Parameters.Add("@NDocumento", SqlDbType.BigInt);
			cmd.Parameters["@NDocumento"].Value = lbl_NDocumento.Text;
			cmd.CommandType = CommandType.StoredProcedure;

			ds = Conectar.Listar(Clases.clsBD.BD, cmd);

			return ds;
		}
	}
}
