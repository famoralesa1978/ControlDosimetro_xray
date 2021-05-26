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
using Microsoft.Reporting.WinForms;

namespace ControlDosimetro
{
    public partial class FrmDosimetriaPersonal : Form
    {

        #region "Definicion variable"
				clsConectorSqlServer Conectar = new clsConectorSqlServer();
				clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
            clsEventoControl ClaseEvento = new clsEventoControl();
            int intintId_Estado_temp = 0;
            int intContar=0;	
        #endregion

            public FrmDosimetriaPersonal(Int64 intId_Cliente)
        {
            InitializeComponent();

            //SqlCommand cmdcombo = new SqlCommand();
            ////	SqlCommand cmdcombo = new SqlCommand();
            //    DataSet dtcombo;			
            //    cmdcombo.CommandText = "select 0 as Id_DetParametro, 'Seleccione' as Glosa, 0 as orden union all " +
            //      "SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=2 order by orden ";
            //    cmdcombo.CommandType = CommandType.Text;
            //    dtcombo = Conectar.Listar(Clases.clsBD.BD,cmdcombo);

            //    //DataGridViewComboBoxColumn comboboxColumn = grdDatos.Columns["Estado"] as DataGridViewComboBoxColumn;
            //    ////
            //    //comboboxColumn.DataSource = dtcombo.Tables[0] ;
            //    //comboboxColumn.DisplayMember = "Glosa";
            //    //comboboxColumn.ValueMember = "Id_DetParametro";


				AsignarEvento();
				Cargar_Cliente(intId_Cliente);
				Cargar_Anno();
                btn_Imprimir.Visible = false;
                grp_Ingreso.Enabled = false;
                pnl_Progreso.Visible = false;
            
        }

        #region "Llamada de carga"


            private void Cargar_Cliente(Int64 intCodCliente)
				{
			SqlCommand cmd = new SqlCommand
			{
				CommandText = "select run,Razon_Social,N_Cliente_Ref,region + ','+ comuna +','+Direccion as Direccion ,r.Id_Region,c.Id_Provincia,c.Id_Comuna,Telefono, Id_TipoFuente,Id_estado,Fechainicio,servicio " +
											"  FROM tbl_cliente c inner join [dbo].[glo_region] r on c.Id_Region=r.Id_Region inner join glo_comuna co on co.id_comuna=c.id_comuna" +
											" WHERE Id_cliente= " + intCodCliente.ToString()
			};
			DataSet dt;

					dt = Conectar.Listar(Clases.clsBD.BD,cmd);

                    if (dt.Tables[0].Rows.Count > 0)
                    {
                        lbl_rut.Text = dt.Tables[0].Rows[0]["run"].ToString();
                        lbl_id_cliente.Text = intCodCliente.ToString();
                        lbl_nombreCliente.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
                        txt_Servicio.Text = dt.Tables[0].Rows[0]["servicio"].ToString();
                        Cargar_Sucursal();
                    }
                    else
                    {
                        grp_Ingreso.Enabled = false;
                        lbl_rut.Text = "";
                        lbl_nombreCliente.Text = "";
                        if(lbl_id_cliente.Text  != "")
                            MessageBox.Show("El cliente no existe");  
                    }
				}

		  private void Listar_Grilla()
		  {
              SqlCommand cmd = new SqlCommand();

				DataSet dt;


                cmd.CommandText = "SELECT G.[id],[id_estadodosimetro],n_documento,[n_dosimetro], Descripcion+ case when id_ref=1 then '/ref.' else '' end as Descripcion,replace([fecha_termino],'/',' - ')fecha" +
                                        " FROM ges_dosimetro_estado G inner join glo_estadodosimetro e on e.id=g.id_estadodosimetro" +
                                        " inner join conf_periodo per on g.id_periodo=per.id_periodo " +
                                        " WHERE id_cliente=" +  lbl_id_cliente.Text + "  and  g.id_periodo=" + cbx_id_periodo.SelectedValue + " " ;
			  cmd.CommandType = CommandType.Text;
	 
			  dt = Conectar.Listar(Clases.clsBD.BD,cmd);
			  grdDatos.DataSource = dt.Tables[0];

              if (dt.Tables[0].Rows.Count > 0)
              {
                  dtp_Fecha_inicio.Text = dt.Tables[0].Rows[0]["fecha"].ToString();
                  btn_Imprimir.Visible = true;
                  cbx_anno.Enabled = false;
                  cbx_id_periodo.Enabled = false;
                  grp_Ingreso.Enabled = true;
                  lbl_id_cliente.Enabled = false;
                  btn_cargar.Enabled = false;
              }
              else
              {
                  btn_Imprimir.Visible = false;
                  cbx_anno.Enabled = true;
                  cbx_id_periodo.Enabled = true;
                  grp_Ingreso.Enabled = false;
                  lbl_id_cliente.Enabled = true;
                  btn_cargar.Enabled = true;
              }
              //string filterExp = "id_cliente=" + lbl_id_cliente.Text;
              //string sortExp = "Per";
              //DataRow[] drarray;
              //drarray = dt.Tables[0].Select(filterExp, sortExp, DataViewRowState.CurrentRows);

            //  groupBox2.Text = "Listado       Registro:" + drarray.Count().ToString();
             // intContar = drarray.Count();
              //groupBox2   intContar
              //if (dt.Tables[0].Rows.Count == 0)
              //{
              //    btn_Guardar.Visible = false;
              //    MessageBox.Show("No se han cargado ningun número de pelicula para el cliente");				  
              //}
              //else
              //{
              //    btn_Guardar.Visible = true;
              //   // MessageBox.Show("Se encontraron personal asociado al cliente");				
              //}
		  }

		  private void Cargar_Anno()
		  {
			SqlCommand cmd = new SqlCommand
			{

				//	  SqlCommand cmd = new SqlCommand();

				CommandText = "SELECT distinct Anno FROM conf_periodo WHERE Id_TipoPeriodo=3"
			};
			//cmd.CommandText = "SELECT Id_Periodo,Anno, Mes,Id_TipoPeriodo FROM conf_periodo WHERE Id_TipoPeriodo=3";
			DataSet dt;
			  dt = Conectar.Listar(Clases.clsBD.BD,cmd);

			  cbx_anno.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
			  cbx_anno.DataSource = dt.Tables[0];

		  }

          private void Cargar_NDocumento()
          {
			SqlCommand cmd = new SqlCommand
			{

				//	  SqlCommand cmd = new SqlCommand();

				CommandText = "SELECT distinct N_Documento FROM [dbo].[ges_dosimetro_estado] WHERE id_cliente=" + lbl_id_cliente.Text + "  and  id_periodo=" + cbx_id_periodo.SelectedValue
			};
			//cmd.CommandText = "SELECT Id_Periodo,Anno, Mes,Id_TipoPeriodo FROM conf_periodo WHERE Id_TipoPeriodo=3";
			DataSet dt;
              dt = Conectar.Listar(Clases.clsBD.BD,cmd);
              
              cbx_NDocumento.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
              cbx_NDocumento.DataSource = dt.Tables[0];

          }

          private int Verificar_NDocumento()
          {
              SqlCommand cmd = new SqlCommand();

              DataSet dt;


              cmd.CommandText = "SELECT G.[id],[id_estadodosimetro],n_documento,[n_dosimetro], Descripcion" +
                                      " FROM ges_dosimetro_estado G inner join glo_estadodosimetro e on e.id=g.id_estadodosimetro" +
                                      " WHERE ((id_cliente <>" + lbl_id_cliente.Text + " ) or" +
                                       " (id_cliente =" + lbl_id_cliente.Text + "  and  id_periodo<>" + cbx_id_periodo.SelectedValue  + ")) " +
                                      " and n_documento=" + txt_NDocumento.Text;
              cmd.CommandType = CommandType.Text;

              dt = Conectar.Listar(Clases.clsBD.BD,cmd);

              if (dt.Tables[0].Rows.Count > 0)
              {
                  return 1;
              }
              else
                  return 0;
          }

          private void Cargar_Periodo()
          {
			SqlCommand cmd = new SqlCommand
			{

				//	  SqlCommand cmd = new SqlCommand();

				CommandText = "SELECT Id_Periodo,Mes, cast((mes/3) as varchar(10))+ '°T' FROM conf_periodo WHERE Id_TipoPeriodo=3 and Anno=" + cbx_anno.Text
			};
			DataSet dt;
              dt = Conectar.Listar(Clases.clsBD.BD,cmd);

              cbx_id_periodo.DisplayMember = dt.Tables[0].Columns[2].Caption.ToString();
              cbx_id_periodo.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
              cbx_id_periodo.DataSource = dt.Tables[0];

              //cbx_periodo.DisplayMember = dt.Tables[0].Columns[2].Caption.ToString();
              //cbx_periodo.DataSource = dt.Tables[0];

              //cbx_id_periodo.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
              //cbx_id_periodo.DataSource = dt.Tables[0];
          }

          private void Cargar_Sucursal()
          {
			SqlCommand cmd = new SqlCommand
			{

				//	  SqlCommand cmd = new SqlCommand();

				CommandText = "select id_sucursal, direccion + ','+co.comuna as Dato " +
					"from [dbo].[tbl_sucursal] s " +
					"inner join glo_region r on r.Id_region=s.Id_Region " +
					"inner join glo_comuna co on co.id_comuna=s.Id_Comuna " +
					"where run='" + lbl_rut.Text + "' and s.id_estado=1"
			};
			DataSet dt;
              dt = Conectar.Listar(Clases.clsBD.BD,cmd);

              cbx_Sucursal.DisplayMember = dt.Tables[0].Columns[1].Caption.ToString();
              cbx_Sucursal.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
              cbx_Sucursal.DataSource = dt.Tables[0];

              //cbx_periodo.DisplayMember = dt.Tables[0].Columns[2].Caption.ToString();
              //cbx_periodo.DataSource = dt.Tables[0];

              //cbx_id_periodo.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
              //cbx_id_periodo.DataSource = dt.Tables[0];
          }

        private void AsignarEvento()
        {           
				//this.txt_Rut.KeyPress += new KeyPressEventHandler(ClaseEvento.Rut_KeyPress);
				//txt_Rut.KeyDown += new KeyEventHandler(ClaseEvento.Rut_KeyDown);
				//txt_Rut.Validated += new EventHandler(ClaseEvento.validarut_Validated);
          //  txt_NDocumento.KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
           // txt_NDocumento.KeyDown += new KeyEventHandler(ClaseEvento.Numero_KeyDown);
           // dtp_Fecha_inicio.KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
				//txt_RazonSocial.KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);

				
        }

        #endregion

        #region "button"

		  private void BtnIngresarDosisISP_Click(object sender, EventArgs e)
		  {
			  frmDosimetriaISP frm = new frmDosimetriaISP(Convert.ToInt64(lbl_id_cliente.Text ));
			  frm.ShowDialog(this);
		  }


        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds;
            btn_Agregar.Enabled = false;
            cmd.CommandText = "pa_DosimetroPersonal_ins " + lbl_id_cliente.Text + "," + cbx_id_periodo.SelectedValue + ","+ cbx_Sucursal.SelectedValue  + ",'" + txt_Servicio.Text + "'," + cbx_NDocumento.Text  + ",'" + dtp_Fecha_inicio.Text.Replace("-"," de ") + "'";
            cmd.CommandType = CommandType.Text;

            ds = Conectar.Listar(Clases.clsBD.BD,cmd);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (ds.Tables[0].Rows[0][0].ToString() != "0")
                        MessageBox.Show(ds.Tables[0].Rows[0][1].ToString());
                }

              //  Grabar_Estado();
            btn_Agregar.Enabled = true;
            Listar_Grilla();
            MessageBox.Show("Informacion grabada");
        }		

		  private void Btn_Filtro_Click(object sender, EventArgs e)
		  {
			  //txt_ref_cliente.ReadOnly = false;
			  //txt_Rut.ReadOnly = false;
			  //txt_ref_cliente.Text = "";
			  //txt_Rut.Text = "";
			  //txt_RazonSocial.Text = "";
			  //Listar_Cliente(0);
			  //Listar_Personal();
			  //txt_ref_cliente.Focus();
		  }

		  private void Btn_cargar_Click(object sender, EventArgs e)
		  {
              Cargar_Cliente(Convert.ToInt64(lbl_id_cliente.Text));  
			  Listar_Grilla();
              Cargar_NDocumento();
			
              intContar = 0;               
		  }

		 private void Btn_filtro_Click_1(object sender, EventArgs e)
		 {
			 cbx_anno.Enabled = true;
             cbx_id_periodo.Enabled = true;
             grp_Ingreso.Enabled = false;
             btn_cargar.Enabled = true;
             btn_Imprimir.Enabled = false;
             lbl_id_cliente.Enabled = true;
             lbl_id_cliente.Text = "0";
             Listar_Grilla();
             lbl_id_cliente.Text = "";
             Cargar_Cliente(0);
             lbl_id_cliente.Focus();
             intContar = 0;
		 }

		 private void Btn_Cerrar_Click(object sender, EventArgs e)
		 {
			 this.Close();
		 }

         private void TsmEliminar_Click(object sender, EventArgs e)
         {
			SqlCommand cmd = new SqlCommand
			{
				CommandText = "pa_Dosimetro_del " + grdDatos.SelectedCells[0].Value.ToString() + ",'" + Clases.clsUsuario.Usuario + "'",
				CommandType = CommandType.Text
			};
			DataSet ds;

            ds = Conectar.Listar(Clases.clsBD.BD,cmd);
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show(ds.Tables[0].Rows[0][1].ToString());    
            }
          
            Listar_Grilla();
             
         }

         private void BtnGrabarMod_Click(object sender, EventArgs e)
         {
             if (Verificar_NDocumento() == 0)
             {
                 if (MessageBox.Show("Desea cambiar el número de documento", "Cambio de N° Documento", MessageBoxButtons.YesNo) == DialogResult.Yes)
                 {
					SqlCommand cmd = new SqlCommand
					{
						CommandText = "pa_CambiarNDocumento_upd " + cbx_NDocumento.Text + "," + txt_NDocumento.Text,
						CommandType = CommandType.Text
					};
					Conectar.AgregarModificarEliminar(Clases.clsBD.BD,cmd);


                     txt_NDocumento.Text = "";
                     Listar_Grilla();
                     MessageBox.Show("Cambio realizado"); 
                 }
             }
         }
		 


         void Grabar_Estado()
         {
             SqlCommand cmd = new SqlCommand();
             // SqlCommand cmd = new SqlCommand();

             //// dtcombo = Conectar.Listar(Clases.clsBD.BD,cmdcombo);

            
             string strId;
             pnl_Progreso.Visible = true;
             pnl_Progreso.Refresh();
             pgb_Barra.Minimum = 0;
             pgb_Barra.Maximum = grdDatos.RowCount;
             for (int i = 0; i <= grdDatos.RowCount - 1; i++)
             {
                 pgb_Barra.Value = i + 1;
                 pgb_Barra.Refresh();

                 strId = grdDatos.Rows[i].Cells["id"].Value.ToString();

                     cmd.CommandText = "pa_Dosimetro_upd " + strId + "," + intintId_Estado_temp.ToString() + ",'" + Clases.clsUsuario.Usuario + "','" + txt_Observacion.Text + "'" ;
                     cmd.CommandType = CommandType.Text;
                     Conectar.AgregarModificarEliminar(Clases.clsBD.BD,cmd);
               


             }
             
       
             pnl_Progreso.Visible = false;

         }
      
        #endregion

		  #region "combobox"

		  private void Cbx_anno_SelectedIndexChanged(object sender, EventArgs e)
		  {
			  Cargar_Periodo();
		  }

		  #endregion

		  #region "grilla"

		  private void GrdDatos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		  {
			  if (grdDatos.IsCurrentCellDirty)
			  {
				  grdDatos.CommitEdit(DataGridViewDataErrorContexts.Commit);
			  }
		  }

		  private void GrdDatos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		  {
			  if ((grdDatos.Columns[e.ColumnIndex].Name == "Controlado")||(grdDatos.Columns[e.ColumnIndex].Name == "condosis"))
			  {
				  DataGridViewCheckBoxCell checkCell =	(DataGridViewCheckBoxCell)grdDatos.Rows[e.RowIndex].Cells["Controlado"];
				  DataGridViewCheckBoxCell chkcondosis = (DataGridViewCheckBoxCell)grdDatos.Rows[e.RowIndex].Cells["condosis"];
				  DataGridViewTextBoxCell  txtvalor = (DataGridViewTextBoxCell)grdDatos.Rows[e.RowIndex].Cells["valor"];				
				  DataGridViewComboBoxCell cbxEstado = (DataGridViewComboBoxCell)grdDatos.Rows[e.RowIndex].Cells["Estado"];
				  if (Convert.ToInt64(checkCell.Value) == 1)
				  {
					  chkcondosis.ReadOnly = false;
                      intContar = intContar + 1;
                      groupBox2.Text = "Listado       Registro:" + intContar.ToString();
                      
					  if (Convert.ToInt64(chkcondosis.Value) == 1)
					  {
						  txtvalor.ReadOnly = false;
						  cbxEstado.ReadOnly = true;
						  cbxEstado.Value = 0;
					  }
					  else
					  {
						  txtvalor.ReadOnly = true;
						  txtvalor.Value = 0.00;
						  cbxEstado.ReadOnly = false;
					  }
				  }
				  else
				  {
					  txtvalor.ReadOnly = true;
					  chkcondosis.ReadOnly = true;
					  chkcondosis.ReadOnly = true;
					  cbxEstado.ReadOnly = true;
                      intContar = intContar - 1;
                      groupBox2.Text = "Listado       Registro:" + intContar.ToString();
				  }
			  }		  
			  
		  }
        #endregion

         private void Btn_Imprimir_Click(object sender, EventArgs e)
         {
              DataSet ds = new DataSet();
              DataSet ds2 = new DataSet();
			SqlCommand cmd = new SqlCommand
			{
				CommandText = "rtpDosimetriaPersonal_Enc " + lbl_id_cliente.Text + "," + cbx_id_periodo.SelectedValue + "," + cbx_NDocumento.Text,
				CommandType = CommandType.Text
			};

			ds = Conectar.Listar(Clases.clsBD.BD,cmd);

             cmd.CommandText = "rtpDosimetriaPersonal_det " + lbl_id_cliente.Text + "," + cbx_id_periodo.SelectedValue + "," + cbx_NDocumento.Text;
             cmd.CommandType = CommandType.Text;

             ds2 = Conectar.Listar(Clases.clsBD.BD,cmd);
             //pnl_sobre.Visible = true;
             frmreporte frm = new frmreporte(ds, ds2, 1);
             frm.Show(this);

             
         }

         private void FrmIngresoPelicula_Load(object sender, EventArgs e)
         {

         }




        
         private void Btn_Ocultar_Click(object sender, EventArgs e)
         {
           //pnl_sobre.Visible = false;
         }

         private void Cbx_NDocumento_SelectedIndexChanged(object sender, EventArgs e)
         {
             DataSet ds = new DataSet();
			SqlCommand cmd = new SqlCommand
			{
				CommandText = "pa_DosimetroPersonal_sel " + lbl_id_cliente.Text + "," + cbx_id_periodo.SelectedValue + "," + cbx_NDocumento.Text,
				CommandType = CommandType.Text
			};

			ds = Conectar.Listar(Clases.clsBD.BD,cmd);

             if (ds.Tables[0].Rows.Count > 0)
             {
                 txt_Servicio.Text = ds.Tables[0].Rows[0]["Servicio"].ToString();
                 dtp_Fecha_inicio.Text = ds.Tables[0].Rows[0]["Devuelta"].ToString().Replace("de", "-");
                 cbx_Sucursal.SelectedValue = ds.Tables[0].Rows[0]["Id_sucursal"].ToString();
             }
             else
             {
                 txt_Servicio.Text = "";
             }
         }

         private void PctAgregarSucursal_Click(object sender, EventArgs e)
         {
             frmBusquedaSucursal frm = new frmBusquedaSucursal(Convert.ToInt32(lbl_id_cliente.Text));
             frm.ShowDialog(this);
             Cargar_Sucursal();
         }

    }
}
