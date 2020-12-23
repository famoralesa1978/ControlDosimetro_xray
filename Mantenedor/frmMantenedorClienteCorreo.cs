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
	public partial class frmMantenedorClienteCorreo : Form
	{
		#region "Definicion variable"

		TextBox txtBox = new TextBox();
		enum ConfGrilla : int
		{
			Id = 0,
			run = 1,
			Email = 2
		};

		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();

		public string Rut { get; private set; }

		public object[] Parametros
		{
			set
			{
				if (value != null)
				{
					Rut = value[0].ToString();
				}
			}
		}

		#endregion

		#region "Inicio"

		public frmMantenedorClienteCorreo()
		{
			InitializeComponent();
			scPrincipal.Panel2Collapsed = true;
			tsbGuardar.Enabled = false;
			dgvGrilla.AutoGenerateColumns = false;
		}

		private void frmMantenedorClienteCorreo_Load(object sender, EventArgs e)
		{
			CargarGrilla();
		}

		#endregion

		#region Procedimiento
		private void LimpiarFormulario()
		{
			txt_Id.Text = "0";
			txt_Email.Clear();
			txt_run.Text = Rut;
		}
		private void Grabar()
		{
			Boolean bolResult;
			bolResult = false;
			if (MessageBox.Show("Desea grabar la información", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
			{
				if ((tssEstado.Text == "Nuevo") && (txt_Id.Text == "0"))
				{
					ClaseComun.Insertar(Clases.clsBD.BD, tbl_cliente_Email, ref bolResult);
					if (bolResult == true)
					{
						CargarGrilla();
						MessageBox.Show("Dato Guardado");
					}
				}
				else
				if (tssEstado.Text == "Modificar")
				{
					ClaseComun.Modificar(Clases.clsBD.BD, tbl_cliente_Email, ref bolResult);
					if (bolResult == true)
					{
						CargarGrilla();
						MessageBox.Show("Dato modificado");
					}
				}
			}
		}

		private void CargarGrilla()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "SELECT  [Id],[run],[Email]  FROM [dbo].[tbl_cliente_Email] where run='" + Rut + "'";

			cmd.CommandType = CommandType.Text;

			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			dgvGrilla.DataSource = dt.Tables[0];
		}

		private void LlamadoAModificar(int intFila)
		{
			DataTable dt = (DataTable)dgvGrilla.DataSource;
			DataRow currentRow = dt.Rows[intFila];
			txt_Id.Text = currentRow[ConfGrilla.Id.ToString()].ToString();
			txt_run.Text = Rut;
			txt_Email.Text = currentRow[ConfGrilla.Email.ToString()].ToString();
			tssEstado.Text = "Modificar";
			if (txt_Id.Text == "")
			{
				btn_Guardar.Enabled = false;
				tsbGuardar.Enabled = false;
			}
			else
			{
				btn_Guardar.Enabled = true;
				tsbGuardar.Enabled = true;
			}
			scPrincipal.Panel2Collapsed = false;
		}

		#endregion

		#region " grilla"

		private void dgvGrilla_Paint(object sender, PaintEventArgs e)
		{
			int columnIndex = 0;
			Point headerCellLocation = this.dgvGrilla.GetCellDisplayRectangle(columnIndex, -1, true).Location;
			txtBox.Location = new Point(headerCellLocation.X, headerCellLocation.Y + 20);
			txtBox.BackColor = Color.AliceBlue;
			txtBox.Width = ColEmail.Width;
			txtBox.TextChanged += new EventHandler(TextBox_Changed);
			dgvGrilla.Controls.Add(txtBox);
		}

		private void dgvGrilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int intFila = e.RowIndex;
			LlamadoAModificar(intFila);
		}

		private void TextBox_Changed(object sender, EventArgs e)
		{
			BindingSource bs = new BindingSource();
			bs.DataSource = dgvGrilla.DataSource;
			bs.Filter = "Email like '%" + (sender as TextBox).Text + "%'";
			dgvGrilla.DataSource = bs;
		}

		#endregion

		#region "boton"
		private void btn_Limpiar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			LimpiarFormulario();
			tssEstado.Text = "Nuevo";
			txt_Id.Text = "0";

			Cursor = Cursors.Default;
		}

		private void btn_Buscar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			CargarGrilla();

			Cursor = Cursors.Default;
		}

		private void btn_Guardar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			Grabar();
			LimpiarFormulario();
			tssEstado.Text = "Nuevo";
			txt_Id.Text = "0";

			Cursor = Cursors.Default;
		}

		private void btn_Minimizar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			scPrincipal.Panel2Collapsed = true;
			tsbGuardar.Enabled = false;

			Cursor = Cursors.Default;
		}

		private void tsmEliminar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			if (MessageBox.Show("¿Desea Eliminar la información?", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
			{
				DataTable dt = (DataTable)dgvGrilla.DataSource;
				DataRow currentRow = dt.Rows[dgvGrilla.CurrentRow.Index];
				SqlCommand cmd = new SqlCommand();
				cmd.CommandText = "delete tbl_cliente_Email where id=" + currentRow[ConfGrilla.Id.ToString()].ToString();

				cmd.CommandType = CommandType.Text;

				DataSet dt1;
				dt1 = Conectar.Listar(Clases.clsBD.BD, cmd);

				MessageBox.Show("Información eliminada", "mensaje", MessageBoxButtons.OK);
				CargarGrilla();
			}

			Cursor = Cursors.Default;
		}

		private void tsmActualizar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			LlamadoAModificar(dgvGrilla.CurrentRow.Index);

			Cursor = Cursors.Default;
		}

		#endregion

		#region Barra

		private void tsbGuardar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			Grabar();

			Cursor = Cursors.Default;
		}
		private void tsbAgregar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			if (scPrincipal.Panel2Collapsed == true)
				scPrincipal.Panel2Collapsed = false;

			if (scPrincipal.Panel2Collapsed == false)
			{
				tssEstado.Text = "Nuevo";
				tsbGuardar.Enabled = true;
				LimpiarFormulario();
				txt_Id.Text = "0";
			}
			else
			{
				tssEstado.Text = "";
				txt_Id.Text = "";
			}

			Cursor = Cursors.Default;

		}


		#endregion

		private void dgvGrilla_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
		{
			txtBox.Width = ColEmail.Width;
		}
	}
}
