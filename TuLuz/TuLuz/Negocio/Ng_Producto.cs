﻿using System;
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
    class Ng_Producto
    {
        Be_BaseDatos _BD = new Be_BaseDatos();

        public void Insertar(Es_Producto Producto)
        {
            String sqlInsertar = "INSERT INTO Productos(codProducto, nombre, descripcion, precio, cantStock, cuitProveedor, codProductoEq) VALUES(" + Producto.codProducto + ",'" + Producto.nombre + "','" + Producto.descripcion + "'," + Producto.precio + "," + Producto.cantStock + ",'" + Producto.cuitProveedor + "'," + Producto.codProductoEq + ")";
            MessageBox.Show("El Producto fue creado con exito!", "CREACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _BD.Insertar(sqlInsertar);
        }

        public DataTable Todos_los_Productos()
        {
            string sql = "SELECT * FROM Productos";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Buscar_ProductoPorCodigo(string codigo)
        {
            string sql = "SELECT * FROM Productos WHERE codProducto = " + codigo;
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public int cuantoVale(string codigo)
        {
            string sql = "SELECT precio FROM Productos WHERE codProducto = " + codigo;
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return int.Parse(tabla.Rows[0]["precio"].ToString());
        }
        public void Modificar(Es_Producto datos)
        {
            string sqlUpdate = "UPDATE Productos SET ";
            sqlUpdate += "nombre = " + _BD.FormatearDato(datos.nombre, "String");
            sqlUpdate += ", descripcion = " + _BD.FormatearDato(datos.descripcion, "String");
            sqlUpdate += ", precio = " + _BD.FormatearDato(datos.precio, "String");
            sqlUpdate += ", cantStock = " + _BD.FormatearDato(datos.cantStock, "Int");
            sqlUpdate += ", cuitProveedor = " + _BD.FormatearDato(datos.cuitProveedor, "String");
            sqlUpdate += ", codProductoEq = " + datos.codProductoEq;
            sqlUpdate += " WHERE codProducto =" + datos.codProducto;

            MessageBox.Show("El Producto fue modificado con exito!", "MODIFICACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _BD.Modificar(sqlUpdate);

        }
        public void Borrar(string Doc)
        {
            string sqlDelete = "DELETE FROM Productos WHERE codProducto = " + Doc;
            MessageBox.Show("El Producto y sus detalles fueron eliminados con exito!", "ELIMINACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _BD.Borrar(sqlDelete);
        }
        public EstructuraComboBox EstructuraCombo()
        {
            EstructuraComboBox EC = new EstructuraComboBox();
            EC.Display = "nombre";
            EC.Value = "codProducto";
            EC.Sql = "SELECT * FROM Productos";
            EC.Tabla = _BD.Consulta(EC.Sql);
            return EC;
        }
        public void actualizarStock(int datos, string cod)
        {
            string sqlUpdate = "UPDATE Productos SET ";
            sqlUpdate += "cantStock = cantStock -" + datos;
            sqlUpdate += " WHERE codProducto =" + cod;
            _BD.Modificar(sqlUpdate);
        }
        public void sumarStock(int datos, string cod)
        {
            string sqlUpdate = "UPDATE Productos SET ";
            sqlUpdate += "cantStock = cantStock +" + datos;
            sqlUpdate += " WHERE codProducto =" + cod;
            _BD.Modificar(sqlUpdate);
        }

        public DataTable Buscar_Producto_EQ_PorCodigo(string codigo)
        {
            string sql = "SELECT * FROM Productos WHERE codProductoEq = " + codigo;
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public void IniciarTransaccion()
        {
            _BD.IniciarTransaccion();
        }
        public void CerrarTransaccion()
        {
            _BD.CerrarTransaccion();
        }
        public DataTable BuscarProductoXprecio(string precioMin, string precioMax)
        {
            string sql = "SELECT * FROM Productos WHERE precio between " + precioMin + " and " + precioMax;
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable BuscarProductoEq()
        {
            string sql = "SELECT 'Productos equivalente' as tipo, *from Productos AS e1 " +
                "WHERE EXISTS(SELECT* FROM Productos AS e2 WHERE e2.codProductoEq = e1.codProducto) " +
                "UNION " +
                "SELECT 'Productos no equivalente' as tipo, *FROM Productos AS e3 " +
                "WHERE NOT EXISTS(SELECT* FROM Productos AS e4 WHERE e4.codProductoEq = e3.codProducto)";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable ContarEquivalente()
        {
            string sql = " SELECT 'Producto equivalente' as tipo, COUNT(*) as cantidad from Productos AS e1  " +
                "WHERE EXISTS(SELECT* FROM Productos AS e2 WHERE e2.codProductoEq = e1.codProducto) " +
                "UNION " +
                "SELECT 'Producto no equivalente' as tipo, COUNT(*) as cantidad FROM Productos AS e3 " +
                "WHERE NOT EXISTS(SELECT * FROM Productos AS e4 WHERE e4.codProductoEq = e3.codProducto)";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
    }
}
