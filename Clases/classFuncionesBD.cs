using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dllConectorMysql;
using dllLibreriaEvento;
using dllLibreriaMysql;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;

namespace classFuncionesBD
{
	public class ClsFunciones
	{
		clsConectorSqlServer Conectar = new clsConectorSqlServer();

		

		public int CambiarEstado(string NDoc, string NDos, ref string mensaje)
		{
			SqlCommand cmd = new SqlCommand();
			DataSet ds;

			cmd.CommandText = "pa_CambiarEstado_upd " + NDoc + "," + NDos;
			cmd.CommandType = CommandType.Text;
			ds = Conectar.Listar(Clases.clsBD.BD, cmd);

			mensaje = ds.Tables[0].Rows[0][1].ToString();
			return Convert.ToInt16(ds.Tables[0].Rows[0][0].ToString());
		}

		public int CambiarEstadoTLD(string NDoc, string NDos, ref string mensaje)
		{
			SqlCommand cmd = new SqlCommand();
			DataSet ds;

			cmd.CommandText = "pa_CambiarEstadoTLD_upd " + NDoc + "," + NDos;
			cmd.CommandType = CommandType.Text;
			ds = Conectar.Listar(Clases.clsBD.BD, cmd);

			mensaje = ds.Tables[0].Rows[0][1].ToString();
			return Convert.ToInt16(ds.Tables[0].Rows[0][0].ToString());
		}

		public void Cargar_Cliente(int intPeriodo,Int64 intCodCliente, ref Label Rut, ref Label RazonSocial)
		{
			DataSet ds;


			SqlCommand cmd = new SqlCommand
			{
				//	SqlCommand cmd = new SqlCommand();

				CommandText = "pa_ObtieneCliente_sel  " + intPeriodo.ToString() + "," + intCodCliente.ToString()
			};
			ds = Conectar.Listar(Clases.clsBD.BD, cmd);

			if (ds.Tables[0].Rows.Count > 0)
			{
				RazonSocial.Text= ds.Tables[0].Rows[0]["Razon_Social"].ToString();
				Rut.Text = ds.Tables[0].Rows[0]["run"].ToString();
			}
			else
			{
				RazonSocial.Text = "";
				Rut.Text = "";
				if(intCodCliente != -1)
					MessageBox.Show(ControlDosimetro.Properties.Resources.msgClientePeriodoError, ControlDosimetro.Properties.Resources.msgCaptionError,MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
			}
		}

		public void Cargar_Cliente(int intPeriodo, Int64 intCodCliente, ref Label Rut, ref Label RazonSocial, ref Label Direccion)
		{
			DataSet ds;


			SqlCommand cmd = new SqlCommand
			{
				//	SqlCommand cmd = new SqlCommand();

				CommandText = "pa_ObtieneCliente_sel  " + intPeriodo.ToString() + "," + intCodCliente.ToString()
			};
			ds = Conectar.Listar(Clases.clsBD.BD, cmd);

			if (ds.Tables[0].Rows.Count > 0)
			{
				RazonSocial.Text = ds.Tables[0].Rows[0]["Razon_Social"].ToString();
				Rut.Text = ds.Tables[0].Rows[0]["run"].ToString();
				Direccion.Text = ds.Tables[0].Rows[0]["Direccion"].ToString();
			}
			else
			{
				RazonSocial.Text = "";
				Rut.Text = "";
				Direccion.Text = "";
				if (intCodCliente != -1)
					MessageBox.Show(ControlDosimetro.Properties.Resources.msgClientePeriodoError, ControlDosimetro.Properties.Resources.msgCaptionError, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
			}
		}

	}

}
