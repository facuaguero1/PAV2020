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
    class Ng_Users
    {
        public enum Respuesta { validacion_Correcta, validacion_Fallida};
        Be_BaseDatos BaseDatos = new Be_BaseDatos();

        public Respuesta validarUsuario(string usr, string pwd)
        {
            string sql = "";
            sql = "SELECT * FROM Usuario WHERE usuario= '" + usr + "' AND password= '" + pwd +"'";
            DataTable tabla = new DataTable();
            tabla = BaseDatos.Consulta(sql);

            if (tabla.Rows.Count == 0)
            {
                //decir que no existe ningun usaurio
                return Respuesta.validacion_Fallida;

            }
            else
            {
                //decir que si existe
                return Respuesta.validacion_Correcta;

            }
        }
        public void Insertar(Es_Usuario usuario)
        {
            
            String sqlInsertar = "INSERT INTO Usuario (usuario, password, numDocEmpleado) VALUES('" + usuario.usuario + "','" + usuario.password + "'," + usuario.numDocEmpleado + ")";
           
            BaseDatos.Insertar(sqlInsertar);

        }

    }
}
