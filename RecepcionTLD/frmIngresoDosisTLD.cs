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
    public partial class frmIngresoDosisTLD : Form
    {

        #region "Definicion variable"
				clsConectorSqlServer Conectar = new clsConectorSqlServer();
				clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
            clsEventoControl ClaseEvento = new clsEventoControl();
            int intContar=0;	
        #endregion

            public frmIngresoDosisTLD(Int64 intId_Cliente)
        {
            InitializeComponent();

            SqlCommand cmdcombo = new SqlCommand();
			//	SqlCommand cmdcombo = new SqlCommand();
				DataSet dtcombo;			
				cmdcombo.CommandText = "select 0 as Id_DetParametro, 'Seleccione' as Glosa, 0 as orden union all " +
				  "SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=2 order by orden ";
				cmdcombo.CommandType = CommandType.Text;
				dtcombo = Conectar.Listar(Clases.clsBD.BD,cmdcombo);

				DataGridViewComboBoxColumn comboboxColumn = grdDatos.Columns["Estado"] as DataGridViewComboBoxColumn;
				//
				comboboxColumn.DataSource = dtcombo.Tables[0] ;
				comboboxColumn.DisplayMember = "Glosa";
				comboboxColumn.ValueMember = "Id_DetParametro";
				AsignarEvento();
                Listar_Personal();
                pnl_Progreso.Visible = false;
        }

        #region "Llamada de carga"
        

		  private void Listar_Personal()
		  {
			 // SqlCommand cmd = new SqlCommand();
              SqlCommand cmd = new SqlCommand();

				DataSet dt;


                cmd.CommandText = "SELECT PosicionDisco,n_dosimetro,tld.N_Documento,p.id_cliente,p.Id_Personal,Rut,Paterno,Maternos,Nombres,isnull( d.Controlado,0)Controlado," +
                        "isnull(d.ConDosis,0)condosis,d.Dosis,isnull(d.Id_EstadoDosis,0)estadodosis, isnull(d.Id_Dosimetro,0)Id_Dosimetro,Cristal1,Cristal2,tld.id_periodo " +		
                        " FROM tbl_personal p inner join ges_dosimetro_estado_TLD tld on p.Id_Personal=tld.Id_Personal	 " + 
		                " left join tbl_dosimetria d on d.id_cliente=tld.id_cliente   and  d.id_personal=tld.id_personal  and   TLD=1 " +
	                    " where id_estadodosimetro=12    order by PosicionDisco";
			  cmd.CommandType = CommandType.Text;
	 
			  dt = Conectar.Listar(Clases.clsBD.BD,cmd);
			  grdDatos.DataSource = dt.Tables[0];

              string filterExp = "controlado = 1";
              string sortExp = "n_dosimetro";
              DataRow[] drarray;
              drarray = dt.Tables[0].Select(filterExp, sortExp, DataViewRowState.CurrentRows);

              groupBox2.Text = "Listado       Registro:" + drarray.Count().ToString();
              intContar = drarray.Count();
              //groupBox2   intContar
			  if (dt.Tables[0].Rows.Count == 0)
			  {
                  btn_Guardar.Visible = false;
				  MessageBox.Show("No se han cargado ningun personal o se asigno todo el personal para ese trimestre");				  
			  }
			  else
			  {
                  btn_Guardar.Visible = true;
				 // MessageBox.Show("Se encontraron personal asociado al cliente");				
			  }
		  }

        private void AsignarEvento()
        {       				
        }

        #endregion

        #region "button"

		  private void btnIngresarDosisISP_Click(object sender, EventArgs e)
		  {
              //frmDosimetriaISP frm = new frmDosimetriaISP(Convert.ToInt64(lbl_id_cliente.Text ));
              //frm.ShowDialog(this);
		  }
        
		 private void btn_Guardar_Click(object sender, EventArgs e)
		  {
              SqlCommand cmd = new SqlCommand();
				 // SqlCommand cmd = new SqlCommand();

				  // dtcombo = Conectar.Listar(Clases.clsBD.BD,cmdcombo);

				  DataGridViewCheckBoxCell checkCell;
				  DataGridViewCheckBoxCell chkcondosis;
				  DataGridViewTextBoxCell txtvalor;
                  DataGridViewTextBoxCell txtcristal1;
                  DataGridViewTextBoxCell txtcristal2;
                  DataGridViewTextBoxCell txtNPelicula;
				  DataGridViewTextBoxCell txtndocumento;
				  DataGridViewComboBoxCell cbxEstado;
				  string strn_cliente;
				  string strid_personal;
				  string strid_dosimetro;
                  String strid_periodo;
                  pnl_Progreso.Visible = true;
                  btn_Guardar.Enabled = false;
                  pnl_Progreso.Refresh();
                  pgb_Barra.Minimum = 0;
                  pgb_Barra.Maximum = grdDatos.RowCount ;
				  for (int i = 0; i <= grdDatos.RowCount - 1; i++)
				  {
                      pgb_Barra.Value = i+1;
                      pgb_Barra.Refresh();
					  checkCell = (DataGridViewCheckBoxCell)grdDatos.Rows[i].Cells["Controlado"];
					  chkcondosis = (DataGridViewCheckBoxCell)grdDatos.Rows[i].Cells["condosis"];
					  txtvalor = (DataGridViewTextBoxCell)grdDatos.Rows[i].Cells["valor"];
                      txtcristal1 = (DataGridViewTextBoxCell)grdDatos.Rows[i].Cells["cristal1"];
                      txtcristal2 = (DataGridViewTextBoxCell)grdDatos.Rows[i].Cells["cristal2"];
					  txtndocumento = (DataGridViewTextBoxCell)grdDatos.Rows[i].Cells["NDocumento"];
                      txtNPelicula = (DataGridViewTextBoxCell)grdDatos.Rows[i].Cells["n_dosimetro"];
					  cbxEstado = (DataGridViewComboBoxCell)grdDatos.Rows[i].Cells["Estado"];

					  strn_cliente = grdDatos.Rows[i].Cells["N_Cliente"].Value.ToString();
					  strid_personal = grdDatos.Rows[i].Cells["id_personal"].Value.ToString();
					  strid_dosimetro = grdDatos.Rows[i].Cells["id_dosimetro"].Value.ToString();
                      strid_periodo = grdDatos.Rows[i].Cells["id_periodo"].Value.ToString();
                      
					  if (txtvalor.Value.ToString()  == "")
						  txtvalor.Value = "0,00";
					  if ((txtndocumento.Value.ToString() == "") && (checkCell.Value.ToString() == "1"))
					  {
                          txtndocumento.Value = "0"; 
					  }

                      if (((chkcondosis.Value.ToString() == "0") && (checkCell.Value.ToString() == "1") && (cbxEstado.Value.ToString() == "0")) ||
                            ((checkCell.Value.ToString() == "1") && ((txtcristal1.Value.ToString() == "") || (txtcristal2.Value.ToString() == ""))))
                          {
                              MessageBox.Show("Ingrese un Estado Controlado en la fila "  + (i+1).ToString() );
                              grdDatos.Rows[i].Selected = true;
                              i = grdDatos.RowCount;
                          }
                          else
                          {
                              if ((strid_dosimetro == "0") && (Convert.ToInt64(checkCell.Value) == 1))
                              {
                                  cmd.CommandText = "INSERT INTO tbl_dosimetria(id_cliente,id_personal,N_Documento,Controlado, ConDosis,Id_EstadoDosis,Dosis,Id_Periodo,enviado,n_pelicula,[TLD],Cristal1,Cristal2)" +
                                                         "VALUES (" + strn_cliente + "," + strid_personal + "," + txtndocumento.Value.ToString() + "," +
                                                                     checkCell.Value.ToString() + "," + chkcondosis.Value.ToString() + "," + cbxEstado.Value.ToString() +
                                                                     ",cast(" + txtvalor.Value.ToString().Replace(",", ".") + " as decimal(10,2)), " + strid_periodo + ", 0," + txtNPelicula.Value.ToString() +
                                                                      " , 1," + txtcristal1.Value.ToString() + "," + txtcristal2.Value.ToString() + ") ";
                                  cmd.CommandType = CommandType.Text;
                                  Conectar.AgregarModificarEliminar(Clases.clsBD.BD,cmd);

                                  cmd.CommandText = "pa_DosimetroIngresoTLD_upd " + txtNPelicula.Value.ToString() + ",12,'" + Clases.clsUsuario.Usuario + "',''";
                                  cmd.CommandType = CommandType.Text;
                                  Conectar.AgregarModificarEliminar(Clases.clsBD.BD,cmd);
                              }
                              else
                              {
                                  if (Convert.ToInt64(checkCell.Value) == 1)
                                  {
                                      cmd.CommandText = "update tbl_dosimetria " +
                                                                 "set Controlado=" + checkCell.Value.ToString() + "," +
                                                                 "ConDosis=" + chkcondosis.Value.ToString() + "," +
                                                                 "Id_EstadoDosis=" + cbxEstado.Value.ToString() + "," +
                                                                 "Dosis=cast(" + txtvalor.Value.ToString().Replace(",", ".") + " as decimal(10,2))," +
                                                                 "Id_Periodo=" + strid_periodo + "," +
                                                                 "N_Documento=" + txtndocumento.Value.ToString() + "," +
                                                                 "n_pelicula=" + txtNPelicula.Value.ToString() + "," +
                                                                 "Cristal1=" + txtcristal1.Value.ToString()  + "," +
                                                                 "Cristal2=" + txtcristal2.Value.ToString() + 
                                                             " where id_dosimetro=" + strid_dosimetro;
                                      cmd.CommandType = CommandType.Text;
                                      Conectar.AgregarModificarEliminar(Clases.clsBD.BD,cmd);

                                      cmd.CommandText = "pa_DosimetroIngresoTLD_upd " + txtNPelicula.Value.ToString() + ",12,'" + Clases.clsUsuario.Usuario + "',''";
                                      cmd.CommandType = CommandType.Text;
                                      Conectar.AgregarModificarEliminar(Clases.clsBD.BD,cmd);

                                  }

                                  if (Convert.ToInt64(checkCell.Value) == 0)
                                  {
                                      cmd.CommandText = "delete from tbl_dosimetria " +
                                                             " where id_dosimetro=" + strid_dosimetro;
                                      cmd.CommandType = CommandType.Text;
                                      Conectar.AgregarModificarEliminar(Clases.clsBD.BD,cmd);

                                      //if (txtNPelicula.Value.ToString() != "")
                                      //{
                                      //    cmd.CommandText = "pa_DosimetroIngresoTLD_upd " + txtNPelicula.Value.ToString() + ",12,'" + Clases.clsUsuario.Usuario + "',''";
                                      //      cmd.CommandType = CommandType.Text;
                                      //      Conectar.AgregarModificarEliminar(Clases.clsBD.BD,cmd);
                                      //}
                                      
                                  }
                              }
                          }

				  }
                  Listar_Personal();
				  MessageBox.Show("Informacion grabada");
                  btn_Guardar.Enabled = true;  
                  pnl_Progreso.Visible = false;
		  }

		 private void btn_Cerrar_Click(object sender, EventArgs e)
		 {
             verificar_Grabado();
			 this.Close();
		 }

         void verificar_Grabado()
         {                
               
             if((grdDatos.RowCount>0) &&(intContar>0))            
                if (MessageBox.Show("Desea grabar la información", "Confirmar", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    btn_Guardar.PerformClick();                
         }

        #endregion

		  #region "combobox"


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

         private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
         {
            
         }

         private void grdDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
         {
         
         }

        #endregion

         private void btn_ocultar_Click(object sender, EventArgs e)
         {
             grdDatos.Focus();
         }

     
         private void grdDatos_KeyDown(object sender, KeyEventArgs e)
         {

             if ((grdDatos.CurrentCell.ColumnIndex == 0) || (grdDatos.CurrentCell.ColumnIndex == 1))
                 {
                     if (e.KeyCode == Keys.Delete)
                     {
                         grdDatos.Rows[grdDatos.CurrentRow.Index].Cells[0].Value = 0;
                         //numero de pelicula
                         grdDatos.Rows[grdDatos.CurrentRow.Index].Cells[1].Value = 0;
                     }
                 }
           
             
         }
                
    }
}
