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

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
