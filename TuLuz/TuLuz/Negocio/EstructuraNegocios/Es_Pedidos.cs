using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuLuz.Negocio.EstructuraNegocios
{
    class Es_Pedidos
    {
        public string numeroPedido { get; set; }
        public string numeroCotizacion { get; set; }
        public string fechaPedido { get; set; }
        public string tipoDniVendedor { get; set; }
        public string numDniVendedor { get; set; }
        public string condicionPago { get; set; }
        public string cuitCliente { get; set; }
    }
}
