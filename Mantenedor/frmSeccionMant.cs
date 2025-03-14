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
	public partial class frmSeccionMant : Form
	{
		#region "Definicion variable"
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();
		#endregion


		public frmSeccionMant(Int64 intCodCliente, Int64 intCodSeccion,string strRun)
		{
			InitializeComponent();
			lbl_Run.Text = strRun;
			Cargar_Estado();
			Cargar_Cliente(intCodCliente);

			if (intCodSeccion == 0)
			{
				btn_Grabar.Text = "Grabar";
				this.Text = "Agregar Sección";
				cbx_id_estado.Enabled = false;
				lbl_id_seccion.Text = intCodSeccion.ToString();
			}
			else
			{
				btn_Grabar.Text = "Modificar";
				this.Text = "Modificar Sección";

			}
		}

		#region "Llamada de carga"

		private void Cargar_Estado()
		{
			ClaseComun.Listar_Estado(ClaseGeneral.Conexion, ref cbx_id_estado, ref cbx_id_estado);
		}

		private void Cargar_Cliente(Int64 intCodCliente)
		{
			SqlCommand cmd = new SqlCommand();

			//	  SqlCommand cmd = new SqlCommand();

			cmd.CommandText = "SELECT run,Razon_Social,N_Cliente_Ref,Direccion,Id_Region,Id_Provincia,Id_Comuna,Telefono, Id_TipoFuente,Id_estado,Fechainicio " +
							" FROM tbl_cliente WHERE Id_cliente= " + intCodCliente.ToString();
			DataSet dt;
			dt = Conectar.Listar(ClaseGeneral.Conexion, cmd);

			lbl_id_cliente.Text = intCodCliente.ToString();
			lbl_nombreCliente.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
		}


		#endregion

		#region "button"

		private void btn_cerrar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			this.Close();

			Cursor = Cursors.Default;

		}

		private void btn_Grabar_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			Boolean bolResult;
			bolResult = false;
			String strMensaje = "";
			ClaseComun.ValidarFormulario(ClaseGeneral.Conexion, tbl_seccion, ref bolResult, ref strMensaje);
			if(!String.IsNullOrEmpty( strMensaje)){
				classFuncionesGenerales.mensajes.MensajeError(strMensaje);
				Cursor = Cursors.Default;
				return;
			}
				

			if (classFuncionesGenerales.mensajes.MensajeConfirmacion(ControlDosimetro.Properties.Resources.msgGrabar))
			{
				if (btn_Grabar.Text == "Modificar")
				{

					ClaseComun.Modificar(ClaseGeneral.Conexion, tbl_seccion, ref bolResult);
					if (bolResult == true)
					{

						this.Close();
					}

				}
				else
				{
					ClaseComun.Insertar(ClaseGeneral.Conexion, tbl_seccion, ref bolResult);
					if (bolResult == true)
					{
						//  MessageBox.Show("Dato Guardado");
						this.Close();
					}
				}

			}

			Cursor = Cursors.Default;

		}

		#endregion

		#region "combobox"

		#endregion

	}
}
