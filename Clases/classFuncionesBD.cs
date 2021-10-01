using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dllConectorMysql;
using dllLibreriaEvento;
using dllLibreriaMysql;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;

namespace classFuncionesBD
{
	public class ClsFunciones
	{
		clsConectorSqlServer Conectar = new clsConectorSqlServer();



		public int CambiarEstado(string NDoc, string NDos, ref string mensaje)
		{
			SqlCommand cmd = new SqlCommand();
			DataSet ds;

			cmd.CommandText = "pa_CambiarEstado_upd " + NDoc + "," + NDos;
			cmd.CommandType = CommandType.Text;
			ds = Conectar.Listar(Clases.clsBD.BD, cmd);

			mensaje = ds.Tables[0].Rows[0][1].ToString();
			return Convert.ToInt16(ds.Tables[0].Rows[0][0].ToString());
		}

		public int CambiarEstadoTLD(string NDoc, string NDos, ref string mensaje)
		{
			SqlCommand cmd = new SqlCommand();
			DataSet ds;

			cmd.CommandText = "pa_CambiarEstadoTLD_upd " + NDoc + "," + NDos;
			cmd.CommandType = CommandType.Text;
			ds = Conectar.Listar(Clases.clsBD.BD, cmd);

			mensaje = ds.Tables[0].Rows[0][1].ToString();
			return Convert.ToInt16(ds.Tables[0].Rows[0][0].ToString());
		}

		public void Cargar_Cliente(Int64 intCodCliente, ref Label Rut, ref Label RazonSocial)
		{
			DataSet ds;


			SqlCommand cmd = new SqlCommand
			{
				CommandText = "select run,Razon_Social,N_Cliente_Ref, Direccion as Direccion ,r.Id_Region,c.Id_Provincia,c.Id_Comuna,Telefono, Id_TipoFuente,Id_estado,Fechainicio,Servicio,r.region,co.Comuna " +
											"  FROM tbl_cliente c inner join [dbo].[glo_region] r on c.Id_Region=r.Id_Region inner join glo_comuna co on co.id_comuna=c.id_comuna" +
											" WHERE Id_cliente= " + intCodCliente.ToString()
		};
			ds = Conectar.Listar(Clases.clsBD.BD, cmd);

			if (ds.Tables[0].Rows.Count > 0)
			{
				RazonSocial.Text = ds.Tables[0].Rows[0]["Razon_Social"].ToString();
				Rut.Text = ds.Tables[0].Rows[0]["run"].ToString();
			}
			else
			{
				RazonSocial.Text = "";
				Rut.Text = "";
				if (intCodCliente != -1)
					classFuncionesGenerales.mensajes.MensajeError(ControlDosimetro.Properties.Resources.msgClientePeriodoError);
			}
		}

		public void Cargar_Cliente(int intPeriodo, Int64 intCodCliente, ref Label RazonSocial)
		{
			DataSet ds;


			SqlCommand cmd = new SqlCommand
			{
				CommandText = "pa_ObtieneCliente_sel  " + intPeriodo.ToString() + "," + intCodCliente.ToString()
			};
			ds = Conectar.Listar(Clases.clsBD.BD, cmd);

			if (ds.Tables[0].Rows.Count > 0)
			{
				RazonSocial.Text = ds.Tables[0].Rows[0]["Razon_Social"].ToString();
			}
			else
			{
				RazonSocial.Text = "";
				if (intCodCliente != -1)
					classFuncionesGenerales.mensajes.MensajeError(ControlDosimetro.Properties.Resources.msgClientePeriodoError);
			}
		}
		public void Cargar_Cliente(int intPeriodo, Int64 intCodCliente, ref Label Rut, ref Label RazonSocial)
		{
			DataSet ds;


			SqlCommand cmd = new SqlCommand
			{
				CommandText = "pa_ObtieneCliente_sel  " + intPeriodo.ToString() + "," + intCodCliente.ToString()
			};
			ds = Conectar.Listar(Clases.clsBD.BD, cmd);

			if (ds.Tables[0].Rows.Count > 0)
			{
				RazonSocial.Text = ds.Tables[0].Rows[0]["Razon_Social"].ToString();
				Rut.Text = ds.Tables[0].Rows[0]["run"].ToString();
			}
			else
			{
				RazonSocial.Text = "";
				Rut.Text = "";
				if (intCodCliente != -1)
					classFuncionesGenerales.mensajes.MensajeError(ControlDosimetro.Properties.Resources.msgClientePeriodoError);
			}
		}

		public void Cargar_Cliente(int intPeriodo, Int64 intCodCliente, ref Label Rut, ref Label RazonSocial, ref Label Direccion)
		{
			DataSet ds;


			SqlCommand cmd = new SqlCommand
			{
				//	SqlCommand cmd = new SqlCommand();

				CommandText = "pa_ObtieneCliente_sel  " + intPeriodo.ToString() + "," + intCodCliente.ToString()
			};
			ds = Conectar.Listar(Clases.clsBD.BD, cmd);

			if (ds.Tables[0].Rows.Count > 0)
			{
				RazonSocial.Text = ds.Tables[0].Rows[0]["Razon_Social"].ToString();
				Rut.Text = ds.Tables[0].Rows[0]["run"].ToString();
				Direccion.Text = ds.Tables[0].Rows[0]["Direccion"].ToString();
			}
			else
			{
				RazonSocial.Text = "";
				Rut.Text = "";
				Direccion.Text = "";
				if (intCodCliente != -1)
					classFuncionesGenerales.mensajes.MensajeError(ControlDosimetro.Properties.Resources.msgClientePeriodoError);
				//	MessageBox.Show(ControlDosimetro.Properties.Resources.msgClientePeriodoError, ControlDosimetro.Properties.Resources.msgCaptionError, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
			}
		}

		public void Cargar_TipoPeriodo(ref ComboBox cbx)
		{
			DataSet ds;
			SqlCommand cmd = new SqlCommand
			{
				//	SqlCommand cmd = new SqlCommand();

				CommandText = "pa_ObtieneTipoPeriodo_sel "
			};
			ds = Conectar.Listar(Clases.clsBD.BD, cmd);

			cbx.ValueMember = ds.Tables[0].Columns[0].Caption.ToString();
			cbx.DisplayMember = ds.Tables[0].Columns[1].Caption.ToString();
			cbx.DataSource = ds.Tables[0];
		}

		public void Cargar_Año(ref ComboBox cbx, int intTipoPeriodo)
		{
			DataSet ds;
			SqlCommand cmd = new SqlCommand
			{
				//	SqlCommand cmd = new SqlCommand();

				CommandText = "pa_ObtieneAnno_sel " + intTipoPeriodo.ToString()
			};
			ds = Conectar.Listar(Clases.clsBD.BD, cmd);
			cbx.ValueMember = ds.Tables[0].Columns[0].Caption.ToString();
			cbx.DisplayMember = ds.Tables[0].Columns[0].Caption.ToString();
			cbx.DataSource = ds.Tables[0];
		}

		public void Cargar_Periodo(ref ComboBox cbx, int intTipoPeriodo, int intAnno)
		{
			DataSet ds;
			SqlCommand cmd = new SqlCommand
			{
				//	SqlCommand cmd = new SqlCommand();

				CommandText = "pa_ObtienePeriodo_sel " + intTipoPeriodo.ToString() + "," + intAnno.ToString()
			};
			ds = Conectar.Listar(Clases.clsBD.BD, cmd);

			cbx.ValueMember = ds.Tables[0].Columns[0].Caption.ToString();
			cbx.DisplayMember = ds.Tables[0].Columns[2].Caption.ToString();
			cbx.DataSource = ds.Tables[0];
		}

		public void Cargar_TipoDocumento(ref ComboBox cbx)
		{
			DataSet ds;
			SqlCommand cmd = new SqlCommand
			{
				//	SqlCommand cmd = new SqlCommand();

				CommandText = "pa_ObtieneTipoDocumento_sel "
			};
			ds = Conectar.Listar(Clases.clsBD.BD, cmd);

			cbx.ValueMember = ds.Tables[0].Columns[1].Caption.ToString();
			cbx.DisplayMember = ds.Tables[0].Columns[0].Caption.ToString();
			cbx.DataSource = ds.Tables[0];
		}

		public void Cargar_Estado(ref ComboBox cbx)
		{
			DataSet ds;
			SqlCommand cmd = new SqlCommand
			{
				//	SqlCommand cmd = new SqlCommand();

				CommandText = "select Id_Estado,descripcion from glo_estado order by orden"
			};
			ds = Conectar.Listar(Clases.clsBD.BD, cmd);

			cbx.ValueMember = ds.Tables[0].Columns[0].Caption.ToString();
			cbx.DisplayMember = ds.Tables[0].Columns[1].Caption.ToString();
			cbx.DataSource = ds.Tables[0];
		}

		public DataSet Cargar_Seccion(int intId_Cliente ){
			DataSet dt;

			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "select 'Todos' as seccion, 0 as id_seccion union all" +
							 "		SELECT seccion,id_seccion " +
							" FROM tbl_seccion  WHERE Id_cliente= " + intId_Cliente.ToString() + " and id_estado=1";
			
			dt = Conectar.Listar(Clases.clsBD.BD, cmd);


			return dt;
		}

		public void DescargarDocumento(int Id, ref byte[] Convert)
		{
			DataSet ds;
			SqlCommand cmd = new SqlCommand
			{
				//	SqlCommand cmd = new SqlCommand();

				CommandText = "pa_DescargarDocumento " + Id.ToString()
			};
			ds = Conectar.Listar(Clases.clsBD.BD, cmd);

			Convert = (byte[])ds.Tables[0].Rows[0]["Archivo"];
		}

		public void Cargar_Permiso(int id_Perfil,int id_Menu,ref bool Lectura,ref bool	Nuevo,ref bool	Modificacion,ref bool	Eliminar)
		{
			Lectura = false;
			Nuevo = false;
			Modificacion = false;
			Eliminar = false;
			DataSet ds;
			SqlCommand cmd = new SqlCommand
			{
				CommandText = "pa_CargarPermiso_Listar " + id_Perfil.ToString() +"," +id_Menu.ToString()
			};
			ds = Conectar.Listar(Clases.clsBD.BD, cmd);

			if(ds.Tables[0].Rows.Count>0)
			{
				Lectura = (bool)ds.Tables[0].Rows[0]["Lectura"];
				Nuevo = (bool)ds.Tables[0].Rows[0]["Nuevo"];
				Modificacion = (bool)ds.Tables[0].Rows[0]["Modificacion"];
				Eliminar = (bool)ds.Tables[0].Rows[0]["Eliminar"];
			}

		}

		/// <summary>
		/// Definicion classFuncionesBD.ClsFunciones FuncBD = new classFuncionesBD.ClsFunciones();
		/// llamada FuncBD.Cargar_Sucursal(ref cbx_Sucursal, lbl_rut.Text, Convert.ToInt16( lbl_id_cliente.Text.ToString()), 1);
		/// </summary>
		/// <param name="cbx"></param>
		/// <param name="strRut"></param>
		/// <param name="intIdCliente"></param>
		/// <param name="intEstado"> 1- activo,2,Inactivo,0- todos</param>
		public void Cargar_Sucursal(ref ComboBox cbx,string strRut, int intIdCliente, int intEstado)
		{
			DataSet ds;
			SqlCommand cmd = new SqlCommand
			{
				CommandText = "BusClienteSucursal '" + strRut.ToString() + "'," + intIdCliente.ToString()
			};
			ds = Conectar.Listar(Clases.clsBD.BD, cmd);
			if (intEstado != 0)
				ds.Tables[0].DefaultView.RowFilter = "Id_estado=" + intEstado.ToString();
			else
				ds.Tables[0].DefaultView.RowFilter = "Id_estado in (1,2)";

			cbx.ValueMember = ds.Tables[0].Columns[0].Caption.ToString();
			cbx.DisplayMember = ds.Tables[0].Columns[1].Caption.ToString();
			cbx.DataSource = ds.Tables[0].DefaultView;
		}


	}

}


