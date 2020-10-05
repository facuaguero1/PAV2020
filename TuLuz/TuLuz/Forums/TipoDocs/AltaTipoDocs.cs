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
    public partial class AltaTipoDoc : Form
    {
        Ng_Tipo_Documentos Documentos = new Ng_Tipo_Documentos();

        public AltaTipoDoc()
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

                Docs.idTipoDoc = txt_idTipo.Text;
                Docs.nombre = txt_nombre.Text;
                Docs.siglas = textSiglas.Text;
                Verificacion = Documentos.Buscar_TiposDoc_Codigo(Docs.idTipoDoc);
                if (Verificacion.Rows.Count > 0)
                {

                    MessageBox.Show("El tipo documento que desea insertar ya existe. ", "ATENCION");

                }
                else
                {
                    Documentos.Insertar(Docs);
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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_CuitCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_idTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
