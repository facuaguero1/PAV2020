using System;
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

            String sqlInsertar = "INSERT INTO Empleados(tipoDoc, numDoc, nombre, apellido, direccion, codBarrio, telefono, tipoDocJefe, numDocJefe, activo) VALUES(" + Empleado.tipoDoc + "," + Empleado.numDoc + ",'" + Empleado.nombre + "','" + Empleado.apellido + "','" + Empleado.direccion + "'," + Empleado.codBarrio + ",'" + Empleado.telefono + "'," + Empleado.tipoDocJefe + "," + Empleado.numDocJefe + ",'" + Empleado.activo + "')";
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
        public DataTable Es_Empleado_Jefe_Supervisor()
        {
            string sql = "SELECT j.tipoDoc, j.numDoc, j.nombre, j.apellido, j. direccion , j.telefono FROM empleados e join empleados j ON (e.numDocJefe = j.numDoc)";
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

        public DataTable Buscar_Empleados_Jefes(string doc)
        {
            string sql = "SELECT * FROM empleados WHERE numDocJefe like '%" + doc.Trim() + "%'";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Buscar_Empleados_Usuario(string usr)
        {
            string sql = "SELECT Empleados.* FROM Empleados, Usuario WHERE  Empleados.numDoc = Usuario.numDocEmpleado AND Usuario.usuario LIKE '" + usr + "'";
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
                sqlUpdate += ", tipoDocJefe = NULL";
                sqlUpdate += ", numDocJefe = NULL";
            }
            else
            {
                sqlUpdate += ", tipoDocJefe = " + datos.tipoDocJefe;
                sqlUpdate += ", numDocJefe = " + datos.numDocJefe;
            }
            sqlUpdate += ", activo = " + _BD.FormatearDato(datos.activo, "String");
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

        public int ContarCotizacionDelCliente(string cuit)
        {
            DataTable Cotizaciones = new DataTable();
            Cotizaciones = _BD.Consulta("SELECT Empleados.* FROM Empleados, Cotizaciones WHERE " + cuit + " = Cotizaciones.numDocVendedor");
            return Cotizaciones.Rows.Count;
        }

        public void DarBaja(string cuit)
        {
            string sqlUpdate = "UPDATE Empleados SET activo = 'false' WHERE numDoc = '" + cuit + "'";
            _BD.Modificar(sqlUpdate);
        }

        public EstructuraComboBox EstructuraCombo()
        {
            EstructuraComboBox EC = new EstructuraComboBox();
            EC.Display = "numDoc";
            EC.Value = "numDoc";
            EC.Sql = "SELECT * FROM Empleados";
            EC.Tabla = _BD.Consulta(EC.Sql);
            return EC;
        }

        public EstructuraComboBox EstructuraComboxListado()
        {
            EstructuraComboBox EC = new EstructuraComboBox();
            EC.Display = "nombre";
            EC.Value = "numDoc";
            EC.Sql = "SELECT * FROM Empleados";
            EC.Tabla = _BD.Consulta(EC.Sql);
            return EC;
        }

    }
}

