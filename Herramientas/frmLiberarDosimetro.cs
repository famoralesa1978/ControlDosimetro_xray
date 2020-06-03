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
using classFuncionesBD;

namespace ControlDosimetro
{
    public partial class frmLiberarDosimetro : Form
    {

        #region "Definicion variable"
				clsConectorSqlServer Conectar = new clsConectorSqlServer();
				clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
            clsEventoControl ClaseEvento = new clsEventoControl();
        clsUtiles clsUtiles1 = new dllLibreriaMysql.clsUtiles();
        clsFunciones clsFunc = new clsFunciones();
        #endregion

        public frmLiberarDosimetro()
        {
            InitializeComponent();
            AsignarEvento();
        }

        #region "Llamada de carga"      
   
        private void AsignarEvento()
        {
            txt_NDoc.KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
            txt_NDoc.KeyDown += new KeyEventHandler(ClaseEvento.Numero_KeyDown);
            txt_NDos.KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
            txt_NDos.KeyDown += new KeyEventHandler(ClaseEvento.Numero_KeyDown);
        }

        #endregion

        #region "button"


		 private void Btn_Cerrar_Click(object sender, EventArgs e)
		 {
			 this.Close();
		 }

      
        #endregion

		  #region "combobox"
		

		  #endregion

		  #region "grilla"

        #endregion
           
         private void Btn_Guardar_Click(object sender, EventArgs e)
         {
            if((txt_NDoc.Text=="")&&(txt_NDos.Text==""))
                MessageBox.Show("Todos los campos son obligatorios");
            else
             if (MessageBox.Show("Esta seguro de  estado?" , "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
             {
                string strMensaje = "";
                int intResul = clsFunc.CambiarEstado(txt_NDoc.Text, txt_NDos.Text, ref strMensaje);
               /* SqlCommand cmd = new SqlCommand();
                DataSet ds;

                cmd.CommandText = "pa_CambiarEstado_upd " + txt_NDoc.Text + "," + txt_NDos.Text;
                cmd.CommandType = CommandType.Text;
                ds = Conectar.Listar(Clases.clsBD.BD,cmd);
                */
                MessageBox.Show(strMensaje);   
            }
        }

         private void Btn_filtro_Click(object sender, EventArgs e)
         {
            txt_NDoc.Clear();
            txt_NDoc.Clear();
         }

    }
}
