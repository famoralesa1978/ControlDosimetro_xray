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
using System.Configuration;

namespace ControlDosimetro
{
    public partial class frmBusquedaTipoDoc : Form

    {
        #region "Definicion variable"
        clsConectorSqlServer Conectar = new clsConectorSqlServer();
        clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
        clsEventoControl ClaseEvento = new clsEventoControl();
   //     int intTempId_Estado;
   //     int intContar = 0;
    //    int iddoc;
        #endregion
        public frmBusquedaTipoDoc()
        {
            InitializeComponent();
            Cargar_Estado();
            Listar_Grilla();

        }
        private void Cargar_Estado()
        {
            ClaseComun.Listar_Estado(ref cbx_id_estado, ref cbx_id_estado);
        }

        private void Listar_Grilla()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select id_tipo_doc as id, detalle_tipo_documento from glo_TipoDocumentos where id_estado= " + cbx_id_estado.SelectedValue + "  order by orden";

            cmd.CommandType = CommandType.Text;

            DataSet dt;
            dt = Conectar.Listar(cmd);

            grdDatos.DataSource = dt.Tables[0];
        }

        private void grdDatos_DoubleClick(object sender, EventArgs e)
        {
            frmTipoDocumentoMant frm = new frmTipoDocumentoMant(Convert.ToInt64(grdDatos.SelectedCells[0].Value.ToString()));
            frm.ShowDialog(this);
            Listar_Grilla();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            frmTipoDocumentoMant frm = new frmTipoDocumentoMant(0);
            frm.ShowDialog(this);
            Listar_Grilla();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Listar_Grilla();
            MessageBox.Show("Busqueda Realizada");
        }

    }
}
