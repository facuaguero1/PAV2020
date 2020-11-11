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


namespace TuLuz.Forums.Reportes.CotizacionesXEstado
{
    public partial class CotizacionesXEstado : Form
    {
        Ng_EstadosCotizaciones Estados = new Ng_EstadosCotizaciones();
        Ng_Cotizaciones Cotizaciones = new Ng_Cotizaciones();
        public CotizacionesXEstado()
        {
            InitializeComponent();
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CotizacionesXEstado_Load(object sender, EventArgs e)
        {
            cmb_Estados.Cargar(Estados.EstructuraComboxListado());
            cmb_Estados.SelectedIndex = -1;
        }
        private void cmb_Estados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Estados.SelectedIndex == -1)
            {
                cmb_Estados.Text = "Seleccionar.";
            }
        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {

            if (cmb_Estados.SelectedIndex == -1)
            {
                MessageBox.Show("No se selecciono ningun estado", "ATENCION");
            }
            else
            {
                DataTable tabla = new DataTable();
                tabla = Cotizaciones.Buscar_CotizacionPorEstado(cmb_Estados.SelectedValue.ToString());
                ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
                RVCotizacionesXEstados.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Reportes.CotizacionesXEstado.ReporteCotizacionesXEstado.rdlc";
                ReportParameter[] parametros = new ReportParameter[2];
                parametros[0] = new ReportParameter("RP01", "Estado: " + cmb_Estados.SelectedValue.ToString());
                parametros[1] = new ReportParameter("RP02", "Fecha: " + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString());
                RVCotizacionesXEstados.LocalReport.DataSources.Clear();
                RVCotizacionesXEstados.LocalReport.SetParameters(parametros);
                RVCotizacionesXEstados.LocalReport.DataSources.Add(Datos);
                RVCotizacionesXEstados.RefreshReport();

            }
        }
    }
}
