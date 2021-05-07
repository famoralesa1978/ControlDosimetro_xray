using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class clsUsuario//prueba
    {
        private static string strusuario;
        private static string strNombre;
        private static int intId_Usuario;
        private static int intId_perfil;
        private static string strContraseña;
        public static int Id_Usuario
        {
            get
            {
                return intId_Usuario;
            }
            set
            {
                intId_Usuario = value;  // value is an implicit parameter
            }

        }

        public  static  string Usuario
            {
                get
                {
                    return strusuario;
                }
                set
                {
                    strusuario = value;  // value is an implicit parameter
                }

            }

        public static string Nombre
            {
                get
                {
                    return strNombre;
                }
                set
                {
                    strNombre = value;  // value is an implicit parameter
                }

            }

        public static int Id_perfil { get => intId_perfil; set => intId_perfil = value; }
        public static string Contraseña { get => strContraseña; set => strContraseña = value; }
    }

	class clsSistema//prueba
	{
		private static string strSistema;
		private static string strBD;


		public static string Sistema
		{
			get
			{
				return strSistema;
			}
			set
			{
				strSistema = value;  // value is an implicit parameter
			}

		}

		public static string BD
		{
			get
			{
				return strBD;
			}
			set
			{
				strBD = value;  // value is an implicit parameter
			}

		}

	}

}
