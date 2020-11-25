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
        enum ConfGrilla: int
        {
            id=0,
            descripcion=1,
            Id_estado = 2
        };

        clsConectorSqlServer Conectar = new clsConectorSqlServer();
        clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
        clsEventoControl ClaseEvento = new clsEventoControl();

        #endregion

        #region "Inicio"

        public frmMantenedorPermiso()
        {
            InitializeComponent();
          //  scPrincipal.Panel2Collapsed = true;
            tsbGuardar.Enabled = false;
            dgvGrilla.AutoGenerateColumns = false;
        }

        private void frmMantenedorPermiso_Load(object sender, EventArgs e)
        {            
            CargarGrilla();
        }

        #endregion

        #region Procedimiento
    
        private void Grabar()
        {
            //Boolean bolResult;
            //bolResult = false;
            //if (MessageBox.Show("Desea grabar la información", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            //{
            //    if ((tssEstado.Text == "Nuevo")&&(txt_Id_perfil.Text=="0"))
            //    {
            //        ClaseComun.Insertar(Clases.clsBD.BD,tbl_perfil, ref bolResult);
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
            //}
        }

        private void CargarGrilla()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT  [Id_perfil] as id,Descripcion,Id_estado FROM [dbo].[tbl_perfil]  order by Descripcion";

            cmd.CommandType = CommandType.Text;

            DataSet dt;
            dt = Conectar.Listar(Clases.clsBD.BD,cmd);

            dgvGrilla.DataSource = dt.Tables[0];
        }

		private void LlamadoAModificar(int intFila)
		{
			DataTable dt = (DataTable)dgvGrilla.DataSource;
			DataRow currentRow = dt.Rows[intFila];
			//txt_Id_perfil.Text = currentRow[ConfGrilla.id.ToString()].ToString();

			//pa_Permiso_sel currentRow[ConfGrilla.id.ToString()].ToString();

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
            txtBox.Location = new Point(headerCellLocation.X, headerCellLocation.Y+20);
            txtBox.BackColor = Color.AliceBlue;
            txtBox.Width = Colperfil1.Width;
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
            bs.Filter ="Descripcion like '%" + (sender as TextBox).Text + "%'";
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

        private void dgvGrilla_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            txtBox.Width = Colperfil1.Width;
        }
    }
}
