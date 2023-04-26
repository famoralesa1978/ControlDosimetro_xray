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

namespace ControlDosimetro
{
	public partial class frmModuloEnviado : Form
	{

		#region "Definicion variable"
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();
		int intContar = 0;
		int intintId_Estado_temp;
		#endregion

		public frmModuloEnviado(int intId_Estado,bool TLD)
		{
			InitializeComponent();

			SqlCommand cmdcombo = new SqlCommand();
			//	SqlCommand cmdcombo = new SqlCommand();
			DataSet dtcombo;
			cmdcombo.CommandText = "select 0 as Id_DetParametro, 'Seleccione' as Glosa, 0 as orden union all " +
				"SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=2 order by orden ";
			cmdcombo.CommandType = CommandType.Text;
			dtcombo = Conectar.Listar(Clases.clsBD.BD, cmdcombo);


			AsignarEvento();
			intintId_Estado_temp = intId_Estado;
			switch (intintId_Estado_temp)
			{
				case 0:
					this.Text = "Envio Dosimetros o TLD";
					break;
				case 1:
					this.Text = "Recepción Dosimetros";
					break;
				case 6:
					this.Text = "Informe Generado";
					break;
			}
			SqlCommand cmd = new SqlCommand
			{
				CommandText = "pa_Log_usuario_ins '" + Clases.clsUsuario.Usuario + "',' " + this.Text + "'",
				CommandType = CommandType.Text
			};
			Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);
			Cargar_Anno();

			rbtDosimetria.Visible = rbtDosimetria.Checked = !TLD;
			rbtTLD.Visible= rbtTLD.Checked = TLD;
			pnl_Progreso.Visible = false;
			btn_Guardar.Enabled = false;
		}

		#region "Llamada de carga"

		private void AsignarEvento()
		{
			txtCliente.KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
			txtCliente.KeyDown += new KeyEventHandler(ClaseEvento.Numero_KeyDown);
		}

		private void Listar_Grilla_Dosimetria()
		{
			SqlCommand cmd = new SqlCommand();
			DataSet dt;
			cmd.CommandText = String.Format("pa_ListadoPorEnviarClienteDosimetro {0}",String.IsNullOrEmpty(txtCliente.Text) ? null : txtCliente.Text);

			cmd.CommandType = CommandType.Text;

			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			grdDatos.DataSource = dt.Tables[0];
		}

		private void Listar_Grilla_TLD()
		{
			SqlCommand cmd = new SqlCommand();
			DataSet dt;
			cmd.CommandText = String.Format("pa_ListadoPorEnviarClienteTLD {0}",String.IsNullOrEmpty(txtCliente.Text)?null: txtCliente.Text);

			cmd.CommandType = CommandType.Text;

			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			grdDatos.DataSource = dt.Tables[0];
			groupBox2.Text = "Listado       Registro:";
			intContar = 0;
		}

		private void Cargar_Anno()
		{
			SqlCommand cmd = new SqlCommand
			{

				//	  SqlCommand cmd = new SqlCommand();

				CommandText = "SELECT distinct Anno FROM conf_periodo WHERE Id_TipoPeriodo=3"
			};
			//cmd.CommandText = "SELECT Id_Periodo,Anno, Mes,Id_TipoPeriodo FROM conf_periodo WHERE Id_TipoPeriodo=3";
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);

			//  cbx_anno.DisplayMember = dt.Tables[0].Columns[0].Caption.ToString();
			// cbx_anno.DataSource = dt.Tables[0];

		}

		private void Cargar_Periodo()
		{
			SqlCommand cmd = new SqlCommand();
			DataSet dt;
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);
		}


		#endregion

		#region "button"

		private void btn_Cerrar_Click_1(object sender, EventArgs e)
		{
			//  verificar_Grabado();
			this.Close();
		}

		private void btn_Guardar_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand();
			// SqlCommand cmd = new SqlCommand();

			//// dtcombo = Conectar.Listar(Clases.clsBD.BD,cmdcombo);

			DataGridViewCheckBoxCell checkMarca;
			DataGridViewCheckBoxCell checkEnviado;
			String strIdCliente;
			String strid_periodo;
			//   string strId;
			pnl_Progreso.Visible = true;
			btn_Guardar.Enabled = false;
			pnl_Progreso.Refresh();
			pgb_Barra.Minimum = 0;
			pgb_Barra.Maximum = grdDatos.RowCount;
			for (int i = 0; i <= grdDatos.RowCount - 1; ++i)
			{
				pgb_Barra.Value = i + 1;
				pgb_Barra.Refresh();
				checkMarca = (DataGridViewCheckBoxCell)grdDatos.Rows[i].Cells["marca"];
				checkEnviado = (DataGridViewCheckBoxCell)grdDatos.Rows[i].Cells["Enviado"];

				strIdCliente = grdDatos.Rows[i].Cells["IdCliente"].Value.ToString();
				strid_periodo = grdDatos.Rows[i].Cells["id_periodo"].Value.ToString();

				if ((checkMarca.Value.ToString() == "1") && (checkEnviado.Value.ToString() == "0"))
				{
					if (rbtDosimetria.Checked == true)
						cmd.CommandText = "pa_DosimetroEstadoEnviadoDosimetro_upd " + intintId_Estado_temp.ToString() + ",'" + Clases.clsUsuario.Usuario + "'," + strIdCliente + "," + strid_periodo;
					if (rbtTLD.Checked == true)
						cmd.CommandText = "pa_DosimetroEstadoEnviadoTLD_upd " + intintId_Estado_temp.ToString() + ",'" + Clases.clsUsuario.Usuario + "'," + strIdCliente + "," + strid_periodo;

					cmd.CommandType = CommandType.Text;
					Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);
				}
				else
				{
					if ((checkMarca.Value.ToString() == "1") && (checkEnviado.Value.ToString() == "1"))
					{
						if (rbtDosimetria.Checked == true)
							cmd.CommandText = "pa_DosimetroDesvolverEstadoEnviadoDosimetria_upd 1,'" + Clases.clsUsuario.Usuario + "'," + strIdCliente + "," + strid_periodo;
						if (rbtTLD.Checked == true)
							cmd.CommandText = "pa_DosimetroDesvolverEstadoEnviadoTLD_upd 1,'" + Clases.clsUsuario.Usuario + "'," + strIdCliente + "," + strid_periodo;

						cmd.CommandType = CommandType.Text;
						Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);
					}
				}//


			}
			if (rbtTLD.Checked == true)
				Listar_Grilla_TLD();
			if (rbtDosimetria.Checked == true)
				Listar_Grilla_Dosimetria();
			MessageBox.Show("Informacion grabada");
			btn_Guardar.Enabled = true;
			pnl_Progreso.Visible = false;
		}

		private void btn_cargar_Click(object sender, EventArgs e)
		{
			if (rbtTLD.Checked == true)
				Listar_Grilla_TLD();
			if (rbtDosimetria.Checked == true)
				Listar_Grilla_Dosimetria();
		}

		private void btn_Cerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		#endregion

		#region "combobox"

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
			if ((grdDatos.Columns[e.ColumnIndex].Name == "marca"))
			{
				DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)grdDatos.Rows[e.RowIndex].Cells["marca"];

				if ((Convert.ToInt64(checkCell.Value) == 1) || (Convert.ToInt64(checkCell.Value) == 2))
				{
					intContar = intContar + 1;
					groupBox2.Text = "Listado       Registro:" + intContar.ToString();
				}
				else
				{
					intContar = intContar - 1;
					groupBox2.Text = "Listado       Registro:" + intContar.ToString();
				}
				btn_Guardar.Enabled = intContar == 0 ? false : true;
			}
		}

		private void grdDatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
		}

		#endregion

		private void chk_marcar_CheckedChanged(object sender, EventArgs e)
		{
			pnl_Progreso.Refresh();
			pgb_Barra.Minimum = 0;
			DataGridViewCheckBoxCell checkMarca;
			pgb_Barra.Maximum = grdDatos.RowCount;
			for (int i = 0; i <= grdDatos.RowCount - 1; i++)
			{
				pgb_Barra.Value = i + 1;
				pgb_Barra.Refresh();
				checkMarca = (DataGridViewCheckBoxCell)grdDatos.Rows[i].Cells["marca"];

				DataGridViewTextBoxCell txtFechaRecepcion = (DataGridViewTextBoxCell)grdDatos.Rows[i].Cells["FechaRecepción"];

			}
			btn_Guardar.Enabled = true;
			pnl_Progreso.Visible = false;
		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

	}
}
