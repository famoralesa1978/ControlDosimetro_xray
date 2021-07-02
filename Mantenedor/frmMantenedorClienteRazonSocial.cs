using dllConectorMysql;
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
	public partial class frmMantenedorClienteRazonSocial : Form
	{

		#region "Definicion variable"
		clsConectorSqlServer Conectar = new clsConectorSqlServer();
		clsSqlComunSqlserver ClaseComun = new clsSqlComunSqlserver();
		clsEventoControl ClaseEvento = new clsEventoControl();
        Clases.ClassEvento clsEvento = new Clases.ClassEvento();
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

		public frmMantenedorClienteRazonSocial(Int64 intId_Cliente)
		{
			InitializeComponent();
			AsignarEvento();
		}

		private void frmMantenedorClienteRazonSocial_Load(object sender, EventArgs e)
		{
			SqlCommand cmdcombo = new SqlCommand();
			DataSet dtcombo;
			cmdcombo.CommandText = "select 0 as Id_DetParametro, 'Seleccione' as Glosa, 0 as orden union all " +
				"SELECT Id_DetParametro,Glosa,orden FROM conf_detparametro where id_estado=1 and Id_Parametro=2 order by orden ";
			cmdcombo.CommandType = CommandType.Text;
			dtcombo = Conectar.Listar(Clases.clsBD.BD, cmdcombo);

			Cargar_Reporte();
            Cargar_Propiedades();
        }

        #region "Llamada de carga"

        private void Cargar_Propiedades()
        {
            label11.Visible = false;
            lbl_rut.Visible = false;
            lbl_rut.Text = "";

            label1.Visible = false;
            lbl_nombreCliente.Visible = false;
            lbl_nombreCliente.Text = "";

            lbl_id_cliente.Text = "";
            lbl_id_cliente.Enabled = true;

            lbl_rut_nvo.Visible = false;
            txt_rut_nvo.Visible = false;
            txt_rut_nvo.Text = "";
            txt_rut_nvo.MaxLength = 10;

            lbl_razsocial_nvo.Visible = false;
            txt_razsocial_nvo.Visible = false;
            txt_razsocial_nvo.Text = "";
            txt_razsocial_nvo.MaxLength = 60;

            btn_Guardar.Visible = false;
            lbl_id_cliente.Focus();
        }

        private void Cargar_Cliente(Int64 intCodCliente)
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "select run,Razon_Social,N_Cliente_Ref, Direccion as Direccion ,r.Id_Region,c.Id_Provincia,c.Id_Comuna,Telefono, Id_TipoFuente,Id_estado,Fechainicio,Servicio,r.region,co.Comuna " +
											"  FROM tbl_cliente c inner join [dbo].[glo_region] r on c.Id_Region=r.Id_Region inner join glo_comuna co on co.id_comuna=c.id_comuna" +
											" WHERE Id_cliente= " + intCodCliente.ToString();
			DataSet dt;

			dt = Conectar.Listar(Clases.clsBD.BD, cmd);
			if (dt.Tables[0].Rows.Count > 0)
			{
				lbl_id_cliente.Text = intCodCliente.ToString();
				lbl_rut.Text = dt.Tables[0].Rows[0]["run"].ToString();
				lbl_nombreCliente.Text = dt.Tables[0].Rows[0]["Razon_Social"].ToString();
				
                label11.Visible = true;
                lbl_rut.Visible = true;
                label1.Visible = true;
                lbl_nombreCliente.Visible = true;
                lbl_rut_nvo.Visible = true;
                txt_rut_nvo.Visible = true;
                lbl_razsocial_nvo.Visible = true;
                txt_razsocial_nvo.Visible = true;
                btn_Guardar.Visible = true;
                lbl_id_cliente.Enabled = false;
            }
			else
			{
                Cargar_Propiedades();
                classFuncionesGenerales.mensajes.MensajeAdvertencia("El cliente no existe");
            }
		}

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

		private void AsignarEvento()
        {
            clsEvento.AsignarRutSinGuion(ref txt_rut_nvo);
            lbl_id_cliente.KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
			lbl_id_cliente.KeyDown += new KeyEventHandler(ClaseEvento.Numero_KeyDown);
		}

        #endregion

        #region "button"

        private void btn_filtro_Click(object sender, EventArgs e)
        {
            Cargar_Propiedades();
        }

		private void btn_Guardar_Click(object sender, EventArgs e)
		{
            if (txt_rut_nvo.Text != "" && txt_razsocial_nvo.Text != "")
            {
                int intIdPersonal = Convert.ToUInt16(lbl_id_cliente.Text);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "CambiarDatosCliente " + intIdPersonal.ToString() + ",'" + txt_rut_nvo.Text + "','" + txt_razsocial_nvo.Text + "'";
                cmd.CommandType = CommandType.Text;
                Conectar.AgregarModificarEliminar(Clases.clsBD.BD, cmd);
                classFuncionesGenerales.mensajes.MensajeConfirmacion("Información grabada correctamente");
                Cargar_Propiedades();
            }
            else
            {
                classFuncionesGenerales.mensajes.MensajeAdvertencia("Ingrese todos los campos requeridos.");
            }
        }

		private void btn_Cerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_Cargar_cliente_Click(object sender, EventArgs e)
		{
            if (lbl_id_cliente.Text=="")
            {
                classFuncionesGenerales.mensajes.MensajeAdvertencia("Ingrese un Id de cliente");
            }
            else
            {
                Cursor = Cursors.WaitCursor;
                Cargar_Cliente(Convert.ToInt64(lbl_id_cliente.Text));
                Cursor = Cursors.Default;
            }
		}


		private void btn_Cliente_Click(object sender, EventArgs e)
		{
			frmBusquedaEmpresa frm = new frmBusquedaEmpresa();
			frm.Show(this);
		}

		#endregion

		private void LLamadoReporte_Click(object sender, EventArgs e)
		{
			MDIPrincipal.LlamadaReporte(Convert.ToUInt16(((System.Windows.Forms.ToolStripItem)sender).Tag.ToString()));
		}
    }
}
