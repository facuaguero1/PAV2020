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

namespace TuLuz.Forums.Reportes.Proveedores_Activos_Inactivos
{
    public partial class Proveedores_Activos_Inactivos : Form
    {
        Ng_Proveedor Proveedor = new Ng_Proveedor();

        public Proveedores_Activos_Inactivos()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click_1(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            string estado = "";

            //Verificar si estan o no activos

            if (checkBoxActivo.Checked == true)
            {
                if (checkBoxNoActivo.Checked == true)
                {
                    tabla = Proveedor.Todos_los_proveedores();
                    estado = "Activos y No Activos";
                    
                }
                else
                {
                    tabla = Proveedor.Todos_los_proveedoresActivos();
                    estado = "Activos";
                }
            }

            if (checkBoxNoActivo.Checked == true)
            {
                if (checkBoxActivo.Checked == false)
                {
                    tabla = Proveedor.Todos_los_proveedoresNoActivos();
                    estado = "No Activos";
                }
            }

            ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
            rv_Proveedores_Activos_NoActivos.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Reportes.Proveedores_Activos_Inactivos.Proveedores_Activos_Inactivos.rdlc";
            ReportParameter[] parametros = new ReportParameter[2];
            parametros[0] = new ReportParameter("RP01", "Estado: " + estado);
            parametros[1] = new ReportParameter("RP02", "Fecha: " + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString());
            rv_Proveedores_Activos_NoActivos.LocalReport.DataSources.Clear();
            rv_Proveedores_Activos_NoActivos.LocalReport.SetParameters(parametros);
            rv_Proveedores_Activos_NoActivos.LocalReport.DataSources.Add(Datos);
            rv_Proveedores_Activos_NoActivos.RefreshReport();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
