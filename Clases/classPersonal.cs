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

}
