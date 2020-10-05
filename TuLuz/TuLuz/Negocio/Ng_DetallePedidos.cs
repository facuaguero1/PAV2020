using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TuLuz.Clases;
using TuLuz.Negocio.EstructuraNegocios;
using System.Windows.Forms;

namespace TuLuz.Negocio
{
    class Ng_DetallePedidos
    {
        Be_BaseDatos _BD = new Be_BaseDatos();
        public void Insertar(Es_DetallePedido detalle)
        {
            String sqlInsertar = "INSERT INTO DetallePedido(numeroPedido, codigoProducto, cantidad, precio) VALUES(" + detalle.numeroPedido + "," + detalle.codigoProducto + "," + detalle.cantidad + "," + detalle.precio + ")";
            _BD.Insertar(sqlInsertar);

        }
        public DataTable RecuperarDetalles()
        {
            return _BD.Consulta("SELECT * FROM DetallePedido ");
        }

        public void Borrar(int Doc)
        {
            string sqlDelete = "DELETE FROM DetallePedido WHERE numeroPedido = " + Doc;
            _BD.Borrar(sqlDelete);
        }

    }
}
