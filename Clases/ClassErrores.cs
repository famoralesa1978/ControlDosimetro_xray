using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dllConectorMysql;
using System.IO;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Reflection;

namespace Clases
{
    public class ClassErrores
    {
        readonly clsConectorSqlServer Conectar = new clsConectorSqlServer();
        ClassDirectorios Directorios = new ClassDirectorios();

        public class Err
        {
            public int Menu { get; set; }
            public string Usuario { get; set; }
            public string Mensaje { get; set; }
            public string VersionApp { get; set; }
            public string Fecha { get; set; }
        }

        public ClassErrores(Exception Error, int menu, string usuario)
        {
            var err = new Err
            {
                Menu = menu,
                Usuario = usuario,
                Mensaje = Error.Message,
                //VersionApp = versionApp,
                VersionApp = Assembly.GetExecutingAssembly().GetName().Version.ToString(),
                Fecha = DateTime.Now.ToString("yyyyMMdd_HHmmss")
            };

            ErroresCreaArchivos(err);
            ErroresGuardarEnBD(err);
        }

        /// <summary>
        /// Creo archivos txt para gudardar los errores que provoque la App.
        /// </summary>
        /// <param name="err"></param>
        private void ErroresCreaArchivos(Err err)
        {
            //Creo directorio para los errores
            var Carpeta = Directorios.CreaDirectorios(0);
            var Archivo = Carpeta + "\\" + err.Usuario + "_" + DateTime.Now.ToString("yyyyMMdd").ToString() + ".txt";
            if (!File.Exists(Archivo)) File.Create(Archivo).Close();
            File.AppendAllLines(Archivo, new String[] { err.Usuario + "; " + err.Menu.ToString() + "; " + err.VersionApp + "; " + err.Mensaje + "; " + err.Fecha });
        }

        /// <summary>
        /// Guardo los errores en la BD.
        /// </summary>
        /// <param name="err"></param>
        private void ErroresGuardarEnBD(Err err)
        {
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "PA_GES_ERRORES_INSERTAR '" + err.Usuario + "'," +
            //                                    err.Menu + ",'" +
            //                                    err.VersionApp + "','" +
            //                                    err.Mensaje + "','" +
            //                                    err.Fecha + "'";
            //cmd.CommandType = CommandType.Text;

            //Conectar.Listar(Clases.clsBD.BD, cmd);
        }
    }
}
