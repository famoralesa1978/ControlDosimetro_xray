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
            public int? Menu { get; set; }
            public string Formulario { get; set; }
            public string Usuario { get; set; }
            public string Mensaje { get; set; }
            public int? N_Error { get; set; }
            public string VersionApp { get; set; }
            public string Pk_Sistema { get; set; }
        }

        /// <summary>
        /// Gestión para errores de sistema.
        /// </summary>
        /// <param name="Error"></param>
        /// <param name="menu"></param>
        /// <param name="formulario"></param>
        /// <param name="versionapp"></param>
        /// <param name="usuario"></param>
        /// <param name="sistema"></param>
        public ClassErrores(Exception Error, int menu, int n_error, string formulario, string versionapp, string usuario, string sistema)
        {
            var err = new Err
            {
                Menu = menu,
                Formulario = formulario,
                Usuario = usuario,
                Mensaje = Error.Message,
                N_Error = n_error,
                VersionApp = versionapp,
                Pk_Sistema = sistema
            };

            ////ErroresCreaArchivos(err);
            ////ErroresGuardarEnBD(err);
            //GuardarErrores();
        }

        private void GuardarErrores(Exception Error, int menu, int n_error, string formulario, string versionapp, string usuario, string sistema)
        {
            //new Libreria.ClsErrores(Error,menu ,n_errorm);
        }

        ///// <summary>
        ///// Creo archivos txt para gudardar los errores que provoque la App.
        ///// </summary>
        ///// <param name="err"></param>
        //private void ErroresCreaArchivos(Err err)
        //{
        //    //Creo directorio para los errores
        //    var Carpeta = Directorios.CreaDirectorios(0);
        //    var Archivo = Carpeta + "\\" + err.Usuario + "_" + DateTime.Now.ToString("yyyyMMdd").ToString() + ".txt";
        //    if (!File.Exists(Archivo)) File.Create(Archivo).Close();
        //    File.AppendAllLines(Archivo, new String[] { err.Usuario + "; " + err.Menu.ToString() + "; " + err.VersionApp + "; " + err.Mensaje + "; " + err.Fecha });
        //}

        ///// <summary>
        ///// Guardo los errores en la BD.
        ///// </summary>
        ///// <param name="err"></param>
        //private void ErroresGuardarEnBD(Err err)
        //{
        //    //SqlCommand cmd = new SqlCommand();
        //    //cmd.CommandText = "PA_GES_ERRORES_INSERTAR '" + err.Usuario + "'," +
        //    //                                    err.Menu + ",'" +
        //    //                                    err.VersionApp + "','" +
        //    //                                    err.Mensaje + "','" +
        //    //                                    err.Fecha + "'";
        //    //cmd.CommandType = CommandType.Text;

        //    //Conectar.Listar(Clases.clsBD.BD, cmd);
        //}
    }
}
