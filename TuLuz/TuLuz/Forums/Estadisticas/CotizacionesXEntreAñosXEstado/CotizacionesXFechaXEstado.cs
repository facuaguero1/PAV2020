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

namespace TuLuz.Forums.Estadisticas.Pedidos_Entre_Años
{
    public partial class CotizacionesXFechaXEstado : Form
    {
        Ng_Cotizaciones Cotizacion = new Ng_Cotizaciones();
        Ng_EstadosCotizaciones Estado = new Ng_EstadosCotizaciones();

        public CotizacionesXFechaXEstado()
        {
            InitializeComponent();
        }
        private DataTable Buscar_X_Fecha()
        {
            DataTable tabla = new DataTable();
            if (LblText_Desde.PP_MaskFull == true && LblTxt_FechaHasta.PP_MaskFull == true)
            {
                tabla = Cotizacion.Buscar_X_Fecha(LblText_Desde.PP_Text, LblTxt_FechaHasta.PP_Text, cmb_Estado.SelectedValue.ToString());
            }
            else
            {
                if (LblText_Desde.PP_MaskFull == false && LblTxt_FechaHasta.PP_MaskFull == false)
                {
                    MessageBox.Show("ERROR!! No selecciono ninguna fecha de busqueda", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (LblText_Desde.PP_MaskFull == false)
                    {
                        MessageBox.Show("ERROR!! No selecciono la fecha inicial de busqueda", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (LblTxt_FechaHasta.PP_MaskFull == false)
                        {
                            MessageBox.Show("ERROR!! No selecciono la fecha final de busqueda", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            return tabla;

        }
        private void CargarInforme(DataTable tabla)
        {
            if (tabla.Rows.Count == 0)
            {
            }
            else
            {
                DataTable tabla2 = new DataTable();
                tabla2 = Cotizacion.Contar_Cotizaciones_X_Año(LblText_Desde.PP_Text , LblTxt_FechaHasta.PP_Text, cmb_Estado.SelectedValue.ToString());
                Be_BaseDatos _BD = new Be_BaseDatos();
                ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
                ReportDataSource Datos1 = new ReportDataSource("DataSet2", tabla2);
                rv_Cotizaciones_fechas.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Estadisticas.CotizacionesXEntreAñosXEstado.rpv_CotizacionesXFechaYEstado.rdlc";
                ReportParameter[] parametros = new ReportParameter[2];
                parametros[0] = new ReportParameter("RP01", "Grafico sobre las Cotizaciones entre: " + LblText_Desde.PP_Text + " hasta: " + LblTxt_FechaHasta.PP_Text+" y en estado: "+ cmb_Estado.Text);
                parametros[1] = new ReportParameter("RP02", "Fecha: " + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString());
                rv_Cotizaciones_fechas.LocalReport.DataSources.Clear();
                rv_Cotizaciones_fechas.LocalReport.SetParameters(parametros);
                rv_Cotizaciones_fechas.LocalReport.DataSources.Add(Datos);
                rv_Cotizaciones_fechas.LocalReport.DataSources.Add(Datos1);
                rv_Cotizaciones_fechas.RefreshReport();
            }

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = Buscar_X_Fecha();
            CargarInforme(tabla);
        }
        private void CotizacionesXFechaXEstado_Load(object sender, EventArgs e)
        {
            cmb_Estado.Cargar(Estado.EstructuraCombo());
        }
    }
}
