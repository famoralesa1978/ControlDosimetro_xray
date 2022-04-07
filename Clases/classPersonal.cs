using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
	class ClsPersonal//prueba
	{
		private static string strRut;
		private static string strNombres;
		private static int intId_Personal;
		private static string strPaterno;
		private static string strMaterno;

		public static int Id_Personal
		{
			get
			{
				return intId_Personal;
			}
			set
			{
				intId_Personal = value;  // value is an implicit parameter
			}

		}

		public static string Rut
		{
			get
			{
				return strRut;
			}
			set
			{
				strRut = value;  // value is an implicit parameter
			}

		}

		public static string Nombres
		{
			get
			{
				return strNombres;
			}
			set
			{
				strNombres = value;  // value is an implicit parameter
			}

		}

		public static string Paterno
		{
			get
			{
				return strPaterno;
			}
			set
			{
				strPaterno = value;  // value is an implicit parameter
			}

		}

		public static string Materno
		{
			get
			{
				return strMaterno;
			}
			set
			{
				strMaterno = value;  // value is an implicit parameter
			}

		}

	}

	class ClsCliente
	{
		private static string strRut;
		private static string strNombres;
		private static string strDireccion;
		private static int intId_Cliente;

		public static string Rut { get => strRut; set => strRut = value; }
		public static string Nombres { get => strNombres; set => strNombres = value; }
		public static int Id_Cliente { get => intId_Cliente; set => intId_Cliente = value; }
		public static string Direccion { get => strDireccion; set => strDireccion = value; }
	}
}
