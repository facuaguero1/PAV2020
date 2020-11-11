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
    public partial class Pedido_X_2Fechas : Form
    {
        Ng_Pedidos Pedidos = new Ng_Pedidos();

        public Pedido_X_2Fechas()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private DataTable Buscar_X_Fecha ()
        {
            DataTable tabla = new DataTable();
            if (txt_fechaDesde.PP_MaskFull == true && txt_fechaHasta.PP_MaskFull == true)
            {
                tabla = Pedidos.Buscar_X_Fecha(txt_fechaDesde.PP_Text, txt_fechaHasta.PP_Text);
            }
            else
            {
                if (txt_fechaDesde.PP_MaskFull == false && txt_fechaHasta.PP_MaskFull == false)
                {
                    MessageBox.Show("ERROR!! No selecciono ninguna fecha de busqueda", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (txt_fechaDesde.PP_MaskFull == false)
                    {
                        MessageBox.Show("ERROR!! No selecciono la fecha inicial de busqueda", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (txt_fechaHasta.PP_MaskFull == false)
                        {
                            MessageBox.Show("ERROR!! No selecciono la fecha final de busqueda", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            return tabla;
        }
        private void CargarInforme (DataTable tabla)
        {
            if (tabla.Rows.Count == 0 )
            {
            }
            else
            {
                ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
                rv_listadoPedido_x_fecha.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Reportes.Pedido_Entre_Fechas.ReportePedidoXFecha.rdlc";
                ReportParameter[] parametros = new ReportParameter[3];

                parametros[0] = new ReportParameter("RP01", "Fecha Desde: " + txt_fechaDesde.PP_Text);
                parametros[1] = new ReportParameter("RP02", "Fecha Hasta: " + txt_fechaHasta.PP_Text);
                parametros[2] = new ReportParameter("RP03", DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString());

                rv_listadoPedido_x_fecha.LocalReport.DataSources.Clear();
                rv_listadoPedido_x_fecha.LocalReport.SetParameters(parametros);
                rv_listadoPedido_x_fecha.LocalReport.DataSources.Add(Datos);
                rv_listadoPedido_x_fecha.RefreshReport();
            }
            
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = Buscar_X_Fecha();
            CargarInforme(tabla);
        }
    }
}
