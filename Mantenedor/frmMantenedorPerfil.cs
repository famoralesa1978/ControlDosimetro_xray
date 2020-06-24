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
    public partial class frmMantenedorPerfil : Form
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

        public frmMantenedorPerfil()
        {
            InitializeComponent();
            scPrincipal.Panel2Collapsed = true;
            Cargar_Estado();
            tsbGuardar.Enabled = false;
            dgvGrilla.AutoGenerateColumns = false;
        }

        private void frmMantenedorPerfil_Load(object sender, EventArgs e)
        {            
            CargarGrilla();
        }

        #endregion

        #region Procedimiento
        private void Cargar_Estado()
        {
            ClaseComun.Listar_Estado(Clases.clsBD.BD,ref cbx_id_estado_Buscar, ref cbx_id_estado_Buscar);
            ClaseComun.Listar_Estado(Clases.clsBD.BD,ref cbx_id_estado, ref cbx_id_estado);
        }
        private void LimpiarFormulario()
        {
            txt_Descripcion.Clear();
            txt_Id_perfil.Clear();
            cbx_id_estado.SelectedIndex = 0;            
        }
        private void Grabar()
        {
            Boolean bolResult;
            bolResult = false;
            if (MessageBox.Show("Desea grabar la información", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if ((tssEstado.Text == "Nuevo")&&(txt_Id_perfil.Text=="0"))
                {
                    ClaseComun.Insertar(Clases.clsBD.BD,tbl_perfil, ref bolResult);
                    if (bolResult == true)
                    {
                        CargarGrilla();
                        MessageBox.Show("Dato Guardado");                        
                    }
                }
                else
                if (tssEstado.Text == "Modificar")
                {
                    ClaseComun.Modificar(Clases.clsBD.BD,tbl_perfil, ref bolResult);
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
            cmd.CommandText = "SELECT  [Id_perfil] as id,Descripcion,Id_estado FROM [dbo].[tbl_perfil]  where id_estado= " + cbx_id_estado_Buscar.SelectedValue + "  order by Descripcion";

            cmd.CommandType = CommandType.Text;

            DataSet dt;
            dt = Conectar.Listar(Clases.clsBD.BD,cmd);

            dgvGrilla.DataSource = dt.Tables[0];
        }
        private void LlamadoAModificar(int intFila)
        {
            DataTable dt = (DataTable)dgvGrilla.DataSource;
            DataRow currentRow = dt.Rows[intFila];
            txt_Id_perfil.Text = currentRow[ConfGrilla.id.ToString()].ToString();
            txt_Descripcion.Text = currentRow[ConfGrilla.descripcion.ToString()].ToString();
            cbx_id_estado.SelectedValue = currentRow[ConfGrilla.Id_estado.ToString()].ToString();
            tssEstado.Text = "Modificar";
            if (txt_Id_perfil.Text == "1")
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
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            LimpiarFormulario();
            tssEstado.Text = "Nuevo";
            txt_Id_perfil.Text = "0";

            Cursor = Cursors.Default;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            Grabar();
            LimpiarFormulario();
            tssEstado.Text = "Nuevo";
            txt_Id_perfil.Text = "0";

            Cursor = Cursors.Default;
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            scPrincipal.Panel2Collapsed = true;
            tsbGuardar.Enabled = false;
        }

        private void tsmEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Eliminar la información?", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {                
                DataTable dt = (DataTable)dgvGrilla.DataSource;
                DataRow currentRow = dt.Rows[dgvGrilla.CurrentRow.Index];
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "pa_Perfil_del " + currentRow[ConfGrilla.id.ToString()].ToString();

                cmd.CommandType = CommandType.Text;

                DataSet dt1;
                dt1 = Conectar.Listar(Clases.clsBD.BD,cmd);

                MessageBox.Show(dt1.Tables[0].Rows[0][1].ToString());
                if (dt1.Tables[0].Rows[0][0].ToString() == "0")
                    CargarGrilla();
            }
        }

        private void tsmActualizar_Click(object sender, EventArgs e)
        {
            LlamadoAModificar(dgvGrilla.CurrentRow.Index);
        }

        #endregion

        #region Barra

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            Grabar();  
        }
        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            if(scPrincipal.Panel2Collapsed==true)
                scPrincipal.Panel2Collapsed =false;

            if (scPrincipal.Panel2Collapsed == false)
            {
                tssEstado.Text = "Nuevo";
                tsbGuardar.Enabled = true;
                LimpiarFormulario();
                txt_Id_perfil.Text = "0";
            }
            else
            {
                tssEstado.Text = "";
                txt_Id_perfil.Text = "";
            }

        }


        #endregion

        private void dgvGrilla_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            txtBox.Width = Colperfil1.Width;
        }
    }
}
