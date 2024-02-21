using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using dllConectorMysql;
using dllLibreriaEvento;
using dllLibreriaMysql;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using NPOI.OpenXmlFormats.Shared;


namespace ControlDosimetro
{
	public partial class frmLogin : Form
	{
		#region "Definicion variable"
		clsConectorSqlServerV2 Conectar = new clsConectorSqlServerV2();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();
		Color coColor;
		dllLibreriaMysql.clsUtiles clsUtiles1 = new dllLibreriaMysql.clsUtiles();

		#endregion

		public frmLogin()
		{
			InitializeComponent();
			coColor = frmLogin.DefaultBackColor;
			this.labelVersion.Text = String.Format("Versión {0}", AssemblyVersion);
			labelBD.Text = ClaseGeneral.Ambiente;
			labelBD_Click(null, null);

		}

		#region Descriptores de acceso de atributos de ensamblado

		public string AssemblyTitle
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
				if (attributes.Length > 0)
				{
					AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
					if (titleAttribute.Title != "")
					{
						return titleAttribute.Title;
					}
				}
				return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
			}
		}

		public string AssemblyVersion
		{
			get
			{
				return Assembly.GetExecutingAssembly().GetName().Version.ToString();
			}
		}

		public string AssemblyDescription
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyDescriptionAttribute)attributes[0]).Description;
			}
		}

		public string AssemblyProduct
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyProductAttribute)attributes[0]).Product;
			}
		}

		public string AssemblyCopyright
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
			}
		}

		public string AssemblyCompany
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyCompanyAttribute)attributes[0]).Company;
			}
		}

		#endregion

		#region Región asociada a los botones

		private void btn_Salir_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btn_ingresar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			try
			{
				if (txt_Usuario.Text.Trim() == "" || txt_Contrasena.Text.Trim() == "")
					MessageBox.Show("Debe contener usuario y contraseña");
				else
				{
					Cursor = Cursors.WaitCursor;
					string Clave = clsUtiles1.GenerateHashMD5(txt_Contrasena.Text.Trim());

					//pa_login_sel 
					SqlCommand cmd = new SqlCommand();
					DataSet ds; // = new DataSet();
					cmd.CommandText = "pa_login_sel";
					cmd.Parameters.Clear();
					cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 30);
					cmd.Parameters["@Usuario"].Value = txt_Usuario.Text.Trim();
					cmd.Parameters.Add("@Contraseña", SqlDbType.VarChar, 100);
					cmd.Parameters["@Contraseña"].Value = Clave;
					cmd.CommandType = CommandType.StoredProcedure;

					string strSp = cmd.XSQLObtieneDatosParametro();

					ds = Conectar.Listar(Clases.clsBD.BD, cmd);
					Cursor = Cursors.Default;
					if (ds != null)
					{
						if (ds.Tables[0].Rows.Count == 0)
							"El usuario no existe".XMensajeError();
						else
						{
							if (ds.Tables[0].Rows[0]["Contraseña"].ToString() == Clave)
								if ((bool)ds.Tables[0].Rows[0]["Estado"])
								{
									Clases.clsUsuario.Usuario = ds.Tables[0].Rows[0]["Usuario"].ToString();
									Clases.clsUsuario.Nombre = ds.Tables[0].Rows[0]["Nombres"].ToString() + " " + ds.Tables[0].Rows[0]["Paterno"].ToString() + " " + ds.Tables[0].Rows[0]["Maternos"].ToString();
									Clases.clsUsuario.Id_Usuario = Convert.ToInt16(ds.Tables[0].Rows[0]["Id_Usuario"].ToString());
									Clases.clsUsuario.Id_perfil = Convert.ToInt16(ds.Tables[0].Rows[0]["Id_perfil"].ToString());
									Clases.clsUsuario.Contraseña = ds.Tables[0].Rows[0]["contraseña"].ToString();
									Clases.clsUsuario.Perfil = ds.Tables[0].Rows[0]["Perfil"].ToString();
									ClaseGeneral.GuardarLOG(this.Name, strSp, "btn_ingresar_Click");
									this.Close();
								}
								else
								{
									"El usuario se encuentra inactivo. Consulte al administrador del sistema.".XMensajeError();
								}
							else
							{
								string msg = string.Format("{0};{1};{2};{3};{4};{5};{6}", ClaseGeneral.IP, ClaseGeneral.NombreEquipo, DateTime.Now, strSp, this.Name, ((System.Windows.Forms.Control)sender).Name, "Contraseña incorrecta. Verifique información.");
								msg.XARCHEscribirArchivoLog(ClaseGeneral.RutaNombreArchivoLog);
								"La contraseña es incorrecta".XMensajeError();
							}

						}
					}
				}
			}
			catch (Exception ex)
			{
				string msg = string.Format("{0};{1};{2};{3};{4};{5};{6}", ClaseGeneral.IP, ClaseGeneral.NombreEquipo, DateTime.Now, "pa_login_sel", this.Name, ((System.Windows.Forms.Control)sender).Name, ex.Message);
				msg.XARCHEscribirArchivoLog(ClaseGeneral.RutaNombreArchivoLog);
			}
			finally
			{
				Cursor = Cursors.Default;
			}
		}

		private void labelBD_Click(object sender, EventArgs e)
		{
			labelBD.Text = labelBD.Text == "Producción" ? "Desarrollo" : "Producción";
			this.BackColor = labelBD.Text == "Producción" ? coColor : Color.Green;
			string strbd = labelBD.Text == "Producción" ? "" : "Desarrollo";
			this.Text = "Sistema de control dosimetro " + strbd;
			//Clases.clsBD.BD = labelBD.Text == "Producción" ? "Prod1" : "Desarrollo";
			Clases.clsBD.BD = labelBD.Text == "Producción" ? Clases.clsBD.strConexionProd : Clases.clsBD.strConexionDes;
		}
		private void tsbEnviarLog_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			ClaseGeneral.MensajeAdministradorCorreo.XCORREOEnviarCorreoAdministrador();
			Cursor = Cursors.Default;
		}

		#endregion


	}
}
