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

namespace TuLuz.Forums.Estadisticas.Cantidades_Jefes_Empleados
{
    public partial class Estadistica_Cantidades_Jefes_Empleados : Form
    {
        Ng_Empleados empleados = new Ng_Empleados();
        public Estadistica_Cantidades_Jefes_Empleados()
        {
            InitializeComponent();
        }

        private void Estadistica_Cantidades_Jefes_Empleados_Load(object sender, EventArgs e)
        {

            this.RV_Cantidades_Jefes_Empleados.RefreshReport();
        }

        private void CalcularEstadistica()
        {

            DataTable tabla = new DataTable();
            DataTable tabla2 = new DataTable();
            tabla = empleados.Todos_los_Jefes_Y_Empleados();
            tabla2 = empleados.ContarJefesYEmpleados();
            Be_BaseDatos _BD = new Be_BaseDatos();
            ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
            ReportDataSource Datos1 = new ReportDataSource("DataSet2", tabla2);
            RV_Cantidades_Jefes_Empleados.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Estadisticas.Cantidades_Jefes_Empleados.Rv_Cantidades_Jefes_Empleados.rdlc";
            ReportParameter[] parametros = new ReportParameter[2];
            parametros[0] = new ReportParameter("RP01", "Grafico sobre las cantidades de jefes y de empleados");
            parametros[1] = new ReportParameter("RP02", "Fecha: " + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString());
            RV_Cantidades_Jefes_Empleados.LocalReport.DataSources.Clear();
            RV_Cantidades_Jefes_Empleados.LocalReport.SetParameters(parametros);
            RV_Cantidades_Jefes_Empleados.LocalReport.DataSources.Add(Datos);
            RV_Cantidades_Jefes_Empleados.LocalReport.DataSources.Add(Datos1);
            RV_Cantidades_Jefes_Empleados.RefreshReport();

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            CalcularEstadistica();
        }
    }
}
