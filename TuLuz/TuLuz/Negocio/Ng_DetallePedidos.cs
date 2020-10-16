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

        public DataTable RecuperarDetallesPedido(string num)
        {
            return _BD.Consulta("SELECT * FROM DetallePedido WHERE numeroPedido = "+ num);
        }

        public void Borrar(string Doc,string num)
        {
            string sqlDelete = "DELETE FROM DetallePedido WHERE numeroPedido = " + Doc+" AND codigoProducto = "+num;
            _BD.Borrar(sqlDelete);
        }

        public DataTable  PedidosXProducto(string cod)
        {
            return _BD.Consulta("SELECT DetallePedido.*, Productos.nombre FROM DetallePedido, Productos WHERE numeroPedido = " + cod+ " AND DetallePedido.codigoProducto = Productos.codProducto ");
        }

        public DataTable TodosLosPedidosXProducto()
        {
            return _BD.Consulta("SELECT DetallePedido.*, Productos.nombre FROM DetallePedido, Productos WHERE DetallePedido.codigoProducto = Productos.codProducto");
        }


    }
}
