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
            cmb_nro_doc.Cargar(Empleados.EstructuraComboxListado());
            cmb_nro_doc.SelectedIndex = -1;
        }
        private DataTable EsJefeS()
        {
            if (chk_todos.Checked==true)
            {
                Tabla = Empleados.Todos_los_Jefes();
            }
            else
            {
                Tabla = Empleados.EsJefeS(cmb_nro_doc.SelectedValue.ToString());
            }
            return Tabla;
        }
        private void CargarInforme(DataTable Tabla)
        {
            if (Tabla.Rows.Count == 0 )
            {
                MessageBox.Show("El empleado seleccionado no es jefe", "Atencion: ", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (chk_todos.Checked == true)
                {
                    ReportDataSource Datos = new ReportDataSource("DataSet1", Tabla);
                    rv_listadoEmpleados_Jefes.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Reportes.Empleados_Jefes.ReporteEmpleados_Jefes.rdlc";
                    ReportParameter[] parametros = new ReportParameter[2];
                    parametros[0] = new ReportParameter("RP01", "Jefe: Todos");
                    parametros[1] = new ReportParameter("RP02", "Fecha: " + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString());
                    rv_listadoEmpleados_Jefes.LocalReport.DataSources.Clear();
                    rv_listadoEmpleados_Jefes.LocalReport.SetParameters(parametros);
                    rv_listadoEmpleados_Jefes.LocalReport.DataSources.Add(Datos);
                    rv_listadoEmpleados_Jefes.RefreshReport();

                }
                else
                {
                    ReportDataSource Datos = new ReportDataSource("DataSet1", Tabla);
                    rv_listadoEmpleados_Jefes.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Reportes.Empleados_Jefes.ReporteEmpleados_Jefes.rdlc";
                    ReportParameter[] parametros = new ReportParameter[2];
                    parametros[0] = new ReportParameter("RP01", "Jefe: " + cmb_nro_doc.SelectedValue);
                    parametros[1] = new ReportParameter("RP02", "Fecha: " + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString());
                    rv_listadoEmpleados_Jefes.LocalReport.DataSources.Clear();
                    rv_listadoEmpleados_Jefes.LocalReport.SetParameters(parametros);
                    rv_listadoEmpleados_Jefes.LocalReport.DataSources.Add(Datos);
                    rv_listadoEmpleados_Jefes.RefreshReport();
                }

            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (cmb_nro_doc.SelectedIndex == -1 && chk_todos.Checked==false)
            {
                MessageBox.Show("No se ha seleccionado ningun numero de documento", "Atencion: ", MessageBoxButtons.OK);
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
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_nro_doc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_nro_doc.SelectedIndex == -1)
            {
                cmb_nro_doc.Text = "Seleccionar...";
            }
        }

        private void chk_todos_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_todos.Checked == true)
            {
                cmb_nro_doc.Enabled = false;
            }
            else
            {
                cmb_nro_doc.Enabled = true;
            }
        }
    }
}
