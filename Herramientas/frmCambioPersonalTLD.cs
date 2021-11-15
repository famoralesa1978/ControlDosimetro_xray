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
using Microsoft.Reporting.WinForms;
using System.Net.Mime;
using System.Net;
using System.Net.Mail;
using classFuncionesBD;

namespace ControlDosimetro
{
    public partial class frmCambioPersonalTLD : Form
    {

        #region "Definicion variable"
				clsConectorSqlServer Conectar = new clsConectorSqlServer();
				clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
            clsEventoControl ClaseEvento = new clsEventoControl();
        clsUtiles clsUtiles1 = new dllLibreriaMysql.clsUtiles();
        ClsFunciones clsFunc = new ClsFunciones();
        #endregion

		public frmCambioPersonalTLD()
		{
			InitializeComponent();
			AsignarEvento();
			Btn_filtro_Click(null,null);
		}

		#region "Llamada de carga"      

		private void Cargar_Documento(Int64 intNDocumento)
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "select P.Id_cliente,run,Razon_Social,Id_sucursal " +
								 "  FROM ges_DosimetriaPersonal P inner join tbl_cliente C on P.Id_cliente=C.Id_cliente WHERE N_Documento= " + intNDocumento.ToString();
			DataSet dt;

			dt = Conectar.Listar(Clases.clsBD.BD, cmd);
			if (dt.Tables[0].Rows.Count == 1)
			{
				lbl_NCliente.Text = dt.Tables[0].Rows[0]["Id_cliente"].ToString();
				lbl_NombreCliente.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
				Cargar_Sucursal(dt.Tables[0].Rows[0]["run"].ToString());
				cbx_SucActual.SelectedValue = dt.Tables[0].Rows[0]["Id_sucursal"];
				btn_Cargar.Enabled = false;
				txt_NDoc.Enabled = false;
				btn_Guardar.Enabled = true;
			}
			else
			if (dt.Tables[0].Rows.Count > 1)
			{
				lbl_NCliente.Text = "";
				lbl_NombreCliente.Text = "";
				btn_Guardar.Enabled = false;

				MessageBox.Show("Existe mas cliente con el mismo N° documento");

			}
			else
			if (dt.Tables[0].Rows.Count == 0)
			{
				lbl_NCliente.Text = "";
				lbl_NombreCliente.Text = "";
				btn_Guardar.Enabled = false;
				MessageBox.Show("Documento no existe");

			}

		}

		private void Cargar_Sucursal(string rut)
		{
			SqlCommand cmd = new SqlCommand();

			cmd.CommandText = "select id_sucursal, direccion + ','+co.comuna as Dato " +
				 "from [dbo].[tbl_sucursal] s " +
				 "inner join glo_region r on r.Id_region=s.Id_Region " +
				 "inner join glo_comuna co on co.id_comuna=s.Id_Comuna " +
				 "where run='" + rut + "'";
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);
			DataSet dtCopia;
			dtCopia = dt.Copy();
			cbx_SucActual.DisplayMember = dt.Tables[0].Columns[1].Caption.ToString();
			cbx_SucActual.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
			cbx_SucActual.DataSource = dt.Tables[0];

			cbx_SucCambio.DisplayMember = dtCopia.Tables[0].Columns[1].Caption.ToString();
			cbx_SucCambio.ValueMember = dtCopia.Tables[0].Columns[0].Caption.ToString();
			cbx_SucCambio.DataSource = dtCopia.Tables[0];
		}

		private void AsignarEvento()
		{
			txt_NDoc.KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
			txt_NDoc.KeyDown += new KeyEventHandler(ClaseEvento.Numero_KeyDown);
		}
		#endregion

		#region "button"

		private void btn_Cargar_Click(object sender, EventArgs e)
		{
			Cargar_Documento(Convert.ToInt64(  txt_NDoc.Text));
		}

		private void Btn_Guardar_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand();
			DataSet ds;
			string strParametro = String.Format("{0},{1},{2}", txt_NDoc.Text, cbx_SucActual.SelectedValue, cbx_SucCambio.SelectedValue);
			cmd.CommandText = "pa_ModificarSucursal_upd " + strParametro;
			cmd.CommandType = CommandType.Text;


			ds = Conectar.Listar(Clases.clsBD.BD, cmd);
			if (Convert.ToInt16(ds.Tables[0].Rows[0][0].ToString()) != 0)
			{
				MessageBox.Show("Error en actualizar la información");
			}

			else
				MessageBox.Show(ds.Tables[0].Rows[0][1].ToString());
		}

		private void Btn_Cerrar_Click(object sender, EventArgs e)
		 {
			 this.Close();
		 }

		private void Btn_filtro_Click(object sender, EventArgs e)
		{
			txt_NDoc.Clear();
			lbl_NombreCliente.Text = "";
			lbl_NCliente.Text = "";
			btn_Cargar.Enabled = true;
			txt_NDoc.Enabled = true;
			lbl_NCliente.Text = "";
			lbl_NombreCliente.Text = "";
			btn_Guardar.Enabled = false;
		}

		#endregion

		#region "combobox"


		#endregion

		#region "grilla"

		#endregion

	}
}
