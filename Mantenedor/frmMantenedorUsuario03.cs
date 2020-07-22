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
    public partial class frmMantenedorUsuario03 : Form
    {
        #region "Definicion variable"

        TextBox txtBox = new TextBox();
        enum ConfGrilla: int
        {
            Id_Usuario = 0,
            Rut = 1,
            Nombres = 2,
            Paterno = 3,
            Maternos = 4,
            Id_perfil = 5,
            Id_estado = 6,
            Usuario = 7,
            Contraseña = 8,
            Fecha_agregado = 9,
            Fecha_Modificacion = 10,

            //Id_Usuario],[Rut],[Nombres],[Paterno],[Maternos],u.[Id_perfil],u.[Id_estado],[Usuario],[Contraseña],[Fecha_agregado],[Fecha_Modificacion] ,u.id_estado 
        };

        clsConectorSqlServer Conectar = new clsConectorSqlServer();
        clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
        clsEventoControl ClaseEvento = new clsEventoControl();
        BindingSource bs = new BindingSource();
        dllLibreriaMysql.clsUtiles clsUtiles1 = new dllLibreriaMysql.clsUtiles();

        #endregion

        #region "Inicio"

        public frmMantenedorUsuario03()
        {
            InitializeComponent();
            scPrincipal.Panel2Collapsed = true;
            Cargar_Estado();
            AsignarEvento();
            Cargar_Perfil();
            tsbGuardar.Enabled = false;
            dgvGrilla.AutoGenerateColumns = false; 
        }

        private void frmMantenedorUsuario03_Load(object sender, EventArgs e)
        {            
            CargarGrilla();
        }

        #endregion

        #region Procedimiento
        private void Cargar_Estado()
        {
            ClaseComun.Listar_Estado(Clases.clsBD.BD,ref cbx_id_estadoBuscar, ref cbx_id_estadoBuscar);
            ClaseComun.Listar_Estado(Clases.clsBD.BD,ref cbx_Id_estado, ref cbx_Id_estado);
        }

        private void Cargar_Perfil()
        {
            Cursor = Cursors.WaitCursor;

            // SqlCommand cmd = new SqlCommand();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select Id_perfil, Descripcion FROM tbl_perfil WHERE Id_estado=1 order by Descripcion";
            DataSet dt;
            dt = Conectar.Listar(Clases.clsBD.BD, cmd);

            cbx_Id_perfilBuscar.DisplayMember = dt.Tables[0].Columns[1].Caption.ToString();
            cbx_Id_perfilBuscar.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
            cbx_Id_perfilBuscar.DataSource = dt.Tables[0];

            cbx_Id_perfil.DisplayMember = dt.Tables[0].Columns[1].Caption.ToString();
            cbx_Id_perfil.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
            cbx_Id_perfil.DataSource = dt.Tables[0];

            Cursor = Cursors.Default;

        }

        private void AsignarEvento()
        {
            cbx_Id_estado.KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);
            cbx_Id_perfil.KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);

            SqlCommand cmd = new SqlCommand();
            //SqlCommand cmd = new SqlCommand();
            DataSet dt;
            string strname;
            foreach (Control c in tbl_Usuario.Controls)
            {
                //foreach (Control childc in c.Controls)
                //{
                if (c is TextBox)
                {

                    strname = ((TextBox)c).Name;

                    cmd.CommandText = "SELECT  requerido, validacion " +
                                            " FROM glo_configuracioncampo WHERE campo= '" + strname.Replace("txt_", "") + "'";

                    dt = Conectar.Listar(Clases.clsBD.BD, cmd);
                    if (dt.Tables[0].Rows.Count == 0)
                        ((TextBox)c).KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);
                    else
                    {
                        if (dt.Tables[0].Rows[0]["validacion"].ToString() == "rut")
                        {
                            ((TextBox)c).KeyPress += new KeyPressEventHandler(ClaseEvento.Rut_KeyPress);
                            ((TextBox)c).KeyDown += new KeyEventHandler(ClaseEvento.Rut_KeyDown);
                            ((TextBox)c).Validated += new EventHandler(ClaseEvento.validarut_Validated);
                        }
                        if (dt.Tables[0].Rows[0]["validacion"].ToString() == "numerico")
                        {
                            ((TextBox)c).KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
                            ((TextBox)c).KeyDown += new KeyEventHandler(ClaseEvento.Numero_KeyDown);
                        }
                    }
                }
                if (c is ComboBox)
                    ((ComboBox)c).KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);
                if (c is DateTimePicker)
                    ((DateTimePicker)c).KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);
            }
        }

        private void LimpiarFormulario()
        {
            txt_rut.Text = "";
            txt_paterno.Text = "";
            txt_Nombres.Text = "";
            txt_Maternos.Text = "";
            txt_rut.Enabled = true;
            cbx_Id_estado.SelectedIndex = 0;
            cbx_Id_perfil.SelectedIndex = 0;
           // HabDesa_Controles(false);
            btn_Guardar.Text = "Grabar";
            this.Text = "Agregar Personal";
          //  lbl_Usuario.Text = Clases.clsUsuario.Usuario;
            lbl_Fecha_agregado.Text = DateTime.Now.Date.ToString().Substring(1, 10);
            lbl_Fecha_Modificacion.Text = DateTime.Now.Date.ToString().Substring(1, 10);
            txt_Contraseña.Clear();
            txt_Contraseña1.Clear();
            cbx_Id_estado.SelectedIndex = 0;
            txt_Usuario.Clear();
            txt_rut.Focus();

            txt_Contraseña1.Enabled = true;
            lbl_Id_Usuario.Text = "N° usuario";

            // cbx_id_estado.SelectedIndex = 0;           
        }
        private void Grabar()
        {
           Boolean bolResult;
            bolResult = false;
            if (MessageBox.Show("Desea grabar la información", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if ((tssEstado.Text == "Nuevo")&&(txt_id_tipo_doc.Text=="0"))
                {
                    ClaseComun.Insertar(Clases.clsBD.BD,tbl_Usuario, ref bolResult);
                    if (bolResult == true)
                    {
                        CargarGrilla();
                        MessageBox.Show("Dato Guardado");                        
                    }
                }
                else
                if (tssEstado.Text == "Modificar")
                {
                    if (!String.IsNullOrEmpty(txt_rut.Text) && !String.IsNullOrEmpty(txt_Maternos.Text) && !String.IsNullOrEmpty(txt_paterno.Text) && !String.IsNullOrEmpty(txt_Nombres.Text) && !String.IsNullOrEmpty(txt_Usuario.Text))
                    {

                        ClaseComun.Modificar(Clases.clsBD.BD, tbl_Usuario, ref bolResult);
                        if (bolResult == true)
                        {
                            CargarGrilla();
                            MessageBox.Show("Dato modificado");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Completar todos los datos");
                    }
                
                }
            }  
        }

        private void CargarGrilla()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT [Id_Usuario],[Rut],[Nombres],[Paterno],[Maternos],u.[Id_perfil],u.[Id_estado],[Usuario],[Contraseña],[Fecha_agregado],[Fecha_Modificacion] ,u.id_estado " +
                                            " FROM [dbo].[tbl_Usuario] U inner join tbl_perfil p on p.id_perfil=u.id_perfil" +
                                            " where u.id_estado=" + cbx_id_estadoBuscar.SelectedValue + " and p.id_perfil=" + cbx_Id_perfilBuscar.SelectedValue +
                                  " order by Nombres,Paterno,Maternos";
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

            btn_Guardar.Text = "Modificar";

            //lbl_Contraseña.Enabled = false;
            txt_Contraseña.Enabled = false;
            txt_Contraseña1.Enabled = false;

            lbl_Id_Usuario.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Id_Usuario].ToString();
           // txt_Contraseña1.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Contraseña].ToString();
            txt_Usuario.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Usuario].ToString();
            txt_rut.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Rut].ToString();
            txt_Nombres.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Nombres].ToString();
            txt_paterno.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Paterno].ToString();
            cbx_Id_estado.SelectedValue = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Id_estado].ToString();
            txt_Maternos.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Maternos].ToString();
            cbx_Id_perfil.SelectedValue = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Id_perfil].ToString();

            txt_Contraseña.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Contraseña].ToString();
            try
            {
                txt_Contraseña1.Text = clsUtiles1.DecryptTripleDES(((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Contraseña].ToString());
            }
            catch (Exception)
            {

                txt_Contraseña1.Text = clsUtiles1.GenerateHashMD5(((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Contraseña].ToString());
                txt_Contraseña.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Contraseña].ToString();
            }

            lbl_Fecha_Modificacion.Text = DateTime.Today.ToString().Substring(0, 9);
            lbl_Fecha_agregado.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Fecha_agregado].ToString();

            tssEstado.Text = "Modificar";
            btn_Guardar.Enabled = true;
            tsbGuardar.Enabled = true;

            scPrincipal.Panel2Collapsed = false;
        }

        private void Filtro()
        {
            bs = new BindingSource();
            bs.DataSource = dgvGrilla.DataSource;
            bs.Filter = ColUsuario.DataPropertyName + " like '%" + txtBox.Text + "%'";
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
            txtBox.Width = ColUsuario.Width;
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
            Cursor = Cursors.WaitCursor;
/*
            LimpiarFormulario();
            tssEstado.Text = "Nuevo";
            txt_id_tipo_doc.Text = "0";

            Cursor = Cursors.Default;  */
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

            AsignarEvento();

            if (!String.IsNullOrEmpty(txt_rut.Text) && !String.IsNullOrEmpty(txt_Maternos.Text) && !String.IsNullOrEmpty(txt_paterno.Text) && !String.IsNullOrEmpty(txt_Nombres.Text) && !String.IsNullOrEmpty(txt_Usuario.Text))
            {
                Grabar();
                LimpiarFormulario();
                tssEstado.Text = "Nuevo";
                txt_id_tipo_doc.Text = "0";

            }
            else {
                MessageBox.Show("Debe Completar todos los campos");
            }



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
            /*
            if (MessageBox.Show("¿Desea Eliminar la información?", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {                
                DataTable dt = (DataTable)dgvGrilla.DataSource;
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
            */
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
            
            if(scPrincipal.Panel2Collapsed==true)
                scPrincipal.Panel2Collapsed =false;

            if (scPrincipal.Panel2Collapsed == false)
            {
                tssEstado.Text = "Nuevo";
                tsbGuardar.Enabled = true;
                LimpiarFormulario();
                txt_id_tipo_doc.Text = "0";

                btn_Guardar.Text = "Grabar";
            }
            else
            {
                tssEstado.Text = "";
                txt_id_tipo_doc.Text = "";
            }

            Cursor = Cursors.Default;
        }


        #endregion

        private void dgvGrilla_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            txtBox.Width = ColUsuario.Width;
        }

        private void txt_Contraseña1_TextChanged(object sender, EventArgs e)
        {
            txt_Contraseña.Text = clsUtiles1.GenerateHashMD5(txt_Contraseña1.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvGrilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
