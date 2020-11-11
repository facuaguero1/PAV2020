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
    public partial class CotizacionesXEmpleados : Form
    {
        Ng_Cotizaciones Cotizaciones = new Ng_Cotizaciones();
        Ng_Empleados Empleados = new Ng_Empleados();
        public CotizacionesXEmpleados()
        {
            InitializeComponent();
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CotizacionesXEmpleados_Load(object sender, EventArgs e)
        {
            cmb_Empleados.Cargar(Empleados.EstructuraComboxListado());
            cmb_Empleados.SelectedIndex = -1;
            this.RVCotizacionesXEmpleados.RefreshReport();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (cmb_Empleados.SelectedIndex == -1)
            {
                MessageBox.Show("No se selecciono ningun empleado", "ATENCION");
            }
            else
            {
                DataTable tabla = new DataTable();
                tabla = Cotizaciones.Buscar_CotizacionPorEmpleado(cmb_Empleados.SelectedValue.ToString());
                ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
                RVCotizacionesXEmpleados.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Reportes.CotizacionesXEmpleado.reporteCotizacionesXEmpleado.rdlc";
                ReportParameter[] parametros = new ReportParameter[2];
                parametros[0] = new ReportParameter("RP01", "Empleado: " + cmb_Empleados.SelectedValue.ToString());
                parametros[1] = new ReportParameter("RP02", "Fecha: " + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString());
                RVCotizacionesXEmpleados.LocalReport.DataSources.Clear();
                RVCotizacionesXEmpleados.LocalReport.SetParameters(parametros);
                RVCotizacionesXEmpleados.LocalReport.DataSources.Add(Datos);
                RVCotizacionesXEmpleados.RefreshReport();

            }
        }
        private void cmb_Empleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Empleados.SelectedIndex == -1)
            {
                cmb_Empleados.Text = "Seleccionar.";
            }
        }
    }
}       

