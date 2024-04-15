using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dllLibreriaMysql;
using System.Data.SqlClient;

namespace ControlDosimetro
{
	public partial class frmModificarPersonalMasivo : Form
	{

		#region "Definicion variable"
		clsConectorSqlServerV2 Conectar = new clsConectorSqlServerV2();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		Clases.ClassEvento clsEvento = new Clases.ClassEvento();
		classFuncionesBD.ClsFunciones ClaseFunciones = new classFuncionesBD.ClsFunciones();
		bool bolDesdeCodigo;
		bool bolInicializacion;
		private bool Lectura, Agregar, Modificar, Eliminar;
		DateTimePicker dateTimePicker1;
		DateTimePicker dtpFechaInicio;
		DateTimePicker dtpFechaTermino;
		DataSet dt;
		DataSet dtPersonal;
		public int intMenu;

		public bool bolGrabar;

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
			btnDescargarExcel.Enabled = false;
		}

		#region "Llamada de carga"

		private void AsignarPermiso()
		{
			Cursor = Cursors.WaitCursor;
			Conectar.PermisoFormulario(intMenu, ref Lectura, ref Agregar, ref Modificar, ref Eliminar);
			Cursor = Cursors.Default;

			tsbGuardar.Enabled = (Lectura == false && Modificar);
			tsbNuevo.Enabled = false;
			tsbEliminar.Enabled = false;
			grdDatos.ReadOnly = Lectura || !Modificar;
			grdDatos.DefaultCellStyle.BackColor = !Lectura && (Modificar) ? SystemColors.Window : ClaseGeneral.ColorCeldaBloqueado;
			//btnEliminar.Enabled = Lectura == false && Eliminar;
			Cursor = Cursors.Default;
		}
		private void Listar_Personal()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = String.Format("pa_ListarPersonal_sel");
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add("@IdCliente", SqlDbType.Int);
			cmd.Parameters["@IdCliente"].Value = txt_N_cliente.Text;
			cmd.Parameters.Add("@Rut", SqlDbType.VarChar, 11);
			cmd.Parameters["@Rut"].Value = txt_Rut.Text;
			dtPersonal = Conectar.Listar(Clases.clsBD.BD, cmd);
			if (dtPersonal != null)
				grdDatos.DataSource = dtPersonal.Tables[0].DefaultView;
			btnDescargarExcel.Enabled = true;

			chk_AsignarTLD.Checked = grpCambiarEstado.Enabled = dtPersonal != null && dtPersonal.Tables[0].Rows.Count > 0;
		}

		private void Cargar_Seccion()
		{

			dt = ClaseFunciones.Cargar_SeccionPorRunBuscar(Convert.ToInt16(txt_N_cliente.Text.ToString()), txt_Rut.Text);

			cbx_id_seccion.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
			cbx_id_seccion.ValueMember = dt.Tables[0].Columns[1].Caption.ToString();
			cbx_id_seccion.DataSource = dt.Tables[0];

		}
		private void Cargar_Direccion()
		{

			ClaseFunciones.Cargar_Sucursal(ref cbx_Direccin, txt_Rut.Text.ToString(), Convert.ToInt16(txt_N_cliente.Text.ToString()), 0);

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

		private void AsignarEvento()
		{
			clsEvento.AsignarRutSinGuion(ref txt_Rut);
			clsEvento.AsignarRutSinGuion(ref txt_RunPersonal);
			txt_Rut.EventoAsignarRut();
			txt_RunPersonal.EventoAsignarRut();
			txt_N_cliente.EventoAsignarNumero(9);
			txt_RazonSocial.EventoAsignarAvanzar();
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

		#endregion

		#region "button"       
		private void btnDescargarExcel_Click(object sender, EventArgs e)
		{
			//SqlCommand cmd = new SqlCommand();
			SqlCommand cmd = new SqlCommand();

			cmd.CommandText = "pa_ListarPersonal_selExcel " + txt_N_cliente.Text + ",'" + txt_Rut.Text + "' ";
			cmd.CommandType = CommandType.Text;

			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			if (dt.Tables[0].Rows.Count > 0)
			{
				frmreporte frm = new frmreporte(dt, dt, 10);
				frm.Show(this);

			}

		}

		private void btn_cargarCliente_Click(object sender, EventArgs e)
		{
			if (txt_N_cliente.DevuelveCadenaNulo() == null) return;

			Cursor = Cursors.WaitCursor;

			frmAyudaCliente frm = new frmAyudaCliente(txt_N_cliente.DevuelveEntero());

			if (frm.ShowDialog() == DialogResult.OK)
			{
				txt_RazonSocial.Text = txt_N_cliente.DevuelveCadenaNulo() != null ? Clases.ClsCliente.Nombres : "";
				txt_Rut.Text = txt_N_cliente.DevuelveCadenaNulo() != null ? Clases.ClsCliente.Rut : "";
				txt_N_cliente.Enabled = false;
				btn_cargarCliente.Enabled = false;
				tsbNuevo.Enabled = Lectura == false && Agregar;
				Cargar_Seccion();
				Cargar_CodServicio();
				Cargar_Direccion();
				picFiltrarpersonal_Click(null, null);
				grp_Grilla.Enabled = grpPersonal.Enabled = chk_AsignarTLD.Enabled = true;
				grpCambiarEstado.Enabled = true;
			}
			else
			{
				grp_Grilla.Enabled = grpPersonal.Enabled = chk_AsignarTLD.Enabled = false;
				txt_RazonSocial.Clear();
				txt_Rut.Clear();
				txt_N_cliente.Enabled = true;
				btn_cargarCliente.Enabled = true;
				grpCambiarEstado.Enabled = false;
				grdDatos.LimpiarDataGridView();

			}
			Cursor = Cursors.Default;

		}

		private void btn_Filtro_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			grp_Grilla.Enabled = grpPersonal.Enabled = chk_AsignarTLD.Enabled = false;
			txt_N_cliente.Enabled = true;
			txt_N_cliente.Clear();
			txt_Rut.Clear();
			txt_RazonSocial.Clear();
			bolDesdeCodigo = true;
			chk_AsignarTLD.Checked = false;
			tsbNuevo.Enabled = false;
			tsbGuardar.Enabled = false;
			tsbAsignarSeccion.Enabled = false;
			tsbAsignarSucursal.Enabled = false;
			grp_Grilla.Enabled = grpPersonal.Enabled = chk_AsignarTLD.Enabled = false;
			grdDatos.LimpiarDataGridView();
			//picFiltrarpersonal_Click(null, null);
			btnDescargarExcel.Enabled = false;
			btn_cargarCliente.Enabled = true;
			txt_N_cliente.Focus();

			Cursor = Cursors.Default;
		}

		private void picFiltrarpersonal_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			DataSet ds;
			int intEstado = rbtAmbos.Checked ? -1 : rbtActivo.Checked ? 1 : 0;
			int intIdDireccion = chkDireccion.Checked ? (int)cbx_Direccin.SelectedValue : 0;
			int intCliente = String.IsNullOrEmpty(txt_N_cliente.Text) ? 0 : Convert.ToInt16(txt_N_cliente.Text);
			if (chk_FecNac.Checked)
				ds = classFuncionesGenerales.Filtro.FiltroPersonal(intCliente, txt_NombrePersonal.Text, txt_RunPersonal.Text, "01/01/1900", intEstado, (int)cbx_id_seccion.SelectedValue, chkVerificarSinDireccion.Checked, intIdDireccion, txt_Rut.Text);
			else
				ds = classFuncionesGenerales.Filtro.FiltroPersonal(intCliente, txt_NombrePersonal.Text, txt_RunPersonal.Text, "", intEstado, (int)cbx_id_seccion.SelectedValue, chkVerificarSinDireccion.Checked, intIdDireccion, txt_Rut.Text);

			grdDatos.DataSource = ds.Tables[0];

			grp_Grilla.Text = "Listado personal   - Cantidad :" + ds.Tables[0].Rows.Count.ToString();
			tsbEliminar.Enabled = !Lectura && Eliminar && ds.Tables[0].Rows.Count>0;
			btnDescargarExcel.Enabled =  ds.Tables[0].Rows.Count > 0;
			Cursor = Cursors.Default;
		}
		private void btnCambiar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			grdDatos.FinalizaEdicion();
			grdDatos.Vista().Table.AsEnumerable().Where(s => (int)s[ColSeleccion.DataPropertyName.ToString()] == 1).ToList().
						ForEach(s => { s["Id_estado"] = (chkCambiarEstado.Checked ? 1 : 0); s["fecha_termino"] = (chkCambiarEstado.Checked ? "01/01/1900" : dtpCambioFecha.Value.ToString("dd/MM/yyyy")); }) ;
			Cursor = Cursors.Default;
		}
		#endregion

		#region ""checkBox"
		private void chk_AsignarTLD_CheckedChanged(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			grdDatos.FinalizaEdicion();
			grdDatos.Vista().Table.AsEnumerable().ToList().
						ForEach(s => { s["Id_CodServicio"] =99; });
			Cursor = Cursors.Default;
		}
		private void chkMarcar_CheckedChanged(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			grdDatos.Vista().Table.AsEnumerable().ToList().ForEach(s => s["Seleccionar"]=chkMarcar.Checked);

			Cursor = Cursors.Default;
		}

		#endregion

		#region "grilla"

		private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == colMod.Index)
			{
				frmPersonalMant frm = new frmPersonalMant(Convert.ToInt64(txt_N_cliente.Text), Convert.ToInt64(grdDatos.Rows[e.RowIndex].Cells[Id_Personal.Index].Value.ToString()), txt_Rut.Text);
				frm.ShowDialog(this);
				picFiltrarpersonal_Click(null, null);
			}
			else

			if (e.ColumnIndex == ColFechaNac.Index)
			{
				dateTimePicker1 = new DateTimePicker();
				dateTimePicker1.CustomFormat = "dd/MM/yyyy";
				dateTimePicker1.Format = DateTimePickerFormat.Custom;
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
				dateTimePicker1.Enabled = !grdDatos.ReadOnly;
				dateTimePicker1.CloseUp += new EventHandler(dateTimePicker1_CloseUp);

			}
			else
			if ((e.ColumnIndex == ColFechaTermino.Index && ColFechaTermino.ReadOnly == false))
			{
				dtpFechaTermino = new DateTimePicker();
				dtpFechaTermino.Format = DateTimePickerFormat.Custom;
				dtpFechaTermino.CustomFormat = "dd/MM/yyyy";

				//Agregamos el control de fecha dentro del DataGridView 
				dtpFechaTermino.Text = grdDatos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
				grdDatos.Controls.Add(dtpFechaTermino);

				// Hacemos que el control sea invisible (para que no moleste visualmente)
				dtpFechaTermino.Visible = false;

				// Establecemos el formato (depende de tu localización en tu PC)
				dtpFechaTermino.Format = DateTimePickerFormat.Short;  //Ej: 24/08/2016

				// Agregamos el evento para cuando seleccionemos una fecha
				dtpFechaTermino.TextChanged += new EventHandler(dtpFechaTermino_OnTextChange);

				// Lo hacemos visible
				dtpFechaTermino.Visible = true;

				// Creamos un rectángulo que representa el área visible de la celda
				Rectangle rectangle1 = grdDatos.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

				//Establecemos el tamaño del control DateTimePicker (que sería el tamaño total de la celda)
				dtpFechaTermino.Size = new Size(rectangle1.Width, rectangle1.Height);

				// Establecemos la ubicación del control
				dtpFechaTermino.Location = new Point(rectangle1.X, rectangle1.Y);
				dtpFechaTermino.Enabled = !grdDatos.ReadOnly;
				// Generamos el evento de cierre del control fecha
				dtpFechaTermino.CloseUp += new EventHandler(dtpFechaTermino_CloseUp);


			}
			else
			if (e.ColumnIndex == colFecha_inicio.Index)
			{
				dtpFechaInicio = new DateTimePicker();
				dtpFechaInicio.Format = DateTimePickerFormat.Custom;
				dtpFechaInicio.CustomFormat = "dd/MM/yyyy";

				//Agregamos el control de fecha dentro del DataGridView 
				dtpFechaInicio.Text = grdDatos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
				grdDatos.Controls.Add(dtpFechaInicio);

				// Hacemos que el control sea invisible (para que no moleste visualmente)
				dtpFechaInicio.Visible = false;

				// Establecemos el formato (depende de tu localización en tu PC)
				dtpFechaInicio.Format = DateTimePickerFormat.Short;  //Ej: 24/08/2016

				// Agregamos el evento para cuando seleccionemos una fecha
				dtpFechaInicio.TextChanged += new EventHandler(dtpFechaInicio_OnTextChange);

				// Lo hacemos visible
				dtpFechaInicio.Visible = true;

				// Creamos un rectángulo que representa el área visible de la celda
				Rectangle rectangle1 = grdDatos.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

				//Establecemos el tamaño del control DateTimePicker (que sería el tamaño total de la celda)
				dtpFechaInicio.Size = new Size(rectangle1.Width, rectangle1.Height);

				// Establecemos la ubicación del control
				dtpFechaInicio.Location = new Point(rectangle1.X, rectangle1.Y);
				dtpFechaInicio.Enabled = !grdDatos.ReadOnly;
				// Generamos el evento de cierre del control fecha
				dtpFechaInicio.CloseUp += new EventHandler(dtpFechaInicio_CloseUp);

			}
		}
		private void dtpFechaInicio_OnTextChange(object sender, EventArgs e)
		{
			//Asignamos a la celda el valor de la feha seleccionada
			grdDatos.CurrentCell.Value = dtpFechaInicio.Text.ToString().Replace("-", "/");
		}
		private void dtpFechaTermino_OnTextChange(object sender, EventArgs e)
		{
			//Asignamos a la celda el valor de la feha seleccionada
			grdDatos.CurrentCell.Value = dtpFechaTermino.Text.ToString().Replace("-", "/");
		}
		private void dateTimePicker1_OnTextChange(object sender, EventArgs e)
		{
			//Asignamos a la celda el valor de la feha seleccionada
			grdDatos.CurrentCell.Value = dateTimePicker1.Text.ToString().Replace("-", "/");
		}
		void dtpFechaInicio_CloseUp(object sender, EventArgs e)
		{
			//Volvemos a colocar en invisible el control
			dtpFechaInicio.Visible = false;
		}
		void dtpFechaTermino_CloseUp(object sender, EventArgs e)
		{
			//Volvemos a colocar en invisible el control
			dtpFechaTermino.Visible = false;
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
				if (e.ColumnIndex == ColServicio.Index || e.ColumnIndex == ColFechaNac.Index || e.ColumnIndex == ColFechaTermino.Index || e.ColumnIndex == ColEstado.Index)
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
					DataGridViewTextBoxCell TextBox = ((DataGridViewTextBoxCell)item.Cells[ColFechaTermino.Index]);
					if (Convert.ToInt32(dtrFila["Id_estado"].ToString()) != 1)
					{
						item.DefaultCellStyle.BackColor = Color.Red;
						TextBox.ReadOnly = false;
					}
					else
						TextBox.ReadOnly = true;
				}

			}
		}

		#endregion

		#region Barra
		private void tsbAsignarSucursal_Click(object sender, EventArgs e)
		{
			frmAsignarDireccionPersonal frm = new frmAsignarDireccionPersonal(Convert.ToInt32(txt_N_cliente.Text), txt_Rut.Text);
			frm.ShowDialog(this);
			picFiltrarpersonal_Click(null, null);
		}

		private void tsbEliminar_Click(object sender, EventArgs e)
		{
			grdDatos.FinalizaEdicion();
			DataTable dt = ((DataTable)grdDatos.DataSource);
			List<string> lista = dt.AsEnumerable().Where(s => (int)s["Seleccionar"]==1).Select(s => s[0].ToString()).ToList();
			if (lista.Count == 0)
				"Debe Seleccionar registro para eliminar".XMensajeError();
			else
			{
				if ("¿Esta seguro eliminar los registros?".XMensajeConfirmacionSiNo())
				{
					string strMensajeError = "";
					StringBuilder sbMensaje = new StringBuilder();
					for (int intLista = 0; intLista < lista.Count; intLista++)
					{
						SqlCommand cmd = new SqlCommand();
						cmd.CommandText = "pa_PersonalMasivo_Del";
						cmd.Parameters.Add("@Id_Personal", SqlDbType.Int);
						cmd.Parameters["@Id_Personal"].Value = lista[intLista];


						cmd.CommandType = CommandType.StoredProcedure;
						Conectar.AgregarModificarEliminar(ClaseGeneral.Conexion, cmd, ref strMensajeError);
						if (!string.IsNullOrWhiteSpace(strMensajeError))
						{
							Cursor = Cursors.Default;
							sbMensaje.AppendLine(string.Format("{0}{1}", lista[intLista], strMensajeError));
							ClaseGeneral.GuardarLOG(this.Name, "pa_PersonalMasivo_Del", "Grabar");
						}
					}
					if (!string.IsNullOrWhiteSpace(sbMensaje.ToString()))
						sbMensaje.ToString().XMensajeError();
					picFiltrarpersonal_Click(null, null);
				}
			}
		}

		private void tsbAsignarSeccion_Click(object sender, EventArgs e)
		{
			frmAsignarSeccionPersonal frm = new frmAsignarSeccionPersonal(Convert.ToInt32(txt_N_cliente.Text), txt_Rut.Text);
			frm.ShowDialog(this);
			picFiltrarpersonal_Click(null, null);
		}
		private void tsbGuardar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			DataTable dt = new DataTable();
			grdDatos.FinalizaEdicion();
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
						cmd.Parameters.Clear();
						cmd.Parameters.Add("@Id_CodServicio", SqlDbType.Int);
						cmd.Parameters["@Id_CodServicio"].Value = dr["Id_CodServicio"] == DBNull.Value ? null : dr["Id_CodServicio"];
						cmd.Parameters.Add("@Fecha_Nac", SqlDbType.VarChar, 10);
						cmd.Parameters["@Fecha_Nac"].Value = dr["Fecha_Nac"] == DBNull.Value ? "01/01/1900" : dr["Fecha_Nac"];
						cmd.Parameters.Add("@Id_Estado", SqlDbType.Int);
						cmd.Parameters["@Id_Estado"].Value = dr["Id_Estado"] == DBNull.Value ? null : dr["Id_estado"];
						cmd.Parameters.Add("@fecha_termino", SqlDbType.VarChar, 10);
						cmd.Parameters["@fecha_termino"].Value = dr["fecha_termino"] == DBNull.Value || (int)dr["Id_Estado"] == 1 ? "01/01/1900" : dr["fecha_termino"];
						cmd.Parameters.Add("@Fecha_inicio", SqlDbType.VarChar, 10);
						cmd.Parameters["@Fecha_inicio"].Value = dr["Fecha_inicio"] == DBNull.Value ? "01/01/1900" : dr["Fecha_inicio"];

						cmd.CommandText = "pa_PersonalMasivo_Upd";
						cmd.Parameters.Add("@Id_Personal", SqlDbType.Int);
						cmd.Parameters["@Id_Personal"].Value = dr["Id_Personal"];
						cmd.CommandType = CommandType.StoredProcedure;
						string strMensajeError = "";
						Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd, ref strMensajeError);
					}

				}
				picFiltrarpersonal_Click(null, null);
			}

			Cursor = Cursors.Default;

		}

		private void tsbPersonal_Click(object sender, EventArgs e)
		{
			frmPersonalMant frm = new frmPersonalMant(Convert.ToInt64(txt_N_cliente.Text), 0, txt_Rut.Text);
			frm.ShowDialog(this);
			Cursor = Cursors.WaitCursor;
			picFiltrarpersonal_Click(null, null);

			Cursor = Cursors.Default;
		}


		#endregion


	}
}
