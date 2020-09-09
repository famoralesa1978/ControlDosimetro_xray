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

		public void Cargar_Cliente(Int64 intCodCliente, ref Label Rut, ref Label RazonSocial)
		{
			DataSet ds;


			SqlCommand cmd = new SqlCommand
			{
				//	SqlCommand cmd = new SqlCommand();

				CommandText = "SELECT run,Razon_Social,N_Cliente_Ref,Direccion,Id_Region,Id_Provincia,Id_Comuna,Telefono, Id_TipoFuente,Id_estado,Fechainicio " +
								 " FROM tbl_cliente WHERE Id_cliente= " + intCodCliente.ToString()
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
			}
		}


	}

}
