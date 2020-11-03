using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuLuz.Forums;
using TuLuz.Forums.Estadisticas.VendedoresXCotizaciones;
using TuLuz.Forums.Estadisticas.VentasXMes;

namespace TuLuz
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
            //Application.Run(new ModificarCliente() { cuit = "555"});

            //Application.Run(new ()); 
                }
    }
}
