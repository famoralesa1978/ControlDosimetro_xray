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
	public partial class frmOrdenTrabajo : Form
	{

		#region "Definicion variable"
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();
		int intContar = 0;
		int intintId_Estado_temp;
		#endregion

		public frmOrdenTrabajo(int intId_Estado)
		{
			InitializeComponent();
			chk_marcar.Checked = false;
			dtp_FechaRecepcion.Text = DateTime.Now.Date.ToString();
			dtp_FechaDesde.Text = DateTime.Now.Date.ToString();
			dtp_FechaHasta.Text = DateTime.Now.Date.ToString();

			//for (int i = 0; i <= grdDatos.RowCount - 1; i++)
			//{

			//    grdDatos.Rows[i].Cells["FechaOrdenTrabajo"].Value = DateTime.Now.Date.ToString();
			//}
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

			pnl_Progreso.Visible = false;

		}

		#region "Llamada de carga"

		private void Listar_Grilla()
		{
			SqlCommand cmd = new SqlCommand();

			String strFechaDesde = dtp_FechaDesde.Text.Substring(6, 4) + dtp_FechaDesde.Text.Substring(3, 2) + dtp_FechaDesde.Text.Substring(0, 2);
			String strFechaHasta = dtp_FechaHasta.Text.Substring(6, 4) + dtp_FechaHasta.Text.Substring(3, 2) + dtp_FechaHasta.Text.Substring(0, 2);

			DataSet dt;
			cmd.CommandText = "pa_OrdenTrabajoPorFecha_sel " + strFechaDesde + "," + strFechaHasta;
			// pa_OrdenTrabajo_sel
			cmd.CommandType = CommandType.Text;

			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

			grdDatos.DataSource = dt.Tables[0];
			btnFiltrar.Enabled= grpBuscar.Enabled = dt.Tables[0].Rows.Count>0;
			//if(txt_CodCliente.Text!="0")
			if (dt.Tables[0].Rows.Count == 0)
			{
				MessageBox.Show("No se ha ingresado información");
			}
		


		}


		private void AsignarEvento()
		{
			Clases.ClassEvento evt = new Clases.ClassEvento();
			evt.AsignarNumero(ref txtNCliente);
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
			DataTable tabla = new DataTable();
			tabla.Columns.Add("N_orden");
			tabla.Columns.Add("Institucion");
			tabla.Columns.Add("Fecha");
			tabla.Columns.Add("Trimestre");
			tabla.Columns.Add("N_dosimetros");
			SqlCommand cmd = new SqlCommand();
			//// SqlCommand cmd = new SqlCommand();

			////// dtcombo = Conectar.Listar(ClaseGeneral.Conexion,cmdcombo);

			DataGridViewCheckBoxCell checkMarca;
			//    string strId;
			pnl_Progreso.Visible = true;
			btn_Guardar.Enabled = false;
			pnl_Progreso.Text = "Progreso de Grabado";
			pnl_Progreso.Refresh();
			pgb_Barra.Minimum = 0;
			pgb_Barra.Maximum = grdDatos.RowCount;//

			// DataRow workRow;

			cmd.CommandText = "select isnull(max(n_orden),0) as N_orden from ges_OrdenTrabajo";
			cmd.CommandType = CommandType.Text;
			DataSet ds1 = new DataSet();
			ds1 = Conectar.Listar(ClaseGeneral.Conexion, cmd);

			int intN_Orden;
			if (ds1.Tables[0].Rows.Count == 0)
				intN_Orden = 1;
			else
				intN_Orden = Convert.ToInt32(ds1.Tables[0].Rows[0]["N_orden"].ToString()) + 1;

			for (int i = 0; i <= grdDatos.RowCount - 1; ++i)
			{
				pgb_Barra.Value = i + 1;
				pgb_Barra.Refresh();
				checkMarca = (DataGridViewCheckBoxCell)grdDatos.Rows[i].Cells["marca"];
				DataGridViewTextBoxCell txtRazon_Social = (DataGridViewTextBoxCell)grdDatos.Rows[i].Cells["Razon_Social"];

				DataGridViewTextBoxCell txtFechaOrdenTrabajo = (DataGridViewTextBoxCell)grdDatos.Rows[i].Cells["FechaOrdenTrabajo"];
				DataGridViewTextBoxCell txtperiodo = (DataGridViewTextBoxCell)grdDatos.Rows[i].Cells["periodo"];
				DataGridViewTextBoxCell txtN_Dosimetro = (DataGridViewTextBoxCell)grdDatos.Rows[i].Cells["N_Dosimetro"];
				DataGridViewTextBoxCell txtid = (DataGridViewTextBoxCell)grdDatos.Rows[i].Cells["id"];


				if (checkMarca.Value.ToString() == "1")
				{

					cmd.CommandText = "INSERT INTO [dbo].[ges_OrdenTrabajo] ([n_orden],[Razon_Social],[FechaOrdenTrabajo],[Periodo],[n_dosimetro],id_dosimetro)" +
															 "values(" + intN_Orden.ToString() + ",'" + txtRazon_Social.Value + "','" + txtFechaOrdenTrabajo.Value + "','" + txtperiodo.Value + "','" + txtN_Dosimetro.Value + "','" + txtid.Value + "')";
					cmd.CommandType = CommandType.Text;

					Conectar.AgregarModificarEliminar(ClaseGeneral.Conexion, cmd);


					cmd.CommandText = "pa_DosimetroOrdenTrabajo_upd " + intintId_Estado_temp.ToString() + ",'" + Clases.clsUsuario.Usuario + "','" + txtFechaOrdenTrabajo.Value + "','" + txtid.Value + "'";
					cmd.CommandType = CommandType.Text;
					Conectar.AgregarModificarEliminar(ClaseGeneral.Conexion, cmd);


				}
			}
			DataSet dsrpt = new DataSet();
			cmd.CommandText = "rptOrdenTrabajo " + intN_Orden.ToString();

			cmd.CommandType = CommandType.Text;

			dsrpt = Conectar.Listar(ClaseGeneral.Conexion, cmd);
			//rptOrdenTrabajo
			frmreporte frm = new frmreporte(dsrpt, ds1, 4);
			frm.Show(this);
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

		private void btn_Cerrar_Click(object sender, EventArgs e)
		{
			this.Close();
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
			if ((grdDatos.Columns[e.ColumnIndex].Name == "marca"))
			{
				DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)grdDatos.Rows[e.RowIndex].Cells["marca"];
				DataGridViewTextBoxCell txtFechaRecepcion = (DataGridViewTextBoxCell)grdDatos.Rows[e.RowIndex].Cells["FechaOrdenTrabajo"];
				if ((Convert.ToInt64(checkCell.Value) == 1))
				{
					intContar = intContar + 1;
					groupBox2.Text = "Listado       Registro:" + intContar.ToString();

					if (Convert.ToInt64(checkCell.Value) == 1)
					{
						txtFechaRecepcion.Value = dtp_FechaRecepcion.Text;
					}
				}
				else
				{
					txtFechaRecepcion.Value = "";
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
			pnl_Progreso.Visible = true;
			if (chk_marcar.Checked == true)
				pnl_Progreso.Text = "Marcando todas las ordenes de trabajo";
			else
				pnl_Progreso.Text = "Desmarcando todas las ordenes de trabajo";

			pnl_Progreso.Refresh();
			pgb_Barra.Minimum = 0;
			DataGridViewCheckBoxCell checkMarca;
			pgb_Barra.Maximum = grdDatos.RowCount;
			for (int i = 0; i <= grdDatos.RowCount - 1; i++)
			{
				pgb_Barra.Value = i + 1;
				pgb_Barra.Refresh();
				checkMarca = (DataGridViewCheckBoxCell)grdDatos.Rows[i].Cells["marca"];
				if (chk_marcar.Checked == true)
					grdDatos.Rows[i].Cells["FechaOrdenTrabajo"].Value = dtp_FechaRecepcion.Text;
				checkMarca.Value = chk_marcar.Checked;
			}
			btn_Guardar.Enabled = true;
			pnl_Progreso.Visible = false;
		}

		private void btn_cargar_Click(object sender, EventArgs e)
		{
			Listar_Grilla();
		}

		private void btnFiltrar_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(txtNCliente.Text))
				classFuncionesGenerales.mensajes.MensajeError("Debe ingresar un número de cliente");
			else
			{
				classFuncionesGenerales.Filtro.FiltroCliente(ref grdDatos, txtNCliente.Text);
			}
		}
	}
}
