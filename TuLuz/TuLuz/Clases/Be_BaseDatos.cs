
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace TuLuz.Clases
{
    class Be_BaseDatos
    {
        SqlConnection Conexion = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        string Cadena_Conexion = "Data Source=LAPTOP-5NV6I6V9;Initial Catalog=_TuLuz;Integrated Security=True"; //CONEXION MATUTE
        //string Cadena_Conexion = "Data Source=DESKTOP-V8659BG;Initial Catalog=BaseDeDatos_TuLuz;Integrated Security=True"; //CONEXION FABRI
        //string Cadena_Conexion = "Data Source=USUARIO-PC\\SQLEXPRESS;Initial Catalog=DATABASE_TULUZ;Integrated Security=True"; // CONEXION FACU


        private void conectar()
        {
            Conexion.ConnectionString = Cadena_Conexion;
            Conexion.Open();
            Cmd.Connection = Conexion;
            Cmd.CommandType = System.Data.CommandType.Text;

        }
        private void Desconectar()
        {
            Conexion.Close();
        }

        public DataTable Consulta(string sql)
        {
            conectar();
            Cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            tabla.Load(Cmd.ExecuteReader());
            Desconectar();
            return tabla;

        }

        private string EjecutarNoSelect(string sql)
        {
            conectar();
            Cmd.CommandText = sql;
            Cmd.ExecuteNonQuery();
            DataTable tabla = new DataTable();
            Cmd.CommandText = "SELECT @@Identity";
            tabla.Load(Cmd.ExecuteReader());
            Desconectar();
            if (sql.ToUpper().IndexOf("INSERT") >= 0)
                return tabla.Rows[0][0].ToString();
            else
                return "";
        }

        public string Insertar(string sql)
        {
            return EjecutarNoSelect(sql);
        }
        public void Modificar(string sql)
        {
            EjecutarNoSelect(sql);
        }
        public void Borrar(string sql)
        {
            EjecutarNoSelect(sql);
        }
        //public string InsertarAutomatizado(string NombreTabla, Control.ControlCollection controles)
        //{
        //    //INSERT INTO Users (campo1, campo2,. . . campoN) VALUES (dato1, datos2, . . . datoN)
        //    string sqlInsertar = "INSERT INTO " + NombreTabla.Trim() + " (";
        //    string sqldatos = " VALUES (";
        //    DataTable Estructura = new DataTable();
        //    Estructura = EstructuraTabla(NombreTabla);

        //    for (int i = 0; i < Estructura.Columns.Count; i++)
        //    {
        //        string ValorCampo = BuscarValorCampo(Estructura.Columns[i].Caption, NombreTabla, controles);
        //        if (ValorCampo != "")
        //        {
        //            sqlInsertar += ", " + Estructura.Columns[i].Caption;
        //            sqldatos += ", " + FormatearDato(ValorCampo, Estructura.Columns[i].DataType.Name);
        //        }
        //    }
        //    sqlInsertar = sqlInsertar + ")" + sqldatos + ")";
        //    sqlInsertar = sqlInsertar.Replace("(,", "(");
        //    MessageBox.Show("El " + NombreTabla + " fue registrado con exito!", "REGISTRACION EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    return Insertar(sqlInsertar);
        //}
        //public void ModificarAutomatizado(string NombreTabla, string restriccion, Control.ControlCollection controles)
        //{
        //    //UPDATE Users SET campo1 = dato1 , campo2 = datos2, . . . campoN = datoN WHERE id_usuario = 1
        //    string sqlUpdate = "UPDATE " + NombreTabla.Trim() + " SET ";

        //    DataTable Estructura = new DataTable();
        //    Estructura = EstructuraTabla(NombreTabla);

        //    for (int i = 0; i < Estructura.Columns.Count; i++)
        //    {
        //        string ValorCampo = BuscarValorCampo(Estructura.Columns[i].Caption, NombreTabla, controles);
        //        if (ValorCampo != "")
        //        {
        //            sqlUpdate += ", " + Estructura.Columns[i].Caption + " = "
        //                + FormatearDato(ValorCampo, Estructura.Columns[i].DataType.Name);
        //        }
        //    }
        //    sqlUpdate = sqlUpdate + " WHERE " + restriccion;
        //    sqlUpdate = sqlUpdate.Replace("SET ,", "SET ");
        //    MessageBox.Show(sqlUpdate);
        //    Modificar(sqlUpdate);
        //}

        public string FormatearDato (string dato, string formato)
        {
            switch(formato)
            {
                case "String":
                    return "'" +dato+ "'";
                case "Date":
                case "DateTime":
                    return "convert(date, '" + dato + "',103)";
                default:
                    return dato;
            }
        }

        //private string BuscarValorCampo (string campo, string NombreTabla, Control.ControlCollection controles)
        //{
        //    foreach (var item in controles)
        //    {
        //        if (item.GetType().Name == "TextBox01")
        //        {
        //            if (((TextBox01)item).pp_nombre_campo is null)
        //                continue;

        //            if (campo == "activo")
        //            { 
        //                string True = "true";
        //                return True;
        //            }
        //            if (((TextBox01)item).pp_nombre_tabla.IndexOf(NombreTabla) != -1 && ((TextBox01)item).pp_nombre_campo == campo)
        //              return ((TextBox01)item).Text;

        //        }
        //        if (item.GetType().Name == "ComboBox01")
        //        {
        //            if (((ComboBox01)item).pp_nombre_campo is null)
        //                continue;

        //            if (((ComboBox01)item).pp_nombre_tabla.IndexOf(NombreTabla) != -1
        //                && (((ComboBox01)item).pp_nombre_campo == campo))
        //            {
        //                return ((ComboBox01)item).SelectedValue.ToString();
        //            }
        //        }
        //    }
        //    return "";
        //}

        //private DataTable EstructuraTabla (string NombreTabla) //recupero solamente la fila 1 de la tabla
        //{
        //    string sql = "SELECT TOP 1 * FROM " + NombreTabla.Trim();
        //    DataTable tabla = new DataTable();
        //    tabla = this.Consulta(sql);
        //    return tabla;
        //}

    }

}
