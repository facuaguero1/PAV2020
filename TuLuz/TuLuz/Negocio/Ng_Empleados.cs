﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuLuz.Clases;
using System.Data;
using System.Windows.Forms;
using TuLuz.Negocio.EstructuraNegocios;

namespace TuLuz.Negocio
{
    class Ng_Empleados
    {
        Be_BaseDatos _BD = new Be_BaseDatos();
        //public void Insertar(Control.ControlCollection controles)
        //{
        //    _BD.InsertarAutomatizado("Empleados", controles);
        //}

        public void Insertar(Es_Empleados Empleado)
        {

            String sqlInsertar = "INSERT INTO Empleados(tipoDoc, numDoc, nombre, apellido, direccion, codBarrio, telefono, tipoDocJefe, numDocJefe, activo) VALUES(" + Empleado.tipoDoc + "," + Empleado.numDoc + ",'" + Empleado.nombre + "','" +Empleado.apellido + "','" + Empleado.direccion + "'," + Empleado.codBarrio + ",'" +Empleado.telefono + "'," + Empleado.tipoDocJefe + "," + Empleado.numDocJefe + ",'" + Empleado.activo + "')";
            MessageBox.Show("El Empleado fue creado con exito!", "CREACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _BD.Insertar(sqlInsertar);

        }

        public DataTable Todos_los_Empleados()
        {
            string sql = "SELECT * FROM Empleados";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Buscar_Empleados(string doc)
        {
            string sql = "SELECT * FROM empleados WHERE numDoc like '%" + doc.Trim() + "%'";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Buscar_Empleados_Usuario(string usr)
        {
            string sql = "SELECT Empleados.* FROM Empleados, Usuario WHERE  Empleados.numDoc = Usuario.numDocEmpleado AND Usuario.usuario LIKE '"+usr+"'";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable RecuperarEmpleados(string doc)
        {
            return _BD.Consulta("SELECT * FROM empleados WHERE numDoc = " + doc);
        }

        //AGREGAR BIEN LOS DATOS FALTANTES A LA MODIFICACION Y BORRADO

        public void Modificar(Es_Empleados datos)
        {
            string sqlUpdate = "UPDATE Empleados SET ";
            sqlUpdate += "nombre = " + _BD.FormatearDato(datos.nombre, "String");
            sqlUpdate += ", apellido = " + _BD.FormatearDato(datos.apellido, "String");
            sqlUpdate += ", direccion = " + _BD.FormatearDato(datos.direccion, "String");

            sqlUpdate += ", codBarrio = " + _BD.FormatearDato(datos.codBarrio, "Int");
            sqlUpdate += ", telefono = " + _BD.FormatearDato(datos.telefono, "String");

            if (datos.tipoDocJefe == "")
            {
                sqlUpdate += ", tipoDocJefe = " + _BD.FormatearDato("NULL", "String");
                sqlUpdate += ", numDocJefe = " + _BD.FormatearDato("NULL", "String");
            }
            else
            {
                sqlUpdate += ", tipoDocJefe = " + _BD.FormatearDato(datos.tipoDocJefe, "String");
                sqlUpdate += ", numDocJefe = " + _BD.FormatearDato(datos.numDocJefe, "String");
            }
            sqlUpdate += " WHERE numDoc = " + datos.numDoc;

            MessageBox.Show("El Empleado fue modificado con exito!", "MODIFICACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _BD.Modificar(sqlUpdate);

        }
        public void Borrar(string Doc)
        {
            string sqlDelete = "DELETE FROM Empleados WHERE numDoc = " + Doc;
            MessageBox.Show("El Empleado fue eliminado con exito!", "ELIMINACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _BD.Borrar(sqlDelete);
        }
    }
}

