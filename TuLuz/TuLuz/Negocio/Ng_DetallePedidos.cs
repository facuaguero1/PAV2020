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
        public DataTable ContarProductosMasVendidos()
        {
            string sql = "select COUNT(DetallePedido.numeroPedido) as 'cantidad' ,DetallePedido.codigoProducto, Productos.nombre from DetallePedido,Productos WHERE Productos.codProducto = DetallePedido.codigoProducto group by codigoProducto, Productos.nombre";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable ContarProductosMasVendidosXFecha(string FechaMin, string FechaMax)
        {
            string sql = "select COUNT(DetallePedido.numeroPedido) as 'cantidad' ,DetallePedido.codigoProducto, Productos.nombre FROM DetallePedido,Productos,Pedidos WHERE (Productos.codProducto = DetallePedido.codigoProducto) AND (Pedidos.numeroPedido = DetallePedido.numeroPedido) AND (Pedidos.fechaPedido BETWEEN " + _BD.FormatearDato(FechaMin,"Date") + " AND "+_BD.FormatearDato(FechaMax,"Date") +") group by codigoProducto, Productos.nombre";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable TodosLosPedidosXProductoXFecha(string lbl_Desde, string lblHasta)
        {
            return _BD.Consulta("SELECT DetallePedido.*, Productos.nombre FROM DetallePedido, Productos, Pedidos WHERE (DetallePedido.numeroPedido = Pedidos.numeroPedido) AND (Pedidos.fechaPedido BETWEEN " + _BD.FormatearDato(lbl_Desde,"Date") + " AND " + _BD.FormatearDato(lblHasta, "Date")+ ") AND (DetallePedido.codigoProducto = Productos.codProducto )");
        }
        public DataTable TodosLosPedidosXProducto()
        {
            return _BD.Consulta("SELECT DetallePedido.*, Productos.nombre FROM DetallePedido, Productos WHERE DetallePedido.codigoProducto = Productos.codProducto");
        }
    }
}
