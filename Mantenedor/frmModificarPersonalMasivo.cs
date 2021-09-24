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
	public partial class frmModificarPersonalMasivo : Form
	{

		#region "Definicion variable"
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		Clases.ClassEvento clsEvento = new Clases.ClassEvento();
		classFuncionesBD.ClsFunciones ClaseFunciones = new classFuncionesBD.ClsFunciones();
		bool bolDesdeCodigo;
		bool bolInicializacion;
		bool Lectura;
		bool Nuevo;
		bool Modificacion;
		bool Eliminar;
		DateTimePicker dateTimePicker1;
		DataSet dt;
		DataSet dtPersonal;
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

		public frmModificarPersonalMasivo()
		{
			InitializeComponent();

			AsignarEvento();
		}

		private void frmModificarPersonalMasivo_Load(object sender, EventArgs e)
		{
			bolDesdeCodigo = false;
			AsignarPermiso();
			
			grdDatos.AutoGenerateColumns = false;
		}

		#region "Llamada de carga"

		private void AsignarPermiso()
		{
			ClaseFunciones.Cargar_Permiso(Clases.clsUsuario.Id_perfil, Id_Menu, ref Lectura, ref Nuevo, ref Modificacion, ref Eliminar);
			tsbGuardar.Visible = Modificacion;
			tsbPersonal.Visible = Nuevo;
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
						"where  (id_cliente=" + intCliente.ToString() + ") or run ='" + txt_Rut.Text + "' " +
						" and id_estado= 1" +
						"order by id_cliente";
				txt_ref_cliente.Text = intCliente.ToString();
			}
			if (intCliente == 0)
				cmd.CommandText = "select id_cliente,run,razon_social,Direccion,telefono " +
						"from tbl_cliente " +
						"where run  ='" + txt_Rut.Text + "' " + " and id_estado=1"+
						"order by id_cliente";
			cmd.CommandType = CommandType.Text;

			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			if (dt.Tables[0].Rows.Count == 0)
			{
				txt_ref_cliente.Text = "";
				txt_Rut.Text = "";
				txt_RazonSocial.Text = "";
				grp_Grilla.Enabled = grpPersonal.Enabled = chk_AsignarTLD.Enabled = false;
				tsbPersonal.Visible= tsbGuardar.Visible = false;
				bolDesdeCodigo = false;
				chk_AsignarTLD.Checked = false;
				btn_cargarCliente.Enabled = true;
				
			}
			else
			{
				txt_ref_cliente.Text = dt.Tables[0].Rows[0]["id_cliente"].ToString();
				txt_Rut.Text = dt.Tables[0].Rows[0]["run"].ToString();
				txt_RazonSocial.Text = dt.Tables[0].Rows[0]["razon_social"].ToString();
				txt_ref_cliente.ReadOnly = true;
				txt_Rut.ReadOnly = true;
				grp_Grilla.Enabled = grpPersonal.Enabled = chk_AsignarTLD.Enabled = true;
				tsbGuardar.Visible = Modificacion;
				tsbPersonal.Visible = Nuevo;
				txt_RazonSocial.ReadOnly = true;
				btn_cargarCliente.Enabled = false;
				bolDesdeCodigo = true;
				Cargar_Seccion();
				Cargar_Estado();
				Cargar_CodServicio();
				Listar_Personal();
				picFiltrarpersonal_Click(null, null);
			}
		}

		private void Listar_Personal()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "pa_ListarPersonal_sel " + (String.IsNullOrEmpty( txt_ref_cliente.Text)?"0": txt_ref_cliente.Text) + "";
			cmd.CommandType = CommandType.Text;

			dtPersonal = Conectar.Listar(Clases.clsBD.BD, cmd);

			//dtPersonal.Tables[0].DefaultView.RowFilter = "Id_Estado=" + (chkActivo.Checked == true ? 1 : 0);
			grdDatos.DataSource = dtPersonal.Tables[0].DefaultView;

		}

		private void Cargar_Seccion()
		{

			dt = ClaseFunciones.Cargar_Seccion(Convert.ToInt16(txt_ref_cliente.Text.ToString()));

			DataGridViewComboBoxColumn comboboxColumn = grdDatos.Columns[ColSeccion.Index] as DataGridViewComboBoxColumn;
			comboboxColumn.DataSource = dt.Tables[0];
			comboboxColumn.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
			comboboxColumn.ValueMember = dt.Tables[0].Columns[1].Caption.ToString();

			cbx_id_seccion.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
			cbx_id_seccion.ValueMember = dt.Tables[0].Columns[1].Caption.ToString();
			cbx_id_seccion.DataSource = dt.Tables[0];

		}

		private void Cargar_CodServicio()
		{
			ComboBox cb = new ComboBox();
			ClaseComun.Listar_Parametro(Clases.clsBD.BD, ref cb, 16);

			DataGridViewComboBoxColumn comboboxColumn = grdDatos.Columns[ColServicio.Index] as DataGridViewComboBoxColumn;

			comboboxColumn.DataSource = cb.DataSource;
			comboboxColumn.DisplayMember = cb.DisplayMember;
			comboboxColumn.ValueMember = cb.ValueMember;

		}

		private void Cargar_Estado()
		{
			ComboBox cb = new ComboBox();
			ClaseFunciones.Cargar_Estado(ref cb);

			DataGridViewComboBoxColumn comboboxColumn = grdDatos.Columns[ColEstado.Index] as DataGridViewComboBoxColumn;

			comboboxColumn.DataSource = cb.DataSource;
			comboboxColumn.DisplayMember = cb.DisplayMember;
			comboboxColumn.ValueMember = cb.ValueMember;

		}

		private void AsignarEvento()
		{
			clsEvento.AsignarRutSinGuion(ref txt_Rut);
			clsEvento.AsignarRutSinGuion(ref txt_RunPersonal);
			clsEvento.AsignarNumero(ref txt_ref_cliente);
			clsEvento.AsignarKeyPress(ref txt_RazonSocial);
		}


#endregion

		#region "Textbox"

		private void txt_ref_cliente_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
				btn_cargarCliente_Click(null, null);
		}

		private void txt_RunPersonal_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
				picFiltrarpersonal_Click(null, null);
		}

		private void txt_NombrePersonal_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
				picFiltrarpersonal_Click(null, null);
		}

		private void txt_ref_cliente_KeyDown_1(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
				btn_cargarCliente_Click(null, null);
		}

		#endregion

		#region "button"       


		private void btn_cargarCliente_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			bolDesdeCodigo = true;
			if (txt_ref_cliente.Text == "")
				Listar_Cliente(0);
			else
				Listar_Cliente(Convert.ToInt64(txt_ref_cliente.Text.ToString()));

			if (txt_RazonSocial.Text == "")
			{

				tsbPersonal.Visible= tsbGuardar.Visible = false;
			}
				

			Cursor = Cursors.Default;

		}

		private void btn_Filtro_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			grp_Grilla.Enabled = grpPersonal.Enabled = chk_AsignarTLD.Enabled = false;
			txt_ref_cliente.ReadOnly = false;
			txt_ref_cliente.Text = "";
			txt_Rut.Text = "";
			txt_RazonSocial.Text = "";
			bolDesdeCodigo = true;
			chk_AsignarTLD.Checked = false;

			Listar_Cliente(0);
			Listar_Personal();
			picFiltrarpersonal_Click(null, null);
			btn_cargarCliente.Enabled = true;
			txt_ref_cliente.Focus();

			Cursor = Cursors.Default;
		}

		private void picFiltrarpersonal_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			DataSet ds;
			int intEstado = rbtAmbos.Checked?-1: rbtActivo.Checked?1 : 0;
			int intCliente = String.IsNullOrEmpty(txt_ref_cliente.Text) ? 0 : Convert.ToInt16(txt_ref_cliente.Text);
			if (chk_FecNac.Checked)
				ds=classFuncionesGenerales.Filtro.FiltroPersonal(intCliente, txt_NombrePersonal.Text, txt_RunPersonal.Text, "01/01/1900", intEstado,(int)cbx_id_seccion.SelectedValue);
			else
				ds = classFuncionesGenerales.Filtro.FiltroPersonal(intCliente, txt_NombrePersonal.Text, txt_RunPersonal.Text, "", intEstado, (int)cbx_id_seccion.SelectedValue);

			grdDatos.DataSource = ds.Tables[0];
			Cursor = Cursors.Default;
		}

		#endregion

		#region ""checkBox"

		private void chk_AsignarTLD_CheckedChanged(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			if(bolDesdeCodigo){
				foreach (DataGridViewRow dr in grdDatos.Rows)
				{
					if (Convert.ToInt16(dr.Cells[ColServicio.Index].Value) == 44)
						dr.Cells[ColServicio.Index].Value = 99;
				}

			}
		
			Cursor = Cursors.Default;
		}

		#endregion

		#region "grilla"

		private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == colMod.Index)
			{
				frmPersonalMant frm = new frmPersonalMant(Convert.ToInt64(txt_ref_cliente.Text), Convert.ToInt64(grdDatos.Rows[e.RowIndex].Cells[Id_Personal.Index].Value.ToString()));
				frm.ShowDialog(this);
			}else

			if (e.ColumnIndex == ColFechaNac.Index)
			{
				dateTimePicker1 = new DateTimePicker();
				//Agregamos el control de fecha dentro del DataGridView 
				dateTimePicker1.Text = grdDatos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
				grdDatos.Controls.Add(dateTimePicker1);

				// Hacemos que el control sea invisible (para que no moleste visualmente)
				dateTimePicker1.Visible = false;

				// Establecemos el formato (depende de tu localización en tu PC)
				dateTimePicker1.Format = DateTimePickerFormat.Short;  //Ej: 24/08/2016

				// Agregamos el evento para cuando seleccionemos una fecha
				dateTimePicker1.TextChanged += new EventHandler(dateTimePicker1_OnTextChange);

				// Lo hacemos visible
				dateTimePicker1.Visible = true;

				// Creamos un rectángulo que representa el área visible de la celda
				Rectangle rectangle1 = grdDatos.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

				//Establecemos el tamaño del control DateTimePicker (que sería el tamaño total de la celda)
				dateTimePicker1.Size = new Size(rectangle1.Width, rectangle1.Height);

				// Establecemos la ubicación del control
				dateTimePicker1.Location = new Point(rectangle1.X, rectangle1.Y);

				// Generamos el evento de cierre del control fecha
				dateTimePicker1.CloseUp += new EventHandler(dateTimePicker1_CloseUp);

			}
		}

		private void dateTimePicker1_OnTextChange(object sender, EventArgs e)
		{
			//Asignamos a la celda el valor de la feha seleccionada
			grdDatos.CurrentCell.Value = dateTimePicker1.Text.ToString();
		}

		void dateTimePicker1_CloseUp(object sender, EventArgs e)
		{
			//Volvemos a colocar en invisible el control
			dateTimePicker1.Visible = false;
		}

		private void grdDatos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			DataGridView dgv = sender as DataGridView;
			if (null == dgv || null == dgv.CurrentCell || !dgv.IsCurrentCellDirty)
			{
				return;
			}

			if ((dgv.CurrentCell is DataGridViewComboBoxCell || dgv.CurrentCell is DataGridViewCheckBoxCell))
			{
				grdDatos.CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		private void grdDatos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				if (e.ColumnIndex == ColServicio.Index || e.ColumnIndex == ColSeccion.Index || e.ColumnIndex == ColFechaNac.Index || e.ColumnIndex == ColEstado.Index)
				{
					DataTable dt = new DataTable();
					BindingSource bs = new BindingSource();
					bs.DataSource = grdDatos.DataSource;
					dt = (DataTable)(bs.DataSource);

					dt.Rows[e.RowIndex].AcceptChanges();
					dt.Rows[e.RowIndex].SetModified();
				}
				
			}
		}

		private void grdDatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			if (e.ListChangedType == ListChangedType.Reset)
			{
				foreach (DataGridViewRow item in grdDatos.Rows)
				{
					DataRow dtrFila = ((DataRowView)item.DataBoundItem).Row;
					if (Convert.ToInt32(dtrFila["Id_estado"].ToString()) == 0)
					{
						item.DefaultCellStyle.BackColor = Color.Red;
					}
				}

			}
		}

		#endregion

		#region Barra

		private void tsbGuardar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			DataTable dt = new DataTable();
			BindingSource bs = new BindingSource();
			bs.DataSource = grdDatos.DataSource;
			dt = ((DataTable)(bs.DataSource));

			if (dt.GetChanges(DataRowState.Modified) != null)
			{
				SqlCommand cmd = new SqlCommand();
				//foreach (DataRow dr in ((DataTable)grdDatos.DataSource).Rows)
				foreach (DataRow dr in dt.Rows)
				{
					//	if (dr["Id_CodServicio"] != dr["Id_CodServicio",DataRowVersion.Original])
					if (dr.RowState == DataRowState.Modified)
					{
						String strParametro = "";

						if (dr["Nombres"] == DBNull.Value)
							strParametro = "Null" + ",";
						else
							strParametro = dr["Nombres"].ToString() + ",";

						if (dr["Paterno"] == DBNull.Value)
							strParametro = "Null" + ",";
						else
							strParametro = dr["Paterno"].ToString() + ",";

						if (dr["Maternos"] == DBNull.Value)
							strParametro = "Null" + ",";
						else
							strParametro = dr["Maternos"].ToString() + ",";

						if (dr["Id_CodServicio"] == DBNull.Value)
							strParametro = "Null" + ",";
						else
							strParametro = dr["Id_CodServicio"].ToString() + ",";

						if (dr["Id_Seccion"] == DBNull.Value)
							strParametro = strParametro + "Null" + ",";
						else
							strParametro = strParametro + dr["Id_Seccion"].ToString() + ",";

						if (dr["Fecha_Nac"] == DBNull.Value)
							strParametro = strParametro + "'01/01/1900'";
						else
							strParametro = strParametro + "'" + dr["Fecha_Nac"].ToString() + "',";

						if (dr["Id_estado"] == DBNull.Value)
							strParametro = strParametro + "'1";
						else
							strParametro = strParametro + "" + dr["Id_estado"].ToString() + "";

						cmd.CommandText = "pa_PersonalMasivo_Upd " + dr["Id_Personal"] + "," + strParametro;
						cmd.CommandType = CommandType.Text;
						Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);
					}

				}
				picFiltrarpersonal_Click(null, null);
			}

			Cursor = Cursors.Default;

		}

		private void tsbPersonal_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			frmPersonalMant frm = new frmPersonalMant(Convert.ToInt64(txt_ref_cliente.Text), 0);
			frm.ShowDialog(this);
			Listar_Personal();

			Cursor = Cursors.Default;
		}

		#endregion

	}
}
