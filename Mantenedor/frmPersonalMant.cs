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
    public partial class frmPersonalMant : Form
    {
        #region "Definicion variable"
        clsConectorSqlServer Conectar = new clsConectorSqlServer();
		  clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
        clsEventoControl ClaseEvento = new clsEventoControl();        
        #endregion


        public frmPersonalMant(Int64 intCodCliente, Int64 intCodPersonal)
        {
            InitializeComponent();
            AsignarEvento();
				Cargar_Cliente(intCodCliente);
            Cargar_Estado();			  
				Cargar_Seccion( );
				Cargar_Profesion();
            Cargar_sexo();
            Cargar_CodServicio();
            Cargar_Practica();
            Cargar_Cargo();
                if (intCodPersonal == 0)
            {
                btn_Grabar.Text = "Grabar";
                this.Text = "Agregar Personal";
                cbx_id_estado.Enabled = false;
					dtp_fecha_termino.Enabled = false;
					dtp_fecha_termino.Text = "01/01/1900";
					lbl_Usuario.Text = Clases.clsUsuario.Usuario;
					lbl_Fecha_agregado.Text = DateTime.Now.Date.ToString().Substring(1,10) ;
					lbl_Fecha_Modificacion.Text = DateTime.Now.Date.ToString().Substring(1, 10);
					HabDesa_Controles(false);
					btn_Verificar.Visible = true;
            }
            else
            {
                btn_Grabar.Text = "Modificar";
                this.Text = "Modificar Personal";

					 Cargar_Personal(intCodPersonal);					
					 lbl_Id_Personal.Text = intCodPersonal.ToString();
					 HabDesa_Controles(true);
					 btn_Verificar.Visible = false;
                     //txt_rut.Enabled = false;
					 btn_Limpiar.Visible = false;
                     btn_Grabar.Enabled = true;
            }
        }

        #region "Llamada de carga"  
      
        private void Cargar_Estado()
        {
            ClaseComun.Listar_Estado(Clases.clsBD.BD,ref cbx_id_estado, ref cbx_id_estado);
        }

        private void Cargar_Cliente(Int64 intCodCliente)
        {
            SqlCommand cmd = new SqlCommand();
			//  SqlCommand cmd = new SqlCommand();

			  cmd.CommandText = "SELECT run,Razon_Social,N_Cliente_Ref,Direccion,Id_Region,Id_Provincia,Id_Comuna,Telefono, Id_TipoFuente,Id_estado,Fechainicio " +
							  " FROM tbl_cliente WHERE Id_cliente= " + intCodCliente.ToString();
			  DataSet dt;
			  dt = Conectar.Listar(Clases.clsBD.BD,cmd);
			  
			  lbl_id_cliente.Text = intCodCliente.ToString ();
			  lbl_nombreCliente.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
              lbl_rut_cliente.Text = dt.Tables[0].Rows[0]["run"].ToString();	 
        }

        private void Cargar_Personal(Int64 intCodpersonal)
		  {
              SqlCommand cmd = new SqlCommand();
			//  SqlCommand cmd = new SqlCommand();

			  cmd.CommandText = "SELECT Rut,Nombres,Paterno,Maternos,Id_Seccion,Id_estado,Id_sexo,Id_profesion,Fecha_inicio,fecha_termino,Usuario,Fecha_agregado,getdate()as Fecha_Modificacion," +
                            "  fecha_nac, isnull(Id_CodServicio,8) as Id_CodServicio, isnull(Id_Practica,0) as Id_Practica, isnull(Id_Cargo,0) as Id_Cargo " +
							  " FROM tbl_personal WHERE Id_Personal= " + intCodpersonal.ToString() + " and id_cliente=" + lbl_id_cliente.Text;
			  DataSet dt;
			  dt = Conectar.Listar(Clases.clsBD.BD,cmd);

              cbx_Id_Cargo.SelectedValue = dt.Tables[0].Rows[0]["Id_Cargo"].ToString();
            cbx_Id_Practica.SelectedValue = dt.Tables[0].Rows[0]["Id_Practica"].ToString();
            cbx_Id_CodServicio.SelectedValue = dt.Tables[0].Rows[0]["Id_CodServicio"].ToString();
            lbl_Id_Personal.Text = intCodpersonal.ToString();
			  txt_Nombres.Text = dt.Tables[0].Rows[0]["Nombres"].ToString();
			  txt_rut.Text = dt.Tables[0].Rows[0]["Rut"].ToString();
			  txt_Maternos.Text = dt.Tables[0].Rows[0]["Maternos"].ToString();
			  txt_paterno.Text = dt.Tables[0].Rows[0]["Paterno"].ToString();
			  dtp_Fecha_inicio.Text = dt.Tables[0].Rows[0]["Fecha_inicio"].ToString();
            dtp_Fecha_Nac.Text = dt.Tables[0].Rows[0]["fecha_nac"].ToString();
            dtp_fecha_termino.Text = dt.Tables[0].Rows[0]["fecha_termino"].ToString();
			  cbx_id_estado.SelectedValue  = dt.Tables[0].Rows[0]["Id_estado"].ToString();
              if (dt.Tables[0].Rows[0]["Id_estado"].ToString() == "0")
                  btn_Grabar.Enabled = false;
              else
                  btn_Grabar.Enabled = true;
              cbx_id_seccion.SelectedValue = dt.Tables[0].Rows[0]["Id_Seccion"].ToString();
              cbx_id_sexo.SelectedValue = dt.Tables[0].Rows[0]["Id_sexo"].ToString();
              cbx_id_profesion.SelectedValue = dt.Tables[0].Rows[0]["Id_profesion"].ToString();
			  lbl_Fecha_agregado.Text = dt.Tables[0].Rows[0]["Fecha_agregado"].ToString();
			  lbl_Fecha_Modificacion.Text = dt.Tables[0].Rows[0]["Fecha_Modificacion"].ToString().Substring(1,10);
			  lbl_Usuario.Text = dt.Tables[0].Rows[0]["Usuario"].ToString();
		  }

		  private void Cargar_PersonalPorRut(string strRut)
		  {
			  Boolean bolverificar;
			  bolverificar = false;
              SqlCommand cmd = new SqlCommand();

//			  SqlCommand cmd = new SqlCommand();

              cmd.CommandText = "SELECT Id_Personal,id_cliente,rut_cliente,Rut,Nombres,Paterno,Maternos,Id_Seccion,Id_estado,Fecha_inicio,fecha_termino,Usuario,Fecha_agregado,GETDATE()as Fecha_Modificacion " +
                              " FROM tbl_personal WHERE  Rut='" + strRut + "'  and rut_cliente = '" + lbl_rut_cliente.Text + "' and id_cliente=" +  lbl_id_cliente.Text   + " and id_estado=1";
			  DataSet dt;
			  dt = Conectar.Listar(Clases.clsBD.BD,cmd);

			  if (dt.Tables[0].Rows.Count > 0)
			  {
				  
				  for (int i = 0; i <= dt.Tables[0].Rows.Count-1; i++)
				  {
                      if (lbl_id_cliente.Text == dt.Tables[0].Rows[i]["id_cliente"].ToString() && lbl_rut_cliente.Text == dt.Tables[0].Rows[i]["rut_cliente"].ToString())
						  bolverificar = true;
				  }
				  if (bolverificar == false)
				  {
					  txt_Nombres.Text = dt.Tables[0].Rows[0]["Nombres"].ToString();
					  txt_rut.Text = dt.Tables[0].Rows[0]["Rut"].ToString();
					  txt_Maternos.Text = dt.Tables[0].Rows[0]["Maternos"].ToString();
					  txt_paterno.Text = dt.Tables[0].Rows[0]["Paterno"].ToString();
					  txt_rut.Enabled = false;
					  txt_Nombres.Focus();
					  HabDesa_Controles(true);
				  }
				  else
				  {
					  MessageBox.Show("El personal ya fue ingresado al mismo cliente, no se puede repetir");
					  txt_rut.Focus();
				  }
			  }
			  else
			  {				  
				  HabDesa_Controles(true);
				  txt_Nombres.Enabled = true;
				  txt_rut.Enabled = true;
				  txt_Maternos.Enabled = true;
				  txt_paterno.Enabled = true;
				  txt_rut.Enabled = true;
			  }
			  if (btn_Grabar.Text == "Grabar")
                  cbx_id_estado.Enabled = false;
			 
		  }

		  private void Cargar_Seccion()
		  {
              SqlCommand cmd = new SqlCommand();

			//  SqlCommand cmd = new SqlCommand();

			  cmd.CommandText = "SELECT seccion,id_seccion " +
							  " FROM tbl_seccion  WHERE Id_cliente= " + lbl_id_cliente.Text.ToString() + " and id_estado=1";
			  DataSet dt;
			  dt = Conectar.Listar(Clases.clsBD.BD,cmd);
              cbx_id_seccion.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
              cbx_id_seccion.ValueMember = dt.Tables[0].Columns[1].Caption.ToString();
              cbx_id_seccion.DataSource = dt.Tables[0];

              //cbx_seccion.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
              //cbx_seccion.DataSource = dt.Tables[0];

              //cbx_id_seccion.DisplayMember = dt.Tables[0].Columns[1].Caption.ToString();
              //cbx_id_seccion.DataSource = dt.Tables[0];
			  
		  }

		  private void Cargar_Profesion()
		  {
              SqlCommand cmd = new SqlCommand();
			 // SqlCommand cmd = new SqlCommand();

              cmd.CommandText = "select id_profesion,Profesion,orden FROM glo_profesion order by Profesion";
			  DataSet dt;
			  dt = Conectar.Listar(Clases.clsBD.BD,cmd);
              cbx_id_profesion.DisplayMember = dt.Tables[0].Columns[1].Caption.ToString();
              cbx_id_profesion.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
              cbx_id_profesion.DataSource = dt.Tables[0];

              //cbx_profesion.DisplayMember = dt.Tables[0].Columns[1].Caption.ToString();
              //cbx_profesion.DataSource = dt.Tables[0];

              //cbx_id_profesion.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
              //cbx_id_profesion.DataSource = dt.Tables[0];

		  }

        private void Cargar_CodServicio()
        {
            ClaseComun.Listar_Parametro(Clases.clsBD.BD,ref cbx_Id_CodServicio, 16);
        }
        private void Cargar_Practica()
        {
            ClaseComun.Listar_Parametro(Clases.clsBD.BD,ref cbx_Id_Practica, 17);
        }
        private void Cargar_Cargo()
        {
            ClaseComun.Listar_Parametro(Clases.clsBD.BD,ref cbx_Id_Cargo, 18);
        }
        private void Cargar_sexo()
		  {

			 // SqlCommand cmd = new SqlCommand();
              SqlCommand cmd = new SqlCommand();
			  cmd.CommandText = "select Id_DetParametro,Glosa FROM conf_detparametro WHERE Id_Parametro=4 order by orden";
			  DataSet dt;
			  dt = Conectar.Listar(Clases.clsBD.BD,cmd);

              cbx_id_sexo.DisplayMember = dt.Tables[0].Columns[1].Caption.ToString();
              cbx_id_sexo.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
              cbx_id_sexo.DataSource = dt.Tables[0];

              //cbx_sexo.DisplayMember = dt.Tables[0].Columns[1].Caption.ToString();
              //cbx_sexo.DataSource = dt.Tables[0];

              //cbx_id_sexo.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
              //cbx_id_sexo.DataSource = dt.Tables[0];

		  }

        private void AsignarEvento()
								{
                                    SqlCommand cmd = new SqlCommand();
									//SqlCommand cmd = new SqlCommand();
									DataSet dt;
									string strname;
									foreach (Control c in tbl_personal.Controls )
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
              cbx_id_estado.Enabled = bolHabDesa;
			  cbx_id_seccion.Enabled = bolHabDesa;
			  cbx_id_profesion.Enabled = bolHabDesa;
			  cbx_id_sexo.Enabled = bolHabDesa;
			  if (bolHabDesa == false)
			  {
				  dtp_Fecha_inicio.Enabled = bolHabDesa;
				  dtp_fecha_termino.Enabled = bolHabDesa;
			  }
			  else
			  {
				  if (cbx_id_estado.Text == "1")
				  {
					  dtp_Fecha_inicio.Enabled = bolHabDesa;
					  dtp_fecha_termino.Enabled = false;
				  }
				  if (cbx_id_estado.Text == "2")
				  {
					  dtp_Fecha_inicio.Enabled = false;
					  dtp_fecha_termino.Enabled = bolHabDesa;
				  }
			  }

		  }

          private void LimpiarControles()
          {
              txt_rut.Text = "";
              txt_paterno.Text = "";
              txt_Nombres.Text = "";
              dtp_Fecha_inicio.Value = DateTime.Today;
              txt_Maternos.Text = "";
              txt_rut.Enabled = true;
              cbx_id_estado.SelectedIndex = 0;
              cbx_id_seccion.SelectedIndex = 0;
              cbx_id_profesion.SelectedIndex = 0;
              cbx_id_sexo.SelectedIndex = 0;
              HabDesa_Controles(false);
                 btn_Grabar.Text = "Grabar";
                this.Text = "Agregar Personal";            
			dtp_fecha_termino.Text = "01/01/1900";
            dtp_Fecha_Nac.Text = "01/01/1900";
            lbl_Usuario.Text = Clases.clsUsuario.Usuario;
            lbl_Fecha_agregado.Text = DateTime.Now.Date.ToString().Substring(1,10) ;
			lbl_Fecha_Modificacion.Text = DateTime.Now.Date.ToString().Substring(1, 10);
              txt_rut.Focus(); 
          }
        
        #endregion

        #region "button"

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
        
            //verificar_Grabado();
            this.Close();

            Cursor = Cursors.Default;
        }

        private void btn_Grabar_Click(object sender, EventArgs e)
        {
              Cursor = Cursors.WaitCursor;

			  Boolean bolResult;
			  bolResult = false;
       //     if (MessageBox.Show("Desea grabar la información", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
         //   {
                if (btn_Grabar.Text == "Modificar")
                {

						 ClaseComun.Modificar(Clases.clsBD.BD,tbl_personal, ref bolResult);
						 if (bolResult == true)
						 {
                             if (cbx_id_estado.Text == "2")
                             {
                                 if (lbl_Fecha_Modificacion.Text != cbx_id_estado.Text)
                                 {
                                     MessageBox.Show("Dato modificado,Debe ingresar una observación porque se dejo inactivo");
                                     //if (MessageBox.Show("Desea salir del formulario", "Confirmar", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                                     //{
                                     //    this.Close();
                                     //}
                                     //else
                                         LimpiarControles();
                                 }
                                 else
                                     //MessageBox.Show("Dato modificado");
                                     //if (MessageBox.Show("Desea salir del formulario", "Confirmar", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                                     //{
                                     //    this.Close();
                                     //}
                                     //else
                                         LimpiarControles();
                             }
                             else
                             {
                                 //MessageBox.Show("Dato modificado");
                                 //if (MessageBox.Show("Desea salir del formulario", "Confirmar", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                                 //{
                                 //    this.Close();
                                 //}
                                 //else
                                     LimpiarControles();
                             }
							 
						 }
						
                }
                else
                {
						 ClaseComun.Insertar(Clases.clsBD.BD,tbl_personal, ref bolResult);
						 if (bolResult == true)
						 {
							 MessageBox.Show("Dato Guardado");
                             //if (MessageBox.Show("Desea salir del formulario", "Confirmar", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                             //{
                             //    this.Close();
                             //}
                             //else
                                 LimpiarControles();
						 }
                }

            //   }

            Cursor = Cursors.Default;
            
        }

		  private void btn_Agregar_Click(object sender, EventArgs e)
		  {
			  frmSeccionMant frm = new frmSeccionMant(Convert.ToInt64(lbl_id_cliente.Text ), 0);
			  frm.ShowDialog(this);
			  Cargar_Seccion();
		  }

		  private void btn_Verificar_Click(object sender, EventArgs e)
		  {
              Cursor = Cursors.WaitCursor;

			  Cargar_PersonalPorRut(txt_rut.Text );

              Cursor = Cursors.Default;
		  }

		  private void btn_Limpiar_Click(object sender, EventArgs e)
		  {
              verificar_Grabado();
              LimpiarControles();
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
			if (cbx_id_estado.Text == "1")
			{
				dtp_fecha_termino.Enabled = false;
				dtp_Fecha_inicio.Enabled = true;
			}
			else
			{
				dtp_Fecha_inicio.Enabled = false;
				dtp_fecha_termino.Enabled = true;
			}

		}


        #endregion


    }
}
