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
    public partial class AltaProveedor : Form
    {
        Ng_Proveedor Proveedor= new Ng_Proveedor();
        
        public AltaProveedor()
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
            Es_Proveedor _EP = new Es_Proveedor();
            DataTable Verificacion = new DataTable();

            if (tratamiento.validar(this.Controls)==TratamientosEspeciales.Validacion.correcta)
            {
                _EP.cuitProveedor = txt_Cuit_Proveedor.Text;
                _EP.razonSocial = txt_RazonSocial.Text;
                _EP.contacto = txt_contacto.Text;
                _EP.telefono = txt_telefono.Text;
                _EP.activo = "true";
                Verificacion = Proveedor.Buscar_Proveedor_Codigo(_EP.cuitProveedor);
                if (Verificacion.Rows.Count > 0)
                {
                    MessageBox.Show("El Proveedor que desea insertar ya existe. ", "ATENCION");
                }
                else
                {
                    Proveedor.Insertar(_EP);
                    this.Close();
                }
            }
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txt_Cuit_Proveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
