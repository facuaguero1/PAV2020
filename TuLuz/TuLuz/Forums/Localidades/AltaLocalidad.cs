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
    public partial class AltaLocalidad : Form
    {
        Ng_Localidad Localidad = new Ng_Localidad();
        Ng_Provincias Provincia = new Ng_Provincias();
        
        public AltaLocalidad()
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
            Es_Localidad _EL = new Es_Localidad();
            DataTable Verificacion = new DataTable();

            if (tratamiento.validar(this.Controls)==TratamientosEspeciales.Validacion.correcta)
            {
                _EL.codLocalidad = txt_Cod_localidad.Text;
                _EL.nombre = txt_nombreLocalidad.Text;
                _EL.codProvincia = cmb_provincia.SelectedValue.ToString();
                Verificacion = Localidad.Buscar_Localidad_Codigo(_EL.codLocalidad);
                if (Verificacion.Rows.Count > 0)
                {

                    MessageBox.Show("La Localidad que desea insertar ya existe. ", "ATENCION");

                }
                else
                {
                    Localidad.Insertar(_EL);
                    this.Close();
                }
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AltaLocalidad_Load(object sender, EventArgs e)
        {
            cmb_provincia.Cargar(Provincia.EstructuraCombo());
            cmb_provincia.SelectedIndex = - 1;
        }

        private void txt_Cod_localidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmb_provincia_Click(object sender, EventArgs e)
        {
            cmb_provincia.Cargar(Provincia.EstructuraCombo());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new AltaProvincia());
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
    }
}
