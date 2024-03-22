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
	public partial class frmDosimetriaISP : Form
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
		DataTable dtPeriodo;
		#endregion

		public frmDosimetriaISP(Int64 intId_Cliente)
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
			lbl_id_cliente.Text = intId_Cliente.ToString();
			Cargar_Encabezado();
			btn_Guardar.Visible = false;
			pnl_Progreso.Visible = false;
			lbl_Original.Text = RutaArchivo().Replace("\\", "/");
			lbl_Alternativa.Text = "C:/Doc_Xray/";
			rbtOiginal.Checked = true;
		}

		#region "Llamada de carga"
		private void Cargar_Encabezado()
		{
			Cursor = Cursors.WaitCursor;
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
				dt = Conectar.Listar(Clases.clsBD.BD, cmd);

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

					//btn_Cargar_cliente.Enabled = false;
					//}
				}

			}
			Cursor = Cursors.Default;
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
		private void Cargar_Cliente(Int64 intCodCliente)
		{
			SqlCommand cmd = new SqlCommand();
			//	SqlCommand cmd = new SqlCommand();

			cmd.CommandText = "SELECT run,Razon_Social,N_Cliente_Ref,Direccion,Id_Region,Id_Provincia,Id_Comuna,Telefono, Id_TipoFuente,Id_estado,Fechainicio " +
							" FROM tbl_cliente WHERE Id_cliente= " + intCodCliente.ToString();
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			lbl_id_cliente.Text = intCodCliente.ToString();
			lbl_nombreCliente.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
			lbl_rut_cliente.Text = dt.Tables[0].Rows[0]["run"].ToString();
		}

		private void Listar_Personal()
		{
			SqlCommand cmd = new SqlCommand();
			//SqlCommand cmd = new SqlCommand();

			DataSet dt;
			cmd.CommandText = " pa_DosimetroISP_Cliente_sel " + cbx_id_periodo.SelectedValue + "," + lbl_id_cliente.Text + "," + cbx_Sucursal.SelectedValue;
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


			//if (dt.Tables[0].Rows.Count == 0)
			//{
			//	btn_Guardar.Visible = false;
			//	grdDatos.DataSource = dt.Tables[0];
			//	MessageBox.Show("No se han cargado ningun personal");
			//}
			//else
			//{
				btn_Guardar.Visible = true;
				grdDatos.DefaultCellStyle.BackColor = System.Drawing.Color.White;
				grdDatos.DataSource = dt.Tables[0];
			//}
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
			DataTable dtPeriodoCopia = dtPeriodo.Copy();
			dtPeriodoCopia.DefaultView.RowFilter = String.Format("anno={0}", cbx_anno.SelectedValue);

			cbx_id_periodo.DataSource = dtPeriodoCopia.DefaultView.ToTable();
		}

		private void Cargar_Sucursal()
		{
			SqlCommand cmdSucursal = new SqlCommand();
			cmdSucursal.CommandText = "select 0 as Id_sucursal, 'Todos' as Direccion union all " +
									"SELECT distinct s.Id_sucursal, " +
									"case when s.Direccion is null or s.Direccion ='' then c.Direccion else s.Direccion end + ',' + comuna as Direccion" + //N_Documento,
									  " FROM [dbo].[ges_DosimetriaPersonal] dos inner join tbl_cliente c on c.Id_cliente=dos.Id_cliente " +
										" inner join tbl_sucursal s on s.Id_sucursal=dos.Id_Sucursal    and  s.run='" + lbl_rut_cliente.Text + "'" +
										" inner  join glo_region R on s.id_region=r.id_region inner join glo_provincia p on p.id_provincia=s.Id_Provincia  " +
									  " inner join glo_comuna co on co.Id_Comuna=s.Id_Comuna " +
									  "WHERE c.Id_cliente= " + lbl_id_cliente.Text + " and dos.id_periodo=" + cbx_id_periodo.SelectedValue + "";
			cmdSucursal.CommandType = CommandType.Text;
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmdSucursal);
			cbx_Sucursal.DisplayMember = dt.Tables[0].Columns[1].Caption.ToString();
			cbx_Sucursal.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
			cbx_Sucursal.DataSource = dt.Tables[0];

		}

		private void AsignarEvento()
		{
			//this.txt_Rut.KeyPress += new KeyPressEventHandler(ClaseEvento.Rut_KeyPress);
			//txt_Rut.KeyDown += new KeyEventHandler(ClaseEvento.Rut_KeyDown);
			//txt_Rut.Validated += new EventHandler(ClaseEvento.validarut_Validated);

			//txt_ref_cliente.KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
			//txt_ref_cliente.KeyDown += new KeyEventHandler(ClaseEvento.Numero_KeyDown);

			//txt_RazonSocial.KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);


		}

		private void Generar_Todos()
		{

		}
		private void GenerarPorSucursal()
		{

		}

		#endregion

		#region "button"


		private void btn_Filtro_Click(object sender, EventArgs e)
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

		private void btn_cargar_Click(object sender, EventArgs e)
		{
			Cargar_Sucursal();
			Listar_Personal();
			cbx_anno.Enabled = false;
			cbx_id_periodo.Enabled = false;
			grdDatos.Focus();
		}

		private void btn_Guardar_Click(object sender, EventArgs e)
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
			btn_Guardar.Enabled = false;

			SqlCommand cmdArchivo = new SqlCommand();
			//SqlCommand cmdcombo = new SqlCommand();
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
			//targetPath = dtArchivo.Tables[0].Rows[0]["Glosa"].ToString() + "Cliente " + lbl_id_cliente.Text + "\\" + cbx_anno.Text;
			targetPath = targetPath + "\\" + cbx_anno.Text;
			if (!System.IO.Directory.Exists(targetPath))
			{
				System.IO.Directory.CreateDirectory(targetPath);
			}

			// targetPath = ConfigurationManager.AppSettings["Archivo"] + "Cliente " + lbl_id_cliente.Text + "\\" + cbx_anno.Text + "\\" + cbx_id_periodo.Text + "\\";
			//targetPath = dtArchivo.Tables[0].Rows[0]["Glosa"].ToString() + "Cliente " + lbl_id_cliente.Text + "\\" + cbx_anno.Text + "\\" + cbx_id_periodo.Text + "\\";
			targetPath = targetPath + "\\" + cbx_id_periodo.Text + "\\";

			if (!System.IO.Directory.Exists(targetPath))
			{
				System.IO.Directory.CreateDirectory(targetPath);
			}
			//Environment.CurrentDirectory = (targetPath);
			//  Process.Start("explorer.exe" ,"root=" + targetPath.Replace("\\\\")  );
			// strpath =ConfigurationManager.AppSettings["Archivo"] +  "cliente.xlsx";//Application.StartupPath.ToString(); 
		//	strpath = dtformato.Tables[0].Rows[0]["Glosa"].ToString() + "cliente.xlsx";//Application.StartupPath.ToString(); 
			if (rbtOiginal.Checked)
				strpath = dtformato.Tables[0].Rows[0]["Glosa"].ToString() + "cliente.xlsx";//Application.StartupPath.ToString(); 
			else
				strpath = @"C:\\Doc_Xray\\baseCliente\\Plantilla\\cliente.xlsx";

			//**************carga periodo
			DataSet dtPeriodo;
			// SqlCommand cmdPeriodo = new SqlCommand();
			SqlCommand cmdPeriodo = new SqlCommand();

			cmdPeriodo.CommandText = "SELECT fecha_inicio,fecha_termino " +
										" FROM conf_periodo " +
							//"where mes =3 and anno=" + cbx_anno.Text;  
							"WHERE  Id_Periodo= " + cbx_id_periodo.SelectedValue;
			cmdPeriodo.CommandType = CommandType.Text;
			dtPeriodo = Conectar.Listar(Clases.clsBD.BD, cmdPeriodo);
			string strfecha_inicio = dtPeriodo.Tables[0].Rows[0]["fecha_inicio"].ToString();
			string strfecha_termino = dtPeriodo.Tables[0].Rows[0]["fecha_termino"].ToString();
			//**************carga cliente
			//SqlCommand cmdCliente = new SqlCommand();
			SqlCommand cmdCliente = new SqlCommand();

			//         SELECT distinct 0 as Generar,isnull(d.enviado,0)enviado,N_pelicula, 
			//    d.N_Documento,p.id_cliente,p.Id_Personal,Rut, Nombres,Paterno,Maternos, 
			//    isnull(d.ConDosis,0)condosis,
			//    d.Dosis,isnull(d.Id_EstadoDosis,0)estadodosis, 
			//    isnull(d.Id_Dosimetro,0)Id_Dosimetro
			//    ,id_sucursal,tld
			//FROM tbl_personal p inner join ges_dosimetro_estado_TLD tld on p.Id_Personal=tld.Id_Personal	 
			// left join tbl_dosimetria d on d.id_cliente=tld.id_cliente   and  d.id_personal=tld.id_personal  and   TLD=1  
			// WHERE p.id_cliente=@id_cliente  and Controlado=1
			//    and (tld.Id_Sucursal =@Id_Sucursal or @Id_Sucursal=0) 
			//    and  d.id_periodo=@id_periodo 
			if (cbx_Sucursal.SelectedValue.ToString() != "0")
			{
				cmdCliente.CommandText = "SELECT distinct case when runsuc is null or runsuc ='' then c.run else runsuc end as run, " +
										"case when s.Direccion is null or s.Direccion ='' then c.Direccion else s.Direccion end as Direccion," +
										"case when s.Razon_Social is null or s.Razon_Social ='' then c.Razon_Social else s.Razon_Social end as Razon_Social," +
										" region,Provincia,comuna,s.Telefono,s.Id_sucursal" + //N_Documento,
									 " FROM [dbo].[ges_DosimetriaPersonal] dos inner join tbl_cliente c on c.Id_cliente=dos.Id_cliente " +
									 " inner join tbl_sucursal s on s.Id_sucursal=dos.Id_Sucursal   and  s.run='" + lbl_rut_cliente.Text + "'" +
									 " inner  join glo_region R on s.id_region=r.id_region inner join glo_provincia p on p.id_provincia=s.Id_Provincia  " +
									 " inner join glo_comuna co on co.Id_Comuna=s.Id_Comuna " +
									 "WHERE c.Id_cliente= " + lbl_id_cliente.Text + " and dos.id_periodo=" + cbx_id_periodo.SelectedValue + "" +
									 " and (dos.Id_Sucursal =" + cbx_Sucursal.SelectedValue + ")and  C.run='" + lbl_rut_cliente.Text+"'";
			}
			else
			{
				cmdCliente.CommandText = "SELECT distinct case when runsuc is null or runsuc ='' then c.run else runsuc end as run, " +
									 "case when s.Direccion is null or s.Direccion ='' then c.Direccion else s.Direccion end as Direccion," +
									 "case when s.Razon_Social is null or s.Razon_Social ='' then c.Razon_Social else s.Razon_Social end as Razon_Social," +
									 " region,Provincia,comuna,s.Telefono,s.Id_sucursal" + //N_Documento,
								  " FROM [dbo].[ges_DosimetriaPersonal] dos inner join tbl_cliente c on c.Id_cliente=dos.Id_cliente " +
									" inner join tbl_sucursal s on s.Id_sucursal=dos.Id_Sucursal  and  s.run='" + lbl_rut_cliente.Text + "'" +
								  " inner  join glo_region R on s.id_region=r.id_region inner join glo_provincia p on p.id_provincia=s.Id_Provincia  " +
								  " inner join glo_comuna co on co.Id_Comuna=s.Id_Comuna " +
								  "WHERE c.Id_cliente= " + lbl_id_cliente.Text + " and dos.id_periodo=" + cbx_id_periodo.SelectedValue + " and  C.run='" + lbl_rut_cliente.Text + "'";
			}
			cmdCliente.CommandType = CommandType.Text;
			DataSet dt;
			DataSet dtCliente;
			dt = Conectar.Listar(Clases.clsBD.BD, cmdCliente);



		//	string strArchivo = dtformato.Tables[0].Rows[0]["Glosa"].ToString() + "Plantillaword.docx";

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
				strArchivoCopiar = targetPath + "Cliente" + lbl_id_cliente.Text + "_" + strDireccionEmpresa + "_" + cbx_id_periodo.Text.ToString().Substring(0, 1) + "T_" + cbx_anno.Text + ".docx";


				strpathcopiar = targetPath + "cliente " + lbl_id_cliente.Text + "_" + strDireccionEmpresa + ".xlsx";

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
						SqlCommand cmdcombo = new SqlCommand();

						cmdcombo.CommandText = " " +
						  "SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=2 and Id_DetParametro= " + cbxEstado.Value.ToString() +
						  "order by orden ";
						cmdcombo.CommandType = CommandType.Text;
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

								cmd.CommandText = "pa_DosimetroIngreso_upd " + txtnpelicula.Value.ToString() + ",5,'" + Clases.clsUsuario.Usuario +
												  "',''," + cbx_id_periodo.SelectedValue.ToString() + "," + lbl_id_cliente.Text;
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

			btn_Guardar.Enabled = true;
			pnl_Progreso.Visible = false;

			Listar_Personal();
		}

		private void btn_filtro_Click_1(object sender, EventArgs e)
		{
			cbx_anno.Enabled = true;
			cbx_id_periodo.Enabled = true;
			groupBox2.Text = "Listado";
			cbx_anno.Focus();
		}

		private void btn_Cerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_Corregir_Click(object sender, EventArgs e)
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

		private void btn_Sucursal_Click(object sender, EventArgs e)
		{
			frmDireccion frm = new frmDireccion();
			frm.ShowDialog(this);
		}

		#endregion

		#region "combobox"
		private void cbx_Sucursal_SelectedIndexChanged(object sender, EventArgs e)
		{
			Listar_Personal();
		}
		private void cbx_anno_SelectedIndexChanged(object sender, EventArgs e)
		{
			Cargar_Periodo();
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

		private void grdDatos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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

		private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void grdDatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{

			//this.grdDatos.Columns["Dosis"].ValueType = typeof(Decimal);
			//this.grdDatos.Columns["Dosis"].DefaultCellStyle.Format = "N2";
		}

	

		





	}
}
