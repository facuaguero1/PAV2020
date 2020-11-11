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
    public partial class ProductoEquivalente : Form
    {
        Ng_Producto Producto = new Ng_Producto();
        
        public ProductoEquivalente()
        {
            InitializeComponent();
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = Producto.Buscar_Producto_EQ_PorCodigo(cmb_producto.SelectedValue.ToString());


            ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
            RV_producto_Eq.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Reportes.Producto_Equivalente.Reporte_Producto_Equivalente.rdlc";
            ReportParameter[] parametros = new ReportParameter[2];
            parametros[0] = new ReportParameter("RP01", cmb_producto.Text.ToString());
            parametros[1] = new ReportParameter("RP02", DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString());
            RV_producto_Eq.LocalReport.DataSources.Clear();
            RV_producto_Eq.LocalReport.SetParameters(parametros);
            RV_producto_Eq.LocalReport.DataSources.Add(Datos);
            RV_producto_Eq.RefreshReport();
        }

        private void cmb_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_producto.SelectedIndex == -1)
            {
                cmb_producto.Text = "Seleccionar...";
            }
        }

        private void ProductoEquivalente_Load(object sender, EventArgs e)
        {
            cmb_producto.Cargar(Producto.EstructuraCombo());
            cmb_producto.SelectedIndex = -1;
        }
    }
}
