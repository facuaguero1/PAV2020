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
    class Ng_DetalleProducto
    {
        Be_BaseDatos _BD = new Be_BaseDatos();
        //public void Insertar(Control.ControlCollection controles)
        //{
        //    _BD.InsertarAutomatizado("Empleados", controles);
        //}

        public void Insertar(Es_DetalleProducto detalle)
        {

            String sqlInsertar = "INSERT INTO DetalleProducto(codProductoComponente, codProductoGenerico, cantidad, precio) VALUES(" + detalle.CodigoComponente + "," + detalle.codigoProducto + "," + detalle.cantidad + "," + detalle.precio + ")";
            _BD.Insertar(sqlInsertar);

        }

        public DataTable RecuperarDetallesProducto(int cod)
        {
            return _BD.Consulta("SELECT * FROM DetalleProducto WHERE codProductoGenerico = "+cod);
        }
        public DataTable RecuperarDetallesProductoEspecifico(string codigoProducto, string codigoComponente)
        {
            return _BD.Consulta("SELECT * FROM DetalleProducto WHERE codProductoGenerico = " + codigoProducto + "AND codProductoComponente = "+ codigoComponente);
        }
        //AGREGAR BIEN LOS DATOS FALTANTES A LA MODIFICACION Y BORRADO

        public void Modificar(Es_DetalleProducto datos)
        {
            string sqlUpdate = "UPDATE DetalleProducto SET ";
            sqlUpdate += "cantidad = " + _BD.FormatearDato(datos.cantidad, "Int");
            sqlUpdate += ", precio = " + _BD.FormatearDato(datos.precio, "Int");

            sqlUpdate += " WHERE codProductoComponente = " + datos.CodigoComponente + "AND codProductoGenerico = "+ datos.codigoProducto;

            MessageBox.Show("El Detalle de producto fue modificado con exito!", "MODIFICACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _BD.Modificar(sqlUpdate);

        }
        public void Borrar(string Doc)
        {
            string sqlDelete = "DELETE FROM DetalleProducto WHERE codProductoGenerico = " + Doc;
            _BD.Borrar(sqlDelete);
        }
        public void BorrarDetalleEspecifico(string codProductoGenerico, string codProductoComponente)
        {
            string sqlDelete = "DELETE FROM DetalleProducto WHERE codProductoGenerico = " + codProductoGenerico + "AND codProductoComponente = " + codProductoComponente;
            _BD.Borrar(sqlDelete);
        }

    }
}
