using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TuLuz.Clases;
using TuLuz.Negocio.EstructuraNegocios;
using System.Windows.Forms;

namespace TuLuz.Negocio
{
    class Ng_EstadosCotizaciones
    {
        Be_BaseDatos _BD = new Be_BaseDatos();
        public EstructuraComboBox EstructuraCombo()
        {
            EstructuraComboBox EC = new EstructuraComboBox();
            EC.Display = "descripcion";
            EC.Value = "codEstado";
            EC.Sql = "SELECT * FROM EstadosCotizaciones";
            EC.Tabla = _BD.Consulta(EC.Sql);
            return EC;
        }
        public EstructuraComboBox EstructuraComboxListado()
        {
            EstructuraComboBox EC = new EstructuraComboBox();
            EC.Display = "descripcion";
            EC.Value = "codEstado";
            EC.Sql = "SELECT * FROM EstadosCotizaciones";
            EC.Tabla = _BD.Consulta(EC.Sql);
            return EC;
        }
    }
}

