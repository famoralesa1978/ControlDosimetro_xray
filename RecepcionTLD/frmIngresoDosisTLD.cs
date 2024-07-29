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
		readonly clsConectorSqlServer Conectar = new clsConectorSqlServer();
		readonly clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		readonly clsEventoControl ClaseEvento = new clsEventoControl();
		Clases.ClassEvento clsEvento = new Clases.ClassEvento();
		bool bolValidarGrilla = false;
		int intContar = 0;
		#endregion

		public frmIngresoDosisTLD(Int64 intId_Cliente)
		{
			InitializeComponent();
			AsignarEvento();
			grdDatos.AutoGenerateColumns = false;
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
			//Listar_Personal();
			pnl_Progreso.Visible = false;
		}

		#region "Llamada de carga"


		private void Listar_Personal()
		{
			// SqlCommand cmd = new SqlCommand();
			SqlCommand cmd = new SqlCommand();

			DataSet dt;

			String strcadena = String.IsNullOrEmpty(lbl_id_cliente.Text) ? "" : String.Format("{0}", lbl_id_cliente.Text);

			cmd.CommandText = String.Format("pa_IngresoDosis_sel {0}", strcadena);//
			cmd.CommandType = CommandType.Text;

			dt = Conectar.Listar(Clases.clsBD.BD, cmd);
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
			clsEvento.AsignarNumero(ref lbl_id_cliente);
		}

		#endregion

		#region "button"

		private void btnIngresarDosisISP_Click(object sender, EventArgs e)
		{
			//frmDosimetriaISP frm = new frmDosimetriaISP(Convert.ToInt64(lbl_id_cliente.Text ));
			//frm.ShowDialog(this);
		}

		private bool ValidarGrillaError()
		{
			bool bolValidar = false;

			for (int intFila = 0; intFila <= grdDatos.RowCount - 1; intFila++)
			{
				if (!String.IsNullOrEmpty(grdDatos.Rows[intFila].ErrorText))
				{
					bolValidar = true;
					break;
				}

			}
			return bolValidar;
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
			bool bolGrabar = false;

			//validar
			if (ValidarGrillaError())
			{
				MessageBox.Show("Existen errores en el ingreso de información.", ControlDosimetro.Properties.Resources.msgCaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			pnl_Progreso.Visible = true;
			btn_Guardar.Enabled = false;
			pnl_Progreso.Refresh();
			pgb_Barra.Minimum = 0;
			pgb_Barra.Maximum = grdDatos.RowCount;
			Cursor = Cursors.WaitCursor;

			for (int i = 0; i <= grdDatos.RowCount - 1; i++)
			{
				pgb_Barra.Value = i + 1;
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

				if (txtvalor.Value.ToString() == "")
					txtvalor.Value = "0";
				if ((txtndocumento.Value.ToString() == "") && ( Convert.ToBoolean( checkCell.Value) == true))
				{
					txtndocumento.Value = "0";
				}

				if (((Convert.ToBoolean(chkcondosis.Value) == false) && (Convert.ToBoolean(checkCell.Value) == true) && (cbxEstado.Value.ToString() == "0")) ||
							((Convert.ToBoolean(checkCell.Value) == true) && ((txtcristal1.Value.ToString() == "") || (txtcristal2.Value.ToString() == ""))))
				{
					MessageBox.Show("Ingrese un Estado Controlado en la fila " + (i + 1).ToString());
					grdDatos.Rows[i].Selected = true;
					i = grdDatos.RowCount;
					btn_Guardar.Enabled = true;
					return;
				}
				else
				{//pa_IngresoDosisTLD_Upd
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.CommandText = "pa_IngresoDosisTLD_Upd";
					cmd.Parameters.Clear();
					cmd.Parameters.Add("@id_cliente", SqlDbType.Int);
					cmd.Parameters["@id_cliente"].Value = strn_cliente;
					cmd.Parameters.Add("@id_personal", SqlDbType.Int);
					cmd.Parameters["@id_personal"].Value = strid_personal;
					cmd.Parameters.Add("@N_Documento", SqlDbType.Int);
					cmd.Parameters["@N_Documento"].Value = txtndocumento.Value.ToString();
					cmd.Parameters.Add("@Controlado", SqlDbType.Int);
					cmd.Parameters["@Controlado"].Value = Convert.ToBoolean(checkCell.Value) ? 1 : 0;
					cmd.Parameters.Add("@ConDosis", SqlDbType.Int);
					cmd.Parameters["@ConDosis"].Value = Convert.ToBoolean(chkcondosis.Value)?1:0;
					cmd.Parameters.Add("@Id_EstadoDosis", SqlDbType.Int);
					cmd.Parameters["@Id_EstadoDosis"].Value = cbxEstado.Value;
					cmd.Parameters.Add("@Dosis", SqlDbType.Decimal, 9);
					cmd.Parameters["@Dosis"].Value = txtvalor.Value;
					cmd.Parameters.Add("@Id_Periodo", SqlDbType.Int);
					cmd.Parameters["@Id_Periodo"].Value = strid_periodo;
					cmd.Parameters.Add("@N_Pelicula", SqlDbType.Int);
					cmd.Parameters["@N_Pelicula"].Value = txtNPelicula.Value;
					cmd.Parameters.Add("@Cristal1", SqlDbType.Decimal, 9);
					cmd.Parameters["@Cristal1"].Value = txtcristal1.Value.ToString();
					cmd.Parameters.Add("@Cristal2", SqlDbType.Decimal, 9);
					cmd.Parameters["@Cristal2"].Value = txtcristal2.Value.ToString();
					cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 30);
					cmd.Parameters["@usuario"].Value = Clases.clsUsuario.Usuario;
					Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);
				}

				bolGrabar = true;
			}

			Cursor = Cursors.Default;
			if (bolGrabar)
			{
				Listar_Personal();
				MessageBox.Show("Informacion grabada");
			}

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

			if ((grdDatos.RowCount > 0) && (intContar > 0))
				if (MessageBox.Show("Desea grabar la información", "Confirmar", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
					btn_Guardar.PerformClick();
		}

		#endregion

		#region "combobox"


		#endregion

		#region "grilla"

		private void grdDatos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			DataGridView dgv = sender as DataGridView;
			if (null == dgv || null == dgv.CurrentCell || !dgv.IsCurrentCellDirty)
			{
				return;
			}

			if ((dgv.CurrentCell is DataGridViewComboBoxCell || dgv.CurrentCell is DataGridViewCheckBoxCell))
			{
				grdDatos.CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		private void grdDatos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				bolValidarGrilla = bolValidarGrilla ? true : false;
				DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)grdDatos.Rows[e.RowIndex].Cells["Controlado"];
				DataGridViewCheckBoxCell chkcondosis = (DataGridViewCheckBoxCell)grdDatos.Rows[e.RowIndex].Cells["condosis"];
				DataGridViewComboBoxCell cbxEstado = (DataGridViewComboBoxCell)grdDatos.Rows[e.RowIndex].Cells["Estado"];
				grdDatos.Rows[e.RowIndex].ErrorText = "";

				if (Convert.ToInt64(checkCell.Value) == 0 && e.ColumnIndex == condosis.Index)
					return;

				if ((grdDatos.Columns[e.ColumnIndex].Name == "Controlado") || (grdDatos.Columns[e.ColumnIndex].Name == "condosis"))
				{

					DataGridViewTextBoxCell txtvalor = (DataGridViewTextBoxCell)grdDatos.Rows[e.RowIndex].Cells["valor"];
					if (Convert.ToBoolean(checkCell.Value) == true)
					{
						chkcondosis.ReadOnly = false;
						intContar++;
						groupBox2.Text = "Listado       Registro:" + intContar.ToString();

						if (Convert.ToBoolean(chkcondosis.Value) == true)
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

						if (Convert.ToBoolean(chkcondosis.Value) == false && cbxEstado.Value.ToString() == "0")
						{
							grdDatos.Rows[e.RowIndex].ErrorText = "Estado Control es Requerido" + System.Environment.NewLine;
							bolValidarGrilla = true;
						}
						else
							bolValidarGrilla = bolValidarGrilla ? true : false;

						if (grdDatos.Rows[e.RowIndex].Cells["Cristal1"].Value == DBNull.Value)// && Convert.ToInt64(chkcondosis.Value) == 1
						{
							grdDatos.Rows[e.RowIndex].ErrorText = "Cristal 1 es Requerido" + System.Environment.NewLine;
							bolValidarGrilla = true;
						}
						else
							bolValidarGrilla = bolValidarGrilla ? true : false;

						if (grdDatos.Rows[e.RowIndex].Cells["Cristal2"].Value == DBNull.Value)//&& Convert.ToInt64(chkcondosis.Value) == 1
						{
							grdDatos.Rows[e.RowIndex].ErrorText = grdDatos.Rows[e.RowIndex].ErrorText + "Cristal 2 es Requerido" + System.Environment.NewLine;
							bolValidarGrilla = true;
						}
						else
							bolValidarGrilla = bolValidarGrilla ? true : false;

					}
					else
					{
						txtvalor.ReadOnly = true;
						chkcondosis.ReadOnly = true;
						chkcondosis.ReadOnly = true;
						cbxEstado.ReadOnly = true;
						intContar--;

						groupBox2.Text = "Listado       Registro:" + intContar.ToString();
					}
				}
				else
				if ((e.ColumnIndex == Cristal1.Index || e.ColumnIndex == Cristal2.Index) && Convert.ToInt64(checkCell.Value) == 1)
				{

					if (grdDatos.Rows[e.RowIndex].Cells["Cristal1"].Value == DBNull.Value)//
					{
						grdDatos.Rows[e.RowIndex].ErrorText = "Cristal 1 es Requerido" + System.Environment.NewLine;
						bolValidarGrilla = true;
					}
					else
						bolValidarGrilla = bolValidarGrilla ? true : false;

					if (grdDatos.Rows[e.RowIndex].Cells["Cristal2"].Value == DBNull.Value)// && Convert.ToInt64(chkcondosis.Value) == 1
					{
						grdDatos.Rows[e.RowIndex].ErrorText = grdDatos.Rows[e.RowIndex].ErrorText + "Cristal 2 es Requerido" + System.Environment.NewLine;
						bolValidarGrilla = true;
					}
					else
						bolValidarGrilla = bolValidarGrilla ? true : false;
				}
				else
				if (e.ColumnIndex == valor.Index)
				{
					//	if (Convert.ToInt64(chkcondosis.Value) == 1)
					//	{
					grdDatos.Rows[e.RowIndex].Cells["Cristal2"].Value = grdDatos.Rows[e.RowIndex].Cells["Valor"].Value;
					grdDatos.Rows[e.RowIndex].Cells["Cristal1"].Value = grdDatos.Rows[e.RowIndex].Cells["Valor"].Value;
					//	}

				}

				((DataTable)grdDatos.DataSource).Rows[e.RowIndex].AcceptChanges();

				((DataTable)grdDatos.DataSource).Rows[e.RowIndex].SetModified();

			}

		}
		private void grdDatos_RowValidated(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				bolValidarGrilla = bolValidarGrilla ? true : false;
				DataGridViewRow row = grdDatos.CurrentRow;

				grdDatos.Rows[e.RowIndex].ErrorText = "";
				var checkCell = row.Cells["Controlado"].Value;
				var chkcondosis = row.Cells["condosis"].Value;
				var objValue = row.Cells["Cristal1"].Value;
				var objEstado = row.Cells["Estado"].Value;

				if (Convert.ToBoolean(checkCell) == true)
				{
					if (Convert.ToBoolean(chkcondosis) == false && objEstado.ToString() == "0")
					{
						grdDatos.Rows[e.RowIndex].ErrorText = "Estado Control es Requerido" + System.Environment.NewLine;
						bolValidarGrilla = true;
					}
					else
						bolValidarGrilla = false;

					if (String.IsNullOrEmpty(Convert.ToString(objValue)))//&& chkcondosis.ToString() == "1"
					{
						grdDatos.Rows[e.RowIndex].ErrorText = "Cristal 1 es Requerido" + System.Environment.NewLine;
						bolValidarGrilla = true;
					}
					else
						bolValidarGrilla = bolValidarGrilla ? true : false;

					objValue = row.Cells["Cristal2"].Value;

					if (String.IsNullOrEmpty(Convert.ToString(objValue)))//&& chkcondosis.ToString() == "1"
					{
						grdDatos.Rows[e.RowIndex].ErrorText += "Cristal 2 es Requerido" + System.Environment.NewLine;
						bolValidarGrilla = true;
					}
					else
						bolValidarGrilla = bolValidarGrilla ? true : false;
				}

			}
		}

		#endregion
		private void btn_Cargar_Click(object sender, EventArgs e)
		{
			Listar_Personal();
		}

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

		private void btn_Cliente_Click(object sender, EventArgs e)
		{
			frmBusquedaEmpresa frm = new frmBusquedaEmpresa();
			frm.Show(this);
		}

		private void frmIngresoDosisTLD_Load(object sender, EventArgs e)
		{

		}

		private void chkControlado_CheckedChanged(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			DataGridViewCheckBoxCell checkMarca;
			for (int i = 0; i <= grdDatos.RowCount - 1; i++)
			{
				checkMarca = (DataGridViewCheckBoxCell)grdDatos.Rows[i].Cells["Controlado"];
				checkMarca.Value = chkControlado.Checked;
			}

			Cursor = Cursors.Default;
		}

		private void chkMarcar_CheckedChanged(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			DataGridViewComboBoxCell EstDosis;
			DataGridViewCheckBoxCell checkMarca;
			for (int i = 0; i <= grdDatos.RowCount - 1; i++)
			{
				checkMarca = (DataGridViewCheckBoxCell)grdDatos.Rows[i].Cells["condosis"];
				if ((int)checkMarca.Value == 0)
				{
					EstDosis = (DataGridViewComboBoxCell)grdDatos.Rows[i].Cells["Estado"];//
					EstDosis.Value = 5;
				}

			}

			Cursor = Cursors.Default;
		}


	}
}
