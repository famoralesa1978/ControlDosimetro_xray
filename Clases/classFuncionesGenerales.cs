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
					mensajes.MensajeError(e.Message);
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

		public static bool MensajeConfirmacion(string strmensaje)
		{

			if (MessageBox.Show(strmensaje, ControlDosimetro.Properties.Resources.msgCaptionConfirmacion, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
				return true;
			else
				return false;
        }

        public static void MensajeAdvertencia(string strmensaje)
        {
            MessageBox.Show(strmensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

	public class Filtro
	{
		public static void FiltroPersonal(ref DataGridView grdGrilla, string NombrePersonal, string Rut)
		{
			
			string strFiltro = "";
			DataTable dt = ((DataTable)(grdGrilla.DataSource));
			//Rut, Nombres,Paterno,Maternos
			strFiltro = !String.IsNullOrEmpty(Rut) ? "Rut like '%" + Rut + "%'" : "";
			strFiltro = strFiltro + (!String.IsNullOrEmpty(NombrePersonal) ? "(Nombres + ' '+  Paterno+ ' '+Maternos) like '%" + NombrePersonal + "%'" : "");
			dt.DefaultView.RowFilter = strFiltro;
		}

		public static void FiltroPersonal(ref DataGridView grdGrilla, string NombrePersonal, string Rut, string FecNac)
		{

			string strFiltro = "";
			DataTable dt = ((DataTable)(grdGrilla.DataSource));
			//Rut, Nombres,Paterno,Maternos
			strFiltro = !String.IsNullOrEmpty(Rut) ? "Rut like '%" + Rut + "%'" : "";
			strFiltro = strFiltro + (!String.IsNullOrEmpty(NombrePersonal) ? "(Nombres + ' '+  Paterno+ ' '+Maternos) like '%" + NombrePersonal + "%'" : "");
			strFiltro = strFiltro + (!String.IsNullOrEmpty(FecNac) ? "Fecha_Nac = '" + FecNac + "'" : "");
			dt.DefaultView.RowFilter = strFiltro;
		}//id_cliente

		public static void FiltroPersonal(ref DataGridView grdGrilla, string NombrePersonal, string Rut, string FecNac,int intEstado)
		{

			string strFiltro = "";
			DataTable dt = new DataTable();
			BindingSource bs = new BindingSource();
			bs.DataSource = grdGrilla.DataSource;
			dt = ((DataView)(bs.DataSource)).Table;
			//Rut, Nombres,Paterno,Maternos
			strFiltro = !String.IsNullOrEmpty(Rut) ? "Rut like '%" + Rut + "%'" : "";
			strFiltro = strFiltro + (!String.IsNullOrEmpty(NombrePersonal) ? "(Nombres + ' '+  Paterno+ ' '+Maternos) like '%" + NombrePersonal + "%'" : "");
			strFiltro = strFiltro + (!String.IsNullOrEmpty(FecNac) ? "Fecha_Nac = '" + FecNac + "'" : "");
			strFiltro = strFiltro + "id_Estado=" + intEstado.ToString();
			dt.DefaultView.RowFilter = strFiltro;
		}
		public static void FiltroPersonal(ref DataGridView grdGrilla, string NombrePersonal, string Rut,int intEstado)
		{

			string strFiltro = "";
			DataTable dt = new DataTable();
			BindingSource bs = new BindingSource();
			bs.DataSource = grdGrilla.DataSource;
			dt = ((DataView)(bs.DataSource)).Table;
			//Rut, Nombres,Paterno,Maternos
			strFiltro = !String.IsNullOrEmpty(Rut) ? "Rut like '%" + Rut + "%'" : "";
			strFiltro = strFiltro + (!String.IsNullOrEmpty(NombrePersonal) ? "(Nombres + ' '+  Paterno+ ' '+Maternos) like '%" + NombrePersonal + "%'" : "");
			strFiltro = strFiltro + "id_Estado=" + intEstado.ToString();
			dt.DefaultView.RowFilter = strFiltro;
		}

		public static void FiltroPersonal(ref DataGridView grdGrilla, string NombrePersonal, string Rut, string FecNac, int intEstado,int Id_Seccion)
		{

			string strFiltro = "";
			DataTable dt = new DataTable();
			BindingSource bs = new BindingSource();
			bs.DataSource = grdGrilla.DataSource;
			dt = ((DataView)(bs.DataSource)).Table;
			//Rut, Nombres,Paterno,Maternos
			strFiltro = !String.IsNullOrEmpty(Rut) ? "Rut like '%" + Rut + "%'" : "";
			strFiltro = strFiltro + (!String.IsNullOrEmpty(NombrePersonal) ? "(Nombres + ' '+  Paterno+ ' '+Maternos) like '%" + NombrePersonal + "%'" : "");
			strFiltro = strFiltro + (!String.IsNullOrEmpty(FecNac) ? "Fecha_Nac = '" + FecNac + "'" : "");
			strFiltro = strFiltro + "id_Estado=" + intEstado.ToString();
			strFiltro = strFiltro + "(Id_Seccion=" + Id_Seccion.ToString() + " or " + Id_Seccion.ToString() + "=0)";
			dt.DefaultView.RowFilter = strFiltro;
		}
		public static void FiltroPersonal(ref DataGridView grdGrilla, string NombrePersonal, string Rut, int intEstado,int Id_Seccion)
		{

			string strFiltro = "";
			DataTable dt = new DataTable();
			BindingSource bs = new BindingSource();
			bs.DataSource = grdGrilla.DataSource;
			dt = ((DataView)(bs.DataSource)).Table;
			//Rut, Nombres,Paterno,Maternos
			strFiltro = !String.IsNullOrEmpty(Rut) ? "Rut like '%" + Rut + "%'" : "";
			strFiltro = strFiltro + (!String.IsNullOrEmpty(NombrePersonal) ? " and (Nombres + ' '+  Paterno+ ' '+Maternos) like '%" + NombrePersonal + "%'" : "");
			strFiltro = strFiltro + (!String.IsNullOrEmpty(strFiltro) ? " and " : "") + "  (id_Estado=" + intEstado.ToString()+ ")";
			strFiltro = strFiltro + (!String.IsNullOrEmpty(strFiltro) ? " and " : "") + "  (Id_Seccion=" + Id_Seccion.ToString()+" or "+ Id_Seccion.ToString()+  "=0)";
			dt.DefaultView.RowFilter = strFiltro;
		}


		public static void FiltroCliente(ref DataGridView grdGrilla, string intId_Cliente)
		{

			string strFiltro = "";
			DataTable dt = ((DataTable)(grdGrilla.DataSource));
			//Rut, Nombres,Paterno,Maternos
			strFiltro = !String.IsNullOrEmpty(intId_Cliente) ? "Id_Cliente =" + intId_Cliente + "":"";
			dt.DefaultView.RowFilter = strFiltro;
		}//id_cliente
	}

}



