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
			Menu=1,
			Acceso=2,
			Lectura=3,
			Nuevo=4,
			Modificacion=5,
			Eliminar=6
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
			Boolean bolResult;
			bolResult = false;
			if (MessageBox.Show("Desea grabar la información", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
			{
				Cursor = Cursors.WaitCursor;
				DataTable dt = (DataTable)dgvGrilla.DataSource;

				DataRow currentRow = dt.Rows[dgvGrilla.CurrentCell.RowIndex];
				SqlCommand cmd = new SqlCommand();
				cmd.CommandText = "pa_Permiso_Del " + currentRow[ConfGrilla.id.ToString()].ToString();
				cmd.CommandType = CommandType.Text;
				Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);

		//		ConfGrillaDetalle: int
		//{
		//			idmenu = 0,
		//	Menu = 1,
			//	Acceso = 2,
			//	Lectura = 3,
			//	Nuevo = 4,
			//	Modificacion = 5,
			//	Eliminar = 6


				foreach (DataRowView row in ((DataTable) dgvDetalle.DataSource).DefaultView)
				{
					string aaa =row[(int)ConfGrillaDetalle.idmenu].ToString();
			
				}

				//pa_Permiso_Del
				//        if (bolResult == true)
				//        {
				//            CargarGrilla();
				//            MessageBox.Show("Dato Guardado");                        
				//        }
				//    }
				//    else
				//    if (tssEstado.Text == "Modificar")
				//    {
				//        ClaseComun.Modificar(Clases.clsBD.BD,tbl_perfil, ref bolResult);
				//        if (bolResult == true)
				//        {
				//            CargarGrilla();
				//            MessageBox.Show("Dato modificado");
				//        }
				//    }
				Cursor = Cursors.Default;
			}
		}

		private void CargarGrilla()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "SELECT  [Id_perfil] as id,Descripcion,Id_estado FROM [dbo].[tbl_perfil]  order by Descripcion";

			cmd.CommandType = CommandType.Text;

			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

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
			dtDet = Conectar.Listar(Clases.clsBD.BD, cmd);

			dgvDetalle.DataSource = dtDet.Tables[0];

			//txt_Descripcion.Text = currentRow[ConfGrilla.descripcion.ToString()].ToString();
			//cbx_id_estado.SelectedValue = currentRow[ConfGrilla.Id_estado.ToString()].ToString();
			//tssEstado.Text = "Modificar";
			//if (txt_Id_perfil.Text == "1")
			//{
			//	btn_Guardar.Enabled = false;
			//	tsbGuardar.Enabled = false;
			//}
			//else
			//{
			//	btn_Guardar.Enabled = true;
			//	tsbGuardar.Enabled = true;
			//}
			//scPrincipal.Panel2Collapsed = false;
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
