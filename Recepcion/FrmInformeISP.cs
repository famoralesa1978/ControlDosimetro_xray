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
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Sql;
using OpenXmlPowerTools;
using System.Xml;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO.Packaging;
using System.Diagnostics;


namespace ControlDosimetro
{
	public partial class FrmInformeISP : Form
	{

		#region "Definicion variable"
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();
		WorkbookPart wbPart = null;
		SpreadsheetDocument document = null;
		//		SpreadsheetDocument document2 = null;
		object missing = System.Reflection.Missing.Value;
		object strcampoMarcador;
		const string documentRelationshipType = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument";
		const string headerContentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.header+xml";
		const string footerContentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.footer+xml";
		//        XmlNamespaceManager nsManager;
		bool bolDesdeCodigo = false;
		private bool Inicializar = true;
		DataTable dtSeccion;
		DataTable dtPeriodo;
		classFuncionesBD.ClsFunciones ClaseFunciones = new classFuncionesBD.ClsFunciones();
		bool DesdeLimpiar = false;
		#endregion

		public FrmInformeISP(Int64 intId_Cliente)
		{
			InitializeComponent();


			SqlCommand cmdcombo = new SqlCommand();
			//SqlCommand cmdcombo = new SqlCommand();
			DataSet dtcombo;
			cmdcombo.CommandText = "select 0 as Id_DetParametro, 'Seleccione' as Glosa, 0 as orden union all " +
				"SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=2 order by orden ";
			cmdcombo.CommandType = CommandType.Text;
			dtcombo = Conectar.Listar(Clases.clsBD.BD, cmdcombo);

			DataGridViewComboBoxColumn comboboxColumn = grdDatos.Columns["Estado"] as DataGridViewComboBoxColumn;
			//
			comboboxColumn.DataSource = dtcombo.Tables[0];
			comboboxColumn.DisplayMember = "Glosa";
			comboboxColumn.ValueMember = "Id_DetParametro";


			AsignarEvento();

			if (intId_Cliente != -1)
			{
				Cargar_Cliente(intId_Cliente);
				//Cargar_Anno();
			}

			btnGenerar.Visible = false;
			pnl_Progreso.Visible = false;
			lbl_Original.Text = RutaArchivo().Replace("\\", "/");
			lbl_Alternativa.Text = "C:/Doc_Xray/";
			rbtOiginal.Checked = true;
		}

		#region "Llamada de carga"

		private void Cargar_Cliente(Int64 intCodCliente)
		{
			Cursor = Cursors.WaitCursor;
			Inicializar = false;

			frmAyudaCliente frm = new frmAyudaCliente(Convert.ToInt64(lbl_id_cliente.Text));

			if (frm.ShowDialog() == DialogResult.OK)
			{
				lbl_nombreCliente.Text = (Convert.ToInt64(lbl_id_cliente.Text) > 1) ? Clases.ClsCliente.Nombres : "";
				lbl_rut_cliente.Text = (Convert.ToInt64(lbl_id_cliente.Text) > 1) ? Clases.ClsCliente.Rut : "";

				SqlCommand cmd = new SqlCommand
				{
					CommandText = String.Format("CargarClientePorRunInforme '{0}',{1}", lbl_rut_cliente.Text, lbl_id_cliente.Text)
				};
				DataSet dt;
				dt = Conectar.Listar(Clases.clsBD.BD, cmd);

				if (dt != null)
				{
					dtPeriodo = new DataTable();
					//if (dt.Tables[0].Rows.Count > 0)
					//{
					dtPeriodo = dt.Tables[3];
					cbx_anno.DataSource = dt.Tables[1];

					//if ((Convert.ToInt64(lbl_id_cliente.Text) < 1))
					//	cbx_id_periodo.DataSource = dtPeriodo;

					//cbx_Sucursal.DataSource = dt.Tables[2];

					//Cargar_Seccion();
					btn_CargarCli.Enabled = false;
					LimpiarFormulario(1);
				}

			}
			else
			{
				LimpiarFormulario(2);
			}
			Cursor = Cursors.Default;
		}
		private void Cargar_Sucursal()
		{
			SqlCommand cmd = new SqlCommand();
			if (!DesdeLimpiar)
				cmd.CommandText = "BusClienteSucursalInforme_TLD " + "'" + lbl_rut_cliente.Text + "'," + lbl_id_cliente.Text + "," + cbx_id_periodo.SelectedValue;
			else
				cmd.CommandText = "BusClienteSucursal_TLD " + "'0',0,0";
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);
			dtSeccion = dt.Tables[1];
			cbx_Sucursal.DisplayMember = dt.Tables[0].Columns[1].Caption.ToString();
			cbx_Sucursal.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
			cbx_Sucursal.DataSource = dt.Tables[0];

			btnResfrescar.Enabled = dtSeccion.DefaultView.ToTable().Rows.Count > 1 && dt.Tables[0].Rows.Count > 0;
			Cargar_Seccion();
		}

		private void Cargar_Seccion()
		{
			//	DataSet dt;
			if (!DesdeLimpiar)
			//// dt = ClaseFunciones.Cargar_SeccionPorRun(Convert.ToInt16(lbl_id_cliente.Text.ToString()), lbl_rut_cliente.Text);
			{
				dtSeccion.DefaultView.RowFilter = String.Format("Id_sucursal={0} OR  Id_sucursal=0", cbx_Sucursal.SelectedValue == null ? 0 : (int?)cbx_Sucursal.SelectedValue);
				cbx_id_seccion.DisplayMember = dtSeccion.Columns[1].Caption.ToString();
				cbx_id_seccion.ValueMember = dtSeccion.Columns[0].Caption.ToString();
				cbx_id_seccion.DataSource = dtSeccion.DefaultView.ToTable();
			}
			else
			{
				dtSeccion.DefaultView.RowFilter = String.Format("Id_sucursal=-1");
				cbx_id_seccion.DisplayMember = dtSeccion.Columns[1].Caption.ToString();
				cbx_id_seccion.ValueMember = dtSeccion.Columns[0].Caption.ToString();
				cbx_id_seccion.DataSource = dtSeccion.DefaultView.ToTable();
			}

			if (dtSeccion.DefaultView.ToTable().Rows.Count == 1)
				Listar_Personal();
		}
		void LimpiarFormulario(int bolLimpiar)
		{
			if (bolLimpiar == 1)
			{
				lbl_id_cliente.Enabled = false;
				btn_CargarCli.Enabled = false;

				cbx_anno.Enabled = true;
				cbx_id_periodo.Enabled = true;
				btn_cargar.Enabled = true;
				groupBox2.Text = "Listado";
				groupBox2.Enabled = false;
				cbx_Sucursal.Enabled = true;
				btn_Corregir.Enabled = false;
			}
			else if (bolLimpiar == 2)
			{
				lbl_id_cliente.Enabled = true;

				lbl_nombreCliente.Text = "";
				lbl_rut_cliente.Text = "";
				cbx_anno.Enabled = false;
				cbx_id_periodo.Enabled = false;
				btn_cargar.Enabled = false;
				btn_CargarCli.Enabled = true;
				groupBox2.Text = "Listado";
				groupBox2.Enabled = false;
				lbl_id_cliente.Text = "";
				cbx_Sucursal.Enabled = true;
				btn_Corregir.Enabled = false;
				DesdeLimpiar = true;
				Cargar_Sucursal();
				Cargar_Seccion();
				Listar_Personal();
				DesdeLimpiar = false;
				lbl_id_cliente.Focus();
			}
			else if (bolLimpiar == 3)
			{
				groupBox2.Enabled = false;
				btn_Corregir.Enabled = false;
			}
			else if (bolLimpiar == 4)
			{
				groupBox2.Enabled = true;
				btn_Corregir.Enabled = true;
				cbx_Sucursal.Enabled = true;
			}
		}

		private void Listar_Personal()
		{
			if (!String.IsNullOrWhiteSpace(lbl_id_cliente.Text) || DesdeLimpiar)
			{
				SqlCommand cmd = new SqlCommand();
				DataSet dt;
				if (cbx_id_seccion.SelectedValue != null && cbx_Sucursal.SelectedValue != null)
					cmd.CommandText = "pa_DosimetroISP_ClienteSeccion_sel " + cbx_id_periodo.SelectedValue + "," + lbl_id_cliente.Text + "," + cbx_Sucursal.SelectedValue + "," + cbx_id_seccion.SelectedValue + ",'" + lbl_rut_cliente.Text + "'";
				else
				{
					if (DesdeLimpiar)
					{
						cmd.CommandText = "pa_DosimetroISP_ClienteSeccion_sel 0,0,0,0,'1111'";
					}
					else
						cmd.CommandText = "pa_DosimetroISP_ClienteSeccion_sel " + cbx_id_periodo.SelectedValue + "," + lbl_id_cliente.Text + ",0,0,'" + lbl_rut_cliente.Text + "'";
				}

				cmd.CommandType = CommandType.Text;

				dt = Conectar.Listar(Clases.clsBD.BD, cmd);
				string filterExp = "enviado = 1";
				string sortExp = "N_pelicula";
				DataRow[] drarray;
				drarray = dt.Tables[0].Select(filterExp, sortExp, DataViewRowState.CurrentRows);

				string filterExp1 = "enviado = 0";
				string sortExp1 = "N_pelicula";
				DataRow[] drarray1;
				drarray1 = dt.Tables[0].Select(filterExp1, sortExp1, DataViewRowState.CurrentRows);

				groupBox2.Text = "Listado       Registro Generado:" + drarray.Count().ToString() + ", registro Faltante: " + drarray1.Count().ToString();


				if (dt.Tables[0].Rows.Count == 0)
				{
					btnGenerar.Visible = false;
					LimpiarFormulario(3);
					grdDatos.DataSource = dt.Tables[0];
					//	MessageBox.Show("No se han cargado ningun personal");
				}
				else
				{
					LimpiarFormulario(4);
					btnGenerar.Visible = true;
					grdDatos.DefaultCellStyle.BackColor = System.Drawing.Color.White;
					grdDatos.DataSource = dt.Tables[0];
				}
			}
			else
			{
				//	classFuncionesGenerales.mensajes.MensajeError("Debe tener una seccion  seleccionada");
			}

			//		}

		}

		private void Cargar_Anno()
		{
			SqlCommand cmd = new SqlCommand
			{

				//  SqlCommand cmd = new SqlCommand();

				CommandText = "SELECT distinct Anno FROM conf_periodo WHERE Id_TipoPeriodo=3"
			};
			//cmd.CommandText = "SELECT Id_Periodo,Anno, Mes,Id_TipoPeriodo FROM conf_periodo WHERE Id_TipoPeriodo=3";
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			cbx_anno.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
			cbx_anno.DataSource = dt.Tables[0];

		}

		private void Cargar_Periodo()
		{
			DataTable dtPeriodoCopia = dtPeriodo.Copy();
			dtPeriodoCopia.DefaultView.RowFilter = String.Format("anno={0}", cbx_anno.SelectedValue);

			cbx_id_periodo.DataSource = dtPeriodoCopia.DefaultView.ToTable();
		}

		//private void Cargar_Sucursal()
		//{
		//	SqlCommand cmdSucursal = new SqlCommand
		//	{
		//		CommandText = "select 0 as Id_sucursal, 'Todos' as Direccion union all " +
		//							"SELECT distinct s.Id_sucursal, " +
		//							"case when s.Direccion is null or s.Direccion ='' then c.Direccion else s.Direccion end + ',' + comuna as Direccion" + //N_Documento,
		//							  " FROM [dbo].[ges_DosimetriaPersonal] dos inner join tbl_cliente c on c.Id_cliente=dos.Id_cliente " +
		//							  " inner join tbl_sucursal s on s.Id_sucursal=dos.Id_Sucursal " +
		//							  " inner  join glo_region R on s.id_region=r.id_region inner join glo_provincia p on p.id_provincia=s.Id_Provincia  " +
		//							  " inner join glo_comuna co on co.Id_Comuna=s.Id_Comuna " +
		//							  "WHERE c.Id_cliente= " + lbl_id_cliente.Text + " and dos.id_periodo=" + cbx_id_periodo.SelectedValue + " union all " +
		//								"SELECT distinct s.Id_sucursal, " +
		//							"case when s.Direccion is null or s.Direccion ='' then c.Direccion else s.Direccion end + ',' + comuna as Direccion" + //N_Documento,
		//								" FROM  ges_dosimetro_estado_TLD tld inner join tbl_dosimetria dos on dos.id_cliente = tld.id_cliente and TLD = 1 inner join tbl_cliente c on c.Id_cliente=dos.Id_cliente " +
		//								" inner join tbl_sucursal s on s.Id_sucursal=tld.Id_Sucursal " +
		//								" inner  join glo_region R on s.id_region=r.id_region inner join glo_provincia p on p.id_provincia=s.Id_Provincia  " +
		//								" inner join glo_comuna co on co.Id_Comuna=s.Id_Comuna " +
		//								"WHERE c.Id_cliente= " + lbl_id_cliente.Text + " and dos.id_periodo=" + cbx_id_periodo.SelectedValue,
		//		CommandType = CommandType.Text

		//	};
		//	DataSet dt;
		//	dt = Conectar.Listar(Clases.clsBD.BD, cmdSucursal);

		//	cbx_Sucursal.DisplayMember = "Direccion";
		//	cbx_Sucursal.ValueMember = "Id_sucursal";
		//	cbx_Sucursal.DataSource = dt.Tables[0].DefaultView;

		//}

		private void AsignarEvento()
		{
			lbl_id_cliente.KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
			lbl_id_cliente.KeyDown += new KeyEventHandler(ClaseEvento.Numero_KeyDown);
		}

		//private void Cargar_Seccion()
		//{
		//	DataSet dt;
		//	dt = ClaseFunciones.Cargar_SeccionPorRunTodos(Convert.ToInt16(lbl_id_cliente.Text.ToString()), lbl_rut_cliente.Text);
		//	cbx_id_seccion.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
		//	cbx_id_seccion.ValueMember = dt.Tables[0].Columns[1].Caption.ToString();
		//	cbx_id_seccion.DataSource = dt.Tables[0];
		//}

		private void Generar_Todos()
		{
			Cursor = Cursors.WaitCursor;
			for (int intFila = 1; intFila < cbx_id_seccion.Items.Count; intFila++)
			{

				cbx_id_seccion.SelectedIndex = intFila;
				btnResfrescar_Click(null, null);
				GenerarPorSucursalTodos();

			}
			classFuncionesGenerales.mensajes.MensajeProcesoOK("Proceso terminado");
			Cursor = Cursors.Default;
		}
		private void Generar_TodosV2()
		{
			Cursor = Cursors.WaitCursor;
			for (int intFila = 1; intFila < cbx_id_seccion.Items.Count; intFila++)
			{

				cbx_id_seccion.SelectedIndex = intFila;
				btnResfrescar_Click(null, null);
				GenerarPorSucursalV2();

			}
			classFuncionesGenerales.mensajes.MensajeProcesoOK("Proceso terminado");
			Cursor = Cursors.Default;
		}
		private void GenerarPorSucursalV2()
		{
			SqlCommand cmd = new SqlCommand();
			//	  SqlCommand cmd = new SqlCommand();
			SqlCommand cmdpersonal = new SqlCommand();
			//  SqlCommand cmdpersonal = new SqlCommand();
			SqlCommand cmdperiodo = new SqlCommand();
			//  SqlCommand cmdperiodo = new SqlCommand();

			// dtcombo = Conectar.Listar(Clases.clsBD.BD,cmdcombo);
			DataGridViewCheckBoxCell checkGenerar;
			DataGridViewCheckBoxCell checkCell;
			DataGridViewCheckBoxCell chkcondosis;
			DataGridViewTextBoxCell txtvalor;
			DataGridViewTextBoxCell txtndocumento;
			DataGridViewTextBoxCell txtnpelicula;
			DataGridViewTextBoxCell txtnpeliculaoriginal;
			DataGridViewComboBoxCell cbxEstado;
			DataGridViewTextBoxCell txtid_sucursal;
			string strn_cliente;
			string strid_personal;
			string strid_dosimetro;
			string strpath;
			string strpathcopiar;
			string strEstado;
			btnGenerar.Enabled = false;

			SqlCommand cmdArchivo = new SqlCommand();
			DataSet dtArchivo;
			cmdArchivo.CommandText = "" +
				"SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=6 order by orden ";
			cmdArchivo.CommandType = CommandType.Text;
			dtArchivo = Conectar.Listar(Clases.clsBD.BD, cmdArchivo);

			DataSet dtformato;
			cmdArchivo.CommandText = "" +
				"SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=5 order by orden ";
			cmdArchivo.CommandType = CommandType.Text;
			dtformato = Conectar.Listar(Clases.clsBD.BD, cmdArchivo);
			//string targetPath = @ConfigurationManager.AppSettings["Archivo"] + "Cliente " + lbl_id_cliente.Text;
			string targetPath = "";

			if (rbtOiginal.Checked)
				targetPath = @dtArchivo.Tables[0].Rows[0]["Glosa"].ToString() + "Cliente " + lbl_id_cliente.Text;
			else
				targetPath = @"C:\\Doc_Xray\\" + "Cliente " + lbl_id_cliente.Text;


			if (!System.IO.Directory.Exists(targetPath))
			{
				try
				{
					System.IO.Directory.CreateDirectory(targetPath);
				}
				catch(Exception e)
				{
					classFuncionesGenerales.mensajes.MensajeError(e.Message);
					return;
				}
			}



			//  targetPath = dtArchivo.Tables[0].Rows[0]["Glosa"].ToString();


			// targetPath = ConfigurationManager.AppSettings["Archivo"] + "Cliente " + lbl_id_cliente.Text + "\\" + cbx_anno.Text;
			targetPath = targetPath + "\\" + cbx_anno.Text;
			if (!System.IO.Directory.Exists(targetPath))
			{
				System.IO.Directory.CreateDirectory(targetPath);
			}

			// targetPath = ConfigurationManager.AppSettings["Archivo"] + "Cliente " + lbl_id_cliente.Text + "\\" + cbx_anno.Text + "\\" + cbx_id_periodo.Text + "\\";
			targetPath = targetPath + "\\" + cbx_id_periodo.Text + "\\";

			if (!System.IO.Directory.Exists(targetPath))
			{
				System.IO.Directory.CreateDirectory(targetPath);
			}
			//Environment.CurrentDirectory = (targetPath);

			if (rbtOiginal.Checked)
				strpath = dtformato.Tables[0].Rows[0]["Glosa"].ToString() + "cliente.xlsx";//Application.StartupPath.ToString(); 
			else
				strpath = @"C:\\Doc_Xray\\baseCliente\\Plantilla\\cliente.xlsx";



			//**************carga periodo
			DataSet dtPeriodo;
			// SqlCommand cmdPeriodo = new SqlCommand();
			SqlCommand cmdPeriodo = new SqlCommand
			{
				CommandText = "SELECT fecha_inicio,fecha_termino " +
										" FROM conf_periodo " +
										//"where mes =3 and anno=" + cbx_anno.Text;  
										"WHERE  Id_Periodo= " + cbx_id_periodo.SelectedValue,
				CommandType = CommandType.Text
			};
			dtPeriodo = Conectar.Listar(Clases.clsBD.BD, cmdPeriodo);
			string strfecha_inicio = dtPeriodo.Tables[0].Rows[0]["fecha_inicio"].ToString();
			string strfecha_termino = dtPeriodo.Tables[0].Rows[0]["fecha_termino"].ToString();
			//**************carga cliente
			//SqlCommand cmdCliente = new SqlCommand();
			SqlCommand cmdCliente = new SqlCommand
			{
				CommandText = "pa_DosimetroISPGenerar_sel " + cbx_id_periodo.SelectedValue + "," + lbl_id_cliente.Text + "," + cbx_Sucursal.SelectedValue + ",'" + lbl_rut_cliente.Text + "'",

				CommandType = CommandType.Text
			};

			//clsFunc.Cargar_Cliente((int)cbx_id_periodo.SelectedValue, Convert.ToInt64(lbl_id_cliente.Text.ToString()), ref lbl_rut_cliente, ref lbl_nombreCliente);

			DataSet dt;
			DataSet dtCliente;
			dt = Conectar.Listar(Clases.clsBD.BD, cmdCliente);

			string strArchivo = "";
			if (rbtOiginal.Checked)
				strArchivo = dtformato.Tables[0].Rows[0]["Glosa"].ToString() + "Plantillaword.docx";
			else
				strArchivo = @"C:\\Doc_Xray\\baseCliente\\Plantilla\\Informe de Dosimetría.docx";




			//   string strArchivo = ConfigurationManager.AppSettings["Archivo"] + "Plantillaword.docx";

			int i;
			string CantPerdido = "";
			string CantSinUso = "";
			string cantNoDev = "";
			string CantDevFP = "";

			if (dt != null)
			{
				//5 2 MNR 1 0 1
				//6 2 DND 2 0 1
				//10  2 DE  3 0 1
				//11  2 DD  4 0 1
				//12  2 NR  5 0 1
				//13  2 DSU 6 1 1
				if (dt.Tables[1] != null)
				{
					DataTable dtDND = dt.Tables[1].Copy();
					dtDND.DefaultView.RowFilter = String.Format("id_observacion={0}",6);
					CantPerdido = dtDND.DefaultView.ToTable().Rows.Count > 0 ? dtDND.DefaultView.ToTable().Rows[0]["Cantidad"].ToString():"";

					DataTable dtSinUso = dt.Tables[1].Copy();
					dtSinUso.DefaultView.RowFilter = String.Format("id_observacion={0}", 13);
					CantSinUso = dtSinUso.DefaultView.ToTable().Rows.Count > 0 ? dtSinUso.DefaultView.ToTable().Rows[0]["Cantidad"].ToString() : "";

					DataTable dtND= dt.Tables[1].Copy();
					dtND.DefaultView.RowFilter = String.Format("id_observacion={0}", 10);
					cantNoDev = dtND.DefaultView.ToTable().Rows.Count > 0 ? dtND.DefaultView.ToTable().Rows[0]["Cantidad"].ToString() : "";

					DataTable dtNR = dt.Tables[1].Copy();
					dtNR.DefaultView.RowFilter = String.Format("id_observacion={0}", 12);
					cantNoDev = dtNR.DefaultView.ToTable().Rows.Count > 0 ? dtNR.DefaultView.ToTable().Rows[0]["Cantidad"].ToString() : "";
				}
			}
		
			for (int idatos = 0; idatos <= dt.Tables[0].Rows.Count - 1; idatos++)
			{
				#region "Proceso"
				i = 0;
				string strRunEmpresa = lbl_rut_cliente.Text;
				string strRazon_SocialEmpresa = lbl_nombreCliente.Text;
				string strDireccionEmpresa = dt.Tables[0].Rows[idatos]["DireccionCliente"].ToString();
				string strDireccionEmpresaSucursal = cbx_Sucursal.Text;
				string strTelefonoEmpresa = dt.Tables[0].Rows[idatos]["Telefono"].ToString();
				string strregionEmpresa = dt.Tables[0].Rows[idatos]["region"].ToString();
				string strProvinciaEmpresa = dt.Tables[0].Rows[idatos]["Provincia"].ToString();
				string strcomunaEmpresa = dt.Tables[0].Rows[idatos]["comuna"].ToString();
				string strSeccion = (int)cbx_id_seccion.SelectedValue == 0 ? "" : cbx_id_seccion.Text;
				string strFechaRecepcion = dt.Tables[0].Rows[idatos]["FechaRecepcion"].ToString();
				string strOpr = dt.Tables[0].Rows[idatos]["Opr"].ToString();
				string strRunOPR = "";
				string strEmailOPR = dt.Tables[0].Rows[idatos]["EmailOPR"].ToString();
				string strFechaDevolucion = dt.Tables[0].Rows[0]["FechaRecepcion"].ToString();
				//string strN_Documento = dt.Tables[0].Rows[idatos]["N_Documento"].ToString();
				//	string strId_sucursal = dt.Tables[0].Rows[idatos]["Id_sucursal"].ToString();
				String strArchivoCopiar = "";
				strArchivoCopiar = targetPath + "Cliente" + lbl_id_cliente.Text + "_" + strDireccionEmpresa + "_" + cbx_id_periodo.Text.ToString().Substring(0, 1) + "T_" + cbx_anno.Text + "_" + strSeccion + ".docx";


				strpathcopiar = targetPath + "cliente " + lbl_id_cliente.Text + "_" + strDireccionEmpresa + "_" + cbx_id_seccion.Text + ".xlsx";

				// process.Start("c:\Ejemplo de Carpeta con Espacios");
				File.Copy(strpath, strpathcopiar, true);
				//strRunEmpresa + "_" + cbx_id_periodo.Text + ".docx";
				//*************************************


				File.Copy(strArchivo, strArchivoCopiar, true);


				int intfila = 2;

				string[] data1;
				string[] data2;
				string[] data3;
				string[] data4;
				string[] data5;
				string[] data6;

				data1 = new string[] { "" };//strRazon_SocialEmpresa
				data2 = new string[] { "" };
				data3 = new string[] { "" };
				data4 = new string[] { "" };
				data5 = new string[] { "" };
				data6 = new string[] { "" };

				Array.Resize(ref data1, grdDatos.RowCount);
				Array.Resize(ref data2, grdDatos.RowCount);
				Array.Resize(ref data3, grdDatos.RowCount);
				Array.Resize(ref data4, grdDatos.RowCount);
				Array.Resize(ref data5, grdDatos.RowCount);
				Array.Resize(ref data6, grdDatos.RowCount);

				//Array.Resize(ref data1, 1);
				//Array.Resize(ref data2, 1);
				//Array.Resize(ref data3, 1);
				//Array.Resize(ref data4, 1);

				//data1[1] = "NOMBRE";
				//data2[1] = cbx_id_periodo.Text;
				//data3[1] = "N°DOSIMETROS";
				//data4[1] = "RUT";

				pnl_Progreso.Visible = true;
				pgb_Barra.Minimum = 0;
				pgb_Barra.Maximum = grdDatos.RowCount;
				pnl_Progreso.Refresh();
				for (int intfilagrid = 0; intfilagrid <= grdDatos.RowCount - 1; intfilagrid++)
				{
					pgb_Barra.Value = i + 1;
					pgb_Barra.Refresh();
					checkGenerar = (DataGridViewCheckBoxCell)grdDatos.Rows[intfilagrid].Cells["Generar"];
					checkCell = (DataGridViewCheckBoxCell)grdDatos.Rows[intfilagrid].Cells["enviado"];
					chkcondosis = (DataGridViewCheckBoxCell)grdDatos.Rows[intfilagrid].Cells["condosis"];
					txtvalor = (DataGridViewTextBoxCell)grdDatos.Rows[intfilagrid].Cells["valor"];
					txtndocumento = (DataGridViewTextBoxCell)grdDatos.Rows[intfilagrid].Cells["NDocumento"];
					txtnpelicula = (DataGridViewTextBoxCell)grdDatos.Rows[intfilagrid].Cells["N_pelicula"];
					txtnpeliculaoriginal = (DataGridViewTextBoxCell)grdDatos.Rows[intfilagrid].Cells["N_TLD_Original"];

					cbxEstado = (DataGridViewComboBoxCell)grdDatos.Rows[intfilagrid].Cells["Estado"];
					txtid_sucursal = (DataGridViewTextBoxCell)grdDatos.Rows[intfilagrid].Cells["id_sucursal"];

					if (cbxEstado.Value.ToString() != "0")
					{
						DataSet dtcombo;
						SqlCommand cmdcombo = new SqlCommand
						{
							CommandText = " " +
							"SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=2 and Id_DetParametro= " + cbxEstado.Value.ToString() +
							"order by orden ",
							CommandType = CommandType.Text
						};
						dtcombo = Conectar.Listar(Clases.clsBD.BD, cmdcombo);
						strEstado = dtcombo.Tables[0].Rows[0]["glosa"].ToString();
					}
					else
						strEstado = "";
					strn_cliente = grdDatos.Rows[intfilagrid].Cells["N_Cliente"].Value.ToString();
					strid_personal = grdDatos.Rows[intfilagrid].Cells["id_personal"].Value.ToString();
					strid_dosimetro = grdDatos.Rows[intfilagrid].Cells["id_dosimetro"].Value.ToString();

					cmdpersonal.CommandText = "SELECT P.Id_Personal, Rut,SUBSTRING(UPPER (Nombres), 1, 1) + SubSTRING (LOWER (Nombres), 2,len(Nombres)) Nombres, " +
										"SUBSTRING(UPPER (Paterno), 1, 1) + SUbSTRING (LOWER (Paterno), 2,len(Paterno)) Paterno," +
										"SUBSTRING(UPPER (Maternos), 1, 1) + SUbSTRING (LOWER (Maternos), 2,len(Maternos))Maternos," +
										"Id_Seccion,p.Id_estado, " +
							 " cd.glosa,profesion,Fecha_inicio,fecha_termino,Usuario,Fecha_agregado,getdate()as Fecha_Modificacion " +
							 " FROM tbl_personal P inner join conf_detparametro cd on p.Id_sexo=cd.Id_DetParametro" +
							 " inner join glo_profesion pro on pro.id_profesion=p.Id_profesion " +
							 " WHERE Id_Personal= " + strid_personal.ToString() + " and id_cliente=" + lbl_id_cliente.Text +
							 "";
					dtCliente = Conectar.Listar(Clases.clsBD.BD, cmdpersonal);


					//if (strId_sucursal == txtid_sucursal.Value.ToString())
					//{
					//}
					#region "Genera  word y excel"
					if (checkGenerar.Value.ToString() == "1")
					{
						//cmd.CommandText = "update tbl_dosimetria " +
						//                      "set enviado=0" +
						//                  " where id_dosimetro=" + strid_dosimetro;
						//cmd.CommandType = CommandType.Text;

						//Conectar.AgregarModificarEliminar(Clases.clsBD.BD,cmd);

						//cmd.CommandText = "pa_DosimetroIngreso_upd " + txtnpelicula.Value.ToString() + ",12,'Clases.clsUsuario.Usuario',''";
						//cmd.CommandType = CommandType.StoredProcedure;
						//Conectar.AgregarModificarEliminar(Clases.clsBD.BD,cmd);
					}
					else
						 if ((txtndocumento.Value.ToString() == "") && (checkGenerar.Value.ToString() == "0"))
					{
						// MessageBox.Show("Ingrese el n° de  Documento");						  
						grdDatos.Rows[i].DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Red;
						//Selected=true ;
						i = grdDatos.RowCount;
					}
					else
					{
						grdDatos.Rows[i].DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
						if ((strid_dosimetro != "0")) //&& (checkGenerar.Value.ToString() == "1")					 
						{
							document = SpreadsheetDocument.Open(strpathcopiar, true);
							wbPart = document.WorkbookPart;
							string wsName = String.Format("{0}{1}", cbx_id_periodo.Text.Substring(0, 1), "ºT");//4ºT//1ºT|
							UpdateValue(wsName, "A" + (intfila).ToString(), dtCliente.Tables[0].Rows[0]["Nombres"].ToString(), 0, true);
							UpdateValue(wsName, "B" + (intfila).ToString(), dtCliente.Tables[0].Rows[0]["Paterno"].ToString(), 0, true);
							UpdateValue(wsName, "C" + (intfila).ToString(), dtCliente.Tables[0].Rows[0]["Maternos"].ToString(), 0, true);
							UpdateValue(wsName, "D" + (intfila).ToString(), dtCliente.Tables[0].Rows[0]["Rut"].ToString(), 0, true);
							UpdateValue(wsName, "E" + (intfila).ToString(), strfecha_inicio.Replace("/", "-"), 0, true);
							UpdateValue(wsName, "F" + (intfila).ToString(), strfecha_termino.Replace("/", "-"), 0, true);

							UpdateValue(wsName, "G" + (intfila).ToString(), txtvalor.Value.ToString(), 0, true);
							UpdateValue(wsName, "H" + (intfila).ToString(), "TRIMESTRAL", 0, true);
							UpdateValue(wsName, "I" + (intfila).ToString(), strEstado, 0, true);
							UpdateValue(wsName, "J" + (intfila).ToString(), "CUERPO ENTERO", 0, true);
							UpdateValue(wsName, "K" + (intfila).ToString(), "FILMICO", 0, true);

							UpdateValue(wsName, "L" + (intfila).ToString(), "3", 0, false);
							UpdateValue(wsName, "M" + (intfila).ToString(), "Rayos X otros", 0, true);
							UpdateValue(wsName, "N" + (intfila).ToString(), "X-RAY", 0, true);

							UpdateValue(wsName, "O" + (intfila).ToString(), dtCliente.Tables[0].Rows[0]["glosa"].ToString(), 0, true);
							UpdateValue(wsName, "P" + (intfila).ToString(), dtCliente.Tables[0].Rows[0]["profesion"].ToString(), 0, true);
							////							  UpdateValue(wsName, "S" + (intfila + 2).ToString(), dtCliente.Tables[0].Rows[0]["telefono"].ToString(), 0, true);
							UpdateValue(wsName, "S" + (intfila).ToString(), strTelefonoEmpresa, 0, true);//telefono
							UpdateValue(wsName, "X" + (intfila).ToString(), dtCliente.Tables[0].Rows[0]["Fecha_inicio"].ToString().Replace("/", "-"), 0, true);
							//°

							UpdateValue(wsName, "Y" + (intfila).ToString(), strRunEmpresa, 0, true);
							UpdateValue(wsName, "Z" + (intfila).ToString(), strRazon_SocialEmpresa, 0, true);

							UpdateValue(wsName, "AA" + (intfila).ToString(), strDireccionEmpresa.ToString(), 0, true);
							UpdateValue(wsName, "AB" + (intfila).ToString(), strcomunaEmpresa, 0, true);
							UpdateValue(wsName, "AC" + (intfila).ToString(), strProvinciaEmpresa, 0, true);
							UpdateValue(wsName, "AD" + (intfila).ToString(), strregionEmpresa, 0, true);
							UpdateValue(wsName, "AE" + (intfila).ToString(), strTelefonoEmpresa, 0, false);
							document.Close();
							cmd.CommandText = "update tbl_dosimetria " +
																"set enviado=1" +
															" where id_dosimetro=" + strid_dosimetro;
							cmd.CommandType = CommandType.Text;

							Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);

							string strParametro = String.Format("{0},{1},{2},''", txtnpeliculaoriginal.Value.ToString(), "5", Clases.clsUsuario.Usuario);
							cmd.CommandText = "pa_DosimetroIngresoTLD_upd " + strParametro;
							cmd.CommandType = CommandType.Text;
							Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);

							//	id_personal,
							string strUltimoAnno="";
							string strUltimo5Anno = "";
							if (dt.Tables[2] != null)
							{
								DataTable dtUltimoAnno = dt.Tables[2];
								dtUltimoAnno.DefaultView.RowFilter = String.Format("id_personal={0}", strid_personal);

								strUltimoAnno = dtUltimoAnno.DefaultView.ToTable().Rows[0]["UltimoAnno"].ToString();
								strUltimo5Anno = dtUltimoAnno.DefaultView.ToTable().Rows[0]["Ultimo5Anno"].ToString();
							}

							data1[i] = txtnpelicula.Value.ToString();
							data2[i] = dtCliente.Tables[0].Rows[0]["Rut"].ToString();

							data3[i] = dtCliente.Tables[0].Rows[0]["Nombres"].ToString() + " " + dtCliente.Tables[0].Rows[0]["Paterno"].ToString() + " " + dtCliente.Tables[0].Rows[0]["Maternos"].ToString();
							if (chkcondosis.Value.ToString() == "0")
								data4[i] = strEstado == "MNR" ? "0": strEstado;
							else
								data4[i] = txtvalor.Value.ToString();

							data5[i] = strUltimoAnno;
							data6[i] = strUltimo5Anno;
							//}
							// this.p

							intfila = intfila + 1;
							i = i + 1;
						}

					}



					#endregion

				}
				#region Update Document Bookmarks Openxml
				strcampoMarcador = "empresa";

				using (WordprocessingDocument doc = WordprocessingDocument.Open(strArchivoCopiar, true))
				{
					//string strSemetre1 = "";
					//if (cbx_id_periodo.Text.Substring(0, 1) == "1")
					//	strSemetre1 = "primer";
					//if (cbx_id_periodo.Text.Substring(0, 1) == "2")
					//	strSemetre1 = "segundo";
					//if (cbx_id_periodo.Text.Substring(0, 1) == "3")
					//	strSemetre1 = "tercer";
					//if (cbx_id_periodo.Text.Substring(0, 1) == "4")
					//	strSemetre1 = "cuarto";

					strcampoMarcador = "Empresa";
					BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), lbl_nombreCliente.Text);
					strcampoMarcador = "Rut";
					BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), lbl_rut_cliente.Text);//strRazon_SocialEmpresa
					strcampoMarcador = "Periodo";
					BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), string.Format("{0}T {1}", cbx_id_periodo.Text.Substring(0, 1), cbx_anno.Text));//
					strcampoMarcador = "FechaInforme";
					BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), string.Format("{0}/{1}/{2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year));
					strcampoMarcador = "Sucursal";
					BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), strDireccionEmpresaSucursal);
					strcampoMarcador = "Direccion";
					BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), strDireccionEmpresa);
					strcampoMarcador = "NombreOPR";
					BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), strOpr);
					strcampoMarcador = "RunOPR";
					BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), strRunOPR);
					strcampoMarcador = "MailOpr";
					BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), strEmailOPR);
					strcampoMarcador = "FechaDevolucion";
					BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), strFechaDevolucion);
					strcampoMarcador = "FechaLectura";
					BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), strFechaDevolucion);

					strcampoMarcador = "CantToes";
					BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), grdDatos.Rows.Count.ToString());
					strcampoMarcador = "CantPerdido";
					BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), CantPerdido);
					strcampoMarcador = "CantSinUso";
					BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), CantSinUso);
					strcampoMarcador = "cantNoDev";
					BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), cantNoDev);
					strcampoMarcador = "CantDevFP";
					BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), CantDevFP);


				}
				if (data1.Count() > 0)
					WDAddTableV2(strArchivoCopiar, data1, data2, data3, strfecha_inicio, strfecha_termino, strFechaRecepcion, data4, data5, data6);

				#endregion
				#endregion
			}



			MessageBox.Show("Informacion grabada y archivo generado \n Ubicación Archivo:" + targetPath);

			btnGenerar.Enabled = true;
			pnl_Progreso.Visible = false;

			Listar_Personal();
		}

		private void GenerarPorSucursal()
		{
			SqlCommand cmd = new SqlCommand();
			//	  SqlCommand cmd = new SqlCommand();
			SqlCommand cmdpersonal = new SqlCommand();
			//  SqlCommand cmdpersonal = new SqlCommand();
			SqlCommand cmdperiodo = new SqlCommand();
			//  SqlCommand cmdperiodo = new SqlCommand();

			// dtcombo = Conectar.Listar(Clases.clsBD.BD,cmdcombo);
			DataGridViewCheckBoxCell checkGenerar;
			DataGridViewCheckBoxCell checkCell;
			DataGridViewCheckBoxCell chkcondosis;
			DataGridViewTextBoxCell txtvalor;
			DataGridViewTextBoxCell txtndocumento;
			DataGridViewTextBoxCell txtnpelicula;
			DataGridViewTextBoxCell txtnpeliculaoriginal;
			DataGridViewComboBoxCell cbxEstado;
			DataGridViewTextBoxCell txtid_sucursal;
			string strn_cliente;
			string strid_personal;
			string strid_dosimetro;
			string strpath;
			string strpathcopiar;
			string strEstado;
			btnGenerar.Enabled = false;

			SqlCommand cmdArchivo = new SqlCommand();
			DataSet dtArchivo;
			cmdArchivo.CommandText = "" +
				"SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=6 order by orden ";
			cmdArchivo.CommandType = CommandType.Text;
			dtArchivo = Conectar.Listar(Clases.clsBD.BD, cmdArchivo);

			DataSet dtformato;
			cmdArchivo.CommandText = "" +
				"SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=5 order by orden ";
			cmdArchivo.CommandType = CommandType.Text;
			dtformato = Conectar.Listar(Clases.clsBD.BD, cmdArchivo);
			//string targetPath = @ConfigurationManager.AppSettings["Archivo"] + "Cliente " + lbl_id_cliente.Text;
			string targetPath = "";

			if (rbtOiginal.Checked)
				targetPath = @dtArchivo.Tables[0].Rows[0]["Glosa"].ToString() + "Cliente " + lbl_id_cliente.Text;
			else
				targetPath = @"C:\\Doc_Xray\\" + "Cliente " + lbl_id_cliente.Text;


			if (!System.IO.Directory.Exists(targetPath))
			{
				System.IO.Directory.CreateDirectory(targetPath);
			}



			//  targetPath = dtArchivo.Tables[0].Rows[0]["Glosa"].ToString();


			// targetPath = ConfigurationManager.AppSettings["Archivo"] + "Cliente " + lbl_id_cliente.Text + "\\" + cbx_anno.Text;
			targetPath = targetPath + "\\" + cbx_anno.Text;
			if (!System.IO.Directory.Exists(targetPath))
			{
				System.IO.Directory.CreateDirectory(targetPath);
			}

			// targetPath = ConfigurationManager.AppSettings["Archivo"] + "Cliente " + lbl_id_cliente.Text + "\\" + cbx_anno.Text + "\\" + cbx_id_periodo.Text + "\\";
			targetPath = targetPath + "\\" + cbx_id_periodo.Text + "\\";

			if (!System.IO.Directory.Exists(targetPath))
			{
				System.IO.Directory.CreateDirectory(targetPath);
			}
			//Environment.CurrentDirectory = (targetPath);

			if (rbtOiginal.Checked)
				strpath = dtformato.Tables[0].Rows[0]["Glosa"].ToString() + "cliente.xlsx";//Application.StartupPath.ToString(); 
			else
				strpath = @"C:\\Doc_Xray\\baseCliente\\Plantilla\\cliente.xlsx";



			//**************carga periodo
			DataSet dtPeriodo;
			// SqlCommand cmdPeriodo = new SqlCommand();
			SqlCommand cmdPeriodo = new SqlCommand
			{
				CommandText = "SELECT fecha_inicio,fecha_termino " +
										" FROM conf_periodo " +
										//"where mes =3 and anno=" + cbx_anno.Text;  
										"WHERE  Id_Periodo= " + cbx_id_periodo.SelectedValue,
				CommandType = CommandType.Text
			};
			dtPeriodo = Conectar.Listar(Clases.clsBD.BD, cmdPeriodo);
			string strfecha_inicio = dtPeriodo.Tables[0].Rows[0]["fecha_inicio"].ToString();
			string strfecha_termino = dtPeriodo.Tables[0].Rows[0]["fecha_termino"].ToString();
			//**************carga cliente
			//SqlCommand cmdCliente = new SqlCommand();
			SqlCommand cmdCliente = new SqlCommand
			{
				CommandText = "pa_DosimetroISPGenerar_sel " + cbx_id_periodo.SelectedValue + "," + lbl_id_cliente.Text + "," + cbx_Sucursal.SelectedValue + ",'" + lbl_rut_cliente.Text + "'",

				CommandType = CommandType.Text
			};

			//clsFunc.Cargar_Cliente((int)cbx_id_periodo.SelectedValue, Convert.ToInt64(lbl_id_cliente.Text.ToString()), ref lbl_rut_cliente, ref lbl_nombreCliente);

			DataSet dt;
			DataSet dtCliente;
			dt = Conectar.Listar(Clases.clsBD.BD, cmdCliente);

			string strArchivo = "";
			if (rbtOiginal.Checked)
				strArchivo = dtformato.Tables[0].Rows[0]["Glosa"].ToString() + "Plantillaword.docx";
			else
				strArchivo = @"C:\\Doc_Xray\\baseCliente\\Plantilla\\Plantillaword.docx";


			//   string strArchivo = ConfigurationManager.AppSettings["Archivo"] + "Plantillaword.docx";

			int i;
			for (int idatos = 0; idatos <= dt.Tables[0].Rows.Count - 1; idatos++)
			{
				#region "Proceso"
				i = 0;
				string strRunEmpresa = lbl_rut_cliente.Text;
				string strRazon_SocialEmpresa = lbl_nombreCliente.Text;
				string strDireccionEmpresa = (int)cbx_Sucursal.SelectedValue == 0 ? lbl_nombreCliente.Text : dt.Tables[0].Rows[idatos]["Direccion"].ToString();
				string strDireccionEmpresaSucursal = cbx_Sucursal.Text;
				string strTelefonoEmpresa = dt.Tables[0].Rows[idatos]["Telefono"].ToString();
				string strregionEmpresa = dt.Tables[0].Rows[idatos]["region"].ToString();
				string strProvinciaEmpresa = dt.Tables[0].Rows[idatos]["Provincia"].ToString();
				string strcomunaEmpresa = dt.Tables[0].Rows[idatos]["comuna"].ToString();
				string strSeccion = (int)cbx_id_seccion.SelectedValue == 0 ? "" : cbx_id_seccion.Text;
				//string strN_Documento = dt.Tables[0].Rows[idatos]["N_Documento"].ToString();
				//	string strId_sucursal = dt.Tables[0].Rows[idatos]["Id_sucursal"].ToString();
				String strArchivoCopiar = "";
				strArchivoCopiar = targetPath + "Cliente" + lbl_id_cliente.Text + "_" + strDireccionEmpresa + "_" + cbx_id_periodo.Text.ToString().Substring(0, 1) + "T_" + cbx_anno.Text + "_" + strSeccion + ".docx";


				strpathcopiar = targetPath + "cliente " + lbl_id_cliente.Text + "_" + strDireccionEmpresa + "_" + cbx_id_seccion.Text + ".xlsx";

				// process.Start("c:\Ejemplo de Carpeta con Espacios");
				File.Copy(strpath, strpathcopiar, true);
				//strRunEmpresa + "_" + cbx_id_periodo.Text + ".docx";
				//*************************************


				File.Copy(strArchivo, strArchivoCopiar, true);


				int intfila = 2;

				string[] data1;
				string[] data2;
				string[] data3;
				string[] data4;

				data1 = new string[] { strRazon_SocialEmpresa };
				data2 = new string[] { "" };
				data3 = new string[] { "" };
				data4 = new string[] { "" };

				Array.Resize(ref data1, 2);
				Array.Resize(ref data2, 2);
				Array.Resize(ref data3, 2);
				Array.Resize(ref data4, 2);

				data1[1] = "NOMBRE";
				data2[1] = cbx_id_periodo.Text;
				data3[1] = "N°DOSIMETROS";
				data4[1] = "RUT";

				pnl_Progreso.Visible = true;
				pgb_Barra.Minimum = 0;
				pgb_Barra.Maximum = grdDatos.RowCount;
				pnl_Progreso.Refresh();
				for (int intfilagrid = 0; intfilagrid <= grdDatos.RowCount - 1; intfilagrid++)
				{
					pgb_Barra.Value = i + 1;
					pgb_Barra.Refresh();
					checkGenerar = (DataGridViewCheckBoxCell)grdDatos.Rows[intfilagrid].Cells["Generar"];
					checkCell = (DataGridViewCheckBoxCell)grdDatos.Rows[intfilagrid].Cells["enviado"];
					chkcondosis = (DataGridViewCheckBoxCell)grdDatos.Rows[intfilagrid].Cells["condosis"];
					txtvalor = (DataGridViewTextBoxCell)grdDatos.Rows[intfilagrid].Cells["valor"];
					txtndocumento = (DataGridViewTextBoxCell)grdDatos.Rows[intfilagrid].Cells["NDocumento"];
					txtnpelicula = (DataGridViewTextBoxCell)grdDatos.Rows[intfilagrid].Cells["N_pelicula"];
					txtnpeliculaoriginal = (DataGridViewTextBoxCell)grdDatos.Rows[intfilagrid].Cells["N_TLD_Original"];

					cbxEstado = (DataGridViewComboBoxCell)grdDatos.Rows[intfilagrid].Cells["Estado"];
					txtid_sucursal = (DataGridViewTextBoxCell)grdDatos.Rows[intfilagrid].Cells["id_sucursal"];

					if (cbxEstado.Value.ToString() != "0")
					{
						DataSet dtcombo;
						SqlCommand cmdcombo = new SqlCommand
						{
							CommandText = " " +
							"SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=2 and Id_DetParametro= " + cbxEstado.Value.ToString() +
							"order by orden ",
							CommandType = CommandType.Text
						};
						dtcombo = Conectar.Listar(Clases.clsBD.BD, cmdcombo);
						strEstado = dtcombo.Tables[0].Rows[0]["glosa"].ToString();
					}
					else
						strEstado = "";
					strn_cliente = grdDatos.Rows[intfilagrid].Cells["N_Cliente"].Value.ToString();
					strid_personal = grdDatos.Rows[intfilagrid].Cells["id_personal"].Value.ToString();
					strid_dosimetro = grdDatos.Rows[intfilagrid].Cells["id_dosimetro"].Value.ToString();

					cmdpersonal.CommandText = "SELECT Rut,SUBSTRING(UPPER (Nombres), 1, 1) + SubSTRING (LOWER (Nombres), 2,len(Nombres)) Nombres, " +
										"SUBSTRING(UPPER (Paterno), 1, 1) + SUbSTRING (LOWER (Paterno), 2,len(Paterno)) Paterno," +
										"SUBSTRING(UPPER (Maternos), 1, 1) + SUbSTRING (LOWER (Maternos), 2,len(Maternos))Maternos," +
										"Id_Seccion,p.Id_estado, " +
							 " cd.glosa,profesion,Fecha_inicio,fecha_termino,Usuario,Fecha_agregado,getdate()as Fecha_Modificacion " +
							 " FROM tbl_personal P inner join conf_detparametro cd on p.Id_sexo=cd.Id_DetParametro" +
							 " inner join glo_profesion pro on pro.id_profesion=p.Id_profesion " +
							 " WHERE Id_Personal= " + strid_personal.ToString() + " and id_cliente=" + lbl_id_cliente.Text +
							 "";
					dtCliente = Conectar.Listar(Clases.clsBD.BD, cmdpersonal);

					//if (strId_sucursal == txtid_sucursal.Value.ToString())
					//{
					//}
					#region "Genera  word y excel"
					if (checkGenerar.Value.ToString() == "1")
					{
						//cmd.CommandText = "update tbl_dosimetria " +
						//                      "set enviado=0" +
						//                  " where id_dosimetro=" + strid_dosimetro;
						//cmd.CommandType = CommandType.Text;

						//Conectar.AgregarModificarEliminar(Clases.clsBD.BD,cmd);

						//cmd.CommandText = "pa_DosimetroIngreso_upd " + txtnpelicula.Value.ToString() + ",12,'Clases.clsUsuario.Usuario',''";
						//cmd.CommandType = CommandType.StoredProcedure;
						//Conectar.AgregarModificarEliminar(Clases.clsBD.BD,cmd);
					}
					else
						 if ((txtndocumento.Value.ToString() == "") && (checkGenerar.Value.ToString() == "0"))
					{
						// MessageBox.Show("Ingrese el n° de  Documento");						  
						grdDatos.Rows[i].DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Red;
						//Selected=true ;
						i = grdDatos.RowCount;
					}
					else
					{
						grdDatos.Rows[i].DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
						if ((strid_dosimetro != "0")) //&& (checkGenerar.Value.ToString() == "1")					 
						{
							document = SpreadsheetDocument.Open(strpathcopiar, true);
							wbPart = document.WorkbookPart;
							string wsName = String.Format("{0}{1}", cbx_id_periodo.Text.Substring(0, 1), "ºT");//4ºT//1ºT|
							UpdateValue(wsName, "A" + (intfila).ToString(), dtCliente.Tables[0].Rows[0]["Nombres"].ToString(), 0, true);
							UpdateValue(wsName, "B" + (intfila).ToString(), dtCliente.Tables[0].Rows[0]["Paterno"].ToString(), 0, true);
							UpdateValue(wsName, "C" + (intfila).ToString(), dtCliente.Tables[0].Rows[0]["Maternos"].ToString(), 0, true);
							UpdateValue(wsName, "D" + (intfila).ToString(), dtCliente.Tables[0].Rows[0]["Rut"].ToString(), 0, true);
							UpdateValue(wsName, "E" + (intfila).ToString(), strfecha_inicio.Replace("/", "-"), 0, true);
							UpdateValue(wsName, "F" + (intfila).ToString(), strfecha_termino.Replace("/", "-"), 0, true);

							UpdateValue(wsName, "G" + (intfila).ToString(), txtvalor.Value.ToString(), 0, true);
							UpdateValue(wsName, "H" + (intfila).ToString(), "TRIMESTRAL", 0, true);
							UpdateValue(wsName, "I" + (intfila).ToString(), strEstado, 0, true);
							UpdateValue(wsName, "J" + (intfila).ToString(), "CUERPO ENTERO", 0, true);
							UpdateValue(wsName, "K" + (intfila).ToString(), "FILMICO", 0, true);

							UpdateValue(wsName, "L" + (intfila).ToString(), "3", 0, false);
							UpdateValue(wsName, "M" + (intfila).ToString(), "Rayos X otros", 0, true);
							UpdateValue(wsName, "N" + (intfila).ToString(), "X-RAY", 0, true);

							UpdateValue(wsName, "O" + (intfila).ToString(), dtCliente.Tables[0].Rows[0]["glosa"].ToString(), 0, true);
							UpdateValue(wsName, "P" + (intfila).ToString(), dtCliente.Tables[0].Rows[0]["profesion"].ToString(), 0, true);
							////							  UpdateValue(wsName, "S" + (intfila + 2).ToString(), dtCliente.Tables[0].Rows[0]["telefono"].ToString(), 0, true);
							UpdateValue(wsName, "S" + (intfila).ToString(), strTelefonoEmpresa, 0, true);//telefono
							UpdateValue(wsName, "X" + (intfila).ToString(), dtCliente.Tables[0].Rows[0]["Fecha_inicio"].ToString().Replace("/", "-"), 0, true);
							//°

							UpdateValue(wsName, "Y" + (intfila).ToString(), strRunEmpresa, 0, true);
							UpdateValue(wsName, "Z" + (intfila).ToString(), strRazon_SocialEmpresa, 0, true);

							UpdateValue(wsName, "AA" + (intfila).ToString(), strDireccionEmpresa.ToString(), 0, true);
							UpdateValue(wsName, "AB" + (intfila).ToString(), strcomunaEmpresa, 0, true);
							UpdateValue(wsName, "AC" + (intfila).ToString(), strProvinciaEmpresa, 0, true);
							UpdateValue(wsName, "AD" + (intfila).ToString(), strregionEmpresa, 0, true);
							UpdateValue(wsName, "AE" + (intfila).ToString(), strTelefonoEmpresa, 0, false);
							document.Close();
							cmd.CommandText = "update tbl_dosimetria " +
																"set enviado=1" +
															" where id_dosimetro=" + strid_dosimetro;
							cmd.CommandType = CommandType.Text;

							Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);

							string strParametro = String.Format("{0},{1},{2},''", txtnpeliculaoriginal.Value.ToString(), "5", Clases.clsUsuario.Usuario);
							cmd.CommandText = "pa_DosimetroIngresoTLD_upd " + strParametro;
							cmd.CommandType = CommandType.Text;
							Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);

							Array.Resize(ref data1, i + 3);
							Array.Resize(ref data2, i + 3);
							Array.Resize(ref data3, i + 3);
							Array.Resize(ref data4, i + 3);

							data1[i + 2] = dtCliente.Tables[0].Rows[0]["Nombres"].ToString() + " " + dtCliente.Tables[0].Rows[0]["Paterno"].ToString() + " " + dtCliente.Tables[0].Rows[0]["Maternos"].ToString();
							if (chkcondosis.Value.ToString() == "0")
								data2[i + 2] = strEstado;
							else
								data2[i + 2] = txtvalor.Value.ToString();
							data3[i + 2] = txtnpelicula.Value.ToString();
							data4[i + 2] = dtCliente.Tables[0].Rows[0]["Rut"].ToString();
							// this.p

							intfila = intfila + 1;
							i = i + 1;
						}

					}



					#endregion

				}
				#region Update Document Bookmarks Openxml
				strcampoMarcador = "empresa";

				using (WordprocessingDocument doc = WordprocessingDocument.Open(strArchivoCopiar, true))
				{
					string strSemetre1 = "";
					if (cbx_id_periodo.Text.Substring(0, 1) == "1")
						strSemetre1 = "primer";
					if (cbx_id_periodo.Text.Substring(0, 1) == "2")
						strSemetre1 = "segundo";
					if (cbx_id_periodo.Text.Substring(0, 1) == "3")
						strSemetre1 = "tercer";
					if (cbx_id_periodo.Text.Substring(0, 1) == "4")
						strSemetre1 = "cuarto";

					strcampoMarcador = "empresa";
					BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), strRazon_SocialEmpresa);
					strcampoMarcador = "comuna";
					BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), strcomunaEmpresa);
					strcampoMarcador = "anno";
					BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), cbx_anno.Text);
					strcampoMarcador = "semestre";
					BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), strSemetre1);




				}
				if (data1.Count() > 1)
					WDAddTable(strArchivoCopiar, data1, data2, data3, data4);

				#endregion
				#endregion
			}



			MessageBox.Show("Informacion grabada y archivo generado \n Ubicación Archivo:" + targetPath);

			btnGenerar.Enabled = true;
			pnl_Progreso.Visible = false;

			Listar_Personal();
		}
		private void GenerarPorSucursalTodos()
		{
			SqlCommand cmd = new SqlCommand();
			//	  SqlCommand cmd = new SqlCommand();
			SqlCommand cmdpersonal = new SqlCommand();
			//  SqlCommand cmdpersonal = new SqlCommand();
			SqlCommand cmdperiodo = new SqlCommand();
			//  SqlCommand cmdperiodo = new SqlCommand();

			// dtcombo = Conectar.Listar(Clases.clsBD.BD,cmdcombo);
			DataGridViewCheckBoxCell checkGenerar;
			DataGridViewCheckBoxCell checkCell;
			DataGridViewCheckBoxCell chkcondosis;
			DataGridViewTextBoxCell txtvalor;
			DataGridViewTextBoxCell txtndocumento;
			DataGridViewTextBoxCell txtnpelicula;
			DataGridViewTextBoxCell txtnpeliculaoriginal;
			DataGridViewComboBoxCell cbxEstado;
			DataGridViewTextBoxCell txtid_sucursal;
			string strn_cliente;
			string strid_personal;
			string strid_dosimetro;
			string strpath;
			string strpathcopiar;
			string strEstado;
			btnGenerar.Enabled = false;

			SqlCommand cmdArchivo = new SqlCommand();
			DataSet dtArchivo;
			cmdArchivo.CommandText = "" +
				"SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=6 order by orden ";
			cmdArchivo.CommandType = CommandType.Text;
			dtArchivo = Conectar.Listar(Clases.clsBD.BD, cmdArchivo);

			DataSet dtformato;
			cmdArchivo.CommandText = "" +
				"SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=5 order by orden ";
			cmdArchivo.CommandType = CommandType.Text;
			dtformato = Conectar.Listar(Clases.clsBD.BD, cmdArchivo);
			//string targetPath = @ConfigurationManager.AppSettings["Archivo"] + "Cliente " + lbl_id_cliente.Text;
			string targetPath = "";

			if (rbtOiginal.Checked)
				targetPath = @dtArchivo.Tables[0].Rows[0]["Glosa"].ToString() + "Cliente " + lbl_id_cliente.Text;
			else
				targetPath = @"C:\\Doc_Xray\\" + "Cliente " + lbl_id_cliente.Text;

			try
			{
				if (!System.IO.Directory.Exists(targetPath))
				{
					System.IO.Directory.CreateDirectory(targetPath);
				}
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
				return;
			}




			//  targetPath = dtArchivo.Tables[0].Rows[0]["Glosa"].ToString();


			// targetPath = ConfigurationManager.AppSettings["Archivo"] + "Cliente " + lbl_id_cliente.Text + "\\" + cbx_anno.Text;
			targetPath = targetPath + "\\" + cbx_anno.Text;
			if (!System.IO.Directory.Exists(targetPath))
			{
				System.IO.Directory.CreateDirectory(targetPath);
			}

			// targetPath = ConfigurationManager.AppSettings["Archivo"] + "Cliente " + lbl_id_cliente.Text + "\\" + cbx_anno.Text + "\\" + cbx_id_periodo.Text + "\\";
			targetPath = targetPath + "\\" + cbx_id_periodo.Text + "\\";

			if (!System.IO.Directory.Exists(targetPath))
			{
				System.IO.Directory.CreateDirectory(targetPath);
			}
			//Environment.CurrentDirectory = (targetPath);

			if (rbtOiginal.Checked)
				strpath = dtformato.Tables[0].Rows[0]["Glosa"].ToString() + "cliente.xlsx";//Application.StartupPath.ToString(); 
			else
				strpath = @"C:\\Doc_Xray\\baseCliente\\Plantilla\\cliente.xlsx";



			//**************carga periodo
			DataSet dtPeriodo;
			// SqlCommand cmdPeriodo = new SqlCommand();
			SqlCommand cmdPeriodo = new SqlCommand
			{
				CommandText = "SELECT fecha_inicio,fecha_termino " +
										" FROM conf_periodo " +
										//"where mes =3 and anno=" + cbx_anno.Text;  
										"WHERE  Id_Periodo= " + cbx_id_periodo.SelectedValue,
				CommandType = CommandType.Text
			};
			dtPeriodo = Conectar.Listar(Clases.clsBD.BD, cmdPeriodo);
			string strfecha_inicio = dtPeriodo.Tables[0].Rows[0]["fecha_inicio"].ToString();
			string strfecha_termino = dtPeriodo.Tables[0].Rows[0]["fecha_termino"].ToString();
			//**************carga cliente
			//SqlCommand cmdCliente = new SqlCommand();
			SqlCommand cmdCliente = new SqlCommand
			{
				CommandText = "pa_DosimetroISPGenerar_sel " + cbx_id_periodo.SelectedValue + "," + lbl_id_cliente.Text + "," + cbx_Sucursal.SelectedValue + ",'" + lbl_rut_cliente.Text + "'",

				CommandType = CommandType.Text
			};

			//clsFunc.Cargar_Cliente((int)cbx_id_periodo.SelectedValue, Convert.ToInt64(lbl_id_cliente.Text.ToString()), ref lbl_rut_cliente, ref lbl_nombreCliente);

			DataSet dt;
			DataSet dtCliente;
			dt = Conectar.Listar(Clases.clsBD.BD, cmdCliente);

			string strArchivo = "";
			if (rbtOiginal.Checked)
				strArchivo = dtformato.Tables[0].Rows[0]["Glosa"].ToString() + "Plantillaword.docx";
			else
				strArchivo = @"C:\\Doc_Xray\\baseCliente\\Plantilla\\Plantillaword.docx";


			//   string strArchivo = ConfigurationManager.AppSettings["Archivo"] + "Plantillaword.docx";

			int i;
			for (int idatos = 0; idatos <= dt.Tables[0].Rows.Count - 1; idatos++)
			{
				#region "Proceso"
				i = 0;
				string strRunEmpresa = lbl_rut_cliente.Text;
				string strRazon_SocialEmpresa = lbl_nombreCliente.Text;
				string strDireccionEmpresa = (int)cbx_Sucursal.SelectedValue == 0 ? lbl_nombreCliente.Text : dt.Tables[0].Rows[idatos]["Direccion"].ToString();
				string strTelefonoEmpresa = dt.Tables[0].Rows[idatos]["Telefono"].ToString();
				string strregionEmpresa = dt.Tables[0].Rows[idatos]["region"].ToString();
				string strProvinciaEmpresa = dt.Tables[0].Rows[idatos]["Provincia"].ToString();
				string strcomunaEmpresa = dt.Tables[0].Rows[idatos]["comuna"].ToString();
				string strSeccion = (int)cbx_id_seccion.SelectedValue == 0 ? "" : cbx_id_seccion.Text;
				//string strN_Documento = dt.Tables[0].Rows[idatos]["N_Documento"].ToString();
				//	string strId_sucursal = dt.Tables[0].Rows[idatos]["Id_sucursal"].ToString();
				String strArchivoCopiar = "";
				strArchivoCopiar = targetPath + "Cliente" + lbl_id_cliente.Text + "_" + strDireccionEmpresa + "_" + cbx_id_periodo.Text.ToString().Substring(0, 1) + "T_" + cbx_anno.Text + "_" + strSeccion + ".docx";


				strpathcopiar = targetPath + "cliente " + lbl_id_cliente.Text + "_" + strDireccionEmpresa + "_" + cbx_id_seccion.Text + ".xlsx";

				// process.Start("c:\Ejemplo de Carpeta con Espacios");
				File.Copy(strpath, strpathcopiar, true);
				//strRunEmpresa + "_" + cbx_id_periodo.Text + ".docx";
				//*************************************


				File.Copy(strArchivo, strArchivoCopiar, true);


				int intfila = 2;

				string[] data1;
				string[] data2;
				string[] data3;
				string[] data4;

				data1 = new string[] { strRazon_SocialEmpresa };
				data2 = new string[] { "" };
				data3 = new string[] { "" };
				data4 = new string[] { "" };

				Array.Resize(ref data1, 2);
				Array.Resize(ref data2, 2);
				Array.Resize(ref data3, 2);
				Array.Resize(ref data4, 2);

				data1[1] = "NOMBRE";
				data2[1] = cbx_id_periodo.Text;
				data3[1] = "N°DOSIMETROS";
				data4[1] = "RUT";

				pnl_Progreso.Visible = true;
				pgb_Barra.Minimum = 0;
				pgb_Barra.Maximum = grdDatos.RowCount;
				pnl_Progreso.Refresh();
				for (int intfilagrid = 0; intfilagrid <= grdDatos.RowCount - 1; intfilagrid++)
				{
					pgb_Barra.Value = i + 1;
					pgb_Barra.Refresh();
					checkGenerar = (DataGridViewCheckBoxCell)grdDatos.Rows[intfilagrid].Cells["Generar"];
					checkCell = (DataGridViewCheckBoxCell)grdDatos.Rows[intfilagrid].Cells["enviado"];
					chkcondosis = (DataGridViewCheckBoxCell)grdDatos.Rows[intfilagrid].Cells["condosis"];
					txtvalor = (DataGridViewTextBoxCell)grdDatos.Rows[intfilagrid].Cells["valor"];
					txtndocumento = (DataGridViewTextBoxCell)grdDatos.Rows[intfilagrid].Cells["NDocumento"];
					txtnpelicula = (DataGridViewTextBoxCell)grdDatos.Rows[intfilagrid].Cells["n_pelicula"];
					txtnpeliculaoriginal = (DataGridViewTextBoxCell)grdDatos.Rows[intfilagrid].Cells["N_TLD_Original"];
					cbxEstado = (DataGridViewComboBoxCell)grdDatos.Rows[intfilagrid].Cells["Estado"];
					txtid_sucursal = (DataGridViewTextBoxCell)grdDatos.Rows[intfilagrid].Cells["id_sucursal"];

					if (cbxEstado.Value.ToString() != "0")
					{
						DataSet dtcombo;
						SqlCommand cmdcombo = new SqlCommand
						{
							CommandText = " " +
							"SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=2 and Id_DetParametro= " + cbxEstado.Value.ToString() +
							"order by orden ",
							CommandType = CommandType.Text
						};
						dtcombo = Conectar.Listar(Clases.clsBD.BD, cmdcombo);
						strEstado = dtcombo.Tables[0].Rows[0]["glosa"].ToString();
					}
					else
						strEstado = "";
					strn_cliente = grdDatos.Rows[intfilagrid].Cells["N_Cliente"].Value.ToString();
					strid_personal = grdDatos.Rows[intfilagrid].Cells["id_personal"].Value.ToString();
					strid_dosimetro = grdDatos.Rows[intfilagrid].Cells["id_dosimetro"].Value.ToString();

					cmdpersonal.CommandText = "SELECT Rut,SUBSTRING(UPPER (Nombres), 1, 1) + SubSTRING (LOWER (Nombres), 2,len(Nombres)) Nombres, " +
										"SUBSTRING(UPPER (Paterno), 1, 1) + SUbSTRING (LOWER (Paterno), 2,len(Paterno)) Paterno," +
										"SUBSTRING(UPPER (Maternos), 1, 1) + SUbSTRING (LOWER (Maternos), 2,len(Maternos))Maternos," +
										"Id_Seccion,p.Id_estado, " +
							 " cd.glosa,profesion,Fecha_inicio,fecha_termino,Usuario,Fecha_agregado,getdate()as Fecha_Modificacion " +
							 " FROM tbl_personal P inner join conf_detparametro cd on p.Id_sexo=cd.Id_DetParametro" +
							 " inner join glo_profesion pro on pro.id_profesion=p.Id_profesion " +
							 " WHERE Id_Personal= " + strid_personal.ToString() + " and id_cliente=" + lbl_id_cliente.Text +
							 "";
					dtCliente = Conectar.Listar(Clases.clsBD.BD, cmdpersonal);

					//if (strId_sucursal == txtid_sucursal.Value.ToString())
					//{
					//}
					#region "Genera  word y excel"
					if (checkGenerar.Value.ToString() == "1")
					{
						//cmd.CommandText = "update tbl_dosimetria " +
						//                      "set enviado=0" +
						//                  " where id_dosimetro=" + strid_dosimetro;
						//cmd.CommandType = CommandType.Text;

						//Conectar.AgregarModificarEliminar(Clases.clsBD.BD,cmd);

						//cmd.CommandText = "pa_DosimetroIngreso_upd " + txtnpelicula.Value.ToString() + ",12,'Clases.clsUsuario.Usuario',''";
						//cmd.CommandType = CommandType.StoredProcedure;
						//Conectar.AgregarModificarEliminar(Clases.clsBD.BD,cmd);
					}
					else
						 if ((txtndocumento.Value.ToString() == "") && (checkGenerar.Value.ToString() == "0"))
					{
						// MessageBox.Show("Ingrese el n° de  Documento");						  
						grdDatos.Rows[i].DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Red;
						//Selected=true ;
						i = grdDatos.RowCount;
					}
					else
					{
						grdDatos.Rows[i].DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
						if ((strid_dosimetro != "0")) //&& (checkGenerar.Value.ToString() == "1")					 
						{
							document = SpreadsheetDocument.Open(strpathcopiar, true);
							wbPart = document.WorkbookPart;
							string wsName = String.Format("{0}{1}", cbx_id_periodo.Text.Substring(0, 1), "ºT");//4ºT//1ºT|
							UpdateValue(wsName, "A" + (intfila).ToString(), dtCliente.Tables[0].Rows[0]["Nombres"].ToString(), 0, true);
							UpdateValue(wsName, "B" + (intfila).ToString(), dtCliente.Tables[0].Rows[0]["Paterno"].ToString(), 0, true);
							UpdateValue(wsName, "C" + (intfila).ToString(), dtCliente.Tables[0].Rows[0]["Maternos"].ToString(), 0, true);
							UpdateValue(wsName, "D" + (intfila).ToString(), dtCliente.Tables[0].Rows[0]["Rut"].ToString(), 0, true);
							UpdateValue(wsName, "E" + (intfila).ToString(), strfecha_inicio.Replace("/", "-"), 0, true);
							UpdateValue(wsName, "F" + (intfila).ToString(), strfecha_termino.Replace("/", "-"), 0, true);

							UpdateValue(wsName, "G" + (intfila).ToString(), txtvalor.Value.ToString(), 0, true);
							UpdateValue(wsName, "H" + (intfila).ToString(), "TRIMESTRAL", 0, true);
							UpdateValue(wsName, "I" + (intfila).ToString(), strEstado, 0, true);
							UpdateValue(wsName, "J" + (intfila).ToString(), "CUERPO ENTERO", 0, true);
							UpdateValue(wsName, "K" + (intfila).ToString(), "FILMICO", 0, true);

							UpdateValue(wsName, "L" + (intfila).ToString(), "3", 0, false);
							UpdateValue(wsName, "M" + (intfila).ToString(), "Rayos X otros", 0, true);
							UpdateValue(wsName, "N" + (intfila).ToString(), "X-RAY", 0, true);

							UpdateValue(wsName, "O" + (intfila).ToString(), dtCliente.Tables[0].Rows[0]["glosa"].ToString(), 0, true);
							UpdateValue(wsName, "P" + (intfila).ToString(), dtCliente.Tables[0].Rows[0]["profesion"].ToString(), 0, true);
							////							  UpdateValue(wsName, "S" + (intfila + 2).ToString(), dtCliente.Tables[0].Rows[0]["telefono"].ToString(), 0, true);
							UpdateValue(wsName, "S" + (intfila).ToString(), strTelefonoEmpresa, 0, true);//telefono
							UpdateValue(wsName, "X" + (intfila).ToString(), dtCliente.Tables[0].Rows[0]["Fecha_inicio"].ToString().Replace("/", "-"), 0, true);
							//°

							UpdateValue(wsName, "Y" + (intfila).ToString(), strRunEmpresa, 0, true);
							UpdateValue(wsName, "Z" + (intfila).ToString(), strRazon_SocialEmpresa, 0, true);

							UpdateValue(wsName, "AA" + (intfila).ToString(), strDireccionEmpresa.ToString(), 0, true);
							UpdateValue(wsName, "AB" + (intfila).ToString(), strcomunaEmpresa, 0, true);
							UpdateValue(wsName, "AC" + (intfila).ToString(), strProvinciaEmpresa, 0, true);
							UpdateValue(wsName, "AD" + (intfila).ToString(), strregionEmpresa, 0, true);
							UpdateValue(wsName, "AE" + (intfila).ToString(), strTelefonoEmpresa, 0, false);
							document.Close();
							cmd.CommandText = "update tbl_dosimetria " +
																"set enviado=1" +
															" where id_dosimetro=" + strid_dosimetro;
							cmd.CommandType = CommandType.Text;

							Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);

							string strParametro = String.Format("{0},{1},{2},''", txtnpeliculaoriginal.Value.ToString(), "5", Clases.clsUsuario.Usuario);
							cmd.CommandText = "pa_DosimetroIngresoTLD_upd " + strParametro;
							cmd.CommandType = CommandType.Text;
							Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);

							Array.Resize(ref data1, i + 3);
							Array.Resize(ref data2, i + 3);
							Array.Resize(ref data3, i + 3);
							Array.Resize(ref data4, i + 3);

							data1[i + 2] = dtCliente.Tables[0].Rows[0]["Nombres"].ToString() + " " + dtCliente.Tables[0].Rows[0]["Paterno"].ToString() + " " + dtCliente.Tables[0].Rows[0]["Maternos"].ToString();
							if (chkcondosis.Value.ToString() == "0")
								data2[i + 2] = strEstado;
							else
								data2[i + 2] = txtvalor.Value.ToString();
							data3[i + 2] = txtnpelicula.Value.ToString();
							data4[i + 2] = dtCliente.Tables[0].Rows[0]["Rut"].ToString();
							// this.p

							intfila = intfila + 1;
							i = i + 1;
						}

					}



					#endregion

				}
				#region Update Document Bookmarks Openxml
				strcampoMarcador = "empresa";

				using (WordprocessingDocument doc = WordprocessingDocument.Open(strArchivoCopiar, true))
				{
					string strSemetre1 = "";
					if (cbx_id_periodo.Text.Substring(0, 1) == "1")
						strSemetre1 = "primer";
					if (cbx_id_periodo.Text.Substring(0, 1) == "2")
						strSemetre1 = "segundo";
					if (cbx_id_periodo.Text.Substring(0, 1) == "3")
						strSemetre1 = "tercer";
					if (cbx_id_periodo.Text.Substring(0, 1) == "4")
						strSemetre1 = "cuarto";

					strcampoMarcador = "empresa";
					BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), strRazon_SocialEmpresa);
					strcampoMarcador = "comuna";
					BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), strcomunaEmpresa);
					strcampoMarcador = "anno";
					BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), cbx_anno.Text);
					strcampoMarcador = "semestre";
					BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), strSemetre1);




				}
				if (data1.Count() > 1)
					WDAddTable(strArchivoCopiar, data1, data2, data3, data4);

				#endregion
				#endregion
			}



			lblRuta.Text = "Informacion grabada y archivo generado \n Ubicación Archivo:" + targetPath;

			btnGenerar.Enabled = true;
			pnl_Progreso.Visible = false;

			//	Listar_Personal();
		}

		#endregion

		#region "button"
		private void btnGenerarArchivoNuevo_Click(object sender, EventArgs e)
		{
			if ((int)cbx_id_seccion.SelectedValue != 0)
			{
				lblRuta.Visible = false;
				GenerarPorSucursalV2();
			}

			else
			{
				lblRuta.Visible = true;
				lblRuta.Text = "";
				Generar_TodosV2();
				btnGenerar.Enabled = true;
			}
		}
		private void tsbAsignarSucursal_Click(object sender, EventArgs e)
		{
			if (!String.IsNullOrWhiteSpace(lbl_id_cliente.Text))
			{
				frmAsignarDireccionPersonal frm = new frmAsignarDireccionPersonal(Convert.ToInt32(lbl_id_cliente.Text), lbl_rut_cliente.Text);
				frm.ShowDialog(this);
			}

		}

		private void tsbAsignarSeccion_Click(object sender, EventArgs e)
		{
			if (!String.IsNullOrWhiteSpace(lbl_id_cliente.Text))
			{
				frmAsignarSeccionPersonal frm = new frmAsignarSeccionPersonal(Convert.ToInt32(lbl_id_cliente.Text), lbl_rut_cliente.Text);
				frm.ShowDialog(this);
			}
		}

		private void Btn_Sucursal_Click(object sender, EventArgs e)
		{
			frmBusquedaSucursal frm = new frmBusquedaSucursal(0);
			frm.ShowDialog(this);
		}

		private void Btn_CargarCli_Click(object sender, EventArgs e)
		{
			if (!String.IsNullOrWhiteSpace(lbl_id_cliente.Text))
				Cargar_Cliente(Convert.ToInt64(lbl_id_cliente.Text));
		}

		private void Btn_Filtro_Click(object sender, EventArgs e)
		{
			//txt_ref_cliente.ReadOnly = false;
			//txt_Rut.ReadOnly = false;
			//txt_ref_cliente.Text = "";
			//txt_Rut.Text = "";
			//txt_RazonSocial.Text = "";
			//Listar_Cliente(0);
			//Listar_Personal();
			//txt_ref_cliente.Focus();
		}

		private void Btn_cargar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			bolDesdeCodigo = true;
			//Cargar_Sucursal();
			//Cargar_Seccion();
			bolDesdeCodigo = false;
			Listar_Personal();

			Cursor = Cursors.Default;
			grdDatos.Focus();
		}

		String RutaArchivo()
		{
			SqlCommand cmdArchivo = new SqlCommand();
			DataSet dtArchivo;
			cmdArchivo.CommandText = "" +
				"SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=6 order by orden ";
			cmdArchivo.CommandType = CommandType.Text;
			dtArchivo = Conectar.Listar(Clases.clsBD.BD, cmdArchivo);
			//string targetPath = @ConfigurationManager.AppSettings["Archivo"] + "Cliente " + lbl_id_cliente.Text;
			return dtArchivo.Tables[0].Rows[0]["Glosa"].ToString();
		}

		private void btnGenerar_Click(object sender, EventArgs e)
		{
			if ((int)cbx_id_seccion.SelectedValue != 0)
			{
				lblRuta.Visible = false;
				GenerarPorSucursal();
			}

			else
			{
				lblRuta.Visible = true;
				lblRuta.Text = "";
				Generar_Todos();
				btnGenerar.Enabled = true;
			}

		}

		private void Btn_Guardar_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand();
			//	  SqlCommand cmd = new SqlCommand();
			SqlCommand cmdpersonal = new SqlCommand();
			//  SqlCommand cmdpersonal = new SqlCommand();
			SqlCommand cmdperiodo = new SqlCommand();
			//  SqlCommand cmdperiodo = new SqlCommand();

			// dtcombo = Conectar.Listar(Clases.clsBD.BD,cmdcombo);
			DataGridViewCheckBoxCell checkGenerar;
			DataGridViewCheckBoxCell checkCell;
			DataGridViewCheckBoxCell chkcondosis;
			DataGridViewTextBoxCell txtvalor;
			DataGridViewTextBoxCell txtndocumento;
			DataGridViewTextBoxCell txtnpelicula;
			DataGridViewComboBoxCell cbxEstado;
			DataGridViewTextBoxCell txtid_sucursal;
			string strn_cliente;
			string strid_personal;
			string strid_dosimetro;
			string strpath;
			string strpathcopiar;
			string strEstado;
			btnGenerar.Enabled = false;

			SqlCommand cmdArchivo = new SqlCommand();
			DataSet dtArchivo;
			cmdArchivo.CommandText = "" +
				"SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=6 order by orden ";
			cmdArchivo.CommandType = CommandType.Text;
			dtArchivo = Conectar.Listar(Clases.clsBD.BD, cmdArchivo);

			DataSet dtformato;
			cmdArchivo.CommandText = "" +
				"SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=5 order by orden ";
			cmdArchivo.CommandType = CommandType.Text;
			dtformato = Conectar.Listar(Clases.clsBD.BD, cmdArchivo);
			//string targetPath = @ConfigurationManager.AppSettings["Archivo"] + "Cliente " + lbl_id_cliente.Text;
			string targetPath = "";

			if (rbtOiginal.Checked)
				targetPath = @dtArchivo.Tables[0].Rows[0]["Glosa"].ToString() + "Cliente " + lbl_id_cliente.Text;
			else
				targetPath = @"C:\\Doc_Xray\\" + "Cliente " + lbl_id_cliente.Text;


			if (!System.IO.Directory.Exists(targetPath))
			{
				System.IO.Directory.CreateDirectory(targetPath);
			}



			//  targetPath = dtArchivo.Tables[0].Rows[0]["Glosa"].ToString();


			// targetPath = ConfigurationManager.AppSettings["Archivo"] + "Cliente " + lbl_id_cliente.Text + "\\" + cbx_anno.Text;
			targetPath = targetPath + "\\" + cbx_anno.Text;
			if (!System.IO.Directory.Exists(targetPath))
			{
				System.IO.Directory.CreateDirectory(targetPath);
			}

			// targetPath = ConfigurationManager.AppSettings["Archivo"] + "Cliente " + lbl_id_cliente.Text + "\\" + cbx_anno.Text + "\\" + cbx_id_periodo.Text + "\\";
			targetPath = targetPath + "\\" + cbx_id_periodo.Text + "\\";

			if (!System.IO.Directory.Exists(targetPath))
			{
				System.IO.Directory.CreateDirectory(targetPath);
			}
			//Environment.CurrentDirectory = (targetPath);

			if (rbtOiginal.Checked)
				strpath = dtformato.Tables[0].Rows[0]["Glosa"].ToString() + "cliente.xlsx";//Application.StartupPath.ToString(); 
			else
				strpath = @"C:\\Doc_Xray\\baseCliente\\Plantilla\\cliente.xlsx";



			//**************carga periodo
			DataSet dtPeriodo;
			// SqlCommand cmdPeriodo = new SqlCommand();
			SqlCommand cmdPeriodo = new SqlCommand
			{
				CommandText = "SELECT fecha_inicio,fecha_termino " +
										" FROM conf_periodo " +
										//"where mes =3 and anno=" + cbx_anno.Text;  
										"WHERE  Id_Periodo= " + cbx_id_periodo.SelectedValue,
				CommandType = CommandType.Text
			};
			dtPeriodo = Conectar.Listar(Clases.clsBD.BD, cmdPeriodo);
			string strfecha_inicio = dtPeriodo.Tables[0].Rows[0]["fecha_inicio"].ToString();
			string strfecha_termino = dtPeriodo.Tables[0].Rows[0]["fecha_termino"].ToString();
			//**************carga cliente
			//SqlCommand cmdCliente = new SqlCommand();
			SqlCommand cmdCliente = new SqlCommand
			{
				CommandText = "pa_DosimetroISPGenerar_sel " + cbx_id_periodo.SelectedValue + "," + lbl_id_cliente.Text + "," + cbx_Sucursal.SelectedValue,

				CommandType = CommandType.Text
			};

			//clsFunc.Cargar_Cliente((int)cbx_id_periodo.SelectedValue, Convert.ToInt64(lbl_id_cliente.Text.ToString()), ref lbl_rut_cliente, ref lbl_nombreCliente);

			DataSet dt;
			DataSet dtCliente;
			dt = Conectar.Listar(Clases.clsBD.BD, cmdCliente);

			string strArchivo = "";
			if (rbtOiginal.Checked)
				strArchivo = dtformato.Tables[0].Rows[0]["Glosa"].ToString() + "Plantillaword.docx";
			else
				strArchivo = @"C:\\Doc_Xray\\baseCliente\\Plantilla\\Plantillaword.docx";


			//   string strArchivo = ConfigurationManager.AppSettings["Archivo"] + "Plantillaword.docx";

			int i;
			for (int idatos = 0; idatos <= dt.Tables[0].Rows.Count - 1; idatos++)
			{
				#region "Proceso"
				i = 0;
				string strRunEmpresa = dt.Tables[0].Rows[idatos]["run"].ToString();
				string strRazon_SocialEmpresa = dt.Tables[0].Rows[idatos]["Razon_Social"].ToString();
				string strDireccionEmpresa = dt.Tables[0].Rows[idatos]["Direccion"].ToString();
				string strTelefonoEmpresa = dt.Tables[0].Rows[idatos]["Telefono"].ToString();
				string strregionEmpresa = dt.Tables[0].Rows[idatos]["region"].ToString();
				string strProvinciaEmpresa = dt.Tables[0].Rows[idatos]["Provincia"].ToString();
				string strcomunaEmpresa = dt.Tables[0].Rows[idatos]["comuna"].ToString();
				//string strN_Documento = dt.Tables[0].Rows[idatos]["N_Documento"].ToString();
				string strId_sucursal = dt.Tables[0].Rows[idatos]["Id_sucursal"].ToString();
				String strArchivoCopiar = "";
				strArchivoCopiar = targetPath + "Cliente" + lbl_id_cliente.Text + "_" + strDireccionEmpresa + "_" + cbx_id_periodo.Text.ToString().Substring(0, 1) + "T_" + cbx_anno.Text + "_" + cbx_id_seccion.Text + ".docx";


				strpathcopiar = targetPath + "cliente " + lbl_id_cliente.Text + "_" + strDireccionEmpresa + "_" + cbx_id_seccion.Text + ".xlsx";

				// process.Start("c:\Ejemplo de Carpeta con Espacios");
				File.Copy(strpath, strpathcopiar, true);
				//strRunEmpresa + "_" + cbx_id_periodo.Text + ".docx";
				//*************************************


				File.Copy(strArchivo, strArchivoCopiar, true);


				int intfila = 2;

				string[] data1;
				string[] data2;
				string[] data3;
				string[] data4;

				data1 = new string[] { strRazon_SocialEmpresa };
				data2 = new string[] { "" };
				data3 = new string[] { "" };
				data4 = new string[] { "" };

				Array.Resize(ref data1, 2);
				Array.Resize(ref data2, 2);
				Array.Resize(ref data3, 2);
				Array.Resize(ref data4, 2);

				data1[1] = "NOMBRE";
				data2[1] = cbx_id_periodo.Text;
				data3[1] = "N°DOSIMETROS";
				data4[1] = "RUT";

				pnl_Progreso.Visible = true;
				pgb_Barra.Minimum = 0;
				pgb_Barra.Maximum = grdDatos.RowCount;
				pnl_Progreso.Refresh();
				for (int intfilagrid = 0; intfilagrid <= grdDatos.RowCount - 1; intfilagrid++)
				{
					pgb_Barra.Value = i + 1;
					pgb_Barra.Refresh();
					checkGenerar = (DataGridViewCheckBoxCell)grdDatos.Rows[intfilagrid].Cells["Generar"];
					checkCell = (DataGridViewCheckBoxCell)grdDatos.Rows[intfilagrid].Cells["enviado"];
					chkcondosis = (DataGridViewCheckBoxCell)grdDatos.Rows[intfilagrid].Cells["condosis"];
					txtvalor = (DataGridViewTextBoxCell)grdDatos.Rows[intfilagrid].Cells["valor"];
					txtndocumento = (DataGridViewTextBoxCell)grdDatos.Rows[intfilagrid].Cells["NDocumento"];
					txtnpelicula = (DataGridViewTextBoxCell)grdDatos.Rows[intfilagrid].Cells["n_pelicula"];
					cbxEstado = (DataGridViewComboBoxCell)grdDatos.Rows[intfilagrid].Cells["Estado"];
					txtid_sucursal = (DataGridViewTextBoxCell)grdDatos.Rows[intfilagrid].Cells["id_sucursal"];

					if (cbxEstado.Value.ToString() != "0")
					{
						DataSet dtcombo;
						SqlCommand cmdcombo = new SqlCommand
						{
							CommandText = " " +
							"SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=2 and Id_DetParametro= " + cbxEstado.Value.ToString() +
							"order by orden ",
							CommandType = CommandType.Text
						};
						dtcombo = Conectar.Listar(Clases.clsBD.BD, cmdcombo);
						strEstado = dtcombo.Tables[0].Rows[0]["glosa"].ToString();
					}
					else
						strEstado = "";
					strn_cliente = grdDatos.Rows[intfilagrid].Cells["N_Cliente"].Value.ToString();
					strid_personal = grdDatos.Rows[intfilagrid].Cells["id_personal"].Value.ToString();
					strid_dosimetro = grdDatos.Rows[intfilagrid].Cells["id_dosimetro"].Value.ToString();

					cmdpersonal.CommandText = "SELECT Rut,SUBSTRING(UPPER (Nombres), 1, 1) + SubSTRING (LOWER (Nombres), 2,len(Nombres)) Nombres, " +
										"SUBSTRING(UPPER (Paterno), 1, 1) + SUbSTRING (LOWER (Paterno), 2,len(Paterno)) Paterno," +
										"SUBSTRING(UPPER (Maternos), 1, 1) + SUbSTRING (LOWER (Maternos), 2,len(Maternos))Maternos," +
										"Id_Seccion,p.Id_estado, " +
							 " cd.glosa,profesion,Fecha_inicio,fecha_termino,Usuario,Fecha_agregado,getdate()as Fecha_Modificacion " +
							 " FROM tbl_personal P inner join conf_detparametro cd on p.Id_sexo=cd.Id_DetParametro" +
							 " inner join glo_profesion pro on pro.id_profesion=p.Id_profesion " +
							 " WHERE Id_Personal= " + strid_personal.ToString() + " and id_cliente=" + lbl_id_cliente.Text +
							 "";
					dtCliente = Conectar.Listar(Clases.clsBD.BD, cmdpersonal);

					if (strId_sucursal == txtid_sucursal.Value.ToString())
					{
						#region "Genera  word y excel"
						if (checkGenerar.Value.ToString() == "1")
						{
							//cmd.CommandText = "update tbl_dosimetria " +
							//                      "set enviado=0" +
							//                  " where id_dosimetro=" + strid_dosimetro;
							//cmd.CommandType = CommandType.Text;

							//Conectar.AgregarModificarEliminar(Clases.clsBD.BD,cmd);

							//cmd.CommandText = "pa_DosimetroIngreso_upd " + txtnpelicula.Value.ToString() + ",12,'Clases.clsUsuario.Usuario',''";
							//cmd.CommandType = CommandType.StoredProcedure;
							//Conectar.AgregarModificarEliminar(Clases.clsBD.BD,cmd);
						}
						else
							 if ((txtndocumento.Value.ToString() == "") && (checkGenerar.Value.ToString() == "0"))
						{
							// MessageBox.Show("Ingrese el n° de  Documento");						  
							grdDatos.Rows[i].DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Red;
							//Selected=true ;
							i = grdDatos.RowCount;
						}
						else
						{
							grdDatos.Rows[i].DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
							if ((strid_dosimetro != "0")) //&& (checkGenerar.Value.ToString() == "1")					 
							{
								document = SpreadsheetDocument.Open(strpathcopiar, true);
								wbPart = document.WorkbookPart;
								string wsName = cbx_id_periodo.Text.Replace(" ", "").Replace("RI", "");//4ºT//1ºT|
								UpdateValue(wsName, "A" + (intfila).ToString(), dtCliente.Tables[0].Rows[0]["Nombres"].ToString(), 0, true);
								UpdateValue(wsName, "B" + (intfila).ToString(), dtCliente.Tables[0].Rows[0]["Paterno"].ToString(), 0, true);
								UpdateValue(wsName, "C" + (intfila).ToString(), dtCliente.Tables[0].Rows[0]["Maternos"].ToString(), 0, true);
								UpdateValue(wsName, "D" + (intfila).ToString(), dtCliente.Tables[0].Rows[0]["Rut"].ToString(), 0, true);
								UpdateValue(wsName, "E" + (intfila).ToString(), strfecha_inicio.Replace("/", "-"), 0, true);
								UpdateValue(wsName, "F" + (intfila).ToString(), strfecha_termino.Replace("/", "-"), 0, true);

								UpdateValue(wsName, "G" + (intfila).ToString(), txtvalor.Value.ToString(), 0, true);
								UpdateValue(wsName, "H" + (intfila).ToString(), "TRIMESTRAL", 0, true);
								UpdateValue(wsName, "I" + (intfila).ToString(), strEstado, 0, true);
								UpdateValue(wsName, "J" + (intfila).ToString(), "CUERPO ENTERO", 0, true);
								UpdateValue(wsName, "K" + (intfila).ToString(), "FILMICO", 0, true);

								UpdateValue(wsName, "L" + (intfila).ToString(), "3", 0, false);
								UpdateValue(wsName, "M" + (intfila).ToString(), "Rayos X otros", 0, true);
								UpdateValue(wsName, "N" + (intfila).ToString(), "X-RAY", 0, true);

								UpdateValue(wsName, "O" + (intfila).ToString(), dtCliente.Tables[0].Rows[0]["glosa"].ToString(), 0, true);
								UpdateValue(wsName, "P" + (intfila).ToString(), dtCliente.Tables[0].Rows[0]["profesion"].ToString(), 0, true);
								////							  UpdateValue(wsName, "S" + (intfila + 2).ToString(), dtCliente.Tables[0].Rows[0]["telefono"].ToString(), 0, true);
								UpdateValue(wsName, "S" + (intfila).ToString(), strTelefonoEmpresa, 0, true);//telefono
								UpdateValue(wsName, "X" + (intfila).ToString(), dtCliente.Tables[0].Rows[0]["Fecha_inicio"].ToString().Replace("/", "-"), 0, true);
								//°

								UpdateValue(wsName, "Y" + (intfila).ToString(), strRunEmpresa, 0, true);
								UpdateValue(wsName, "Z" + (intfila).ToString(), strRazon_SocialEmpresa, 0, true);

								UpdateValue(wsName, "AA" + (intfila).ToString(), strDireccionEmpresa.ToString(), 0, true);
								UpdateValue(wsName, "AB" + (intfila).ToString(), strcomunaEmpresa, 0, true);
								UpdateValue(wsName, "AC" + (intfila).ToString(), strProvinciaEmpresa, 0, true);
								UpdateValue(wsName, "AD" + (intfila).ToString(), strregionEmpresa, 0, true);
								UpdateValue(wsName, "AE" + (intfila).ToString(), strTelefonoEmpresa, 0, false);
								document.Close();
								cmd.CommandText = "update tbl_dosimetria " +
																	"set enviado=1" +
																" where id_dosimetro=" + strid_dosimetro;
								cmd.CommandType = CommandType.Text;

								Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);

								string strParametro = String.Format("{0},{1},{2},''", txtnpelicula.Value.ToString(), "5", Clases.clsUsuario.Usuario);
								cmd.CommandText = "pa_DosimetroIngresoTLD_upd " + strParametro;
								cmd.CommandType = CommandType.Text;
								Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);

								Array.Resize(ref data1, i + 3);
								Array.Resize(ref data2, i + 3);
								Array.Resize(ref data3, i + 3);
								Array.Resize(ref data4, i + 3);

								data1[i + 2] = dtCliente.Tables[0].Rows[0]["Nombres"].ToString() + " " + dtCliente.Tables[0].Rows[0]["Paterno"].ToString() + " " + dtCliente.Tables[0].Rows[0]["Maternos"].ToString();
								if (chkcondosis.Value.ToString() == "0")
									data2[i + 2] = strEstado;
								else
									data2[i + 2] = txtvalor.Value.ToString();
								data3[i + 2] = txtnpelicula.Value.ToString();
								data4[i + 2] = dtCliente.Tables[0].Rows[0]["Rut"].ToString();
								// this.p

								intfila = intfila + 1;
								i = i + 1;
							}

						}



						#endregion
					}
				}
				#region Update Document Bookmarks Openxml
				strcampoMarcador = "empresa";

				using (WordprocessingDocument doc = WordprocessingDocument.Open(strArchivoCopiar, true))
				{
					string strSemetre1 = "";
					if (cbx_id_periodo.Text.Replace("º TRI", "") == "1")
						strSemetre1 = "primer";
					if (cbx_id_periodo.Text.Replace("º TRI", "") == "2")
						strSemetre1 = "segundo";
					if (cbx_id_periodo.Text.Replace("º TRI", "") == "3")
						strSemetre1 = "tercer";
					if (cbx_id_periodo.Text.Replace("º TRI", "") == "4")
						strSemetre1 = "cuarto";

					strcampoMarcador = "empresa";
					BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), strRazon_SocialEmpresa);
					strcampoMarcador = "comuna";
					BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), strcomunaEmpresa);
					strcampoMarcador = "anno";
					BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), cbx_anno.Text);
					strcampoMarcador = "semestre";
					BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), strSemetre1);




				}
				if (data1.Count() > 1)
					WDAddTable(strArchivoCopiar, data1, data2, data3, data4);

				#endregion
				#endregion
			}



			MessageBox.Show("Informacion grabada y archivo generado \n Ubicación Archivo:" + targetPath);

			btnGenerar.Enabled = true;
			pnl_Progreso.Visible = false;

			Listar_Personal();
		}

		private void Btn_filtro_Click_1(object sender, EventArgs e)
		{
			LimpiarFormulario(2);
		}

		private void Btn_Cerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Btn_Corregir_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand();
			SqlCommand cmd2 = new SqlCommand();
			//	  SqlCommand cmd = new SqlCommand();
			SqlCommand cmdpersonal = new SqlCommand();
			//  SqlCommand cmdpersonal = new SqlCommand();
			SqlCommand cmdperiodo = new SqlCommand();
			//  SqlCommand cmdperiodo = new SqlCommand();

			// dtcombo = Conectar.Listar(Clases.clsBD.BD,cmdcombo);
			DataGridViewCheckBoxCell checkGenerar;
			DataGridViewCheckBoxCell checkCell;
			DataGridViewCheckBoxCell chkcondosis;
			DataGridViewTextBoxCell txtvalor;
			DataGridViewTextBoxCell txtndocumento;
			DataGridViewTextBoxCell txtnpelicula;
			DataGridViewComboBoxCell cbxEstado;
			DataGridViewCheckBoxCell checkTLD;
			string strn_cliente;
			string strid_personal;
			string strid_dosimetro;
			btn_Corregir.Enabled = false;

			pnl_Progreso.Visible = true;
			pgb_Barra.Minimum = 0;
			pgb_Barra.Maximum = grdDatos.RowCount;
			pnl_Progreso.Refresh();
			for (int i = 0; i <= grdDatos.RowCount - 1; i++)
			{
				pgb_Barra.Value = i + 1;
				pgb_Barra.Refresh();
				checkGenerar = (DataGridViewCheckBoxCell)grdDatos.Rows[i].Cells["Generar"];
				checkCell = (DataGridViewCheckBoxCell)grdDatos.Rows[i].Cells["enviado"];
				chkcondosis = (DataGridViewCheckBoxCell)grdDatos.Rows[i].Cells["condosis"];
				txtvalor = (DataGridViewTextBoxCell)grdDatos.Rows[i].Cells["valor"];
				txtndocumento = (DataGridViewTextBoxCell)grdDatos.Rows[i].Cells["NDocumento"];
				txtnpelicula = (DataGridViewTextBoxCell)grdDatos.Rows[i].Cells["n_pelicula"];
				cbxEstado = (DataGridViewComboBoxCell)grdDatos.Rows[i].Cells["Estado"];

				checkTLD = (DataGridViewCheckBoxCell)grdDatos.Rows[i].Cells["tld"];
				strn_cliente = grdDatos.Rows[i].Cells["N_Cliente"].Value.ToString();
				strid_personal = grdDatos.Rows[i].Cells["id_personal"].Value.ToString();
				strid_dosimetro = grdDatos.Rows[i].Cells["id_dosimetro"].Value.ToString();


				if (checkGenerar.Value.ToString() == "1")
				{
					cmd.CommandText = "update tbl_dosimetria " +
												"set enviado=0" +
										 " where id_dosimetro=" + strid_dosimetro;
					cmd.CommandType = CommandType.Text;

					Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);

					if (checkTLD.Value.ToString() == "0")
						cmd2.CommandText = "pa_DevolverEstado_upd " + txtnpelicula.Value.ToString() + "," + cbxEstado.Value + ",'" + Clases.clsUsuario.Usuario +
																	"',''," + cbx_id_periodo.SelectedValue.ToString() + "," + lbl_id_cliente.Text;
					else
						cmd2.CommandText = "pa_DevolverEstadoTLD_upd " + txtnpelicula.Value.ToString() + "," + cbxEstado.Value + ",'" + Clases.clsUsuario.Usuario +
																	"',''," + cbx_id_periodo.SelectedValue.ToString() + "," + lbl_id_cliente.Text;
					cmd2.CommandType = CommandType.Text;
					Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd2);
				}
			}
			MessageBox.Show("Informacion esta listo para corregir su dosis.");

			btn_Corregir.Enabled = true;
			pnl_Progreso.Visible = false;

			Listar_Personal();
		}
		#endregion

		#region "combobox"

		private void Cbx_Sucursal_SelectedIndexChanged(object sender, EventArgs e)
		{
			//if (!bolDesdeCodigo)
			Cursor = Cursors.WaitCursor;
			Cargar_Seccion();
			Cursor = Cursors.Default;
		}

		private void cbx_id_seccion_SelectedIndexChanged(object sender, EventArgs e)
		{
			//if (!bolDesdeCodigo)
			//	Listar_Personal();
		}

		private void cbx_anno_SelectedValueChanged(object sender, EventArgs e)
		{
			Cargar_Periodo();
		}

		private void btnResfrescar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			Inicializar = false;
			Listar_Personal();
			//cbx_anno.Enabled = false;
			//cbx_id_periodo.Enabled = false;
			//btn_cargar.Enabled = false;
			//btn_Corregir.Enabled = true;
			grdDatos.Focus();
			Cursor = Cursors.Default;
		}

		#endregion

		#region "grilla"

		private void GrdDatos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (grdDatos.IsCurrentCellDirty)
			{
				grdDatos.CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		private void GrdDatos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if ((grdDatos.Columns[e.ColumnIndex].Name == "Controlado") || (grdDatos.Columns[e.ColumnIndex].Name == "condosis"))
			{
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
				((DataTable)grdDatos.DataSource).Rows[e.RowIndex].AcceptChanges();
			}

		}

		#endregion
		#region "Excel"

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
				row = new Row
				{
					RowIndex = rowIndex
				};
				wsData.Append(row);
			}
			return row;
		}

		// Given an Excel address such as E5 or AB128, GetRowIndex
		// parses the address and returns the row index.
		private UInt32 GetRowIndex(string address)
		{
			string rowPart;
			UInt32 result = 0;

			for (int i = 0; i < address.Length; i++)
			{
				if (UInt32.TryParse(address.Substring(i, 1), out uint l))
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

		public static void WDAddTableV2(string fileName, string[] Id, string[] Rut, string[] Nombre, string PerInicio, string PerFin, string FechaRecepcion, string[] Medicion, string[] UltimoAnno, string[] Ultimo5anno)
		{
			using (var document = WordprocessingDocument.Open(fileName, true))
			{

				var doc = document.MainDocumentPart.Document;

				//DocumentFormat.OpenXml.Wordprocessing.Table table = doc.Body.Elements<DocumentFormat.OpenXml.Wordprocessing.Table>().Where<>.
				DocumentFormat.OpenXml.Wordprocessing.Table table = doc.Body.Elements<DocumentFormat.OpenXml.Wordprocessing.Table>().ElementAtOrDefault(1);

				//    new DocumentFormat.OpenXml.Wordprocessing.Table().First() ;

				//Table table =
				//  doc.MainDocumentPart.Document.Body.Elements<Table>().First();

				TableProperties props = new TableProperties(
					new TableBorders(
					 new DocumentFormat.OpenXml.Wordprocessing.TopBorder
					 {
						 Val = new EnumValue<BorderValues>(BorderValues.None),
						 Size = 8
					 },
					 new DocumentFormat.OpenXml.Wordprocessing.BottomBorder
					 {
						 Val = new EnumValue<BorderValues>(BorderValues.None),
						 Size = 8
					 },
					 new DocumentFormat.OpenXml.Wordprocessing.LeftBorder
					 {
						 Val = new EnumValue<BorderValues>(BorderValues.None),
						 Size = 8
					 },
					 new DocumentFormat.OpenXml.Wordprocessing.RightBorder
					 {
						 Val = new EnumValue<BorderValues>(BorderValues.None),
						 Size = 8
					 },
					 new InsideHorizontalBorder
					 {
						 Val = new EnumValue<BorderValues>(BorderValues.None),
						 Size = 8
					 },
					 new InsideVerticalBorder
					 {
						 Val = new EnumValue<BorderValues>(BorderValues.None),
						 Size = 8
					 }));
				table.AppendChild<TableProperties>(props);

				for (var i = 0; i <= Id.GetUpperBound(0); i++)
				{
					var tr = new TableRow(new TableWidth { Type = TableWidthUnitValues.Auto });
					var tc2 = new TableCell();
					var tc3 = new TableCell();
					var tc4 = new TableCell();
					var tc5 = new TableCell();
					var tc6 = new TableCell();
					var tc7 = new TableCell();
					var tc8 = new TableCell();
					var tc9 = new TableCell();
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
															 new DocumentFormat.OpenXml.Wordprocessing.FontSize() { Val = "8" },
															 new Paragraph(new DocumentFormat.OpenXml.Wordprocessing.Run(new DocumentFormat.OpenXml.Wordprocessing.Text(Id[i])),
																	new DocumentFormat.OpenXml.Wordprocessing.RunFonts() { Ascii = "Arial" })
															 ));

						tr.Append(tc);



						tc2.Append(new TableCellProperties(
					 new TableCellWidth { Type = TableWidthUnitValues.Dxa, Width = "350" },
															 new DocumentFormat.OpenXml.Wordprocessing.Bold(),
															 new DocumentFormat.OpenXml.Wordprocessing.FontSize() { Val = "8" }
															 ));

						tc3.Append(new TableCellProperties(
					 new TableCellWidth { Type = TableWidthUnitValues.Dxa, Width = "600" },
					 new DocumentFormat.OpenXml.Wordprocessing.Bold(),
															 new DocumentFormat.OpenXml.Wordprocessing.FontSize() { Val = "8" }
															 ));
					}
					else
					{
						tc.Append(new TableCellProperties(
															 new TableCellWidth { Type = TableWidthUnitValues.Auto },
															 new DocumentFormat.OpenXml.Wordprocessing.RunFonts() { Ascii = "Arial" },
															 new DocumentFormat.OpenXml.Wordprocessing.FontSize() { Val = "8" },
															 new Paragraph(new DocumentFormat.OpenXml.Wordprocessing.Run(new DocumentFormat.OpenXml.Wordprocessing.Text(Id[i])),
																	new DocumentFormat.OpenXml.Wordprocessing.RunFonts() { Ascii = "Arial" })
															 ));

						tr.Append(tc);



						tc2.Append(new TableCellProperties(
					 new TableCellWidth { Type = TableWidthUnitValues.Dxa, Width = "350" },
															 new DocumentFormat.OpenXml.Wordprocessing.FontSize() { Val = "8" }
															 ));

						tc3.Append(new TableCellProperties(
					 new TableCellWidth { Type = TableWidthUnitValues.Dxa, Width = "600" },
															 new DocumentFormat.OpenXml.Wordprocessing.FontSize() { Val = "8" }
															 ));
					}
					//tc.Append(new Paragraph(new DocumentFormat.OpenXml.Wordprocessing.Run(new DocumentFormat.OpenXml.Wordprocessing.Text(data1[i]))),
					//    new TableCellProperties(
					//                              new TableCellWidth { Type = TableWidthUnitValues.Dxa, Width = "500" },
					//                               new DocumentFormat.OpenXml.Wordprocessing.FontSize() { Val = "9" }
					//                               )
					//    );
					//tr.Append(tc);


					tc2.Append(new Paragraph(new DocumentFormat.OpenXml.Wordprocessing.Run(new DocumentFormat.OpenXml.Wordprocessing.Text(Rut[i]))));
					// Assume you want columns that are automatically sized.
					tr.Append(tc2);


					tc3.Append(new Paragraph(new DocumentFormat.OpenXml.Wordprocessing.Run(new DocumentFormat.OpenXml.Wordprocessing.Text(Nombre[i]))));
					// Assume you want columns that are automatically sized.

					tr.Append(tc3);

					tc4.Append(new TableCellProperties(
															new TableCellWidth { Type = TableWidthUnitValues.Auto },
															new DocumentFormat.OpenXml.Wordprocessing.Bold(),
															new DocumentFormat.OpenXml.Wordprocessing.RunFonts() { Ascii = "Arial" },
															new DocumentFormat.OpenXml.Wordprocessing.FontSize() { Val = "8" },
															new Paragraph(new DocumentFormat.OpenXml.Wordprocessing.Run(new DocumentFormat.OpenXml.Wordprocessing.Text(PerInicio.Substring(0, 6) + PerInicio.Substring(PerInicio.Length - 2, 2))))
															));

					tr.Append(tc4);

					tc5.Append(new TableCellProperties(
															new TableCellWidth { Type = TableWidthUnitValues.Auto },
															new DocumentFormat.OpenXml.Wordprocessing.Bold(),
															new DocumentFormat.OpenXml.Wordprocessing.RunFonts() { Ascii = "Arial" },
															new DocumentFormat.OpenXml.Wordprocessing.FontSize() { Val = "8" },
															new Paragraph(new DocumentFormat.OpenXml.Wordprocessing.Run(new DocumentFormat.OpenXml.Wordprocessing.Text(PerFin.Substring(0, 6) + PerFin.Substring(PerFin.Length - 2, 2))))
															));

					tr.Append(tc5);//

					tc6.Append(new TableCellProperties(
															new TableCellWidth { Type = TableWidthUnitValues.Auto },
															new DocumentFormat.OpenXml.Wordprocessing.Bold(),
															new DocumentFormat.OpenXml.Wordprocessing.RunFonts() { Ascii = "Arial" },
															new DocumentFormat.OpenXml.Wordprocessing.FontSize() { Val = "8" },
															new Paragraph(new DocumentFormat.OpenXml.Wordprocessing.Run(new DocumentFormat.OpenXml.Wordprocessing.Text(PerFin.Substring(0, 6) + FechaRecepcion.Substring(FechaRecepcion.Length - 2, 2))))
															));

					tr.Append(tc6);
					tc7.Append(new Paragraph(new DocumentFormat.OpenXml.Wordprocessing.Run(new DocumentFormat.OpenXml.Wordprocessing.Text(Medicion[i]))));
					tr.Append(tc7);

					//string[] UltimoAnno, string[] Ultimo5anno

					tc8.Append(new TableCellProperties(
														new TableCellWidth { Type = TableWidthUnitValues.Auto },
														new DocumentFormat.OpenXml.Wordprocessing.RunFonts() { Ascii = "Arial" },
														new DocumentFormat.OpenXml.Wordprocessing.FontSize() { Val = "8" },
														new Paragraph(new DocumentFormat.OpenXml.Wordprocessing.Run(new DocumentFormat.OpenXml.Wordprocessing.Text(UltimoAnno[i].ToString())))
														));

					tr.Append(tc8);

					tc9.Append(new TableCellProperties(
														new TableCellWidth { Type = TableWidthUnitValues.Auto },
														new DocumentFormat.OpenXml.Wordprocessing.RunFonts() { Ascii = "Arial" },
														new DocumentFormat.OpenXml.Wordprocessing.FontSize() { Val = "8" },
														new Paragraph(new DocumentFormat.OpenXml.Wordprocessing.Run(new DocumentFormat.OpenXml.Wordprocessing.Text(Ultimo5anno[i].ToString())))
														));

					tr.Append(tc9);


					table.Append(tr);
				}
				//  doc.Body.Append(table);
				doc.Save();
			}
		}

		private void GrdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void GrdDatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{

			//this.grdDatos.Columns["Dosis"].ValueType = typeof(Decimal);
			//this.grdDatos.Columns["Dosis"].DefaultCellStyle.Format = "N2";
		}

		private void cbx_id_periodo_SelectedIndexChanged(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			Cargar_Sucursal();
			Cursor = Cursors.Default;
		}


	}
}
