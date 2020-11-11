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
    public partial class Pedidos_Entre_Años_Y_PrecioMin : Form
    {
        Ng_Pedidos pedidos = new Ng_Pedidos();
        public Pedidos_Entre_Años_Y_PrecioMin()
        {
            InitializeComponent();
        }
        private void CargarInforme(DataTable tabla)
        {
            if (tabla.Rows.Count == 0)
            {
            }
            else
            {
                Be_BaseDatos _BD = new Be_BaseDatos();
                ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
                rv_pedido_fechas_y_precio.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Estadisticas.ComprasXValor_EntreFechas.RpComprasXValor_EntreFechasrdlc.rdlc";
                ReportParameter[] parametros = new ReportParameter[2];
                parametros[0] = new ReportParameter("RP01", Precio_Min.Text);
                parametros[1] = new ReportParameter("RP02", "Fecha: " + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString());
                rv_pedido_fechas_y_precio.LocalReport.DataSources.Clear();
                rv_pedido_fechas_y_precio.LocalReport.SetParameters(parametros);
                rv_pedido_fechas_y_precio.LocalReport.DataSources.Add(Datos);
                rv_pedido_fechas_y_precio.RefreshReport();
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = pedidos.PedidosXValor_EntreFechas(LblText_Desde.PP_Text,LblTxt_FechaHasta.PP_Text,int.Parse(Precio_Min.Text));
            CargarInforme(tabla);
        }
    }
}
