﻿
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
        //string Cadena_Conexion = "Data Source=(Localdb)\\MatiasServidor;Initial Catalog=_TuLuz;Integrated Security=True"; //CONEXION MATUTE
        //string Cadena_Conexion = "Data Source=DESKTOP-V8659BG;Initial Catalog=BaseDeDatos_TuLuz;Integrated Security=True"; //CONEXION FABRI
        string Cadena_Conexion = "Data Source=USUARIO-PC\\SQLEXPRESS;Initial Catalog=DATABASE_TULUZ;Integrated Security=True"; // CONEXION FACU


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

        private string EjecutarNoSelect (string sql)
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

        public string Insertar (string sql)
        {
            return EjecutarNoSelect(sql);
        }
        public void Modificar(string sql)
        {
            EjecutarNoSelect(sql);
        }
        public void Borrar (string sql)
        {
            EjecutarNoSelect(sql);
        }
        

        public string InsertarAutomatizado (string NombreTabla, Control.ControlCollection controles)
        {
            //INSERT INTO Cliente (campo1, campo2,....., campoN) VALUES (dato1, dato2, ......, datoN)
            string sqlInsertar = "INSERT INTO " + NombreTabla.Trim() + "(";
            string sqlDatos = "VALUES (";
            DataTable Estructura = new DataTable();
            Estructura = EstructuraTabla(NombreTabla);

            for (int i = 0; i < Estructura.Columns.Count; i++)
            {
                string ValorCampo = BuscarValorCampo(Estructura.Columns[i].Caption, NombreTabla, controles); //buscar el nombre de la columna en la posicion i
                if (ValorCampo!= "")
                {
                    sqlInsertar += ", " + Estructura.Columns[i].Caption;
                    sqlDatos += ", " + FormatearDato(ValorCampo, Estructura.Columns[i].DataType.Name); //data type me devuelve el tipo de dato que tiene ese campo (int, bool, etc)
                }
            }
            sqlInsertar = sqlInsertar + ") " + sqlDatos + ")";
            sqlInsertar = sqlInsertar.Replace("(,", "(");
            MessageBox.Show("El " + NombreTabla + " fue registrado con exito!", "REGISTRACION EXITOSA",MessageBoxButtons.OK,MessageBoxIcon.Information);
            return Insertar(sqlInsertar);
        }
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
        private string BuscarValorCampo (string campo, string NombreTabla, Control.ControlCollection controles)
        {
            foreach (var item in controles)
            {
                if (item.GetType().Name=="TextBox01")
                {
                    if (((TextBox01)item).pp_nombre_campo is null)
                        continue;
                    if (((TextBox01)item).pp_nombre_tabla.IndexOf(NombreTabla)!= -1 && ((TextBox01)item).pp_nombre_campo==campo)
                    {
                        return ((TextBox01)item).Text;
                    }
                }
            }
            return "";
        }

        private DataTable EstructuraTabla (string NombreTabla) //recupero solamente la fila 1 de la tabla
        {
            string sql = "SELECT TOP 1 * FROM " + NombreTabla.Trim();
            DataTable tabla = new DataTable();
            tabla = this.Consulta(sql);
            return tabla;
        }
    }

}
