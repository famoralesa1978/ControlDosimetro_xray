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
using OpenXmlPowerTools;

namespace ControlDosimetro
{
	public partial class frmModuloIniciarProcesoTLD : Form
	{

		#region "Definicion variable"
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();
		//   int intContar=0;
		int intintId_Estado_temp;
		#endregion

		public frmModuloIniciarProcesoTLD(int intId_Estado)
		{
			InitializeComponent();

			AsignarEvento();
			intintId_Estado_temp = intId_Estado;
			switch (intintId_Estado_temp)
			{
				case 0:
					this.Text = "Envio Dosimetros";
					break;
				case 1:
					this.Text = "Recepción Dosimetros";
					break;
				case 2:
					this.Text = "Iniciar Proceso de Lectura";
					break;
				case 6:
					this.Text = "Informe Generado";
					break;
			}
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "pa_Log_usuario_ins '" + Clases.clsUsuario.Usuario + "',' " + this.Text + "'";
			cmd.CommandType = CommandType.Text;
			Conectar.AgregarModificarEliminar(ClaseGeneral.Conexion, cmd);
			txt_TLD.Focus();
			LimpiarPantalla();
			Listar_Grilla();
			VerificaSihayProcesoIniciado();
			//  btn_Guardar.Enabled = false;
			// btnIniciar.Enabled = false;
		}

		#region "Llamada de carga"

		private void LimpiarPantalla()
		{
			lbl_NCliente.Text = "";
			lbl_NombreCliente.Text = "";
			lbl_Periodo.Text = "";
			lbl_TLD.Text = "";
			nudPosicion.Value = 1;
			lbl_NombrePersonal.Text = "";
			btn_Guardar.Visible = false;
			btn_Guardar.Enabled = false;
		}

		private void Cargar_TLD(int intTld)
		{
			try
			{
				SqlCommand cmd = new SqlCommand();
				cmd.CommandText = "pa_ListadoDatosTLD ";
				cmd.Parameters.Clear();
				cmd.Parameters.Add("@id_estadodosimetro", SqlDbType.Int);
				cmd.Parameters["@id_estadodosimetro"].Value = intintId_Estado_temp;
				cmd.Parameters.Add("@n_dosimetro", SqlDbType.Int);
				cmd.Parameters["@n_dosimetro"].Value = intTld;
				cmd.CommandType = CommandType.StoredProcedure;

				string strSp = cmd.XSQLObtieneDatosParametro();

				DataSet ds;

				ds = Conectar.Listar(ClaseGeneral.Conexion, cmd);
				if (ds != null)
				{
					if (ds.Tables[0].Rows.Count > 0)
					{
						lbl_NCliente.Text = ds.Tables[0].Rows[0]["id_cliente"].ToString();
						lbl_NombreCliente.Text = ds.Tables[0].Rows[0]["razon_social"].ToString();
						lbl_Periodo.Text = ds.Tables[0].Rows[0]["tri"].ToString();
						lbl_TLD.Text = ds.Tables[0].Rows[0]["n_dosimetro"].ToString();
						nudPosicion.Value = Convert.ToInt32(ds.Tables[0].Rows[0]["PosDisco"].ToString());
						lbl_NombrePersonal.Text = ds.Tables[0].Rows[0]["nombrecompleto"].ToString();
						dtpFechaLectura.Value = (DateTime)ds.Tables[0].Rows[0]["FechaLectura"];
						btn_Guardar.Visible = true;
						txt_TLD.Text = "";
						txtHasta.Text = "";
						btn_Guardar.Enabled = true;
					}
					else
					{
						LimpiarPantalla();
						txt_TLD.Text = "";
						txtHasta.Text = "";
						btn_Guardar.Enabled = false;
						MessageBox.Show("No se puede ingresar a este proceso, verifique en que estado se encuentra.");
					}
				}
				else
				{
					string msg = string.Format("{0};{1};{2};{3};{4};{5};{6}", ClaseGeneral.IP, ClaseGeneral.NombreEquipo, DateTime.Now, strSp, this.Name, "Cargar_TLD", "Error cargar la información.");
					msg.XARCHEscribirArchivoLog(ClaseGeneral.RutaNombreArchivoLog);
					"Error cargar la información.".XMensajeError();
				}
			}
			catch (Exception ex)
			{
				string msg = string.Format("{0};{1};{2};{3};{4};{5};{6}", ClaseGeneral.IP, ClaseGeneral.NombreEquipo, DateTime.Now, "pa_login_sel", this.Name, "Cargar_TLD", ex.Message);
				msg.XARCHEscribirArchivoLog(ClaseGeneral.RutaNombreArchivoLog);
			}
			finally
			{
				Cursor = Cursors.Default;
			}
			

		}

		private void VerificaSihayProcesoIniciado()
		{
			SqlCommand cmd = new SqlCommand();

			DataSet dt;


			cmd.CommandText = "SELECT id_estadodosimetro FROM [dbo].[ges_dosimetro_estado_TLD] where id_estadodosimetro=12";
			cmd.CommandType = CommandType.Text;

			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

			if (dt.Tables[0].Rows.Count > 0)
			{
				btn_Guardar.Visible = false;
		//		btnIniciar.Visible = false;
				//MessageBox.Show("No se puede agregar mas TLD, el motivo es por que el proceso de lectura se inicio \n y no se terminado de registrar las dosis en el proceso anterior");
			}
			else
			{
				btn_Guardar.Visible = true;
				btnIniciar.Visible = true;
			}

			//--verifica que no puede ingresarantes de 45 minutos
			//SELECT fecha_mod  
			//    ,DATEADD(minute,45,fecha_mod) mas45
			//FROM [dbo].[ges_dosimetro_estado_TLD]
			//where
			// getdate()< DATEADD(minute,45,fecha_mod) and id_estadodosimetro=12
		}


		private void Listar_Grilla()
		{
			SqlCommand cmd = new SqlCommand();

			DataSet dt;
			cmd.CommandText = "pa_ListadoPorDosimetroPorIniciarTLD";
			cmd.CommandType = CommandType.Text;

			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);
			grdDatos.DataSource = dt.Tables[0];
			btnIniciar.Enabled = grdDatos.RowCount > 0 ? true : false;
		}


		private void AsignarEvento()
		{

			Clases.ClassEvento Evt = new Clases.ClassEvento();
			Evt.AsignarNumero(ref txt_TLD);
			Evt.AsignarNumero(ref txtHasta);

			nudPosicion.Minimum = 1;
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "SELECT Glosa FROM conf_detparametro WHERE Id_Parametro=9";
			//cmd.CommandText = "SELECT Id_Periodo,Anno, Mes,Id_TipoPeriodo FROM conf_periodo WHERE Id_TipoPeriodo=3";
			DataSet dt;
			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);
			nudPosicion.Maximum = Convert.ToInt32(dt.Tables[0].Rows[0][0].ToString());

		}

		#endregion

		#region "button"

		private void btn_Cerrar_Click_1(object sender, EventArgs e)
		{
			//  verificar_Grabado();
			this.Close();
		}

		private void btn_Guardar_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "pa_DosimetroRecepcionProcesoTLD_upd";
			cmd.Parameters.Clear();
			cmd.Parameters.Add("@n_dosimetro", SqlDbType.Int);
			cmd.Parameters["@n_dosimetro"].Value = lbl_TLD.Text;
			cmd.Parameters.Add("@id_estado", SqlDbType.Int);
			cmd.Parameters["@id_estado"].Value = intintId_Estado_temp;
			cmd.Parameters.Add("@usuario", SqlDbType.VarChar,30);
			cmd.Parameters["@usuario"].Value = Clases.clsUsuario.Usuario;
			cmd.Parameters.Add("@PosicionDisco", SqlDbType.Int);
			cmd.Parameters["@PosicionDisco"].Value = nudPosicion.Value;
			cmd.Parameters.Add("@FechaLectura", SqlDbType.Date);
			cmd.Parameters["@FechaLectura"].Value = dtpFechaLectura.Value;
			cmd.CommandType = CommandType.StoredProcedure;
			Conectar.AgregarModificarEliminar(ClaseGeneral.Conexion, cmd);
			LimpiarPantalla();
			Listar_Grilla();
		}

		private void BtnCancelar_Click(object sender, EventArgs e)
		{
			LimpiarPantalla();
		}

		private void btnIniciar_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "pa_DosimetroIniciarProcesoTLD_upd 4,'" + Clases.clsUsuario.Usuario + "'";
			cmd.CommandType = CommandType.Text;
			Conectar.AgregarModificarEliminar(ClaseGeneral.Conexion, cmd);
			LimpiarPantalla();
			Listar_Grilla();

			//MessageBox.Show("Se ha iniciado el proceso de lectura, espere 45 minutos para agregar nuevo proceso");
		}



		private void btn_cargar_Click(object sender, EventArgs e)
		{
			if (rbtSolo.Checked && ValidarSoloUno() == false)
			{
				btn_Guardar.Enabled = true;
				Cargar_TLD(Convert.ToInt32(txt_TLD.Text));
			}
			else if (rbtVarios.Checked && ValidarVarios() == false)
			{
				btn_Guardar.Enabled = false;
				for (int intTLD = Convert.ToInt32(txt_TLD.Text); intTLD <= Convert.ToInt32(txtHasta.Text); intTLD++){
					nudPosicion.Value = 1;
					Cargar_TLD(intTLD);
					btn_Guardar_Click(null, null);
					nudPosicion.Value = nudPosicion.Value + 2;
				}
					
			}

		}

		private bool ValidarSoloUno()
		{
			bool bolValidar = false;

			if (String.IsNullOrEmpty(txt_TLD.Text))
			{
				bolValidar = true;
				classFuncionesGenerales.mensajes.MensajeError("Debe ingresar un  número");
			}


			return bolValidar;
		}

		private bool ValidarVarios()
		{
			bool bolValidar = false;

			if (String.IsNullOrEmpty(txt_TLD.Text) && String.IsNullOrEmpty(txtHasta.Text))
			{
				classFuncionesGenerales.mensajes.MensajeError("Debe ingresar un  número");
				bolValidar = true;
			}
			else
			{
				if (Convert.ToInt32(txt_TLD.Text) > Convert.ToInt32(txtHasta.Text))
				{
					bolValidar = true;
					classFuncionesGenerales.mensajes.MensajeError("El número hasta debe ser mayor que el desde(TLD)");
				}
			}


			return bolValidar;
		}

		private void btn_filtro_Click_1(object sender, EventArgs e)
		{
			//cbx_anno.Enabled = true;
			//cbx_id_periodo.Enabled = true;
			//txt_TLD.Text = "";
			//txt_TLD.Enabled = true;             
			//txt_TLD.Text = "0";             
			//Listar_Grilla();
			//chk_marcar.Checked = false;
			//txt_TLD.Text = "";
			//txt_TLD.Focus();
			//intContar = 0;
		}

		private void btn_Cerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		#endregion

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}


		#region "combobox"

		#endregion

		#region "grilla"

		#endregion

		private void rbtSolo_CheckedChanged(object sender, EventArgs e)
		{
			if (rbtSolo.Checked == true)
			{
				lblHasta.Visible = false;
				txtHasta.Visible = false;
			}
			else
			{
				lblHasta.Visible = true;
				txtHasta.Visible = true;
			}
		}
	}
}
