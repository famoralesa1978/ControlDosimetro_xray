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
	public partial class frmConsultaDosimetroTLD : Form
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
		string strComuna;
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

		public frmConsultaDosimetroTLD()
		{
			InitializeComponent();
			AsignarEvento();
			grdDatos.AutoGenerateColumns = false;

		}

		private void frmConsultaDosimetroTLD_Load(object sender, EventArgs e)
		{
			SqlCommand cmdcombo = new SqlCommand();
			//SqlCommand cmdcombo = new SqlCommand();
			DataSet dtcombo;
			cmdcombo.CommandText = "select 0 as Id_DetParametro, 'Seleccione' as Glosa, 0 as orden union all " +
				"SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=2 order by orden ";
			cmdcombo.CommandType = CommandType.Text;
			dtcombo = Conectar.Listar(Clases.clsBD.BD, cmdcombo);

			pnl_Progreso.Visible = false;
			grpFiltro.Enabled = false;
			Cargar_Anno();
		}

		#region "Llamada de carga"

		private void Cargar_Cliente(Int64 intCodCliente)
		{


			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "select run,Razon_Social,N_Cliente_Ref, Direccion as Direccion ,r.Id_Region,c.Id_Provincia,c.Id_Comuna,Telefono, Id_TipoFuente,Id_estado,Fechainicio,Servicio,r.region,co.Comuna " +
											"  FROM tbl_cliente c inner join [dbo].[glo_region] r on c.Id_Region=r.Id_Region inner join glo_comuna co on co.id_comuna=c.id_comuna" +
											" WHERE Id_cliente= " + intCodCliente.ToString();//comuna +','+ region
			DataSet dt;

			dt = Conectar.Listar(Clases.clsBD.BD, cmd);
			if (dt.Tables[0].Rows.Count > 0)
			{
				lbl_id_cliente.Text = intCodCliente.ToString();
				lbl_rut.Text = dt.Tables[0].Rows[0]["run"].ToString();
				lbl_nombreCliente.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
				strDireccion = dt.Tables[0].Rows[0]["Direccion"].ToString();
				strServicio= dt.Tables[0].Rows[0]["Servicio"].ToString();
				strRegion = dt.Tables[0].Rows[0]["region"].ToString();
				strComuna = dt.Tables[0].Rows[0]["Comuna"].ToString();
				btn_cargar.Enabled = true;
				btn_Cargar_cliente.Enabled = false;
				lbl_id_cliente.Enabled = false;
				cbx_anno.Enabled = true;
				cbx_id_periodo.Enabled = true;
			}
			else
			{
				btn_Cargar_cliente.Enabled = true;
				//lbl_id_cliente.Text = "";
				btn_cargar.Enabled = false;
				lbl_id_cliente.Enabled = true;
				lbl_nombreCliente.Text = "";
				lbl_rut.Text = "";
				if (intCodCliente != 0)
					MessageBox.Show("El cliente no existe");

			}
		}

		private void Listar_Personal()
		{
			SqlCommand cmd = new SqlCommand();
			//SqlCommand cmd = new SqlCommand();

			DataSet dt;

			int intSucursal = cbx_Sucursal.SelectedValue == null ? 0 : (int)cbx_Sucursal.SelectedValue;
			int intSeccion = cbx_id_seccion.SelectedValue == null ? 0 : (int)cbx_id_seccion.SelectedValue;

			cmd.CommandText = "pa_ConsultaIngresoTLDPorSeccion_sel " + cbx_id_periodo.SelectedValue.ToString() + "," + lbl_id_cliente.Text + "," + intSeccion.ToString() + "," + intSucursal.ToString();

			cmd.CommandType = CommandType.Text;

			dt = Conectar.Listar(Clases.clsBD.BD, cmd);
			string filterExp = "";
			string sortExp = "rut";
			DataRow[] drarray;
			drarray = dt.Tables[0].Select(filterExp, sortExp, DataViewRowState.CurrentRows);

			string filterExp1 = "";
			string sortExp1 = "N_pelicula";
			DataRow[] drarray1;
			drarray1 = dt.Tables[0].Select(filterExp1, sortExp1, DataViewRowState.CurrentRows);

			groupBox2.Text = "Listado       Registro Generado:" + drarray.Count().ToString() + ", registro Faltante: " + drarray1.Count().ToString();


			if (dt.Tables[0].Rows.Count == 0)
			{
				grdDatos.DataSource = dt.Tables[0];
				grpFiltro.Enabled = false;
				
			}
			else
			{
				grpFiltro.Enabled = true;
				grdDatos.DefaultCellStyle.BackColor = System.Drawing.Color.White;
				grdDatos.DataSource = dt.Tables[0];
			}
		}

		private void Cargar_Anno()
		{
			SqlCommand cmd = new SqlCommand();

			//  SqlCommand cmd = new SqlCommand();

			cmd.CommandText = "SELECT distinct Anno FROM conf_periodo WHERE Id_TipoPeriodo=3";
			//cmd.CommandText = "SELECT Id_Periodo,Anno, Mes,Id_TipoPeriodo FROM conf_periodo WHERE Id_TipoPeriodo=3";
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			cbx_anno.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
			cbx_anno.DataSource = dt.Tables[0];

		}

		private void Cargar_Periodo()
		{
			SqlCommand cmd = new SqlCommand
			{
				CommandText = "SELECT Id_Periodo,Mes, cast((mes/3) as varchar(10))+ 'º TRI' FROM conf_periodo WHERE Id_TipoPeriodo=3 and Anno=" + cbx_anno.Text
			};
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			cbx_id_periodo.DisplayMember = dt.Tables[0].Columns[2].Caption.ToString();
			cbx_id_periodo.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
			cbx_id_periodo.DataSource = dt.Tables[0];
		}

		private void Cargar_Sucursal()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "select id_sucursal, direccion + ','+co.comuna as Dato " +
					"from [dbo].[tbl_sucursal] s " +
					"inner join glo_region r on r.Id_region=s.Id_Region " +
					"inner join glo_comuna co on co.id_comuna=s.Id_Comuna " +
					"where run='" + lbl_rut.Text + "' and s.id_estado=1";
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			cbx_Sucursal.DisplayMember = dt.Tables[0].Columns[1].Caption.ToString();
			cbx_Sucursal.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
			cbx_Sucursal.DataSource = dt.Tables[0];

		}

		private void Cargar_Seccion()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "SELECT seccion,id_seccion " +
							" FROM tbl_seccion  WHERE Id_cliente= " + lbl_id_cliente.Text.ToString() + " and id_estado=1";
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);
			
			cbx_id_seccion.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
			cbx_id_seccion.ValueMember = dt.Tables[0].Columns[1].Caption.ToString();
			cbx_id_seccion.DataSource = dt.Tables[0];
		}

		private void AsignarEvento()
		{
			lbl_id_cliente.KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
			lbl_id_cliente.KeyDown += new KeyEventHandler(ClaseEvento.Numero_KeyDown);
		}

		int DevolverNDosimetro(int intDosimetro, DataTable dt)
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

		private void picFiltrarpersonal_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			classFuncionesGenerales.Filtro.FiltroPersonal(ref grdDatos, txt_NombrePersonal.Text, txt_RunPersonal.Text);
			Cursor = Cursors.Default;
		}

		private void btn_Filtro_Click(object sender, EventArgs e)
		{
		}

		private void btn_cargar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			Inicializar = false;
			Listar_Personal();
			cbx_anno.Enabled = false;
			cbx_id_periodo.Enabled = false;
			btn_cargar.Enabled = false;
			grdDatos.Focus();
				Cursor = Cursors.Default;
		}

		private void btn_filtro_Click_1(object sender, EventArgs e)
		{

			cbx_anno.Enabled = true;
			cbx_id_periodo.Enabled = true;
			groupBox2.Text = "Listado";
			lbl_id_cliente.Text = "-1";
			lbl_rut.Text = "";
			lbl_nombreCliente.Text = "";
			btn_cargar.Enabled = true;
			btn_Cargar_cliente.Enabled = true;
			lbl_id_cliente.Enabled = true;
			Listar_Personal();
			lbl_id_cliente.Text = "0";
			lbl_rut.Text = "";
			lbl_id_cliente.Focus();
			btn_cargar.Enabled = false;
			Inicializar = true;
		}

		private void btn_Cerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_Excel_Click(object sender, EventArgs e)
		{
			string targetPathFormato = "C:\\BaseTLD\\formato\\" + "FormatoTLD.xlsx";
			string targetPathFormatoInfome = "C:\\BaseTLD\\formato\\" + "FORMULARIO DESPACHO.xlsx";
			grdDatos.Sort(grdDatos.Columns[1], ListSortDirection.Ascending);

			string targetPathConf = "C:\\BaseTLD\\Cliente";
			string targetPathFormatoFormulario = "C:\\BaseTLD\\Cliente";
			if (!System.IO.Directory.Exists(targetPathConf))
			{
				System.IO.Directory.CreateDirectory(targetPathConf);
			}

			targetPathConf = "C:\\BaseTLD\\Cliente\\Cliente" + lbl_id_cliente.Text;
			if (!System.IO.Directory.Exists(targetPathConf))
			{
				System.IO.Directory.CreateDirectory(targetPathConf);
			}
			targetPathConf = "C:\\BaseTLD\\Cliente\\Cliente" + lbl_id_cliente.Text;
			if (!System.IO.Directory.Exists(targetPathConf))
			{
				System.IO.Directory.CreateDirectory(targetPathConf);
			}

			string strDirCliente= @targetPathConf;

			targetPathConf = "C:\\BaseTLD\\Cliente\\Cliente" + lbl_id_cliente.Text + "\\CodigoBarra";
			if (!System.IO.Directory.Exists(targetPathConf))
			{
				System.IO.Directory.CreateDirectory(targetPathConf);
			}

			targetPathFormatoFormulario = "C:\\BaseTLD\\Cliente\\Cliente" + lbl_id_cliente.Text + "\\Formulario";
			if (!System.IO.Directory.Exists(targetPathFormatoFormulario))
			{
				System.IO.Directory.CreateDirectory(targetPathFormatoFormulario);
			}

			DataSet dtPeriodo;
			// SqlCommand cmdPeriodo = new SqlCommand();
			SqlCommand cmdPeriodo = new SqlCommand();

			cmdPeriodo.CommandText = "SELECT fecha_inicio,fecha_termino, " +
														"substring([fecha_inicio],1,2)+' de '+ dbo.getmonth(cast(substring( [fecha_inicio],4,2)as int))+ ' de '+ substring([fecha_inicio],7,4) as Finicio," +
														"substring([fecha_termino],1,2)+' de '+dbo.getmonth(cast(substring( [fecha_termino],4,2)as int))+ ' de '+ substring([fecha_termino],7,4) as FTermino" +
													 " FROM conf_periodo " +
													 //"where mes =3 and anno=" + cbx_anno.Text;  
													 "WHERE  Id_Periodo= " + cbx_id_periodo.SelectedValue;
			cmdPeriodo.CommandType = CommandType.Text;
			dtPeriodo = Conectar.Listar(Clases.clsBD.BD, cmdPeriodo);
			string strfecha_inicio = "From " + dtPeriodo.Tables[0].Rows[0]["fecha_inicio"].ToString().Substring(0, 6) + dtPeriodo.Tables[0].Rows[0]["fecha_inicio"].ToString().Substring(8, 2);
			strfecha_inicio = strfecha_inicio + " to " + dtPeriodo.Tables[0].Rows[0]["fecha_termino"].ToString().Substring(0, 6) + dtPeriodo.Tables[0].Rows[0]["fecha_termino"].ToString().Substring(8, 2);

			string strfecha_Per = dtPeriodo.Tables[0].Rows[0]["Finicio"].ToString() + " al " + dtPeriodo.Tables[0].Rows[0]["FTermino"].ToString();

			string strfecha_Fin = dtPeriodo.Tables[0].Rows[0]["FTermino"].ToString();

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
			int intExcel = 1;
			File.Copy(targetPathFormato, targetPathConf + "\\ET_Cliente" + lbl_id_cliente.Text + "_" + cbx_id_seccion.Text + "_" + cbx_anno.Text.ToString() + "_" + cbx_id_periodo.Text.ToString().Substring(0, 1) + "Tri.xlsx", true);
			File.Copy(targetPathFormatoInfome, targetPathFormatoFormulario + "\\Formulario Cliente" + lbl_id_cliente.Text + "_" + cbx_id_seccion.Text + "_" + cbx_anno.Text.ToString() + "_" + cbx_id_periodo.Text.ToString().Substring(0, 1) + "Tri_" + intExcel.ToString() + ".xlsx", true);
			string strpathcopiar = targetPathConf + "\\ET_Cliente" + lbl_id_cliente.Text + "_" + cbx_id_seccion.Text + "_" + cbx_anno.Text.ToString() + "_" + cbx_id_periodo.Text.ToString().Substring(0, 1) + "Tri.xlsx";
			
			int intFila = 2;
			int intHojaExcel = 19;
		
			string strpathcopiarInforme = targetPathFormatoFormulario + "\\Formulario Cliente" + lbl_id_cliente.Text + "_" + cbx_id_seccion.Text + "_" + cbx_anno.Text.ToString() + "_" + cbx_id_periodo.Text.ToString().Substring(0, 1) + "Tri_" + intExcel.ToString() + ".xlsx";
			string strUsados = "Estos dosimetros deben ser usados entre el " + strfecha_Per + " al " + strfecha_Fin;
			string fmt = "00000000";
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
				string wsName = "Sheet1";
				if ((checkCell.Value.ToString() == "1"))//(checkGenerar.Value.ToString() == "1") &&&& (txtid_estadodosimetro.Value.ToString() == "-1")
				{
					if(intHojaExcel==34)
					{
						intHojaExcel = 19;
						intExcel = intExcel + 1;
						strpathcopiarInforme = targetPathFormatoFormulario + "\\Formulario Cliente" + lbl_id_cliente.Text + "_" + cbx_id_seccion.Text + "_" + cbx_anno.Text.ToString() + "_" + cbx_id_periodo.Text.ToString().Substring(0, 1) + "Tri_" + (intExcel-1).ToString() + ".xlsx";

						File.Copy(strpathcopiarInforme, targetPathFormatoFormulario + "\\Formulario Cliente" + lbl_id_cliente.Text + "_" + cbx_id_seccion.Text + "_" + cbx_anno.Text.ToString() + "_" + cbx_id_periodo.Text.ToString().Substring(0, 1) + "Tri_" + (intExcel).ToString() + ".xlsx", true);

						strpathcopiarInforme = targetPathFormatoFormulario + "\\Formulario Cliente" + lbl_id_cliente.Text + "_" + cbx_id_seccion.Text + "_" + cbx_anno.Text.ToString() + "_" + cbx_id_periodo.Text.ToString().Substring(0, 1) + "Tri_" + intExcel.ToString() + ".xlsx";
					
						for (int intFilalimpiar= intHojaExcel; intFilalimpiar<=33; intFilalimpiar++){
							wsName = "Informe";
							document = SpreadsheetDocument.Open(strpathcopiarInforme, true);
							wbPart = document.WorkbookPart;
							UpdateValue(wsName, "B" + (intFilalimpiar).ToString(), "", 0, true);
							UpdateValue(wsName, "C" + (intFilalimpiar).ToString(), "", 0, true);
							UpdateValue(wsName, "D" + (intFilalimpiar).ToString(), "", 0, true);
							UpdateValue(wsName, "E" + (intFilalimpiar).ToString(), "", 0, true);
							UpdateValue(wsName, "F" + (intFilalimpiar).ToString(),"", 0, true);
							UpdateValue(wsName, "G" + (intFilalimpiar).ToString(), "", 0, true);
							UpdateValue(wsName, "B15", strUsados, 0, true);
					//		UpdateValue(wsName, "D18", strfecha_Fin, 0, true);
				//			UpdateValue(wsName, "J4", strServicio, 0, true);
							UpdateValue(wsName, "C12", strDireccion.ToUpper(), 0, true);
							UpdateValue(wsName, "C14", lbl_rut.Text, 0, true);
							
						//	UpdateValue(wsName, "M4", strRegion, 0, true);
							UpdateValue(wsName, "C13", strComuna.ToUpper() + ", " + strRegion.ToUpper(), 0, true);
							UpdateValue(wsName, "C11", lbl_nombreCliente.Text.ToUpper(), 0, true);
							UpdateValue(wsName, "F11", lbl_id_cliente.Text, 0, true);
							//lbl_id_cliente
							document.Close();
						}
					}
					
					document = SpreadsheetDocument.Open(strpathcopiar, true);
					wbPart = document.WorkbookPart;
					wsName = "Sheet1";
					UpdateValue(wsName, "A" + (intFila).ToString(), int.Parse(txtnpelicula.Value.ToString()).ToString(fmt), 0, true);
					UpdateValue(wsName, "B" + (intFila).ToString(), Paterno.Value.ToString().ToUpper(), 0, true);
					UpdateValue(wsName, "C" + (intFila).ToString(), Maternos.Value.ToString().ToUpper(), 0, true);
					UpdateValue(wsName, "D" + (intFila).ToString(), Nombres.Value.ToString().Substring(0, 1).ToUpper() + Nombres.Value.ToString().Substring(1, Nombres.Value.ToString().Length - 1).ToLower(), 0, true);
					UpdateValue(wsName, "E" + (intFila).ToString(), Rut.Value.ToString().ToUpperInvariant(), 0, true);
					UpdateValue(wsName, "F" + (intFila).ToString(), strTri, 0, true);
					UpdateValue(wsName, "G" + (intFila).ToString(), strfecha_inicio, 0, true);
					document.Close();

					wsName = "Informe";
					document = SpreadsheetDocument.Open(strpathcopiarInforme, true);
					wbPart = document.WorkbookPart;

					UpdateValue(wsName, "B" + (intHojaExcel).ToString(), int.Parse(txtnpelicula.Value.ToString()).ToString(fmt), 0, true);
					UpdateValue(wsName, "C" + (intHojaExcel).ToString(), Paterno.Value.ToString().ToUpper(), 0, true);
					UpdateValue(wsName, "D" + (intHojaExcel).ToString(), Maternos.Value.ToString().ToUpper(), 0, true);
					UpdateValue(wsName, "E" + (intHojaExcel).ToString(), Nombres.Value.ToString().ToUpper(), 0, true);
					UpdateValue(wsName, "F" + (intHojaExcel).ToString(), Rut.Value.ToString().ToUpperInvariant(), 0, true);
					//UpdateValue(wsName, "D2" , strfecha_Per, 0, true);
					//UpdateValue(wsName, "D18", strfecha_Fin, 0, true);
					UpdateValue(wsName, "B15", strUsados, 0, true);
					UpdateValue(wsName, "C12", strDireccion, 0, true);
					UpdateValue(wsName, "C14", lbl_rut.Text, 0, true);

					//	UpdateValue(wsName, "M4", strRegion, 0, true);
					UpdateValue(wsName, "C13", strComuna.ToUpper() + ", " + strRegion.ToUpper(), 0, true);
					UpdateValue(wsName, "C11", lbl_nombreCliente.Text.ToUpper(), 0, true);
					UpdateValue(wsName, "F11", lbl_id_cliente.Text, 0, true);
					document.Close();


					intFila = intFila + 1;
					intHojaExcel = intHojaExcel + 1;
					//
				}



			}
			Process.Start("explorer.exe", strDirCliente);
			MessageBox.Show("El archivo fue generado");
		}

		private void btn_Cargar_cliente_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			bolInicio = true;
			Inicializar = true;
			Cargar_Cliente(Convert.ToInt64(lbl_id_cliente.Text));
			Cargar_Sucursal();
			Cargar_Seccion();
			Cursor = Cursors.Default;
		}


		#endregion

		#region "combobox"

		private void cbx_Sucursal_SelectedIndexChanged(object sender, EventArgs e)
		{
			Listar_Personal();
		}


		private void Cbx_anno_SelectedIndexChanged(object sender, EventArgs e)
		{
			Cargar_Periodo();
		}


		private void cbx_id_seccion_SelectedIndexChanged(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			if (!Inicializar)
				Listar_Personal();
			Cursor = Cursors.Default;
		}

		private void cbx_Sucursal_SelectionChangeCommitted(object sender, EventArgs e)
		{
			if (!bolInicio)
				btn_cargar_Click(null, null);

			bolInicio = false;
		}


		#endregion

		#region "grilla"

		private void grdDatos_KeyDown(object sender, KeyEventArgs e)
		{
			if ((grdDatos.CurrentCell.ColumnIndex == N_pelicula.Index + 2))
			{
				if (e.KeyCode == Keys.Delete)
				{
					SqlCommand cmdValorMax = new SqlCommand();
					DataSet dtValorMax;
					cmdValorMax.CommandText = "pa_DosimetroTLD_del " + grdDatos.Rows[grdDatos.CurrentRow.Index].Cells[2].Value.ToString() + ",'" + Clases.clsUsuario.Usuario + "'";
					cmdValorMax.CommandType = CommandType.Text;
					dtValorMax = Conectar.Listar(Clases.clsBD.BD, cmdValorMax);
					if (dtValorMax.Tables[0].Rows[0][0].ToString() == "-1")
					{
						btn_cargar_Click(null, null);
					}

					MessageBox.Show(dtValorMax.Tables[0].Rows[0][1].ToString());
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
		
		#region Textbox

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

	}
}