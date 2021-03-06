﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuLuz.Negocio.EstructuraNegocios;
using System.Windows.Forms;
using System.Data;
using TuLuz.Clases;

namespace TuLuz.Negocio.EstructuraNegocios
{
    class Ng_Proveedor
    {
        Be_BaseDatos _BD = new Be_BaseDatos();

        public void Insertar(Es_Proveedor Proveedor)
        {

            String sqlInsertar = "INSERT INTO Proveedor (cuitProveedor, razonSocial, contacto, telefono) VALUES(" + Proveedor.cuitProveedor + ",'" + Proveedor.razonSocial + "','" + Proveedor.contacto + "',"+ Proveedor.telefono + ")";
            MessageBox.Show("El Proveedor fue creado con exito!", "CREACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _BD.Insertar(sqlInsertar);

        }
        public DataTable Todos_los_proveedores()
        {
            string sql = "SELECT * FROM Proveedor";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Buscar_Proveedor_Codigo(string cod)
        {
            string sql = "SELECT * FROM Proveedor WHERE cuitProveedor = " + cod.Trim();
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Buscar_Proveedor_Nombre(string nom)
        {
            string sql = "SELECT * FROM Proveedor WHERE nombre like '%" + nom.Trim() + "%'";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable RecuperarProveedor_Codigo(string cod)
        {
            return _BD.Consulta("SELECT * FROM Proveedor WHERE cuitProveedor = " + cod);
        }
        public DataTable RecuperarProveedor_Nombre(string nom)
        {
            return _BD.Consulta("SELECT * FROM Proveedor WHERE nombre like '%" + nom + "%'");
        }
        public void Modificar(Es_Proveedor datos)
        {
            string sqlUpdate = "UPDATE Proveedor SET ";
            sqlUpdate += "razonSocial = " + _BD.FormatearDato(datos.razonSocial, "String");
            sqlUpdate += ", contacto = " + _BD.FormatearDato(datos.contacto, "String");
            sqlUpdate += ", telefono = " + _BD.FormatearDato(datos.telefono, "String");
            sqlUpdate += " WHERE cuitProveedor = " + datos.cuitProveedor;

            MessageBox.Show("El Proveedor fue modificado con exito!", "MODIFICACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _BD.Modificar(sqlUpdate);

        }
        public void Borrar(string cod)
        {
            string sqlDelete = "DELETE FROM Proveedor WHERE cuitProveedor= " + cod;
            MessageBox.Show("El Proveedor fue eliminado con exito!", "ELIMINACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _BD.Borrar(sqlDelete);
        }

        //public EstructuraComboBox EstructuraCombo()
        //{
        //    EstructuraComboBox EC = new EstructuraComboBox();
        //    EC.Display = "nombre";
        //    EC.Value = "codLocalidad";
        //    EC.Sql = "SELECT * FROM Localidad";
        //    EC.Tabla = _BD.Consulta(EC.Sql);
        //    return EC;
        //}
    }
}
