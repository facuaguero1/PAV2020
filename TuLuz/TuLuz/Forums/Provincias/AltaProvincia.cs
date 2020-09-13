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

            if (tratamiento.validar(this.Controls)==TratamientosEspeciales.Validacion.correcta)
            {
                _Ep.codProvincia = txt_codProvincia.Text;
                _Ep.nombre = txt_nombreProvincia.Text;
                Provincias.Insertar(_Ep);
            }
            this.Close();
            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AltaProvincia_Load(object sender, EventArgs e)
        {

        }
    }
}
