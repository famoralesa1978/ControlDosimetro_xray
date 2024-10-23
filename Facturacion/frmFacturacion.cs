using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using XRAY.Clases;
using System.Diagnostics;
using dllConectorMysql;
using dllLibreriaMysql;
using dllLibreriaEvento;
using System.Data.SqlClient;

namespace ControlDosimetro
{
    public partial class FrmFacturacion : Form
    {

        #region "Definicion variable"
        clsConectorSqlServer Conectar = new clsConectorSqlServer();
        clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
        clsEventoControl ClaseEvento = new clsEventoControl();
        int intTempId_Estado;
        private int intContar = 0;
        int iddoc;
        #endregion


        public FrmFacturacion( int intId_Estado)
        {
            InitializeComponent();
            Cargar_Anno();
            Cargar_Periodo();
            this.intTempId_Estado = intId_Estado;


        }

        private void Cargar_Cliente(int intCodCliente)
        {
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "select run,Razon_Social,N_Cliente_Ref,region + ','+ comuna +','+Direccion as Direccion ,r.Id_Region,c.Id_Provincia,c.Id_Comuna,Telefono, Id_TipoFuente,Id_estado,Fechainicio " +
                            "  FROM tbl_cliente c inner join [dbo].[glo_region] r on c.Id_Region=r.Id_Region inner join glo_comuna co on co.id_comuna=c.id_comuna" +
                            " WHERE Id_cliente= " + intCodCliente.ToString()
            };
            DataSet dt;

            dt = Conectar.Listar(ClaseGeneral.Conexion,cmd);

            txt_CodCliente.Text = intCodCliente.ToString();
            lbl_nombreCliente.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
            lbl_Direccion.Text = dt.Tables[0].Rows[0]["Direccion"].ToString();
        }

        private void Cargar_Anno()
        {
            SqlCommand cmd = new SqlCommand
            {

                //	  SqlCommand cmd = new SqlCommand();

                CommandText = "SELECT distinct Anno FROM conf_periodo WHERE Id_TipoPeriodo=3"
            };
            //cmd.CommandText = "SELECT Id_Periodo,Anno, Mes,Id_TipoPeriodo FROM conf_periodo WHERE Id_TipoPeriodo=3";
            DataSet dt;
            dt = Conectar.Listar(ClaseGeneral.Conexion,cmd);

            cbx_anno.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
            cbx_anno.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
            cbx_anno.DataSource = dt.Tables[0];

        }

        private void Cargar_Periodo()
        {
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "SELECT Id_Periodo,Mes, cast((mes/3) as varchar(10))+ '°T' FROM conf_periodo WHERE Id_TipoPeriodo=3 and Anno=" + cbx_anno.Text
            };
            DataSet dt;
            dt = Conectar.Listar(ClaseGeneral.Conexion,cmd);

            cbx_periodo.DisplayMember = dt.Tables[0].Columns[2].Caption.ToString();
            cbx_periodo.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
            cbx_periodo.DataSource = dt.Tables[0];

        }

        #region "combobox"

        private void Cbx_anno_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cargar_Periodo();
        }

        #endregion

        #region "combobox"
        private void AsignarEvento()
        {
            //this.txt_Rut.KeyPress += new KeyPressEventHandler(ClaseEvento.Rut_KeyPress);
            //txt_Rut.KeyDown += new KeyEventHandler(ClaseEvento.Rut_KeyDown);
            //txt_Rut.Validated += new EventHandler(ClaseEvento.validarut_Validated);

            txt_CodCliente.KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
            txt_CodCliente.KeyDown += new KeyEventHandler(ClaseEvento.Numero_KeyDown);

            //txt_RazonSocial.KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);


        }
        #endregion


        private Documento BuscarDocumento(int iddoc)
        {
            Documento doc = null;
            SqlCommand sqlcmd = new SqlCommand
            {
                CommandText = "" +
            "SELECT	[Doc_Id], [Doc_Id_cliente], [Doc_Id_periodo],[Doc_Nombre], [Doc_Descripcion], [Doc_Extension], " +
            " [Doc_Archivo], [Doc_Id_Tipo_Documento] FROM	ges_documentos WHERE	[Doc_Id] = @Doc_Id"
            };
            sqlcmd.Parameters.Add("@Doc_Id", SqlDbType.Int).Value = iddoc;

            DataTable dtt = Conectar.Listar(ClaseGeneral.Conexion,sqlcmd).Tables[0];

            DataRow dr;
            if (dtt.Rows.Count == 1)
            {
                doc = new Documento();
                dr = dtt.Rows[0];

                doc.Doc_Id = iddoc;
                doc.Doc_Id_Cliente = Convert.ToInt32(dr["Doc_Id_Cliente"]);
                doc.Doc_Id_Periodo = Convert.ToInt32(dr["Doc_Id_Periodo"]);
                doc.Doc_Nombre = dr["Doc_Nombre"].ToString();
                doc.Doc_Descripcion = dr["Doc_Descripcion"].ToString();
                doc.Doc_Extension = dr["Doc_Extension"].ToString();
                doc.Doc_Archivo = (byte[])dr["Doc_Archivo"];
                doc.Doc_Id_Tipo_Documento = Convert.ToInt32(dr["Doc_Id_Tipo_Documento"]);
            }

            return doc;


        }

        private void MostrarArchivo(byte[] file, String nombre)
        {

            String pathname = Path.GetTempFileName();
            string ruta = Path.GetDirectoryName(pathname) + "\\" + nombre;
            if (File.Exists(ruta))
            {
                File.Delete(ruta);
            }
            File.Move(pathname, ruta);
            File.WriteAllBytes(ruta, file);

            Process.Start(ruta);
        }

        private void DgvArchivos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }



        private void Btn_cargarCliente_Click(object sender, EventArgs e)
        {

        }

        private void Listar_Cliente(Int64 intCliente)
        {
            //SqlCommand cmd = new SqlCommand();
            SqlCommand cmd = new SqlCommand();
            //MessageBox.Show("Conectado al servidor");

            if (intCliente != 0)
            {
                cmd.CommandText = "select id_cliente,run,razon_social,Direccion,telefono " +
                        "from tbl_cliente " +
                        "where  (id_cliente=" + intCliente.ToString() + ") " +
                        " and id_estado=1 " +
                        "order by id_cliente";
            }

            cmd.CommandType = CommandType.Text;

            DataSet dt;
            dt = Conectar.Listar(ClaseGeneral.Conexion,cmd);
        }

        private void BtnCargarCliente_Click(object sender, EventArgs e)
        {
            if (txt_CodCliente.Text == "")
                Listar_Cliente(0);
            else
                Listar_Cliente(Convert.ToInt64(txt_CodCliente.Text.ToString()));

            if (lbl_nombreCliente.Text == "")
            {
                MessageBox.Show("El cliente puede estar inactivo o no existe");
            }

            ConfigBotonFactura();
        }


        private void ConfigBotonFactura()
        {
            iddoc = VerificarFacturas();

            if (iddoc == 0)
            {
                btnAccionFactura.Text = "Agregar Factura a Cliente";
            }
            else
            {
                btnAccionFactura.Text = "Ver Factura Asociada.";
            }
        }

        private void Listar_Grilla()
        {
            SqlCommand cmd = new SqlCommand();
            Int64 intN_Documento;

            intN_Documento = 0;

            DataSet dt;
            //  switch (intintId_Estado_temp)
            //  {
            //      case 0:
            cmd.CommandText = "pa_Dosimetro_sel " + txt_CodCliente.Text + "," + cbx_periodo.SelectedValue.ToString() + "," + intTempId_Estado.ToString() + "," + intN_Documento.ToString();
            //          break;
            //      case 2:
            //          cmd.CommandText = "pa_Dosimetro_sel " + txt_CodCliente.Text + "," + cbx_id_periodo.Text + "," + intintId_Estado_temp.ToString() + "," + intN_Documento.ToString();
            //          break;
            //  }
            //cmd.CommandType = CommandType.StoredProcedure ;

            dt = Conectar.Listar(ClaseGeneral.Conexion,cmd);

            grdDatos.DataSource = dt.Tables[0];

            if (txt_CodCliente.Text != "0")
                if (dt.Tables[0].Rows.Count == 0)
                    MessageBox.Show("No se ha ingresado información");

            //string filterExp = "id_cliente=" + lbl_id_cliente.Text;
            //string sortExp = "Per";
            //DataRow[] drarray;
            //drarray = dt.Tables[0].Select(filterExp, sortExp, DataViewRowState.CurrentRows);

            //  groupBox2.Text = "Listado       Registro:" + drarray.Count().ToString();
            // intContar = drarray.Count();
            //groupBox2   intContar
            //if (dt.Tables[0].Rows.Count == 0)
            //{
            //    btn_Guardar.Visible = false;
            //    MessageBox.Show("No se han cargado ningun número de pelicula para el cliente");				  
            //}
            //else
            //{
            //    btn_Guardar.Visible = true;
            //   // MessageBox.Show("Se encontraron personal asociado al cliente");				
            //}
        }


        private int VerificarFacturas()
        { 
            /*
        
    */
            int iddoc;
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "SELECT doc_id as id FROM ges_documentos where doc_id_cliente = @doc_id_cliente and doc_id_periodo = @doc_id_periodo"
            };
            cmd.Parameters.Add("@doc_id_cliente", SqlDbType.Int).Value = Convert.ToInt32(txt_CodCliente.Text);
            cmd.Parameters.Add("@doc_id_periodo", SqlDbType.Int).Value = Convert.ToInt32(cbx_periodo.SelectedValue.ToString());
            cmd.CommandType = CommandType.Text;

            DataSet dt;
            dt = Conectar.Listar(ClaseGeneral.Conexion,cmd);

            if (dt.Tables.Count > 0)
            {
                if (dt.Tables[0].Rows.Count > 0) // tiene documento
                {
                    iddoc = Convert.ToInt32(dt.Tables[0].Rows[0]["id"].ToString());

                }
                else // no existe documento
                {
                    iddoc = 0;
                }
            }
            else
            {
                iddoc = 0;
            }

            return iddoc;

        }

        private void BtnAccionFactura_Click(object sender, EventArgs e)
        {
            if (iddoc > 0) // ABRIR DOC
            {


                Documento doc = BuscarDocumento(iddoc);
                MostrarArchivo(doc.Doc_Archivo, doc.Doc_Nombre + ".pdf");
            }
            else
            {

                frmAsociarFactura frmAsociarFactura = new frmAsociarFactura(Convert.ToInt64(txt_CodCliente.Text.ToString()), Convert.ToInt64(cbx_periodo.SelectedValue.ToString()), intTempId_Estado);
                DialogResult res = frmAsociarFactura.ShowDialog();

                if (res == System.Windows.Forms.DialogResult.OK)
                {
                    ConfigBotonFactura();
                }

            }
        }

            
    }
}

