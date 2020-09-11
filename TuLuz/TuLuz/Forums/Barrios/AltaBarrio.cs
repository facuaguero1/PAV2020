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
    public partial class AltaBarrio : Form
    {
        Ng_Barrios Barrios = new Ng_Barrios();
        Ng_Localidad Localidad = new Ng_Localidad();
        
        public AltaBarrio()
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
            Es_Barrio _Ec = new Es_Barrio();

            if (tratamiento.validar(this.Controls)==TratamientosEspeciales.Validacion.correcta)
            {
                _Ec.codBarrio = txt_CuitCliente.Text;
                _Ec.nombre = txt_nombreCliente.Text;
                _Ec.codLocalidad = cmb_Localidad.SelectedValue.ToString();
                Barrios.Insertar(_Ec);
            }
            this.Close();
            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AltaBarrio_Load(object sender, EventArgs e)
        {
            cmb_Localidad.Cargar(Localidad.EstructuraCombo());
        }
    }
}
