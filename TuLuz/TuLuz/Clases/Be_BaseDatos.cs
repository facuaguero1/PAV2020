
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
        public enum EstadoAccionBD { correcto, error };
        public enum EstadoTransaccion { correcta, error };
        public enum TipoConexion { simple, transaccional };

        SqlConnection Conexion = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        SqlTransaction Transaccion; //declaracion del manipulador de la transaccion 
        public EstadoTransaccion ControlTransaccion { get; set; } = EstadoTransaccion.correcta; //seteo la transaccion en correcta
        TipoConexion ControlConexion = TipoConexion.simple; //indico que la transaccion por defecto es simple


        string Cadena_Conexion = "Data Source=LAPTOP-5NV6I6V9;Initial Catalog=_BD_TuLuz;Integrated Security=True"; //CONEXION MATUTE
        //string Cadena_Conexion = "Data Source=DESKTOP-V8659BG;Initial Catalog=DATABASE_TULUZ;Integrated Security=True"; //CONEXION FABRI
        //string Cadena_Conexion = "Data Source=USUARIO-PC\\SQLEXPRESS;Initial Catalog=DATABASE_TULUZ;Integrated Security=True"; // CONEXION FACU
        //string Cadena_Conexion = "Data Source=LAPTOP-GR111J17;Initial Catalog=TuLuz;Integrated Security=True"; //CONEXION MARTIN
        //string Cadena_Conexion = "Data Source=desktop-a7p75ig\\sqlexpress;Initial Catalog=DATABASE_TULUZ;Integrated Security=True"; //CONEXION agusto
        //string Cadena_Conexion = "Data Source=DESKTOP-LBDC65G;Initial Catalog=TuLuz;Integrated Security=True"; // CONEXION PEDRO

        //-----------------------------------------INICIAR TRANSACCION-----------------------------------------
        public void IniciarTransaccion()
        {
            ControlConexion = TipoConexion.transaccional;
            ControlTransaccion = EstadoTransaccion.correcta;
        }

        //-----------------------------------------FIN DE LA TRANSACCION-----------------------------------------

        public EstadoTransaccion CerrarTransaccion ()
        {
            if (ControlConexion == TipoConexion.transaccional) //¿la coneccion es transaccional?
            {
                if (ControlTransaccion== EstadoTransaccion.correcta) //¿la transaccion es correcta sin errores?
                {
                    Transaccion.Commit(); //finaliza y guarda
                }
                else
                {
                    Transaccion.Rollback(); //finaliza y borra todos los cambios realizados
                }
                ControlConexion = TipoConexion.simple;
                Desconectar();
            }
            return ControlTransaccion;
        }
        //----------------------------------------- CONECTAR CON LA BD -----------------------------------------

        private void conectar()
        {
            if (Conexion.State == ConnectionState.Closed) 
            {
                Conexion.ConnectionString = Cadena_Conexion;
                Conexion.Open();
                Cmd.Connection = Conexion;
                Cmd.CommandType = System.Data.CommandType.Text;

                if (ControlConexion == TipoConexion.transaccional)
                {
                    Transaccion = Conexion.BeginTransaction(IsolationLevel.ReadCommitted);
                    Cmd.Transaction = Transaccion;
                }
            }
        //-----------------------------------------DESCONECTAR CON LA BD-----------------------------------------

        }
        private void Desconectar()
        {
            if (ControlConexion == TipoConexion.simple)
            {
                Conexion.Close();
            }
        }
        //-----------------------------------------METODO CONSULTA (SELECT)-----------------------------------------

        public DataTable Consulta(string sql)
        {
            conectar();
            Cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            try //recuperador de errores
            {
                tabla.Load(Cmd.ExecuteReader());
            }
            catch (Exception e) //si NO hay errores, no ingresa al CATCH
            {
                ControlTransaccion = EstadoTransaccion.error;
                MessageBox.Show("Error con la Base de Datos" + "\n"
                                + "En el comando:" + "\n"
                                + sql + "\n"
                                + "El mensaje es: " + "\n"
                                + e.Message);
            }
            Desconectar();
            return tabla;
        }
        //-----------------------------------------METODO INSERT, UPDATE Y DELETE -----------------------------------------

        private string EjecutarNoSelect(string sql)
        {
            conectar();
            Cmd.CommandText = sql;
            try
            {
              Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ControlTransaccion = EstadoTransaccion.error;
                MessageBox.Show("Error con la Base de Datos" + "\n"
                                + "En el comando:" + "\n"
                                + sql + "\n"
                                + "El mensaje es: " + "\n"
                                + e.Message);
            }
            if (sql.ToUpper().IndexOf("INSERT") >= 0)
            {
                DataTable tabla = new DataTable();
                Cmd.CommandText = "SELECT @@Identity";
                try
                {
                     tabla.Load(Cmd.ExecuteReader());
                }
                catch (Exception e)
                {
                    ControlTransaccion = EstadoTransaccion.error;
                    MessageBox.Show("Error con la Base de Datos" + "\n"
                                    + "En el comando:" + "\n"
                                    + "SELECT @@Identity  \n"
                                    + "El mensaje es: " + "\n"
                                    + e.Message);
                }
                Desconectar();  
                return tabla.Rows[0][0].ToString();
            }
            else
            {
                Desconectar();
                return "";
            }
        }
        //-----------------------------------------INSERT-----------------------------------------
        public string Insertar(string sql)
        {
            return EjecutarNoSelect(sql);
        }
        //----------------------------------------- UPDATE-----------------------------------------

        public void Modificar(string sql)
        {
            EjecutarNoSelect(sql);
        }
        //-----------------------------------------DELETE-----------------------------------------

        public void Borrar(string sql)
        {
            EjecutarNoSelect(sql);
        }
        //-----------------------------------------FORMATEAR DATOS-----------------------------------------

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


        //private DataTable EstructuraTabla (string NombreTabla) //recupero solamente la fila 1 de la tabla
        //{
        //    string sql = "SELECT TOP 1 * FROM " + NombreTabla.Trim();
        //    DataTable tabla = new DataTable();
        //    tabla = this.Consulta(sql);
        //    return tabla;
        //}

    }

}
