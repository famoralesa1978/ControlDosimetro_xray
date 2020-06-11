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
    public partial class frmBusquedaEmpresa : Form
    {

        #region "Definicion variable"
				clsConectorSqlServer Conectar = new clsConectorSqlServer();
				clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
            clsEventoControl ClaseEvento = new clsEventoControl();
        #endregion

        public frmBusquedaEmpresa()
        {
            InitializeComponent();
				AsignarEvento();
            Cargar_Estado();
           // Listar_Cliente();
            
        }

        #region "Llamada de carga"

        private void    Listar_Cliente()
        {
            Cursor = Cursors.WaitCursor;
			//  SqlCommand cmd = new SqlCommand()
            SqlCommand cmd = new SqlCommand();


            //MessageBox.Show("Conectado al servidor");

				if (txt_N_Cliente_Ref.Text !="")
					cmd.CommandText = "select id_cliente,run,razon_social,Direccion,telefono " +
									"from tbl_cliente " +
									"where run like '%" + txt_Rut.Text + "%' and razon_social like '%" + txt_RazonSocial.Text   + "%' " +
                                    " and id_estado=" + cbx_Estado.SelectedValue + " and id_cliente =" + txt_N_Cliente_Ref.Text + " " +
                                    " and Direccion like '%" + txt_Direccion.Text + "%' order by id_cliente";
				else
					cmd.CommandText = "select id_cliente,run,razon_social,Direccion,telefono " +
									"from tbl_cliente " +
									"where run like '%" + txt_Rut.Text + "%' and razon_social like '%" + txt_RazonSocial.Text + "%' " +
                                    " and id_estado=" + cbx_Estado.SelectedValue +
                                    " and Direccion like '%" + txt_Direccion.Text + "%' order by id_cliente";
					cmd.CommandType = CommandType.Text;


            DataSet dt;
            dt = Conectar.Listar(Clases.clsBD.BD,cmd);

            grdDatos.DataSource = dt.Tables[0];
            Cursor = Cursors.Default;
        }

        private void AsignarEvento()
        {           
            this.txt_Rut.KeyPress += new KeyPressEventHandler(ClaseEvento.Rut_KeyPress);
            txt_Rut.KeyDown += new KeyEventHandler(ClaseEvento.Rut_KeyDown);
            txt_Rut.Validated += new EventHandler(ClaseEvento.validarut_Validated);


				this.txt_N_Cliente_Ref.KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
				txt_N_Cliente_Ref.KeyDown += new KeyEventHandler(ClaseEvento.Numero_KeyDown);
			  
			  txt_RazonSocial.KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);

			  cbx_Estado.KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);
        }

        private void Cargar_Estado()
        {
            ClaseComun.Listar_Estado(Clases.clsBD.BD,ref cbx_Estado, ref cbx_Estado);
        }

        private void Configurar_Grilla()
        {

        }


        #endregion

        #region "button"
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            Listar_Cliente();

            Cursor = Cursors.Default;


        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            frmEmpresaMant frm = new frmEmpresaMant(0);
            frm.ShowDialog(this);
            Listar_Cliente();

            Cursor = Cursors.Default;
        }

        private void tsbAgregarReferencia_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            frmBusquedaReferencia frm = new frmBusquedaReferencia(Convert.ToInt64(grdDatos.SelectedCells[0].Value.ToString()));
            frm.ShowDialog(this);

            Cursor = Cursors.Default;
        }

		  private void tsbAgregarPersonal_Click(object sender, EventArgs e)
		  {
			  frmBusquedaPersonal frm = new frmBusquedaPersonal(Convert.ToInt64(grdDatos.SelectedCells[0].Value.ToString()));
			  frm.ShowDialog(this);
		  }

		  private void tsbIngresoDosimetro_Click(object sender, EventArgs e)
		  {
			  frmIngresoDosimetria frm = new frmIngresoDosimetria(Convert.ToInt64(grdDatos.SelectedCells[0].Value.ToString()));
			  frm.ShowDialog(this);
		  }

		  private void btnIngresarDosisISP_Click(object sender, EventArgs e)
		  {
			  frmDosimetriaISP frm = new frmDosimetriaISP(Convert.ToInt64(grdDatos.SelectedCells[0].Value.ToString()));
			  frm.ShowDialog(this);
		  }

          private void btnIngresarPelicula_Click(object sender, EventArgs e)
          {
              frmIngresoPelicula frm = new frmIngresoPelicula(Convert.ToInt64(grdDatos.SelectedCells[0].Value.ToString()));
              frm.ShowDialog(this);
          }

        #endregion

		  #region "combobox"
			  private void cbx_id_estado_SelectedIndexChanged(object sender, EventArgs e)
			  {
                  if (cbx_Estado.SelectedValue.ToString()   == "1")
					  tsbIngresoDosimetro.Visible = true;
				  else
					  tsbIngresoDosimetro.Visible = false;
			  }

			#endregion

        #region "grilla"

        private void grdDatos_DoubleClick(object sender, EventArgs e)
        {
            frmEmpresaMant frm = new frmEmpresaMant(Convert.ToInt64(grdDatos.SelectedCells[0].Value.ToString()));
            frm.ShowDialog(this);
            Listar_Cliente();
        }

        #endregion

        private void tsmEliminar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "pa_Cliente_del " + grdDatos.SelectedCells[0].Value.ToString() + "";
            cmd.CommandType = CommandType.Text;
            DataSet ds;

            ds = Conectar.Listar(Clases.clsBD.BD,cmd);
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Cliente se dejo Inactivo,Debe ingresar una observación porque se dejo inactivo");
                frmObservacionCliente frm1 = new frmObservacionCliente(grdDatos.SelectedCells[0].Value.ToString(), ds.Tables[0].Rows[0]["FechaInicio"].ToString());
                frm1.ShowDialog(this);
            }
            Listar_Cliente();
        }		    
    }
}
