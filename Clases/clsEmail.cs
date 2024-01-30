using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using ControlDosimetro;
using System.Xml.Linq;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;


namespace ControlDosimetro
{
	public class ClsEmail//prueba
	{
		#region Declaracion

		private static string strDesde;
		private static string strCredencial;
		private static string strClave;
		private static string strHost;
		private static int strPort;

		public int Port
		{
			get
			{
				return strPort;
			}
			set
			{
				strPort = value;  // value is an implicit parameter
			}

		}
		public string Host
		{
			get
			{
				return strHost;
			}
			set
			{
				strHost = value;  // value is an implicit parameter
			}

		}
		public string Clave
		{
			get
			{
				return strClave;
			}
			set
			{
				strClave = value;  // value is an implicit parameter
			}

		}
		public string Desde
		{
			get
			{
				return strDesde;
			}
			set
			{
				strDesde = value;  // value is an implicit parameter
			}

		}

		public string Credencial
		{
			get
			{
				return strCredencial;
			}
			set
			{
				strCredencial = value;  // value is an implicit parameter
			}

		}
		#endregion

		#region Configuracion
		private void CargarConfiguracionAdministrador()
		{
			//ConfCorreoAdm
			string ruta = Path.Combine(Application.StartupPath, "ArchivoConfiguracion", "ConfCorreoAdm.xml");
			XDocument nodoRaiz = XDocument.Load(@ruta, LoadOptions.None);
			IEnumerable<XElement> nodo = nodoRaiz.Descendants("Conf");

			foreach (XElement ele in nodo)
			{
				strDesde = ele.Element("Desde").Value;
				strCredencial = ele.Element("Credencial").Value;
				strClave = ele.Element("Clave").Value;
				strHost = ele.Element("Host").Value;
				strPort = Convert.ToInt16(ele.Element("Port").Value);
			}
		}

		#endregion

		#region EnvioCorreo
		public void EnviarCorreoAdministrador(string Subject, string Add, string htmlBody, string filename)
		{

			CargarConfiguracionAdministrador();

			try
			{
				MailMessage correos = new MailMessage();
				SmtpClient envios = new SmtpClient();


				correos.To.Clear();
				correos.Subject = Subject;
				correos.IsBodyHtml = true;
				correos.To.Add(Add);
				correos.Body = htmlBody;
				correos.From = new MailAddress(Desde);
				if (!string.IsNullOrWhiteSpace(filename))
				{
					Attachment data = new Attachment(filename, MediaTypeNames.Application.Octet);
					correos.Attachments.Add(data);
				}

				envios.Credentials = new NetworkCredential(Credencial, Clave);

				//Datos importantes no modificables para tene¿¿r acceso a las cuentas

				envios.Host = Host;
				envios.Port = Port;
				envios.EnableSsl = true;

				envios.Send(correos);
				"Correo enviado".XMensajeProcesoOK();
			}
			catch (Exception ex)
			{
				string msg = string.Format("{0};{1};{2};{3};{4};{5};{6}", ClaseGeneral.IP, ClaseGeneral.NombreEquipo, DateTime.Now, "Envio correo administardor", "ClsEmail", "EnviarCorreoAdministrador", ex.Message);
				msg.XARCHEscribirArchivoLog(ClaseGeneral.RutaNombreArchivoLog);
				ClaseGeneral.MensajeAdministrador.XMensajeError();
			}
		}

		#endregion

	}
}
