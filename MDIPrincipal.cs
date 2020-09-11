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
	public partial class MDIPrincipal : Form
	{
		#region "Definicion variable"

		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();

		dllLibreriaMysql.clsUtiles clsUtiles1 = new dllLibreriaMysql.clsUtiles();

		public enum MENU
		{
			MantConfiguracionParametro		=	101,
			MantPerfil							=  102,
			MantUsuario							=	103,
			MantTipoDocumento					=	104,
			MantCliente							=	106,
			MantSucursal						=	107,
			MantPersonal						=	108,

			IngresoPel							=	201,
			CorreccionDcto						=	202,
			EnvioPelicula						=	203,
			ProcSeparador1						=	204,
			ProcEnviado							=  205,
			ProcRecepcion						=	206,
			ProcOrTrabTodas					=	208,
			ProcOrTrabPorCliente				=	209,
			ProcOrTrabPorFechaRecepcion	=	210,
			ProcIngresarDosisCliente		=  213,
			ProcIngresarDosisDos				=  214,

			Ingreso_TLD							=	301, 
			EnviadoTLD							=	302,
			RecepcionTLD						=	303,
			IniciarLectura						=	304,
			IngresarDosisTLD					=	305,
			DosisISPTLD							=	306,
		

			GenerarDctoISP						=	401,

			repDosimetria						=	501,
			repEstadoDosimetro				=	502,
			repCliente							=	503,

			LinkVigDosimetrica				=	601,

			Herramientas						=	800,
			ConfigurarCorreo					=	801,
			RestcontrCliente					=	802,
			Cambiarcontraseña					=	803,
			EnviarCorreo						=	804,
			CambioTrimestre					=	805,
			AsociarDocumentoCliente			=	806,
			LiberarDosimetro					=	807,
			TraspasoPersonal					=	808,
			CambioSucursal						=	809,

			Ayuda									=	900,
			AcercaDe								=	901,

			Salir									=	1000
		}

		public enum REPORTES
		{
			Cliente = 1,
			Dosimetro = 2
		}


		#endregion

		#region formulario

		public MDIPrincipal()
		{
			InitializeComponent();

			frmLogin frm = new frmLogin();
			frm.ShowDialog();

			tstUsuario.Text = Clases.clsUsuario.Usuario;
			tstNombre.Text = Clases.clsUsuario.Nombre;

			SqlCommand cmd = new SqlCommand
			{
				CommandText = "pa_Log_usuario_ins '" + Clases.clsUsuario.Usuario + "','Ingreso'",
				CommandType = CommandType.Text
			};

			HabiliarDesabilitarMenu(Clases.clsUsuario.Id_perfil);

			Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);
			if (Clases.clsBD.BD == "Desarrollo")
			{
				this.BackColor = Color.Green;
				this.Text = this.Text + " Desarrollo";
			}
		}

		private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Desea salir del programa?", "Mensaje de salida", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				SqlCommand cmd = new SqlCommand
				{
					CommandText = "pa_Log_usuario_ins '" + Clases.clsUsuario.Usuario + "','Finalizar'",
					CommandType = CommandType.Text
				};

				Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);
				Application.Exit();
			}
		}

		private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
		{
			Graba_log("Finalizar");
			Application.Exit();
		}

		private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
		{

			Graba_log("Finalizar");

			Application.Exit();
		}

		#endregion

		#region "ToolStrip"

		private void TsbPrincipalCambioContraseñaCliente_Click(object sender, EventArgs e)
		{
			LlamarFormularioContrasenaCliente();
		}

		private void TsbPrincipalCambioContraseña_Click(object sender, EventArgs e)
		{
			LlamarFormularioContrasena();
		}

		#endregion

		#region "Proceso"
		private void mnuProcesoDosisISP_Click(object sender, EventArgs e)
		{
			frmDosimetriaISP frm = new frmDosimetriaISP(-1);
			Graba_log(frm.Text);
			frm.Show();
		}

		private void MnuProcesoInformeGenerado_Click(object sender, EventArgs e)
		{
			frmRecepcionPelicula frm = new frmRecepcionPelicula(6);
			Graba_log(frm.Text);
			frm.Show();

		}

		private void PorFacturarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmPorFacturar frm = new frmPorFacturar(10);
			Graba_log(frm.Text);
			frm.Show();
		}

		private void FacturaciónToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmFacturacion frm = new FrmFacturacion(11);
			Graba_log(frm.Text);
			frm.Show();

		}

		private void MnuProcesoIngresarDosis_Click(object sender, EventArgs e)
		{
			frmIngresoDosimetria frm = new frmIngresoDosimetria(0);
			Graba_log(frm.Text);
			frm.ShowDialog(this);
		}

		#endregion

		#region Procedimiento

		private void LlamarFormularioContrasena()
		{
			frmCambioContrasena frm = new frmCambioContrasena
			{
				ShowInTaskbar = false
			};
			Graba_log(frm.Text);
			frm.ShowDialog(this);
		}

		private void LlamarFormularioContrasenaCliente()
		{
			frmRestablecerContrasenaCliente frm = new frmRestablecerContrasenaCliente
			{
				ShowInTaskbar = false
			};
			Graba_log(frm.Text);
			frm.ShowDialog(this);
		}

		private void HabiliarDesabilitarMenu(int intPerfil)
		{
			ToolStripMenuItem tsiMenu;
			SqlCommand cmd = new SqlCommand
			{
				CommandText = "pa_MenuPrivilegio_sel " + Clases.clsUsuario.Id_perfil.ToString(),
				CommandType = CommandType.Text
			};
			DataSet ds = Conectar.Listar(Clases.clsBD.BD, cmd);

			if (ds == null)
				menuStrip.Visible = false;
			else
			{
				//menuStrip.Items.Clear();
				menuStrip.Visible = ds.Tables[0].Rows.Count == 0 ? false : true;
				if (ds.Tables[0].Rows.Count > 0)
				{

					for (int intFila = 0; intFila <= ds.Tables[0].Rows.Count - 1; intFila++)
					{
						tsiMenu = new ToolStripMenuItem();
						tsiMenu.Text = ds.Tables[0].Rows[intFila]["Menu"].ToString();
						tsiMenu.Name = ds.Tables[0].Rows[intFila]["nameMenu"].ToString();
						tsiMenu.Tag = ds.Tables[0].Rows[intFila]["Id_Menu"].ToString();


						if ((bool)ds.Tables[0].Rows[intFila]["EventoClick"] == true)
							tsiMenu.Click += new EventHandler(this.Cargamenu_Click);
						else
							Cargar_Submenu(ref tsiMenu, ds.Tables[1], Convert.ToInt16(ds.Tables[0].Rows[intFila]["Id_Menu"].ToString()));
						menuStrip.Items.Add(tsiMenu);
					}
				}
			}
		}

		private void Cargar_Submenu( ref ToolStripMenuItem tsiMenu,DataTable dt,int intTag)
		{
			ToolStripMenuItem tsiSubMenu;
			ToolStripSeparator tsiSeparador;

			DataView dv = new DataView(dt);
			dv.RowFilter = "Id_menu_Padre=" + intTag.ToString();
			dv.Sort = "Orden";
			foreach (DataRowView drv in dv)
			{

				if(drv["Menu"].ToString()=="Separador")
				{
					tsiSeparador = new ToolStripSeparator();
					tsiMenu.DropDownItems.Add(tsiSeparador);
				}
				else{ 
				tsiSubMenu = new ToolStripMenuItem();
				tsiSubMenu.Text = drv["Menu"].ToString();
				tsiSubMenu.Name = drv["nameMenu"].ToString();
				tsiSubMenu.Tag = drv["Id_Menu"].ToString();
				

					if ((bool)drv["EventoClick"] == true)
						tsiSubMenu.Click += new EventHandler(this.Cargamenu_Click);
					Cargar_Submenu(ref tsiSubMenu,dt,Convert.ToInt16( tsiSubMenu.Tag));
					tsiMenu.DropDownItems.Add(tsiSubMenu);

					
				}
				
			}
		}

		private void Cargamenu_Click(object sender, EventArgs e)
		{
			
			int intMenu= Convert.ToUInt16(((System.Windows.Forms.ToolStripItem)sender).Tag.ToString());
			object[] objParams = { intMenu };
			Form objFrm;
			switch (intMenu)
			{
				#region "Mantenedor"

				case (int)MENU.MantConfiguracionParametro:
					objFrm = new frmParametro()
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.ShowDialog(this);
					break;
				case (int)MENU.MantPerfil:
					objFrm = new frmMantenedorPerfil()
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.MantUsuario:
					objFrm = new frmMantenedorUsuario()
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.MantTipoDocumento:
					objFrm = new frmMantenedorTipoDocumento()
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.MantCliente:
					objFrm = new frmBusquedaEmpresa()
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.MantSucursal:
					objFrm = new frmBusquedaSucursal(0)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.MantPersonal:
					objFrm = new frmBusquedaPersonal(0)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;

				#endregion


				#region "Proceso 200"

				case (int)MENU.IngresoPel:
					objFrm = new frmIngresoPelicula(0)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.CorreccionDcto:
					objFrm = new frmDosimetriaPersonal(0)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.EnvioPelicula:
					objFrm = new frmRecepcionPelicula(0)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.ProcEnviado:
					objFrm = new frmModuloEnviado(0)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.ProcRecepcion:
					objFrm = new frmModuloRecepcion(0)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.ProcOrTrabTodas:
					objFrm = new frmOrdenTrabajo(2)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.ProcOrTrabPorCliente:
					objFrm = new frmOrdenTrabajoPorDocumento(2)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.ProcOrTrabPorFechaRecepcion:
					objFrm = new frmOrdenTrabajoFechaRecepcion(2)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.ProcIngresarDosisCliente:
					objFrm = new frmIngresoDosimetria(0)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.ProcIngresarDosisDos:
					objFrm = new frmIngresoDosimetriaDos(0)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;

				#endregion

				#region "ProcesoTLD 300"
				case (int)MENU.Ingreso_TLD:
					objFrm = new frmIngresoDosimetroTLD(0)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen,
						Parametros = objParams
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.EnviadoTLD:
					objFrm = new frmModuloEnviado(0)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.RecepcionTLD:
					objFrm = new frmModuloRecepcion(0)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.IniciarLectura:
					objFrm = new frmModuloIniciarProcesoTLD(2)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.IngresarDosisTLD:
					objFrm = new frmIngresoDosisTLD(12)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.DosisISPTLD:
					objFrm = new FrmInformeISP(-1)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;

				#endregion

				#region "Generar Dcto ISP 400"

				case (int)MENU.GenerarDctoISP:
					objFrm = new frmGenerarISP()
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;

				#endregion

				#region "Reporte 500"
				case (int)MENU.repDosimetria:
					objFrm = new frmRpDosimetria()
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.repEstadoDosimetro:
					objFrm = new frmRptPorEstado()
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.repCliente:
					objFrm = new frmRptcliente()
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				#endregion

				#region "link 600"

				case (int)MENU.LinkVigDosimetrica:
					objFrm = new frmUrlVigilanciadosimetrica()
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;

				#endregion

				#region "Herramientas 800"
				case (int)MENU.ConfigurarCorreo:
					objFrm = new FrmConfCorreo()
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.ShowDialog(this);
					break;
				case (int)MENU.RestcontrCliente:
					LlamarFormularioContrasenaCliente();
					break;
				case (int)MENU.Cambiarcontraseña:
					LlamarFormularioContrasena();
					break;
				case (int)MENU.EnviarCorreo:
					objFrm = new frmEnvioCorreos(0)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.ShowDialog(this);
					break;
				case (int)MENU.CambioTrimestre:
					objFrm = new frmCorreccionTrimestral(0)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.ShowDialog(this);

					break;
				case (int)MENU.AsociarDocumentoCliente:
					objFrm = new frmingdocumentos(0)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.ShowDialog(this);

					break;
				case (int)MENU.LiberarDosimetro:
					objFrm = new frmLiberarDosimetro()
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.ShowDialog(this);
					break;
				case (int)MENU.TraspasoPersonal:
					objFrm = new frmTraspasoPersonal()
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.ShowDialog(this);
					break;
				case (int)MENU.CambioSucursal:
					objFrm = new frmCambioSucursal()
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.ShowDialog(this);
					break;
				#endregion

				#region "Acerca De 900"
				case (int)MENU.AcercaDe:
					objFrm = new frmAcerceDe
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.ShowDialog(this);
					break;
				#endregion
			
				#region "Salir 1000"
				case (int)MENU.Salir:
					Graba_log("Finalizar");
					Application.Exit();
					break;	
				#endregion
			}
			
		}

		private void Cargamenu(int intMenu)
		{

			object[] objParams = { intMenu };
			Form objFrm;
			switch (intMenu)
			{
				#region "Mantenedor"

				case (int)MENU.MantUsuario:
					objFrm = new frmMantenedorUsuario()
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.MantTipoDocumento:
					objFrm = new frmMantenedorTipoDocumento()
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.MantCliente:
					objFrm = new frmBusquedaEmpresa()
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.MantSucursal:
					objFrm = new frmBusquedaSucursal(0)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.MantPersonal:
					objFrm = new frmBusquedaPersonal(0)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;

				#endregion


				#region "Proceso 200"

				case (int)MENU.IngresoPel:
					objFrm = new frmIngresoPelicula(0)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.CorreccionDcto:
					objFrm = new frmDosimetriaPersonal(0)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.EnvioPelicula:
					objFrm = new frmRecepcionPelicula(0)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.ProcEnviado:
					objFrm = new frmModuloEnviado(0)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.ProcRecepcion:
					objFrm = new frmModuloRecepcion(0)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.ProcOrTrabTodas:
					objFrm = new frmOrdenTrabajo(2)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.ProcOrTrabPorCliente:
					objFrm = new frmOrdenTrabajoPorDocumento(2)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.ProcOrTrabPorFechaRecepcion:
					objFrm = new frmOrdenTrabajoFechaRecepcion(2)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.ProcIngresarDosisCliente:
					objFrm = new frmIngresoDosimetria(0)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.ProcIngresarDosisDos:
					objFrm = new frmIngresoDosimetriaDos(0)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;

				#endregion

				#region "ProcesoTLD 300"
				case (int)MENU.Ingreso_TLD:
					objFrm = new frmIngresoDosimetroTLD(0)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen,
						Parametros = objParams
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.EnviadoTLD:
					objFrm = new frmModuloEnviado(0)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.RecepcionTLD:
					objFrm = new frmModuloRecepcion(0)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.IniciarLectura:
					objFrm = new frmModuloIniciarProcesoTLD(2)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.IngresarDosisTLD:
					objFrm = new frmIngresoDosisTLD(12)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.DosisISPTLD:
					objFrm = new FrmInformeISP(-1)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;

				#endregion

				#region "Generar Dcto ISP 400"

				case (int)MENU.GenerarDctoISP:
					objFrm = new frmGenerarISP()
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;

				#endregion

				#region "Reporte 500"
				case (int)MENU.repDosimetria:
					objFrm = new frmRpDosimetria()
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.repEstadoDosimetro:
					objFrm = new frmRptPorEstado()
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				case (int)MENU.repCliente:
					objFrm = new frmRptcliente()
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;
				#endregion

				#region "link 600"

				case (int)MENU.LinkVigDosimetrica:
					objFrm = new frmUrlVigilanciadosimetrica()
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.Show(this);
					break;

				#endregion

				#region "Herramientas 800"
				case (int)MENU.ConfigurarCorreo:
					objFrm = new FrmConfCorreo()
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.ShowDialog(this);
					break;
				case (int)MENU.RestcontrCliente:
					LlamarFormularioContrasenaCliente();
					break;
				case (int)MENU.Cambiarcontraseña:
					LlamarFormularioContrasena();
					break;
				case (int)MENU.EnviarCorreo:
					objFrm = new frmEnvioCorreos(0)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.ShowDialog(this);
					break;
				case (int)MENU.CambioTrimestre:
					objFrm = new frmCorreccionTrimestral(0)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.ShowDialog(this);

					break;
				case (int)MENU.AsociarDocumentoCliente:
					objFrm = new frmingdocumentos(0)
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.ShowDialog(this);

					break;
				case (int)MENU.LiberarDosimetro:
					objFrm = new frmLiberarDosimetro()
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.ShowDialog(this);
					break;
				case (int)MENU.TraspasoPersonal:
					objFrm = new frmTraspasoPersonal()
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.ShowDialog(this);
					break;
				case (int)MENU.CambioSucursal:
					objFrm = new frmCambioSucursal()
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.ShowDialog(this);
					break;
				#endregion

				#region "Acerca De 900"
				case (int)MENU.AcercaDe:
					objFrm = new frmAcerceDe
					{
						ShowInTaskbar = false,
						StartPosition = FormStartPosition.CenterScreen
					};
					Graba_log(objFrm.Text);
					objFrm.ShowDialog(this);
					break;
				#endregion

				#region "Salir 1000"
				case (int)MENU.Salir:
					Graba_log("Finalizar");
					Application.Exit();
					break;
					#endregion
			}

		}


		static public void LlamadaReporte(int intReporte)
		{
			switch (intReporte)
			{
				case (int)REPORTES.Cliente:
					frmRptcliente frm1 = new frmRptcliente
					{
						ShowInTaskbar = false
					};
					frm1.Show();
					break;
				case (int)REPORTES.Dosimetro:
					frmRpDosimetria frm2 = new frmRpDosimetria();
					frm2.ShowInTaskbar = false;
					frm2.Show();
					break;
			}

		}


		private void Timer1_Tick(object sender, EventArgs e)
		{
			stsHora.Text = DateTime.Now.ToString();
		}
		
		private void Graba_log(string strModulo)
		{
			SqlCommand cmd = new SqlCommand
			{
				CommandText = "pa_Log_usuario_ins '" + Clases.clsUsuario.Usuario + "',' " + strModulo + "'",
				CommandType = CommandType.Text
			};
			Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);
		}

		private void TreeView1_Click(object sender, EventArgs e)
		{

		}

		private void TreeView1_DoubleClick(object sender, EventArgs e)
		{
			TreeNode node = treeView1.SelectedNode;

			if (node.Name == "Nodo0")
			{
				richTextBox1.Text = "Lista las versiones sistemas y sus actualizaciones ";
			}
			if (node.Name == "Nodo1")
			{
				richTextBox1.Text = "Se agrego un reporte anual por cliente,\n Se encuentra en el menu reportes/dosimetria  en la opción Anual por Cliente ";
			}
			if (node.Name == "Nodo2")
			{
				richTextBox1.Text = "Se agrego un reporte por dosimetros,\n Se encuentra en el menu reportes/dosimetria  en la opción ¨Por Dosimetro ";
			}
			if (node.Name == "Nodo3")
			{
				richTextBox1.Text = "Se agrego la funcionalidad de modificarla surcusal.";
			}

			if (node.Name == "Nodo4")
			{
				richTextBox1.Text = "Se Agrego la funcionalidad  de ingreso/Envio/Recepcion TLD \n Se agrego un reporte de los dosimetros por sucursal";
			}

			if (node.Name == "Nodo4")
			{
				richTextBox1.Text = "Se agrego la Fecha de nacimiento al personal y se agrego un reporte de cliente por personal";
			}

		}

		#endregion

		private void tsbPrincipal_Click(object sender, EventArgs e)
		{
			if (((ToolStripButton)sender).Text == "Cliente")
				Cargamenu((int)MENU.MantUsuario);
			if (((ToolStripButton)sender).Text == "Personal")
				Cargamenu((int)MENU.MantPersonal);
			//if (((ToolStripButton)sender).Text == "Restablecer")
			//	Cargamenu((int)MENU.MantPersonal);
		}
	}
}
