using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuLuz.Forums;
using TuLuz.Forums.Clientes;
using TuLuz.Clases;
using TuLuz.Negocio;
using TuLuz.Negocio.EstructuraNegocios;




namespace TuLuz.Forums.Clientes
{
    public partial class ModificarBarrio : Form
    {
        Ng_Localidad Localidad = new Ng_Localidad();
        Ng_Barrios Barrio = new Ng_Barrios();
        public string cod { get; set; } 
        
        public ModificarBarrio()
        {
            InitializeComponent();
            CerrarPanel();
            cmbLocalidades.Cargar(Localidad.EstructuraCombo());
           
            
        }
         private void CerrarPanel ()
        {
            Panel_ModificarCliente.Visible = false;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (this.grid01.Rows.Count == 0)
            {
                MessageBox.Show("No selecciono ningun registro de la grilla","Importante",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                cmbLocalidades.Cargar(Localidad.EstructuraCombo());
                Panel_ModificarCliente.Visible = true;
                this.cod = grid01.CurrentRow.Cells[0].Value.ToString();
                DataTable tabla = new DataTable();
                tabla = Barrio.RecuperarBarrio_Codigo(cod);
                txt_codBarrio.Text = tabla.Rows[0]["codBarrio"].ToString();
                txt_NombreNuevo.Text = tabla.Rows[0]["nombre"].ToString();
                cmbLocalidades.SelectedValue = int.Parse(tabla.Rows[0]["codLocalidad"].ToString());


            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            CerrarPanel();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (chk_Todos.Checked==true)
            {
                Cargar_grilla(Barrio.Todos_los_Barrios());
            }
            else
            {
                if (txt_BuscarCuit.Text == "")
                {
                    MessageBox.Show("No se ingreso parametro de busqueda");
                }
                else
                {
                    Cargar_grilla(Barrio.Buscar_Barrio_Codigo(txt_BuscarCuit.Text));
                }
            }
        }
        private void Cargar_grilla (DataTable tabla)
        {
            grid01.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid01.Rows.Add();
                grid01.Rows[i].Cells[0].Value = tabla.Rows[i]["codBarrio"].ToString();
                grid01.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre"].ToString();
                grid01.Rows[i].Cells[2].Value = tabla.Rows[i]["codLocalidad"].ToString();

            }
        }
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_BuscarCuit.Text = "";
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_Barrio _EC = new Es_Barrio();
            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                _EC.codBarrio = txt_codBarrio.Text;
                _EC.nombre = txt_NombreNuevo.Text;
                _EC.codLocalidad = cmbLocalidades.SelectedValue.ToString();

                Barrio.Modificar(_EC);
                Panel_ModificarCliente.Visible = false;
            }
            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cmbLocalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_BuscarCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
