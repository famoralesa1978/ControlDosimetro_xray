using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clases
{
    public class ClassDirectorios
    {
        string DirectorioRaiz = "D:\\ControlDosimetro";
        string DirectorioCreado = "";
        public enum Directorios
        {
            Errores,
            Reportes
        }

        public string CreaDirectorios(int CodigoDirectorio)
        {
            Directory.CreateDirectory(DirectorioRaiz);
            switch (CodigoDirectorio)
            {
                case 0:
                    //Crea directorio Errores
                    DirectorioCreado = DirectorioRaiz + "\\" + Directorios.Errores;
                    Directory.CreateDirectory(DirectorioCreado);
                    break;
                case 1:
                    //Crea directorio Reportes
                    DirectorioCreado = DirectorioRaiz + "\\" + Directorios.Reportes;
                    Directory.CreateDirectory(DirectorioCreado);
                    break;
                default:
                    //Crea directorio Errores
                    break;
            }
            return DirectorioCreado;
        }
    }
}
