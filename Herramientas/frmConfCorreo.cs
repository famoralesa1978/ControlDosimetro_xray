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
namespace ControlDosimetro
{
	public partial class FrmConfCorreo : Form
	{
		#region "Definicion variable"
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();
		dllLibreriaMysql.clsUtiles clsUtiles1 = new dllLibreriaMysql.clsUtiles();
		#endregion


		public FrmConfCorreo()
		{
			InitializeComponent();
			AsignarEvento();
			Cargar_Departamento();
			Cargar();
		}

		#region "Llamada de carga"  

		private void Cargar_Departamento()
		{
			ClaseComun.Listar_Parametro(Clases.clsBD.BD, ref cbx_Id_Depto, 19);
		}

		private void Cargar()
		{
			SqlCommand cmd = new SqlCommand
			{
				CommandText = "  SELECT [Desde] , [Credencial],[Clave],[Host],[Port]  FROM [dbo].[conf_Correo]"
			};
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			txt_Desde.Text = dt.Tables[0].Rows[0]["Desde"].ToString();
			txt_Host.Text = dt.Tables[0].Rows[0]["Host"].ToString();
			txt_Port.Text = dt.Tables[0].Rows[0]["Port"].ToString();
			txt_Credencial.Text = dt.Tables[0].Rows[0]["Credencial"].ToString();
			txt_Clave.Text = dt.Tables[0].Rows[0]["Clave"].ToString();
			try
			{
				txt_Clave1.Text = clsUtiles1.DecryptTripleDES(dt.Tables[0].Rows[0]["Clave"].ToString());
			}
			catch (Exception)
			{

				txt_Clave1.Text = clsUtiles1.GenerateHashMD5(dt.Tables[0].Rows[0]["Clave"].ToString());
				txt_Clave.Text = dt.Tables[0].Rows[0]["Clave"].ToString();
			}


		}
		private void AsignarEvento()
		{
			txt_Credencial.Validated += new EventHandler(ClaseEvento.validaEmail_Validated);
			txt_Desde.Validated += new EventHandler(ClaseEvento.validaEmail_Validated);
			txt_Para.Validated += new EventHandler(ClaseEvento.validaEmail_Validated);
		}

		private void HabDesa_Controles(bool bolHabDesa)
		{
			txt_Host.Enabled = true;
			txt_Port.Enabled = true;
			txt_Desde.Enabled = true;
			txt_Clave.Enabled = bolHabDesa;
			txt_Clave1.Enabled = bolHabDesa;
			txt_Credencial.Enabled = bolHabDesa;
		}

		#endregion

		#region "button"

		private void Btn_cerrar_Click(object sender, EventArgs e)
		{
			Verificar_Grabado();
			this.Close();
		}

		private void Btn_Grabar_Click(object sender, EventArgs e)
		{
			Boolean bolResult;
			bolResult = false;

			ClaseComun.Modificar(Clases.clsBD.BD, conf_Correo, ref bolResult);
			if (bolResult == true)
			{

				MessageBox.Show("Dato modificado");
			}
		}

		private void btn_EnviarCorreo_Click(object sender, EventArgs e)
		{
			if (txt_Para.Text.Trim().Length > 0)
			{
				ListBox lb = new ListBox();
				RichTextBox rtb = new RichTextBox
				{
					Text = "Prueba envio de correo"
				};
				clsUtiles1.SendMailGmail(rtb, "Usuario prueba", "correo prueba", txt_Para.Text, lb, txt_Desde.Text,
														txt_Credencial.Text, txt_Clave.Text, txt_Host.Text, Convert.ToInt16(txt_Port.Text));
			}
			else
				MessageBox.Show("Debe digitar un email");
		}
		void Verificar_Grabado()
		{
			if (btn_Grabar.Enabled == true)
			{
				if (txt_Desde.Text != "" || txt_Host.Text != "" || txt_Port.Text != "")
				{
					if (MessageBox.Show("Desea grabar la información", "Confirmar", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
						btn_Grabar.PerformClick();
				}
			}

		}
		#endregion

		#region "TextBox"

		private void Txt_Contraseña1_TextChanged(object sender, EventArgs e)
		{
			txt_Clave.Text = clsUtiles1.GenerateHashMD5(txt_Clave1.Text);
		}

		#endregion


	}
}
