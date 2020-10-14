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
    public partial class Pedido_X_2Fechas : Form
    {
        Ng_Pedidos Pedidos = new Ng_Pedidos();
        Ng_Empleados Empleados = new Ng_Empleados();

        public Pedido_X_2Fechas()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_TipoDocs Docs = new Es_TipoDocs();
            DataTable Verificacion = new DataTable();

            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {

                
               
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txt_idTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Pedido_X_2Fechas_Load(object sender, EventArgs e)
        {
            for (int i = 1930; i < 2021; i++)
            {
                if (i < 2021)
                    cmb_Año_Desde.Items.Add(i);
            }

            for (int i = 1930; i < 2021; i++)
            {
                if (i < 2021)
                    cmb_Año_Hasta.Items.Add(i);
            }

            //this.reportViewer1.RefreshReport();
            this.rv_listadoPedido_x_fecha.RefreshReport();
        }

        private void cmb_Mes_desde_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Mes_desde.SelectedItem.ToString() == "2")
            {
                cmb_Dia_Desde.Items.Clear();
                for (int i = 1; i < 29; i++)
                {
                    cmb_Dia_Desde.Items.Add(i);
                }
            }
            else
            {
                if (cmb_Mes_desde.SelectedItem.ToString() == "4" || cmb_Mes_desde.SelectedItem.ToString() == "6" || cmb_Mes_desde.SelectedItem.ToString() == "9" || cmb_Mes_desde.SelectedItem.ToString() == "11")
                {
                    cmb_Dia_Desde.Items.Clear();
                    for (int i = 1; i < 31; i++)
                    {

                        cmb_Dia_Desde.Items.Add(i);
                    }
                }
                else
                {
                    cmb_Dia_Desde.Items.Clear();
                    for (int i = 1; i < 32; i++)
                    {

                        cmb_Dia_Desde.Items.Add(i);
                    }
                }

            }
        }

        private void cmb_Año_Desde_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Año_Desde_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void cmb_Año_Desde_Click(object sender, EventArgs e)
        {
            
        }

        private void cmb_Mes_Hasta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Mes_Hasta.SelectedItem.ToString() == "2")
            {
                cmb_Dia_Hasta.Items.Clear();
                for (int i = 1; i < 29; i++)
                {
                    cmb_Dia_Hasta.Items.Add(i);
                }
            }
            else
            {
                if (cmb_Mes_Hasta.SelectedItem.ToString() == "4" || cmb_Mes_Hasta.SelectedItem.ToString() == "6" || cmb_Mes_Hasta.SelectedItem.ToString() == "9" || cmb_Mes_Hasta.SelectedItem.ToString() == "11")
                {
                    cmb_Dia_Hasta.Items.Clear();
                    for (int i = 1; i < 31; i++)
                    {

                        cmb_Dia_Hasta.Items.Add(i);
                    }
                }
                else
                {
                    cmb_Dia_Hasta.Items.Clear();
                    for (int i = 1; i < 32; i++)
                    {

                        cmb_Dia_Hasta.Items.Add(i);
                    }
                }

            }
        }
        private DataTable Buscar_X_Fecha ()
        {
            DataTable tabla = new DataTable();
            string FechaMin = cmb_Dia_Desde.SelectedItem.ToString() + "/" + cmb_Mes_desde.SelectedItem.ToString() + "/" + cmb_Año_Desde.SelectedItem.ToString();
            string FechaMax = cmb_Dia_Hasta.SelectedItem.ToString() + "/" + cmb_Mes_Hasta.SelectedItem.ToString() + "/" + cmb_Año_Hasta.SelectedItem.ToString();
            tabla = Pedidos.Buscar_X_Fecha(FechaMin, FechaMax);
            return tabla;
        }
        private void CargarInforme (DataTable tabla)
        {
            ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
            rv_listadoPedido_x_fecha.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Reportes.Pedido_Entre_Fechas.ReportePedidoXFecha.rdlc";
            ReportParameter[] parametros = new ReportParameter[3];
            parametros[0] = new ReportParameter("RP01", "Fecha Desde: " + cmb_Dia_Desde.SelectedItem.ToString() + "/" + cmb_Mes_desde.SelectedItem.ToString() + "/" + cmb_Año_Desde.SelectedItem.ToString());
            parametros[1] = new ReportParameter("RP02", "Fecha Hasta: " + cmb_Dia_Hasta.SelectedItem.ToString() + "/" + cmb_Mes_Hasta.SelectedItem.ToString() + "/" + cmb_Año_Hasta.SelectedItem.ToString());
            parametros[2] = new ReportParameter("RP03", DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString());
            rv_listadoPedido_x_fecha.LocalReport.DataSources.Clear();
            rv_listadoPedido_x_fecha.LocalReport.SetParameters(parametros);
            rv_listadoPedido_x_fecha.LocalReport.DataSources.Add(Datos);
            rv_listadoPedido_x_fecha.RefreshReport();
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = Buscar_X_Fecha();
            CargarInforme(tabla);
        }
    }
}
