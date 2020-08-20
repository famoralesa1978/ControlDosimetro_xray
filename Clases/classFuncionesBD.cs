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

namespace classFuncionesBD
{
   public class clsFunciones
    {
        clsConectorSqlServer Conectar = new clsConectorSqlServer();
        public int CambiarEstado(string NDoc,string NDos, ref string mensaje)
        {            
            SqlCommand cmd = new SqlCommand();
            DataSet ds;

            cmd.CommandText = "pa_CambiarEstado_upd " + NDoc + "," + NDos;
            cmd.CommandType = CommandType.Text;
            ds = Conectar.Listar(Clases.clsBD.BD, cmd);

            mensaje=ds.Tables[0].Rows[0][1].ToString();
            return Convert.ToInt16( ds.Tables[0].Rows[0][0].ToString());
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

	}

}
