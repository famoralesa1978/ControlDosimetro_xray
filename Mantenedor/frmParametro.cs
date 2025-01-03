﻿using System;
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
   
    public partial class frmParametro : Form
    {
        #region "Definicion variable"
		 clsConectorSqlServer Conectar = new clsConectorSqlServer();
		  clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver(); 
        #endregion

        public frmParametro()
        {
            InitializeComponent();
            
            Cargar_Estado();
            Listar_Conf_Parametro();
        }

#region "Llamada de carga"

    private void Listar_Conf_Parametro()
        {
            SqlCommand cmd = new SqlCommand();
		//	  SqlCommand cmd = new SqlCommand();
            //MessageBox.Show("Conectado al servidor");


            cmd.CommandText = "select Id_parametro ,descripcion,  orden from conf_parametro where id_estado= " + cbx_Estado.SelectedValue.ToString() + "  order by orden";
            cmd.CommandType = CommandType.Text ;

            DataSet dt;
            dt = Conectar.Listar(ClaseGeneral.Conexion,cmd);

            grdDatos.DataSource = dt.Tables[0] ;            
        }
         
    private void Cargar_Estado()
    {
        ClaseComun.Listar_Estado(ClaseGeneral.Conexion,ref cbx_Estado, ref cbx_EstadoId);           
    }

#endregion

#region"Button"
    private void btn_Buscar_Click(object sender, EventArgs e)
    {
        Cursor = Cursors.WaitCursor;

        Listar_Conf_Parametro();
        MessageBox.Show("Busqueda Realizada");

        Cursor = Cursors.Default;
    }

    private void btn_Agregar_Click(object sender, EventArgs e)
    {
        Cursor = Cursors.WaitCursor;

        frmParametroMant frm = new frmParametroMant(0);
        frm.ShowDialog (this);
        Listar_Conf_Parametro();
            // frmParametroMant.Show();

        Cursor = Cursors.Default;
    }

#endregion

    #region "grilla"
    private void grdDatos_DoubleClick(object sender, EventArgs e)
    {
        frmParametroMant frm = new frmParametroMant(Convert.ToInt64(grdDatos.SelectedCells[0].Value.ToString()));
        frm.ShowDialog(this);
        Listar_Conf_Parametro();
    }

    #endregion

   

    


    }
}
