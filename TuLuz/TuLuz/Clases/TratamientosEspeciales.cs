using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuLuz.Clases
{
    class TratamientosEspeciales
    {
        public enum Validacion { correcta, incorrecta}
        public Validacion validar (Control.ControlCollection controles)
        {
            foreach (var item in controles)
            {
                if (item.GetType().Name=="TextBox01")
                {
                    if(((TextBox01)item).pp_validable==true)
                    {
                        if(((TextBox01)item).Text=="")
                        {
                            MessageBox.Show(((TextBox01)item).pp_mensaje_error);
                            ((TextBox01)item).Focus();
                            return Validacion.incorrecta;
                        }
                    }
                }
                if (item.GetType().Name=="ComboBox01")
                {
                    if (((ComboBox01)item).pp_validable==true)
                    {
                        if (((ComboBox01)item).SelectedIndex==-1)
                        {
                            MessageBox.Show(((ComboBox01)item).pp_mensaje_error);
                            ((ComboBox01)item).Focus();
                            return Validacion.incorrecta;
                        }
                    }
                }
            }
            return Validacion.correcta;
        }
    }
}
