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
    public partial class frmMantenedorNuevoReporte : Form
    {
        #region "Definicion variable"

        TextBox txtBox = new TextBox();
        Button btnColBuscara = new Button();
        bool bolInicializacion;
        enum ConfGrilla: int
        {
            Nombre=0,
            N_Reporte = 1,
            NameManu = 2,
            
        };

        clsConectorSqlServer Conectar = new clsConectorSqlServer();
        clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
        clsEventoControl ClaseEvento = new clsEventoControl();
        BindingSource bs = new BindingSource();

        #endregion

        #region "Inicio"

        public frmMantenedorNuevoReporte()
        {
            InitializeComponent();
           
        }

        private void frmMantenedorPerfil_Load(object sender, EventArgs e)
        {

            scPrincipal.Panel2Collapsed = true;
            tsbGuardar.Enabled = false;
            dgvGrilla.AutoGenerateColumns = false;
            bolInicializacion = true;
            CargarGrilla();
          
        }

        #endregion

        #region Procedimiento
        
        private void LimpiarFormulario()
        {
            txt_Nombre.Clear();
            txt_NameMenu.Clear();
            txt_N_Reporte.Clear();
                    
        }
        private void Grabar()
        {
            Boolean bolResult;
            bolResult = false;
            if (MessageBox.Show("Desea grabar la información", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if ((tssEstado.Text == "Nuevo") && (txt_N_Reporte.Text == "0"))
                {

                    ClaseComun.Insertar(ClaseGeneral.Conexion, tbl_Reporte, ref bolResult);
                        if (bolResult == true)
                        {
                            CargarGrilla();
                            MessageBox.Show("Dato Guardado");
                        }
                                      
                }
                else
                if (tssEstado.Text == "Modificar")
                {
                    if (!String.IsNullOrEmpty(txt_Nombre.Text) && !String.IsNullOrEmpty(txt_N_Reporte.Text))
                    {
                        ClaseComun.Modificar(ClaseGeneral.Conexion, tbl_Reporte, ref bolResult);
                        if (bolResult == true)
                        {
                            CargarGrilla();
                            MessageBox.Show("Dato modificado");
                        }

                    }
                    else {
                        MessageBox.Show("Completar todos los campos");
                    }
                }
            }
        }

        private void CargarGrilla()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select Nombre, N_Reporte, NameMenu from tbl_Reporte order by Nombre";

            cmd.CommandType = CommandType.Text;

            DataSet dt;
            dt = Conectar.Listar(ClaseGeneral.Conexion,cmd);

            bs.DataSource = dt.Tables[0];
            dgvGrilla.DataSource = bs;
            Filtro();
        }
        private void LlamadoAModificar(int intFila)
        {
            BindingSource bs1 = new BindingSource();
             bs1=(BindingSource)dgvGrilla.DataSource;
            var currentRow = bs1.List[intFila];

            txt_Nombre.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Nombre].ToString();          
            txt_N_Reporte.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.N_Reporte].ToString();
            txt_NameMenu.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.NameManu].ToString();
            tssEstado.Text = "Modificar";
            btn_Guardar.Enabled = true;
            tsbGuardar.Enabled = true;
            btn_Guardar.Text = "Modificar";

            scPrincipal.Panel2Collapsed = false;
        }

        private void Filtro()
        {
            bs = new BindingSource();
            bs.DataSource = dgvGrilla.DataSource;
            bs.Filter = ColNombre.DataPropertyName + " like '%" + txtBox.Text + "%'";
            dgvGrilla.DataSource = bs;
        }

        #endregion

        #region " grilla"

        private void dgvGrilla_Paint(object sender, PaintEventArgs e)
        {
            if (bolInicializacion == true)
            {
                int columnIndex = 0;
            Point headerCellLocation = this.dgvGrilla.GetCellDisplayRectangle(columnIndex, -1, true).Location;                     
            txtBox.Location = new Point(headerCellLocation.X, headerCellLocation.Y+20);
            txtBox.BackColor = Color.AliceBlue;
            txtBox.Width = ColNombre.Width-2;
             txtBox.TextAlign = HorizontalAlignment.Left;
                dgvGrilla.Controls.Add(txtBox);

            columnIndex = -1;
            headerCellLocation = this.dgvGrilla.GetCellDisplayRectangle(columnIndex, -1, true).Location;
            btnColBuscara.Location = new Point(headerCellLocation.X, headerCellLocation.Y + 0);
            btnColBuscara.Image = ControlDosimetro.Properties.Resources.Buscar;

            btnColBuscara.FlatStyle = FlatStyle.Standard;
            btnColBuscara.Height = 41;
            btnColBuscara.Width = 41;
            btnColBuscara.Click += new EventHandler(BtnColBuscar_Click);

            dgvGrilla.Controls.Add(btnColBuscara);
            }
            bolInicializacion = false;
        }

        private void dgvGrilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int intFila = e.RowIndex;
            LlamadoAModificar(intFila);
        }

        private void dgvGrilla_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            txtBox.Width = ColNombre.Width - 4;
            int columnIndex = 0;
            Point headerCellLocation = this.dgvGrilla.GetCellDisplayRectangle(columnIndex, -1, true).Location;
            txtBox.Location = new Point(headerCellLocation.X, headerCellLocation.Y + 20);
        }

        #endregion

        #region "boton"
        private void BtnColBuscar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Filtro();
            Cursor = Cursors.Default;
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            LimpiarFormulario();
            tssEstado.Text = "Nuevo";
            txt_N_Reporte.Text = "0";

            Cursor = Cursors.Default;
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            CargarGrilla();

            Cursor = Cursors.Default;
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            Grabar();
           // LimpiarFormulario();
            tssEstado.Text = "Nuevo";
            txt_N_Reporte.Text = "0";

            Cursor = Cursors.Default;
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            
        }

      

        private void TsmActualizar_Click(object sender, EventArgs e)
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

            if(scPrincipal.Panel2Collapsed==true)
                scPrincipal.Panel2Collapsed =false;

            if (scPrincipal.Panel2Collapsed == false)
            {
                tssEstado.Text = "Nuevo";
                tsbGuardar.Enabled = true;
                LimpiarFormulario();
                txt_N_Reporte.Text = "0";

                btn_Guardar.Text = "Grabar";
            }
            else
            {
                tssEstado.Text = "";
                txt_N_Reporte.Text = "";
            }

            Cursor = Cursors.Default;
        }




        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            scPrincipal.Panel2Collapsed = true;
            tsbGuardar.Enabled = false;

            Cursor = Cursors.Default;
        }

        private void tbl_Reporte_Enter(object sender, EventArgs e)
        {

        }
    }
}
