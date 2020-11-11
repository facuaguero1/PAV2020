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
    public partial class BorrarLocalidad : Form
    {
        Ng_Provincias Provincias = new Ng_Provincias();
        Ng_Localidad Localidad = new Ng_Localidad();
        public string codProvincia { get; set; }
        public string codLocalidad { get; set; }

        public BorrarLocalidad()
        {
            InitializeComponent();
            CerrarPanel();
            cmb_Provincia.Cargar(Provincias.EstructuraCombo());
            
        }
         private void CerrarPanel ()
        {
            Panel_DatosProvincia.Visible = false;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (this.grid01.Rows.Count == 0)
            {
                MessageBox.Show("No selecciono ningun registro de la grilla", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                this.codLocalidad = grid01.CurrentRow.Cells[0].Value.ToString();
                DataTable Verificacion = new DataTable();
                Verificacion = Localidad.Buscar_Localidad_Codigo(this.codLocalidad);
                if (Verificacion.Rows.Count > 0)
                {
                    Panel_DatosProvincia.Visible = true;
                    DataTable tabla = new DataTable();
                    tabla = Localidad.RecuperarLocalidad_Codigo(codLocalidad);
                    txt_codLocalidad.Text = tabla.Rows[0]["codLocalidad"].ToString();
                    txt_NombreLocalidad.Text = tabla.Rows[0]["nombre"].ToString();
                    cmb_Provincia.SelectedValue = int.Parse(tabla.Rows[0]["codProvincia"].ToString());
                }
            }
        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (chk_Todos.Checked==true)
            {
                Cargar_grilla(Localidad.Todos_las_Localidades());
            }
            else
            {
                if (txt_codLocalidad.Text == "")
                {
                    MessageBox.Show("No se ingreso parametro de busqueda");
                }
                else
                {
                    Cargar_grilla(Localidad.Buscar_Localidad_Codigo(txt_codLocalidad.Text));
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
            txt_BuscarCodLocalidad.Text = "";
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            Localidad.Borrar(this.codLocalidad);
            Panel_DatosProvincia.Visible = false;
        }
        private void txt_BuscarCodLocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
