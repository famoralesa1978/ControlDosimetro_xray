using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
	class clsBD
	{
		public static string strBD;
		public static string strConexionBD;
		public static string BD { get => strBD; set => strBD = value; }

		public static string ConexionBD
		{
			get
			{
				return strConexionBD;
			}
			set
			{
				strConexionBD = value;  // value is an implicit parameter
			}

		}
	}

}
