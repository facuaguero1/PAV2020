using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using TuLuz.Clases;
using TuLuz.Negocio;
using TuLuz.Negocio.EstructuraNegocios;

class Ng_Cotizaciones
{
    Be_BaseDatos _BD = new Be_BaseDatos();


    public void Insertar(Es_Cotizaciones Cotizacion)
    {
        String sqlInsertar = "INSERT INTO Cotizaciones(numeroCotizacion, año, cuitCliente, tipoDocVendedor, numDocVendedor, codEstadoCotizacion, nombreSolicitante, apellidoSolicitante, fecha, observaciones, precioTotal, motivoPerdida, nomCompetidor) VALUES(" + Cotizacion.numeroCotizacicon + ",'" + Cotizacion.año + "','" + Cotizacion.cuitCliente + "'," + Cotizacion.tipoDocVendedor + "," + Cotizacion.numDocVendedor + "," + Cotizacion.codEstadoCotizacion + ",'" + Cotizacion.nombreSolicitante + "','" + Cotizacion.apellidoSolicitante + "','" + Cotizacion.fecha + "','" + Cotizacion.observaciones + "'," + Cotizacion.precioTotal + ",'" + Cotizacion.motivoPerdida + "','" + Cotizacion.nomCompetidor + "')";
        MessageBox.Show("La Cotizacion fue creado con exito!", "CREACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        _BD.Insertar(sqlInsertar);

    }

    public DataTable Todas_Las_Cotizciones()
    {
        string sql = "SELECT * FROM Cotizaciones";
        DataTable tabla = new DataTable();
        tabla = _BD.Consulta(sql);
        return tabla;
    }
    public DataTable Buscar_Cotizcion(string doc)
    {
        string sql = "SELECT * FROM Cotizaciones WHERE numeroCotizacion =" + doc;
        DataTable tabla = new DataTable();
        tabla = _BD.Consulta(sql);
        return tabla;
    }

    //AGREGAR BIEN LOS DATOS FALTANTES A LA MODIFICACION Y BORRADO

    public void Modificar(Es_Cotizaciones datos)
    {
        string sqlUpdate = "UPDATE Cotizaciones SET ";
        sqlUpdate += " año = " + _BD.FormatearDato(datos.año, "Int");
        sqlUpdate += ", cuitCliente = " + _BD.FormatearDato(datos.cuitCliente, "String");
        sqlUpdate += ", tipoDocVendedor = " + _BD.FormatearDato(datos.tipoDocVendedor, "Int");
        sqlUpdate += ", numDocVendedor = " + _BD.FormatearDato(datos.numDocVendedor, "Int");
        sqlUpdate += ", codEstadoCotizacion = " + _BD.FormatearDato(datos.codEstadoCotizacion, "Int");
        sqlUpdate += ", nombreSolicitante = " + _BD.FormatearDato(datos.nombreSolicitante, "String");
        sqlUpdate += ", apellidoSolicitante = " + _BD.FormatearDato(datos.apellidoSolicitante, "String");
        sqlUpdate += ", fecha = " + _BD.FormatearDato(datos.fecha, "String");
        sqlUpdate += ", observaciones = " + _BD.FormatearDato(datos.observaciones, "String");
        sqlUpdate += ", precioTotal = " + _BD.FormatearDato(datos.precioTotal, "Int");
        sqlUpdate += ", motivoPerdida = " + _BD.FormatearDato(datos.motivoPerdida, "String");
        sqlUpdate += ", nomCompetidor = " + _BD.FormatearDato(datos.nomCompetidor, "String");
        sqlUpdate += " WHERE numeroCotizacion = " + datos.numeroCotizacicon;
        MessageBox.Show("La cotizacion fue modificada con exito!", "MODIFICACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        _BD.Modificar(sqlUpdate);

    }
    public void Borrar(string Doc)
    {
        string sqlDelete = "DELETE FROM Cotizaciones WHERE numeroCotizacion = " + Doc;
        MessageBox.Show("La cotizacion fue eliminada con exito!", "ELIMINACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        _BD.Borrar(sqlDelete);
    }
    public EstructuraComboBox EstructuraCombo()
    {
        EstructuraComboBox EC = new EstructuraComboBox();
        EC.Display = "numeroCotizacion";
        EC.Value = "numeroCotizacion";
        EC.Sql = "SELECT * FROM Cotizaciones";
        EC.Tabla = _BD.Consulta(EC.Sql);
        return EC;
    }

    public String TraerMes(string doc)
    {
        string sql = "SELECT MONTH(fecha) FROM Cotizaciones WHERE numeroCotizacion =" + doc;
        DataTable tabla = new DataTable();
        tabla = _BD.Consulta(sql);
        return tabla.Rows[0][0].ToString();
    }

    public String TraerDia(string doc)
    {
        string sql = "SELECT DAY(fecha) FROM Cotizaciones WHERE numeroCotizacion =" + doc;
        DataTable tabla = new DataTable();
        tabla = _BD.Consulta(sql);
        return tabla.Rows[0][0].ToString();
    }

    public void IniciarTransaccion()
    {
        _BD.IniciarTransaccion();
    }
    public void CerrarTransaccion()
    {
        _BD.CerrarTransaccion();
    }
}


