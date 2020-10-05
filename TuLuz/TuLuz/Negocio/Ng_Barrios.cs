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
    class Ng_Barrios
    {
      Be_BaseDatos _BD = new Be_BaseDatos();
       
        public void Insertar(Es_Barrio Barrio)
        {
            String sqlInsertar = "INSERT INTO Barrio(codBarrio,nombre,codLocalidad) VALUES(" +Barrio.codBarrio + ",'" + Barrio.nombre + "'," + Barrio.codLocalidad + ")";
            MessageBox.Show("El Barrio fue creado con exito!", "CREACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _BD.Insertar(sqlInsertar);
            
        }

        public DataTable Todos_los_Barrios()
        {
            string sql = "SELECT * FROM Barrio";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Buscar_Barrio_Codigo(string cod)
        {
            string sql = "SELECT * FROM Barrio WHERE codBarrio = " + cod.Trim() + "";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Buscar_Barrio_Nombre(string nom)
        {
            string sql = "SELECT * FROM Barrio WHERE nombre like '%" + nom.Trim() + "%'";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
            public DataTable RecuperarBarrio_Codigo(string cod)
        {
            return _BD.Consulta("SELECT * FROM Barrio WHERE codBarrio = " + cod);
        }
        public DataTable RecuperarBarrio_Nombre(string nom)
        {
            return _BD.Consulta("SELECT * FROM Barrio WHERE nombre like '%" + nom + "%'");
        }
        public void Modificar(Es_Barrio datos)
        {
            string sqlUpdate = "UPDATE Barrio SET ";
            sqlUpdate += "codLocalidad = " + _BD.FormatearDato(datos.codLocalidad, "String");
            sqlUpdate += ", nombre = " + _BD.FormatearDato(datos.nombre, "String");
            sqlUpdate += " WHERE codBarrio = " + datos.codBarrio;

            MessageBox.Show("El Barrio fue modificado con exito!", "MODIFICACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _BD.Modificar(sqlUpdate);

        }
        public void Borrar(string cod)
        {
            string sqlDelete = "DELETE FROM Barrio WHERE codBarrio = " + cod;
            MessageBox.Show("El Barrio fue eliminado con exito!", "ELIMINACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _BD.Borrar(sqlDelete);
        }
        public EstructuraComboBox EstructuraCombo()
        {
            EstructuraComboBox EC = new EstructuraComboBox();
            EC.Display = "nombre";
            EC.Value = "codBarrio";
            EC.Sql = "SELECT * FROM Barrio";
            EC.Tabla = _BD.Consulta(EC.Sql);
            return EC;
        }

        public EstructuraComboBox EstructuraComboEspecial(int cod)
        {
            EstructuraComboBox EC = new EstructuraComboBox();
            EC.Display = "nombre";
            EC.Value = "codBarrio";
            EC.Sql = "SELECT * FROM Barrio WHERE codLocalidad = "+ cod;
            EC.Tabla = _BD.Consulta(EC.Sql);
            return EC;
        }
    }

}

