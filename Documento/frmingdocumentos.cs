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
		}


		private void frmingdocumentos_Load(object sender, EventArgs e)
		{
			
		}

		#endregion


		#region carga

		private void Cargar_Ddls(){
			Func.Cargar_TipoDocumento(ref cbxTipoDocumento);
			Func.Cargar_TipoPeriodo(ref cbx_TipoPeriodo);

		} 

		private void Cargar_Cliente(Int64 intCodCliente)
		{
			Func.Cargar_Cliente((int)cbx_id_periodo.SelectedValue, Convert.ToInt64( lbl_id_cliente.Text.ToString()), ref lbl_rut,ref lbl_RazonSocial, ref lbl_Direccion);

		}

		private void Cargar_Anno()
		{
			Func.Cargar_Año(ref cbx_anno, (int)cbx_TipoPeriodo.SelectedValue);

		}

		private void Cargar_Periodo()
		{
			Func.Cargar_Periodo(ref cbx_id_periodo, (int)cbx_TipoPeriodo.SelectedValue, (int)cbx_anno.SelectedValue);
		}

		private void HabilitarControles(bool bolHabilitar){
			btn_Cargar_cliente.Enabled = bolHabilitar;
			btnGrabarArchivo.Enabled = bolHabilitar &&  !String.IsNullOrEmpty( lbl_rut.Text.Trim());
			gpx_Asociar.Enabled = bolHabilitar && !String.IsNullOrEmpty(lbl_rut.Text.Trim());
		}

		#endregion

		private void btn_Cargar_cliente_Click(object sender, EventArgs e)
		{
			Cargar_Cliente(Convert.ToInt64(lbl_id_cliente.Text));
			HabilitarControles(cbx_id_periodo.Enabled);
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

		private void cbx_TipoPeriodo_SelectedIndexChanged(object sender, EventArgs e)
		{
			Cargar_Anno();
			cbx_anno.Enabled = cbx_anno.Items.Count == 0 ? false : true;
			cbx_id_periodo.Enabled = cbx_anno.Enabled;
			if (!cbx_anno.Enabled){
				cbx_id_periodo.DataSource = null;
			}
				

			HabilitarControles(cbx_id_periodo.Enabled);
		}

		private void cbx_anno_SelectedIndexChanged(object sender, EventArgs e)
		{
			Cargar_Periodo();
			cbx_id_periodo.Enabled = cbx_id_periodo.Items.Count == 0 ? false : true;
			HabilitarControles(cbx_id_periodo.Enabled);
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
