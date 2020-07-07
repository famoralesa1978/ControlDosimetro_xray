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
    public partial class frmMantenedorTipoDocumento : Form
    {
        #region "Definicion variable"

        TextBox txtBox = new TextBox();
        enum ConfGrilla: int
        {
            id=0,
            detalle_tipo_documento = 1,
            Id_estado = 2,
            orden=3
        };

        clsConectorSqlServer Conectar = new clsConectorSqlServer();
        clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
        clsEventoControl ClaseEvento = new clsEventoControl();
        BindingSource bs = new BindingSource();

        #endregion

        #region "Inicio"

        public frmMantenedorTipoDocumento()
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
            txt_detalle_tipo_documento.Clear();
            txt_id_tipo_doc.Clear();
            txt_orden.Clear();
            cbx_id_estado.SelectedIndex = 0;            
        }
        private void Grabar()
        {
            Boolean bolResult;
            bolResult = false;
            if (MessageBox.Show("Desea grabar la información", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if ((tssEstado.Text == "Nuevo")&&(txt_id_tipo_doc.Text=="0"))
                {
                    ClaseComun.Insertar(Clases.clsBD.BD,glo_TipoDocumentos, ref bolResult);
                    if (bolResult == true)
                    {
                        CargarGrilla();
                        MessageBox.Show("Dato Guardado");                        
                    }
                }
                else
                if (tssEstado.Text == "Modificar")
                {
                    ClaseComun.Modificar(Clases.clsBD.BD,glo_TipoDocumentos, ref bolResult);
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
            cmd.CommandText = "select id_tipo_doc as id, detalle_tipo_documento,id_estado,orden from glo_TipoDocumentos where id_estado= " + cbx_id_estado.SelectedValue + "  order by orden";

            cmd.CommandType = CommandType.Text;

            DataSet dt;
            dt = Conectar.Listar(Clases.clsBD.BD,cmd);

            bs.DataSource = dt.Tables[0];
            dgvGrilla.DataSource = bs;
            Filtro();
        }
        private void LlamadoAModificar(int intFila)
        {
            BindingSource bs1 = new BindingSource();
             bs1=(BindingSource)dgvGrilla.DataSource;
            var currentRow = bs1.List[intFila];

            txt_id_tipo_doc.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.id].ToString();
            txt_detalle_tipo_documento.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.detalle_tipo_documento].ToString();          
            txt_orden.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.orden].ToString();
            cbx_id_estado.SelectedValue = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Id_estado].ToString();
            tssEstado.Text = "Modificar";
            btn_Guardar.Enabled = true;
            tsbGuardar.Enabled = true;
            
            scPrincipal.Panel2Collapsed = false;
        }

        private void Filtro()
        {
            bs = new BindingSource();
            bs.DataSource = dgvGrilla.DataSource;
            bs.Filter = Coldetalle_tipo_documento.DataPropertyName + " like '%" + txtBox.Text + "%'";
            dgvGrilla.DataSource = bs;
        }

        #endregion

        #region " grilla"

        private void dgvGrilla_Paint(object sender, PaintEventArgs e)
        {
            int columnIndex = 0;
            Point headerCellLocation = this.dgvGrilla.GetCellDisplayRectangle(columnIndex, -1, true).Location;                     
            txtBox.Location = new Point(headerCellLocation.X, headerCellLocation.Y+20);
            txtBox.BackColor = Color.AliceBlue;
            txtBox.Width = Coldetalle_tipo_documento.Width;
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
            Filtro();
        }

        #endregion

        #region "boton"
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            tssEstado.Text = "Nuevo";
            txt_id_tipo_doc.Text = "0";
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Grabar();
            LimpiarFormulario();
            tssEstado.Text = "Nuevo";
            txt_id_tipo_doc.Text = "0";
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
                DataTable dt = ((DataTable)((BindingSource)((BindingSource)dgvGrilla.DataSource).DataSource).DataSource);
                DataRow currentRow = dt.Rows[dgvGrilla.CurrentRow.Index];
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "pa_TipoDocumento_del " + currentRow[ConfGrilla.id.ToString()].ToString();

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
            Cursor = Cursors.WaitCursor; 

            Grabar();

            Cursor = Cursors.Default;
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
                txt_id_tipo_doc.Text = "0";
            }
            else
            {
                tssEstado.Text = "";
                txt_id_tipo_doc.Text = "";
            }

        }


        #endregion

        private void dgvGrilla_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            txtBox.Width = Coldetalle_tipo_documento.Width;
        }

        private void cmsMenuContexto_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
