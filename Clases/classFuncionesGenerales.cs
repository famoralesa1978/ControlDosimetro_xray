using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dllConectorMysql;
using dllLibreriaEvento;
using dllLibreriaMysql;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace classFuncionesGenerales
{
    public class ClsValidadores
	{
		readonly clsConectorSqlServer Conectar = new clsConectorSqlServer();


		public static string FormatearRut(string rut)
		{
			string rutFormateado = string.Empty;

			if (rut.Length == 0)
			{
				rutFormateado = "";
			}
			else
			{
				string rutTemporal;
				string dv;

				rut = rut.Replace("-", "").Replace(".", "");

				if (rut.Length == 1)
				{
					rutFormateado = rut;
				}
				else
				{
					rutTemporal = rut.Substring(0, rut.Length - 1);
					dv = rut.Substring(rut.Length - 1, 1);

					if (!Int64.TryParse(rutTemporal, out long rutNumerico))
					{
						rutNumerico = 0;
					}

					rutFormateado = rutNumerico.ToString();

					if (rutFormateado.Equals("0"))
					{
						rutFormateado = string.Empty;
					}
					else
					{
						//si no hubo problemas con el formateo agrego el DV a la salida
						rutFormateado += "-" + dv;

						//y hago este replace por si el servidor tuviese configuracion anglosajona y reemplazo las comas por puntos
						rutFormateado = rutFormateado.Replace(",", ".");
					}
				}
			}

			return rutFormateado;
		}


		public static byte[] Convertir_Binario(String Ruta_Archivo)
		{

			byte[] Convert = File.ReadAllBytes(Ruta_Archivo);

			return Convert;
		}

		public static void Leer_BinarioCarpetaTmp(byte[] Convert, String Archivo)
		{
			string strPath = "C:\\Doc_Xray\\tmp\\";
			try
			{
				if (!Directory.Exists("C:\\Doc_Xray"))
					Directory.CreateDirectory("C:\\Doc_Xray");
				if (!Directory.Exists("C:\\Doc_Xray\\tmp"))
					Directory.CreateDirectory("C:\\Doc_Xray\\tmp");

				System.IO.File.WriteAllBytes(strPath + Archivo, Convert);
				Process p = new Process();
				p.StartInfo.FileName = strPath + Archivo;
				p.Start();
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message, ControlDosimetro.Properties.Resources.msgCaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		public static void Leer_Binario(byte[] Convert, String Archivo)
		{
			FolderBrowserDialog fdlg = new FolderBrowserDialog();
			if (fdlg.ShowDialog() == DialogResult.OK)
			{
				try
				{
					System.IO.File.WriteAllBytes(fdlg.SelectedPath + "\\" + Archivo, Convert);
					Process p = new Process();
					p.StartInfo.FileName = fdlg.SelectedPath + "\\" + Archivo;
					p.Start();
				}
				catch (Exception e)
				{
					MessageBox.Show(e.Message, ControlDosimetro.Properties.Resources.msgCaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

	}

	public class mensajes
	{

		public static void MensajeError(string strmensaje)
		{
			MessageBox.Show(strmensaje, ControlDosimetro.Properties.Resources.msgCaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}

    public class Filtro
    {
        public static DataSet FiltroPersonal(Int64 intCliente, string Rut)
        {
            clsConectorSqlServer Conectar = new clsConectorSqlServer();
            SqlCommand cmd = new SqlCommand();

            if (intCliente != 0)
            {
                cmd.CommandText = "select id_cliente,run,razon_social,Direccion,telefono " +
                        "from tbl_cliente " +
                        "where  (id_cliente=" + intCliente.ToString() + ") or run ='" + Rut + "' " +
                        " and id_estado=1 " +
                        "order by id_cliente";
            }
            if (intCliente == 0)
                cmd.CommandText = "select id_cliente,run,razon_social,Direccion,telefono " +
                        "from tbl_cliente " +
                        "where run  ='" + Rut + "' " + " and id_estado=1 " +
                        "order by id_cliente";
            cmd.CommandType = CommandType.Text;

            DataSet dt;
            dt = Conectar.Listar(Clases.clsBD.BD, cmd);
            return dt;
        }
    }

}



