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

namespace classFuncionesGenerales
{
   public class ClsValidadores
    {
        clsConectorSqlServer Conectar = new clsConectorSqlServer();
        public bool ValidadorRut(string NDoc,string NDos, ref string mensaje)
        {

            return false;
        }
    }

}
