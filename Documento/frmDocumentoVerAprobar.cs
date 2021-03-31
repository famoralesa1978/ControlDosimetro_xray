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
	public partial class frmDocumentoVerAprobar : Form
	{

		#region "Definicion variable"
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		Clases.ClassEvento ClaseEvento = new Clases.ClassEvento();
		classFuncionesBD.ClsFunciones ClasesFuncBD = new classFuncionesBD.ClsFunciones();
		classFuncionesBD.ClsFunciones ClaseFunciones = new classFuncionesBD.ClsFunciones();
		DataTable dt;
		int intContar = 0;
		bool Lectura;
		bool Nuevo;
		bool Modificacion;
		bool Eliminar;
		bool bolIdEstado;

		public int Id_Menu { get; private set; }

		public object[] Parametros
		{
			set
			{
				if (value != null)
				{
					Id_Menu = (int)value[0];
				}
			}
		}

		#endregion

		public frmDocumentoVerAprobar(bool Id_Estado)
		{
			InitializeComponent();
			AsignarEvento();

			bolIdEstado = Id_Estado;
			grdDatos.AutoGenerateColumns = false;

		}

		private void frmDocumentoVerAprobar_Load(object sender, EventArgs e)
		{
			AsignarPermiso(bolIdEstado);
			Cargar_Anno();
			CargarDt();
			Listar_Grilla();
			pnl_Progreso.Visible = false;
		}

		#region "Llamada de carga"

		private void Listar_Grilla()
		{

			if (rbtAprobado.Checked)
				dt.DefaultView.RowFilter = "aprobado=1";
			if (rbtSinAprobar.Checked)
				dt.DefaultView.RowFilter = "aprobado=0";
			grdDatos.DataSource = dt;
		}

		private void CargarDt()
		{
			SqlCommand cmd = new SqlCommand();
			DataSet ds;
			cmd.CommandText = "pa_ListadoPorDocumento " + cbx_Anno.SelectedValue;

			cmd.CommandType = CommandType.Text;
			ds = Conectar.Listar(Clases.clsBD.BD, cmd);
			dt = ds.Tables[0];

		}

		private void Cargar_Anno()
		{
			ClasesFuncBD.Cargar_Año(ref cbx_Anno, 3);
		}


		private void AsignarEvento()
		{
			ClaseEvento.AsignarNumero(ref txt_n_Cliente);
		}

		private void AsignarPermiso(bool Id_Estado)
		{
			ClaseFunciones.Cargar_Permiso(Clases.clsUsuario.Id_perfil, Id_Menu, ref Lectura, ref Nuevo, ref Modificacion, ref Eliminar);
			ColAprobado.Visible = Id_Estado && Modificacion;

			ColEliminar.Visible = Id_Estado && Eliminar;
			tsbAgregar.Visible = Nuevo;
			tsbGuardar.Visible = Nuevo || Modificacion;
		}

		#endregion

		#region "button"

		private void btn_Cerrar_Click_1(object sender, EventArgs e)
		{
			//  verificar_Grabado();
			this.Close();
		}

		private void btn_Guardar_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand();
			bool bolMarca;
			String strId;
			Cursor = Cursors.WaitCursor;
			pnl_Progreso.Visible = true;
			tsbGuardar.Enabled = false;
			pnl_Progreso.Refresh();
			pgb_Barra.Minimum = 0;
			pgb_Barra.Maximum = grdDatos.RowCount;
			StringBuilder strMarcado = new StringBuilder();
			StringBuilder strDesmarcado = new StringBuilder();

			foreach (DataRowView dv in ((DataTable)grdDatos.DataSource).DefaultView)
			{
				strId = dv["Id_Doc"].ToString();
				bolMarca = (bool)dv["Aprobado"];
				if (bolMarca)
				{
					strMarcado.AppendFormat(@"<a e=""{0}""/>", strId);

				}
				else
				{
					strDesmarcado.AppendFormat(@"<a e=""{0}""/>", strId);
				}
			}

			cmd.CommandText = "pa_DocumentoAprobarUpd '" + strMarcado + "','" + strDesmarcado + "'";
			cmd.CommandType = CommandType.Text;
			Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);
			Listar_Grilla();
			Cursor = Cursors.Default;
			MessageBox.Show("Informacion grabada");
			tsbGuardar.Enabled = true;
			pnl_Progreso.Visible = false;
		}

		private void btn_cargar_Click(object sender, EventArgs e)
		{
			CargarDt();
			Listar_Grilla();
		}

		private void btn_Cerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		#endregion

		#region "combobox"
	
		private void cbx_Anno_SelectedIndexChanged(object sender, EventArgs e)
		{
			CargarDt();
			Listar_Grilla();
		}

		#endregion

		#region "barra"

		private void tsbAgregar_Click(object sender, EventArgs e)
		{
			object[] objParams = { Id_Menu };
			frmingdocumentos frm = new frmingdocumentos();
			frm.Parametros = objParams;
			frm.ShowDialog();
		}

		#endregion

		#region "grilla"

		private void grdDatos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (grdDatos.IsCurrentCellDirty)
			{
				grdDatos.CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				int intFila = e.RowIndex;
				int id;
				DataTable dt = (DataTable)grdDatos.DataSource;
				DataRow currentRow = dt.Rows[intFila];
				id = (int)currentRow["Id_Doc"];
				if (e.ColumnIndex == ColNombreArchivo.Index)
				{

					Cursor = Cursors.WaitCursor;
					
					byte[] archivo = null;

					string strNombreArchivo = currentRow["NombreArchivo"].ToString();
					ClasesFuncBD.DescargarDocumento(id, ref archivo);
					Cursor = Cursors.Default;
					classFuncionesGenerales.ClsValidadores.Leer_Binario(archivo, strNombreArchivo);
				}
				else
				{
					if (e.ColumnIndex == ColEliminar.Index)
					{
						if(MessageBox.Show("¿Desea elimar el archivo?","Eliminar archivo adjunto",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK){
							SqlCommand cmd = new SqlCommand();
							cmd.CommandText = "pa_DocumentoDel " + id.ToString();

							cmd.CommandType = CommandType.Text;

							Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);

							CargarDt();
							Listar_Grilla();
						}
					}
				}

			}
		}


		#endregion

	}
}
