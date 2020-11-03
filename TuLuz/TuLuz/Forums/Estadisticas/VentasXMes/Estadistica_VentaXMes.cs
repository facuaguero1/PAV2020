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
    public partial class Estadistica_VentaXMes : Form
    {
        DataTable tabla = new DataTable();

        Ng_Pedidos pedidos = new Ng_Pedidos();

        public Estadistica_VentaXMes()
        {
            InitializeComponent();
        }

        private void Estadistica_VentaXMes_Load(object sender, EventArgs e)
        {

            this.rv_VentasXMes.RefreshReport();
        }

        private void CalcularEstadistica_VentasXMes()
        {
            DataTable tabla2 = new DataTable();
            tabla = pedidos.VentasXProductos(txt_CodProducto.Text);
            tabla2 = pedidos.ContarVentasXProductos(txt_CodProducto.Text);
            Be_BaseDatos _BD = new Be_BaseDatos();
            ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
            ReportDataSource Datos1 = new ReportDataSource("DataSet2", tabla2);
            rv_VentasXMes.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Estadisticas.VentasXMes.Rv_VentasXMes.rdlc";
            ReportParameter[] parametros = new ReportParameter[2];
            parametros[0] = new ReportParameter("RP01", "Grafico sobre las ventas de un producto por mes");
            parametros[1] = new ReportParameter("RP02", "Fecha: " + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString());
            rv_VentasXMes.LocalReport.DataSources.Clear();
            rv_VentasXMes.LocalReport.SetParameters(parametros);
            rv_VentasXMes.LocalReport.DataSources.Add(Datos);
            rv_VentasXMes.LocalReport.DataSources.Add(Datos1);
            rv_VentasXMes.RefreshReport();

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            CalcularEstadistica_VentasXMes();
        }

        private void txt_CodProducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
