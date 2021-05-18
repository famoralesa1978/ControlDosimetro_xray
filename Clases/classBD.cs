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
        public static int strEstadoSistema;
        public static string strConexionBdCentralAdm;
        public static string strConexionDes;
        public static bool Ambiente = true;
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

                //using (SqlConnection connection = new SqlConnection(libadm.)
                //{
                //    String sql = "SELECT * FROM GES_SISTEMA WHERE PK_SISTEMA='" + ControlDosimetro.Properties.Settings.Default.Pk_Sistema + "'";
                //
                //    using (SqlCommand command = new SqlCommand(sql, connection))
                //    {
                //        connection.Open();
                //
                //        SqlDataReader reader = command.ExecuteReader();
                //
                //        while (reader.Read())
                //        {
                //            strEstadoSistema = Convert.ToInt16(reader[0]);
                //            strConexionBdCentralAdm = reader[7].ToString();
                //            strConexionDes = reader[3].ToString();
                //            strConexionBD = reader[4].ToString();
                //        }
                //
                //        // Call Close when done reading.
                //        reader.Close();
                //    }
                //}
                return _tabla;
            }
            catch (SqlException e)
            {
                return null;
            }
        }
	}

}
