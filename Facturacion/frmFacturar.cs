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
    public partial class frmFacturar : Form
    {

        #region "Definicion variable"
        clsConectorSqlServer Conectar = new clsConectorSqlServer();
        clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
        clsEventoControl ClaseEvento = new clsEventoControl();
        int intTempId_Estado;
        private int intContar = 0;
        int iddoc;
        #endregion


        public frmFacturar( int intId_Estado)
        {
            InitializeComponent();
            this.intTempId_Estado = intId_Estado;


        }

		private void Cbx_anno_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}

