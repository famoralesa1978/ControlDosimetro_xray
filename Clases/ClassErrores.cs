using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dllConectorMysql;
using System.Xml.Serialization;
using System.IO;

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
            public string Fecha { get; set; }
        }

        public ClassErrores(Exception Error, int menu, string usuario)
        {
            var err = new Err
            {
                Menu = menu,
                Usuario = usuario,
                Mensaje = Error.Message,
                Fecha = DateTime.Now.ToString("yyyyMMdd_HHmmss")
            };

            ErroresCreaArchivos(err);
            ErroresGuardarEnBD(err);
        }

        /// <summary>
        /// Creo archivos xml para gudardar los errores que provoque la App.
        /// </summary>
        /// <param name="err"></param>
        private void ErroresCreaArchivos(Err err)
        {
            //Creo directorio para los errores
            var Carpeta = Directorios.CreaDirectorios(0);

            //Creo un archivo xml para guardar el error.
            StreamWriter serialWriter;
            serialWriter = new StreamWriter(Carpeta + "\\" +err.Usuario + "_" + err.Fecha + ".xml");
            XmlSerializer xmlWriter = new XmlSerializer(err.GetType());
            xmlWriter.Serialize(serialWriter, err);
            serialWriter.Close();
        }

        /// <summary>
        /// Guardo los errores en la BD.
        /// </summary>
        /// <param name="err"></param>
        private void ErroresGuardarEnBD(Err err)
        {
        }
    }
}
