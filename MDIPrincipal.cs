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
        //     private int childFormNumber = 0;
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

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "pa_Log_usuario_ins '" + Clases.clsUsuario.Usuario + "','Ingreso'";
            cmd.CommandType = CommandType.Text;

            HabiliarDesabilitarMenu(Clases.clsUsuario.Id_perfil);

            Conectar.AgregarModificarEliminar(cmd);
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del programa?", "Mensaje de salida", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "pa_Log_usuario_ins '" + Clases.clsUsuario.Usuario + "','Finalizar'";
                cmd.CommandType = CommandType.Text;

                Conectar.AgregarModificarEliminar(cmd);
                Application.Exit();
            }
        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Graba_log("Finalizar");
            Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Graba_log("Finalizar");

            Application.Exit();
        }

        #endregion

        #region "Menu Mantenedor"
        private void mnuMantConfiguracionParametro_Click(object sender, EventArgs e)
        {
            frmParametro frm = new frmParametro();
            Graba_log(frm.Text);
				frm.ShowDialog(this); 
        }

         private void mnuMantTipoDocumento_Click(object sender, EventArgs e)
         {
             frmBusquedaTipoDoc frm = new frmBusquedaTipoDoc();
             Graba_log(frm.Text);
             frm.ShowDialog(this); 
         }
        private void mnuMantCliente_Click(object sender, EventArgs e)
        {
		    frmBusquedaEmpresa frm = new frmBusquedaEmpresa();
            Graba_log(frm.Text);					
            frm.ShowDialog (this);
        }

		  private void mnuMantPersonal_Click(object sender, EventArgs e)
		  {
			  frmBusquedaPersonal frm = new frmBusquedaPersonal(0);
              Graba_log(frm.Text);
			  frm.ShowDialog(this);
		  }

          private void mnuMantPerfil_Click(object sender, EventArgs e)
          {
            frmMantenedorPerfil frm = new frmMantenedorPerfil();
            Graba_log(frm.Text);            
            frm.Show(this);
          }

          private void mnuMantUsuario_Click(object sender, EventArgs e)
          {
              frmBusquedaUsuario frm = new frmBusquedaUsuario();
              Graba_log(frm.Text);
              frm.ShowDialog(this);
          }
        #endregion

        #region "Reportes"
        private void mnuReporteDosimetria_Click(object sender, EventArgs e)
        {
            frmRpDosimetria frm = new frmRpDosimetria();
            Graba_log(frm.Text);
            frm.Show(this);
        }

        private void mnuReportePorCliente_Click(object sender, EventArgs e)
        {
            frmRptcliente frm = new frmRptcliente();
            Graba_log(frm.Text);
            frm.Show(this);
        }

        #endregion

        #region "Proceso"



        private void mnuLinkVigilanciaDosi_Click(object sender, EventArgs e)
          {
              frmUrlVigilanciadosimetrica frm = new frmUrlVigilanciadosimetrica();
              Graba_log(frm.Text);
              frm.Show();

          }

          private void mnuAyudaAcercaDe_Click(object sender, EventArgs e)
          {
              frmAcerceDe frm = new frmAcerceDe();
              Graba_log(frm.Text);
              frm.Show();
          }

          private void mnuProcesoRecepcion_Click(object sender, EventArgs e)
          {
              frmModuloRecepcion frm = new frmModuloRecepcion(0);
            Graba_log(frm.Text);
            frm.Show();
          }

          private void mnuProcesoEnviado_Click(object sender, EventArgs e)
          {
              frmModuloEnviado frm = new frmModuloEnviado(0);
            Graba_log(frm.Text);
            frm.Show();
          }

          private void mnuProcesoOrdenTrabajoVarios_Click(object sender, EventArgs e)
          {
              frmOrdenTrabajo frm = new frmOrdenTrabajo(2);
              Graba_log(frm.Text);
              frm.Show();
          }

          private void mnuProcesoOrdenTrabajoPorDocumento_Click(object sender, EventArgs e)
          {
              frmOrdenTrabajoPorDocumento frm = new frmOrdenTrabajoPorDocumento(2);
              Graba_log(frm.Text);
              frm.Show();
          }

          private void mnuProcesoOrdenTrabajoFechaRecepcion_Click(object sender, EventArgs e)
          {
              frmOrdenTrabajoFechaRecepcion frm = new frmOrdenTrabajoFechaRecepcion(2);
              Graba_log(frm.Text);
              frm.Show();
          }

          private void mnuProcesoEnvioDosimetro_Click(object sender, EventArgs e)
          {
              frmRecepcionPelicula frm = new frmRecepcionPelicula(0);
              Graba_log(frm.Text);
              frm.Show();
          }

          private void mnuProcesoInformeGenerado_Click(object sender, EventArgs e)
          {
              frmRecepcionPelicula frm = new frmRecepcionPelicula(6);
              Graba_log(frm.Text);
              frm.Show();

          }

          private void porFacturarToolStripMenuItem_Click(object sender, EventArgs e)
          {
              frmPorFacturar frm = new frmPorFacturar(10);
              Graba_log(frm.Text);
              frm.Show();
          }

          private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
          {
              FrmFacturacion frm = new FrmFacturacion(11);
              Graba_log(frm.Text);
              frm.Show();

          }

          private void mnuReporteEstadoDosimetro_Click(object sender, EventArgs e)
          {
              frmRptPorEstado frm = new frmRptPorEstado();
              Graba_log(frm.Text);
              frm.Show();
          }

          private void mnuProcesoIngresoNpelicula_Click(object sender, EventArgs e)
          {
              frmIngresoPelicula frm = new frmIngresoPelicula(0);
            Graba_log(frm.Text);
            frm.ShowDialog(this);
          }

          private void mnuProcesoIngresarDosis_Click(object sender, EventArgs e)
          {
              frmIngresoDosimetria frm = new frmIngresoDosimetria(0);
            Graba_log(frm.Text);
            frm.ShowDialog(this);
          }

          private void mnuMantSucursal_Click(object sender, EventArgs e)
          {
              frmBusquedaSucursal frm = new frmBusquedaSucursal(0);
            Graba_log(frm.Text);
            frm.ShowDialog(this);
          }

          private void mnuProcesoIngresoDosimetroPersonal_Click(object sender, EventArgs e)
          {
              frmDosimetriaPersonal frm = new frmDosimetriaPersonal(0);
            Graba_log(frm.Text);
            frm.ShowDialog(this);
          }

        #endregion

        #region "Herramientas"

        private void tsbPrincipalCambioContraseña_Click(object sender, EventArgs e)
        {
            frmCambioContrasena frm = new frmCambioContrasena();
            Graba_log(frm.Text);
            frm.ShowDialog(this);
        }

        private void frmUtilidadesEnviarCorreo_Click(object sender, EventArgs e)
          {
              frmEnvioCorreos frm = new frmEnvioCorreos(0);
            Graba_log(frm.Text);
            frm.ShowDialog(this);
          }

          private void frmUtilidadesCambioTrimestre_Click(object sender, EventArgs e)
          {
              frmCorreccionTrimestral frm = new frmCorreccionTrimestral(0);
            Graba_log(frm.Text);
            frm.ShowDialog(this);
          }

          private void frmUtilidadesAsociarDocumentoCliente_Click(object sender, EventArgs e)
          {
              frmingdocumentos frm = new frmingdocumentos(0);
              Graba_log(frm.Text );
              frm.ShowDialog(this);
          }

          #endregion

          #region "Proceso TLD"

          private void mnuProcesoTLDIngresoPelicula_Click(object sender, EventArgs e)
          {
              frmIngresoDosimetroTLD frm = new frmIngresoDosimetroTLD(0);
            Graba_log(frm.Text);
            frm.ShowDialog(this);
          }

          private void mnuProcesoTLDIniciarLectura_Click(object sender, EventArgs e)
          {
              frmModuloIniciarProcesoTLD frm = new frmModuloIniciarProcesoTLD(2);
            Graba_log(frm.Text);
            frm.ShowDialog(this);
          }

          private void mnuProcesoIngresarDosisTLD_Click(object sender, EventArgs e)
          {
              frmIngresoDosisTLD frm = new frmIngresoDosisTLD(12);
            Graba_log(frm.Text);
            frm.ShowDialog(this);
          }
        #endregion

        #region "Generar Dcto ISP"
        private void frmGenerarDctoISPGenerar_Click(object sender, EventArgs e)
        {
            frmGenerarISP frm = new frmGenerarISP();
            Graba_log(frm.Text);
            frm.ShowDialog(this);
        }
        #endregion

        #region Procedimiento

        private void HabiliarDesabilitarMenu(int intPerfil)
        {
            if (intPerfil != 1)
                mnuMantConfiguracionMenu.Visible = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            stsHora.Text = DateTime.Now.ToString();
        }
        private void Graba_log(string strModulo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "pa_Log_usuario_ins '" + Clases.clsUsuario.Usuario + "',' " + strModulo + "'";
            cmd.CommandType = CommandType.Text;
            Conectar.AgregarModificarEliminar(cmd);
        }

        private void treeView1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
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
       
    }
}
