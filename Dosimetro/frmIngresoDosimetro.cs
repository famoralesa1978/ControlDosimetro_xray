﻿using dllConectorMysql;
using dllLibreriaEvento;
using dllLibreriaMysql;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ControlDosimetro
{
	public partial class frmIngresoDosimetro : Form
	{

		#region "Definicion variable"
		private bool bolInicio = false;
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();
		WorkbookPart wbPart = null;
		SpreadsheetDocument document = null;
		SpreadsheetDocument documentInforme = null;
		//	SpreadsheetDocument document2 = null;
		object missing = System.Reflection.Missing.Value;
		//     object strcampoMarcador;
		const string documentRelationshipType = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument";
		const string headerContentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.header+xml";
		const string footerContentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.footer+xml";
		string strDireccion;
		string strServicio;
		string strRegion;
		public string Id_Menu { get; private set; }
		private bool Inicializar = true;
		DataTable dtPeriodo;
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
		classFuncionesBD.ClsFunciones ClaseFunciones = new classFuncionesBD.ClsFunciones();

		#endregion

		public frmIngresoDosimetro()
		{
			InitializeComponent();
			AsignarEvento();
			grdDatos.AutoGenerateColumns = false;


		}

		private void frmIngresoDosimetro_Load(object sender, EventArgs e)
		{
			SqlCommand cmdcombo = new SqlCommand();
			//SqlCommand cmdcombo = new SqlCommand();
			DataSet dtcombo;
			cmdcombo.CommandText = "select 0 as Id_DetParametro, 'Seleccione' as Glosa, 0 as orden union all " +
				"SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=2 order by orden ";
			cmdcombo.CommandType = CommandType.Text;
			dtcombo = Conectar.Listar(ClaseGeneral.Conexion, cmdcombo);



			btnAgregarRef.Visible = btn_Guardar.Visible = false;

			pnl_Progreso.Visible = false;
			Cargar_Reporte();
			//	Cargar_Anno();
		}

		#region "Llamada de carga"

		private void Cargar_Cliente()
		{


			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "select run,Razon_Social,N_Cliente_Ref, Direccion as Direccion ,r.Id_Region,c.Id_Provincia,c.Id_Comuna,Telefono, Id_TipoFuente,Id_estado,Fechainicio,Servicio,r.region,co.Comuna " +
											"  FROM tbl_cliente c inner join [dbo].[glo_region] r on c.Id_Region=r.Id_Region inner join glo_comuna co on co.id_comuna=c.id_comuna" +
											" WHERE Id_cliente= " + lbl_id_cliente.Text.ToString() + " and run ='" + lbl_rut_cliente.Text + "'";//comuna +','+ region
			DataSet dt;

			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);
			if (dt.Tables[0].Rows.Count > 0)
			{
				strDireccion = dt.Tables[0].Rows[0]["Direccion"].ToString();
				strServicio = dt.Tables[0].Rows[0]["Servicio"].ToString();
				strRegion = dt.Tables[0].Rows[0]["region"].ToString();
			}

		}
		private void Cargar_Anno()
		{
			SqlCommand cmd = new SqlCommand();

			//  SqlCommand cmd = new SqlCommand();

			cmd.CommandText = "SELECT distinct Anno FROM conf_periodo WHERE Id_TipoPeriodo=3";
			//cmd.CommandText = "SELECT Id_Periodo,Anno, Mes,Id_TipoPeriodo FROM conf_periodo WHERE Id_TipoPeriodo=3";
			DataSet dt;
			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

			cbx_anno.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
			cbx_anno.DataSource = dt.Tables[0];

		}

		private void Cargar_Periodo()
		{
			DataTable dtPeriodoCopia = dtPeriodo.Copy();
			dtPeriodoCopia.DefaultView.RowFilter = String.Format("anno={0}", cbx_anno.SelectedValue);

			cbx_id_periodo.DataSource = dtPeriodoCopia.DefaultView.ToTable();
		}

		private void Cargar_Sucursal()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "select id_sucursal, direccion + ','+co.comuna as Dato,co.comuna, direccion" +
					"from [dbo].[tbl_sucursal] s " +
					"inner join glo_region r on r.Id_region=s.Id_Region " +
					"inner join glo_comuna co on co.id_comuna=s.Id_Comuna " +
					"where run='" + lbl_rut_cliente.Text + "'  and id_cliente= " + lbl_id_cliente.Text + " and s.Estado=1";
			DataSet dt;
			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

			cbx_Sucursal.DisplayMember = dt.Tables[0].Columns[1].Caption.ToString();
			cbx_Sucursal.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
			cbx_Sucursal.DataSource = dt.Tables[0];

		}

		private void Cargar_Reporte()
		{
			ToolStripMenuItem tsiMenu;
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "pa_ListarReporte_Sel " + Id_Menu.ToString();
			DataSet dt;
			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);
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

		private void AsignarEvento()
		{
			//		this.txtRut.KeyPress += new KeyPressEventHandler(ClaseEvento.Rut_KeyPress);
			//	txtRut.KeyDown += new KeyEventHandler(ClaseEvento.Rut_KeyDown);
			this.txtDesde.KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
			txtDesde.KeyDown += new KeyEventHandler(ClaseEvento.Numero_KeyDown);
			lbl_id_cliente.KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
			lbl_id_cliente.KeyDown += new KeyEventHandler(ClaseEvento.Numero_KeyDown);
		}

		Int64 DevolverNDosimetro(Int64 intDosimetro, DataTable dt)
		{
			bool bolResul = false;

			while (!bolResul)
			{
				dt.DefaultView.RowFilter = "n_dosimetro=" + intDosimetro.ToString();
				bolResul = dt.DefaultView.Count > 0 ? false : true;
				intDosimetro = dt.DefaultView.Count > 0 ? intDosimetro + 1 : intDosimetro;
			}


			return intDosimetro;
		}


		#endregion

		#region "button"
		private void tsbAsignar_Click(object sender, EventArgs e)
		{
			if (lbl_id_cliente.DevuelveEnteroNulo() == null) return;
			frmAsignarSeccionDireccion frm = new frmAsignarSeccionDireccion(Convert.ToInt32(lbl_id_cliente.Text), lbl_rut_cliente.Text);
			frm.ShowDialog(this);
		}
		private void tsbAsignarSucursal_Click(object sender, EventArgs e)
		{
			frmAsignarDireccionPersonal frm = new frmAsignarDireccionPersonal(Convert.ToInt32(lbl_id_cliente.Text), lbl_rut_cliente.Text);
			frm.ShowDialog(this);
		}

		private void tsbAsignarSeccion_Click(object sender, EventArgs e)
		{
			frmAsignarSeccionPersonal frm = new frmAsignarSeccionPersonal(Convert.ToInt32(lbl_id_cliente.Text), lbl_rut_cliente.Text);
			frm.ShowDialog(this);
		}
		private void btnResfrescar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			Inicializar = false;
			//pa_ConsultaFilmicoIngresado_Sel
			//@id_periodo int,
		 //@id_cliente int,
		 //@id_Sucursal int,
		 //@Rut  varchar(15)
			Cursor = Cursors.Default;
		}

		private void btn_Guardar_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand();
			//	  SqlCommand cmd = new SqlCommand();
			SqlCommand cmdpersonal = new SqlCommand();
			//  SqlCommand cmdpersonal = new SqlCommand();
			SqlCommand cmdperiodo = new SqlCommand();
			//  SqlCommand cmdperiodo = new SqlCommand();

			// dtcombo = Conectar.Listar(ClaseGeneral.Conexion,cmdcombo);            
			btnAgregarRef.Enabled = btn_Guardar.Enabled = false;


			//   //**************carga periodo
			DataSet dtPeriodo;
			// SqlCommand cmdPeriodo = new SqlCommand();
			SqlCommand cmdPeriodo = new SqlCommand();

			cmdPeriodo.CommandText = "SELECT fecha_inicio,fecha_termino " +
													 " FROM conf_periodo " +
													 //"where mes =3 and anno=" + cbx_anno.Text;  
													 "WHERE  Id_Periodo= " + cbx_id_periodo.SelectedValue;
			cmdPeriodo.CommandType = CommandType.Text;
			dtPeriodo = Conectar.Listar(ClaseGeneral.Conexion, cmdPeriodo);
			string strfecha_inicio = "From " + dtPeriodo.Tables[0].Rows[0]["fecha_inicio"].ToString().Substring(0, 6) + dtPeriodo.Tables[0].Rows[0]["fecha_inicio"].ToString().Substring(8, 2);
			strfecha_inicio = strfecha_inicio + " to " + dtPeriodo.Tables[0].Rows[0]["fecha_termino"].ToString().Substring(0, 6) + dtPeriodo.Tables[0].Rows[0]["fecha_termino"].ToString().Substring(8, 2); ;

			string strTri = cbx_id_periodo.Text.ToString().Substring(0, 1) + "er Trim " + cbx_anno.Text;
			//  From 01/01/19 to 31/03/19
			//*****************
			DataGridViewCheckBoxCell checkGenerar;
			DataGridViewCheckBoxCell checkCell;
			//DataGridViewTextBoxCell txtvalor;
			DataGridViewTextBoxCell txtndocumento;
			DataGridViewTextBoxCell txtnpelicula;
			DataGridViewTextBoxCell txtid_estadodosimetro;
			//    DataGridViewTextBoxCell N_Cliente;
			DataGridViewTextBoxCell Rut;
			DataGridViewTextBoxCell Paterno;
			DataGridViewTextBoxCell Nombres;
			DataGridViewTextBoxCell Maternos;
			DataGridViewTextBoxCell id_sucursal;
			DataGridViewTextBoxCell id_dosimetro;
			DataGridViewTextBoxCell Id_Personal;

			//*******************
			//     string strArchivo = "";// dtformato.Tables[0].Rows[0]["Glosa"].ToString() + "Plantillaword.docx";
			//     int i;                
			string fmt = "00000000";
			String strError = "";
			String strCorrecto = "";
			for (int idatos = 0; idatos <= grdDatos.Rows.Count - 1; idatos++)
			{
				checkGenerar = (DataGridViewCheckBoxCell)grdDatos.Rows[idatos].Cells["Generar"];
				checkCell = (DataGridViewCheckBoxCell)grdDatos.Rows[idatos].Cells["chkGenerado"];
				txtndocumento = (DataGridViewTextBoxCell)grdDatos.Rows[idatos].Cells["NDocumento"];
				txtnpelicula = (DataGridViewTextBoxCell)grdDatos.Rows[idatos].Cells["N_pelicula"];
				txtid_estadodosimetro = (DataGridViewTextBoxCell)grdDatos.Rows[idatos].Cells["id_estadodosimetro"];
				Rut = (DataGridViewTextBoxCell)grdDatos.Rows[idatos].Cells["Rut"];
				id_dosimetro = (DataGridViewTextBoxCell)grdDatos.Rows[idatos].Cells["id_dosimetro"];
				Paterno = (DataGridViewTextBoxCell)grdDatos.Rows[idatos].Cells["Paterno"];
				Maternos = (DataGridViewTextBoxCell)grdDatos.Rows[idatos].Cells["Maternos"];
				Nombres = (DataGridViewTextBoxCell)grdDatos.Rows[idatos].Cells["Nombres"];
				id_sucursal = (DataGridViewTextBoxCell)grdDatos.Rows[idatos].Cells["id_sucursal"];
				Id_Personal = (DataGridViewTextBoxCell)grdDatos.Rows[idatos].Cells["Id_Personal"];
				if ((checkGenerar.Value.ToString() == "1") && (checkCell.Value.ToString() == "0") && (txtid_estadodosimetro.Value.ToString() == "-1"))
				{
					if (Convert.ToInt64(txtnpelicula.Value.ToString()) > 0)
					{
						cmd.CommandText = "pa_DosimetroTLD_ins " +
									 Id_Personal.Value.ToString() + "," + // @Id_Personal int,
									lbl_id_cliente.Text.ToString() + "," +//@Id_cliente int,
																												//id_sucursal.Value.ToString() + "," + //@Id_sucursal int,
									id_sucursal + "," + //@Id_sucursal int,
									cbx_id_periodo.SelectedValue + "," +//@id_periodo int,
									txtndocumento.Value.ToString() + "," +//@N_Documento int,
									txtnpelicula.Value.ToString() + ",-1,'" +//@n_dosimetro int,
									Clases.clsUsuario.Usuario + "',";
						cmd.CommandType = CommandType.Text;
						DataSet ds = Conectar.Listar(ClaseGeneral.Conexion, cmd);

						if (Convert.ToInt16(ds.Tables[0].Rows[0]["Valor"].ToString()) == -1)//error
							strError = strError + "," + txtnpelicula.Value.ToString();
						else
							strCorrecto = strCorrecto + "," + txtnpelicula.Value.ToString();

					}
				}
				if ((checkGenerar.Value.ToString() == "1") && (checkCell.Value.ToString() == "0") && (txtid_estadodosimetro.Value.ToString() != "-1"))
				{
					cmd.CommandText = "pa_DosimetroTLD_upd " +
								Id_Personal.Value.ToString() + "," + // @Id_Personal int,
								lbl_id_cliente.Text.ToString() + "," +//@Id_cliente int,
								id_sucursal + "," + //@Id_sucursal int,
								cbx_id_periodo.SelectedValue + "," +//@id_periodo int,
								txtndocumento.Value.ToString() + "," +//@N_Documento int,
								txtnpelicula.Value.ToString() + ",-1,'" +//@n_dosimetro int,
								Clases.clsUsuario.Usuario + "',";
					//@id_estadodosimetro int
					cmd.CommandType = CommandType.Text;
					Conectar.AgregarModificarEliminar(ClaseGeneral.Conexion, cmd);
				}

			}
			string strMensaje = String.Format("Los TLD fueron generado con exito: {0} {1}", strCorrecto, String.IsNullOrEmpty(strError)?"": " y con errores : " + strError);
			MessageBox.Show(strMensaje);
			btn_Guardar.Enabled = true;
		}

		private void btn_filtro_Click_1(object sender, EventArgs e)
		{
			cbx_anno.Enabled = true;
			cbx_id_periodo.Enabled = true;
			groupBox2.Text = "Listado";
			lbl_id_cliente.Text = "-1";
			lbl_rut_cliente.Text = "";
			lbl_nombreCliente.Text = "";
			lbl_id_cliente.Enabled = true;

			lbl_id_cliente.Text = "-1";
			lbl_id_cliente.Focus();

			btn_Cargar_cliente_Click(null, null);
			btnResfrescar_Click(null, null);
			lbl_id_cliente.Text = "";
			cbx_anno.Enabled = true;
			cbx_id_periodo.Enabled = true;
			btn_Cargar_cliente.Enabled = true;
			Inicializar = true;
		}

		private void btn_Cerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_Corregir_Click(object sender, EventArgs e)
		{


			SqlCommand cmd2 = new SqlCommand();
			//	  SqlCommand cmd = new SqlCommand();
			SqlCommand cmdpersonal = new SqlCommand();
			//  SqlCommand cmdpersonal = new SqlCommand();
			SqlCommand cmdperiodo = new SqlCommand();
			//  SqlCommand cmdperiodo = new SqlCommand();

			// dtcombo = Conectar.Listar(ClaseGeneral.Conexion,cmdcombo);
			DataGridViewCheckBoxCell checkGenerar;
			DataGridViewCheckBoxCell checkCell;
			//DataGridViewTextBoxCell txtvalor;
			DataGridViewTextBoxCell txtndocumento;
			DataGridViewTextBoxCell txtnpelicula;
			DataGridViewTextBoxCell txtid_estadodosimetro;
			//     DataGridViewComboBoxCell cbxEstado;
			string strn_cliente;
			string strid_personal;
			//   string strid_dosimetro;
			btn_Corregir.Enabled = false;

			pnl_Progreso.Visible = true;
			pgb_Barra.Minimum = 0;
			pgb_Barra.Maximum = grdDatos.RowCount;
			pnl_Progreso.Refresh();
			Int64 intN_Dos = 0;
			SqlCommand cmd = new SqlCommand();
			//   cmd.CommandText = "SELECT isnull(max([n_dosimetro]),0)n_dosimetro   FROM[dbo].[ges_dosimetro_estado_TLD]";
			cmd.CommandText = "SELECT [n_dosimetro]  FROM[dbo].[ges_dosimetro_estado_TLD] where n_dosimetro>=" + txtDesde.Text;
			cmd.CommandType = CommandType.Text;
			DataSet dt;
			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);
			DataTable dtNTld = dt.Tables[0];

			intN_Dos = Int64.Parse(txtDesde.Text);

			cmd.CommandText = "SELECT [N_Documento]   FROM[dbo].[ges_dosimetro_estado_TLD] where id_periodo= " + cbx_id_periodo.SelectedValue +
												" and Id_cliente=" + lbl_id_cliente.Text + " union all " +
												"SELECT isnull(max([N_Documento]),0)n_dosimetro   FROM[dbo].[ges_dosimetro_estado_TLD] where " +
												"  Id_cliente<>" + lbl_id_cliente.Text;
			cmd.CommandType = CommandType.Text;

			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);
			int intN_Doc;
			if (dt.Tables[0].Rows.Count > 0)
				intN_Doc = 1 + Int16.Parse(dt.Tables[0].Rows[0]["N_Documento"].ToString());
			else
				intN_Doc = 1;

			//N_Documento
			for (int i = 0; i <= grdDatos.RowCount - 1; i++)
			{
				pgb_Barra.Value = i + 1;
				pgb_Barra.Refresh();
				checkGenerar = (DataGridViewCheckBoxCell)grdDatos.Rows[i].Cells["Generar"];
				checkCell = (DataGridViewCheckBoxCell)grdDatos.Rows[i].Cells["chkGenerado"];
				txtndocumento = (DataGridViewTextBoxCell)grdDatos.Rows[i].Cells["NDocumento"];
				txtnpelicula = (DataGridViewTextBoxCell)grdDatos.Rows[i].Cells["N_pelicula"];
				txtid_estadodosimetro = (DataGridViewTextBoxCell)grdDatos.Rows[i].Cells["id_estadodosimetro"];

				strn_cliente = grdDatos.Rows[i].Cells["N_Cliente"].Value.ToString();
				strid_personal = grdDatos.Rows[i].Cells["id_personal"].Value.ToString();


				if ((checkGenerar.Value.ToString() == "1") && (checkCell.Value.ToString() == "0") && (txtid_estadodosimetro.Value.ToString() == "-1"))
				{
					intN_Dos = DevolverNDosimetro(intN_Dos, dtNTld);

					txtndocumento.Value = intN_Doc.ToString();
					txtnpelicula.Value = intN_Dos.ToString();
					intN_Dos = intN_Dos + 1;

				}
			}
			MessageBox.Show("Informacion esta listo para generar el documento.");

			btn_Corregir.Enabled = true;
			pnl_Progreso.Visible = false;
		}

		public static void InsertWorksheet(string docName, int intCantidadHoja, string strFormato, string NombreHoja)
		{
			classFuncionesGenerales.ExcelNpoin ExcelNpoin = new classFuncionesGenerales.ExcelNpoin();
			string strNombreHoja = String.Format("{0}{1}", NombreHoja, intCantidadHoja);
			ExcelNpoin.CopiarHoja(docName, 0, strNombreHoja);
		}
		public static void BorrarWorksheet(string docName, int intHoja=0)
		{
			classFuncionesGenerales.ExcelNpoin ExcelNpoin = new classFuncionesGenerales.ExcelNpoin();
			ExcelNpoin.EliminarHoja(docName);
		}

		private void btn_Excel_Click(object sender, EventArgs e)
		{
			//btn_Guardar_Click(null, null);
			//bool bolArchivoGenerado = true;

   //   //cbx_Sucursal

   //   DataTable dt = ((DataTable)cbx_Sucursal.DataSource).Copy();

   //   dt.DefaultView.RowFilter = String.Format("Id_sucursal={0}", cbx_Sucursal.SelectedValue);

   //   String strComuna = dt.DefaultView.ToTable().Rows[0]["Comuna"].ToString();

   //   Cursor = Cursors.WaitCursor;//FORMULARIO DESPACHO_Laboratorio
			//														//FormularioLaboratorio
			//string targetPathFormatoCodigoBarra = "C:\\BaseTLD\\formato\\" + "FormatoTLD.xlsx";
			//string targetPathFormatoInfome = "C:\\BaseTLD\\formato\\" + "FORMULARIO DESPACHO.xlsx";
			//string targetPathFormatoFomratoLaboratorio= "C:\\BaseTLD\\formato\\" + "FORMULARIO DESPACHO_Laboratorio.xlsx";
			//grdDatos.Sort(grdDatos.Columns["N_pelicula"], ListSortDirection.Ascending);

			//string targetPathConf = "C:\\BaseTLD\\Cliente";
			//string targetPathCodigoBarra = "C:\\BaseTLD\\Cliente";
			//string targetPathFormatoFormulario = "C:\\BaseTLD\\Cliente";
			//string targetPathLaboratorio = "C:\\BaseTLD\\Cliente";
			//if (!System.IO.Directory.Exists(targetPathConf))
			//{
			//	System.IO.Directory.CreateDirectory(targetPathConf);
			//}

			//targetPathConf = "C:\\BaseTLD\\Cliente\\Cliente" + lbl_id_cliente.Text;
			//if (!System.IO.Directory.Exists(targetPathConf))
			//{
			//	System.IO.Directory.CreateDirectory(targetPathConf);
			//}
			//targetPathConf = "C:\\BaseTLD\\Cliente\\Cliente" + lbl_id_cliente.Text;
			//if (!System.IO.Directory.Exists(targetPathConf))
			//{
			//	System.IO.Directory.CreateDirectory(targetPathConf);
			//}

			//string strDirCliente = @targetPathConf;

			//targetPathCodigoBarra = "C:\\BaseTLD\\Cliente\\Cliente" + lbl_id_cliente.Text + "\\CodigoBarra";
			//if (!System.IO.Directory.Exists(targetPathCodigoBarra))
			//{
			//	System.IO.Directory.CreateDirectory(targetPathCodigoBarra);
			//}

			//targetPathFormatoFormulario = "C:\\BaseTLD\\Cliente\\Cliente" + lbl_id_cliente.Text + "\\Formulario";
			//if (!System.IO.Directory.Exists(targetPathFormatoFormulario))
			//{
			//	System.IO.Directory.CreateDirectory(targetPathFormatoFormulario);
			//}

			//targetPathLaboratorio = "C:\\BaseTLD\\Cliente\\Cliente" + lbl_id_cliente.Text + "\\Laboratorio";
			//if (!System.IO.Directory.Exists(targetPathLaboratorio))
			//{
			//	System.IO.Directory.CreateDirectory(targetPathLaboratorio);
			//}

			//DataSet dtPeriodo;
			//SqlCommand cmdPeriodo = new SqlCommand();

			//cmdPeriodo.CommandText = "SELECT fecha_inicio,fecha_termino, " +
			//											"substring([fecha_inicio],1,2)+' de '+ dbo.getmonth(cast(substring( [fecha_inicio],4,2)as int))+ ' de '+ substring([fecha_inicio],7,4) as Finicio," +
			//											"substring([fecha_termino],1,2)+' de '+dbo.getmonth(cast(substring( [fecha_termino],4,2)as int))+ ' de '+ substring([fecha_termino],7,4) as FTermino" +
			//										 " FROM conf_periodo " +
			//										 //"where mes =3 and anno=" + cbx_anno.Text;  
			//										 "WHERE  Id_Periodo= " + cbx_id_periodo.SelectedValue;
			//cmdPeriodo.CommandType = CommandType.Text;
			//dtPeriodo = Conectar.Listar(ClaseGeneral.Conexion, cmdPeriodo);
			//string strfecha_inicio = "From " + dtPeriodo.Tables[0].Rows[0]["fecha_inicio"].ToString().Substring(0, 6) + dtPeriodo.Tables[0].Rows[0]["fecha_inicio"].ToString().Substring(8, 2);
			//strfecha_inicio = strfecha_inicio + " to " + dtPeriodo.Tables[0].Rows[0]["fecha_termino"].ToString().Substring(0, 6) + dtPeriodo.Tables[0].Rows[0]["fecha_termino"].ToString().Substring(8, 2);
			//Cargar_Cliente();
			//string strfecha_Per = dtPeriodo.Tables[0].Rows[0]["Finicio"].ToString() + " al " + dtPeriodo.Tables[0].Rows[0]["FTermino"].ToString();

			//string strfecha_Fin = dtPeriodo.Tables[0].Rows[0]["FTermino"].ToString();
			//string strSigla = (cbx_id_periodo.Text.ToString().Substring(0, 1) == "1") ? "er Trim " : (cbx_id_periodo.Text.ToString().Substring(0, 1) == "2") ? "do Trim " : (cbx_id_periodo.Text.ToString().Substring(0, 1) == "3") ? "er Trim " : (cbx_id_periodo.Text.ToString().Substring(0, 1) == "4") ? "to Trim " : "";
			//string strTri = cbx_id_periodo.Text.ToString().Substring(0, 1) + strSigla + cbx_anno.Text;
			////  From 01/01/19 to 31/03/19
			////*****************
			//DataGridViewCheckBoxCell checkGenerar;
			//DataGridViewCheckBoxCell checkCell;
			////DataGridViewTextBoxCell txtvalor;
			//DataGridViewTextBoxCell txtndocumento;
			//DataGridViewTextBoxCell txtnpelicula;
			//DataGridViewTextBoxCell txtid_estadodosimetro;
			////    DataGridViewTextBoxCell N_Cliente;
			//DataGridViewTextBoxCell Rut;
			//DataGridViewTextBoxCell Paterno;
			//DataGridViewTextBoxCell Nombres;
			//DataGridViewTextBoxCell Maternos;
			//DataGridViewTextBoxCell id_sucursal;
			//DataGridViewTextBoxCell id_dosimetro;
			//DataGridViewTextBoxCell Id_Personal;

			////*******************
			////     string strArchivo = "";// dtformato.Tables[0].Rows[0]["Glosa"].ToString() + "Plantillaword.docx";
			////     int i;
			//int intExcel = 1;
			//String strFecha = DateTime.Now.ToString("dd-MM-yyyy HHmmss");
			//String strPath = targetPathConf + "\\ET_Cliente" + lbl_id_cliente.Text + "_" + cbx_id_seccion.Text + "_" + cbx_anno.Text.ToString() + "_" + cbx_id_periodo.Text.ToString().Substring(0, 1) + "Tri.xlsx";
			//String strPathRespaldo = targetPathConf + "\\ET_Cliente" + lbl_id_cliente.Text + "_" + cbx_id_seccion.Text + "_" + cbx_anno.Text.ToString() + "_" + cbx_id_periodo.Text.ToString().Substring(0, 1) + "Tri" + strFecha + ".xlsx";

			//string strNombreArchivoCodigo = String.Format(targetPathFormatoFormulario + "\\Formulario Cliente{0}{1}{2}{3}{4}Tri.xlsx",
			//																																						lbl_id_cliente.Text + "_",
			//																																						cbx_Sucursal.Text + "_",
			//																																						cbx_anno.Text.ToString() + "_",
			//																																						cbx_id_periodo.Text.ToString().Substring(0, 1)
			//																																				);
			//string strNombreArchivoCodigoRespaldo = String.Format(targetPathFormatoFormulario + "\\Formulario Cliente{0}{1}{2}{3}{4}{5}Tri.xlsx",
			//																																						lbl_id_cliente.Text + "_",
			//																																						cbx_Sucursal.Text + "_",
			//																																						cbx_anno.Text.ToString() + "_",
			//																																						cbx_id_periodo.Text.ToString().Substring(0, 1),
			//																																						strFecha
			//																																				);
			//string strNombreArchivoLabotatorio = String.Format(targetPathLaboratorio + "\\Formulario Laboratorio{0}{1}{2}{3}Tri.xlsx",
			//																																						lbl_id_cliente.Text + "_",
			//																																					//	cbx_Sucursal.Text + "_",
			//																																						cbx_anno.Text.ToString() + "_",
			//																																						cbx_id_periodo.Text.ToString().Substring(0, 1)
			//																																				);
			//string strNombreArchivoLabotatorioRespaldo = String.Format(targetPathLaboratorio + "\\Formulario Laboratorio{0}{1}{2}{3}{4}Tri.xlsx",
			//																																						lbl_id_cliente.Text + "_",
			//																																					//	cbx_Sucursal.Text + "_",
			//																																						cbx_anno.Text.ToString() + "_",
			//																																						cbx_id_periodo.Text.ToString().Substring(0, 1),
			//																																						strFecha
			//																																				);

			//string strNombreArchivoCodigoBarra = targetPathCodigoBarra + String.Format("\\ET_Cliente{0}_{1}_{2}_{3}Tri.xlsx", lbl_id_cliente.Text, cbx_id_seccion.Text, cbx_anno.Text.ToString(), cbx_id_periodo.Text.ToString().Substring(0, 1));
			//string strNombreArchivoCodigoBarraRespaldo = targetPathCodigoBarra + String.Format("\\ET_Cliente{0}_{1}_{2}_{3}_{4}Tri.xlsx", lbl_id_cliente.Text, cbx_id_seccion.Text, cbx_anno.Text.ToString(), cbx_id_periodo.Text.ToString().Substring(0, 1), strFecha);

			////Crea el excel para imrpimir el laboratorio
			//if (File.Exists(strNombreArchivoLabotatorio))
			//{
			//	File.Copy(strNombreArchivoLabotatorio, strNombreArchivoLabotatorioRespaldo, true);
			//	File.Delete(strNombreArchivoLabotatorio);
			//}
			//File.Copy(targetPathFormatoFomratoLaboratorio, strNombreArchivoLabotatorio, true);

			////Crea el excel para imrpimir el codigo de barra
			//if (File.Exists(strNombreArchivoCodigoBarra))
			//{
			//	File.Copy(strNombreArchivoCodigoBarra, strNombreArchivoCodigoBarraRespaldo, true);
			//	File.Delete(strNombreArchivoCodigoBarra);
			//}
			//File.Copy(targetPathFormatoCodigoBarra, strNombreArchivoCodigoBarra, true);


			////Crea el excel para imrpimir el cliente
			//if (File.Exists(strNombreArchivoCodigo))
			//{
			//	File.Copy(strNombreArchivoCodigo, strNombreArchivoCodigoRespaldo, true);
			//	File.Delete(strNombreArchivoCodigo);
			//}
			//File.Copy(targetPathFormatoInfome, strNombreArchivoCodigo, true);


			//int intFila = 2;
			//int intNumRegistro = 1;
			//int intHojaExcel = 20;

			//String strTitulo = String.Format("Dosimetria Personal TLD {0} Trimestre {1}",
			//										cbx_id_periodo.Text.Substring(0,1).ToString()=="1"?"Primer": cbx_id_periodo.Text.Substring(0, 1).ToString() == "2" ? "Segundo": cbx_id_periodo.Text.Substring(0, 1).ToString() == "3" ? "Tercer":"Cuarto", 
			//										cbx_anno.Text);
			//string strpathcopiarInforme = "";// targetPathFormatoFormulario + "\\Formulario Cliente" + lbl_id_cliente.Text + "_" + cbx_id_seccion.Text + "_" + cbx_anno.Text.ToString() + "_" + cbx_id_periodo.Text.ToString().Substring(0, 1) + "Tri_" + intExcel.ToString() + ".xlsx";
			//string strUsados = "Estos dosimetros deben ser usados entre el " + strfecha_Per;// + " al " + strfecha_Fin;
			//string fmt = "00000000";

			//strpathcopiarInforme = strNombreArchivoCodigo;

			//int intcantidadHoja = (grdDatos.Rows.Count / 14) + ((grdDatos.Rows.Count % 14) == 0 ? 0 : 1);
			//string strNombreHoja = "Registro";
			//for (int intnumHoja = 1; intnumHoja <= intcantidadHoja; intnumHoja++)
			//{

			//	InsertWorksheet(strNombreArchivoCodigo, intnumHoja, targetPathFormatoInfome, strNombreHoja);
			//	InsertWorksheet(strNombreArchivoLabotatorio, intnumHoja, targetPathFormatoFomratoLaboratorio, strNombreHoja);
			//}
			
			//for (int idatos = 0; idatos <= grdDatos.Rows.Count - 1; idatos++)
			//{
			//	try
			//	{
			//		checkGenerar = (DataGridViewCheckBoxCell)grdDatos.Rows[idatos].Cells["Generar"];
			//		checkCell = (DataGridViewCheckBoxCell)grdDatos.Rows[idatos].Cells["chkGenerado"];
			//		txtndocumento = (DataGridViewTextBoxCell)grdDatos.Rows[idatos].Cells["NDocumento"];
			//		txtnpelicula = (DataGridViewTextBoxCell)grdDatos.Rows[idatos].Cells["N_pelicula"];
			//		txtid_estadodosimetro = (DataGridViewTextBoxCell)grdDatos.Rows[idatos].Cells["id_estadodosimetro"];
			//		Rut = (DataGridViewTextBoxCell)grdDatos.Rows[idatos].Cells["Rut"];
			//		id_dosimetro = (DataGridViewTextBoxCell)grdDatos.Rows[idatos].Cells["id_dosimetro"];
			//		Paterno = (DataGridViewTextBoxCell)grdDatos.Rows[idatos].Cells["Paterno"];
			//		Maternos = (DataGridViewTextBoxCell)grdDatos.Rows[idatos].Cells["Maternos"];
			//		Nombres = (DataGridViewTextBoxCell)grdDatos.Rows[idatos].Cells["Nombres"];
			//		id_sucursal = (DataGridViewTextBoxCell)grdDatos.Rows[idatos].Cells["id_sucursal"];
			//		Id_Personal = (DataGridViewTextBoxCell)grdDatos.Rows[idatos].Cells["Id_Personal"];
			//		strDireccion = cbx_Sucursal.Text.ToString().ToUpper();
			//		//	if ((checkCell.Value.ToString() == "1"))//(checkGenerar.Value.ToString() == "1") &&&& (txtid_estadodosimetro.Value.ToString() == "-1")
			//		//	{

			//		if(int.Parse(txtnpelicula.Value.ToString()) !=0)
			//		{
			//			if (intHojaExcel == 34)
			//			{
			//				intHojaExcel = 20;
			//				intExcel = intExcel + 1;
			//				intNumRegistro = intNumRegistro + 1;
			//			}
			//			string wsName = String.Format("Registro{0}", intNumRegistro);
			//			string wsNameCodigoBarra = String.Format("Sheet1");
			//			//INform para imprimir el codigo barra
			//			document = SpreadsheetDocument.Open(strNombreArchivoCodigoBarra, true);
			//			wbPart = document.WorkbookPart;
			//			UpdateValue(wsNameCodigoBarra, "A" + (intFila).ToString(), int.Parse(txtnpelicula.Value.ToString()).ToString(fmt), 0, true);
			//			UpdateValue(wsNameCodigoBarra, "B" + (intFila).ToString(), Paterno.Value.ToString().ToUpper(), 0, true);
			//			UpdateValue(wsNameCodigoBarra, "C" + (intFila).ToString(), Maternos.Value.ToString().ToUpper(), 0, true);
			//			UpdateValue(wsNameCodigoBarra, "D" + (intFila).ToString(), Nombres.Value.ToString().ToUpper(), 0, true);// Nombres.Value.ToString().Substring(0, 1).ToUpper() + Nombres.Value.ToString().Substring(1, Nombres.Value.ToString().Length - 1).ToLower(), 0, true);
			//			UpdateValue(wsNameCodigoBarra, "E" + (intFila).ToString(), Rut.Value.ToString().ToUpperInvariant(), 0, true);
			//			UpdateValue(wsNameCodigoBarra, "F" + (intFila).ToString(), strTri, 0, true);
			//			UpdateValue(wsNameCodigoBarra, "G" + (intFila).ToString(), strfecha_inicio, 0, true);
			//			document.Close();

			//			//Genera informe para el cliente
			//			document = SpreadsheetDocument.Open(strpathcopiarInforme, true);
			//			wbPart = document.WorkbookPart;

			//			UpdateValue(wsName, "B" + (intHojaExcel).ToString(), int.Parse(txtnpelicula.Value.ToString()).ToString(fmt), 0, true);
			//			UpdateValue(wsName, "C" + (intHojaExcel).ToString(), Paterno.Value.ToString().ToUpper(), 0, true);
			//			UpdateValue(wsName, "D" + (intHojaExcel).ToString(), Maternos.Value.ToString().ToUpper(), 0, true);
			//			UpdateValue(wsName, "E" + (intHojaExcel).ToString(), Nombres.Value.ToString().ToUpper(), 0, true);
			//			UpdateValue(wsName, "F" + (intHojaExcel).ToString(), Rut.Value.ToString().ToUpperInvariant(), 0, true);
			//			//UpdateValue(wsName, "D2" , strfecha_Per, 0, true);
			//			//UpdateValue(wsName, "D18", strfecha_Fin, 0, true);
			//			UpdateValue(wsName, "B9", strTitulo, 0, true);
			//			UpdateValue(wsName, "B16", strUsados, 0, true);
			//			UpdateValue(wsName, "C12", strDireccion, 0, true);
			//			UpdateValue(wsName, "C14", lbl_rut_cliente.Text.ToUpper(), 0, true);
			//			UpdateValue(wsName, "F14", cbx_id_seccion.Text.ToUpper(), 0, true);
			//			//	UpdateValue(wsName, "M4", strRegion, 0, true);
			//			UpdateValue(wsName, "C13", strComuna.ToUpper() + ", " + strRegion.ToUpper(), 0, true);
			//			UpdateValue(wsName, "C11", lbl_nombreCliente.Text.ToUpper(), 0, true);
			//			UpdateValue(wsName, "G11", lbl_id_cliente.Text, 0, true);
			//			DataRow dtr = ((DataRowView)cbx_id_periodo.SelectedItem).Row;
			//			UpdateValue(wsName, "B43", dtr["Glosa"].ToString(), 0, true);
			//			document.Close();

			//			//Genera informe para el laboratorio
			//			document = SpreadsheetDocument.Open(strNombreArchivoLabotatorio, true);
			//			wbPart = document.WorkbookPart;

			//			UpdateValue(wsName, "B" + (intHojaExcel).ToString(), int.Parse(txtnpelicula.Value.ToString()).ToString(fmt), 0, true);
			//			UpdateValue(wsName, "C" + (intHojaExcel).ToString(), Paterno.Value.ToString().ToUpper(), 0, true);
			//			UpdateValue(wsName, "D" + (intHojaExcel).ToString(), Maternos.Value.ToString().ToUpper(), 0, true);
			//			UpdateValue(wsName, "E" + (intHojaExcel).ToString(), Nombres.Value.ToString().ToUpper(), 0, true);
			//			UpdateValue(wsName, "F" + (intHojaExcel).ToString(), Rut.Value.ToString().ToUpperInvariant(), 0, true);
			//			//UpdateValue(wsName, "D2" , strfecha_Per, 0, true);
			//			//UpdateValue(wsName, "D18", strfecha_Fin, 0, true);
			//			UpdateValue(wsName, "B9", strTitulo, 0, true);
			//			UpdateValue(wsName, "B16", strUsados, 0, true);
			//			UpdateValue(wsName, "C12", strDireccion, 0, true);
			//			UpdateValue(wsName, "C14", lbl_rut_cliente.Text.ToUpper(), 0, true);
			//			UpdateValue(wsName, "F14", cbx_id_seccion.Text.ToUpper(), 0, true);
			//			//	UpdateValue(wsName, "M4", strRegion, 0, true);
			//			UpdateValue(wsName, "C13", strComuna.ToUpper() + ", " + strRegion.ToUpper(), 0, true);
			//			UpdateValue(wsName, "C11", lbl_nombreCliente.Text.ToUpper(), 0, true);
			//			UpdateValue(wsName, "G11", lbl_id_cliente.Text, 0, true);
			//			document.Close();

			//			intFila = intFila + 1;
			//			intHojaExcel = intHojaExcel + 1;
			//			bolArchivoGenerado = true;
			//		}


				
			//	}
			//	catch (Exception ex)
			//	{
			//		classFuncionesGenerales.mensajes.MensajeError(ex.Message);
			//		bolArchivoGenerado = false;
			//		break;
			//	}

			//}
			//if(bolArchivoGenerado == true)
			//{
			//	BorrarWorksheet(strNombreArchivoCodigo);
			//	BorrarWorksheet(strNombreArchivoLabotatorio);
			//	Process.Start("explorer.exe", strDirCliente);
			//	MessageBox.Show("El archivo fue generado");
			//}
			//Cursor = Cursors.Default;
		}

		private void btn_Sucursal_Click(object sender, EventArgs e)
		{
			frmDireccion frm = new frmDireccion();
			frm.intMenu = (int)MDIPrincipal.MENU.MantSucursal;
			frm.ShowDialog(this);
		}

		private void btn_Cargar_cliente_Click(object sender, EventArgs e)
		{
			
			if(String.IsNullOrWhiteSpace(lbl_id_cliente.Text))
			{
				classFuncionesGenerales.mensajes.MensajeError("Ingrese le número de cliente");
				return;
			}
			Cursor = Cursors.WaitCursor;
			Inicializar = false;

			frmAyudaCliente frm = new frmAyudaCliente(Convert.ToInt64(lbl_id_cliente.Text));

			if (frm.ShowDialog() == DialogResult.OK)
			{
				lbl_nombreCliente.Text = (Convert.ToInt64(lbl_id_cliente.Text) > 1) ? Clases.ClsCliente.Nombres : "";
				lbl_rut_cliente.Text = (Convert.ToInt64(lbl_id_cliente.Text) > 1) ? Clases.ClsCliente.Rut : "";

				SqlCommand cmd = new SqlCommand
				{
					CommandText = String.Format("CargarClientePorRun '{0}',{1}", lbl_rut_cliente.Text, lbl_id_cliente.Text)
				};
				DataSet dt;
				dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

				if (dt != null)
				{
					dtPeriodo = new DataTable();
					//if (dt.Tables[0].Rows.Count > 0)
					//{
					dtPeriodo = dt.Tables[3];
					cbx_anno.DataSource = dt.Tables[1];

					if ((Convert.ToInt64(lbl_id_cliente.Text) < 1))
						cbx_id_periodo.DataSource = dtPeriodo;

					DataTable dtSeccion = dt.Tables[2].Copy();
					dtSeccion.DefaultView.RowFilter = "Id_estado=1";

					cbx_Sucursal.DataSource = dtSeccion.DefaultView.Table;

					btn_Cargar_cliente.Enabled = false;
					//}
				}

			}
			Cursor = Cursors.Default;
		}
		private void btn_Eliminar_Click(object sender, EventArgs e)
		{
			pnl_Progreso.Visible = true;
			pgb_Barra.Minimum = 0;
			pgb_Barra.Maximum = grdDatos.RowCount;
			pnl_Progreso.Refresh();
			DataGridViewCheckBoxCell checkEliminar;
			DataGridViewTextBoxCell txtnpelicula;

			//N_Documento
			for (int i = 0; i <= grdDatos.RowCount - 1; i++)
			{
				pgb_Barra.Value = i + 1;
				pgb_Barra.Refresh();
				checkEliminar = (DataGridViewCheckBoxCell)grdDatos.Rows[i].Cells["ColEliminar"];
				txtnpelicula = (DataGridViewTextBoxCell)grdDatos.Rows[i].Cells["N_pelicula"];

				if (Convert.ToBoolean(checkEliminar.Value) == true)
				{
					SqlCommand cmdValorMax = new SqlCommand();
					DataSet dtValorMax;
					cmdValorMax.CommandText = "pa_DosimetroTLD_del " + txtnpelicula.Value + ",'" + Clases.clsUsuario.Usuario + "'";
					cmdValorMax.CommandType = CommandType.Text;
					dtValorMax = Conectar.Listar(ClaseGeneral.Conexion, cmdValorMax);
				}
			}
			MessageBox.Show("Informacion esta listo para generar el documento.");

			btn_Corregir.Enabled = true;
			pnl_Progreso.Visible = false;
		}


		private void btn_Cliente_Click(object sender, EventArgs e)
		{
			frmBusquedaEmpresa frm = new frmBusquedaEmpresa();
			frm.Show(this);
		}

		private void btnAgregarRef_Click(object sender, EventArgs e)
		{
			//SqlCommand cmd = new SqlCommand();
			//cmd.CommandText = String.Format("pa_PersonalReferencia_ins {0},'{1}',{2},{3}", lbl_id_cliente.Text.ToString(), lbl_rut_cliente.Text, cbx_id_seccion.SelectedValue, cbx_Sucursal.SelectedValue);
			////@id_estadodosimetro int
			//cmd.CommandType = CommandType.Text;
			//Conectar.AgregarModificarEliminar(ClaseGeneral.Conexion, cmd);
		}

		#endregion

		#region "combobox"

		private void cbx_Sucursal_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Listar_Personal();
		}


		private void Cbx_anno_SelectedIndexChanged(object sender, EventArgs e)
		{
			Cargar_Periodo();
		}
		private void cbx_Sucursal_SelectionChangeCommitted(object sender, EventArgs e)
		{
			//Cursor = Cursors.WaitCursor;
			//if (!Inicializar)
			//	Listar_Personal();
			//Cursor = Cursors.Default;
		}


		#endregion

		#region "CheckBox"
		private void chkSeleccionar_CheckedChanged(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			DataGridViewCheckBoxCell checkEliminar;
			DataGridViewCheckBoxCell checkGenerado;
			DataGridViewCheckBoxCell checkgenerar;
			for (int i = 0; i <= grdDatos.RowCount - 1; i++)
			{
				checkEliminar = (DataGridViewCheckBoxCell)grdDatos.Rows[i].Cells["ColEliminar"];
				checkGenerado = (DataGridViewCheckBoxCell)grdDatos.Rows[i].Cells["chkGenerado"];
				checkgenerar = (DataGridViewCheckBoxCell)grdDatos.Rows[i].Cells["Generar"];
				if ((bool)checkEliminar.Value == false && (int)checkGenerado.Value == 0)
				{
					checkgenerar.Value = (int)checkgenerar.Value == 1 ? 0 : 1;
				}

			}

			Cursor = Cursors.Default;
		}

		#endregion

		#region "grilla"

		private void grdDatos_KeyDown(object sender, KeyEventArgs e)
		{
			if ((grdDatos.CurrentCell.ColumnIndex == N_pelicula.Index + 2))
			{
				if (e.KeyCode == Keys.Delete)
				{

				}
			}
		}


		private void grdDatos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (grdDatos.IsCurrentCellDirty)
			{
				grdDatos.CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		private void grdDatos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if ((grdDatos.Columns[e.ColumnIndex].Name == "Controlado") || (grdDatos.Columns[e.ColumnIndex].Name == "condosis"))
			{//chkGenerado
				DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)grdDatos.Rows[e.RowIndex].Cells["Controlado"];
				DataGridViewCheckBoxCell chkcondosis = (DataGridViewCheckBoxCell)grdDatos.Rows[e.RowIndex].Cells["condosis"];
				DataGridViewTextBoxCell txtvalor = (DataGridViewTextBoxCell)grdDatos.Rows[e.RowIndex].Cells["valor"];
				DataGridViewComboBoxCell cbxEstado = (DataGridViewComboBoxCell)grdDatos.Rows[e.RowIndex].Cells["Estado"];
				if (Convert.ToInt64(checkCell.Value) == 1)
				{
					chkcondosis.ReadOnly = false;

					if (Convert.ToInt64(chkcondosis.Value) == 1)
					{
						txtvalor.ReadOnly = false;
						cbxEstado.ReadOnly = true;
						cbxEstado.Value = 0;
					}
					else
					{
						txtvalor.ReadOnly = true;
						txtvalor.Value = 0;
						cbxEstado.ReadOnly = false;
					}
				}
				else
				{
					txtvalor.ReadOnly = true;
					chkcondosis.ReadOnly = true;
					chkcondosis.ReadOnly = true;
					cbxEstado.ReadOnly = true;

				}
			}

		}


		private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void grdDatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{

			//this.grdDatos.Columns["Dosis"].ValueType = typeof(Decimal);
			//this.grdDatos.Columns["Dosis"].DefaultCellStyle.Format = "N2";
		}


		#endregion

		#region "Excel"

		public static void WDAddTable(string fileName, string[] data1, string[] data2, string[] data3, string[] data4)
		{
			using (var document = WordprocessingDocument.Open(fileName, true))
			{

				var doc = document.MainDocumentPart.Document;

				//DocumentFormat.OpenXml.Wordprocessing.Table table = doc.Body.Elements<DocumentFormat.OpenXml.Wordprocessing.Table>().Where<>.
				DocumentFormat.OpenXml.Wordprocessing.Table table = doc.Body.Elements<DocumentFormat.OpenXml.Wordprocessing.Table>().ElementAtOrDefault(2);

				//    new DocumentFormat.OpenXml.Wordprocessing.Table().First() ;

				//Table table =
				//  doc.MainDocumentPart.Document.Body.Elements<Table>().First();

				TableProperties props = new TableProperties(
					new TableBorders(
						new DocumentFormat.OpenXml.Wordprocessing.TopBorder
						{
							Val = new EnumValue<BorderValues>(BorderValues.None),
							Size = 9
						},
						new DocumentFormat.OpenXml.Wordprocessing.BottomBorder
						{
							Val = new EnumValue<BorderValues>(BorderValues.None),
							Size = 9
						},
						new DocumentFormat.OpenXml.Wordprocessing.LeftBorder
						{
							Val = new EnumValue<BorderValues>(BorderValues.None),
							Size = 9
						},
						new DocumentFormat.OpenXml.Wordprocessing.RightBorder
						{
							Val = new EnumValue<BorderValues>(BorderValues.None),
							Size = 9
						},
						new InsideHorizontalBorder
						{
							Val = new EnumValue<BorderValues>(BorderValues.None),
							Size = 9
						},
						new InsideVerticalBorder
						{
							Val = new EnumValue<BorderValues>(BorderValues.None),
							Size = 9
						}));
				table.AppendChild<TableProperties>(props);

				for (var i = 0; i <= data1.GetUpperBound(0); i++)
				{
					var tr = new TableRow(new TableWidth { Type = TableWidthUnitValues.Auto });
					var tc2 = new TableCell();
					var tc3 = new TableCell();
					var tc4 = new TableCell();
					//for (var j = 0; j <= data.GetUpperBound(1); j++)
					//{
					var tc = new TableCell();
					// Assume you want columns that are automatically sized.
					if (i == 0)
					{



						tc.Append(new TableCellProperties(
																				new TableCellWidth { Type = TableWidthUnitValues.Auto },
																				new DocumentFormat.OpenXml.Wordprocessing.Bold(),
																				new DocumentFormat.OpenXml.Wordprocessing.RunFonts() { Ascii = "Arial" },
																				new DocumentFormat.OpenXml.Wordprocessing.FontSize() { Val = "9" },
																				new Paragraph(new DocumentFormat.OpenXml.Wordprocessing.Run(new DocumentFormat.OpenXml.Wordprocessing.Text(data1[i])),
																						new DocumentFormat.OpenXml.Wordprocessing.RunFonts() { Ascii = "Arial" })
																				));

						tr.Append(tc);



						tc2.Append(new TableCellProperties(
					new TableCellWidth { Type = TableWidthUnitValues.Dxa, Width = "350" },
																				new DocumentFormat.OpenXml.Wordprocessing.Bold(),
																				new DocumentFormat.OpenXml.Wordprocessing.FontSize() { Val = "9" }
																				));

						tc3.Append(new TableCellProperties(
					new TableCellWidth { Type = TableWidthUnitValues.Dxa, Width = "600" },
					new DocumentFormat.OpenXml.Wordprocessing.Bold(),
																				new DocumentFormat.OpenXml.Wordprocessing.FontSize() { Val = "9" }
																				));
					}
					else
					{
						tc.Append(new TableCellProperties(
																				new TableCellWidth { Type = TableWidthUnitValues.Auto },
																				new DocumentFormat.OpenXml.Wordprocessing.RunFonts() { Ascii = "Arial" },
																				new DocumentFormat.OpenXml.Wordprocessing.FontSize() { Val = "9" },
																				new Paragraph(new DocumentFormat.OpenXml.Wordprocessing.Run(new DocumentFormat.OpenXml.Wordprocessing.Text(data1[i])),
																						new DocumentFormat.OpenXml.Wordprocessing.RunFonts() { Ascii = "Arial" })
																				));

						tr.Append(tc);



						tc2.Append(new TableCellProperties(
					new TableCellWidth { Type = TableWidthUnitValues.Dxa, Width = "350" },
																				new DocumentFormat.OpenXml.Wordprocessing.FontSize() { Val = "9" }
																				));

						tc3.Append(new TableCellProperties(
					new TableCellWidth { Type = TableWidthUnitValues.Dxa, Width = "600" },
																				new DocumentFormat.OpenXml.Wordprocessing.FontSize() { Val = "9" }
																				));
					}
					//tc.Append(new Paragraph(new DocumentFormat.OpenXml.Wordprocessing.Run(new DocumentFormat.OpenXml.Wordprocessing.Text(data1[i]))),
					//    new TableCellProperties(
					//                              new TableCellWidth { Type = TableWidthUnitValues.Dxa, Width = "500" },
					//                               new DocumentFormat.OpenXml.Wordprocessing.FontSize() { Val = "9" }
					//                               )
					//    );
					//tr.Append(tc);


					tc2.Append(new Paragraph(new DocumentFormat.OpenXml.Wordprocessing.Run(new DocumentFormat.OpenXml.Wordprocessing.Text(data2[i]))));
					// Assume you want columns that are automatically sized.
					tr.Append(tc2);


					tc3.Append(new Paragraph(new DocumentFormat.OpenXml.Wordprocessing.Run(new DocumentFormat.OpenXml.Wordprocessing.Text(data3[i]))));
					// Assume you want columns that are automatically sized.

					tr.Append(tc3);

					tc4.Append(new TableCellProperties(
																				new TableCellWidth { Type = TableWidthUnitValues.Auto },
																				new DocumentFormat.OpenXml.Wordprocessing.Bold(),
																				new DocumentFormat.OpenXml.Wordprocessing.RunFonts() { Ascii = "Arial" },
																				new DocumentFormat.OpenXml.Wordprocessing.FontSize() { Val = "9" },
																				new Paragraph(new DocumentFormat.OpenXml.Wordprocessing.Run(new DocumentFormat.OpenXml.Wordprocessing.Text(data4[i])))
																				));

					tr.Append(tc4);
					// }
					table.Append(tr);
				}
				//  doc.Body.Append(table);
				doc.Save();
			}
		}


		public bool UpdateValue(string sheetName, string addressName, string value, UInt32Value styleIndex, bool isString)
		{
			// Assume failure.
			bool updated = false;

			Sheet sheet = wbPart.Workbook.Descendants<Sheet>().Where(
				(s) => s.Name == sheetName).FirstOrDefault();

			if (sheet != null)
			{
				Worksheet ws = ((WorksheetPart)(wbPart.GetPartById(sheet.Id))).Worksheet;
				Cell cell = InsertCellInWorksheet(ws, addressName);

				if (isString)
				{
					// Either retrieve the index of an existing string,
					// or insert the string into the shared string table
					// and get the index of the new item.
					// int stringIndex = InsertSharedStringItem(wbPart, value);

					//					  cell.CellValue = new CellValue(stringIndex.ToString());
					cell.CellValue = new CellValue(value);
					cell.DataType = new EnumValue<CellValues>(CellValues.String);
				}
				else
				{
					cell.CellValue = new CellValue(value);
					cell.DataType = new EnumValue<CellValues>(CellValues.Number);
				}

				//if (styleIndex > 0)
				//	cell.StyleIndex = styleIndex;

				// Save the worksheet.
				ws.Save();
				updated = true;
			}

			return updated;
		}

		// Given the main workbook part, and a text value, insert the text into 
		// the shared string table. Create the table if necessary. If the value 
		// already exists, return its index. If it doesn't exist, insert it and 
		// return its new index.
		private int InsertSharedStringItem(WorkbookPart wbPart, string value)
		{
			int index = 0;
			bool found = false;
			var stringTablePart = wbPart
				.GetPartsOfType<SharedStringTablePart>().FirstOrDefault();

			// If the shared string table is missing, something's wrong.
			// Just return the index that you found in the cell.
			// Otherwise, look up the correct text in the table.
			if (stringTablePart == null)
			{
				// Create it.
				stringTablePart = wbPart.AddNewPart<SharedStringTablePart>();
			}

			var stringTable = stringTablePart.SharedStringTable;
			if (stringTable == null)
			{
				stringTable = new SharedStringTable();
			}

			// Iterate through all the items in the SharedStringTable. 
			// If the text already exists, return its index.
			foreach (SharedStringItem item in stringTable.Elements<SharedStringItem>())
			{
				if (item.InnerText == value)
				{
					found = true;
					break;
				}
				index += 1;
			}

			if (!found)
			{
				stringTable.AppendChild(new SharedStringItem(new DocumentFormat.OpenXml.Spreadsheet.Text(value)));
				stringTable.Save();
			}

			return index;
		}

		// Given a Worksheet and an address (like "AZ254"), either return a 
		// cell reference, or create the cell reference and return it.
		private Cell InsertCellInWorksheet(Worksheet ws, string addressName)
		{
			SheetData sheetData = ws.GetFirstChild<SheetData>();
			Cell cell = null;

			UInt32 rowNumber = GetRowIndex(addressName);
			Row row = GetRow(sheetData, rowNumber);

			// If the cell you need already exists, return it.
			// If there is not a cell with the specified column name, insert one.  
			Cell refCell = row.Elements<Cell>().
				Where(c => c.CellReference.Value == addressName).FirstOrDefault();
			if (refCell != null)
			{
				cell = refCell;
			}
			else
			{
				cell = CreateCell(row, addressName);
			}
			return cell;
		}

		// Add a cell with the specified address to a row.
		private Cell CreateCell(Row row, String address)
		{
			Cell cellResult;
			Cell refCell = null;

			// Cells must be in sequential order according to CellReference. 
			// Determine where to insert the new cell.
			foreach (Cell cell in row.Elements<Cell>())
			{
				//if (string.Compare(cell.CellReference.Value, address, true) > 0)
				if (cell.CellReference.Value.ToString() == address)
				{
					refCell = cell;
					break;
				}
			}

			cellResult = new Cell
			{
				CellReference = address
			};

			row.InsertBefore(cellResult, refCell);
			return cellResult;
		}

		// Return the row at the specified rowIndex located within
		// the sheet data passed in via wsData. If the row does not
		// exist, create it.
		private Row GetRow(SheetData wsData, UInt32 rowIndex)
		{
			var row = wsData.Elements<Row>().
			Where(r => r.RowIndex.Value == rowIndex).FirstOrDefault();
			if (row == null)
			{
				row = new Row();
				row.RowIndex = rowIndex;
				wsData.Append(row);
			}
			return row;
		}

		// Given an Excel address such as E5 or AB128, GetRowIndex
		// parses the address and returns the row index.
		private UInt32 GetRowIndex(string address)
		{
			string rowPart;
			uint l;
			UInt32 result = 0;

			for (int i = 0; i < address.Length; i++)
			{
				if (UInt32.TryParse(address.Substring(i, 1), out l))
				{
					rowPart = address.Substring(i, address.Length - i);
					if (UInt32.TryParse(rowPart, out l))
					{
						result = l;
						break;
					}
				}
			}
			return result;
		}


		#endregion



		private void LLamadoReporte_Click(object sender, EventArgs e)
		{
			MDIPrincipal.LlamadaReporte(Convert.ToUInt16(((System.Windows.Forms.ToolStripItem)sender).Tag.ToString()));

		}

		#region Textbox

		#endregion

	}
}
