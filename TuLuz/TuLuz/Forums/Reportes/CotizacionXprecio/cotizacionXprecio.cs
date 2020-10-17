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
    public partial class cotizacionXprecio : Form
    {
        Ng_Cotizaciones cot = new Ng_Cotizaciones();

        
        public cotizacionXprecio()
        {
            InitializeComponent();
        }

      

    

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AltaBarrio_Load(object sender, EventArgs e)
        {

            this.RVcotizacionXprecio.RefreshReport();
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




        private void button1_Click_2(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = cot.BuscarCotizacionesXprecio(txt_pracioMinimo.Text, txt_precioMaximo.Text);


            ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
            RVcotizacionXprecio.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Reportes.CotizacionXprecio.ReporteCotizacionXprecio.rdlc";
            ReportParameter[] parametros = new ReportParameter[3];
            parametros[0] = new ReportParameter("RP01", " Precio Minimo: " + txt_pracioMinimo.Text);
            parametros[1] = new ReportParameter("RP02", " Precio Maximo: " + txt_precioMaximo.Text);
            parametros[2] = new ReportParameter("RP03", "Fecha: " + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString());
            RVcotizacionXprecio.LocalReport.DataSources.Clear();
            RVcotizacionXprecio.LocalReport.SetParameters(parametros);
            RVcotizacionXprecio.LocalReport.DataSources.Add(Datos);
            RVcotizacionXprecio.RefreshReport();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
