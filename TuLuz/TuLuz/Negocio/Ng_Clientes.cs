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
    class Ng_Clientes
    {
        Be_BaseDatos _BD = new Be_BaseDatos();
        public void Insertar(Control.ControlCollection controles)
        {
            _BD.InsertarAutomatizado("Cliente", controles);
        }

        public DataTable Todos_los_Clientes()
        {
            string sql = "SELECT * FROM cliente";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Buscar_Cliente(string cuit)
        {
            string sql = "SELECT * FROM cliente WHERE cuitCliente like '%" + cuit.Trim() + "%'";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable RecuperarCliente(string cuit)
        {
            return _BD.Consulta("SELECT * FROM cliente WHERE cuitCliente = " + cuit);
        }
        public void Modificar (Es_Clientes datos)
        {
            string sqlUpdate = "UPDATE Cliente SET ";
            sqlUpdate += "nombre = " + _BD.FormatearDato(datos.nombre, "String");
            sqlUpdate += ", apellido = " + _BD.FormatearDato(datos.apellido, "String");
            sqlUpdate += " WHERE cuitCliente = " + datos.cuitCliente;

            MessageBox.Show("El cliente fue modificado con exito!", "MODIFICACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _BD.Modificar(sqlUpdate);
            
        }
        public void Borrar(string cuit)
        {
            string sqlDelete = "DELETE FROM Cliente WHERE cuitCliente = "+ cuit;
            MessageBox.Show("El cliente fue eliminado con exito!", "ELIMINACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _BD.Borrar(sqlDelete);
        }
    }
    
}
