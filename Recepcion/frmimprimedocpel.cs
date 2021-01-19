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
	public partial class frmimprimedocpel : Form
	{
		#region "Definicion variable"
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		Clases.ClassEvento clsEvento = new Clases.ClassEvento();
		//   int intContar = 0;
		//  int tmpintId_Cliente;

		#endregion

		public frmimprimedocpel()
		{
			InitializeComponent();
			clsEvento.AsignarNumero(ref lbl_NDocumento);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (lbl_NDocumento.Text != "")
			{
				DataSet ds = new DataSet();
				DataSet ds2 = new DataSet();

				DataSet ds3 = new DataSet();
				SqlCommand cmd = new SqlCommand();

				SqlCommand cmddet = new SqlCommand();

				cmddet.CommandText = "select distinct Id_cliente,id_periodo 	from ges_dosimetro_estado 	where N_Documento=" + lbl_NDocumento.Text; ;
				cmddet.CommandType = CommandType.Text;

				ds3 = Conectar.Listar(Clases.clsBD.BD, cmddet);

				cmd.CommandText = "rtpDosimetriaPersonal_Enc " + ds3.Tables[0].Rows[0][0].ToString() + "," + ds3.Tables[0].Rows[0][1].ToString() + "," + lbl_NDocumento.Text;
				cmd.CommandType = CommandType.Text;

				ds = Conectar.Listar(Clases.clsBD.BD, cmd);

				cmd.CommandText = "rtpDosimetriaPersonal_det " + ds3.Tables[0].Rows[0][0].ToString() + "," + ds3.Tables[0].Rows[0][1].ToString() + "," + lbl_NDocumento.Text;
				cmd.CommandType = CommandType.Text;

				ds2 = Conectar.Listar(Clases.clsBD.BD, cmd);
				//pnl_sobre.Visible = true;
				frmreporte frm = new frmreporte(ds, ds2, 1);
				frm.Show(this);
			}
		}

		private void Btn_cerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
