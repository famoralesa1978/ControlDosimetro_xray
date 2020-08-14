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
    public partial class frmMantenedorWeb : Form
    {
        #region "Definicion variable"

        TextBox txtColMenu = new TextBox();
        TextBox txtColTitulo = new TextBox();
        Button btnColBuscara = new Button();
        bool bolInicializacion;

        enum ConfGrilla: int
        {
            Id_menuWeb=0,
            Menu = 1,
            Id_menu_Padre = 2,
            DirUrl=3,
            Titulo= 4,
            Class = 5,
            Orden = 6,
            Id_Estado = 7,
        };

        clsConectorSqlServer Conectar = new clsConectorSqlServer();
        clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
        clsEventoControl ClaseEvento = new clsEventoControl();
        BindingSource bs = new BindingSource();

        #endregion

        #region "Inicio"

        public frmMantenedorWeb()
        {
            InitializeComponent();
        }

        private void frmMantenedorPerfil_Load(object sender, EventArgs e)
        {
            scPrincipal.Panel2Collapsed = true;
            Cargar_Estado();
            Cargar_Menu();
            Cargar_Clase();
            tsbGuardar.Enabled = false;
            dgvGrilla.AutoGenerateColumns = false;
            bolInicializacion = true;
            CargarGrilla();
        }

        #endregion

        #region "Llamada a carga"

        private void Cargar_Estado()
        {
            ClaseComun.Listar_Estado(Clases.clsBD.BD, ref cbx_Id_Estado_Buscar, ref cbx_Id_Estado_Buscar);
            ClaseComun.Listar_Estado(Clases.clsBD.BD, ref cbx_Id_Estado, ref cbx_Id_Estado);
        }

        private void Cargar_Menu()
        {
            Cursor = Cursors.WaitCursor;
            SqlCommand cmd = new SqlCommand();
            {

                cmd.CommandText = "SELECT Id_menuWeb, Menu FROM tbl_MenuWeb WHERE Id_menu_padre=0" +
                                   " union select -1 as Id_menuWeb, 'Seleccionar' as Menu " +
                                   "order by Id_menuWeb";
                DataSet dt;
                dt = Conectar.Listar(Clases.clsBD.BD, cmd);

                cbx_Id_menuWeb_Buscar.DisplayMember = dt.Tables[0].Columns[1].Caption.ToString();
                cbx_Id_menuWeb_Buscar.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
                cbx_Id_menuWeb_Buscar.DataSource = dt.Tables[0];

                cmd.CommandText = "SELECT Id_menuWeb, Menu FROM tbl_MenuWeb WHERE Id_menu_padre=0 order by Id_menuWeb";
           
                dt = Conectar.Listar(Clases.clsBD.BD, cmd);
                cbx_Id_menu_Padre.DisplayMember = dt.Tables[0].Columns[1].Caption.ToString();
                cbx_Id_menu_Padre.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
                cbx_Id_menu_Padre.DataSource = dt.Tables[0];
                Cursor = Cursors.Default;

                //"SELECT Id_menuWeb, Menu FROM tbl_MenuWeb WHERE Id_menu_padre=0" +
                //                   " union select 0 as Id_menuWeb, 'Menu Padre' as Menu " +
                //                   "order by Id_menuWeb";
            }
        }

        private void Cargar_Clase() {

            Cursor = Cursors.WaitCursor;
            SqlCommand cmd = new SqlCommand();
            {
                cmd.CommandText = "SELECT [Id_Class],[Class],[Nombre] FROM [dbo].[glo_Class]";
                DataSet dt;
                dt = Conectar.Listar(Clases.clsBD.BD, cmd);

                cbx_Class.DisplayMember = dt.Tables[0].Columns[1].Caption.ToString();
                cbx_Class.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
                cbx_Class.DataSource = dt.Tables[0];

                DataTable dtVista = dt.Tables[0];
                Cursor = Cursors.Default;
            }
        }
        #endregion

        #region Procedimiento

        private void LimpiarFormulario()
        {
            txt_Menu.Clear();
            cbx_Id_menu_Padre.SelectedIndex = -1;
            txt_DirUrl.Clear();
            txt_Titulo.Clear();
            cbx_Class.SelectedIndex = 0;
            txt_Orden.Clear();
            cbx_Id_Estado.SelectedIndex = 0;
        }
        private void txt_Orden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Grabar()
        {
            Boolean bolResult;
            bolResult = false;
            if (MessageBox.Show("¿Desea grabar la información?", "Confirmar:", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if ((tssEstado.Text == "Nuevo") && (lbl_Id_menuWeb.Text == "0"))
                {
                    ClaseComun.Insertar(Clases.clsBD.BD, tbl_MenuWeb, ref bolResult);
                    if (bolResult == true)
                    {
                        CargarGrilla();
                        MessageBox.Show("Dato Guardado");
                    }
                } 
                else
                if (tssEstado.Text == "Modificar")
                {
                    ClaseComun.Modificar(Clases.clsBD.BD, tbl_MenuWeb, ref bolResult);
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
            {
                cmd.CommandText = "SELECT [Id_menuWeb],[Menu],[Id_menu_Padre],[DirUrl],[Titulo],[Class],[Orden],[Id_Estado]" +
                                                " FROM [dbo].[tbl_MenuWeb] WHERE Id_Estado=" + cbx_Id_Estado_Buscar.SelectedValue +
                                                "and Id_menu_Padre=" + cbx_Id_menuWeb_Buscar.SelectedValue + "order by Orden";

                cmd.CommandType = CommandType.Text;

                DataSet dt;
                dt = Conectar.Listar(Clases.clsBD.BD, cmd);

                bs.DataSource = dt.Tables[0];
                dgvGrilla.DataSource = bs;
                Filtro();
            }
        }
        private void LlamadoAModificar(int intFila)
        {
            if (intFila >= 0)
            {
                BindingSource bs1 = new BindingSource();
                bs1 = (BindingSource)dgvGrilla.DataSource;
                var currentRow = bs1.List[intFila];

                lbl_Id_menuWeb.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Id_menuWeb].ToString();
                txt_Menu.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Menu].ToString();
                cbx_Id_menu_Padre.Text= ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Id_menu_Padre].ToString();
                txt_DirUrl.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.DirUrl].ToString();
                txt_Titulo.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Titulo].ToString();
                cbx_Class.SelectedValue = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Class].ToString();
                txt_Orden.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Orden].ToString();
                cbx_Id_Estado.SelectedValue = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Id_Estado].ToString();
                tssEstado.Text = "Modificar";
                btn_Guardar.Enabled = true;
                tsbGuardar.Enabled = true;
                btn_Guardar.Text = "Modificar";
                scPrincipal.Panel2Collapsed = false;
            }
        }

        private void Filtro()
        {
            var bs = new BindingSource();
            {
                bs.DataSource = dgvGrilla.DataSource;
                string strFiltro = txtColMenu.Text != "" ? ColMenu .DataPropertyName + " like '%" + txtColMenu.Text + "%'" : "";
                strFiltro += strFiltro != "" && txtColTitulo.Text != "" ? " and " : "";
                strFiltro += txtColTitulo.Text != "" ? ColTitulo.DataPropertyName + " like '%" + txtColTitulo.Text + "%'" : "";
                bs.Filter = strFiltro;
                dgvGrilla.DataSource = bs;
            }
        }

        #endregion

        #region " grilla"

        private void dgvGrilla_Paint(object sender, PaintEventArgs e)
        {
            if (bolInicializacion == true)
            {
                int columnIndex = 0;
            Point headerCellLocation = this.dgvGrilla.GetCellDisplayRectangle(columnIndex, -1, true).Location;
                txtColMenu.Location = new Point(headerCellLocation.X, headerCellLocation.Y+20);
                txtColMenu.BackColor = Color.AliceBlue;
                txtColMenu.Width = ColMenu.Width-2;
                txtColMenu.TextAlign = HorizontalAlignment.Left;
                dgvGrilla.Controls.Add(txtColMenu);

                columnIndex = 1;
                headerCellLocation = this.dgvGrilla.GetCellDisplayRectangle(columnIndex,-1, true).Location;
                txtColTitulo.Location = new Point(headerCellLocation.X, headerCellLocation.Y + 20);
                txtColTitulo.BackColor = Color.AliceBlue;
                txtColTitulo.Width = ColMenu.Width-1;
                txtColTitulo.TextAlign = HorizontalAlignment.Left;
                dgvGrilla.Controls.Add(txtColTitulo);

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
            txtColMenu.Width = ColMenu.Width-2;
            txtColTitulo.Width = ColTitulo.Width-2;

            int columnIndex = 0;
            Point headerCellLocation = this.dgvGrilla.GetCellDisplayRectangle(columnIndex, -1, true).Location;
            txtColMenu.Location = new Point(headerCellLocation.X, headerCellLocation.Y + 20);

            columnIndex = 1;
            headerCellLocation = this.dgvGrilla.GetCellDisplayRectangle(columnIndex, -1, true).Location;
            txtColTitulo.Location = new Point(headerCellLocation.X, headerCellLocation.Y + 20);
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
            lbl_Id_menuWeb.Text = "0";
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
            tssEstado.Text = "Nuevo";
            lbl_Id_menuWeb.Text = "0";
            Cursor = Cursors.Default;
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            scPrincipal.Panel2Collapsed = true;
            tsbGuardar.Enabled = false;
            Cursor = Cursors.Default;
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
                lbl_Id_menuWeb.Text = "0";
                btn_Guardar.Text = "Grabar";
            }
            else
            {
                tssEstado.Text = "";
                lbl_Id_menuWeb.Text = "";
            }
            Cursor = Cursors.Default;
        }



        #endregion

    
    }
}
