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
	public partial class FrmInformeDetalleISPAnual : Form
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
		Int64 intId_Cliente;
		DataTable dtPeriodo;
		#endregion

		public FrmInformeDetalleISPAnual()
		{
			InitializeComponent();

			AsignarEvento();
			LimpiarFormulario(2);
			LimpiarFormulario(3);
			//	Cargar_Anno();
			btnGenerar.Visible = false;
			pnl_Progreso.Visible = false;
			lbl_Original.Text = RutaArchivo().Replace("\\", "/");
			lbl_Alternativa.Text = "C:/Doc_Xray/";
			rbtOiginal.Checked = true;
		}

		#region "Llamada de carga"

		private void Cargar_Cliente()
		{
			frmAyudaCliente frm = new frmAyudaCliente(Convert.ToInt64(txt_IdCliente.Text));

			if(frm.ShowDialog()==DialogResult.OK)
			{
				lbl_nombreCliente.Text = Clases.ClsCliente.Nombres;
				lbl_Rut.Text = Clases.ClsCliente.Rut;

				SqlCommand cmd = new SqlCommand
				{
					//	SqlCommand cmd = new SqlCommand();CargarClientePorRun

					CommandText = String.Format("CargarClientePorRun '{0}'", lbl_Rut.Text)
				};
				DataSet dt;
				dt = Conectar.Listar(Clases.clsBD.BD, cmd);

				if (dt.Tables[0].Rows.Count > 0)
				{
					cbx_anno.DataSource = dt.Tables[1];
					cbxSucursal.DataSource = dt.Tables[2];

					LimpiarFormulario(1);
				}

			}
			else
			{
				LimpiarFormulario(2);
				LimpiarFormulario(3);
			}
		}

		void LimpiarFormulario(int bolLimpiar)
		{
			if (bolLimpiar == 1)
			{
				//txt_id_cliente.Enabled = false;
				btn_CargarCli.Enabled = false;

				cbx_anno.Enabled = true;
				btn_cargar.Enabled = true;
				grpInformacion.Text = "Listado";
				grpInformacion.Enabled = false;
			}
			else if (bolLimpiar == 2)
			{
				lbl_nombreCliente.Text = "";
				lbl_Rut.Text = "";
				txt_IdCliente.Clear();
				btn_cargar.Enabled = false;
				btn_CargarCli.Enabled = true;
				grpInformacion.Text = "Listado";
				grpInformacion.Enabled = false;
				cbx_anno.DataSource = null;
				cbx_anno.ValueMember = "anno";
				cbx_anno.DisplayMember = "anno";
				cbxSucursal.DataSource = null;
				cbxSucursal.ValueMember = "Id_sucursal";
				cbxSucursal.DisplayMember = "Direccion";
				txt_IdCliente.Focus();
				grpInformacion.Enabled = false;
				btnGenerar.Enabled = false;
				btn_cargar.Enabled = false;
			}
			else if (bolLimpiar == 3)
			{
				grpInformacion.Enabled = false;
				btnGenerar.Enabled = false;
				btn_cargar.Enabled = true;
			}
			else if (bolLimpiar == 4)
			{
				grpInformacion.Enabled = true;
				grpInformacion.Enabled = true;
				cbx_anno.Enabled = true;
				btn_cargar.Enabled = true;
				btnGenerar.Enabled = true;
			}
		}

		private void Listar_Personal()
		{
			SqlCommand cmd = new SqlCommand();
			 DataSet dt;
			cmd.CommandText = String.Format("pa_DosimetroISP_ClientePorTrimestre_sel '{0}',{1},{2}", lbl_Rut.Text, cbx_anno.SelectedValue, cbxSucursal.SelectedValue);
			cmd.CommandType = CommandType.Text;

			dt = Conectar.Listar(Clases.clsBD.BD, cmd);
			string filterExp = "";
			DataRow[] drarray;
			drarray = dt.Tables[0].Select(filterExp, "", DataViewRowState.CurrentRows);

			string filterExp1 = "";
			string sortExp1 = "";
			DataRow[] drarray1;
			drarray1 = dt.Tables[0].Select(filterExp1, sortExp1, DataViewRowState.CurrentRows);

			grpInformacion.Text = "Listado       Registro Generado:" + drarray.Count().ToString() + ", registro Faltante: " + drarray1.Count().ToString();


			if (dt.Tables[0].Rows.Count == 0)
			{
				btnGenerar.Visible = false;
				LimpiarFormulario(3);
				grdDatos.DataSource = dt.Tables[0];
				MessageBox.Show("No se han cargado ningun personal");
			}
			else
			{
				LimpiarFormulario(4);
				btnGenerar.Visible = true;
				grdDatos.DefaultCellStyle.BackColor = System.Drawing.Color.White;
				grdDatos.DataSource = dt.Tables[0];
			}
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

		private void AsignarEvento()
		{
			Clases.ClassEvento evt = new Clases.ClassEvento();
			evt.AsignarNumero(ref txt_IdCliente);
		}

		#endregion

		#region "button"

		private void Btn_CargarCli_Click(object sender, EventArgs e)
		{

			Cargar_Cliente();
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
			SqlCommand cmd = new SqlCommand();
			//	  SqlCommand cmd = new SqlCommand();
			SqlCommand cmdpersonal = new SqlCommand();
			//  SqlCommand cmdpersonal = new SqlCommand();
			SqlCommand cmdperiodo = new SqlCommand();
			//  SqlCommand cmdperiodo = new SqlCommand();

			// dtcombo = Conectar.Listar(Clases.clsBD.BD,cmdcombo);
			DataGridViewCheckBoxCell checkGenerar;
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
				targetPath = @dtArchivo.Tables[0].Rows[0]["Glosa"].ToString() + "Cliente " + lbl_Rut.Text;
			else
				targetPath = @"C:\\Doc_Xray\\" + "Cliente "+ lbl_Rut.Text;


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

			//**************carga cliente
			SqlCommand cmdCliente = new SqlCommand
			{
				CommandText = "pa_DosimetroISPGenerarSinPeriodo_sel " + lbl_Rut.Text + "," + cbxSucursal.SelectedValue,

				CommandType = CommandType.Text
			};

			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmdCliente);

			string strArchivo = "";
			if (rbtOiginal.Checked)
				strArchivo = dtformato.Tables[0].Rows[0]["Glosa"].ToString() + "PlantillawordAnual.docx";
			else
				strArchivo = @"C:\\Doc_Xray\\baseCliente\\Plantilla\\PlantillawordAnual.docx";


			//   string strArchivo = ConfigurationManager.AppSettings["Archivo"] + "Plantillaword.docx";

			int i;
			for (int idatos = 0; idatos <= dt.Tables[0].Rows.Count - 1; idatos++)
			{
				#region "Proceso"
				
				string strRunEmpresa = dt.Tables[0].Rows[idatos]["run"].ToString();
				string strRazon_SocialEmpresa = dt.Tables[0].Rows[idatos]["Razon_Social"].ToString();
				string strDireccionEmpresa = (int)cbx_anno.SelectedValue == 0 ? lbl_nombreCliente.Text : dt.Tables[0].Rows[idatos]["Direccion"].ToString();
				string strTelefonoEmpresa = dt.Tables[0].Rows[idatos]["Telefono"].ToString();
				string strregionEmpresa = dt.Tables[0].Rows[idatos]["region"].ToString();
				string strProvinciaEmpresa = dt.Tables[0].Rows[idatos]["Provincia"].ToString();
				string strcomunaEmpresa = dt.Tables[0].Rows[idatos]["comuna"].ToString();
				string strSeccion = (int)cbx_anno.SelectedValue == 0 ? "" : cbx_anno.Text;
				String strArchivoCopiar = "";

				//*************************************
				int intfila = 2;

				string[] data1;
				string[] data2;
				string[] data3;
				string[] data4;
				string[] data5;
				string[] data6;

				data1 = new string[] { strRazon_SocialEmpresa };
				data2 = new string[] { "" };
				data3 = new string[] { "" };
				data4 = new string[] { "" };
				data5 = new string[] { "" };
				data6 = new string[] { "" };

				Array.Resize(ref data1, 2);
				Array.Resize(ref data2, 2);
				Array.Resize(ref data3, 2);
				Array.Resize(ref data4, 2);
				Array.Resize(ref data5, 2);
				Array.Resize(ref data6, 2);

				data1[1] = "Rut";
				data2[1] = "Nombre";
				data3[1] = "1° Tri";
				data4[1] = "2° Tri";
				data5[1] = "3° Tri";
				data6[1] = "4° Tri";

				pnl_Progreso.Visible = true;
				pgb_Barra.Minimum = 0;
				pgb_Barra.Maximum = grdDatos.RowCount;
				pnl_Progreso.Refresh();
				for (int intfilagrid = 0; intfilagrid <= grdDatos.RowCount - 1; intfilagrid++)
				{
					i = 0;
					pgb_Barra.Value = i + 1;
					pgb_Barra.Refresh();
					checkGenerar = (DataGridViewCheckBoxCell)grdDatos.Rows[intfilagrid].Cells["colGenerar"];
					if ((bool)checkGenerar.Value == true)
					{
						#region "Genera  word y excel"
						{
							grdDatos.Rows[i].DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
							//if ((strid_dosimetro != "0")) //&& (checkGenerar.Value.ToString() == "1")					 
							//{
							//strArchivoCopiar = targetPath + cbx_anno.Text.ToString().Substring(0, 1) + "T_" + cbx_anno.Text + "_Rut(" + dtCliente.Tables[0].Rows[0]["Rut"].ToString() + ").docx";//Cliente" + lbl_id_cliente.Text + "_"

							strArchivoCopiar = String.Format("{0}\\{1}_{2}.docx", targetPath, lbl_nombreCliente.Text, grdDatos.Rows[intfilagrid].Cells[1].Value);
								
								
							//	+ "T_" + cbx_anno.Text + "_Rut(" + dtCliente.Tables[0].Rows[0]["Rut"].ToString() + ").docx";//Cliente" + lbl_id_cliente.Text + "_"
																																																																																									 //strpathcopiar = targetPath + "_Rut(" + dtCliente.Tables[0].Rows[0]["Rut"].ToString() + ").xlsx";//"cliente " + lbl_id_cliente.Text + 

							//File.Copy(strpath, strpathcopiar, true);
							File.Copy(strArchivo, strArchivoCopiar, true);
						
							Array.Resize(ref data1, i + 3);
								Array.Resize(ref data2, i + 3);
								Array.Resize(ref data3, i + 3);
								Array.Resize(ref data4, i + 3);
							Array.Resize(ref data5, i + 3);
							Array.Resize(ref data6, i + 3);
							data1[i + 2] = grdDatos.Rows[intfilagrid].Cells[1].Value.ToString();
							data2[i + 2] = grdDatos.Rows[intfilagrid].Cells[2].Value.ToString() + " "+ grdDatos.Rows[intfilagrid].Cells[3].Value.ToString() + " " + grdDatos.Rows[intfilagrid].Cells[4].Value.ToString();
							data3[i + 2] = grdDatos.Rows[intfilagrid].Cells[5].Value.ToString();
							data4[i + 2] = grdDatos.Rows[intfilagrid].Cells[6].Value.ToString();
							data5[i + 2] = grdDatos.Rows[intfilagrid].Cells[7].Value.ToString();
							data6[i + 2] = grdDatos.Rows[intfilagrid].Cells[8].Value.ToString();
							#region Update Document Bookmarks Openxml
							strcampoMarcador = "empresa";

								using (WordprocessingDocument doc = WordprocessingDocument.Open(strArchivoCopiar, true))
								{
							
									strcampoMarcador = "empresa";
									BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), strRazon_SocialEmpresa);
									strcampoMarcador = "comuna";
									BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), strcomunaEmpresa);
									strcampoMarcador = "anno";
									BookmarkReplacer.ReplaceBookmarkText(doc, strcampoMarcador.ToString(), cbx_anno.Text);




								}
								if (data1.Count() > 1)
									WDAddTable(strArchivoCopiar, data1, data2, data3, data4, data5, data6);

								#endregion

								intfila = intfila + 1;
								i = 0;
							//}

						}



						#endregion

					}
				}

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

		#endregion

		#region "combobox"


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

		public static void WDAddTable(string fileName, string[] data1, string[] data2, string[] data3, string[] data4, string[] data5,string[] data6)
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
					var tc5 = new TableCell();
					var tc6 = new TableCell();
					//for (var j = 0; j <= data.GetUpperBound(1); j++)
					//{
					var tc = new TableCell();
					// Assume you want columns that are automatically sized.
					if (i == 0)
					{



						tc.Append(new TableCellProperties(
															 new TableCellWidth { Type = TableWidthUnitValues.Dxa, Width = "130" },
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
					 new TableCellWidth { Type = TableWidthUnitValues.Auto },
					 new DocumentFormat.OpenXml.Wordprocessing.Bold(),
															 new DocumentFormat.OpenXml.Wordprocessing.FontSize() { Val = "9" }
															 ));
					}
					else
					{
						tc.Append(new TableCellProperties(
															 new TableCellWidth { Type = TableWidthUnitValues.Dxa, Width = "130" },
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
						new TableCellWidth { Type = TableWidthUnitValues.Auto },
															 new DocumentFormat.OpenXml.Wordprocessing.FontSize() { Val = "9" }
															 ));
					}

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

					tc5.Append(new TableCellProperties(
															new TableCellWidth { Type = TableWidthUnitValues.Auto },
															new DocumentFormat.OpenXml.Wordprocessing.Bold(),
															new DocumentFormat.OpenXml.Wordprocessing.RunFonts() { Ascii = "Arial" },
															new DocumentFormat.OpenXml.Wordprocessing.FontSize() { Val = "9" },
															new Paragraph(new DocumentFormat.OpenXml.Wordprocessing.Run(new DocumentFormat.OpenXml.Wordprocessing.Text(data5[i])))
															));

					tr.Append(tc5);

					tc6.Append(new TableCellProperties(
															new TableCellWidth { Type = TableWidthUnitValues.Auto },
															new DocumentFormat.OpenXml.Wordprocessing.Bold(),
															new DocumentFormat.OpenXml.Wordprocessing.RunFonts() { Ascii = "Arial" },
															new DocumentFormat.OpenXml.Wordprocessing.FontSize() { Val = "9" },
															new Paragraph(new DocumentFormat.OpenXml.Wordprocessing.Run(new DocumentFormat.OpenXml.Wordprocessing.Text(data6[i])))
															));

					tr.Append(tc6);
					// }
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

		private void Cbx_Sucursal_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!bolDesdeCodigo)
				Listar_Personal();
		}

		private void cbx_id_seccion_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!bolDesdeCodigo)
				Listar_Personal();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void lbl_id_cliente_TextChanged(object sender, EventArgs e)
		{

		}

		private void FrmInformeDetalleISPAnual_Load(object sender, EventArgs e)
		{

		}

	}
}
