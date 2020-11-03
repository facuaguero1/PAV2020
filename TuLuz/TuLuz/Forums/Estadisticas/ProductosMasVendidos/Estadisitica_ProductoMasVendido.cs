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

namespace TuLuz.Forums.Estadisticas.VentasXMes
{
    public partial class  Estadistica_ProductoMasVendido: Form
    {
        DataTable tabla = new DataTable();

        Ng_DetallePedidos Detalle = new Ng_DetallePedidos();

        public Estadistica_ProductoMasVendido()
        {
            InitializeComponent();
            lblHasta.Enabled = false;
            lbl_Desde.Enabled = false;
        }

        private void Estadistica_VentaXMes_Load(object sender, EventArgs e)
        {

            this.rv_productoMasVendido.RefreshReport();
        }

        private void CalcularEstadistica_VentasXMes()
        {
            if (chk_filtro.Checked == true)
            {
                DataTable tabla2 = new DataTable();
                tabla2 = Detalle.ContarProductosMasVendidosXFecha(lbl_Desde.PP_Text,lblHasta.PP_Text);
                tabla = Detalle.TodosLosPedidosXProductoXFecha(lbl_Desde.PP_Text, lblHasta.PP_Text);
                Be_BaseDatos _BD = new Be_BaseDatos();
                ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
                ReportDataSource Datos1 = new ReportDataSource("DataSet2", tabla2);
                rv_productoMasVendido.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Estadisticas.ProductosMasVendidos.rp_ProductosMasVendidos.rdlc";
                ReportParameter[] parametros = new ReportParameter[2];
                parametros[0] = new ReportParameter("RP01", "Grafico sobre los productos mas vendidos entre la fecha: "+ lbl_Desde.PP_Text+" y: "+ lblHasta.PP_Text);
                parametros[1] = new ReportParameter("RP02", "Fecha: " + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString());
                rv_productoMasVendido.LocalReport.DataSources.Clear();
                rv_productoMasVendido.LocalReport.SetParameters(parametros);
                rv_productoMasVendido.LocalReport.DataSources.Add(Datos);
                rv_productoMasVendido.LocalReport.DataSources.Add(Datos1);
                rv_productoMasVendido.RefreshReport();
            }
            else
            {
                DataTable tabla2 = new DataTable();
                tabla2 = Detalle.ContarProductosMasVendidos();
                tabla = Detalle.TodosLosPedidosXProducto();
                Be_BaseDatos _BD = new Be_BaseDatos();
                ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
                ReportDataSource Datos1 = new ReportDataSource("DataSet2", tabla2);
                rv_productoMasVendido.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Estadisticas.ProductosMasVendidos.rp_ProductosMasVendidos.rdlc";
                ReportParameter[] parametros = new ReportParameter[2];
                parametros[0] = new ReportParameter("RP01", "Grafico sobre los Productos mas vendidos");
                parametros[1] = new ReportParameter("RP02", "Fecha: " + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString());
                rv_productoMasVendido.LocalReport.DataSources.Clear();
                rv_productoMasVendido.LocalReport.SetParameters(parametros);
                rv_productoMasVendido.LocalReport.DataSources.Add(Datos);
                rv_productoMasVendido.LocalReport.DataSources.Add(Datos1);
                rv_productoMasVendido.RefreshReport();

            }

            }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            CalcularEstadistica_VentasXMes();
        }

        private void chk_filtro_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_filtro.Checked == true)
            {       
            lblHasta.Enabled = true;
            lbl_Desde.Enabled = true;
            }
            else
            {
                lblHasta.Enabled = false;
                lbl_Desde.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
