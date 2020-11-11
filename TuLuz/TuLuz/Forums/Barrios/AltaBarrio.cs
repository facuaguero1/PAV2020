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
        Ng_Provincias Provincias = new Ng_Provincias();
        
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
            DataTable Verificacion = new DataTable();

            if (tratamiento.validar(this.Controls)==TratamientosEspeciales.Validacion.correcta)
            {
                _Ec.codBarrio = txt_codBarrio.Text;
                _Ec.nombre = txt_nombreCliente.Text;
                _Ec.codLocalidad = cmb_Localidad.SelectedValue.ToString();
                Verificacion = Barrios.Buscar_Barrio_Codigo(_Ec.codBarrio);
                if (Verificacion.Rows.Count > 0)
                {
                    
                    MessageBox.Show("El barrio que desea insertar ya existe. ", "ATENCION");
                }
                else
                {
                    Barrios.Insertar(_Ec);
                    this.Close();
                }
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AltaBarrio_Load(object sender, EventArgs e)
        {
            cmb_Provincia.Cargar(Provincias.EstructuraCombo());
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
            FormularioSubMenu.TopLevel = true;
            FormularioSubMenu.FormBorderStyle = FormBorderStyle.None;   //sin bordes
            FormularioSubMenu.Dock = DockStyle.Fill;    //para rellenar formulario en el centro
            FormularioSubMenu.BringToFront(); //traer el formulario por delante de la imagen de fondo
            FormularioSubMenu.Show(); //ejecutar formulario

        }
        private void cmb_Localidad_Click(object sender, EventArgs e)
        {
            if (cmb_Provincia.SelectedIndex == -1)
            {

            }
            else
            {
                cmb_Localidad.Cargar(new EstructuraComboBox());
                cmb_Localidad.Cargar(Localidad.EstructuraComboEspecial(int.Parse(cmb_Provincia.SelectedValue.ToString())));
            }
            cmb_Localidad.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormularioSubMenu(new AltaProvincia());
        }

        private void cmb_Provincia_Click(object sender, EventArgs e)
        {
            cmb_Provincia.Cargar(Provincias.EstructuraCombo());
        }

        private void cmb_Provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Provincia.SelectedIndex == -1)
            {

            }
            else
            {
                cmb_Localidad.Cargar(new EstructuraComboBox());
                cmb_Localidad.Cargar(Localidad.EstructuraComboEspecial(int.Parse(cmb_Provincia.SelectedValue.ToString())));
            }
            cmb_Localidad.SelectedIndex = -1;
        }
    }
}
