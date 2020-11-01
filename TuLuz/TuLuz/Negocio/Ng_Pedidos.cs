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
    class Ng_Pedidos
    {

        Be_BaseDatos _BD = new Be_BaseDatos();
        //public void Insertar(Control.ControlCollection controles)
        //{
        //    _BD.InsertarAutomatizado("Empleados", controles);
        //}

        public void Insertar(Es_Pedidos Pedidos)
        {

            String sqlInsertar = "INSERT INTO Pedidos(numeroPedido, numeroCotizacion, fechaPedido, tipoDniVendedor, numDniVendedor, condicionPago, cuitCliente) VALUES(" + Pedidos.numeroPedido + "," + Pedidos.numeroCotizacion + "," + _BD.FormatearDato(Pedidos.fechaPedido, "Date") + "," + Pedidos.tipoDniVendedor + "," + Pedidos.numDniVendedor + ",'" + Pedidos.condicionPago + "','" + Pedidos.cuitCliente + "')";
            MessageBox.Show("El Pedido fue creado con exito!", "CREACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _BD.Insertar(sqlInsertar);

        }

        public DataTable Todos_los_Pedidos()
        {
            string sql = "SELECT * FROM Pedidos";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Buscar_PedidoPorNumero(int codigo)
        {
            string sql = "SELECT * FROM Pedidos WHERE numeroPedido = " + codigo;
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }

        public void Modificar(Es_Pedidos datos)
        {
            string sqlUpdate = "UPDATE Pedidos SET ";
            sqlUpdate += "cuitCliente = " + _BD.FormatearDato(datos.cuitCliente, "String");
            sqlUpdate += ", numeroCotizacion = " + _BD.FormatearDato(datos.numeroCotizacion, "Int");
            sqlUpdate += ", fechaPedido = " + _BD.FormatearDato(datos.fechaPedido, "Date");
            sqlUpdate += ", tipoDniVendedor = " + _BD.FormatearDato(datos.tipoDniVendedor, "Int");
            sqlUpdate += ", numDniVendedor = " + _BD.FormatearDato(datos.numDniVendedor, "Int");
            sqlUpdate += ", condicionPago = " + _BD.FormatearDato(datos.condicionPago, "String");
            sqlUpdate += " WHERE numeroPedido =" + datos.numeroPedido;
            MessageBox.Show("El Pedido fue modificado con exito!", "MODIFICACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _BD.Modificar(sqlUpdate);
        }
        public void Borrar(int num)
        {
            string sqlDelete = "DELETE FROM Pedidos WHERE numeroPedido = " + num;
            MessageBox.Show("El Pedido fue eliminado con exito!", "ELIMINACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _BD.Borrar(sqlDelete);
        }
        //public EstructuraComboBox EstructuraCombo()
        //{
        //    EstructuraComboBox EC = new EstructuraComboBox();
        //    EC.Display = "nombre";
        //    EC.Value = "codProducto";
        //    EC.Sql = "SELECT * FROM Productos";
        //    EC.Tabla = _BD.Consulta(EC.Sql);
        //    return EC;
        //}

        public String TraerMes(string doc)
        {
            string sql = "SELECT MONTH(fechaPedido) FROM Pedidos WHERE numeroPedido =" + doc;
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla.Rows[0][0].ToString();
        }

        public String TraerDia(string doc)
        {
            string sql = "SELECT DAY(fechaPedido) FROM Pedidos WHERE numeroPedido =" + doc;
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla.Rows[0][0].ToString();
        }

        public String TraerAño(string doc)
        {
            string sql = "SELECT YEAR(fechaPedido) FROM Pedidos WHERE numeroPedido =" + doc;
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla.Rows[0][0].ToString();
        }

        public void IniciarTransaccion()
        {
            _BD.IniciarTransaccion();
        }
        public void CerrarTransaccion()
        {
            _BD.CerrarTransaccion();
        }

        public DataTable Buscar_X_Fecha(string fechaMin, string fechaMax)
        {
            string sql = "SELECT *,YEAR(Pedidos.fechaPedido) AS 'año' FROM Pedidos WHERE fechaPedido BETWEEN " + _BD.FormatearDato(fechaMin, "Date") + " AND " + _BD.FormatearDato(fechaMax, "Date");
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Contar_Pedido_x_Año(string fechaMin, string fechaMax)
        {
            string sql = "SELECT YEAR(Pedidos.fechaPedido) AS 'año',COUNT(Pedidos.numeroPedido) AS 'cantidad' FROM Pedidos WHERE fechaPedido BETWEEN " + _BD.FormatearDato(fechaMin, "Date") + " AND " + _BD.FormatearDato(fechaMax, "Date") + " GROUP BY YEAR(Pedidos.fechaPedido)";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }

        public DataTable Buscar_PedidoPorEmpleado(string codigo)
        {
            string sql = "SELECT * FROM Pedidos WHERE numDniVendedor = " + codigo;
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }

        public DataTable Buscar_PedidoPorCliente(string codigo)
        {
            string sql = "SELECT * FROM Pedidos WHERE cuitCliente = " + codigo;
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }

        public DataTable VentasXProductos(string codigoProducto)
        {
            string sql = "select MONTH(Pedidos.fechaPedido) as 'Mes' , COUNT (DP.codigoProducto) as 'Cantidad' from Pedidos Pedidos join DetallePedido DP on (Pedidos.numeroPedido = DP.numeroPedido) where  YEAR(Pedidos.fechaPedido) = 2020 and DP.codigoProducto = " + codigoProducto + "group by MONTH(Pedidos.fechaPedido)";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }


        public EstructuraComboBox EstructuraCombo()
        {
            EstructuraComboBox EC = new EstructuraComboBox();
            EC.Display = "numeroPedido";
            EC.Value = "numeroPedido";
            EC.Sql = "SELECT * FROM Pedidos";
            EC.Tabla = _BD.Consulta(EC.Sql);
            return EC;
        }
    }
}

