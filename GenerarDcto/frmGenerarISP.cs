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
    public partial class frmGenerarISP : Form
    {

        #region "Definicion variable"
        DataSet dt;
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

        #endregion

                public frmGenerarISP()
        {
            InitializeComponent();

            AsignarEvento();
            Cargar_Anno();           
            pnl_Progreso.Visible = true;
        }

        #region "Llamada de carga"
		  private void Cargar_Anno()
		  {
              SqlCommand cmd = new SqlCommand();

			//  SqlCommand cmd = new SqlCommand();

			  cmd.CommandText = "SELECT distinct Anno FROM conf_periodo WHERE Id_TipoPeriodo=3";
			  //cmd.CommandText = "SELECT Id_Periodo,Anno, Mes,Id_TipoPeriodo FROM conf_periodo WHERE Id_TipoPeriodo=3";
			  DataSet dt;
			  dt = Conectar.Listar(Clases.clsBD.BD,cmd);

			  cbx_anno.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
			  cbx_anno.DataSource = dt.Tables[0];

		  }

          private void Cargar_Periodo()
          {
              SqlCommand cmd = new SqlCommand();

              //	  SqlCommand cmd = new SqlCommand();

              cmd.CommandText = "SELECT Id_Periodo,Mes, cast((mes/3) as varchar(10))+ 'º TRI' FROM conf_periodo WHERE Id_TipoPeriodo=3 and Anno=" + cbx_anno.Text;
              DataSet dt;
              dt = Conectar.Listar(Clases.clsBD.BD,cmd);

              cbx_id_periodo.DisplayMember = dt.Tables[0].Columns[2].Caption.ToString();
              cbx_id_periodo.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
              cbx_id_periodo.DataSource = dt.Tables[0];
          }

        private void AsignarEvento()
        {    	
        }

        #endregion

        #region "button"
    

		 private void btn_Guardar_Click(object sender, EventArgs e)
		  {
            String targetPath = "c:\\ControlDosimetro";
            //crea carpeta
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }
            //copiar archivo
            String strArchivoCopiar = "C:\\Formato\\FICHA-X-RAY-Formato1.xlsx";//Application.StartupPath + 
            String strpathcopiar = targetPath + "\\planilla" + "_" + cbx_id_periodo.Text.ToString().Substring(0, 1) + "T_" + cbx_anno.Text + ".xlsx";
            File.Copy(strArchivoCopiar, strpathcopiar, true);


            SqlCommand cmd = new SqlCommand();
            btn_Corregir.Enabled = false;

            cmd.CommandText = "pa_Sel_ArchivoISP_sel " + cbx_id_periodo.SelectedValue.ToString();
            cmd.CommandType = CommandType.Text;

            DataSet dt;
            dt = Conectar.Listar(Clases.clsBD.BD,cmd);
           
            if(dt.Tables[0].Rows.Count>0)
            {//ENTIDADES,TOES,DOSIS
                document = SpreadsheetDocument.Open(strpathcopiar, true);
                wbPart = document.WorkbookPart;
                string wsName = "ENTIDADES ";
                for (int intfila = 0; intfila <= dt.Tables[0].Rows.Count - 1; intfila++)
              //  for (int intfila = 0; intfila <= 10; intfila++)
                {
                   
                    UpdateValue(wsName, "C" + (intfila+9).ToString(), dt.Tables[0].Rows[intfila]["run"].ToString(), 0, true);
                    UpdateValue(wsName, "E" + (intfila + 9).ToString(), dt.Tables[0].Rows[intfila]["Razon_Social"].ToString(), 0, true);
                    UpdateValue(wsName, "G" + (intfila + 9).ToString(), dt.Tables[0].Rows[intfila]["Id_TipoEmpresa"].ToString(), 0, true);
                    UpdateValue(wsName, "I" + (intfila + 9).ToString(), dt.Tables[0].Rows[intfila]["Id_Region"].ToString(), 0, true);
                    UpdateValue(wsName, "K" + (intfila + 9).ToString(), dt.Tables[0].Rows[intfila]["Id_Comuna"].ToString(), 0, true);
                    UpdateValue(wsName, "M" + (intfila + 9).ToString(), dt.Tables[0].Rows[intfila]["Id_ministerio"].ToString(), 0, true);
                    UpdateValue(wsName, "O" + (intfila + 9).ToString(), dt.Tables[0].Rows[intfila]["Id_Sector"].ToString(), 0, true);
                    UpdateValue(wsName, "Q" + (intfila + 9).ToString(), dt.Tables[0].Rows[intfila]["Direccion"].ToString(), 0, true);
                    UpdateValue(wsName, "S" + (intfila + 9).ToString(), dt.Tables[0].Rows[intfila]["codigo_postal"].ToString(), 0, true);
                    UpdateValue(wsName, "W" + (intfila + 9).ToString(), dt.Tables[0].Rows[intfila]["Telefono"].ToString(), 0, true);
                    UpdateValue(wsName, "Y" + (intfila + 9).ToString(), dt.Tables[0].Rows[intfila]["FAX"].ToString(), 0, true);
                    UpdateValue(wsName, "AA" + (intfila + 9).ToString(), dt.Tables[0].Rows[intfila]["Email"].ToString(), 0, true);
                    UpdateValue(wsName, "AC" + (intfila + 9).ToString(), dt.Tables[0].Rows[intfila]["director"].ToString(), 0, true);
                    UpdateValue(wsName, "AE" + (intfila + 9).ToString(), dt.Tables[0].Rows[intfila]["OPR"].ToString(), 0, true);
                   // if((intfila % 20) ==0 )
                     //   System.Threading.Thread.Sleep(20000);

                }

                string wsNameTOES = "TOES";
                string wsNameDOSIS = "DOSIS";
                for (int intfila1 = 0; intfila1 <= dt.Tables[1].Rows.Count - 1; intfila1++)
                //  for (int intfila = 0; intfila <= 10; intfila++)
                {

                    UpdateValue(wsNameTOES, "C" + (intfila1 + 9).ToString(), dt.Tables[1].Rows[intfila1]["Run_empleado"].ToString(), 0, true);
                    UpdateValue(wsNameTOES, "E" + (intfila1 + 9).ToString(), dt.Tables[1].Rows[intfila1]["Nombres"].ToString() + ' ' +
                                        dt.Tables[1].Rows[intfila1]["Paterno"].ToString() + ' ' + dt.Tables[1].Rows[intfila1]["Maternos"].ToString(), 0, true);
                    UpdateValue(wsNameTOES, "G" + (intfila1 + 9).ToString(), dt.Tables[1].Rows[intfila1]["sexo"].ToString(), 0, true);
                    UpdateValue(wsNameTOES, "I" + (intfila1 + 9).ToString(), dt.Tables[1].Rows[intfila1]["Fecha_Nac"].ToString(), 0, true);
                    UpdateValue(wsNameTOES, "K" + (intfila1 + 9).ToString(), dt.Tables[1].Rows[intfila1]["pais"].ToString(), 0, true);                    
                }

                for (int intfila2 = 0; intfila2 <= dt.Tables[2].Rows.Count - 1; intfila2++)
                //  for (int intfila = 0; intfila <= 10; intfila++)
                {

                     UpdateValue(wsNameDOSIS, "C" + (intfila2 + 8).ToString(), dt.Tables[2].Rows[intfila2]["Run_empleado"].ToString(), 0, true);
                    UpdateValue(wsNameDOSIS, "G" + (intfila2 + 8).ToString(), dt.Tables[2].Rows[intfila2]["Rut_Empresa"].ToString(), 0, true);
                    UpdateValue(wsNameDOSIS, "K" + (intfila2 + 8).ToString(), dt.Tables[2].Rows[intfila2]["Id_cargo"].ToString(), 0, true);
                    UpdateValue(wsNameDOSIS, "Q" + (intfila2 + 8).ToString(), dt.Tables[2].Rows[intfila2]["dosis"].ToString(), 0, true);
                    UpdateValue(wsNameDOSIS, "U" + (intfila2 + 8).ToString(), dt.Tables[2].Rows[intfila2]["id_estado_dosimetro"].ToString(), 0, true);
                    UpdateValue(wsNameDOSIS, "M" + (intfila2 + 8).ToString(), dt.Tables[2].Rows[intfila2]["fecha_inicio"].ToString(), 0, true);
                    UpdateValue(wsNameDOSIS, "O" + (intfila2 + 8).ToString(), dt.Tables[2].Rows[intfila2]["fecha_termino"].ToString(), 0, true);
                    UpdateValue(wsNameDOSIS, "E" + (intfila2 + 8).ToString(), dt.Tables[2].Rows[intfila2]["Id_CodServicio"].ToString(), 0, true);
                    UpdateValue(wsNameDOSIS, "I" + (intfila2 + 8).ToString(), dt.Tables[2].Rows[intfila2]["Id_Practica"].ToString(), 0, true);
                    		
                }
                
                document.Close();
            }

        MessageBox.Show("El archivo ISP fue generado en esta en la ruta " + targetPath);

            btn_Corregir.Enabled = true;



            MessageBox.Show("Informacion grabada y archivo generado \n Ubicación Archivo:" + targetPath);

             pnl_Progreso.Visible = false;
                  
				//  Listar_Personal();
		  }

		 private void btn_Cerrar_Click(object sender, EventArgs e)
		 {
			 this.Close();
		 }

        private void btn_Corregir_Click(object sender, EventArgs e)
          {
            SqlCommand cmd2 = new SqlCommand();

            btn_Corregir.Enabled = false;

            cmd2.CommandText = "pa_GenerarArchivoISP_sel " + cbx_id_periodo.SelectedValue.ToString() ;
            cmd2.CommandType = CommandType.Text;
            Conectar.AgregarModificarEliminar(Clases.clsBD.BD,cmd2);
            MessageBox.Show("Los datos fueron generado y esta listo para que se genere el infome");

              btn_Corregir.Enabled = true;
        }
        #endregion

		  #region "combobox"

		  private void cbx_anno_SelectedIndexChanged(object sender, EventArgs e)
		  {
			  Cargar_Periodo();
		  }

		  #endregion

		  #region "grilla"

        #endregion
		 #region "Excel"

		  public bool UpdateValue(string sheetName, string addressName, string value,  UInt32Value styleIndex, bool isString)
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

			  cellResult = new Cell();
			  cellResult.CellReference = address;

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
			  UInt32 l;
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

          public static void WDAddTable(string fileName, string[] data1, string[] data2, string[] data3, string[] data4)
          {
              using (var document = WordprocessingDocument.Open(fileName, true))
              {

                  var doc = document.MainDocumentPart.Document;

                  //DocumentFormat.OpenXml.Wordprocessing.Table table = doc.Body.Elements<DocumentFormat.OpenXml.Wordprocessing.Table>().Where<>.
                  DocumentFormat.OpenXml.Wordprocessing.Table table = doc.Body.Elements<DocumentFormat.OpenXml.Wordprocessing.Table>().ElementAtOrDefault(2) ;
                      
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
                          Val = new EnumValue<BorderValues>(BorderValues.None ),
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
                                                         new TableCellWidth { Type = TableWidthUnitValues.Auto  },
                                                         new DocumentFormat.OpenXml.Wordprocessing.Bold(),
                                                         new DocumentFormat.OpenXml.Wordprocessing.RunFonts() { Ascii = "Arial" },
                                                         new DocumentFormat.OpenXml.Wordprocessing.FontSize() { Val = "9" },
                                                         new Paragraph(new DocumentFormat.OpenXml.Wordprocessing.Run(new DocumentFormat.OpenXml.Wordprocessing.Text(data1[i])),
                                                              new DocumentFormat.OpenXml.Wordprocessing.RunFonts() { Ascii = "Arial" })
                                                         ));

                              tr.Append(tc);

                             

                              tc2.Append(new TableCellProperties(
                            new TableCellWidth { Type = TableWidthUnitValues.Dxa ,Width ="350" },
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
                                                         new TableCellWidth { Type = TableWidthUnitValues.Auto  },
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

        private void tsb_Verificacion_Click(object sender, EventArgs e)
        {
            DataSet dt;
            dt = Cargar_DosimetrioAnual();

            frmreporte frm = new frmreporte(dt, dt, 5);
            frm.Show(this);
        }

        private DataSet Cargar_DosimetrioAnual()
        {
            SqlCommand cmd = new SqlCommand();

            //  SqlCommand cmd = new SqlCommand();
            Int64 intanno;
            
            cmd.CommandText = "rtpDosimetriaVerificar " + cbx_id_periodo.SelectedValue.ToString();
            //cmd.CommandText = "SELECT Id_Periodo,Anno, Mes,Id_TipoPeriodo FROM conf_periodo WHERE Id_TipoPeriodo=3";
            DataSet dt;
            dt = Conectar.Listar(Clases.clsBD.BD,cmd);

            return dt;

        }

        private void cbx_id_periodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "pa_Sel_ArchivoISP_sel " + cbx_id_periodo.SelectedValue.ToString();
            //cmd.CommandText = "SELECT Id_Periodo,Anno, Mes,Id_TipoPeriodo FROM conf_periodo WHERE Id_TipoPeriodo=3";
            
            dt = Conectar.Listar(Clases.clsBD.BD,cmd);
            if(dt != null)
            {
                lbl_Status.Text= dt.Tables[0].Rows.Count > 0 ? "Se ha generado los datos para descargar los archivos" : "No se ha generado los datos para este periodo";
                btn_Entidades.Enabled = dt.Tables[0].Rows.Count > 0 ? true : false;
                btn_Toes.Enabled = dt.Tables[1].Rows.Count > 0 ? true : false;
                btn_Dosis.Enabled = dt.Tables[2].Rows.Count > 0 ? true : false;
                lbl_Status.ForeColor = dt.Tables[0].Rows.Count > 0 ? System.Drawing.Color.Green : System.Drawing.Color.Red;                 
            }
            else
            {
                lbl_Status.Text = "No se ha generado los datos para este periodo";
                lbl_Status.ForeColor = System.Drawing.Color.Red;
            }
            this.Refresh();
            Cursor = Cursors.Default;
        }

        private void btn_Entidades_Click(object sender, EventArgs e)
        {
            frmreporte frm = new frmreporte(dt, null, 6);
            frm.Show(this);
        }

        private void btn_Toes_Click(object sender, EventArgs e)
        {
            frmreporte frm = new frmreporte(dt, null, 7);
            frm.Show(this);
        }

        private void btn_Dosis_Click(object sender, EventArgs e)
        {
            frmreporte frm = new frmreporte(dt, null, 8);
            frm.Show(this);
        }
    }
}
