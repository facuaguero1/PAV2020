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


namespace TuLuz.Forums.Reportes.ClientesXEstado
{
    public partial class ClientesXEstado1 : Form
    {
        Ng_Clientes Clientes = new Ng_Clientes();
        public ClientesXEstado1()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {

            DataTable tabla = new DataTable();
            string estado = "";

            if (chk_Activos.Checked == true)
            {
                if (Chk_no_Activos.Checked == true)
                {
                    tabla = Clientes.Todos_los_Clientes();
                    estado = "Activos y No Activos";

                }
                else
                {
                    tabla = Clientes.Todos_los_ClientesActivos();
                    estado = "Activos";
                }
            }

            if (Chk_no_Activos.Checked == true)
            {
                if (chk_Activos.Checked == false)
                {
                    tabla = Clientes.Todos_los_ClientesNoActivos();
                    estado = "No Activos";
                }
            }
            ReportDataSource Datos = new ReportDataSource("DataSet2", tabla);
            RVClientesXEstados.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Reportes.ClientesXEstado.ClientesXEstado.rdlc";
            ReportParameter[] parametros = new ReportParameter[2];
            parametros[0] = new ReportParameter("RP01", "Estado: " + estado);
            parametros[1] = new ReportParameter("RP02", "Fecha: " + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString());
            RVClientesXEstados.LocalReport.DataSources.Clear();
            RVClientesXEstados.LocalReport.SetParameters(parametros);
            RVClientesXEstados.LocalReport.DataSources.Add(Datos);
            RVClientesXEstados.RefreshReport();
        }
    }
}

