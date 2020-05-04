using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dllConectorMysql;
using dllLibreriaEvento;
using dllLibreriaMysql;

namespace ControlDosimetro
{
    public partial class frmAsociarFactura : Form
    {

        #region "Definicion variable"
        clsConectorSqlServer Conectar = new clsConectorSqlServer();
        clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
        clsEventoControl ClaseEvento = new clsEventoControl();
        Int64 intTempId_Estado;
        Int64 intTempId_Cliente;
        Int64 intTempPeriodo;
        #endregion


        public frmAsociarFactura(Int64 intId_Cliente, Int64 intPeriodo, Int64 intId_Estado)
        {
            InitializeComponent();

            this.intTempId_Cliente = intId_Cliente;
            this.intTempPeriodo = intPeriodo;
            this.intTempId_Estado = intId_Estado;
            

        }





        private void ObtenerTiposDocumento()
        {
            DataRow dr;
            DataTable dtt = new DataTable("tipodocumento");
            dtt.Columns.Add("Id_Tipo_Documento");
            dtt.Columns.Add("Glosa_Tipo_Documento");

            dr = dtt.NewRow();
            dr["Id_Tipo_Documento"] = 1;
            dr["Glosa_Tipo_Documento"] = "Facturación";
            dtt.Rows.Add(dr);

            cmbTipoDocumento.DataSource = dtt;


            //ClaseComun.Listar_Parametro(Clases.clsBD.BD,cmbTipoDocumento, 8);
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Seleccione archivo a Cargar";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                txtRutaArchivo.Text = fdlg.FileName;
            }
        }


        private void btnGrabarArchivo_Click(object sender, EventArgs e)
        {
            GrabarArchivo();

        }

        private void GrabarArchivo()
        {
            if (File.Exists(txtRutaArchivo.Text))
            {
                String nombrearchivo = Path.GetFileNameWithoutExtension(txtRutaArchivo.Text);
                String extension = Path.GetExtension(txtRutaArchivo.Text).Replace(".", "");


                byte[] buffer = File.ReadAllBytes(txtRutaArchivo.Text);

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "" +

        "   INSERT INTO ges_documentos ([Doc_Id_cliente],[Doc_Id_periodo],[Doc_Nombre],[Doc_Descripcion],[Doc_Extension],[Doc_Archivo],[Doc_Id_Tipo_Documento]) " +
        "   VALUES (@Doc_Id_cliente,@Doc_Id_periodo,@Doc_Nombre,@Doc_Descripcion,@Doc_Extension,@Doc_Archivo,@Doc_Id_Tipo_Documento)  ";

                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.Parameters.Add("@Doc_Id_Cliente", SqlDbType.Int) .Value =  intTempId_Cliente;
                sqlcmd.Parameters.Add("@Doc_Id_Periodo", SqlDbType.Int).Value = intTempPeriodo;
                sqlcmd.Parameters.Add("@Doc_Id_Tipo_Documento",SqlDbType.Int).Value = Convert.ToInt32(cmbTipoDocumento.SelectedValue);
                sqlcmd.Parameters.Add("@Doc_Descripcion", SqlDbType.VarChar, 200).Value = txtDescripcionArchivo.Text.Trim();
                sqlcmd.Parameters.Add("@Doc_Extension", SqlDbType.VarChar, 200).Value = extension;
                sqlcmd.Parameters.Add("@Doc_Nombre", SqlDbType.VarChar, 200).Value = nombrearchivo;
                sqlcmd.Parameters.Add("@Doc_Archivo", SqlDbType.Image).Value =  buffer;

                Conectar.AgregarModificarEliminar(Clases.clsBD.BD,sqlcmd);


                //MostrarArchivo(buffer, Path.GetFileName(txtRutaArchivo.Text));
                MessageBox.Show("Archivo guardado", "Grabado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                //this.Close();

            }
            else
            {
                MessageBox.Show("No existe archivo a cargar", "Error al seleccionar archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LimpiarForm()
        {
            txtRutaArchivo.Text = "";
            txtDescripcionArchivo.Text = "";
            txtDescripcionArchivo.Focus();

        }

        private void AsociarFactura_Load(object sender, EventArgs e)
        {
            ObtenerTiposDocumento();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

    }


}
