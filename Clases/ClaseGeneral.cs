using System;
using System.Data.SqlClient;
using System.Data;
using ControlDosimetro.Properties;
using System.Reflection;

namespace ControlDosimetro
{
	public static class ClaseGeneral
	{
		#region Declaraciones
		private static clsConectorSqlServerV2 ConexionBD = new clsConectorSqlServerV2();
		public static string Conexion = Settings.Default.ConfiguracionBD.ToString();
		public static string RutaCarpeta = Settings.Default.RutaArchivo.ToString();
		public static string RutaCarpetaLog = string.Format("{0}{1}", 
																							RutaCarpeta,
																							Settings.Default.RutaArchivoLog.ToString());
		public static string RutaNombreArchivoLog = string.Format("{0}{1}{2}", 
																							RutaCarpeta,
																							Settings.Default.RutaArchivoLog.ToString(),
																							Settings.Default.NombreArchivoLog.ToString());
		public static string Ambiente = Settings.Default.Ambiente.ToString();
		public static System.Drawing.Color ColorAmbiente = Settings.Default.Color;
		public static System.Drawing.Color ColorCeldaBloqueado = Settings.Default.ColorCeldaBloqueda;
		public static System.Drawing.Color ColorCeldaEliminado = Settings.Default.ColorCeldaEliminado;
		public static string IP = "".XCapturarIP();
		public static string NombreEquipo = "".XCapturarNombreEquipo();
		public static string MensajeAdministrador = Settings.Default.MensajeAdminstrador.ToString();
		public const string MensajeAdministradorCorreo = "Envio archivo LOG";
		public static string RutaArchivoPlantilla = Settings.Default.RutaArchivoPlantilla.ToString();
		public static string RutaEjecutablePlantilla = AppDomain.CurrentDomain.BaseDirectory + "Archivo";
		#endregion

		#region Ddls
		public static DataSet  CargarPerfil()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "ddl_Perfil";

			cmd.CommandType = CommandType.StoredProcedure;

			return  ConexionBD.Listar(ClaseGeneral.Conexion, cmd);
		}

		#endregion

		#region ManejoLog
		public static void GuardarLOG(string Formulario,string Descripcion,string Evento)
		{
			string strMensajeError="";
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = String.Format("Sist_ManejoLogIns");
			cmd.Parameters.Clear();
			cmd.Parameters.Add("@Usuario", SqlDbType.VarChar);
			cmd.Parameters["@Usuario"].Value = Clases.clsUsuario.Usuario;
			cmd.Parameters.Add("@Id_Perfil", SqlDbType.Int);
			cmd.Parameters["@Id_Perfil"].Value = Clases.clsUsuario.Id_perfil;
			cmd.Parameters.Add("@Formulario", SqlDbType.VarChar,200);
			cmd.Parameters["@Formulario"].Value = Formulario;
			cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar);
			cmd.Parameters["@Descripcion"].Value = Descripcion;
			cmd.Parameters.Add("@Evento", SqlDbType.VarChar);
			cmd.Parameters["@Evento"].Value = Evento;
			cmd.Parameters.Add("@Id", SqlDbType.BigInt);
			cmd.Parameters["@Id"].Direction = ParameterDirection.Output;
			cmd.CommandType = CommandType.StoredProcedure;
			ConexionBD.Agregar(ClaseGeneral.Conexion, cmd, "Id", ref strMensajeError);
		}

		#endregion

		#region Manejo de archivo y carpeta

		public static void CrearCarpetaSistema()
		{
			RutaCarpeta.XARCHCrearCarpeta();
			RutaCarpetaLog.XARCHCrearCarpeta();
			RutaNombreArchivoLog.XARCHCrearArchivo();
		}

		#endregion
	}
}
