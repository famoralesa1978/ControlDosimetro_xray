using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dllConectorMysql;
using dllLibreriaEvento;
using dllLibreriaMysql;
using System.Data.SqlClient;
using System.Data.Sql;
using Microsoft.Reporting.WinForms;
using System.Net.Mime;
using System.Net;
using System.Net.Mail;

namespace ControlDosimetro
{
    public partial class frmEnvioCorreos : Form
    {

        #region "Definicion variable"
				clsConectorSqlServer Conectar = new clsConectorSqlServer();
				clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
            clsEventoControl ClaseEvento = new clsEventoControl();
            dllLibreriaMysql.clsUtiles clsUtiles1 = new dllLibreriaMysql.clsUtiles();
        private int intContar=0;
      
        public frmEnvioCorreos(int intId_Cliente)
        {
            InitializeComponent();
            intContar = 0;
        }
        #endregion
        #region "Llamada de carga"

        private void Cargar_Cliente(Int64 intCodCliente)
				{
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "select run,Razon_Social,N_Cliente_Ref,region + ','+ comuna +','+Direccion as Direccion ,r.Id_Region,c.Id_Provincia,c.Id_Comuna,Telefono, Id_TipoFuente,Id_estado,Fechainicio " +
                            "  FROM tbl_cliente c inner join [dbo].[glo_region] r on c.Id_Region=r.Id_Region inner join glo_comuna co on co.id_comuna=c.id_comuna" +
                            " WHERE Id_cliente= " + intCodCliente.ToString()
            };
            DataSet dt;

					dt = Conectar.Listar(cmd);
                    if (dt.Tables[0].Rows.Count > 0)
                    {
                        lbl_id_cliente.Text = intCodCliente.ToString();
                      //  lbl_nombreCliente.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
                       // lbl_Direccion.Text = dt.Tables[0].Rows[0]["Direccion"].ToString();
                        btn_cargar.Enabled = true; 
                       // btn_Cargar_cliente.Enabled = false;
                        lbl_id_cliente.Enabled = false;
                        
                    }
                    else
                    {
                    //    btn_Cargar_cliente.Enabled = true;
                        btn_cargar.Enabled = false;
                        lbl_id_cliente.Enabled = true;
                      //  lbl_nombreCliente.Text = "";
                       // lbl_Direccion.Text = "";
                    }

					

                    //
				}

        private void AsignarEvento()
        {     
				
        }

        #endregion

        #region "button"

		  private void BtnIngresarDosisISP_Click(object sender, EventArgs e)
		  {
              frmDosimetriaISP frm = new frmDosimetriaISP(Convert.ToInt64(lbl_id_cliente.Text));
			  frm.ShowDialog(this);
		  }

		  private void Btn_Filtro_Click(object sender, EventArgs e)
		  {
		  }

		  private void Btn_cargar_Click(object sender, EventArgs e)
		  {
              if (lbl_id_cliente.Text.ToString().Trim() != "")
              {
                //Listar_Grilla();

                intContar = 0;
              }
             
			            
		  }

		 private void Btn_filtro_Click_1(object sender, EventArgs e)
		 {
			
             Cargar_Cliente(0);
             lbl_id_cliente.Text = "0";
         //    Listar_Grilla();
             lbl_id_cliente.Text = "";
          //   btn_Cargar_cliente.Enabled = true;
             lbl_id_cliente.Enabled = true;
            intContar = 0;
		 }

		 private void Btn_Cerrar_Click(object sender, EventArgs e)
		 {
			 this.Close();
		 }

         private void TsmEliminar_Click(object sender, EventArgs e)
         {
         }
      
        #endregion

		  #region "combobox"
		

		  #endregion

		  #region "grilla"

        #endregion

         private void Btn_Imprimir_Click(object sender, EventArgs e)
         {

             DataSet dt;
             dt = RptSobre(Convert.ToInt64(lbl_id_cliente.Text));

             frmreporte frm = new frmreporte(dt, dt, 2);
             frm.Show(this);             
         }

         private void FrmIngresoPelicula_Load(object sender, EventArgs e)
         {

         }

         public DataSet RptSobre(Int64 id_cliente)
         {
             DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand
            {
                // SqlCommand cmd = new SqlCommand();
                //MessageBox.Show("Conectado al servidor");

                CommandText = "rtpSobre " + id_cliente.ToString(),

                //"SELECT * FROM " +tabla.Name.ToString();// WHERE TABLE_SCHEMA = 'bd_sistema' AND "// +
                // "TABLE_NAME = '" + tabla.Name.ToString()    + "'";
                CommandType = CommandType.Text
            };

            ds = Conectar.Listar(cmd);
             return ds;
         }


         private void Btn_IngresoDosimetro_Click(object sender, EventArgs e)
         {
             frmDosimetriaPersonal frm = new frmDosimetriaPersonal(Convert.ToInt64(lbl_id_cliente.Text.ToString()));
             frm.Show();
           //  Listar_Grilla();
         }
         private void Btn_Cargar_cliente_Click(object sender, EventArgs e)
         {
             Cargar_Cliente(Convert.ToInt64(lbl_id_cliente.Text));
         }

         private void BtnEnviarCorreo_Click(object sender, EventArgs e)
         {
             if (txtNombre.Text == "")
                 MessageBox.Show("Ingrese el nombre de la persona que envia el correo");
             if (txtCorreo.Text == "")
                 MessageBox.Show("Ingrese el correo de destino");
             else
             {
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "select Desde,Credencial,Clave,Host,Port from conf_Correo"
                };
                DataSet dt;

					dt = Conectar.Listar(cmd);
                    if (dt.Tables[0].Rows.Count > 0)
                    {
                        clsUtiles1.SendMailGmail(rtbCuerpo, txtNombre.Text, txtAsunto.Text, txtCorreo.Text, listBox2, dt.Tables[0].Rows[0]["Desde"].ToString(),
                                dt.Tables[0].Rows[0]["Credencial"].ToString(), dt.Tables[0].Rows[0]["Clave"].ToString(), dt.Tables[0].Rows[0]["Host"].ToString(),
                                Convert.ToInt16( dt.Tables[0].Rows[0]["Port"].ToString()));
                    }
             }
         }

         private void BtnNegrita_Click(object sender, EventArgs e)
         {
             System.Drawing.FontStyle newFontStyle;
             System.Drawing.Font currentFont = rtbCuerpo.SelectionFont;
             if (btnNegrita.Checked == true)
             {
                 newFontStyle = FontStyle.Regular;
             }
             else
             {
                 newFontStyle = FontStyle.Bold;
             }
         rtbCuerpo.SelectionFont = new Font(
         currentFont.FontFamily, 
         currentFont.Size, 
         newFontStyle
      );
         }

         private void BtnTipoLetra_Click(object sender, EventArgs e)
         {
             if (fdgLetra.ShowDialog()  == DialogResult.OK)
             {                
                 Font font = fdgLetra.Font;
                 // Set TextBox properties.
                 this.rtbCuerpo.SelectionFont = font;
             }
         }

         private void Btn_ColorLetra_Click(object sender, EventArgs e)
         {
             if (colorDialog1.ShowDialog() == DialogResult.OK)
             {
                 //Font font = fdgLetra.Font;
                 // Set TextBox properties.
                 this.rtbCuerpo.SelectionColor = colorDialog1.Color;
             }
         }

         public string ConvertToHTML(RichTextBox Box)
         {
             // Takes a RichTextBox control and returns a
             // simple HTML-formatted version of its contents
             string strHTML;
             string strColour;
             bool blnBold;
             bool blnItalic;
             string strFont;
             strFont = "";
             short shtSize;
       //      int lngOriginalStart=0;
             int lngOriginalLength;
             int intCount;
             strColour = "";
             blnBold = false;
             blnItalic = false;
             shtSize = 1;
             strHTML = "";
             // If nothing in the box, exit
             if (Box.Text.Length == 0) return strHTML;
             // Store original selections, then select first character
        //     lngOriginalStart = 0;
             lngOriginalLength = Box.TextLength;
             Box.Select(0, 1);
             // Add HTML header
             strHTML = "<html><body>";
             // Set up initial parameters
             strColour = Box.SelectionColor.ToKnownColor().ToString();
             blnBold = Box.SelectionFont.Bold;
             blnItalic = Box.SelectionFont.Italic;
             strFont = Box.SelectionFont.FontFamily.Name;
             shtSize = Convert.ToInt16( Box.SelectionFont.Size);
             // Include first 'style' parameters in the HTML
             strHTML += "<span style=\"font-family: " + strFont + "; font-size: " + shtSize + "pt; color: " + strColour + "\">";
             // Include bold tag, if required
             if (blnBold == true)
             {
                 strHTML += "<b>";
             }
             // Include italic tag, if required
             if (blnItalic == true)
             {
                 strHTML += "<i>";
             }
             // Finally, add our first character
             strHTML += Box.Text.Substring(0, 1);
             // Loop around all remaining characters
             for (intCount = 2; intCount <= Box.Text.Length; intCount++)
             {
                 // Select current character
                 Box.Select(intCount - 1, 1);
                 // If this is a line break, add HTML tag
                 if (Convert.ToChar(Box.Text.Substring(intCount - 1, 1)) == Convert.ToChar(10))
                 {
                     strHTML += "<br>";
                 }
                 // Check/implement any changes in style
                 if (Box.SelectionColor.ToKnownColor().ToString() != strColour | Box.SelectionFont.FontFamily.Name != strFont | Box.SelectionFont.Size != shtSize)
                 {
                     strHTML += "</span><span style=\"font-family: " + Box.SelectionFont.FontFamily.Name + "; font-size: " + Box.SelectionFont.Size + "pt; color: " + Box.SelectionColor.ToKnownColor().ToString()   + "\">";
                 }
                 // Check for bold changes
                 if (Box.SelectionFont.Bold != blnBold)
                 {
                     if (Box.SelectionFont.Bold == false)
                     {
                         strHTML += "</b>";
                     }
                     else
                     {
                         strHTML += "<b>";
                     }
                 }
                 // Check for italic changes
                 if (Box.SelectionFont.Italic != blnItalic)
                 {
                     if (Box.SelectionFont.Italic == false)
                     {
                         strHTML += "</i>";
                     }
                     else
                     {
                         strHTML += "<i>";
                     }
                 }
                 // Add the actual character
                 strHTML += Box.Text.Substring(1, intCount-1);
                 // strHTML += Box.Text.Substring(intCount, 1);
                 // Update variables with current style
                  strColour = Box.SelectionColor.ToKnownColor().ToString();
                 blnBold = false;// Box.SelectionFont;
                 blnItalic = Box.SelectionFont.Italic;
                  strFont = Box.SelectionFont.FontFamily.Name;
                  shtSize = Convert.ToInt16( Box.SelectionFont.Size);
             }
             // Close off any open bold/italic tags
             if (blnBold == true) strHTML += "";
             if (blnItalic == true) strHTML += "";
             
             return strHTML;
         }

         private void BtnAdjuntarArchivo_Click(object sender, EventArgs e)
         {
             string archivo;
             archivo = "";
             //openFileDialog1.ShowDialog();
             if (openFileDialog1.ShowDialog() == DialogResult.OK)
             {
                 archivo = openFileDialog1.SafeFileName;
                 listBox1.Items.Add(archivo);
                 listBox2.Items.Add(openFileDialog1.FileName);
                 listBox1.ContextMenuStrip.Enabled = true;
             }

         }

         private void Btn_EliminarSeleccion_Click(object sender, EventArgs e)
         {
             if (listBox1.Items.Count != 0)
             {
                 listBox2.Items.RemoveAt(listBox1.SelectedIndex);
                 listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                 if (listBox1.Items.Count == 0)
                     listBox1.ContextMenuStrip.Enabled = false;
                 else
                     listBox1.ContextMenuStrip.Enabled = true;
             }
             else
             {
                 listBox1.ContextMenuStrip.Enabled = false;
             }

         }

    }
}
