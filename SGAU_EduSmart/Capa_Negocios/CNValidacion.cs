using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
   public class CNValidacion
    {
        public void Solo_Letras(KeyPressEventArgs e)
        {
            try
            {
                if(Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if(Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if(Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error de validación: "+ex.ToString());
            }
        }
    }
}
