using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuLuz.Clases;
using System.Data;

namespace TuLuz.Clases
{
    class ComboBox01 : ComboBox
    {
        public string pp_Tabla { get; set; }
        public string pp_Display { get; set; }
        public string pp_Value { get; set; }
        public bool pp_Seleccionado { get; set; }

        public bool pp_validable { get; set; }
        public string pp_nombre_campo { get; set; }
        public string pp_nombre_tabla { get; set; }
        public string pp_mensaje_error { get; set; }

        Be_BaseDatos BaseDatos = new Be_BaseDatos();

        public void Cargar(EstructuraComboBox ec)
        {
            this.DisplayMember = ec.Display;
            this.ValueMember = ec.Value;
            this.DataSource = ec.Tabla;
        }
    }

    
}
