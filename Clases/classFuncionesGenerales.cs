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
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using DocumentFormat.OpenXml.Spreadsheet;


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

		public static bool ExportExcel(DataTable dt,string fileName, string strHoja)
		{

			bool result = false;
			IWorkbook workbook = null;
			FileStream fs = null;
			IRow row = null;
			ISheet sheet = null;
			ICell cell = null;
			try
			{
				if (dt != null && dt.Rows.Count > 0)
				{
					//fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
					workbook = new HSSFWorkbook();
					sheet = workbook.CreateSheet(strHoja);
					int rowCount = dt.Rows.Count;
					int columnCount = dt.Columns.Count;
					row = sheet.CreateRow(0);
					for (int c = 0; c < columnCount; c++)
					{
						cell = row.CreateCell(c);
						cell.SetCellValue(dt.Columns[c].ColumnName);
					}
					for (int i = 0; i < rowCount; i++)
					{
						row = sheet.CreateRow(i + 1);
						for (int j = 0; j < columnCount; j++)
						{
							cell = row.CreateCell(j);
							cell.SetCellValue(dt.Rows[i][j].ToString());
						}
					}
					using (fs = File.Create(fileName))
					{
						workbook.Write(fs);
						workbook.Close();
						result = true;
					}
				}
				return result;
			}
			catch (Exception ex)
			{
				if (fs != null)
				{
					fs.Close();
				}
				return result;
			}
		}
	}


	public class mensajes
	{
		public static void MensajeProcesoOK(string strmensaje)
		{
			MessageBox.Show(strmensaje, ControlDosimetro.Properties.Resources.msgCaptionProcesoOK, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
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
			strFiltro = strFiltro + (intEstado==3?"":( "id_Estado=" + intEstado.ToString()));
			strFiltro = strFiltro + "(Id_Seccion=" + Id_Seccion.ToString() + " or " + Id_Seccion.ToString() + "=0)";
			dt.DefaultView.RowFilter = strFiltro;
		}

		public static DataSet FiltroPersonal(int intIdCliente,string NombrePersonal, string Rut, string FecNac, int intEstado, int Id_Seccion, bool bolListarSinDireccion,int id_Direccion=0)
		{
			DataSet dt = new DataSet();
			clsConectorSqlServer Conectar = new clsConectorSqlServer();
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = String.Format("pa_ListarPersonalFiltro_sel {0},'{1}','{2}','{3}',{4},{5},{6},{7}", intIdCliente.ToString(), NombrePersonal, Rut,FecNac, intEstado,Id_Seccion, (bolListarSinDireccion?1:0), id_Direccion);
			cmd.CommandType = CommandType.Text;

			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			return dt;
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
			strFiltro = strFiltro + (!String.IsNullOrEmpty(strFiltro) ? " and " : "") + (!String.IsNullOrEmpty(NombrePersonal) ? "  (Nombres + ' '+  Paterno+ ' '+Maternos) like '%" + NombrePersonal + "%'" : "");

			strFiltro = strFiltro + (!String.IsNullOrEmpty(strFiltro)&& intEstado != 3 ? " and " : "") + (intEstado == 3 ? "" : "  (id_Estado=" + intEstado.ToString()+ ")");
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

	public class ExcelNpoin
	{
		public ISheet LeerExcel(string archivo, string extension,int intHoja, ref string nomHoja)
		{
			ISheet sheet = null;
			IWorkbook hssfwb = null;
			using (FileStream file = new FileStream(@archivo, FileMode.Open, FileAccess.Read))
			{
				//hssfwb = new HSSFWorkbook(file);
				if (extension == ".xlsx")
					hssfwb = new XSSFWorkbook(file);
				else if (extension == ".xls")
					hssfwb = new HSSFWorkbook(file);
			}

			sheet = hssfwb.GetSheetAt(intHoja);
			nomHoja=hssfwb.GetSheetAt(intHoja).SheetName;
			return sheet;
		}

		public void CopiarHoja(string archivo, int intHoja,string NombreHoja)
		{
			ISheet sheet = null;
			IWorkbook hssfwb = null;
			FileInfo fi = new FileInfo(archivo);
			string extension = fi.Extension;
			using (FileStream file = new FileStream(@archivo, FileMode.Open, FileAccess.Read))
			{
				//hssfwb = new HSSFWorkbook(file);
				if (extension == ".xlsx")
				{
					hssfwb = new XSSFWorkbook(file);
				}
					
				else if (extension == ".xls")
				{
					hssfwb = new HSSFWorkbook(file);

				}
				
			}
			sheet = hssfwb.GetSheetAt(intHoja);
			sheet.CopyTo(hssfwb, $"{NombreHoja}", true, true);

			using (FileStream fs = new FileStream(@archivo, FileMode.Create, FileAccess.Write))
			{
				hssfwb.Write(fs);
			}
		}

		public void EliminarHoja(string archivo,int intHoja= 0)
		{
			ISheet sheet = null;
			IWorkbook hssfwb = null;
			FileInfo fi = new FileInfo(archivo);
			string extension = fi.Extension;
			using (FileStream file = new FileStream(@archivo, FileMode.Open, FileAccess.Read))
			{
				//hssfwb = new HSSFWorkbook(file);
				if (extension == ".xlsx")
				{
					hssfwb = new XSSFWorkbook(file);
				}

				else if (extension == ".xls")
				{
					hssfwb = new HSSFWorkbook(file);

				}
			
			}
			using (FileStream fs = new FileStream(@archivo, FileMode.OpenOrCreate, FileAccess.Write))
			{
				hssfwb.RemoveSheetAt(intHoja);

				//hssfwb.Write(fs);
			}
			hssfwb.Close();

		}

	}
}



