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
    public partial class Pedidos_Entre_Años : Form
    {
        DataTable tabla = new DataTable();
        Ng_Pedidos pedidos = new Ng_Pedidos();
        public Pedidos_Entre_Años()
        {
            InitializeComponent();
        }

        private void Pedidos_Entre_Años_Load(object sender, EventArgs e)
        {

        }
        private DataTable Buscar_X_Fecha()
        {
            DataTable tabla = new DataTable();
            if (LblText_Desde.PP_MaskFull == true && LblTxt_FechaHasta.PP_MaskFull == true)
            {
                tabla = pedidos.Buscar_X_Fecha(LblText_Desde.PP_Text, LblTxt_FechaHasta.PP_Text);
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
                tabla2 = pedidos.Contar_Pedido_x_Año(LblText_Desde.PP_Text , LblTxt_FechaHasta.PP_Text);
                Be_BaseDatos _BD = new Be_BaseDatos();
                ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
                ReportDataSource Datos1 = new ReportDataSource("DataSet2", tabla2);
                rv_pedido_fechas.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Estadisticas.Pedidos_Entre_Años.Rv_Pedidos_Fechas.rdlc";
                ReportParameter[] parametros = new ReportParameter[2];
                parametros[0] = new ReportParameter("RP01", "Grafico sobre los pedidos entre: " + LblText_Desde.PP_Text + " hasta: " + LblTxt_FechaHasta.PP_Text);
                parametros[1] = new ReportParameter("RP02", "Fecha: " + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString());
                rv_pedido_fechas.LocalReport.DataSources.Clear();
                rv_pedido_fechas.LocalReport.SetParameters(parametros);
                rv_pedido_fechas.LocalReport.DataSources.Add(Datos);
                rv_pedido_fechas.LocalReport.DataSources.Add(Datos1);
                rv_pedido_fechas.RefreshReport();
            }

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = Buscar_X_Fecha();
            CargarInforme(tabla);
        }
    }
}
