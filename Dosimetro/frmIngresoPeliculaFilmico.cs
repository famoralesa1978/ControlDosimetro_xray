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
using Microsoft.Reporting.WinForms;
using classFuncionesBD;
using NPOI.Util;

namespace ControlDosimetro
{
	public partial class frmIngresoPeliculaFilmico : Form
	{

		#region "Definicion variable"
		Clases.ClassEvento clsEvt = new Clases.ClassEvento();
		readonly clsConectorSqlServer Conectar = new clsConectorSqlServer();
		readonly clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsConectorSqlServerV2 Conectar2 = new clsConectorSqlServerV2();
		readonly clsEventoControl ClaseEvento = new clsEventoControl();
		classFuncionesBD.ClsFunciones FuncBD = new classFuncionesBD.ClsFunciones();
		ClsFunciones clsFunc = new ClsFunciones();
		int intContar = 0;
		DataTable dtPeriodo;
		public string Id_Menu { get; private set; }

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

		bool desdeCodigo = false;

		#endregion

		#region "inicio"
		public frmIngresoPeliculaFilmico(Int64 intId_Cliente)
		{
			InitializeComponent();

			AsignarEvento();
			grp_Ingreso.Enabled = false;
			pnl_Progreso.Visible = false;
			btn_cargar.Enabled = true;
			dtp_Fecha_inicio.Text = DateTime.Now.Date.ToString();
			lbl_id_cliente.Focus();
			lbl_nombreCliente.Text = "";
			lbl_rut.Text = "";
			lbl_Direccion.Text = "";
		}

		private void frmIngresoPeliculaFilmico_Load(object sender, EventArgs e)
		{
			Cargar_Reporte();
		}

		#endregion

		#region "Llamada de carga"
		private void Listar_Grilla(int intCliente,int intPeriodo,int intSucursal)
		{
			SqlCommand cmd = new SqlCommand();

			DataSet dt;

			cmd.CommandText = "pa_ConsultaIngFilmicoPorSucursal_sel";
			cmd.Parameters.Add("@id_cliente", SqlDbType.Int);
			cmd.Parameters["@id_cliente"].Value = intCliente;
			cmd.Parameters.Add("@id_periodo", SqlDbType.Int);
			cmd.Parameters["@id_periodo"].Value = intPeriodo;
			cmd.Parameters.Add("@Id_sucursal", SqlDbType.Int);
			cmd.Parameters["@Id_sucursal"].Value = intSucursal;
			cmd.CommandType = CommandType.StoredProcedure;

			dt = Conectar.Listar(Clases.clsBD.BD, cmd);
			grdDatos.DataSource = dt.Tables[0];
			txt_NDocumento.Text = dt.Tables[1].Rows[0]["N_Documento"].ToString();
			btnRefrescarNDcto.Visible = btn_Imprimir.Enabled = dt.Tables[0].Rows.Count > 0;

		}

		private void Cargar_Anno()
		{
			SqlCommand cmd = new SqlCommand();

			//	  SqlCommand cmd = new SqlCommand();

			cmd.CommandText = "pa_ObtieneAnno_sel 3";
			//cmd.CommandText = "SELECT Id_Periodo,Anno, Mes,Id_TipoPeriodo FROM conf_periodo WHERE Id_TipoPeriodo=3";
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			cbx_anno.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
			cbx_anno.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
			cbx_anno.DataSource = dt.Tables[0];


		}

		private void Cargar_Periodo()
		{
			DataTable dtPeriodoCopia = dtPeriodo.Copy();
			dtPeriodoCopia.DefaultView.RowFilter = String.Format("anno={0}", cbx_anno.SelectedValue);

			cbx_id_periodo.DataSource = dtPeriodoCopia.DefaultView.ToTable();
			cbx_id_periodo.DisplayMember = "Trimestre";
			cbx_id_periodo.ValueMember = "Id_Periodo";
		}

		private void Cargar_Sucursal()
		{
			int intIdCliente = String.IsNullOrEmpty(lbl_id_cliente.Text) ? 0 : Convert.ToInt16(lbl_id_cliente.Text);
			FuncBD.Cargar_Sucursal(ref cbx_Sucursal, lbl_rut.Text, intIdCliente, 1);
		}

		private void AsignarEvento()
		{
			txt_Pelicula.EventoAsignarNumero(9);
			txt_PeliculaHasta.EventoAsignarNumero(9);
			txt_pelrefhasta.EventoAsignarNumero(9);
			txt_pelrefdesde.EventoAsignarNumero(9);
			txt_NDocumento.EventoAsignarNumero(9);
		}
		public DataSet RptInforme()
		{
			DataSet ds = new DataSet();
			SqlCommand cmd = new SqlCommand();
			// SqlCommand cmd = new SqlCommand();
			//MessageBox.Show("Conectado al servidor");

			cmd.CommandText = "rptDctoFilmico";
			cmd.Parameters.Add("@id_cliente", SqlDbType.Int);
			cmd.Parameters["@id_cliente"].Value = lbl_id_cliente.Text;
			cmd.Parameters.Add("@Rut", SqlDbType.VarChar, 20);
			cmd.Parameters["@Rut"].Value = lbl_rut.Text;
			cmd.Parameters.Add("@NDocumento", SqlDbType.BigInt);
			cmd.Parameters["@NDocumento"].Value = txt_NDocumento.Text;
			cmd.CommandType = CommandType.StoredProcedure;

			ds = Conectar.Listar(Clases.clsBD.BD, cmd);

			return ds;
		}

		#endregion

		#region Texto


		#endregion

		#region "button"
		private void tsbEliminarDcto_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txt_NDocumento.Text))
			{
				"Debe tener un número de documento".XMensajeError();
				return;
			}
			string strMensaje = string.Format("Desea eliminar el número de documento {0}.¿Confirmar?", txt_NDocumento.Text);
			if (strMensaje.XMensajeConfirmacionOKCancel())
			{
				string strMensajeError = "";
				SqlCommand cmd = new SqlCommand();
				cmd.CommandText = "pa_FilmicoDocumentoDel";
				cmd.Parameters.Add("@id_cliente", SqlDbType.Int);
				cmd.Parameters["@id_cliente"].Value = lbl_id_cliente.Text;
				cmd.Parameters.Add("@n_documento", SqlDbType.Int);
				cmd.Parameters["@n_documento"].Value = txt_NDocumento.Text;

				cmd.CommandType = CommandType.StoredProcedure;
				Conectar2.AgregarModificarEliminar(ClaseGeneral.Conexion, cmd, ref strMensajeError);
				if (!string.IsNullOrWhiteSpace(strMensajeError))
				{
					Cursor = Cursors.Default;
					ClaseGeneral.GuardarLOG(this.Name, "pa_FilmicoDocumentoDel", "Delete");
				}
				
			}
		}
		private void BtnIngresarDosisISP_Click(object sender, EventArgs e)
		{
			frmDosimetriaISP frm = new frmDosimetriaISP(Convert.ToInt64(lbl_id_cliente.Text));
			frm.ShowDialog(this);
		}
		private void Btn_Agregar_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txt_NDocumento.Text))
			{
				MessageBox.Show("Ingrese número de documento");
				return;
			}
			SqlCommand cmdvalidar = new SqlCommand();

			DataSet dt;

			cmdvalidar.CommandText = "pa_ObtieneUltimoValornDocumento_sel " + txt_NDocumento.Text+","+ lbl_id_cliente.Text+","+ cbx_id_periodo.SelectedValue.ToString();

			dt = Conectar.Listar(Clases.clsBD.BD, cmdvalidar);

			if (dt.Tables[0].Rows.Count > 0)
			{
				MessageBox.Show("El número de documento ya existe");
				return;
			}

			SqlCommand cmd = new SqlCommand();
			DataSet ds;

			Int64 intFinal;
			Int64 intInicio;
			Int64 intFinalref;
			Int64 intInicioref;
			String strMensajeAdv = "";


			if (txt_pelrefdesde.Text != "")
			{
				if (txt_pelrefhasta.Text == "")
					intFinalref = Convert.ToInt64(txt_pelrefdesde.Text);
				else
					intFinalref = Convert.ToInt64(txt_pelrefhasta.Text);

				intInicioref = Convert.ToInt64(txt_pelrefdesde.Text);
			}
			else
			{
				intFinalref = 0;
				intInicioref = 0;
			}

			if (txt_Pelicula.Text != "")
			{
				if (txt_PeliculaHasta.Text == "")
					intFinal = Convert.ToInt64(txt_Pelicula.Text);
				else
					intFinal = Convert.ToInt64(txt_PeliculaHasta.Text);

				intInicio = Convert.ToInt64(txt_Pelicula.Text);
			}
			else
			{
				intFinal = 0;
				intInicio = 0;
			}

			if (cbx_Sucursal.Text == "")
			{
				MessageBox.Show("Le falta asignar una sucursal");
			}
			if ((intInicioref == 0) && (intInicio == 0))
			{
				MessageBox.Show("Ingrese  de pelicula o pelicula de referencia");
			}
			else
			if ((intInicioref != 0) && (intInicioref > intFinalref))
			{
				MessageBox.Show("El número de pelicula de referencia hasta debe ser mayor o igual que el inicio");
			}
			else
				 if ((intInicio != 0) && (intInicio > intFinal))
			{
				MessageBox.Show("El número de pelicula hasta debe ser mayor o igual que el inicio");
			}
			else
			{
				if (txt_NDocumento.Text == "")
				{
					MessageBox.Show("Ingrese el número el n° Documento");
				}
				long intsuma;
				intsuma = (intFinal - intInicio) + 1;
				if (intsuma == 0 && chk_Ref.Checked == false)
					intsuma = 1;
				else
				{
					if (chk_Ref.Checked == true)
						intsuma = 0;
				}
				{
					string strError = "";
					if (intInicio != 0)
					{


						while (intInicio <= intFinal)
						{
							//if(chk_Ref.Checked ==true)
							//    cmd.CommandText = "pa_Dosimetro_ins " + lbl_id_cliente.Text + "," + cbx_id_periodo.SelectedValue + "," + txt_NDocumento.Text + "," + intInicio.ToString() + ",'" + dtp_Fecha_inicio.Text + "','" + Clases.clsUsuario.Usuario + "',1,'" + txt_Observacion.Text + "'";
							//else
							cmd.CommandText = "pa_Dosimetro_ins " + lbl_id_cliente.Text + "," + cbx_id_periodo.SelectedValue + "," + txt_NDocumento.Text + "," + intInicio.ToString() + ",'" + dtp_Fecha_inicio.Text + "','" + Clases.clsUsuario.Usuario + "',0,'" + txt_Observacion.Text + "'";
							cmd.CommandType = CommandType.Text;

							// Conectar.AgregarModificarEliminar(Clases.clsBD.BD,cmd);


							ds = Conectar.Listar(Clases.clsBD.BD, cmd);
							if (ds.Tables[0].Rows.Count > 0)
							{

								if (ds.Tables[0].Rows[0][0].ToString() != "-1")
								{
									//if (MessageBox.Show("Desea ingresar el dosimetro  y  tiene siguiente error" + System.Environment.NewLine + ds.Tables[0].Rows[0][1].ToString(), "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
									//{
									strMensajeAdv = strMensajeAdv + System.Environment.NewLine + ds.Tables[0].Rows[0][1].ToString();
									cmd.CommandText = "pa_DosimetroForzar_ins " + lbl_id_cliente.Text + "," + cbx_id_periodo.SelectedValue + "," + txt_NDocumento.Text + "," + intInicio.ToString() + ",'" + dtp_Fecha_inicio.Text + "','" + Clases.clsUsuario.Usuario + "',0,'" + txt_Observacion.Text + "'";
									cmd.CommandType = CommandType.Text;

									// Conectar.AgregarModificarEliminar(Clases.clsBD.BD,cmd);


									ds = Conectar.Listar(Clases.clsBD.BD, cmd);

									if (ds.Tables[0].Rows[0][0].ToString() != "-1")
									{
										strError = strError + System.Environment.NewLine + ds.Tables[0].Rows[0][1].ToString();
									}
									//}
									//else
									//    strError = strError+ System.Environment.NewLine+ ds.Tables[0].Rows[0][1].ToString() ;
								}
							}
							intInicio = intInicio + 1;
						}
						if (strError != "")
						{
							MessageBox.Show(strError);
						}
						if (strMensajeAdv != "")
						{
							MessageBox.Show("Tiene siguiente advertecia :" + System.Environment.NewLine + strMensajeAdv);
						}
					}
					if (intInicioref != 0)
					{
						while (intInicioref <= intFinalref)
						{
							//if(chk_Ref.Checked ==true)
							cmd.CommandText = "pa_Dosimetro_ins " + lbl_id_cliente.Text + "," + cbx_id_periodo.SelectedValue + "," + txt_NDocumento.Text + "," + intInicioref.ToString() + ",'" + dtp_Fecha_inicio.Text + "','" + Clases.clsUsuario.Usuario + "',1,'" + txt_Observacion.Text + "'";
							//else
							//cmd.CommandText = "pa_Dosimetro_ins " + lbl_id_cliente.Text + "," + cbx_id_periodo.SelectedValue + "," + txt_NDocumento.Text + "," + intInicio.ToString() + ",'" + dtp_Fecha_inicio.Text + "','" + Clases.clsUsuario.Usuario + "',0,'" + txt_Observacion.Text + "'";
							cmd.CommandType = CommandType.Text;

							// Conectar.AgregarModificarEliminar(Clases.clsBD.BD,cmd);


							ds = Conectar.Listar(Clases.clsBD.BD, cmd);
							if (ds.Tables[0].Rows.Count > 0)
							{
								if (ds.Tables[0].Rows[0][0].ToString() != "-1")
								{
									//if (MessageBox.Show("Desea ingresar el dosimetro  y  tiene siguiente error" + System.Environment.NewLine + ds.Tables[0].Rows[0][1].ToString(), "mensaje", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
									//{
									cmd.CommandText = "pa_DosimetroForzar_ins " + lbl_id_cliente.Text + "," + cbx_id_periodo.SelectedValue + "," + txt_NDocumento.Text + "," + intInicioref.ToString() + ",'" + dtp_Fecha_inicio.Text + "','" + Clases.clsUsuario.Usuario + "',1,'" + txt_Observacion.Text + "'";
									cmd.CommandType = CommandType.Text;

									// Conectar.AgregarModificarEliminar(Clases.clsBD.BD,cmd);


									ds = Conectar.Listar(Clases.clsBD.BD, cmd);

									if (ds.Tables[0].Rows[0][0].ToString() != "-1")
									{
										strError = strError + System.Environment.NewLine + ds.Tables[0].Rows[0][1].ToString();
									}
									//}
									//else
									//    strError = strError + System.Environment.NewLine + ds.Tables[0].Rows[0][1].ToString();
								}
							}

							intInicioref = intInicioref + 1;
						}

					}

					if (strError != "")
					{
						MessageBox.Show(strError);
					}
					//if ((intInicioref == 0) && (intFinalref==0))    

					SqlCommand cmd1 = new SqlCommand();
					DataSet ds1;
					cmd1.CommandText = "pa_DosimetroPersonal_ins " + lbl_id_cliente.Text + "," + cbx_id_periodo.SelectedValue + "," + cbx_Sucursal.SelectedValue + ",'" + txt_Servicio.Text + "'," + txt_NDocumento.Text + ",'" + dtp_Fecha_dev.Text.Replace("-", " de ") + "'";
					cmd1.CommandType = CommandType.Text;

					ds1 = Conectar.Listar(Clases.clsBD.BD, cmd1);



					if (lbl_id_cliente.Text.Trim() != "")//id_ref=0 and
					{
						cmd1.CommandText = "select cast(count(n_dosimetro) as varchar(3))cant from ges_dosimetro_estado es where  es.Id_cliente = " + lbl_id_cliente.Text + " and es.id_periodo=" + cbx_id_periodo.SelectedValue.ToString() + " and Id_sucursal=" + cbx_Sucursal.SelectedValue.ToString() + " group by Id_sucursal";
						cmd1.CommandType = CommandType.Text;

						ds1 = Conectar.Listar(Clases.clsBD.BD, cmd1);
						if (ds1.Tables[0].Rows.Count > 0)
						{
							grpListado.Text = "Listado        Cantidad de dosimetro ingresado  por Sucursal es:" + ds1.Tables[0].Rows[0][0].ToString();
						}
						else
							grpListado.Text = "Listado        Cantidad de dosimetro ingresado  por Sucursal es: 0";
					}

					Listar_Grilla(Convert.ToUInt16(lbl_id_cliente.Text), (int)cbx_id_periodo.SelectedValue, (int)cbx_Sucursal.SelectedValue);
					txt_pelrefdesde.Text = "";
					txt_pelrefhasta.Text = "";
					txt_Pelicula.Text = "";
					txt_PeliculaHasta.Text = "";
					pnl_Progreso.Visible = false;
				}

			}
		}
		private void btn_Filtro_Click(object sender, EventArgs e)
		{

		}
		private void btn_cargar_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(lbl_id_cliente.Text)) return;

			lbl_nombreCliente.Text = "";
			lbl_rut.Text = "";
			lbl_Direccion.Text = "";

			frmAyudaCliente frm = new frmAyudaCliente(Convert.ToInt64(lbl_id_cliente.Text));

			if (frm.ShowDialog() == DialogResult.OK)
			{
				lbl_nombreCliente.Text = (Convert.ToInt64(lbl_id_cliente.Text) > 1) ? Clases.ClsCliente.Nombres : "";
				lbl_rut.Text = (Convert.ToInt64(lbl_id_cliente.Text) > 1) ? Clases.ClsCliente.Rut : "";
				lbl_Direccion.Text = (Convert.ToInt64(lbl_id_cliente.Text) > 1) ? Clases.ClsCliente.Direccion : "";
				if (frm.ShowDialog() == DialogResult.OK)
				{

					SqlCommand cmd = new SqlCommand
					{
						CommandText = String.Format("CargarClientePorRun '{0}',{1}", lbl_rut.Text, lbl_id_cliente.Text)
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

						DataTable dtSucursal = dt.Tables[2].Copy();
						dtSucursal.DefaultView.RowFilter = "Id_estado=1";

						cbx_Sucursal.DataSource = dtSucursal.DefaultView.Table;
						grp_Ingreso.Enabled = true;
						grpListado.Enabled = true;
						btn_cargar.Enabled = false;
						cbx_anno.Enabled = true;
						cbx_id_periodo.Enabled = true;
						cbx_Sucursal.Enabled = true;
						btnFiltrar.Enabled = dtSucursal.DefaultView.Table.Rows.Count > 0;
						//}
					}

				}
				Cursor = Cursors.Default;
			}
		}
		private void btn_filtro_Click_1(object sender, EventArgs e)
		{
			desdeCodigo = true;
			lbl_id_cliente.Clear();
			cbx_anno.Enabled = false;
			cbx_id_periodo.Enabled = false;
			cbx_anno.SelectedIndex = -1;
			cbx_id_periodo.SelectedIndex = -1;
			cbx_Sucursal.Enabled = false;
			cbx_Sucursal.SelectedIndex = -1;
			lbl_nombreCliente.Text = "";
			lbl_rut.Text = "";
			lbl_Direccion.Text = "";


			btnFiltrar.Enabled = false;
			desdeCodigo = false;

			txt_Pelicula.Clear();
			txt_PeliculaHasta.Clear();
			chk_Ref.Checked = false;
			txt_pelrefdesde.Clear();
			txt_pelrefhasta.Clear();
			txt_NDocumento.Clear();
			txt_Servicio.Clear();
			txt_Observacion.Clear();
			Listar_Grilla(0, 0, 0);
			grp_Ingreso.Enabled = false;
			grpListado.Enabled = false;
			btn_Imprimir.Enabled = false;

			btn_cargar.Enabled = true;
		}
		private void btn_Cerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void btnFiltrar_Click(object sender, EventArgs e)
		{
			if(!desdeCodigo)
				Listar_Grilla(Convert.ToUInt16(lbl_id_cliente.Text), (int)cbx_id_periodo.SelectedValue,(int)cbx_Sucursal.SelectedValue);
		}
		private void btnRefrescarNDcto_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrWhiteSpace(txt_NDocumento.Text))
			{
				MessageBox.Show("Ingrese número de documento");
				return;
			}

			SqlCommand cmd = new SqlCommand();

			DataSet dt;

			cmd.CommandText = "pa_ObtieneUltimoValornDocumento_sel " + txt_NDocumento.Text + "," + lbl_id_cliente.Text + "," + cbx_id_periodo.SelectedValue.ToString();

			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			if (dt.Tables[0].Rows.Count > 0)
			{
				MessageBox.Show("El número de documento ya existe");
				return;
			}
		}

		private void tsmEliminar_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand();
			DataSet ds;


			for (int intfila = 0; intfila <= grdDatos.RowCount - 1; intfila++)
			{
				if (grdDatos.Rows[intfila].Selected == true)
				{
					//cmd.CommandText = "pa_Dosimetro_del " + grdDatos.SelectedRows[intfila].Cells[0].Value.ToString() + ",'" + Clases.clsUsuario.Usuario + "'";
					cmd = new SqlCommand();
					cmd.CommandText = "pa_Dosimetro_del " + grdDatos.Rows[intfila].Cells[0].Value.ToString() + ",'" + Clases.clsUsuario.Usuario + "'";
					cmd.CommandType = CommandType.Text;


					ds = Conectar.Listar(Clases.clsBD.BD, cmd);

					if (ds.Tables[0].Rows[0]["valor"].ToString() != "-1")
					{
						if (MessageBox.Show("Esta seguro de eliminar, esta asociado en otro proceso", "mensaje", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
						{
							cmd = new SqlCommand();
							cmd.CommandText = "pa_DosimetroForzar_del " + grdDatos.Rows[intfila].Cells[0].Value.ToString() + ",'" + Clases.clsUsuario.Usuario + "'";
							cmd.CommandType = CommandType.Text;


							ds = Conectar.Listar(Clases.clsBD.BD, cmd);
						}
					}
				}
			}
			Listar_Grilla(Convert.ToUInt16(lbl_id_cliente.Text), (int)cbx_id_periodo.SelectedValue, (int)cbx_Sucursal.SelectedValue);
		}
		private void tsb_Imprimir_Click(object sender, EventArgs e)
		{
			frmimprimeDocFilmico frm = new frmimprimeDocFilmico();
			frm.strNumero = txt_NDocumento.Text;
			frm.Show(this);
		}

		private void btn_Imprimir_Click(object sender, EventArgs e)
		{

			DataSet dt;
			dt = RptInforme();
			frmreporte frm = new frmreporte(dt, dt, 11);
			frm.Show(this);
		}


		#endregion

		#region "combobox"
		private void cbx_id_periodo_SelectedValueChanged(object sender, EventArgs e)
		{
			if (!desdeCodigo)
			{
				SqlCommand cmd = new SqlCommand();

				DataSet dt;


				cmd.CommandText = "SELECT replace([fecha_termino],'/',' - ')fecha" +
												" FROM conf_periodo " +
												" WHERE  id_periodo=" + cbx_id_periodo.SelectedValue + " ";
				cmd.CommandType = CommandType.Text;

				dt = Conectar.Listar(Clases.clsBD.BD, cmd);
				dtp_Fecha_dev.Text = dt.Tables[0].Rows[0]["fecha"].ToString();

			}

		}
		private void cbx_anno_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!desdeCodigo)
				Cargar_Periodo();
		}
		private void cbx_Sucursal_SelectedValueChanged(object sender, EventArgs e)
		{
			btnFiltrar_Click(null, null);
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
					intContar = intContar + 1;
					grpListado.Text = "Listado       Registro:" + intContar.ToString();

					if (Convert.ToInt64(chkcondosis.Value) == 1)
					{
						txtvalor.ReadOnly = false;
						cbxEstado.ReadOnly = true;
						cbxEstado.Value = 0;
					}
					else
					{
						txtvalor.ReadOnly = true;
						txtvalor.Value = 0.00;
						cbxEstado.ReadOnly = false;
					}
				}
				else
				{
					txtvalor.ReadOnly = true;
					chkcondosis.ReadOnly = true;
					chkcondosis.ReadOnly = true;
					cbxEstado.ReadOnly = true;
					intContar = intContar - 1;
					grpListado.Text = "Listado       Registro:" + intContar.ToString();
				}
			}

		}

		private void grdDatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			//if (e.ColumnIndex == 9) //Column ColB
			//{
			//    if (e.Value != null)
			//    {
			//        try
			//        {
			//            e.CellStyle.Format = "N2";
			//        }
			//        catch (Exception)
			//        {

			//            MessageBox.Show("Ingrese solo número");
			//        }


			//    }
			//}

			//              private void dataGridView1_CellValidating(object sender,
			//    DataGridViewCellValidatingEventArgs e)
			//{
			//    dataGridView1.Rows[e.RowIndex].ErrorText = "";
			//    int newInteger;

			//    // Don't try to validate the 'new row' until finished 
			//    // editing since there
			//    // is not any point in validating its initial value.
			//    if (dataGridView1.Rows[e.RowIndex].IsNewRow) { return; }
			//    if (!int.TryParse(e.FormattedValue.ToString(),
			//        out newInteger) || newInteger < 0)
			//    {
			//        e.Cancel = true;
			//        dataGridView1.Rows[e.RowIndex].ErrorText = "the value must be a non-negative integer";
			//    }
			//}
		}

		#endregion

		#region "Carga"

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




		#endregion

		#region evento Generico controles
		private void Avanzar_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)(Keys.Enter))
			{
				e.Handled = true;
				SendKeys.Send("{TAB}");
			}
		}
		#endregion

	}
}
