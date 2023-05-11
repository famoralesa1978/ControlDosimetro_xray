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

namespace ControlDosimetro
{
	public partial class frmIngresoPeliculaDosi : Form
	{

		#region "Definicion variable"
		Clases.ClassEvento clsEvt = new Clases.ClassEvento();
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();
		classFuncionesBD.ClsFunciones FuncBD = new classFuncionesBD.ClsFunciones();
		ClsFunciones clsFunc = new ClsFunciones();
		int intContar = 0;

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

		#endregion

		public frmIngresoPeliculaDosi(Int64 intId_Cliente)
		{
			InitializeComponent();

			AsignarEvento();
			Cargar_Cliente(intId_Cliente);
			Cargar_Anno();
			
			grp_Ingreso.Enabled = false;
			pnl_Progreso.Visible = false;
			btn_cargar.Enabled = true;
			dtp_Fecha_inicio.Text = DateTime.Now.Date.ToString();
			lbl_id_cliente.Focus();
		}

		private void frmIngresoPelicula_Load(object sender, EventArgs e)
		{
			Cargar_Reporte();
		}


		#region "Llamada de carga"

		private void Cargar_Cliente(Int64 intCodCliente)
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "select run,Razon_Social,N_Cliente_Ref,region + ','+ comuna +','+Direccion as Direccion ,r.Id_Region,c.Id_Provincia,c.Id_Comuna,Telefono, Id_TipoFuente,Id_estado,Fechainicio " +
								 "  FROM tbl_cliente c inner join [dbo].[glo_region] r on c.Id_Region=r.Id_Region inner join glo_comuna co on co.id_comuna=c.id_comuna" +
								 " WHERE Id_cliente= " + intCodCliente.ToString();
			DataSet dt;

			dt = Conectar.Listar(Clases.clsBD.BD, cmd);
			if (dt.Tables[0].Rows.Count > 0)
			{
				lbl_id_cliente.Text = intCodCliente.ToString();
				lbl_rut.Text = dt.Tables[0].Rows[0]["run"].ToString();
				lbl_nombreCliente.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
				lbl_Direccion.Text = dt.Tables[0].Rows[0]["Direccion"].ToString();
				btn_cargar.Enabled = true;
				btn_Cargar_cliente.Enabled = false;
				lbl_id_cliente.Enabled = false;
				grp_Ingreso.Enabled = true;
				cbx_anno.Enabled = false;
				cbx_id_periodo.Enabled = false;
				grp_Ingreso.Enabled = true;
				Cargar_Sucursal();
				txt_Pelicula.Focus();
			}
			else
			{
				btn_Cargar_cliente.Enabled = true;
				btn_cargar.Enabled = false;
				lbl_id_cliente.Enabled = true;
				lbl_nombreCliente.Text = "";
				lbl_Direccion.Text = "";
				lbl_rut.Text = "";
				grp_Ingreso.Enabled = false;
				btn_IngresoDosimetro.Enabled = btn_Imprimir.Enabled = grpListado.Enabled = false;
				Cargar_Sucursal();
				if (intCodCliente != 0)
					MessageBox.Show("El cliente no existe");

			}



			//
		}
		private int Cantidad_InformacionCargada()
		{
			SqlCommand cmd = new SqlCommand();

			DataSet dt;

			cmd.CommandText = "pa_ConsultaIngFilmico_sel " + lbl_id_cliente.Text + " ," + cbx_id_periodo.SelectedValue + "";

			cmd.CommandType = CommandType.Text;

			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			dt.Tables[0].DefaultView.RowFilter = " id_ref=0  and n_documento=" + txt_NDocumento.Text;

			return dt.Tables[0].DefaultView.Count;

		}

		private void Listar_Grilla()
		{
			SqlCommand cmd = new SqlCommand();

			DataSet dt;

			cmd.CommandText = "pa_ConsultaIngFilmico_sel " + lbl_id_cliente.Text + " ," + cbx_id_periodo.SelectedValue + "";
		
			cmd.CommandType = CommandType.Text;

			dt = Conectar.Listar(Clases.clsBD.BD, cmd);
			grdDatos.DataSource = dt.Tables[0];
			btn_IngresoDosimetro.Enabled = btn_Imprimir.Enabled = grpListado.Enabled = grp_Ingreso.Enabled = dt.Tables[0].Rows.Count > 0;
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
			cbx_anno.DataSource = dt.Tables[0];

		}

		private void Cargar_Periodo()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "SELECT Id_Periodo,Mes, cast((mes/3) as varchar(10))+ '°T' FROM conf_periodo WHERE Id_TipoPeriodo=3 and Anno=" + cbx_anno.Text;
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			cbx_id_periodo.DisplayMember = dt.Tables[0].Columns[2].Caption.ToString();
			cbx_id_periodo.ValueMember = dt.Tables[0].Columns[0].Caption.ToString();
			cbx_id_periodo.DataSource = dt.Tables[0];
		}

		private void Cargar_Sucursal()
		{
			int intIdCliente = String.IsNullOrEmpty(lbl_id_cliente.Text) ? 0 : Convert.ToInt16( lbl_id_cliente.Text);
			FuncBD.Cargar_Sucursal(ref cbx_Sucursal, lbl_rut.Text, intIdCliente, 1);
		}

		private void AsignarEvento()
		{
			clsEvt.AsignarNumero(ref txt_Pelicula);
			clsEvt.AsignarNumero(ref txt_PeliculaHasta);
			clsEvt.AsignarNumero(ref txt_pelrefhasta);
			clsEvt.AsignarNumero(ref txt_pelrefdesde);
			clsEvt.AsignarNumero(ref txt_NDocumento);
			clsEvt.AsignarKeyPressDTP(ref dtp_Fecha_inicio);
		}

		#endregion

		#region Texto

		private void txt_NDocumento_Leave(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand();

			DataSet dt;


			cmd.CommandText = "SELECT G.[id],[id_estadodosimetro],n_documento,[n_dosimetro], Descripcion" +
											" FROM ges_dosimetro_estado G inner join glo_estadodosimetro e on e.id=g.id_estadodosimetro" +
											" WHERE ((id_cliente <>" + lbl_id_cliente.Text + " ) or" +
											 " (id_cliente =" + lbl_id_cliente.Text + "  and  id_periodo<>" + cbx_id_periodo.SelectedValue + ")) " +
											" and n_documento=" + txt_NDocumento.Text;
			cmd.CommandType = CommandType.Text;

			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			if (dt.Tables[0].Rows.Count > 0)
			{
				MessageBox.Show("No se puede asignar el n° de documento a otro cliente  o puede estar asignado en otro periodo");
			}
		}

		#endregion

		#region "button"

		private void btnIngresarDosisISP_Click(object sender, EventArgs e)
		{
			frmDosimetriaISP frm = new frmDosimetriaISP(Convert.ToInt64(lbl_id_cliente.Text));
			frm.ShowDialog(this);
		}


		private void btn_Agregar_Click(object sender, EventArgs e)
		{
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


			int intcant;
			intcant = 0;
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
				else
					intcant = Cantidad_InformacionCargada();
				long intsuma;
				intsuma = (intFinal - intInicio) + 1;
				if (intsuma == 0 && chk_Ref.Checked == false)
					intsuma = 1;
				else
				{
					if (chk_Ref.Checked == true)
						intsuma = 0;
				}

				if (((intsuma + intcant) >= 13) && (intInicio != 0))
				{
					MessageBox.Show("No se puede agregar mas de 13 pelicula");
				}
				else
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

					Listar_Grilla();
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
			//if (bolDesdeinicio == false)
			//{
				if ((lbl_id_cliente.Text != "-1") && (!String.IsNullOrEmpty(lbl_id_cliente.Text)))
					Cargar_Datos();
				else
					if (String.IsNullOrEmpty(lbl_id_cliente.Text))
					MessageBox.Show(ControlDosimetro.Properties.Resources.msgErrorFaltaCliente, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//}
		}

		private void btn_filtro_Click_1(object sender, EventArgs e)
		{
			cbx_anno.Enabled = true;
			cbx_id_periodo.Enabled = true;
			txt_Pelicula.Text = "";
			txt_PeliculaHasta.Text = "";
			txt_pelrefdesde.Text = "";
			txt_pelrefhasta.Text = "";
			Cargar_Cliente(0);
			lbl_id_cliente.Text = "0";
			Listar_Grilla();
			lbl_id_cliente.Text = "";
			btn_Cargar_cliente.Enabled = true;
			lbl_id_cliente.Enabled = true;
			grp_Ingreso.Enabled = false;
			btn_cargar.Enabled = true;
			btn_IngresoDosimetro.Enabled = btn_Imprimir.Enabled = grpListado.Enabled = grp_Ingreso.Enabled = false;
			cbx_anno.Focus();
			intContar = 0;
		}

		private void btn_Cerrar_Click(object sender, EventArgs e)
		{
			this.Close();
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
			Listar_Grilla();
		}

		private void btn_IngresoDosimetro_Click(object sender, EventArgs e)
		{
			FrmDosimetriaPersonal frm = new FrmDosimetriaPersonal(Convert.ToInt64(lbl_id_cliente.Text.ToString()));
			frm.Show();
			Listar_Grilla();
		}

		private void btn_Cargar_cliente_Click(object sender, EventArgs e)
		{
			Cargar_Cliente(Convert.ToInt64(lbl_id_cliente.Text));
		}

		private void pctAgregarSucursal_Click(object sender, EventArgs e)
		{
			frmBusquedaSucursal frm = new frmBusquedaSucursal(Convert.ToInt32(lbl_id_cliente.Text));
			frm.ShowDialog(this);
			Cargar_Sucursal();
		}

		private void tsb_Imprimir_Click(object sender, EventArgs e)
		{
			frmimprimedocpel frm = new frmimprimedocpel();
			frm.Show(this);
		}

		private void btn_Imprimir_Click(object sender, EventArgs e)
		{

			DataSet dt;
			dt = RptSobre(Convert.ToInt64(lbl_id_cliente.Text));

			frmreporte frm = new frmreporte(dt, dt, 2);
			frm.Show(this);
			//Llamado_reporte(dt);


		}


		#endregion

		#region "combobox"

		private void cbx_anno_SelectedIndexChanged(object sender, EventArgs e)
		{
			Cargar_Periodo();
		}

		private void cbx_Sucursal_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlCommand cmd1 = new SqlCommand();
			DataSet ds1;
			if (lbl_id_cliente.Text.Trim() != "")
			{
				cmd1.CommandText = "select cast(count(n_dosimetro) as varchar(3))cant from ges_dosimetro_estado es where id_ref=0 and es.Id_cliente = " + lbl_id_cliente.Text + " and es.id_periodo=" + cbx_id_periodo.SelectedValue.ToString() + " and Id_sucursal=" + cbx_Sucursal.SelectedValue.ToString() + " group by Id_sucursal";
				cmd1.CommandType = CommandType.Text;

				ds1 = Conectar.Listar(Clases.clsBD.BD, cmd1);
				if (ds1.Tables[0].Rows.Count > 0)
				{
					grpListado.Text = "Listado        Cantidad de dosimetro ingresado  por Sucursal es:" + ds1.Tables[0].Rows[0][0].ToString();
				}
				else
					grpListado.Text = "Listado        Cantidad de dosimetro ingresado  por Sucursal es: 0";
			}
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

		private void Cargar_Datos()
		{
			Cursor = Cursors.WaitCursor;
			clsFunc.Cargar_Cliente((int)cbx_id_periodo.SelectedValue, Convert.ToInt64(lbl_id_cliente.Text.ToString()), ref lbl_rut, ref lbl_nombreCliente,ref lbl_Direccion);
			if (lbl_id_cliente.Text.ToString().Trim() != "")
			{
				Cargar_Cliente(Convert.ToInt64(lbl_id_cliente.Text));
				Listar_Grilla();
				SqlCommand cmd = new SqlCommand();

				DataSet dt;


				cmd.CommandText = "SELECT replace([fecha_termino],'/',' - ')fecha" +
												" FROM conf_periodo " +
												" WHERE  id_periodo=" + cbx_id_periodo.SelectedValue + " ";
				cmd.CommandType = CommandType.Text;

				dt = Conectar.Listar(Clases.clsBD.BD, cmd);
				dtp_Fecha_dev.Text = dt.Tables[0].Rows[0]["fecha"].ToString();
				//btn_Cargar_cliente_Click(sender, e);
				intContar = 0;
			}
			Cursor = Cursors.Default;
		}

		private void LLamadoReporte_Click(object sender, EventArgs e)
		{
			MDIPrincipal.LlamadaReporte(Convert.ToUInt16(((System.Windows.Forms.ToolStripItem)sender).Tag.ToString()));

		}

		#endregion

		public DataSet RptSobre(Int64 id_cliente)
		{
			DataSet ds = new DataSet();
			SqlCommand cmd = new SqlCommand();
			// SqlCommand cmd = new SqlCommand();
			//MessageBox.Show("Conectado al servidor");

			cmd.CommandText = "rtpSobre " + id_cliente.ToString();

			//"SELECT * FROM " +tabla.Name.ToString();// WHERE TABLE_SCHEMA = 'bd_sistema' AND "// +
			// "TABLE_NAME = '" + tabla.Name.ToString()    + "'";
			cmd.CommandType = CommandType.Text;

			ds = Conectar.Listar(Clases.clsBD.BD, cmd);
			return ds;
		}

	}
}
