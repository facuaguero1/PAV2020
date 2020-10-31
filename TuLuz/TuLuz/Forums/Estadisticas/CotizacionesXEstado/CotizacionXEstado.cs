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
    public partial class CotizacionXEstado: Form
    {
        Ng_Cotizaciones Cotizacion = new Ng_Cotizaciones();
        
        public CotizacionXEstado()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AltaBarrio_Load(object sender, EventArgs e)
        {
           
        }

        private void txt_codBarrio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new AltaLocalidad());
        }

        public void AbrirFormularioSubMenu(Form FormularioSubMenu)
        {
            //this.SendToBack();      //si existe un formulario abierto, lo cerramos 
            FormularioSubMenu.TopLevel = true;
            FormularioSubMenu.FormBorderStyle = FormBorderStyle.None;   //sin bordes
            FormularioSubMenu.Dock = DockStyle.Fill;    //para rellenar formulario en el centro
            FormularioSubMenu.BringToFront(); //traer el formulario por delante de la imagen de fondo
            FormularioSubMenu.Show(); //ejecutar formulario

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new AltaProvincia());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            DataTable tabla2 = new DataTable();
            tabla = Cotizacion.Todas_Las_Cotizciones();
            tabla2 = Cotizacion.ContarCotizacionesXEstado();
            Be_BaseDatos _BD = new Be_BaseDatos();
            ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
            ReportDataSource Datos1 = new ReportDataSource("DataSet2", tabla2);
            rpv_CotizacionXEstado.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Estadisticas.CotizacionesXEstado.Rp_CotizacionesXEstado.rdlc";
            ReportParameter[] parametros = new ReportParameter[2];
            parametros[0] = new ReportParameter("RP01", "Grafico sobre los estado de las cotizaciones");
            parametros[1] = new ReportParameter("RP02", "Fecha: " + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString());
            //parametros[2] = new ReportParameter("RP03", Activos().ToString());
            rpv_CotizacionXEstado.LocalReport.DataSources.Clear();
            rpv_CotizacionXEstado.LocalReport.SetParameters(parametros);
            rpv_CotizacionXEstado.LocalReport.DataSources.Add(Datos);
            rpv_CotizacionXEstado.LocalReport.DataSources.Add(Datos1);
            rpv_CotizacionXEstado.RefreshReport();
        }
    }
}
