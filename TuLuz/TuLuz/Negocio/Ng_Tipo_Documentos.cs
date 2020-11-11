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

        public void Insertar(Es_TipoDocs Docs)
        {
            String sqlInsertar = "INSERT INTO TiposDoc(idTipoDoc,siglas,nombre) VALUES(" + Docs.idTipoDoc + ",'" + Docs.siglas + "','" + Docs.nombre + "')";
            MessageBox.Show("El Tipo Documento fue creado con exito!", "CREACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _BD.Insertar(sqlInsertar);
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
        public void Modificar(Es_TipoDocs datos)
        {
            string sqlUpdate = "UPDATE TiposDoc SET ";
            sqlUpdate += "idTipoDoc = " + _BD.FormatearDato(datos.idTipoDoc, "String");
            sqlUpdate += ", nombre = " + _BD.FormatearDato(datos.nombre, "String");
            sqlUpdate += ", siglas = " + _BD.FormatearDato(datos.siglas, "String");
            sqlUpdate += " WHERE idTipoDoc = " + datos.idTipoDoc;

           MessageBox.Show("El Tipo Documento fue modificado con exito!", "MODIFICACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
           _BD.Modificar(sqlUpdate);

        }
        public void Borrar(string id)
        {
            string sqlDelete = "DELETE FROM TiposDoc WHERE idTipoDoc = " + id;
            MessageBox.Show("La Tipo Documento fue eliminado con exito!", "ELIMINACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _BD.Borrar(sqlDelete);
        }

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
