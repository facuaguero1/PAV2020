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
    public partial class PedidosXEmpleados : Form
    {
        Ng_Pedidos Pedidos = new Ng_Pedidos();
        Ng_Empleados Empleados = new Ng_Empleados();

        public PedidosXEmpleados()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox011_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Empleados.SelectedIndex == -1)
            {
                cmb_Empleados.Text = "Seleccionar.";
            }
            
        }

        private void PedidosXEmpleados_Load(object sender, EventArgs e)
        {
            cmb_Empleados.Cargar(Empleados.EstructuraComboxListado());
            cmb_Empleados.SelectedIndex = -1;
            this.RVPedidosXEmpleados.RefreshReport();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (cmb_Empleados.SelectedIndex == -1)
            {
                MessageBox.Show("No se selecciono ningun empleado", "ATENCION");
            }
            else
            {
                DataTable tabla = new DataTable();
                tabla = Pedidos.Buscar_PedidoPorEmpleado(cmb_Empleados.SelectedValue.ToString());
                ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
                RVPedidosXEmpleados.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Reportes.PedidosXEmpleados.PedidosXEmpleados.rdlc";
                ReportParameter[] parametros = new ReportParameter[2];
                parametros[0] = new ReportParameter("RP01", "Empleados: " + cmb_Empleados.SelectedValue.ToString());
                parametros[1] = new ReportParameter("RP02", "Fecha: " + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString());
                RVPedidosXEmpleados.LocalReport.DataSources.Clear();
                RVPedidosXEmpleados.LocalReport.SetParameters(parametros);
                RVPedidosXEmpleados.LocalReport.DataSources.Add(Datos);
                RVPedidosXEmpleados.RefreshReport();

            }
        }
    }
}       

