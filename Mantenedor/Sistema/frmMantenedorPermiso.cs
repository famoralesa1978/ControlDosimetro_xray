﻿using System;
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
	public partial class frmMantenedorPermiso : Form
	{
		#region "Definicion variable"

		TextBox txtBox = new TextBox();
		enum ConfGrilla : int
		{
			id = 0,
			descripcion = 1,
			Id_estado = 2
		};

		enum ConfGrillaDetalle : int
		{
			idmenu = 0,
			Menu = 1,
			Acceso = 2,
			Lectura = 3,
			Nuevo = 4,
			Modificacion = 5,
			Eliminar = 6,
			Id_menu_Padre = 7
		};

		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();

		#endregion

		#region "Inicio"

		public frmMantenedorPermiso()
		{
			InitializeComponent();
			dgvGrilla.AutoGenerateColumns = false;
			dgvDetalle.AutoGenerateColumns = false;
		}

		private void frmMantenedorPermiso_Load(object sender, EventArgs e)
		{
			CargarGrilla();
			LlamadoAModificar(dgvGrilla.CurrentCell.RowIndex);
		}

		#endregion

		#region Procedimiento

		private void Grabar()
		{
			if (MessageBox.Show("Desea grabar la información", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
			{
				Cursor = Cursors.WaitCursor;
				if (((DataTable)dgvDetalle.DataSource).GetChanges(DataRowState.Modified) != null && ((DataTable)dgvDetalle.DataSource).GetChanges(DataRowState.Added) != null)
				{

				}

					DataTable dt = (DataTable)dgvGrilla.DataSource;

				DataRow currentRow = dt.Rows[dgvGrilla.CurrentCell.RowIndex];
				SqlCommand cmd = new SqlCommand();
				cmd.CommandText = "pa_Permiso_Del " + currentRow[ConfGrilla.id.ToString()].ToString();
				cmd.CommandType = CommandType.Text;
				Conectar.AgregarModificarEliminar(ClaseGeneral.Conexion, cmd);

				//foreach (DataRow dr in ((DataTable)grdDatos.DataSource).GetChanges(DataRowState.Modified).Rows){

				//}

				foreach (DataRowView row in ((DataTable)dgvDetalle.DataSource).DefaultView)
				{

					//if (row.Row.RowState==DataRowState.Modified){

					if ((bool)row[(int)ConfGrillaDetalle.Acceso] || (bool)row[(int)ConfGrillaDetalle.Lectura] || (bool)row[(int)ConfGrillaDetalle.Modificacion] || (bool)row[(int)ConfGrillaDetalle.Nuevo] || (bool)row[(int)ConfGrillaDetalle.Eliminar])
					{
						cmd.CommandText = "pa_Permiso_Ins " + currentRow[ConfGrilla.id.ToString()].ToString() + "," + row[(int)ConfGrillaDetalle.idmenu] + "," + row[(int)ConfGrillaDetalle.Acceso] + "," + row[(int)ConfGrillaDetalle.Lectura] + "," + row[(int)ConfGrillaDetalle.Nuevo] + "," + row[(int)ConfGrillaDetalle.Modificacion] + "," + row[(int)ConfGrillaDetalle.Eliminar];
						cmd.CommandType = CommandType.Text;
						Conectar.AgregarModificarEliminar(ClaseGeneral.Conexion, cmd);
					}
				}

				Cursor = Cursors.Default;
			}
		}

		private void CargarGrilla()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "SELECT  [Id_perfil] as id,Descripcion,Id_estado FROM [dbo].[tbl_perfil]  order by Descripcion";

			cmd.CommandType = CommandType.Text;

			DataSet dt;
			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

			dgvGrilla.DataSource = dt.Tables[0];
		}

		private void LlamadoAModificar(int intFila)
		{
			DataTable dt = (DataTable)dgvGrilla.DataSource;
			DataRow currentRow = dt.Rows[intFila];
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "pa_Permiso_sel " + currentRow[ConfGrilla.id.ToString()].ToString();

			cmd.CommandType = CommandType.Text;

			DataSet dtDet;
			dtDet = Conectar.Listar(ClaseGeneral.Conexion, cmd);

			dgvDetalle.DataSource = dtDet.Tables[0];
		}

		#endregion

		#region " grilla"

		private void dgvGrilla_Paint(object sender, PaintEventArgs e)
		{
			int columnIndex = 0;
			Point headerCellLocation = this.dgvGrilla.GetCellDisplayRectangle(columnIndex, -1, true).Location;
			txtBox.Location = new Point(headerCellLocation.X, headerCellLocation.Y + 20);
			txtBox.BackColor = Color.AliceBlue;
			txtBox.Width = Colperfil1.Width;
			txtBox.TextChanged += new EventHandler(TextBox_Changed);
			dgvGrilla.Controls.Add(txtBox);
		}

		private void dgvGrilla_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
		{
			txtBox.Width = Colperfil1.Width;
		}

		private void dgvGrilla_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int intFila = e.RowIndex;
			LlamadoAModificar(intFila);
		}

		private void TextBox_Changed(object sender, EventArgs e)
		{
			BindingSource bs = new BindingSource();
			bs.DataSource = dgvGrilla.DataSource;
			bs.Filter = "Descripcion like '%" + (sender as TextBox).Text + "%'";
			dgvGrilla.DataSource = bs;
		}

		private void dgvDetalle_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			foreach (DataGridViewRow filaGrilla in dgvDetalle.Rows)
			{
				DataRowView dtrFila = (DataRowView)filaGrilla.DataBoundItem;
				if ((bool)dtrFila["EventoClick"] == false)
				{
					dgvDetalle[ColLectura.Index, filaGrilla.Index].ReadOnly = true;
					dgvDetalle[ColNuevo.Index, filaGrilla.Index].ReadOnly = true;
					dgvDetalle[ColModificacion.Index, filaGrilla.Index].ReadOnly = true;
					dgvDetalle[ColEliminar.Index, filaGrilla.Index].ReadOnly = true;
					dgvDetalle[ColMenu.Index, filaGrilla.Index].Style.BackColor = Color.Aqua;
				}
			}
		}

		private void dgvDetalle_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			DataGridView dgv = sender as DataGridView;
			if (null == dgv || null == dgv.CurrentCell || !dgv.IsCurrentCellDirty)
			{
				return;
			}

			if ((dgv.CurrentCell is DataGridViewComboBoxCell || dgv.CurrentCell is DataGridViewCheckBoxCell))
			{
				dgvDetalle.CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		private void dgvDetalle_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{

			//	dgvDetalle.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = ((DataTable)dgvDetalle.DataSource).Rows[e.RowIndex]["Id_CodServicio"];
				((DataTable)dgvDetalle.DataSource).Rows[e.RowIndex].AcceptChanges();

				((DataTable)dgvDetalle.DataSource).Rows[e.RowIndex].SetModified();
			}
		}

		#endregion

		#region "boton"

		#endregion

		#region Barra

		private void tsbGuardar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			Grabar();

			Cursor = Cursors.Default;
		}


		#endregion


	}
}
