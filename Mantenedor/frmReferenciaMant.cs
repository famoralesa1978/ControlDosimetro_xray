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
	public partial class frmReferenciaMant : Form
	{
		#region "Definicion variable"
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();
		String strRun;
		#endregion


		public frmReferenciaMant(Int64 intCodigo, string idCliente,String Run)
		{
			InitializeComponent();

			lbl_Id_Cliente.Text = idCliente;
			strRun = Run;
			AsignarEvento();
			Cargar_Cliente();
			Cargar_Estado();

			if (intCodigo == 0)
			{
				btn_Grabar.Text = "Grabar";
				this.Text = "Agregar Referencia";
				//cargar_valor_maximo();
				//
			}
			else
			{
				btn_Grabar.Text = "Modificar";
				this.Text = "Modificar Referencia";
				txt_id_referencia.Text = intCodigo.ToString();

				//SqlCommand cmd = new SqlCommand();
				SqlCommand cmd = new SqlCommand();

				cmd.CommandText = string.Format("SELECT encargado,fono,email,id_estado  FROM tbl_encargado WHERE Id_referencia= {0} and (run='{1}' or run is null)" ,
													intCodigo.ToString(), strRun);
				DataSet dt;
				dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

				//txt_run.Text = dt.Tables[0].Rows[0]["run"].ToString();
				txt_Encargado.Text = dt.Tables[0].Rows[0]["encargado"].ToString();
				txt_Email.Text = dt.Tables[0].Rows[0]["email"].ToString();
				txt_Fono.Text = dt.Tables[0].Rows[0]["fono"].ToString();
				cbx_id_Estado.SelectedValue = dt.Tables[0].Rows[0]["id_estado"].ToString();
			}
		}

		#region "Llamada de carga"


		private void Cargar_Estado()
		{
			ClaseComun.Listar_Estado(ClaseGeneral.Conexion, ref cbx_id_Estado, ref cbx_id_Estado);
		}

		private void Cargar_Cliente()
		{
			SqlCommand cmd = new SqlCommand();

			//  SqlCommand cmd = new SqlCommand();

			cmd.CommandText = "SELECT run,Razon_Social,Direccion,Id_Region,Id_Provincia,Id_Comuna,Telefono, Id_TipoFuente " +
									" FROM tbl_cliente WHERE Id_cliente= " + lbl_Id_Cliente.Text.ToString();
			DataSet dt;
			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

			lbl_nombre.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
		}

		private void AsignarEvento()
		{
			SqlCommand cmd = new SqlCommand();

			//	  SqlCommand cmd = new SqlCommand();
			DataSet dt;
			string strname;
			foreach (Control c in tbl_encargado.Controls)
			{
				//foreach (Control childc in c.Controls)
				//{
				if (c is TextBox)
				{

					strname = ((TextBox)c).Name;

					cmd.CommandText = "SELECT  requerido, validacion " +
							" FROM glo_configuracioncampo WHERE campo= '" + strname.Replace("txt_", "") + "'";

					dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);
					if (dt.Tables[0].Rows.Count == 0)
						((TextBox)c).KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);
					else
					{
						if (dt.Tables[0].Rows[0]["validacion"].ToString() == "rut")
						{
							((TextBox)c).KeyPress += new KeyPressEventHandler(ClaseEvento.Rut_KeyPress);
							((TextBox)c).KeyDown += new KeyEventHandler(ClaseEvento.Rut_KeyDown);
							((TextBox)c).Validated += new EventHandler(ClaseEvento.validarut_Validated);
						}
						if (dt.Tables[0].Rows[0]["validacion"].ToString() == "numerico")
						{
							((TextBox)c).KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
							((TextBox)c).KeyDown += new KeyEventHandler(ClaseEvento.Numero_KeyDown);
						}
						if (dt.Tables[0].Rows[0]["validacion"].ToString() == "Email")
						{
							((TextBox)c).Validated += new EventHandler(ClaseEvento.validaEmail_Validated);
							((TextBox)c).KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);
						}
					}
				}
				if (c is ComboBox)
					((ComboBox)c).KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);
				if (c is DateTimePicker)
					((DateTimePicker)c).KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);

			}

		}

		#endregion
		#region "button"

		private void btn_cerrar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			this.Close();

			Cursor = Cursors.Default;
		}

		private void btn_Grabar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			SqlCommand cmd = new SqlCommand();
			Boolean bolResult;
			bolResult = false;
			if (MessageBox.Show("Desea grabar la información", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
			{
				if (btn_Grabar.Text == "Modificar")
				{
					cmd.CommandText = String.Format("pa_Referecia_upd {0},{1},'{2}','{3}','{4}',{5},'{6}'",
										txt_id_referencia.Text,lbl_Id_Cliente.Text, txt_Encargado.Text, txt_Fono.Text, txt_Email.Text, cbx_id_Estado.SelectedValue,strRun);
					cmd.CommandType = CommandType.Text;
					Conectar.AgregarModificarEliminar(ClaseGeneral.Conexion, cmd);

					//if (bolResult == true)
					//{
						MessageBox.Show("Dato Modificado");
						this.Close();
					//}
				}
				else
				{
					cmd.CommandText = String.Format("pa_Referecia_ins {0},'{1}','{2}','{3}',{4},'{5}'",
											lbl_Id_Cliente.Text, txt_Encargado.Text, txt_Fono.Text, txt_Email.Text, cbx_id_Estado.SelectedValue, strRun);
					cmd.CommandType = CommandType.Text;
					Conectar.AgregarModificarEliminar(ClaseGeneral.Conexion, cmd);
					//if (bolResult == true)
					//{
					MessageBox.Show("Dato Guardado");
						this.Close();
				//	}

				}
			}

			Cursor = Cursors.Default;
		}

		#endregion

		#region "combobox"


		#endregion



	}
}
