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

namespace TuLuz.Forums.Estadisticas.Proveedores_Activos_NoActivos
{
    public partial class Estadistica_Proveedores_Ac_NoAc : Form
    {
        DataTable tabla = new DataTable();
        Ng_Proveedor proveedores = new Ng_Proveedor();
        public Estadistica_Proveedores_Ac_NoAc()
        {
            InitializeComponent();
        }

        private void Estadistica_Proveedores_Ac_NoAc_Load(object sender, EventArgs e)
        {

            this.RV_Proveedores_AC_NAC.RefreshReport();
        }

        private void CalcularEstadistica()
        {
            DataTable tabla2 = new DataTable();
            tabla = proveedores.Todos_los_proveedores();
            tabla2 = proveedores.ContarProveedoresAcNoAc();
            Be_BaseDatos _BD = new Be_BaseDatos();
            ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
            ReportDataSource Datos1 = new ReportDataSource("DataSet2", tabla2);
            RV_Proveedores_AC_NAC.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Estadisticas.Proveedores_Activos_NoActivos.Rv_Proveedores_Ac_NoAc.rdlc";
            ReportParameter[] parametros = new ReportParameter[2];
            parametros[0] = new ReportParameter("RP01", "Grafico sobre los proveedores activos y no activos");
            parametros[1] = new ReportParameter("RP02", "Fecha: " + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString());
            //parametros[2] = new ReportParameter("RP03", Activos().ToString());
            RV_Proveedores_AC_NAC.LocalReport.DataSources.Clear();
            RV_Proveedores_AC_NAC.LocalReport.SetParameters(parametros);
            RV_Proveedores_AC_NAC.LocalReport.DataSources.Add(Datos);
            RV_Proveedores_AC_NAC.LocalReport.DataSources.Add(Datos1);
            RV_Proveedores_AC_NAC.RefreshReport();

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            CalcularEstadistica();
        }
    }
}
