using System;
using System.Data;
using System.Data.SqlClient;
namespace ControlDosimetro
{

	public class clsConectorSqlServerV2
	{
		private SqlConnection conexion;

		//private SqlConnection conexion;

		private void Conectar(String strPublicacion)
		{
			//**********************
			conexion = new SqlConnection(strPublicacion.XDecryptTripleDES());

			conexion.Open();

		}

		private void Cerrar()
		{

			conexion.Close();
		}

		public DataSet Listar(String strPublicacion, SqlCommand cmd)
		{
			ClaseGeneral.CrearCarpetaSistema();
			string strSp = "";
			try
			{

				Conectar(strPublicacion);
			DataSet dt = new DataSet();
			cmd.Connection = conexion;
				strSp = cmd.XSQLObtieneDatosParametro();
				SqlDataAdapter reader = new SqlDataAdapter(cmd);
			reader.Fill(dt);
			Cerrar();
			return dt;
			}
			catch (SqlException ex)
			{
				if (ex.Class != 16)
				{
					string msg = string.Format("{0};{1};{2};{3};{4};{5};{6}", ClaseGeneral.IP, ClaseGeneral.NombreEquipo, DateTime.Now, strSp, "SP", ex.Procedure, ex.Message);
					msg.XARCHEscribirArchivoLog(ClaseGeneral.RutaNombreArchivoLog);
					ex.Message.XMensajeError();
				}

			}
			finally
			{

				Cerrar();
			}
			return null;
		}

    public string Agregar(String strPublicacion, SqlCommand cmd,string campo, ref string strMensajeError)
    {
      string strId = "";
			string strSp = "";
			ClaseGeneral.CrearCarpetaSistema();
			try
      {
        Conectar(strPublicacion);

        cmd.Connection = conexion;
				strSp = cmd.XSQLObtieneDatosParametro();
				cmd.ExecuteNonQuery();
        return cmd.Parameters["@"+campo].Value.ToString();
      }
      catch (SqlException ex)
      {
				if (ex.Class != 16)
				{
					string msg = string.Format("{0};{1};{2};{3};{4};{5};{6}", ClaseGeneral.IP, ClaseGeneral.NombreEquipo, DateTime.Now, strSp, "SP", ex.Procedure, ex.Message);
					msg.XARCHEscribirArchivoLog(ClaseGeneral.RutaNombreArchivoLog);
					ex.Message.XMensajeError();
				}
				strMensajeError = ex.Message;
			}
      finally
      {

        Cerrar();
      }
      return strId;
    }

    public void Modificar(String strPublicacion, SqlCommand cmd, ref string strMensajeError)
    {
			ClaseGeneral.CrearCarpetaSistema();
			string strSp = "";
			try
      {
        Conectar(strPublicacion);

        cmd.Connection = conexion;
				strSp = cmd.XSQLObtieneDatosParametro();
				cmd.ExecuteNonQuery();
      }
      catch (SqlException ex)
      {
				if (ex.Class != 16)
				{
					string msg = string.Format("{0};{1};{2};{3};{4};{5};{6}", ClaseGeneral.IP, ClaseGeneral.NombreEquipo, DateTime.Now, strSp, "SP", ex.Procedure, ex.Message);
					msg.XARCHEscribirArchivoLog(ClaseGeneral.RutaNombreArchivoLog);
					ex.Message.XMensajeError();
				}
				strMensajeError = ex.Message;
			}
      finally
      {

        Cerrar();
      }
    }

    public void AgregarModificarEliminar(String strPublicacion, SqlCommand cmd, ref string strMensajeError)
		{
			ClaseGeneral.CrearCarpetaSistema();
			string strSp = "";
			try
			{
				Conectar(strPublicacion);

				cmd.Connection = conexion;
				strSp = cmd.XSQLObtieneDatosParametro();
				cmd.ExecuteNonQuery();
			}
			catch (SqlException ex)
			{
				if(ex.Class != 16)
				{
					string msg = string.Format("{0};{1};{2};{3};{4};{5};{6}", ClaseGeneral.IP, ClaseGeneral.NombreEquipo, DateTime.Now, strSp, "SP", ex.Procedure, ex.Message);
					msg.XARCHEscribirArchivoLog(ClaseGeneral.RutaNombreArchivoLog);
					ex.Message.XMensajeError();
				}
				
				strMensajeError = ex.Message;
			}
			finally
			{

				Cerrar();
			}

		}

		public void PermisoFormulario(int intMenu,ref bool Lectura, ref bool Agregar, ref  bool Modificar, ref bool Eliminar)
		{
			SqlCommand cmd = new SqlCommand();
			DataSet ds;
			cmd.CommandText = "Sist_Permiso_SelId";
			cmd.Parameters.Clear();
			cmd.Parameters.Add("@Id_perfil", SqlDbType.Int);
			cmd.Parameters["@Id_perfil"].Value = Clases.clsUsuario.Id_perfil;
			cmd.Parameters.Add("@IdMenu", SqlDbType.Int);
			cmd.Parameters["@IdMenu"].Value = intMenu;
			cmd.CommandType = CommandType.StoredProcedure;

			ds = Listar(ClaseGeneral.Conexion, cmd);
			if (ds != null)
			{
				if (ds.Tables[0].Rows.Count > 0)
				{
					Lectura = (bool)ds.Tables[0].Rows[0]["Lectura"];
					Agregar = (bool)ds.Tables[0].Rows[0]["Nuevo"];
					Modificar = (bool)ds.Tables[0].Rows[0]["Modificacion"];
					Eliminar = (bool)ds.Tables[0].Rows[0]["Eliminar"];
				}
				else
				{
					Lectura = false;
					Agregar = false;
					Modificar = false;
					Eliminar = false;
				}
			}
			else
			{
				Lectura = false;
				Agregar = false;
				Modificar = false;
				Eliminar = false;
			}
		}

	}
}
