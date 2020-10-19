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

namespace TuLuz.Forums.Reportes.Empleados_Jefes
{
    public partial class Empleados_Jefes : Form
    {
        Ng_Empleados Empleados = new Ng_Empleados();
        DataTable Tabla = new DataTable();

        public Empleados_Jefes()
        {
            InitializeComponent();
        }

        private void Empleados_Jefes_Load(object sender, EventArgs e)
        {

            this.rv_listadoEmpleados_Jefes.RefreshReport();
            this.rv_listadoEmpleados_Jefes.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        //private DataTable Todos_los_Empleados()
        private DataTable EsJefeS()
        {
            {
                //Tabla = Empleados.Todos_los_Empleados();
                Tabla = Empleados.EsJefeS(txt_tipoDoc.Text,txt_numDoc.Text);
            }
            return Tabla;
        }

        private void CargarInforme(DataTable Tabla)
        {
            if (Tabla.Rows.Count == 0)
            {
                MessageBox.Show("No se ha seleccionado un jefe de manera correcta", "Atencion: ", MessageBoxButtons.OK);
                return;
            }
            else
            {
                ReportDataSource Datos = new ReportDataSource("DataSet1", Tabla);
                rv_listadoEmpleados_Jefes.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Reportes.Empleados_Jefes.ReporteEmpleados_Jefes.rdlc";
                rv_listadoEmpleados_Jefes.LocalReport.DataSources.Clear();
                rv_listadoEmpleados_Jefes.LocalReport.DataSources.Add(Datos);
                rv_listadoEmpleados_Jefes.RefreshReport();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_numDoc.Text == "" || txt_tipoDoc.Text == "")
            {
                MessageBox.Show("No se ha insertado el Tipo o Numero de Documento", "Atencion: ", MessageBoxButtons.OK);
                return;
            }
            else
            {
                DataTable Tabla = new DataTable();
                //Tabla 
                Tabla = EsJefeS();
                CargarInforme(Tabla);
            }
        }
    }
}
