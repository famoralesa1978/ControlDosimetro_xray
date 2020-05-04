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
    public partial class frmRecepcionPelicula : Form
    {

        #region "Definicion variable"
				clsConectorSqlServer Conectar = new clsConectorSqlServer();
				clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
            clsEventoControl ClaseEvento = new clsEventoControl();
            int intContar=0;
            int intintId_Estado_temp;
        #endregion

            public frmRecepcionPelicula(int intId_Estado)
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
                intintId_Estado_temp = intId_Estado;
                switch (intintId_Estado_temp)
                {
                    case 0:
                        this.Text = "Envio Dosimetros";
                        break;
                    case 1:
                        this.Text = "Recepción Dosimetros";
                        break;
                    case 6:
                        this.Text = "Informe Generado";
                        break;
                }

				Cargar_Anno();
                lbl_nombreCliente.Text = "";
                txt_CodCliente.Focus();
                pnl_Progreso.Visible = false;
            
        }

        #region "Llamada de carga"

            private void Cargar_Cliente(Int64 intCodCliente)
				{
                    SqlCommand cmd = new SqlCommand();
					cmd.CommandText = "SELECT run,Razon_Social,N_Cliente_Ref,Direccion,Id_Region,Id_Provincia,Id_Comuna,Telefono, Id_TipoFuente,Id_estado,Fechainicio " +
									" FROM tbl_cliente WHERE Id_cliente= " + txt_CodCliente.Text;
					DataSet dt;

					dt = Conectar.Listar(Clases.clsBD.BD,cmd);
                    if (dt.Tables[0].Rows.Count > 0)
                        lbl_nombreCliente.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
                    else
                        lbl_nombreCliente.Text = "";
				}

		  private void Listar_Grilla()
		  {
              SqlCommand cmd = new SqlCommand();
              Int64  intN_Documento;
              if (txt_NDocumento.Text == "")
              {
                  intN_Documento = 0;
              }
              else
                  intN_Documento = Convert.ToInt64 (txt_NDocumento.Text);

				DataSet dt;
              //  switch (intintId_Estado_temp)
              //  {
              //      case 0:
                        cmd.CommandText = "pa_Dosimetro_sel " + txt_CodCliente.Text + "," + cbx_id_periodo.SelectedValue + "," + intintId_Estado_temp.ToString() + "," + intN_Documento.ToString();
              //          break;
              //      case 2:
              //          cmd.CommandText = "pa_Dosimetro_sel " + txt_CodCliente.Text + "," + cbx_id_periodo.Text + "," + intintId_Estado_temp.ToString() + "," + intN_Documento.ToString();
              //          break;
              //  }
                      cmd.CommandType = CommandType.Text ;
	 
			  dt = Conectar.Listar(Clases.clsBD.BD,cmd);

              grdDatos.DataSource = dt.Tables[0];

              if(txt_CodCliente.Text!="0")
                if(dt.Tables [0].Rows.Count ==0) 
                  MessageBox.Show("No se ha ingresado información");

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
              SqlCommand cmd = new SqlCommand();

		//	  SqlCommand cmd = new SqlCommand();

			  cmd.CommandText = "SELECT distinct Anno FROM conf_periodo WHERE Id_TipoPeriodo=3";
			  //cmd.CommandText = "SELECT Id_Periodo,Anno, Mes,Id_TipoPeriodo FROM conf_periodo WHERE Id_TipoPeriodo=3";
			  DataSet dt;
			  dt = Conectar.Listar(Clases.clsBD.BD,cmd);

			  cbx_anno.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
			  cbx_anno.DataSource = dt.Tables[0];

		  }

          private void Cargar_Periodo()
          {
              SqlCommand cmd = new SqlCommand();

              //	  SqlCommand cmd = new SqlCommand();

              cmd.CommandText = "SELECT Id_Periodo,Mes, cast((mes/3) as varchar(10))+ '°T' FROM conf_periodo WHERE Id_TipoPeriodo=3 and Anno=" + cbx_anno.Text;
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

        private void AsignarEvento()
        {           
				//this.txt_Rut.KeyPress += new KeyPressEventHandler(ClaseEvento.Rut_KeyPress);
				//txt_Rut.KeyDown += new KeyEventHandler(ClaseEvento.Rut_KeyDown);
				//txt_Rut.Validated += new EventHandler(ClaseEvento.validarut_Validated);

            txt_CodCliente.KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
            txt_CodCliente.KeyDown += new KeyEventHandler(ClaseEvento.Numero_KeyDown);

            txt_NDocumento.KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
            txt_NDocumento.KeyDown += new KeyEventHandler(ClaseEvento.Numero_KeyDown);
            
				//txt_RazonSocial.KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);

				
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
            DataGridViewCheckBoxCell checkMarca;
            string strId;
            pnl_Progreso.Visible = true;
            btn_Guardar.Enabled = false;
            pnl_Progreso.Refresh();
            pgb_Barra.Minimum = 0;
            pgb_Barra.Maximum = grdDatos.RowCount;
            for (int i = 0; i <= grdDatos.RowCount - 1; i++)
            {
                pgb_Barra.Value = i + 1;
                pgb_Barra.Refresh();
                checkMarca = (DataGridViewCheckBoxCell)grdDatos.Rows[i].Cells["Marca"];
         
                strId = grdDatos.Rows[i].Cells["id"].Value.ToString();

                if (checkMarca.Value.ToString() == "1")
                {
                    cmd.CommandText = "pa_Dosimetro_upd " + strId + "," + intintId_Estado_temp.ToString() + ",'" + Clases.clsUsuario.Usuario + "','" + txt_Observacion.Text + "'";
                    cmd.CommandType = CommandType.Text;
                    Conectar.AgregarModificarEliminar(Clases.clsBD.BD,cmd);
                }
                else
                {
                    cmd.CommandText = "pa_Dosimetro_SinMarca_upd " + strId + "," + intintId_Estado_temp.ToString() + ",'" + Clases.clsUsuario.Usuario + "'";
                    cmd.CommandType = CommandType.Text;
                    Conectar.AgregarModificarEliminar(Clases.clsBD.BD,cmd);
                }


            }
            Listar_Grilla();
            MessageBox.Show("Informacion grabada");
            btn_Guardar.Enabled = true;
            pnl_Progreso.Visible = false;
        }

		  private void btn_Filtro_Click(object sender, EventArgs e)
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

		  private void btn_cargar_Click(object sender, EventArgs e)
		  {
              Cargar_Cliente(Convert.ToInt64(txt_CodCliente.Text));
              if (lbl_nombreCliente.Text != "")
              {
                  Listar_Grilla();
                  cbx_anno.Enabled = false;
                  cbx_id_periodo.Enabled = false;
                  txt_CodCliente.Enabled = false;
                  intContar = 0;
              }
              else
                  MessageBox.Show("El cliente no existe"); 
			             
		  }

		 private void btn_filtro_Click_1(object sender, EventArgs e)
		 {
			 cbx_anno.Enabled = true;
			 cbx_id_periodo.Enabled = true;
             txt_CodCliente.Text = "";
             txt_CodCliente.Enabled = true;             
             txt_CodCliente.Text = "0";
             Listar_Grilla();
             txt_CodCliente.Text = "";
             txt_CodCliente.Focus();
             intContar = 0;
		 }

		 private void btn_Cerrar_Click(object sender, EventArgs e)
		 {
			 this.Close();
		 }

      
        #endregion

		  #region "combobox"

		  private void cbx_anno_SelectedIndexChanged(object sender, EventArgs e)
		  {
			  Cargar_Periodo();
		  }

		  #endregion

		  #region "grilla"

		  private void grdDatos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		  {
			  if (grdDatos.IsCurrentCellDirty)
			  {
				  grdDatos.CommitEdit(DataGridViewDataErrorContexts.Commit);
			  }
		  }

		  private void grdDatos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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

         private void grdDatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
          {
              //if (e.ColumnIndex == 9) //Column ColB
              //{
              //    if (e.Value != null)
              //    {
              //        try
              //        {
              //            e.CellStyle.Format = "N2";
              //        }
              //        catch (Exception)
              //        {

              //            MessageBox.Show("Ingrese solo número");
              //        }

                      
              //    }
              //}

//              private void dataGridView1_CellValidating(object sender,
//    DataGridViewCellValidatingEventArgs e)
//{
//    dataGridView1.Rows[e.RowIndex].ErrorText = "";
//    int newInteger;

//    // Don't try to validate the 'new row' until finished 
//    // editing since there
//    // is not any point in validating its initial value.
//    if (dataGridView1.Rows[e.RowIndex].IsNewRow) { return; }
//    if (!int.TryParse(e.FormattedValue.ToString(),
//        out newInteger) || newInteger < 0)
//    {
//        e.Cancel = true;
//        dataGridView1.Rows[e.RowIndex].ErrorText = "the value must be a non-negative integer";
//    }
//}
          }

        #endregion

         private void chk_marcar_CheckedChanged(object sender, EventArgs e)
         {
             pnl_Progreso.Refresh();
             pgb_Barra.Minimum = 0;
             DataGridViewCheckBoxCell checkMarca;
             pgb_Barra.Maximum = grdDatos.RowCount;
             for (int i = 0; i <= grdDatos.RowCount - 1; i++)
             {
                 pgb_Barra.Value = i + 1;
                 pgb_Barra.Refresh();
                 checkMarca = (DataGridViewCheckBoxCell)grdDatos.Rows[i].Cells["Marca"];
                 checkMarca.Value =chk_marcar.Checked; 
             }
             btn_Guardar.Enabled = true;
             pnl_Progreso.Visible = false;
         }

      

        

    

          
	
		 
		  
		

	
    }
}
