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
	public partial class frmModuloRecepcion : Form
	{

		#region "Definicion variable"
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();
		int intContar = 0;
		int intintId_Estado_temp;
		DataTable dtPeriodo;
		#endregion

		public frmModuloRecepcion(int intId_Estado, bool bolTLD)
		{
			InitializeComponent();

			SqlCommand cmdcombo = new SqlCommand();
			//	SqlCommand cmdcombo = new SqlCommand();
			DataSet dtcombo;
			cmdcombo.CommandText = "select 0 as Id_DetParametro, 'Seleccione' as Glosa, 0 as orden union all " +
				"SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=2 order by orden ";
			cmdcombo.CommandType = CommandType.Text;
			dtcombo = Conectar.Listar(Clases.clsBD.BD, cmdcombo);

			DataGridViewComboBoxColumn comboboxColumn = grdDatos.Columns["Observación"] as DataGridViewComboBoxColumn;
			//
			comboboxColumn.DisplayMember = "Glosa";
			comboboxColumn.ValueMember = "Id_DetParametro";
			comboboxColumn.DataSource = dtcombo.Tables[0];


			AsignarEvento();
			intintId_Estado_temp = intId_Estado;
			switch (intintId_Estado_temp)
			{
				case 0:
					this.Text = "Recepción Dosimetros";
					break;
				case 1:
					this.Text = "Recepción Dosimetros";
					break;
				case 6:
					this.Text = "Informe Generado";
					break;
			}
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "pa_Log_usuario_ins '" + Clases.clsUsuario.Usuario + "',' " + this.Text + "'";
			cmd.CommandType = CommandType.Text;
			Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);

			lbl_nombreCliente.Text = "";
			txt_CodCliente.Focus();
			pnl_Progreso.Visible = false;

			if (bolTLD)
			{
				rbtDosimetria.Visible = false;
				rbtTLD.Checked = true;
			}
			else
			{
				rbtDosimetria.Checked = true;
				rbtTLD.Visible = false;
			}

			dtp_FechaRecepcion.Text = DateTime.Now.Date.ToString();
			btn_Guardar.Enabled = false;
		}

		#region "Llamada de carga"

		private void Cargar_Cliente(Int64 intCodCliente)
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "SELECT run,Razon_Social,N_Cliente_Ref,Direccion,Id_Region,Id_Provincia,Id_Comuna,Telefono, Id_TipoFuente,Id_estado,Fechainicio " +
							" FROM tbl_cliente WHERE Id_cliente= " + txt_CodCliente.Text;
			DataSet dt;

			dt = Conectar.Listar(Clases.clsBD.BD, cmd);
			if (dt.Tables[0].Rows.Count > 0)
				lbl_nombreCliente.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
			else
				lbl_nombreCliente.Text = "";
		}//[]

		private void Listar_Grilla_TLD(bool DesdeLimpiar)
		{
			SqlCommand cmd = new SqlCommand();
			Int64 intN_Documento;
			if (txt_NDocumento.Text == "")
			{
				intN_Documento = 0;
			}
			else
				intN_Documento = Convert.ToInt64(txt_NDocumento.Text);

			DataSet dt;
			if(DesdeLimpiar==false)
				cmd.CommandText = String.Format("pa_DosimetroRecepcionTLD_sel  {0},{1},{2},{3}", txt_CodCliente.Text, (cbx_id_periodo.SelectedValue == null ? -1 : cbx_id_periodo.SelectedValue), "1", intN_Documento.ToString());
			else
				cmd.CommandText = String.Format("pa_DosimetroRecepcionTLD_sel  0,0,0,0");

			cmd.CommandType = CommandType.Text;

			dt = Conectar.Listar(Clases.clsBD.BD, cmd);
			grdDatos.DataSource = dt.Tables[0];
			btn_Guardar.Enabled = dt.Tables[0].Rows.Count > 0 ? true : false;

			if (txt_CodCliente.Text != "0" && DesdeLimpiar == false)
				if (dt.Tables[0].Rows.Count == 0)
					MessageBox.Show("No se ha ingresado información");
		}

		private void Listar_Grilla_Dosimetria(bool bolLimpiar)
		{
			SqlCommand cmd = new SqlCommand();
			Int64 intN_Documento;
			if (txt_NDocumento.Text == "")
			{
				intN_Documento = 0;
			}
			else
				intN_Documento = Convert.ToInt64(txt_NDocumento.Text);

			int intPeriodo = cbx_id_periodo.SelectedValue == null ? 0 : (int)cbx_id_periodo.SelectedValue;

			DataSet dt;
			if (bolLimpiar == false)
				cmd.CommandText = "pa_DosimetroRecepcion_sel " + txt_CodCliente.Text + "," + intPeriodo + "," + intintId_Estado_temp.ToString() + "," + intN_Documento.ToString();
			else
				cmd.CommandText = "pa_DosimetroRecepcion_sel -1,0,-1,0";

			cmd.CommandType = CommandType.Text;

			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			grdDatos.DataSource = dt.Tables[0];



			if (txt_CodCliente.Text != "0" && !bolLimpiar)
				if (dt.Tables[0].Rows.Count == 0 && intPeriodo > 0)
					MessageBox.Show("No se ha ingresado información");

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
			DataTable dtPeriodoCopia = dtPeriodo.Copy();
			dtPeriodoCopia.DefaultView.RowFilter = String.Format("anno={0}", cbx_anno.SelectedValue);

			cbx_id_periodo.DataSource = dtPeriodoCopia.DefaultView.ToTable();
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

		private void btn_Cliente_Click(object sender, EventArgs e)
		{
			frmBusquedaEmpresa frm = new frmBusquedaEmpresa();
			frm.Show(this);
		}
		private void btn_Cerrar_Click_1(object sender, EventArgs e)
		{
			//  verificar_Grabado();
			this.Close();
		}

		private void btn_Guardar_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand();
			// SqlCommand cmd = new SqlCommand();

			//// dtcombo = Conectar.Listar(Clases.clsBD.BD,cmdcombo);

			DataGridViewCheckBoxCell checkMarca;
			string strId;
			pnl_Progreso.Visible = true;
			btn_Guardar.Enabled = false;
			pnl_Progreso.Refresh();
			pgb_Barra.Minimum = 0;
			pgb_Barra.Maximum = grdDatos.RowCount;
			for (int i = 0; i <= grdDatos.RowCount - 1; ++i)
			{
				pgb_Barra.Value = i + 1;
				pgb_Barra.Refresh();
				checkMarca = (DataGridViewCheckBoxCell)grdDatos.Rows[i].Cells["marca"];
				DataGridViewTextBoxCell txtFechaRecepcion = (DataGridViewTextBoxCell)grdDatos.Rows[i].Cells["FechaRecepción"];
				DataGridViewComboBoxCell txtObservacionid = (DataGridViewComboBoxCell)grdDatos.Rows[i].Cells["Observación"];

				strId = grdDatos.Rows[i].Cells["id"].Value.ToString();

				if (checkMarca.Value.ToString() == "1")
				{
					if (rbtDosimetria.Checked == true)
						cmd.CommandText = "pa_DosimetroRecepcion_upd " + strId + "," + intintId_Estado_temp.ToString() + ",'" + Clases.clsUsuario.Usuario + "','" + txt_Observacion.Text + "'" + ",'" + txtFechaRecepcion.Value + "',0";
					if (rbtTLD.Checked == true)//
						cmd.CommandText = "pa_DosimetroRecepcionTLD_upd " + strId + ",1,'" + Clases.clsUsuario.Usuario + "','" + txt_Observacion.Text + "'" + ",'" + txtFechaRecepcion.Value + "',0";

					cmd.CommandType = CommandType.Text;
					Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);
				}
				else
				{
					if (checkMarca.Value.ToString() == "2")
					{
						if (rbtDosimetria.Checked == true)
							cmd.CommandText = "pa_DosimetroNoRecepcion_upd " + strId + ",'" + Clases.clsUsuario.Usuario + "','" + txtFechaRecepcion.Value + "','" + txt_Observacion.Text + "'," + txtObservacionid.Value.ToString() + "";
						if (rbtTLD.Checked == true)//
							cmd.CommandText = "pa_DosimetroNoRecepcionTLD_upd " + strId + ",'" + Clases.clsUsuario.Usuario + "','" + txtFechaRecepcion.Value + "','" + txt_Observacion.Text + "'," + txtObservacionid.Value.ToString() + "";

						cmd.CommandType = CommandType.Text;
						Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);
					}
				}//


			}
			if (rbtDosimetria.Checked == true)
				Listar_Grilla_Dosimetria(false);
			if (rbtTLD.Checked == true)
				Listar_Grilla_TLD(false);
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
				if (rbtDosimetria.Checked == true)
					Listar_Grilla_Dosimetria(false);
				if (rbtTLD.Checked == true)
					Listar_Grilla_TLD(false);

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
			cargarDatos(true);
			if (rbtDosimetria.Checked == true)
				Listar_Grilla_Dosimetria(true);
			if (rbtTLD.Checked == true)
				Listar_Grilla_TLD(true);

			chk_marcar.Checked = false;
			txt_CodCliente.Focus();
			btn_Cargar_cliente.Enabled = true;
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
			if ((grdDatos.Columns[e.ColumnIndex].Name == "marca"))
			{
				DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)grdDatos.Rows[e.RowIndex].Cells["marca"];
				DataGridViewTextBoxCell txtFechaRecepcion = (DataGridViewTextBoxCell)grdDatos.Rows[e.RowIndex].Cells[6];
				//DataGridViewComboBoxCell txtObservacion = (DataGridViewComboBoxCell)grdDatos.Rows[e.RowIndex].Cells[7];
				DataGridViewComboBoxCell txtObservacion = (DataGridViewComboBoxCell)grdDatos.Rows[e.RowIndex].Cells["Observación"];
				if ((Convert.ToInt64(checkCell.Value) == 1) || (Convert.ToInt64(checkCell.Value) == 2))
				{
					intContar = intContar + 1;
					groupBox2.Text = "Listado       Registro:" + intContar.ToString();

					if (Convert.ToInt64(checkCell.Value) == 1)
					{
						txtObservacion.ReadOnly = false;
						txtFechaRecepcion.Value = dtp_FechaRecepcion.Text;
					}
					else
					{
						if (Convert.ToInt64(checkCell.Value) == 2)
						{
							txtObservacion.ReadOnly = false;
							txtFechaRecepcion.Value = dtp_FechaRecepcion.Text;
						}
						else
						{
							txtObservacion.ReadOnly = true;
							txtObservacion.Value = 0;
							txtFechaRecepcion.Value = "";
						}
					}
				}
				else
				{
					txtObservacion.ReadOnly = true;
					txtFechaRecepcion.Value = "";
					txtObservacion.Value = 0;
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
				checkMarca = (DataGridViewCheckBoxCell)grdDatos.Rows[i].Cells["marca"];
				checkMarca.Value = chk_marcar.Checked;
				DataGridViewTextBoxCell txtFechaRecepcion = (DataGridViewTextBoxCell)grdDatos.Rows[i].Cells["FechaRecepción"];
				if (chk_marcar.Checked == true)
					txtFechaRecepcion.Value = dtp_FechaRecepcion.Text;
				else
					txtFechaRecepcion.Value = "";
			}
			btn_Guardar.Enabled = true;
			pnl_Progreso.Visible = false;
		}

		private void btn_Cargar_cliente_Click(object sender, EventArgs e)
		{
			cargarDatos(false);
		}

		void cargarDatos(bool bolDesdeLimpiar)
		{
			if (String.IsNullOrWhiteSpace(txt_CodCliente.Text) && !bolDesdeLimpiar)
			{
				classFuncionesGenerales.mensajes.MensajeError("Debe ingresar el número de cliente");
				return;
			}

			Cursor = Cursors.WaitCursor;

			if (bolDesdeLimpiar)
			{
				SqlCommand cmd = new SqlCommand
				{
					CommandText = String.Format("CargarClientePorRun '{0}',{1}", (!bolDesdeLimpiar ? lbl_rut_cliente.Text : "0"), (!bolDesdeLimpiar ? txt_CodCliente.Text : "-1"))
				};
				DataSet dt;
				dt = Conectar.Listar(Clases.clsBD.BD, cmd);

				if (dt != null)
				{
					dtPeriodo = new DataTable();
					//if (dt.Tables[0].Rows.Count > 0)
					//{
					dtPeriodo = dt.Tables[3];
					cbx_anno.DataSource = dt.Tables[1];
					lbl_nombreCliente.Text = "";
					lbl_rut_cliente.Text = "";
					cbx_id_periodo.DataSource = dtPeriodo;
				}
			}
			else
			{
				frmAyudaCliente frm = new frmAyudaCliente(Convert.ToInt64(txt_CodCliente.Text));

				if (frm.ShowDialog() == DialogResult.OK)
				{
					lbl_nombreCliente.Text = (Convert.ToInt64(txt_CodCliente.Text) > 1) ? Clases.ClsCliente.Nombres : "";
					lbl_rut_cliente.Text = (Convert.ToInt64(txt_CodCliente.Text) > 1) ? Clases.ClsCliente.Rut : "";

					SqlCommand cmd = new SqlCommand
					{
						CommandText = String.Format("CargarClientePorRun '{0}',{1}", (!bolDesdeLimpiar ? lbl_rut_cliente.Text : "0"), (!bolDesdeLimpiar ? txt_CodCliente.Text : "-1"))
					};
					DataSet dt;
					dt = Conectar.Listar(Clases.clsBD.BD, cmd);

					if (dt != null)
					{
						dtPeriodo = new DataTable();
						//if (dt.Tables[0].Rows.Count > 0)
						//{
						dtPeriodo = dt.Tables[3];
						cbx_anno.DataSource = dt.Tables[1];

						if ((Convert.ToInt64(txt_CodCliente.Text) < 1))
							cbx_id_periodo.DataSource = dtPeriodo;

						btn_Cargar_cliente.Enabled = false;
						//}
					}

				}
			}


			Cursor = Cursors.Default;
		}
	}
}
