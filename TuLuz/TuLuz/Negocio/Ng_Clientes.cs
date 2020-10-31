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

        //public void Insertar(Control.ControlCollection controles)
        //{
        //    _BD.InsertarAutomatizado("Cliente", controles);
        //}

        public void Insertar(Es_Clientes Cliente)
        {
            String sqlInsertar = "INSERT INTO Cliente(cuitCliente,nombre,apellido,activo) VALUES(" + Cliente.cuitCliente + ",'" + Cliente.nombre + "','" + Cliente.apellido + "','" + Cliente.activo +"')";
            MessageBox.Show("El Cliente fue registrado con exito!", "REGISTRACION EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _BD.Insertar(sqlInsertar);

        }

        public DataTable Todos_los_ClientesActivos()
        {
            string sql = "SELECT * FROM cliente WHERE activo = 'true'";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }

        public DataTable Todos_los_ClientesNoActivos()
        {
            string sql = "SELECT * FROM cliente WHERE activo = 'false'";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Buscar_Cliente(string cuit)
        {
            string sql = "SELECT * FROM Cliente WHERE cuitCliente like '%" + cuit.Trim() + "%'";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable RecuperarCliente(string cuit)
        {
            return _BD.Consulta("SELECT * FROM cliente WHERE cuitCliente like " + cuit );
        }
        public DataTable Todos_los_Clientes()
        {
            string sql = "SELECT * FROM cliente";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }

        public DataTable ContarClientesAcNoAc ()
        {
            string sql = "SELECT Cliente.activo, COUNT (Cliente.cuitCliente) AS 'cantidad' FROM Cliente GROUP BY Cliente.activo";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }

        public DataTable Buscar_ClienteMasBajos(string cuit)
        {
            string sql = "SELECT * FROM Cliente WHERE cuitCliente like '%" + cuit.Trim() + "%' ";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }

        public int ContarPedidosDelCliente(string cuit) {
            DataTable Pedidos = new DataTable();
            Pedidos = _BD.Consulta("SELECT Pedidos.* FROM Cliente, Pedidos WHERE "+ cuit +" = Pedidos.cuitCliente");
            return Pedidos.Rows.Count;
        }
        public int ContarCotizacionDelCliente(string cuit)
        {
            DataTable Cotizaciones = new DataTable();
            Cotizaciones = _BD.Consulta("SELECT Cotizaciones.* FROM Cliente, Cotizaciones WHERE " + cuit + " = Cotizaciones.cuitCliente");
            return Cotizaciones.Rows.Count;
        }

        public void DarBaja(string cuit)
        {
            string sqlUpdate = "UPDATE Cliente SET activo = 'false' WHERE cuitCliente = '"+ cuit+"'";
            _BD.Modificar(sqlUpdate);
        }

        public void Modificar (Es_Clientes datos)
        {
            string sqlUpdate = "UPDATE Cliente SET ";
            sqlUpdate += "nombre = " + _BD.FormatearDato(datos.nombre, "String");
            sqlUpdate += ", apellido = " + _BD.FormatearDato(datos.apellido, "String");
            sqlUpdate += ", activo = " + _BD.FormatearDato(datos.activo, "String");
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

        public EstructuraComboBox EstructuraCombo()
        {
            EstructuraComboBox EC = new EstructuraComboBox();
            EC.Display = "cuitCliente";
            EC.Value = "cuitCliente";
            EC.Sql = "SELECT * FROM Cliente";
            EC.Tabla = _BD.Consulta(EC.Sql);
            return EC;
        }

        public EstructuraComboBox EstructuraComboxListado()
        {
            EstructuraComboBox EC = new EstructuraComboBox();
            EC.Display = "nombre";
            EC.Value = "cuitCliente";
            EC.Sql = "SELECT * FROM Cliente";
            EC.Tabla = _BD.Consulta(EC.Sql);
            return EC;
        }
    }
    
}
