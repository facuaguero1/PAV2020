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

namespace TuLuz.Forums.Reportes.PedidosXClientes
{
    public partial class PedidosXCliente : Form
    {

        Ng_Pedidos Pedidos = new Ng_Pedidos();
        Ng_Clientes Clientes = new Ng_Clientes();
        public PedidosXCliente()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PedidosXCliente_Load(object sender, EventArgs e)
        {
            cmb_Clientes.Cargar(Clientes.EstructuraComboxListado());
            cmb_Clientes.SelectedIndex = -1;
            this.RVPedidosXClientes.RefreshReport();
        }

        private void cmb_Clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Clientes.SelectedIndex == -1)
            {
                cmb_Clientes.Text = "Seleccionar.";
            }
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (cmb_Clientes.SelectedIndex == -1)
            {
                MessageBox.Show("No se selecciono ningun empleado", "ATENCION");
            }
            else
            {
                DataTable tabla = new DataTable();
                tabla = Pedidos.Buscar_PedidoPorCliente(cmb_Clientes.SelectedValue.ToString());
                ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
                RVPedidosXClientes.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Reportes.PedidosXClientes.PedidosXClientes.rdlc";
                ReportParameter[] parametros = new ReportParameter[2];
                parametros[0] = new ReportParameter("RP01", "Clientes: " + cmb_Clientes.SelectedValue.ToString());
                parametros[1] = new ReportParameter("RP02", "Fecha: " + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString());
                RVPedidosXClientes.LocalReport.DataSources.Clear();
                RVPedidosXClientes.LocalReport.SetParameters(parametros);
                RVPedidosXClientes.LocalReport.DataSources.Add(Datos);
                RVPedidosXClientes.RefreshReport();

            }
        }
    }
}
