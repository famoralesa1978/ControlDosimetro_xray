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
    public partial class frmBusquedaUsuario : Form
    {

        #region "Definicion variable"
            clsConectorSqlServer Conectar = new clsConectorSqlServer();
				clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
            clsEventoControl ClaseEvento = new clsEventoControl();				
        #endregion

            public frmBusquedaUsuario()
        {
            InitializeComponent();
				AsignarEvento();
                Cargar_Estado();
                Cargar_Perfil();
        }

        #region "Llamada de carga"

            private void Cargar_Estado()
            {
                ClaseComun.Listar_Estado(Clases.clsBD.BD,ref cbx_id_estado, ref cbx_id_estado);
            }
		  private void Listar_Usuario()
		  {
              SqlCommand cmd = new SqlCommand();

			 
                  cmd.CommandText = "SELECT [Id_Usuario],[Usuario],[Nombres],[Paterno],[Maternos],[Descripcion] " +
                                            " FROM [dbo].[tbl_Usuario] U inner join tbl_perfil p on p.id_perfil=u.id_perfil"  +
                                            " where u.id_estado=" + cbx_id_estado.SelectedValue + " and p.id_perfil=" + cbx_Id_perfil.SelectedValue + 
								  " order by Nombres,Paterno,Maternos";
			  cmd.CommandType = CommandType.Text;

			  DataSet dt;
			  dt = Conectar.Listar(Clases.clsBD.BD,cmd);
			  grdDatos.DataSource = dt.Tables[0];

			  if (dt.Tables[0].Rows.Count == 0)
			  {
				  MessageBox.Show("No se han cargado ningun usuario");				  
			  }
			  else
			  {
				  MessageBox.Show("Se encontraron usuario");				
			  }
		  }
		  
        private void AsignarEvento()
        {           
           cbx_id_estado.KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);
           cbx_Id_perfil.KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);

				
        }
     


        #endregion

        #region "button"       

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            frmUsuarioMant frm = new frmUsuarioMant(0);
			  frm.ShowDialog(this);
              Listar_Usuario();
        }


		  private void btn_Filtro_Click(object sender, EventArgs e)
		  {
			  
		  }
          private void Cargar_Perfil()
          {

              // SqlCommand cmd = new SqlCommand();
              SqlCommand cmd = new SqlCommand();
              cmd.CommandText = "select Id_perfil,Descripcion FROM tbl_perfil WHERE Id_estado=1 order by Descripcion";
              DataSet dt;
              dt = Conectar.Listar(Clases.clsBD.BD,cmd);

              cbx_Id_perfil.DisplayMember = dt.Tables[0].Columns[1].Caption.ToString();
              cbx_Id_perfil.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
              cbx_Id_perfil.DataSource = dt.Tables[0];

          }

        #endregion

        #region "grilla"

        private void grdDatos_DoubleClick(object sender, EventArgs e)
        {
            frmUsuarioMant frm = new frmUsuarioMant(Convert.ToInt64(grdDatos.SelectedCells[0].Value.ToString()));
            frm.ShowDialog(this);
				Listar_Usuario();
        }

        #endregion

        private void btn_cargarusuario_Click(object sender, EventArgs e)
        {
            Listar_Usuario();
        }

		 

		 

        

        

       

       
    }
}
