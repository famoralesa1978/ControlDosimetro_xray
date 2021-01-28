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
	public partial class frmingdocumentos : Form
	{
		#region "Definicion variable"

		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();
		classFuncionesBD.ClsFunciones Func = new classFuncionesBD.ClsFunciones();

		#endregion

		#region Inicio

		public frmingdocumentos()
		{
			InitializeComponent();
			Cargar_Ddls();
			//Cargar_Anno();
			//Cargar_Periodo();
		}


		private void frmingdocumentos_Load(object sender, EventArgs e)
		{
			Cargar_Ddls();
		}

		#endregion


		#region carga

		private void Cargar_Ddls(){
			Func.Cargar_TipoDocumento(ref cbxTipoDocumento);
			Func.Cargar_TipoPeriodo(ref cbx_TipoPeriodo);

		}

		#endregion

		private void btn_Cargar_cliente_Click(object sender, EventArgs e)
		{
			Cargar_Cliente(Convert.ToInt64(lbl_id_cliente.Text));

		}

		private void Cargar_Cliente(Int64 intCodCliente)
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "select run,Razon_Social,N_Cliente_Ref,region + ','+ comuna +','+Direccion as Direccion ,r.Id_Region,c.Id_Provincia,c.Id_Comuna,Telefono, Id_TipoFuente,Id_estado,Fechainicio " +
											"  FROM tbl_cliente c inner join [dbo].[glo_region] r on c.Id_Region=r.Id_Region inner join glo_comuna co on co.id_comuna=c.id_comuna" +
											" WHERE Id_cliente= " + intCodCliente.ToString();
			DataSet dt;

			dt = Conectar.Listar(Clases.clsBD.BD, cmd);
			if (dt.Tables[0].Rows.Count > 0)
			{
				lbl_id_cliente.Text = intCodCliente.ToString();
				lbl_rut.Text = dt.Tables[0].Rows[0]["run"].ToString();
				lbl_nombreCliente.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
				lbl_Direccion.Text = dt.Tables[0].Rows[0]["Direccion"].ToString();

				//btn_Cargar_cliente.Enabled = false;
				//lbl_id_cliente.Enabled = false;

				//cbx_anno.Enabled = false;
				//cbx_id_periodo.Enabled = false;

				// Cargar_Sucursal();

			}
			else
			{
				btn_Cargar_cliente.Enabled = true;

				lbl_id_cliente.Enabled = true;
				lbl_nombreCliente.Text = "";
				lbl_Direccion.Text = "";
				lbl_rut.Text = "";

				// Cargar_Sucursal();
				if (intCodCliente != 0)
					MessageBox.Show("El cliente no existe");

			}



			//
		}

		private void Cargar_Anno()
		{
			SqlCommand cmd = new SqlCommand();

			//	  SqlCommand cmd = new SqlCommand();

			cmd.CommandText = "SELECT distinct Anno FROM conf_periodo WHERE Id_TipoPeriodo=3";
			//cmd.CommandText = "SELECT Id_Periodo,Anno, Mes,Id_TipoPeriodo FROM conf_periodo WHERE Id_TipoPeriodo=3";
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			cbx_anno.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
			cbx_anno.DataSource = dt.Tables[0];

		}

		private void Cargar_Periodo()
		{
			SqlCommand cmd = new SqlCommand();

			//	  SqlCommand cmd = new SqlCommand();

			cmd.CommandText = "SELECT Id_Periodo,Mes, cast((mes/3) as varchar(10))+ '°T' FROM conf_periodo WHERE Id_TipoPeriodo=3 and Anno=" + cbx_anno.Text;
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			cbx_id_periodo.DisplayMember = dt.Tables[0].Columns[2].Caption.ToString();
			cbx_id_periodo.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
			cbx_id_periodo.DataSource = dt.Tables[0];

			//cbx_periodo.DisplayMember = dt.Tables[0].Columns[2].Caption.ToString();
			//cbx_periodo.DataSource = dt.Tables[0];

			//cbx_id_periodo.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
			//cbx_id_periodo.DataSource = dt.Tables[0];
		}

		private void btnGrabarArchivo_Click(object sender, EventArgs e)
		{
			GrabarArchivo();
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

		private void GrabarArchivo()
		{
			if (File.Exists(txtRutaArchivo.Text))
			{
				String nombrearchivo = Path.GetFileNameWithoutExtension(txtRutaArchivo.Text);
				String extension = Path.GetExtension(txtRutaArchivo.Text).Replace(".", "");


				byte[] buffer = File.ReadAllBytes(txtRutaArchivo.Text);

				SqlCommand sqlcmd = new SqlCommand();
				sqlcmd.CommandText = "" +

"   INSERT INTO ges_documentos ([Id_cliente],[Id_periodo],[Nombre],[Descripcion],[Extension],[Archivo],[Id_Tipo_Documento]) " +
// "   VALUES (Convert.ToInt32( lbl_id_cliente.Text), Convert.ToInt32(cbx_id_periodo.SelectedValue),Convert.ToInt32(cmbTipoDocumento.SelectedValue), txtDescripcionArchivo.Text.Trim(),extension, buffer,@Doc_Id_Tipo_Documento)  ";

"   VALUES (@Doc_Id_cliente,@Doc_Id_periodo,@Doc_Nombre,@Doc_Descripcion,@Doc_Extension,@Doc_Archivo,@Doc_Id_Tipo_Documento)  ";

				sqlcmd.CommandType = CommandType.Text;
				sqlcmd.Parameters.Add("@Doc_Id_Cliente", SqlDbType.Int).Value = Convert.ToInt16(lbl_id_cliente.Text);
				sqlcmd.Parameters.Add("@Doc_Id_Periodo", SqlDbType.Int).Value = Convert.ToInt16(cbx_id_periodo.SelectedValue);
				sqlcmd.Parameters.Add("@Doc_Id_Tipo_Documento", SqlDbType.Int).Value = Convert.ToInt32(cbxTipoDocumento.SelectedValue);
				sqlcmd.Parameters.Add("@Doc_Descripcion", SqlDbType.VarChar, 200).Value = txtDescripcionArchivo.Text.Trim();
				sqlcmd.Parameters.Add("@Doc_Extension", SqlDbType.VarChar, 200).Value = extension;
				sqlcmd.Parameters.Add("@Doc_Nombre", SqlDbType.VarChar, 200).Value = nombrearchivo;
				sqlcmd.Parameters.Add("@Doc_Archivo", SqlDbType.Image).Value = buffer;

				Conectar.AgregarModificarEliminar(Clases.clsBD.BD, sqlcmd);
				// sqlcmd.CommandText = "" + "VALUES (" + Convert.ToInt32(lbl_id_cliente.Text) +""+ ;   

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

	}
}
