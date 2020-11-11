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
    public partial class ProductoXrangoPrecio : Form
    {
        Ng_Producto producto = new Ng_Producto();
      
        public ProductoXrangoPrecio()
        {
            InitializeComponent();
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = producto.BuscarProductoXprecio(txt_pracioMin.Text, txt_precioMax.Text);


            ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
            RVproductoXprecio.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Reportes.Productos_rango_precios.Report1.rdlc";
            ReportParameter[] parametros = new ReportParameter[3];
            parametros[0] = new ReportParameter("RP01", " Precio Minimo: " + txt_pracioMin.Text);
            parametros[1] = new ReportParameter("RP02", " Precio Maximo: " + txt_precioMax.Text);
            parametros[2] = new ReportParameter("RP03", "Fecha: " + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString());
            RVproductoXprecio.LocalReport.DataSources.Clear();
            RVproductoXprecio.LocalReport.SetParameters(parametros);
            RVproductoXprecio.LocalReport.DataSources.Add(Datos);
            RVproductoXprecio.RefreshReport();
        }

        private void txt_pracioMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_precioMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ProductoXrangoPrecio_Load(object sender, EventArgs e)
        {

        }
    }
}

