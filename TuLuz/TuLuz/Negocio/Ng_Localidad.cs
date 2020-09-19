using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuLuz.Negocio.EstructuraNegocios;
using System.Windows.Forms;
using System.Data;
using TuLuz.Clases;

namespace TuLuz.Negocio
{
    class Ng_Localidad
    {
        Be_BaseDatos _BD = new Be_BaseDatos();

        //public void Insertar(Control.ControlCollection controles)
        //{
        //    _BD.InsertarAutomatizado("Localidad", controles);
        //}
        public void Insertar(Es_Localidad localidad)
        {

            String sqlInsertar = "INSERT INTO Localidad (codLocalidad, nombre, codProvincia) VALUES(" + localidad.codLocalidad + ",'" + localidad.nombre + "'," + localidad.codProvincia + ")";
            MessageBox.Show("La Localidad fue creada con exito!", "CREACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _BD.Insertar(sqlInsertar);

        }
        public DataTable Todos_las_Localidades()
        {
            string sql = "SELECT * FROM Localidad";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Buscar_Localidad_Codigo(string cod)
        {
            string sql = "SELECT * FROM Localidad WHERE codLocalidad = " + cod.Trim();
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Buscar_Localidad_Nombre(string nom)
        {
            string sql = "SELECT * FROM Localidad WHERE nombre like '%" + nom.Trim() + "%'";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable RecuperarLocalidad_Codigo(string cod)
        {
            return _BD.Consulta("SELECT * FROM Localidad WHERE codLocalidad = " + cod);
        }
        public DataTable RecuperarLocalidad_Nombre(string nom)
        {
            return _BD.Consulta("SELECT * FROM Localidad WHERE nombre like '%" + nom + "%'");
        }
        public void Modificar(Es_Localidad datos)
        {
            string sqlUpdate = "UPDATE Localidad SET ";
            sqlUpdate += "codProvincia = " + _BD.FormatearDato(datos.codProvincia, "String");
            sqlUpdate += ", nombre = " + _BD.FormatearDato(datos.nombre, "String");
            sqlUpdate += " WHERE codLocalidad = " + datos.codLocalidad;

            MessageBox.Show("La Localidad fue modificada con exito!", "MODIFICACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _BD.Modificar(sqlUpdate);

        }
        public void Borrar(string cod)
        {
            string sqlDelete = "DELETE FROM Localidad WHERE codLocalidad = " + cod;
            MessageBox.Show("La Localidad fue eliminada con exito!", "ELIMINACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _BD.Borrar(sqlDelete);
        }

        public EstructuraComboBox EstructuraCombo()
        {
            EstructuraComboBox EC = new EstructuraComboBox();
            EC.Display = "nombre";
            EC.Value = "codLocalidad";
            EC.Sql = "SELECT * FROM Localidad";
            EC.Tabla = _BD.Consulta(EC.Sql);
            return EC;
        }


    }
}
