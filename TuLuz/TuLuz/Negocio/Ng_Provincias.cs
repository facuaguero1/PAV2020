using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuLuz.Clases;
using TuLuz.Negocio.EstructuraNegocios;
using System.Windows.Forms;
using System.Data;

namespace TuLuz.Negocio
{
    class Ng_Provincias
    {
        Be_BaseDatos _BD = new Be_BaseDatos();

        public void Insertar(Es_Provincia Provincia)
        {
            String sqlInsertar = "INSERT INTO Provincia(codProvincia,nombre) VALUES(" + Provincia.codProvincia + ",'" + Provincia.nombre + "')";
            MessageBox.Show("La provincia fue creada con exito!", "CREACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _BD.Insertar(sqlInsertar);

        }

        public DataTable Todas_las_Provincias()
        {
            string sql = "SELECT * FROM Provincia";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Buscar_Provincia_Codigo(string cod)
        {
            string sql = "SELECT * FROM Provincia WHERE codProvincia = " + cod.Trim() + "";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable RecuperarProvincia_Codigo(string cod)
        {
            return _BD.Consulta("SELECT * FROM Provincia WHERE codProvincia = " + cod);
        }
        public void Modificar(Es_Provincia datos)
        {
            string sqlUpdate = "UPDATE Provincia SET ";
            sqlUpdate += "nombre = " + _BD.FormatearDato(datos.nombre, "String");
            sqlUpdate += " WHERE codProvincia = " + datos.codProvincia;

            MessageBox.Show("La provincia fue modificada con exito!", "MODIFICACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _BD.Modificar(sqlUpdate);
        }
        public void Borrar(string cod)
        {
            string sqlDelete = "DELETE FROM Provincia WHERE codProvincia = " + cod;
            MessageBox.Show("La provincia fue eliminada con exito!", "ELIMINACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _BD.Borrar(sqlDelete);
        }
        public EstructuraComboBox EstructuraCombo()
        {
            EstructuraComboBox EC = new EstructuraComboBox();
            EC.Display = "nombre";
            EC.Value = "codProvincia";
            EC.Sql = "SELECT * FROM Provincia";
            EC.Tabla = _BD.Consulta(EC.Sql);
            return EC;
        }
    }
}
