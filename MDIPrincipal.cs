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

            Conectar.AgregarModificarEliminar(Clases.clsBD.BD,cmd);
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

                Conectar.AgregarModificarEliminar(Clases.clsBD.BD,cmd);
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

        #region "Menu Mantenedor"
        private void MnuMantConfiguracionParametro_Click(object sender, EventArgs e)
        {
            frmParametro frm = new frmParametro();
            Graba_log(frm.Text);
				frm.ShowDialog(this); 
        }

         private void MnuMantTipoDocumento_Click(object sender, EventArgs e)
         {
            frmMantenedorTipoDocumento frm = new frmMantenedorTipoDocumento();
             Graba_log(frm.Text);
             frm.ShowDialog(this); 
         }
        private void MnuMantCliente_Click(object sender, EventArgs e)
        {
            frmBusquedaEmpresa frm = new frmBusquedaEmpresa();
            Graba_log(frm.Text);
            frm.Show(this);     
        }

		  private void MnuMantPersonal_Click(object sender, EventArgs e)
		  {
			  frmBusquedaPersonal frm = new frmBusquedaPersonal(0);
              Graba_log(frm.Text);
			  frm.ShowDialog(this);
		  }

          private void MnuMantPerfil_Click(object sender, EventArgs e)
          {
            frmMantenedorPerfil frm = new frmMantenedorPerfil();
            Graba_log(frm.Text);            
            frm.Show(this);
          }

          private void MnuMantUsuario_Click(object sender, EventArgs e)
          {
              frmMantenedorUsuario frm = new frmMantenedorUsuario();
              Graba_log(frm.Text);
              frm.ShowDialog(this);
          }

        #endregion

        #region "Reportes"
        private void MnuReporteDosimetria_Click(object sender, EventArgs e)
        {
            frmRpDosimetria frm = new frmRpDosimetria();
            Graba_log(frm.Text);
            frm.Show(this);
        }

        private void MnuReportePorCliente_Click(object sender, EventArgs e)
        {
            frmRptcliente frm = new frmRptcliente();
            Graba_log(frm.Text);
            frm.Show(this);
        }

        #endregion

        #region "Proceso"
        private void mnuProcesoDosisISP_Click(object sender, EventArgs e)
        {
						frmDosimetriaISP frm = new frmDosimetriaISP(-1);
            Graba_log(frm.Text);
            frm.Show();
        }

        private void MnuLinkVigilanciaDosi_Click(object sender, EventArgs e)
          {
              frmUrlVigilanciadosimetrica frm = new frmUrlVigilanciadosimetrica();
              Graba_log(frm.Text);
              frm.Show();

          }

          private void MnuAyudaAcercaDe_Click(object sender, EventArgs e)
          {
              frmAcerceDe frm = new frmAcerceDe();
              Graba_log(frm.Text);
              frm.Show();
          }

          private void MnuProcesoRecepcion_Click(object sender, EventArgs e)
          {
              frmModuloRecepcion frm = new frmModuloRecepcion(0);
            Graba_log(frm.Text);
            frm.Show();
          }

          private void MnuProcesoEnviado_Click(object sender, EventArgs e)
          {
              frmModuloEnviado frm = new frmModuloEnviado(0);
            Graba_log(frm.Text);
            frm.Show();
          }

          private void MnuProcesoOrdenTrabajoVarios_Click(object sender, EventArgs e)
          {
              frmOrdenTrabajo frm = new frmOrdenTrabajo(2);
              Graba_log(frm.Text);
              frm.Show();
          }

          private void MnuProcesoOrdenTrabajoPorDocumento_Click(object sender, EventArgs e)
          {
              frmOrdenTrabajoPorDocumento frm = new frmOrdenTrabajoPorDocumento(2);
              Graba_log(frm.Text);
              frm.Show();
          }

          private void MnuProcesoOrdenTrabajoFechaRecepcion_Click(object sender, EventArgs e)
          {
              frmOrdenTrabajoFechaRecepcion frm = new frmOrdenTrabajoFechaRecepcion(2);
              Graba_log(frm.Text);
              frm.Show();
          }

          private void MnuProcesoEnvioDosimetro_Click(object sender, EventArgs e)
          {
              frmRecepcionPelicula frm = new frmRecepcionPelicula(0);
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

          private void MnuReporteEstadoDosimetro_Click(object sender, EventArgs e)
          {
              frmRptPorEstado frm = new frmRptPorEstado();
              Graba_log(frm.Text);
              frm.Show();
          }

          private void MnuProcesoIngresoNpelicula_Click(object sender, EventArgs e)
          {
              frmIngresoPelicula frm = new frmIngresoPelicula(0);
            Graba_log(frm.Text);
            frm.ShowDialog(this);
          }

          private void MnuProcesoIngresarDosis_Click(object sender, EventArgs e)
          {
              frmIngresoDosimetria frm = new frmIngresoDosimetria(0);
            Graba_log(frm.Text);
            frm.ShowDialog(this);
          }

          private void MnuMantSucursal_Click(object sender, EventArgs e)
          {
              frmBusquedaSucursal frm = new frmBusquedaSucursal(0);
            Graba_log(frm.Text);
            frm.ShowDialog(this);
          }

          private void MnuProcesoIngresoDosimetroPersonal_Click(object sender, EventArgs e)
          {
              frmDosimetriaPersonal frm = new frmDosimetriaPersonal(0);
            Graba_log(frm.Text);
            frm.ShowDialog(this);
          }

        #endregion

        #region "Herramientas"
        private void FrmUtilidadesLiberarDosimetro_Click(object sender, EventArgs e)
        {
            frmLiberarDosimetro frm = new frmLiberarDosimetro();
            Graba_log(frm.Text);
            frm.Show();
        }

        private void frmUtilidadesTraspaso_Click(object sender, EventArgs e)
        {
            frmTraspasoPersonal frm = new frmTraspasoPersonal();
            Graba_log(frm.Text);
            frm.Show();
        }
        private void FrmUtilidadesConfigurarCorreo_Click(object sender, EventArgs e)
        {
            FrmConfCorreo frm = new FrmConfCorreo();
            Graba_log(frm.Text);
            frm.ShowDialog(this);
        }
        private void FrmUtilidadesRestablecerContrasenaCliente_Click(object sender, EventArgs e)
        {
            LlamarFormularioContrasenaCliente();
        }

        private void TsbPrincipalCambioContraseñaCliente_Click(object sender, EventArgs e)
        {
            LlamarFormularioContrasenaCliente();
        }

        private void FrmCambiaContrasena_Click(object sender, EventArgs e)
        {
            LlamarFormularioContrasena();
        }

        private void TsbPrincipalCambioContraseña_Click(object sender, EventArgs e)
        {
            LlamarFormularioContrasena();
        }

        private void FrmUtilidadesEnviarCorreo_Click(object sender, EventArgs e)
          {
              frmEnvioCorreos frm = new frmEnvioCorreos(0);
            Graba_log(frm.Text);
            frm.ShowDialog(this);
          }

          private void FrmUtilidadesCambioTrimestre_Click(object sender, EventArgs e)
          {
              frmCorreccionTrimestral frm = new frmCorreccionTrimestral(0);
            Graba_log(frm.Text);
            frm.ShowDialog(this);
          }

          private void FrmUtilidadesAsociarDocumentoCliente_Click(object sender, EventArgs e)
          {
              frmingdocumentos frm = new frmingdocumentos(0);
              Graba_log(frm.Text );
              frm.ShowDialog(this);
          }

          #endregion

        #region "Proceso TLD"

    private void MnuProcesoTLDIngresoPelicula_Click(object sender, EventArgs e)
    {
			object[] objParams = {mnuProcesoTLDIngresoPelicula.Tag.ToString()};

			frmIngresoDosimetroTLD frm = new frmIngresoDosimetroTLD(0);
			frm.Parametros = objParams;
      Graba_log(frm.Text);
      frm.Show(this);
    }

        private void MnuProcesoTLDIniciarLectura_Click(object sender, EventArgs e)
        {
            frmModuloIniciarProcesoTLD frm = new frmModuloIniciarProcesoTLD(2);
          Graba_log(frm.Text);
          frm.ShowDialog(this);
        }

        private void MnuProcesoIngresarDosisTLD_Click(object sender, EventArgs e)
        {
            frmIngresoDosisTLD frm = new frmIngresoDosisTLD(12);
          Graba_log(frm.Text);
          frm.ShowDialog(this);
          }

        private void MnuProcesoTLDDosisISP_Click(object sender, EventArgs e)
        {
            FrmInformeISP frm = new FrmInformeISP(-1);
            Graba_log(frm.Text);
            frm.Show();
        }
        #endregion

        #region "Generar Dcto ISP"
        private void FrmGenerarDctoISPGenerar_Click(object sender, EventArgs e)
        {
            frmGenerarISP frm = new frmGenerarISP();
            Graba_log(frm.Text);
            frm.ShowDialog(this);
        }
        #endregion

        #region Procedimiento

        private void LlamarFormularioContrasena()
        {
            frmCambioContrasena frm = new frmCambioContrasena();
            Graba_log(frm.Text);
            frm.ShowDialog(this);
        }

        private void LlamarFormularioContrasenaCliente()
        {
            frmRestablecerContrasenaCliente frm = new frmRestablecerContrasenaCliente();
            Graba_log(frm.Text);
            frm.ShowDialog(this);
        }

        private void HabiliarDesabilitarMenu(int intPerfil)
        {
            if (intPerfil != 1)
                mnuMantConfiguracionMenu.Visible = false;
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
            Conectar.AgregarModificarEliminar(Clases.clsBD.BD,cmd);
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

		public enum REPORTES
		{
			Cliente = 1,
			Dosimetro = 2
		}


		static public void LlamadaReporte(int intReporte)
		{
			//Type enumType;
			//int intReporte = 0;

			//foreach (var value in Enum.GetValues(typeof(REPORTES)))
			//{
			//	Console.WriteLine("{0,3}     0x{0:X8}     {1}",
			//			var();

			//	intReporte = (int)value;
			//	var rep = (REPORTES)value;

			//}

			//enumType = enumValue.GetType();

			//string str
			//	Type underlyingType = Enum.GetUnderlyingType(enumType);
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


	}
}
