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

            ////Creo un archivo xml para guardar el error.
            //StreamWriter serialWriter;
            //serialWriter = new StreamWriter("d:\\Error_ControlDosimetro_" + err.Fecha + ".xml");
            //XmlSerializer xmlWriter = new XmlSerializer(err.GetType());
            //xmlWriter.Serialize(serialWriter, err);
            //serialWriter.Close();

            //Creo el xml
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(err.GetType());
            x.Serialize(Console.Out, err);
        }
    }
}
