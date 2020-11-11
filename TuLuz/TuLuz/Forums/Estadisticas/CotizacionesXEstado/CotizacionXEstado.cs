using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuLuz.Negocio;
using TuLuz.Clases;
using TuLuz.Negocio.EstructuraNegocios;
using Microsoft.Reporting.WinForms;

namespace TuLuz.Forums
{
    public partial class CotizacionXEstado: Form
    {
        Ng_Cotizaciones Cotizacion = new Ng_Cotizaciones();
        
        public CotizacionXEstado()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            DataTable tabla2 = new DataTable();
            tabla = Cotizacion.Todas_Las_Cotizciones();
            tabla2 = Cotizacion.ContarCotizacionesXEstado();
            Be_BaseDatos _BD = new Be_BaseDatos();
            ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
            ReportDataSource Datos1 = new ReportDataSource("DataSet2", tabla2);
            rpv_CotizacionXEstado.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Estadisticas.CotizacionesXEstado.Rp_CotizacionesXEstado.rdlc";
            ReportParameter[] parametros = new ReportParameter[2];
            parametros[0] = new ReportParameter("RP01", "Grafico sobre los estado de las cotizaciones");
            parametros[1] = new ReportParameter("RP02", "Fecha: " + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString());
            rpv_CotizacionXEstado.LocalReport.DataSources.Clear();
            rpv_CotizacionXEstado.LocalReport.SetParameters(parametros);
            rpv_CotizacionXEstado.LocalReport.DataSources.Add(Datos);
            rpv_CotizacionXEstado.LocalReport.DataSources.Add(Datos1);
            rpv_CotizacionXEstado.RefreshReport();
        }
    }
}
