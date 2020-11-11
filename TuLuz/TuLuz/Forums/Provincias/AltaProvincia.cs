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

namespace TuLuz.Forums
{
    public partial class AltaProvincia : Form
    {
        Ng_Provincias Provincias = new Ng_Provincias();
        
        public AltaProvincia()
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
            Es_Provincia _Ep = new Es_Provincia();
            DataTable Verificacion = new DataTable();

            if (tratamiento.validar(this.Controls)==TratamientosEspeciales.Validacion.correcta)
            {
                _Ep.codProvincia = txt_codProvincia.Text;
                _Ep.nombre = txt_nombreProvincia.Text;
                Verificacion = Provincias.Buscar_Provincia_Codigo(_Ep.codProvincia);
                if (Verificacion.Rows.Count > 0)
                {
                    MessageBox.Show("La provincia que desea insertar ya existe. ", "ATENCION");
                }
                else
                {
                    Provincias.Insertar(_Ep);
                    this.Close();
                }
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txt_codProvincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
