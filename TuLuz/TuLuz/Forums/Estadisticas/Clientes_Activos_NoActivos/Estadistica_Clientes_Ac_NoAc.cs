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

namespace TuLuz.Forums._Estadisticas.Prod_con_ProdEq
{
    public partial class Estadistica_Clientes_Ac_NoAc : Form
    {
        DataTable tabla = new DataTable();
        Ng_Clientes clientes = new Ng_Clientes();
        public Estadistica_Clientes_Ac_NoAc()
        {
            InitializeComponent();
        }

        private void Estadistica_Prod_ProdEq_Load(object sender, EventArgs e)
        {

            this.RV_Clientes_AC_NAC.RefreshReport();
        }
        private void CalcularEstadistica()
        {
            DataTable tabla2 = new DataTable();
            tabla = clientes.Todos_los_Clientes();
            tabla2 = clientes.ContarClientesAcNoAc();
            Be_BaseDatos _BD = new Be_BaseDatos();
            ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
            ReportDataSource Datos1 = new ReportDataSource("DataSet2", tabla2);
            RV_Clientes_AC_NAC.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Estadisticas.Clientes_Activos_NoActivos.Rv_Clientes_Ac_NoAc.rdlc";
            ReportParameter[] parametros = new ReportParameter[2];
            parametros[0] = new ReportParameter("RP01", "Grafico sobre los clientes activos y no activos");
            parametros[1] = new ReportParameter("RP02", "Fecha: " + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString());
            //parametros[2] = new ReportParameter("RP03", Activos().ToString());
            RV_Clientes_AC_NAC.LocalReport.DataSources.Clear();
            RV_Clientes_AC_NAC.LocalReport.SetParameters(parametros);
            RV_Clientes_AC_NAC.LocalReport.DataSources.Add(Datos);
            RV_Clientes_AC_NAC.LocalReport.DataSources.Add(Datos1);
            RV_Clientes_AC_NAC.RefreshReport();

        }

        //private double Activos()
        //{
        //    DataTable tablaAC = new DataTable();

        //    tablaAC = clientes.Todos_los_ClientesActivos();
        //    return tablaAC.Rows.Count;
            
        //}
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            CalcularEstadistica();
        }
    }
}
