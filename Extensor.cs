﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using dllLibreriaEvento;
using System.IO;
using System.Net;
using System.Data.SqlClient;
using System.Text;
using System.Deployment.Application;
using System.Runtime.CompilerServices;

namespace ControlDosimetro
{
	public static class Extensores
	{
		#region Declaracion

		static clsEventoControl ClaseEvento = new clsEventoControl();
		static dllLibreriaMysql.clsUtiles clsUtiles1 = new dllLibreriaMysql.clsUtiles();

		#endregion

		#region Eventos Controles
		/// <summary>
		/// Asigna número entero al control Texbox
		/// </summary>
		/// <param name="control">El nombre del control</param>
		/// <param name="Maximo">se le asigna el largo </param>
		public static void EventoAsignarNumero(this Control control, int Maximo)
		{
			if (control is System.Windows.Forms.TextBox)
			{
				(control as System.Windows.Forms.TextBox).KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
				(control as System.Windows.Forms.TextBox).KeyDown += new KeyEventHandler(ClaseEvento.Numero_KeyDown);
				(control as System.Windows.Forms.TextBox).MaxLength = Maximo;
			}

		}

		#endregion

		#region Funciones
		public static string XGenerateHashMD5(this string cadena)
		{
			return clsUtiles1.GenerateHashMD5(cadena);
		}
		public static string XDecryptTripleDES(this string cadena)
		{
			return clsUtiles1.DecryptTripleDES(cadena);
		}

		public static bool XHayCambio(this DataGridView dg)
		{
			int intCount = ((DataTable)dg.DataSource).AsEnumerable().Where(s => s.RowState == DataRowState.Added || s.RowState == DataRowState.Modified).Count();
			if (intCount > 0)
			{
				return true;
			}
			return false;
		}
		public static DataView Vista(this DataGridView dg)
		{
			DataView dv = ((DataTable)dg.DataSource).DefaultView;
			return dv;
		}
		public static bool XHayError(this DataGridView dg)
		{
			DataTable dt = (DataTable)dg.DataSource;
			if (dt.HasErrors)
			{
				return true;
			}
			return false;
		}
		public static bool XValidarFormulario(this Form frm, ref StringBuilder stbError)
		{
			foreach (var label in frm.Controls.OfType<System.Windows.Forms.Label>())
			{
				if (label.Font.Underline)
				{
					if (label.Tag.ToString() == "TextBox")
					{
						string strNombreControl = label.Name.Substring(3, label.Name.Length - 3);
						Control control = frm.Controls.Find(string.Format("txt{0}", strNombreControl), true).FirstOrDefault() as TextBox;
						if (control.Text.ToString().Trim().Length == 0)
						{
							stbError.AppendLine(string.Format("- {0}", label.Text));
						}
					}
				}
			}

			if (stbError.Length > 0)
				return true;
			else
				return false;
		}
		public static bool XValidarEmail(this string cadena)
		{
			bool bolValidar = false;
			try
			{
				string[] stringSeparators = new string[] { ";" };
				string[] result = cadena.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
				String expresion;
				expresion = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
 @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
				foreach (string s in result)
				{

					if (System.Text.RegularExpressions.Regex.IsMatch(s, expresion))
					{
						if (System.Text.RegularExpressions.Regex.Replace(s, @"(@)(.+)$", String.Empty).Length == 0)
						{
							bolValidar = true;
						}

					}
					else
					{
						bolValidar = true;
					}
				}


			}
			catch (Exception)
			{
			}
			return bolValidar;
		}
		public static bool XValidarRut(this string cadena)
		{
			bool bolValidar = false;
			try
			{
				cadena = cadena.ToUpper();
				cadena = cadena.Replace(".", "");
				cadena = cadena.Replace("-", "");
				int rutAux = int.Parse(cadena.Substring(0, cadena.Length - 1));

				char dv = char.Parse(cadena.Substring(cadena.Length - 1, 1));

				int m = 0, s = 1;
				for (; rutAux != 0; rutAux /= 10)
				{
					s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
				}
				if (dv != (char)(s != 0 ? s + 47 : 75))
				{
					bolValidar = true;
				}
			}
			catch (Exception)
			{
			}
			return bolValidar;
		}



		#endregion

		#region Tratatamiento de archivo y carpeta
		public static void XARCHCrearCarpeta(this string cadena)
		{
			if (!Directory.Exists(cadena)) Directory.CreateDirectory(cadena);
		}
		public static void XARCHCrearArchivo(this string cadena)
		{
			if (!File.Exists(cadena))
			{
				StreamWriter writer = File.CreateText(cadena);
				writer.Close();
			}

		}

		public static void XARCHEscribirArchivoLog(this string Mensaje, string Archivo)
		{
			ClaseGeneral.CrearCarpetaSistema();
			StreamWriter writer = File.AppendText(Archivo);

			writer.WriteLine(Environment.NewLine + Mensaje);
			writer.Close();

		}

		#endregion

		#region SQl

		public static string XSQLObtieneDatosParametro(this SqlCommand cmd)
		{
			string strParametro = string.Format("{0} ", cmd.CommandText);
			for (int intParam = 0; intParam < cmd.Parameters.Count; intParam++)
			{
				if (cmd.Parameters[intParam].SqlDbType == SqlDbType.VarChar || cmd.Parameters[intParam].SqlDbType == SqlDbType.DateTime )
					strParametro += string.Format("{0}'{1}'", intParam > 0 ? "," : "", cmd.Parameters[intParam].Value);
				else
					strParametro += string.Format("{0}'{1}'", intParam > 0 ? "," : "", cmd.Parameters[intParam].Value);
			}

			return strParametro;
		}

		#endregion

		#region Otras funciones

		public static string XCapturarIP(this string cadena)
		{
			string strHostName = string.Empty;
			strHostName = Dns.GetHostName();
			string strIP = "";
			IPAddress[] hostIPs = Dns.GetHostAddresses(strHostName);
			for (int i = 0; i < hostIPs.Length; i++)
			{
				strIP = hostIPs[i].ToString();
			}

			return strIP;
		}
		public static string XCapturarNombreEquipo(this string cadena)
		{
			string strHostName = string.Empty;
			strHostName = Dns.GetHostName();
			return strHostName;
		}

		#endregion

		#region Correo

		public static void XCORREOEnviarCorreoAdministrador(this string strMensaje)
		{
			ClsEmail mail = new ClsEmail();
			mail.EnviarCorreoAdministrador(strMensaje, "pipecato2@gmail.com", "Se adjunta archivo LOG", ClaseGeneral.RutaNombreArchivoLog);
		}

		#endregion

		#region Mensaje

		public static void XMensajeProcesoOK(this string strmensaje)
		{
			MessageBox.Show(strmensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		public static void XMensajeError(this string strmensaje)
		{
			MessageBox.Show(strmensaje, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public static bool XMensajeConfirmacionOKCancel(this string strmensaje)
		{

			if (MessageBox.Show(strmensaje, "Mensaje de confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
				return true;
			else
				return false;
		}
		public static bool XMensajeConfirmacionSiNo(this string strmensaje)
		{

			if (MessageBox.Show(strmensaje, "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
				return true;
			else
				return false;
		}

		public static void XMensajeAdvertencia(this string strmensaje)
		{
			MessageBox.Show(strmensaje, "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}


		#endregion
	}
}