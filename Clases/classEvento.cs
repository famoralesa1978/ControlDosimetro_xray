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

    }

}
