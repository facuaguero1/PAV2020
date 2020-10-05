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
using TuLuz.Forums.Provincias;
using TuLuz.Clases;
using TuLuz.Negocio;
using TuLuz.Negocio.EstructuraNegocios;




namespace TuLuz.Forums.Provincias
{
    public partial class ModificarProvincia : Form
    {
        Ng_Provincias Provincia = new Ng_Provincias();
        public string cod { get; set; } 
        
        public ModificarProvincia()
        {
            InitializeComponent();
            CerrarPanel();
           
            
        }
         private void CerrarPanel ()
        {
            Panel_ModificarProvincia.Visible = false;
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
                Panel_ModificarProvincia.Visible = true;
                this.cod = grid01.CurrentRow.Cells[0].Value.ToString();
                DataTable tabla = new DataTable();
                tabla = Provincia.RecuperarProvincia_Codigo(cod);
                txt_codProvincia.Text = tabla.Rows[0]["codProvincia"].ToString();
                txt_NombreNuevo.Text = tabla.Rows[0]["nombre"].ToString();


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
                Cargar_grilla(Provincia.Todas_las_Provincias());
            }
            else
            {
                if (txt_BuscarProvincia.Text == "")
                {
                    MessageBox.Show("No se ingreso parametro de busqueda");
                }
                else
                {
                    Cargar_grilla(Provincia.Buscar_Provincia_Codigo(txt_BuscarProvincia.Text));
                }
            }
        }
        private void Cargar_grilla (DataTable tabla)
        {
            grid01.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid01.Rows.Add();
                grid01.Rows[i].Cells[0].Value = tabla.Rows[i]["codProvincia"].ToString();
                grid01.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre"].ToString();

            }
        }
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_BuscarProvincia.Text = "";
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_Provincia _EC = new Es_Provincia();
            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                _EC.codProvincia = txt_codProvincia.Text;
                _EC.nombre = txt_NombreNuevo.Text;

                Provincia.Modificar(_EC);
                Panel_ModificarProvincia.Visible = false;
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

        private void txt_BuscarProvincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
