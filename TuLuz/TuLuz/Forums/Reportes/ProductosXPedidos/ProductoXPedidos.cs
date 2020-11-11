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
    public partial class ProductoXPedidos : Form
    {
        Ng_Pedidos Pedidos = new Ng_Pedidos();
        Ng_DetallePedidos Detalle = new Ng_DetallePedidos();

        public ProductoXPedidos()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmb_Pedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Pedidos.SelectedIndex == -1)
            {
                cmb_Pedidos.Text = "Seleccionar...";
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                cmb_Pedidos.Enabled = false;
            }
            else
            {
                cmb_Pedidos.Enabled = true;
            }
        }
 
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                DataTable tabla = new DataTable();
                tabla = Detalle.TodosLosPedidosXProducto();
                ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
                ProdcutXPedidos.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Reportes.ProductosXPedidos.ReporteProductoXPedidos.rdlc";
                ReportParameter[] parametros = new ReportParameter[2];
                parametros[0] = new ReportParameter("RP01", "Pedido: Todos");
                parametros[1] = new ReportParameter("RP02", "Fecha: " + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString());
                ProdcutXPedidos.LocalReport.DataSources.Clear();
                ProdcutXPedidos.LocalReport.SetParameters(parametros);
                ProdcutXPedidos.LocalReport.DataSources.Add(Datos);
                ProdcutXPedidos.RefreshReport();

            }
            else
            {
                if (cmb_Pedidos.SelectedIndex == -1)
                {
                    MessageBox.Show("No se selecciono ningun empleado", "ATENCION");
                }
                else
                {
                    DataTable tabla = new DataTable();
                    tabla = Detalle.PedidosXProducto(cmb_Pedidos.SelectedValue.ToString());
                    ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
                    ProdcutXPedidos.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Reportes.ProductosXPedidos.ReporteProductoXPedidos.rdlc";
                    ReportParameter[] parametros = new ReportParameter[2];
                    parametros[0] = new ReportParameter("RP01", "Pedido: " + cmb_Pedidos.SelectedValue.ToString());
                    parametros[1] = new ReportParameter("RP02", "Fecha: " + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString());
                    ProdcutXPedidos.LocalReport.DataSources.Clear();
                    ProdcutXPedidos.LocalReport.SetParameters(parametros);
                    ProdcutXPedidos.LocalReport.DataSources.Add(Datos);
                    ProdcutXPedidos.RefreshReport();

                }
            }
        }

        private void ProductoXPedidos_Load(object sender, EventArgs e)
        {
            cmb_Pedidos.Cargar(Pedidos.EstructuraCombo());
            cmb_Pedidos.SelectedIndex = -1;
        }
    }
}
