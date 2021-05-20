using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Clases
{

	class clsBD
    {
        public static string strBD;
		public static string strConexionBD;
        public static string strConexionDes;
        public static string strConexionProd;
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

        public static System.Data.DataSet ObtieneDatosSistema()
        {
            try
            {
                LibAdmSistema.ClsConector libadm = new LibAdmSistema.ClsConector();
                System.Data.DataSet _tabla = new System.Data.DataSet();
                SqlCommand command = new SqlCommand("PA_CARGA_DATOS_SISTEMA " + ControlDosimetro.Properties.Settings.Default.Pk_Sistema, null);

                _tabla = libadm.Listar("", command);
                BD = _tabla.Tables[0].Rows[0]["SIS_CON_DES"].ToString();
                strConexionDes = _tabla.Tables[0].Rows[0]["SIS_CON_DES"].ToString();
                strConexionProd = _tabla.Tables[0].Rows[0]["SIS_CON_PROD"].ToString();

                return _tabla;
            }
            catch (SqlException e)
            {
                return null;
            }
        }
	}

}
