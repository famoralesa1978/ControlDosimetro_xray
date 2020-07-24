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
    public partial class frmUsuarioMant : Form
    {
        #region "Definicion variable"
        clsConectorSqlServer Conectar = new clsConectorSqlServer();
		  clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
        clsEventoControl ClaseEvento = new clsEventoControl();
        dllLibreriaMysql.clsUtiles clsUtiles1 = new dllLibreriaMysql.clsUtiles();
        #endregion


        public frmUsuarioMant(Int64 intCodUsuario)
        {
            InitializeComponent();
            AsignarEvento();
				
            Cargar_Estado();		
			Cargar_Perfil();
            if (intCodUsuario == 0)
            {
                btn_Grabar.Text = "Grabar";
                this.Text = "Agregar Usuario";
                cbx_Id_estado.Enabled = false;
				lbl_Fecha_agregado.Text = DateTime.Now.Date.ToString().Substring(1,10) ;
				lbl_Fecha_Modificacion.Text = DateTime.Now.Date.ToString().Substring(1, 10);
                lbl_Contraseña.Enabled = true;
                txt_Contraseña.Enabled = true;
                txt_Contraseña1.Enabled = true;
				HabDesa_Controles(true);
            }
            else
            {
                btn_Grabar.Text = "Modificar";
                this.Text = "Modificar Usuario";

                Cargar_Usuario(intCodUsuario);
                lbl_Id_Usuario.Text = intCodUsuario.ToString();
				HabDesa_Controles(true);
				btn_Limpiar.Visible = false;
                btn_Grabar.Enabled = true;
            }
        }

        #region "Llamada de carga"  
      
        private void Cargar_Estado()
        {
            ClaseComun.Listar_Estado(Clases.clsBD.BD,ref cbx_Id_estado, ref cbx_Id_estado);
        }

        private void Cargar_Usuario(Int64 intCodUsuario)
        {
            SqlCommand cmd = new SqlCommand();
			//  SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT [Id_Usuario],[Rut],[Nombres],[Paterno],[Maternos],[Id_perfil],[Id_estado],[Usuario],[Contraseña],[Fecha_agregado],[Fecha_Modificacion]" +
                              " FROM [dbo].[tbl_Usuario] WHERE Id_Usuario= " + intCodUsuario.ToString();
			  DataSet dt;
			  dt = Conectar.Listar(Clases.clsBD.BD,cmd);
            lbl_Contraseña.Enabled = false;
            txt_Contraseña.Enabled = false;
            txt_Contraseña1.Enabled = false;
            txt_rut.Text = dt.Tables[0].Rows[0]["Rut"].ToString();
              txt_Nombres.Text = dt.Tables[0].Rows[0]["Nombres"].ToString();
              txt_paterno.Text = dt.Tables[0].Rows[0]["Paterno"].ToString();
              txt_Maternos.Text = dt.Tables[0].Rows[0]["Maternos"].ToString();
              txt_Usuario.Text = dt.Tables[0].Rows[0]["Usuario"].ToString();
              cbx_Id_perfil.SelectedValue = dt.Tables[0].Rows[0]["Id_perfil"].ToString();          
             // txt_Email.Text = dt.Tables[0].Rows[0]["Email"].ToString();
              cbx_Id_estado.SelectedValue = dt.Tables[0].Rows[0]["Id_estado"].ToString();
              // cbx_id_estado.SelectedValue  = cbx_id_estado.SelectedIndex;
              txt_Contraseña.Text = dt.Tables[0].Rows[0]["Contraseña"].ToString();
              try
              {
                  txt_Contraseña1.Text = clsUtiles1.DecryptTripleDES(dt.Tables[0].Rows[0]["Contraseña"].ToString());
              }
              catch (Exception)
              {

                  txt_Contraseña1.Text = clsUtiles1.GenerateHashMD5(dt.Tables[0].Rows[0]["Contraseña"].ToString());
                  txt_Contraseña.Text = dt.Tables[0].Rows[0]["Contraseña"].ToString();
              }
              lbl_Fecha_Modificacion.Text = DateTime.Today.ToString().Substring(0,9); 
              lbl_Fecha_agregado.Text = dt.Tables[0].Rows[0]["Fecha_agregado"].ToString();
                   
			  	 
        }

		  private void Cargar_Perfil()
		  {

			 // SqlCommand cmd = new SqlCommand();
              SqlCommand cmd = new SqlCommand();
              if(Clases.clsUsuario.Id_perfil != 1)
                cmd.CommandText = "select Id_perfil,Descripcion FROM tbl_perfil WHERE Id_estado=1 and Id_perfil>1 order by Descripcion";
              else
                cmd.CommandText = "select Id_perfil,Descripcion FROM tbl_perfil WHERE Id_estado=1  order by Descripcion";

            DataSet dt;
			  dt = Conectar.Listar(Clases.clsBD.BD,cmd);

              cbx_Id_perfil.DisplayMember = dt.Tables[0].Columns[1].Caption.ToString();
              cbx_Id_perfil.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
              cbx_Id_perfil.DataSource = dt.Tables[0];

		  }

        private void AsignarEvento()
								{
                                    SqlCommand cmd = new SqlCommand();
									//SqlCommand cmd = new SqlCommand();
									DataSet dt;
									string strname;
									foreach (Control c in tbl_Usuario.Controls )
									{
										//foreach (Control childc in c.Controls)
										//{
											if (c is TextBox)
											{

												strname = ((TextBox)c).Name ;

												cmd.CommandText = "SELECT  requerido, validacion " +
																		" FROM glo_configuracioncampo WHERE campo= '" + strname.Replace("txt_","")  + "'";

												dt = Conectar.Listar(Clases.clsBD.BD,cmd);
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
												}
											}
											if (c is ComboBox)											
												((ComboBox)c).KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);
											if (c is DateTimePicker )
												((DateTimePicker)c).KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);

									}
           
        }

		  private void HabDesa_Controles(bool bolHabDesa)
		  {
			  txt_Maternos.Enabled = true;
			  txt_Nombres.Enabled = true;
			  txt_paterno.Enabled = true;
              txt_rut.Enabled = true;
              cbx_Id_estado.Enabled = bolHabDesa;
			  cbx_Id_perfil.Enabled = bolHabDesa;
              txt_Contraseña.Enabled = bolHabDesa;
              txt_Contraseña1.Enabled = bolHabDesa;
              cbx_Id_estado.Enabled = bolHabDesa;
              txt_Usuario.Enabled = bolHabDesa;
		  }

          private void LimpiarControles()
          {
              txt_rut.Text = "";
              txt_paterno.Text = "";
              txt_Nombres.Text = "";
              txt_Maternos.Text = "";
              txt_rut.Enabled = true;
              cbx_Id_estado.SelectedIndex = 0;
              cbx_Id_perfil.SelectedIndex = 0;
              HabDesa_Controles(false);
                 btn_Grabar.Text = "Grabar";
                this.Text = "Agregar Personal";     
			lbl_Usuario.Text = Clases.clsUsuario.Usuario;
			lbl_Fecha_agregado.Text = DateTime.Now.Date.ToString().Substring(1,10) ;
			lbl_Fecha_Modificacion.Text = DateTime.Now.Date.ToString().Substring(1, 10);
            txt_Contraseña.Clear();
            txt_Contraseña1.Clear();
            cbx_Id_estado.SelectedIndex = 0;
            txt_Usuario.Clear();
              txt_rut.Focus(); 
          }
        
        #endregion

        #region "button"

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            verificar_Grabado();
            this.Close();

            Cursor = Cursors.Default;
        }

        private void btn_Grabar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            Boolean bolResult;
            bolResult = false;
         //   if (MessageBox.Show("Desea grabar la información", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
           // {
                if (btn_Grabar.Text == "Modificar")
                {

                    ClaseComun.Modificar(Clases.clsBD.BD,tbl_Usuario, ref bolResult);
                    if (bolResult == true)
                    {

                        MessageBox.Show("Dato modificado");
                        if (MessageBox.Show("Desea salir del formulario", "Confirmar", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                        {
                            this.Close();
                        }
                        else
                            LimpiarControles();

                    }
                    

                }
                else
                {
                    ClaseComun.Insertar(Clases.clsBD.BD,tbl_Usuario, ref bolResult);
                    if (bolResult == true)
                    {
                        MessageBox.Show("Dato Guardado");
                        if (MessageBox.Show("Desea salir del formulario", "Confirmar", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                        {
                            this.Close();
                        }
                        else
                            LimpiarControles();
                    }
                }
            //     }

            Cursor = Cursors.Default;
        }

		  private void btn_Limpiar_Click(object sender, EventArgs e)
		  {
              Cursor = Cursors.WaitCursor;

              verificar_Grabado();
              LimpiarControles();

              Cursor = Cursors.Default;

		  }

          void verificar_Grabado()
          {
              if (btn_Grabar.Enabled == true)
              {
                  if (txt_rut.Text != "" || txt_Nombres.Text != "" || txt_paterno.Text != "" || txt_Maternos.Text != "")
                  {
                      if (MessageBox.Show("Desea grabar la información", "Confirmar", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                          btn_Grabar.PerformClick();
                  }
              }

          }
        #endregion
        
        #region "combobox"

       private void cbx_id_estado_SelectedIndexChanged(object sender, EventArgs e)
		{
		

		}


        #endregion

       private void txt_Contraseña1_TextChanged(object sender, EventArgs e)
       {
           txt_Contraseña.Text = clsUtiles1.GenerateHashMD5(txt_Contraseña1.Text); 
       }


    }
}
