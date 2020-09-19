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
    public partial class ModificarLocalidad : Form
    {
        Ng_Provincias Provincia = new Ng_Provincias();
        Ng_Localidad Localidad = new Ng_Localidad();
        public string cod { get; set; } 
        
        public ModificarLocalidad()
        {
            InitializeComponent();
            CerrarPanel();
            cmb_provincia.Cargar(Provincia.EstructuraCombo());
            
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
                tabla = Localidad.RecuperarLocalidad_Codigo(cod);
                txt_codLocalidad.Text = tabla.Rows[0]["codLocalidad"].ToString();
                txt_NombreNuevo.Text = tabla.Rows[0]["nombre"].ToString();
                cmb_provincia.SelectedValue = int.Parse(tabla.Rows[0]["codProvincia"].ToString());


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
                Cargar_grilla(Localidad.Todos_las_Localidades());
            }
            else
            {
                if (txt_BuscarLocalidad.Text == "")
                {
                    MessageBox.Show("No se ingreso parametro de busqueda");
                }
                else
                {
                    Cargar_grilla(Localidad.Buscar_Localidad_Codigo(txt_BuscarLocalidad.Text));
                }
            }
        }
        private void Cargar_grilla (DataTable tabla)
        {
            grid01.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid01.Rows.Add();
                grid01.Rows[i].Cells[0].Value = tabla.Rows[i]["codLocalidad"].ToString();
                grid01.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre"].ToString();
                grid01.Rows[i].Cells[2].Value = tabla.Rows[i]["codProvincia"].ToString();

            }
        }
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_BuscarLocalidad.Text = "";
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_Localidad _El = new Es_Localidad();
            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                _El.codLocalidad = txt_codLocalidad.Text;
                _El.nombre = txt_NombreNuevo.Text;
                _El.codProvincia = cmb_provincia.SelectedValue.ToString();

                Localidad.Modificar(_El);
                Panel_ModificarProvincia.Visible = false;
            }
            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
