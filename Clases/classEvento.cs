using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dllLibreriaEvento;

namespace Clases
{

    /// <summary>
	 /// Esta clase tiene la finalidad de asignar los eventos a los controles
	 /// </summary>
	 class ClassEvento
	{
		clsEventoControl ClaseEvento = new clsEventoControl();

		/// <summary>
		/// Solo se digita numero
		/// </summary>
		public void AsignarNumero(ref TextBox textbox)
		{
			textbox.KeyPress += new KeyPressEventHandler(ClaseEvento.Numero_KeyPress);
			textbox.KeyDown += new KeyEventHandler(ClaseEvento.Numero_KeyDown);
			textbox.MaxLength = 9;
		}

		public void AsignarRut(ref TextBox textbox)
		{
			textbox.MaxLength = 10;

			textbox.KeyPress += new KeyPressEventHandler(ClaseEvento.Rut_KeyPress);
			textbox.KeyDown += new KeyEventHandler(ClaseEvento.Rut_KeyDown);
			textbox.Validated += new EventHandler(ClaseEvento.validarut_Validated);
			textbox.Leave += new EventHandler(ClaseEvento.run_Leave);
		}

		public void AsignarMailMultiple(ref TextBox textbox)
		{
			textbox.KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);
			textbox.Validated += new EventHandler(ClaseEvento.validaVariosEmail_Validated);
		}

		public void AsignarMail(ref TextBox textbox)
		{
			textbox.KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);
			textbox.Validated += new EventHandler(ClaseEvento.validarut_Validated);
		}

		public void AsignarKeyPress(ref TextBox textbox)
		{
			textbox.KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);
		}

		public void AsignarKeyPressDTP(ref DateTimePicker textbox)
		{
			textbox.KeyPress += new KeyPressEventHandler(ClaseEvento.Avanzar_KeyPress);
		}

	}

}
