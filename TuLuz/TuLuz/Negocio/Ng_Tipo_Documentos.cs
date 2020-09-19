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
    class Ng_Tipo_Documentos
    {
        Be_BaseDatos _BD = new Be_BaseDatos();

        public void Insertar(Control.ControlCollection controles)
        {
            _BD.InsertarAutomatizado("TiposDoc", controles);
        }

        public DataTable Todos_las_Tipos_Doc()
        {
            string sql = "SELECT * FROM TiposDoc";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Buscar_TiposDoc_Codigo(string cod)
        {
            string sql = "SELECT * FROM TiposDoc WHERE idTipoDoc = " + cod.Trim();
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Buscar_TipoDoc_Nombre(string nom)
        {
            string sql = "SELECT * FROM TiposDoc WHERE nombre like '%" + nom.Trim() + "%'";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
        public DataTable Recuperar_Tipo_Doc_Codigo(string cod)
        {
            return _BD.Consulta("SELECT * FROM TiposDoc WHERE idTIpoDoc = " + cod);
        }
        public DataTable Recuperar_Tipo_Doc_Nombre(string nom)
        {
            return _BD.Consulta("SELECT * FROM TiposDoc WHERE nombre like '%" + nom + "%'");
        }
        //public void Modificar(Es_Tipos_Doc datos)
        //{
        //    string sqlUpdate = "UPDATE TiposDoc SET ";
        //    sqlUpdate += "codProvincia = " + _BD.FormatearDato(datos.codProvincia, "String");
        //    sqlUpdate += ", nombre = " + _BD.FormatearDato(datos.nombre, "String");
        //    sqlUpdate += " WHERE codLocalidad = " + datos.codLocalidad;

        //    MessageBox.Show("El Barrio fue modificado con exito!", "MODIFICACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    _BD.Modificar(sqlUpdate);

        //}
        //public void Borrar(string cod)
        //{
        //    string sqlDelete = "DELETE FROM Localidad WHERE codLocalidad = " + cod;
        //    MessageBox.Show("La Localidad fue eliminado con exito!", "ELIMINACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    _BD.Borrar(sqlDelete);
        //}

        public EstructuraComboBox EstructuraCombo()
        {
            EstructuraComboBox EC = new EstructuraComboBox();
            EC.Display = "siglas";
            EC.Value = "idTipoDoc";
            EC.Sql = "SELECT * FROM TiposDoc";
            EC.Tabla = _BD.Consulta(EC.Sql);
            return EC;
        }
    }
}
