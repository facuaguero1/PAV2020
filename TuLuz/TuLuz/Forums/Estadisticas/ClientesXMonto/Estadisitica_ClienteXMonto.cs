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
    public partial class  Estadistica_ClienteXMonto: Form
    {
        DataTable tabla = new DataTable();

        Ng_Pedidos Pedidos = new Ng_Pedidos();

        public Estadistica_ClienteXMonto()
        {
            InitializeComponent();
        }
        private void CalcularEstadistica_VentasXMes()
        {
            
                DataTable tabla2 = new DataTable();
            tabla2 = Pedidos.ContarClientesXPedidosEntreMonto(lbl_Desde.Text, lbl_Hasta.Text);
                tabla = Pedidos.ClientesXPedidosEntreMonto(lbl_Desde.Text, lbl_Hasta.Text);
                Be_BaseDatos _BD = new Be_BaseDatos();
                ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
                ReportDataSource Datos1 = new ReportDataSource("DataSet2", tabla2);
                rv_ClienteXMonto.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Estadisticas.ClientesXMonto.rp_ClientesXMonto.rdlc";
                ReportParameter[] parametros = new ReportParameter[2];
                parametros[0] = new ReportParameter("RP01", "Grafico sobre los Clientes con pedidos con monto entre: "+ lbl_Desde.Text + " y: "+ lbl_Hasta.Text);
                parametros[1] = new ReportParameter("RP02", "Fecha: " + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString());
                rv_ClienteXMonto.LocalReport.DataSources.Clear();
                rv_ClienteXMonto.LocalReport.SetParameters(parametros);
                rv_ClienteXMonto.LocalReport.DataSources.Add(Datos);
                rv_ClienteXMonto.LocalReport.DataSources.Add(Datos1);
                rv_ClienteXMonto.RefreshReport();
          
            }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            CalcularEstadistica_VentasXMes();
        }
    }

}
