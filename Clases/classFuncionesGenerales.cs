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
      
                 
            public static string FormatearRut(string rut)
            {
                string rutFormateado = string.Empty;

                if (rut.Length == 0)
                {
                    rutFormateado = "";
                }
                else
                {
                    string rutTemporal;
                    string dv;
                    Int64 rutNumerico;

                    rut = rut.Replace("-", "").Replace(".", "");

                    if (rut.Length == 1)
                    {
                        rutFormateado = rut;
                    }
                    else
                    {
                        rutTemporal = rut.Substring(0, rut.Length - 1);
                        dv = rut.Substring(rut.Length - 1, 1);

                        if (!Int64.TryParse(rutTemporal, out rutNumerico))
                        {
                            rutNumerico = 0;
                        }
  
                        rutFormateado = rutNumerico.ToString();

                        if (rutFormateado.Equals("0"))
                        {
                            rutFormateado = string.Empty;
                        }
                        else
                        {
                            //si no hubo problemas con el formateo agrego el DV a la salida
                            rutFormateado += "-" + dv;

                            //y hago este replace por si el servidor tuviese configuracion anglosajona y reemplazo las comas por puntos
                            rutFormateado = rutFormateado.Replace(",", ".");
                        }
                    }
                }

                return rutFormateado;
            }
        }
    }



