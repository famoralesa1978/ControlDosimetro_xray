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

namespace ControlDosimetro
{
	public partial class frmMantenedorCliente : Form
	{
		#region "Definicion variable"

		TextBox txtColUsuario = new TextBox();
		TextBox txtColNombre = new TextBox();
		TextBox txtColNCliente = new TextBox();
		public bool bolFiltro;
		Button btnColBuscara = new Button();
		bool bolInicializacion;
		bool Lectura;
		bool Nuevo;
		bool Modificacion;
		bool Eliminar;


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

		enum ConfGrilla : int
		{
			Id_Usuario = 0,
			Rut = 1,
			Nombres = 2,
			Paterno = 3,
			Maternos = 4,
			Id_perfil = 5,
			Id_estado = 6,
			Usuario = 7,
			Contraseña = 8,
			Fecha_agregado = 9,
			Fecha_Modificacion = 10,

			//Id_Usuario],[Rut],[Nombres],[Paterno],[Maternos],u.[Id_perfil],u.[Id_estado],[Usuario],[Contraseña],[Fecha_agregado],[Fecha_Modificacion] ,u.id_estado 
		};

		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();
		BindingSource bs = new BindingSource();
		dllLibreriaMysql.clsUtiles clsUtiles1 = new dllLibreriaMysql.clsUtiles();
		classFuncionesBD.ClsFunciones ClaseFunciones = new classFuncionesBD.ClsFunciones();

		#endregion

		#region "Inicio"

		public frmMantenedorCliente()
		{
			InitializeComponent();

		}

		private void frmMantenedorCliente_Load(object sender, EventArgs e)
		{
		//	scPrincipal.Panel2Collapsed = true;
			AsignarPermiso();
			Cargar_Reporte();
			Cargar_Estado();
			AsignarEvento();
			Cargar_Perfil();
			//tsbGuardar.Enabled = false;
			dgvGrilla.AutoGenerateColumns = false;
			bolInicializacion = true;
			CargarGrilla();
		}

		#endregion

		#region "Llamado a carga"

		private void Cargar_Reporte()
		{
			ToolStripMenuItem tsiMenu;
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "pa_ListarReporte_Sel " + Id_Menu.ToString();
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);
			if (dt == null)
				tsdReporte.Visible = false;
			else
			{
				tsdReporte.Visible = dt.Tables[0].Rows.Count == 0 ? false : true;
				if (dt.Tables[0].Rows.Count > 0)
				{
					for (int intFila = 0; intFila <= dt.Tables[0].Rows.Count - 1; intFila++)
					{
						tsiMenu = new ToolStripMenuItem();
						tsiMenu.Text = dt.Tables[0].Rows[intFila]["Nombre"].ToString();
						tsiMenu.Name = dt.Tables[0].Rows[intFila]["nameMenu"].ToString();
						tsiMenu.Tag = dt.Tables[0].Rows[intFila]["N_Reporte"].ToString();
						tsiMenu.Click += new EventHandler(this.LLamadoReporte_Click);

						tsdReporte.DropDownItems.Add(tsiMenu);
					}
				}
			}

		}

		private void LLamadoReporte_Click(object sender, EventArgs e)
		{
			MDIPrincipal.LlamadaReporte(Convert.ToUInt16(((System.Windows.Forms.ToolStripItem)sender).Tag.ToString()));

		}



		private void Cargar_Estado()
		{
			ClaseComun.Listar_Estado(Clases.clsBD.BD, ref cbx_id_estadoBuscar, ref cbx_id_estadoBuscar);
			//ClaseComun.Listar_Estado(Clases.clsBD.BD, ref cbx_Id_estado, ref cbx_Id_estado);
		}

		private void AsignarPermiso()
		{
			ClaseFunciones.Cargar_Permiso(Clases.clsUsuario.Id_perfil, Id_Menu, ref Lectura, ref Nuevo, ref Modificacion, ref Eliminar);
			tsbAgregar.Visible = Nuevo;
		//	tsbGuardar.Visible = Nuevo || Modificacion;
		}

		private void Cargar_Perfil()
		{
			//Cursor = Cursors.WaitCursor;

			//SqlCommand cmd = new SqlCommand();
			//{

			//	cmd.CommandText = "select Id_perfil, Descripcion FROM tbl_perfil WHERE Id_estado=1 order by Descripcion";
			//	DataSet dt;
			//	dt = Conectar.Listar(Clases.clsBD.BD, cmd);


			//	cbx_Id_perfil.DisplayMember = dt.Tables[0].Columns[1].Caption.ToString();
			//	cbx_Id_perfil.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
			//	DataTable dtVista = dt.Tables[0];

			//	if (Clases.clsUsuario.Id_perfil != 1)
			//	{
			//		dtVista.DefaultView.RowFilter = "Id_perfil>1";
			//		cbx_Id_perfil.DataSource = dtVista;
			//	}
			//	else
			//		cbx_Id_perfil.DataSource = dt.Tables[0];

			//	Cursor = Cursors.Default;
			//}
		}

		private void AsignarEvento()
		{

			//cbx_Id_estado.KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);
			//cbx_Id_perfil.KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);

		}


		private void CargarGrilla()
		{

			SqlCommand cmd = new SqlCommand();

			{
				cmd.CommandText = "pa_Cliente_sel " + cbx_id_estadoBuscar.SelectedValue;
				cmd.CommandType = CommandType.Text;

				DataSet dt;
				dt = Conectar.Listar(Clases.clsBD.BD, cmd);

				bs.DataSource = dt.Tables[0];
				dgvGrilla.DataSource = bs;
				Filtro();
			}
		}
		#endregion

		#region "Procedimiento"

		private void LimpiarFormulario()
		{
			//txt_rut.Text = "";
			//txt_paterno.Text = "";
			//txt_Nombres.Text = "";
			//txt_Maternos.Text = "";
			//txt_rut.Enabled = true;
			//cbx_Id_estado.SelectedIndex = 0;
			//cbx_Id_perfil.SelectedIndex = 0;
			//// HabDesa_Controles(false);
			//btn_Guardar.Text = "Grabar";
			//this.Text = "Agregar Personal";
			////  lbl_Usuario.Text = Clases.clsUsuario.Usuario;
			//lbl_Fecha_agregado.Text = DateTime.Now.Date.ToString().Substring(1, 10);
			//lbl_Fecha_Modificacion.Text = DateTime.Now.Date.ToString().Substring(1, 10);
			//txt_Contraseña.Clear();
			//txt_Contraseña1.Clear();
			//cbx_Id_estado.SelectedIndex = 0;
			//txt_Usuario.Clear();
			//txt_rut.Focus();

			//txt_Contraseña1.Enabled = true;
			//lbl_Id_Usuario.Text = "N° usuario";
			//btn_Guardar.Enabled = Nuevo || Modificacion;
		//	tsbGuardar.Enabled = Nuevo || Modificacion;

			// cbx_id_estado.SelectedIndex = 0;           
		}

		private void Grabar()
		{
			//Boolean bolResult;
			//bolResult = false;
			//if (MessageBox.Show("Desea grabar la información", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
			//{
			//	if ((tssEstado.Text == "Nuevo") && (txt_id_tipo_doc.Text == "0"))
			//	{
			//		ClaseComun.Insertar(Clases.clsBD.BD, tbl_Usuario, ref bolResult);
			//		if (bolResult == true)
			//		{
			//			CargarGrilla();
			//			MessageBox.Show("Dato Guardado");
			//		}
			//	}
			//	else
			//	if (tssEstado.Text == "Modificar")
			//	{

			//		if (!String.IsNullOrEmpty(txt_rut.Text) && !String.IsNullOrEmpty(txt_Maternos.Text) && !String.IsNullOrEmpty(txt_paterno.Text) && !String.IsNullOrEmpty(txt_Nombres.Text) && !String.IsNullOrEmpty(txt_Usuario.Text))
			//		{

			//			ClaseComun.Modificar(Clases.clsBD.BD, tbl_Usuario, ref bolResult);
			//			if (bolResult == true)
			//			{
			//				CargarGrilla();
			//				MessageBox.Show("Dato modificado");
			//			}

			//		}
			//		else
			//		{
			//			MessageBox.Show("Completar todos los datos ingresar modificación");
			//		}
			//	}
			//}
		}

		private void LlamadoAModificar(int intFila)
		{
			BindingSource bs1 = new BindingSource();
			bs1 = (BindingSource)dgvGrilla.DataSource;

			if (intFila >= 0)
			{
				var currentRow = bs1.List[intFila];



				//btn_Guardar.Text = "Modificar";

				//txt_Contraseña.Enabled = false;
				//txt_Contraseña1.Enabled = false;

				//lbl_Id_Usuario.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Id_Usuario].ToString();
				//txt_Contraseña1.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Contraseña].ToString();
				//txt_Usuario.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Usuario].ToString();
				//txt_rut.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Rut].ToString();
				//txt_Nombres.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Nombres].ToString();
				//txt_paterno.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Paterno].ToString();
				//cbx_Id_estado.SelectedValue = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Id_estado].ToString();
				//txt_Maternos.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Maternos].ToString();
				//cbx_Id_perfil.SelectedValue = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Id_perfil].ToString();

				//txt_Contraseña.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Contraseña].ToString();
				//try
				//{
				//	txt_Contraseña1.Text = clsUtiles1.DecryptTripleDES(((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Contraseña].ToString());
				//}
				//catch (Exception)
				//{

				//	txt_Contraseña1.Text = clsUtiles1.GenerateHashMD5(((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Contraseña].ToString());
				//	txt_Contraseña.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Contraseña].ToString();
				//}

				//lbl_Fecha_Modificacion.Text = DateTime.Today.ToString().Substring(0, 9);
				//lbl_Fecha_agregado.Text = ((System.Data.DataRowView)currentRow).Row.ItemArray[(int)ConfGrilla.Fecha_agregado].ToString();

				//tssEstado.Text = "Modificar";
				//btn_Guardar.Enabled = Nuevo || Modificacion;
		//		tsbGuardar.Enabled = Nuevo || Modificacion;

			}
		}

		private void Txt_Contraseña1_TextChanged(object sender, EventArgs e)
		{
		//	txt_Contraseña.Text = clsUtiles1.GenerateHashMD5(txt_Contraseña1.Text);
		}

		#endregion

		#region "RUT"

		private void AsignarRut()
		{

			//SqlCommand cmd = new SqlCommand();
			////SqlCommand cmd = new SqlCommand();
			//DataSet dt;
			//string strname;
			//foreach (Control c in tbl_Usuario.Controls)
			//{
			//	//foreach (Control childc in c.Controls)
			//	//{
			//	if (c is TextBox)
			//	{
			//		strname = ((TextBox)c).Name;

			//		cmd.CommandText = "SELECT  requerido, validacion " +
			//														" FROM glo_configuracioncampo WHERE campo= '" + strname.Replace("txt_", "") + "'";

			//		dt = Conectar.Listar(Clases.clsBD.BD, cmd);
			//		if (dt.Tables[0].Rows.Count == 0)
			//			((TextBox)c).KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);
			//		else
			//		{
			//			if (dt.Tables[0].Rows[0]["validacion"].ToString() == "rut")
			//			{
			//				((TextBox)c).KeyPress += new KeyPressEventHandler(ClaseEvento.Rut_KeyPress);
			//				((TextBox)c).KeyDown += new KeyEventHandler(ClaseEvento.Rut_KeyDown);
			//				((TextBox)c).Validated += new EventHandler(ClaseEvento.validarut_Validated);
			//			}
			//			if (dt.Tables[0].Rows[0]["validacion"].ToString() == "numerico")
			//			{
			//				((TextBox)c).KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
			//				((TextBox)c).KeyDown += new KeyEventHandler(ClaseEvento.Numero_KeyDown);
			//			}
			//		}
			//	}
			//	if (c is ComboBox)
			//		((ComboBox)c).KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);
			//	if (c is DateTimePicker)
			//		((DateTimePicker)c).KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);
			//}
		}

		private void txt_rut_KeyUp(object sender, KeyEventArgs e)
		{
			//txt_rut.Text = classFuncionesGenerales.ClsValidadores.FormatearRut(txt_rut.Text);
			//txt_rut.SelectionStart = txt_rut.Text.Length;
			//txt_rut.SelectionLength = 0;
		}

		private void txt_rut_Leave(object sender, EventArgs e)
		{
			AsignarRut();
		}
		#endregion

		#region "Grilla"

		private void Filtro()
		{
			var bs = new BindingSource();
			{
				bs.DataSource = dgvGrilla.DataSource;
				string strFiltro = txtColUsuario.Text != "" ? ColUsuario.DataPropertyName + " like '%" + txtColUsuario.Text + "%'" : "";//
				strFiltro += strFiltro != "" && txtColNombre.Text != "" ? " and " : "";
				strFiltro += txtColNombre.Text != "" ? ColNombres.DataPropertyName + " like '%" + txtColNombre.Text + "%'" : "";
				strFiltro += txtColNCliente.Text != "" ? colId_cliente.DataPropertyName + "=" + txtColNCliente.Text + "" : "";

				bs.Filter = strFiltro;
				dgvGrilla.DataSource = bs;
			}
		}

		private void DgvGrilla_Paint(object sender, PaintEventArgs e)
		{
			if (bolInicializacion == true)
			{
				int columnIndex = 0;
				Point headerCellLocation = this.dgvGrilla.GetCellDisplayRectangle(columnIndex, -1, true).Location;
				txtColNCliente.Location = new Point(headerCellLocation.X, headerCellLocation.Y + 20);
				txtColNCliente.BackColor = Color.AliceBlue;
				txtColNCliente.Width = colId_cliente.Width - 2;
				txtColNCliente.TextAlign = HorizontalAlignment.Left;
				dgvGrilla.Controls.Add(txtColNCliente);

				columnIndex = 1;
				headerCellLocation = this.dgvGrilla.GetCellDisplayRectangle(columnIndex, -1, true).Location;
				txtColUsuario.Location = new Point(headerCellLocation.X, headerCellLocation.Y + 20);
				txtColUsuario.BackColor = Color.AliceBlue;
				txtColUsuario.Width = ColUsuario.Width - 2;
				txtColUsuario.TextAlign = HorizontalAlignment.Left;
				dgvGrilla.Controls.Add(txtColUsuario);

				columnIndex = 2;
				headerCellLocation = this.dgvGrilla.GetCellDisplayRectangle(columnIndex, -1, true).Location;
				txtColNombre.Location = new Point(headerCellLocation.X, headerCellLocation.Y + 20);
				txtColNombre.BackColor = Color.AliceBlue;
				txtColNombre.Width = ColNombres.Width - 2;
				txtColNombre.TextAlign = HorizontalAlignment.Left;
				dgvGrilla.Controls.Add(txtColNombre);

				columnIndex = -1;
				headerCellLocation = this.dgvGrilla.GetCellDisplayRectangle(columnIndex, -1, true).Location;
				btnColBuscara.Location = new Point(headerCellLocation.X, headerCellLocation.Y + 0);
				btnColBuscara.Image = ControlDosimetro.Properties.Resources.Buscar;

				btnColBuscara.FlatStyle = FlatStyle.Standard;
				btnColBuscara.Height = 41;
				btnColBuscara.Width = 41;
				btnColBuscara.Click += new EventHandler(BtnColBuscar_Click);

				dgvGrilla.Controls.Add(btnColBuscara);
			}
			bolInicializacion = false;
		}

		private void DgvGrilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int intFila = e.RowIndex;
			LlamadoAModificar(intFila);
		}

		private void DgvGrilla_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
		{
			txtColUsuario.Width = ColUsuario.Width - 4;
			txtColNombre.Width = ColNombres.Width - 4;
			txtColNCliente.Width = colId_cliente.Width - 4;
			int columnIndex = 0;
			Point headerCellLocation = this.dgvGrilla.GetCellDisplayRectangle(columnIndex, -1, true).Location;
			txtColNCliente.Location = new Point(headerCellLocation.X, headerCellLocation.Y + 20);

			columnIndex = 1;
			 headerCellLocation = this.dgvGrilla.GetCellDisplayRectangle(columnIndex, -1, true).Location;
			txtColUsuario.Location = new Point(headerCellLocation.X, headerCellLocation.Y + 20);

			columnIndex = 2;
			headerCellLocation = this.dgvGrilla.GetCellDisplayRectangle(columnIndex, -1, true).Location;
			txtColNombre.Location = new Point(headerCellLocation.X, headerCellLocation.Y + 20);
		}

		#endregion

		#region "Boton"
		private void BtnColBuscar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			Filtro();
			Cursor = Cursors.Default;
		}

		private void Btn_Limpiar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			LimpiarFormulario();
			//tssEstado.Text = "Nuevo";
			//txt_id_tipo_doc.Text = "0";

			Cursor = Cursors.Default;
		}

		private void Btn_Buscar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			CargarGrilla();

			Cursor = Cursors.Default;
		}

		private void Btn_Guardar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			Grabar();

			//tssEstado.Text = "Nuevo";
			//txt_id_tipo_doc.Text = "0";

			Cursor = Cursors.Default;
		}

		private void TsmEliminar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			/*
			if (MessageBox.Show("¿Desea Eliminar la información?", "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
			{                
					DataTable dt = (DataTable)dgvGrilla.DataSource;
					DataRow currentRow = dt.Rows[dgvGrilla.CurrentRow.Index];
					SqlCommand cmd = new SqlCommand();
					cmd.CommandText = "pa_TipoDocumento_del " + currentRow[ConfGrilla.id.ToString()].ToString();

					cmd.CommandType = CommandType.Text;

					DataSet dt1;
					dt1 = Conectar.Listar(Clases.clsBD.BD,cmd);

					MessageBox.Show(dt1.Tables[0].Rows[0][1].ToString());
					if (dt1.Tables[0].Rows[0][0].ToString() == "0")
							CargarGrilla();
			}
			*/
			Cursor = Cursors.Default;
		}

		private void TsmActualizar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			LlamadoAModificar(dgvGrilla.CurrentRow.Index);

			Cursor = Cursors.Default;
		}

		#endregion

		#region "Barra"

		private void TsbGuardar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			Grabar();

			Cursor = Cursors.Default;
		}
		private void TsbAgregar_Click(object sender, EventArgs e)
		{
		//	Cursor = Cursors.WaitCursor;

		//	if (scPrincipal.Panel2Collapsed == true)
		//		scPrincipal.Panel2Collapsed = false;

		//	if (scPrincipal.Panel2Collapsed == false)
		//	{
		//		tssEstado.Text = "Nuevo";
		////		tsbGuardar.Enabled = true;
		//		LimpiarFormulario();
		//		txt_id_tipo_doc.Text = "0";

		//		btn_Guardar.Text = "Grabar";
		//	}
		//	else
		//	{
		//		tssEstado.Text = "";
		//		txt_id_tipo_doc.Text = "";
		//	}

		//	Cursor = Cursors.Default;
		}

		#endregion


	}
}
