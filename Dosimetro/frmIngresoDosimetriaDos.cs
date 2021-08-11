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
using classFuncionesBD;

namespace ControlDosimetro
{
	public partial class frmIngresoDosimetriaDos : Form
	{

		#region "Definicion variable"
		Clases.ClassEvento clsEvt = new Clases.ClassEvento();
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();
		ClsFunciones clsFunc = new ClsFunciones();
		classFuncionesBD.ClsFunciones func = new ClsFunciones();
		DataSet dtayuda;
		DataTable dtGrilla;
		int intContar = 0;
		bool bolDesdeinicio;

		#endregion

		public frmIngresoDosimetriaDos(Int64 intId_Cliente)
		{
			InitializeComponent();
			bolDesdeinicio = true;
			SqlCommand cmdcombo = new SqlCommand();
			//	SqlCommand cmdcombo = new SqlCommand();
			DataSet dtcombo;
			cmdcombo.CommandText = "select 0 as Id_DetParametro, 'Seleccione' as Glosa, 0 as orden union all " +
			  "SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=2 order by orden ";
			cmdcombo.CommandType = CommandType.Text;
			dtcombo = Conectar.Listar(Clases.clsBD.BD, cmdcombo);

			DataGridViewComboBoxColumn comboboxColumn = grdDatos.Columns["Estado"] as DataGridViewComboBoxColumn;
			//
			comboboxColumn.DataSource = dtcombo.Tables[0];
			comboboxColumn.DisplayMember = "Glosa";
			comboboxColumn.ValueMember = "Id_DetParametro";


			AsignarEvento();
			Cargar_Anno();
			grdDatos.AutoGenerateColumns = false;
			btn_LimpiarFiltro(null, null);
			pnl_Progreso.Visible = false;
			bolDesdeinicio = false;
		}

		#region "Llamada de carga"

		private void Cargar_Datos()
		{
			Cursor = Cursors.WaitCursor;
			clsFunc.Cargar_Cliente((int)cbx_id_periodo.SelectedValue, Convert.ToInt64(txt_id_cliente.Text.ToString()), ref lbl_rut_cliente, ref lbl_nombreCliente);
			SqlCommand cmdcombo = new SqlCommand();
			DataSet dtcombo;
			cmdcombo.CommandText = "pa_IngresoDosimetroPorDosimetro_sel " + cbx_id_periodo.SelectedValue + "," + txt_id_cliente.Text + ",12";
			cmdcombo.CommandType = CommandType.Text;
			dtcombo = Conectar.Listar(Clases.clsBD.BD, cmdcombo);

			if (dtcombo.Tables[0].Rows.Count == 1)
			{
				btn_cargar.Enabled = true;
				btn_Agregar.Enabled = false;
				MessageBox.Show(ControlDosimetro.Properties.Resources.msgNoExisteError, ControlDosimetro.Properties.Resources.msgCaptionError,MessageBoxButtons.OK,MessageBoxIcon.Error);
				btn_LimpiarFiltro(null, null);
			}				
			else
			if (dtcombo.Tables[0].Rows.Count >1)
			{
				btn_cargar.Enabled = false;
				btn_Agregar.Enabled = true;
				grp_Detalle.Enabled = true;
				btn_Guardar.Enabled = true;
				cbx_anno.Enabled = false;
				cbx_id_periodo.Enabled = false;
				txt_id_cliente.Enabled = false;
				dtGrilla=dtcombo.Tables[1];
				cbx_NDocumento.DataSource = dtcombo.Tables[0];
				
			}

			Cursor = Cursors.Default;
		}

		private void Listar_Personal()
		{
			// SqlCommand cmd = new SqlCommand();
			SqlCommand cmd = new SqlCommand();

			DataSet dt;


			cmd.CommandText = "SELECT N_pelicula,N_Documento,p.id_cliente,p.Id_Personal,Rut,Paterno,Maternos,Nombres,isnull( d.Controlado,0)Controlado, " +
											"isnull(d.ConDosis,0)condosis,d.Dosis,isnull(d.Id_EstadoDosis,0)estadodosis, isnull(d.Id_Dosimetro,0)Id_Dosimetro " +
											//"isnull(d.enviado,0)enviado " +
											" FROM tbl_personal p left join tbl_dosimetria d on d.id_cliente=p.id_cliente   and  p.id_personal=d.id_personal " +
											" and id_periodo=" + cbx_id_periodo.SelectedValue + " " +
							  " WHERE p.id_cliente=" + txt_id_cliente.Text + " and p.id_estado=1 and isnull(d.enviado,0)=0" +
											" and rut_cliente='" + lbl_rut_cliente.Text + "'" +
							  " order by Paterno,Maternos;";
			cmd.CommandType = CommandType.Text;

			dt = Conectar.Listar(Clases.clsBD.BD, cmd);
			grdDatos.DataSource = dt.Tables[0];

			string filterExp = "controlado = 1";
			string sortExp = "N_pelicula";
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

		private void Cargar_Anno()
		{
			SqlCommand cmd = new SqlCommand();

			//	  SqlCommand cmd = new SqlCommand();

			cmd.CommandText = "SELECT distinct Anno FROM conf_periodo WHERE Id_TipoPeriodo=3";
			//cmd.CommandText = "SELECT Id_Periodo,Anno, Mes,Id_TipoPeriodo FROM conf_periodo WHERE Id_TipoPeriodo=3";
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			cbx_anno.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
			cbx_anno.DataSource = dt.Tables[0];

		}

		private void Cargar_Periodo()
		{
			SqlCommand cmd = new SqlCommand();

			//	  SqlCommand cmd = new SqlCommand();

			cmd.CommandText = "SELECT Id_Periodo,Mes, cast((mes/3) as varchar(10))+ '°T' FROM conf_periodo WHERE Id_TipoPeriodo=3 and Anno=" + cbx_anno.Text;
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

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
			clsEvt.AsignarNumero(ref txt_id_cliente);
		}

		#endregion

		#region "button"

		private void BtnIngresarDosisISP_Click(object sender, EventArgs e)
		{
			frmDosimetriaISP frm = new frmDosimetriaISP(Convert.ToInt64(txt_id_cliente.Text));
			frm.ShowDialog(this);
		}


		private void Btn_Agregar_Click(object sender, EventArgs e)
		{
			verificar_Grabado();
			frmPersonalMant frm = new frmPersonalMant(Convert.ToInt64(txt_id_cliente.Text), 0);
			frm.ShowDialog(this);
			Listar_Personal();

		}


		private void Btn_cargar_Click(object sender, EventArgs e)
		{
			if (bolDesdeinicio == false)
			{
				if ((txt_id_cliente.Text != "-1") && (!String.IsNullOrEmpty(txt_id_cliente.Text)))
					Cargar_Datos();
				else
					if(String.IsNullOrEmpty(txt_id_cliente.Text))
					MessageBox.Show(ControlDosimetro.Properties.Resources.msgErrorFaltaCliente, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Btn_Guardar_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand();
			// SqlCommand cmd = new SqlCommand();

			// dtcombo = Conectar.Listar(Clases.clsBD.BD,cmdcombo);

			DataGridViewCheckBoxCell checkCell;
			DataGridViewCheckBoxCell chkcondosis;
			DataGridViewTextBoxCell txtvalor;
			DataGridViewTextBoxCell txtNPelicula;
			DataGridViewTextBoxCell txtndocumento;
			DataGridViewComboBoxCell cbxEstado;
			string strn_cliente;
			string strid_personal;
			string strid_dosimetro;
			pnl_Progreso.Visible = true;
			btn_Guardar.Enabled = false;
			pnl_Progreso.Refresh();
			pgb_Barra.Minimum = 0;
			pgb_Barra.Maximum = grdDatos.RowCount;
			for (int i = 0; i <= grdDatos.RowCount - 1; i++)
			{
				pgb_Barra.Value = i + 1;
				pgb_Barra.Refresh();
				checkCell = (DataGridViewCheckBoxCell)grdDatos.Rows[i].Cells["Controlado"];
				chkcondosis = (DataGridViewCheckBoxCell)grdDatos.Rows[i].Cells["condosis"];
				txtvalor = (DataGridViewTextBoxCell)grdDatos.Rows[i].Cells["valor"];
				txtndocumento = (DataGridViewTextBoxCell)grdDatos.Rows[i].Cells["NDocumento"];
				txtNPelicula = (DataGridViewTextBoxCell)grdDatos.Rows[i].Cells["N_Pelicula"];
				cbxEstado = (DataGridViewComboBoxCell)grdDatos.Rows[i].Cells["Estado"];

				strn_cliente = grdDatos.Rows[i].Cells["N_Cliente"].Value.ToString();
				strid_personal = grdDatos.Rows[i].Cells["id_personal"].Value.ToString();
				strid_dosimetro = grdDatos.Rows[i].Cells["id_dosimetro"].Value.ToString();
				if (txtvalor.Value.ToString() == "")
					txtvalor.Value = "0,00";
				if ((txtndocumento.Value.ToString() == "") && (checkCell.Value.ToString() == "1"))
				{
					txtndocumento.Value = "0";
				}

				if ((chkcondosis.Value.ToString() == "0") && (checkCell.Value.ToString() == "1") && (cbxEstado.Value.ToString() == "0"))
				{
					MessageBox.Show("Ingrese un Estado Controlado en la fila " + (i + 1).ToString());
					grdDatos.Rows[i].Selected = true;
					i = grdDatos.RowCount;
				}
				else
				{
					if ((strid_dosimetro == "0") && (Convert.ToInt64(checkCell.Value) == 1))
					{
						cmd.CommandText = "INSERT INTO tbl_dosimetria(id_cliente,id_personal,N_Documento,Controlado, ConDosis,Id_EstadoDosis,Dosis,Id_Periodo,enviado,n_pelicula)" +
													  "VALUES (" + strn_cliente + "," + strid_personal + "," + txtndocumento.Value.ToString() + "," +
																	  checkCell.Value.ToString() + "," + chkcondosis.Value.ToString() + "," + cbxEstado.Value.ToString() +
																	  ",cast(" + txtvalor.Value.ToString().Replace(",", ".") + " as decimal(10,2)), " + cbx_id_periodo.SelectedValue + ", 0," + txtNPelicula.Value.ToString() + ") ";
						cmd.CommandType = CommandType.Text;
						Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);

						cmd.CommandText = "pa_DosimetroIngreso_upd " + txtNPelicula.Value.ToString() + ",12,'" + Clases.clsUsuario.Usuario + "','',"
										  + cbx_id_periodo.SelectedValue + "," + strn_cliente; ;
						cmd.CommandType = CommandType.Text;
						Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);
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
																"Id_Periodo=" + cbx_id_periodo.SelectedValue + "," +
																"N_Documento=" + txtndocumento.Value.ToString() + "," +
																"n_pelicula=" + txtNPelicula.Value.ToString() +
														  " where id_dosimetro=" + strid_dosimetro;
							cmd.CommandType = CommandType.Text;
							Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);


							cmd.CommandText = "pa_DosimetroIngreso_upd " + txtNPelicula.Value.ToString() + ",12,'" + Clases.clsUsuario.Usuario + "',''," + cbx_id_periodo.SelectedValue + "," + strn_cliente;
							cmd.CommandType = CommandType.Text;
							Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);
						}

						if (Convert.ToInt64(checkCell.Value) == 0)
						{
							cmd.CommandText = "delete from tbl_dosimetria " +
														  " where id_dosimetro=" + strid_dosimetro;
							cmd.CommandType = CommandType.Text;
							Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);

							if (txtNPelicula.Value.ToString() != "")
							{
								cmd.CommandText = "pa_DosimetroIngreso_upd " + txtNPelicula.Value.ToString() + ",12,'" + Clases.clsUsuario.Usuario + "','',"
														  + cbx_id_periodo.SelectedValue + "," + strn_cliente; ;
								cmd.CommandType = CommandType.Text;
								Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);
							}

						}
					}
				}

			}
			Listar_Personal();
			MessageBox.Show("Informacion grabada");
			btn_Guardar.Enabled = true;
			pnl_Progreso.Visible = false;
		}

		private void btn_LimpiarFiltro(object sender, EventArgs e)
		{
			cbx_anno.Enabled = true;
			cbx_id_periodo.Enabled = true;
			txt_id_cliente.Enabled = true;
			cbx_anno.Focus();
			lbl_nombreCliente.Text = "";
			lbl_rut_cliente.Text = "";
			txt_id_cliente.Text = "-1";
			Btn_cargar_Click(null,null);
			txt_id_cliente.Clear();
			txt_id_cliente.Focus();
			grdDatos.DataSource=null;
			grp_Detalle.Enabled = false;
			btn_Guardar.Enabled = false;
			btn_cargar.Enabled = true;
			intContar = 0;
		}

		private void btn_Cerrar_Click(object sender, EventArgs e)
		{
			verificar_Grabado();
			this.Close();
		}

		private void btn_Buscar_Click(object sender, EventArgs e)
		{
			verificar_Grabado();
			BindingSource bs = new BindingSource();
			bs.DataSource = grdDatos.DataSource;
		//	bs.Filter = "(Nombres + ' ' + Paterno + ' '+ Maternos like '%" + txt_nombres.Text + "%')";
			grdDatos.DataSource = bs;
		}

		private void btn_BuscarDosimetro_Click(object sender, EventArgs e)
		{
			//CargarAyuda();
		}

		void verificar_Grabado()
		{

			if ((grdDatos.RowCount > 0) && (intContar > 0))
				if (MessageBox.Show("Desea grabar la información", "Confirmar", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
					btn_Guardar.PerformClick();
		}

		#endregion

		#region "combobox"

		private void cbx_anno_SelectedIndexChanged(object sender, EventArgs e)
		{
			Cargar_Periodo();
		}

		private void cbx_NDocumento_SelectedValueChanged(object sender, EventArgs e)
		{
			if (!bolDesdeinicio)
			{
				DataView dv = dtGrilla.DefaultView;
				dv.RowFilter = (int)cbx_NDocumento.SelectedValue == 0 ? "" : "n_documento=" + (int)cbx_NDocumento.SelectedValue;
				grdDatos.DataSource = dv;
			}

		}

		#endregion

		#region "grilla"

		private void grdDatos_KeyDown(object sender, KeyEventArgs e)
		{
			if (grdDatos.CurrentCell.RowIndex >= 0)
			{
				if (e.KeyCode == Keys.Delete)
				{
					string strMensaje = "";
					int intResul = clsFunc.CambiarEstado(grdDatos.Rows[grdDatos.CurrentRow.Index].Cells[0].Value.ToString(),
										 grdDatos.Rows[grdDatos.CurrentRow.Index].Cells[1].Value.ToString(), ref strMensaje);

					grdDatos.Rows[grdDatos.CurrentRow.Index].Cells[0].Value = 0;
					//numero de pelicula
					grdDatos.Rows[grdDatos.CurrentRow.Index].Cells[5].Value = "";
					grdDatos.Rows[grdDatos.CurrentRow.Index].Cells[6].Value = "";
					grdDatos.Rows[grdDatos.CurrentRow.Index].Cells[7].Value = "";
					grdDatos.Rows[grdDatos.CurrentRow.Index].Cells[8].Value = "";
				}
			}
			//if ((grdDatos.CurrentCell.ColumnIndex == 0) || (grdDatos.CurrentCell.ColumnIndex == 1))
			//{

			//}
		}

		private void grdDatos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (grdDatos.IsCurrentCellDirty)
			{
				grdDatos.CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		private void grdDatos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{

			if ((grdDatos.Columns[e.ColumnIndex].Name == "Controlado") || (grdDatos.Columns[e.ColumnIndex].Name == "condosis"))
			{
				DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)grdDatos.Rows[e.RowIndex].Cells["Controlado"];
				DataGridViewCheckBoxCell chkcondosis = (DataGridViewCheckBoxCell)grdDatos.Rows[e.RowIndex].Cells["condosis"];
				DataGridViewTextBoxCell txtvalor = (DataGridViewTextBoxCell)grdDatos.Rows[e.RowIndex].Cells["valor"];
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
			if (e.ColumnIndex != -1)
			{
				if (grdDatos.Columns[e.ColumnIndex].Name == colRut.Name) 
				{
					frmAyudaPersonal frm = new frmAyudaPersonal(Convert.ToInt64( txt_id_cliente.Text));
					frm.ShowDialog();

					grdDatos.Rows[e.RowIndex].Cells[0].Value= Clases.ClsPersonal.Id_Personal;
					grdDatos.Rows[e.RowIndex].Cells[5].Value = Clases.ClsPersonal.Rut;
					grdDatos.Rows[e.RowIndex].Cells[6].Value = Clases.ClsPersonal.Paterno;
					grdDatos.Rows[e.RowIndex].Cells[7].Value = Clases.ClsPersonal.Materno;
					grdDatos.Rows[e.RowIndex].Cells[8].Value = Clases.ClsPersonal.Nombres;
				}
			}
		}

		#endregion

		#region "Barra"

		private void tsmEliminarPersonal_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand();
			DataSet ds;
			string strn_cliente;
			string strid_personal;
			strn_cliente = grdDatos.Rows[Convert.ToInt16(grdDatos.CurrentRow.Index)].Cells["N_Cliente"].Value.ToString();
			strid_personal = grdDatos.Rows[Convert.ToInt16(grdDatos.CurrentRow.Index)].Cells["id_personal"].Value.ToString();
			cmd.CommandText = "pa_Personal_del " + strn_cliente + "," + strid_personal;// + ",'" + Clases.clsUsuario.Usuario + "'";

			cmd.CommandType = CommandType.Text;


			ds = Conectar.Listar(Clases.clsBD.BD, cmd);


			Listar_Personal();
		}

		private void tsmModificarPersonal_Click(object sender, EventArgs e)
		{
			verificar_Grabado();
			string strn_cliente;
			string strid_personal;
			strn_cliente = grdDatos.Rows[Convert.ToInt16(grdDatos.CurrentRow.Index)].Cells["N_Cliente"].Value.ToString();
			strid_personal = grdDatos.Rows[Convert.ToInt16(grdDatos.CurrentRow.Index)].Cells["id_personal"].Value.ToString();
			frmPersonalMant frm = new frmPersonalMant(Convert.ToInt64(strn_cliente), Convert.ToInt64(strid_personal));
			frm.ShowDialog(this);
			Listar_Personal();
		}


		private void dgvAyuda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			//numero de documento
			//grdDatos.Rows[Convert.ToInt32(lbl_fila.Text)].Cells[0].Value = dgvAyuda.Rows[e.RowIndex].Cells[1].Value;
			////numero de pelicula
			//grdDatos.Rows[Convert.ToInt32(lbl_fila.Text)].Cells[1].Value = dgvAyuda.Rows[e.RowIndex].Cells[2].Value;
			//grdDatos.Rows[Convert.ToInt32(lbl_fila.Text)].Cells[11].Value = 5;
			//grdDatos.Rows[Convert.ToInt32(lbl_fila.Text)].Cells[8].Value = 1;
			//grp_ingreso.Visible = false;
			//grdDatos.Focus();
		}


		#endregion
	
	}
}
