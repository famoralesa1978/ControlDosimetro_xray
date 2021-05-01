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


namespace ControlDosimetro
{
    public partial class frmLogin : Form
    {
        #region "Definicion variable"
        clsConectorSqlServer Conectar = new clsConectorSqlServer();
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
            Clases.clsBD.BD = "Prod1";
            if (Clases.clsBD.BD == "Desarrollo")
            {
                this.BackColor = Color.Green;
                this.Text = this.Text + " Desarrollo";
            }
                
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
                //throw new ArgumentException("Prueba forzando error");
                if (txt_Usuario.Text.Trim() == "" || txt_Contrasena.Text.Trim() == "")
                    MessageBox.Show("Debe contener usuario y contraseña");
                else
                {
                    Cursor = Cursors.WaitCursor;
                    string Clave = clsUtiles1.GenerateHashMD5(txt_Contrasena.Text.Trim());
                    //pa_login_sel 
                    SqlCommand cmd = new SqlCommand();
                    DataSet ds; // = new DataSet();
                    cmd.CommandText = "pa_login_sel '" + txt_Usuario.Text.Trim() + "','" + Clave + "'";
                    cmd.CommandType = CommandType.Text;

                    ds = Conectar.Listar(Clases.clsBD.BD, cmd);

                    if (ds.Tables[0].Rows.Count == 0)
                        MessageBox.Show("El usuario no existe");
                    else
                    {
                        if (ds.Tables[0].Rows[0]["Contraseña"].ToString() == Clave)
                            if (ds.Tables[0].Rows[0]["Id_estado"].ToString() == "1")
                            {
                                Clases.clsUsuario.Usuario = ds.Tables[0].Rows[0]["Usuario"].ToString();
                                Clases.clsUsuario.Nombre = ds.Tables[0].Rows[0]["Nombres"].ToString() + " " + ds.Tables[0].Rows[0]["Paterno"].ToString() + " " + ds.Tables[0].Rows[0]["Maternos"].ToString();
                                Clases.clsUsuario.Id_Usuario = Convert.ToInt16(ds.Tables[0].Rows[0]["Id_Usuario"].ToString());
                                Clases.clsUsuario.Id_perfil = Convert.ToInt16(ds.Tables[0].Rows[0]["Id_perfil"].ToString());
                                Clases.clsUsuario.Contraseña = ds.Tables[0].Rows[0]["contraseña"].ToString();

                                this.Close();
                            }
                            else
                                MessageBox.Show("El usuario se encuentra desactivado");
                        else
                            MessageBox.Show("La contraseña es incorrecta");
                    }
                    Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                new Clases.ClassErrores(ex, 0, txt_Usuario.Text, String.Format("Versión {0}", AssemblyVersion));
            }
            finally
            {
                Cursor = Cursors.Default;
                classFuncionesGenerales.mensajes.MensajeAdvertencia("Se ha producido un error. Inténtelo nuevamente.");
            }
        }

        private void labelBD_Click(object sender, EventArgs e)
        {
            labelBD.Text = labelBD.Text == "Producción" ? "Desarrollo" : "Producción";
            this.BackColor = labelBD.Text == "Producción" ? coColor : Color.Green;
            string strbd= labelBD.Text == "Producción" ? "" : "Desarrollo";
            this.Text = "Sistema de control dosimetro " + strbd;
            Clases.clsBD.BD = labelBD.Text == "Producción" ? "Prod1" : "Desarrollo";
        }

        #endregion
    }
}
