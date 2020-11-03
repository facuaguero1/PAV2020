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

namespace TuLuz.Forums.Estadisticas.VendedoresXCotizaciones
{
    public partial class Estadistica_VendedoresXCotizaciones : Form
    {
        DataTable tabla = new DataTable();

        Ng_Cotizaciones cotizaciones = new Ng_Cotizaciones();

        public Estadistica_VendedoresXCotizaciones()
        {
            InitializeComponent();
        }

        private void Estadistica_VendedoresXCotizaciones_Load(object sender, EventArgs e)
        {

            this.rv_VendedoresXCotizaciones.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void CalcularEstadistica_VendedoresXCotizaciones()
        {
            DataTable tabla2 = new DataTable();
            tabla2 = cotizaciones.ContarCotizaciones_X_Vendedores();
            tabla = cotizaciones.Cotizaciones_X_Vendedores();
            Be_BaseDatos _BD = new Be_BaseDatos();
            ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
            ReportDataSource Datos1 = new ReportDataSource("DataSet2", tabla2);
            rv_VendedoresXCotizaciones.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Estadisticas.VendedoresXCotizaciones.Rv_VendedoresXCotizaciones.rdlc";
            ReportParameter[] parametros = new ReportParameter[2];
            parametros[0] = new ReportParameter("RP01", "Grafico sobre los vendedores por cotizaciones ganadas");
            parametros[1] = new ReportParameter("RP02", "Fecha: " + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString());

            rv_VendedoresXCotizaciones.LocalReport.DataSources.Clear();
            rv_VendedoresXCotizaciones.LocalReport.SetParameters(parametros);
            rv_VendedoresXCotizaciones.LocalReport.DataSources.Add(Datos);
            rv_VendedoresXCotizaciones.LocalReport.DataSources.Add(Datos1);
            rv_VendedoresXCotizaciones.RefreshReport();

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            CalcularEstadistica_VendedoresXCotizaciones();
        }
    }
}
