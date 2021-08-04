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
using classFuncionesBD;

namespace ControlDosimetro
{
	public partial class frmFacturar : Form
	{

		#region "Definicion variable"

		private bool bolInicio = false;
		ClsFunciones clsFunc = new ClsFunciones();
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();

		classFuncionesBD.ClsFunciones FuncBD = new classFuncionesBD.ClsFunciones();

		public string Id_Menu { get; private set; }
		private bool Inicializar = true;

		public object[] Parametros
		{
			set
			{
				if (value != null)
				{
					Id_Menu = value[0].ToString();
				}
			}
		}

		#endregion

		#region "inicio"

		public frmFacturar()
		{
			InitializeComponent();
			AsignarEvento();
			grdDetalle.AutoGenerateColumns = false;
		}

		private void frmFacturar_Load(object sender, EventArgs e)
		{
			
			Cargar_Anno();
		}

		#endregion

		#region "Llamada de carga"

		private void Listar_Personal()
		{
			//SqlCommand cmd = new SqlCommand();
			////SqlCommand cmd = new SqlCommand();

			//DataSet dt;

			//int intSucursal = cbx_Sucursal.SelectedValue == null ? 0 : (int)cbx_Sucursal.SelectedValue;
			//int intSeccion = cbx_id_seccion.SelectedValue == null ? 0 : (int)cbx_id_seccion.SelectedValue;

			//cmd.CommandText = "pa_ConsultaIngresoFilmicoPorSeccion_sel " + cbx_id_periodo.SelectedValue.ToString() + "," + lbl_id_cliente.Text + "," + intSeccion.ToString() + "," + intSucursal.ToString();

			//cmd.CommandType = CommandType.Text;

			//dt = Conectar.Listar(Clases.clsBD.BD, cmd);
			//string filterExp = "";
			//string sortExp = "rut";
			//DataRow[] drarray;
			//drarray = dt.Tables[0].Select(filterExp, sortExp, DataViewRowState.CurrentRows);

			//string filterExp1 = "Rut is null";
			//string sortExp1 = "N_pelicula";
			//DataRow[] drarray1;
			//drarray1 = dt.Tables[0].Select(filterExp1, sortExp1, DataViewRowState.CurrentRows);

			//filterExp1 = "Medicion ='Si'";
			//sortExp1 = "N_pelicula";
			//DataRow[] drarray2;
			//drarray2 = dt.Tables[0].Select(filterExp1, sortExp1, DataViewRowState.CurrentRows);

			//filterExp1 = "Referencia =true";
			//sortExp1 = "N_pelicula";
			//DataRow[] drarray3;
			//drarray3 = dt.Tables[0].Select(filterExp1, sortExp1, DataViewRowState.CurrentRows);

			//groupBox2.Text = String.Format("Listado       Total registro: {0}, registro Faltante: {1}, Total con Dosis : {2}, Total referencia: {3}",
			//					drarray.Count().ToString(), drarray1.Count().ToString(), drarray2.Count().ToString(), drarray3.Count());


			//if (dt.Tables[0].Rows.Count == 0)
			//{
			//	grdDatos.DataSource = dt.Tables[0];
			//	grpFiltro.Enabled = false;

			//}
			//else
			//{
			//	grpFiltro.Enabled = true;
			//	grdDatos.DefaultCellStyle.BackColor = System.Drawing.Color.White;
			//	grdDatos.DataSource = dt.Tables[0];
			//}
		}

		private void Cargar_Anno()
		{
			clsFunc.Cargar_Año(ref cbx_anno, 3);
		}

		private void Cargar_Periodo()
		{
			clsFunc.Cargar_Periodo(ref cbx_id_periodo, 3, (int)cbx_anno.SelectedValue);
		}

		private void AsignarEvento()
		{
			Clases.ClassEvento classEvento = new Clases.ClassEvento();
			classEvento.AsignarNumero(ref lbl_id_cliente);

			
		}

		#endregion

		#region "combobox"

		private void Cbx_anno_SelectedIndexChanged(object sender, EventArgs e)
		{
			Cargar_Periodo();
		}


		#endregion

	}
}

