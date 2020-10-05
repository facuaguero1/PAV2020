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
    public partial class BorrarBarrio : Form
    {
        Ng_Localidad localidad = new Ng_Localidad();
        Ng_Barrios Barrios = new Ng_Barrios();
        public string cuit { get; set; } 
        
        public BorrarBarrio()
        {
            InitializeComponent();
            CerrarPanel();
           
            
        }
         private void CerrarPanel ()
        {
            Panel_ModificarCliente.Visible = false;
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
                this.cuit = grid01.CurrentRow.Cells[0].Value.ToString();
                DataTable Verificacion = new DataTable();
                Verificacion = Barrios.Buscar_Barrio_Codigo(this.cuit);
                if (Verificacion.Rows.Count > 0)
                {
                    Panel_ModificarCliente.Visible = true;
                    
                    DataTable tabla = new DataTable();
                    tabla = Barrios.RecuperarBarrio_Codigo(cuit);
                    txt_codBarrio.Text = tabla.Rows[0]["codBarrio"].ToString();
                    txt_NombreNuevo.Text = tabla.Rows[0]["nombre"].ToString();
                    string codBarrio = tabla.Rows[0]["codLocalidad"].ToString();
                    DataTable tabla2 = new DataTable();
                    tabla2 = localidad.Buscar_Localidad_Codigo(codBarrio);
                    txt_Localidad.Text = tabla2.Rows[0]["nombre"].ToString();
                }
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
                Cargar_grilla(Barrios.Todos_los_Barrios());
            }
            else
            {
                if (txt_BuscarCuit.Text == "")
                {
                    MessageBox.Show("No se ingreso parametro de busqueda");
                }
                else
                {
                    Cargar_grilla(Barrios.Buscar_Barrio_Codigo(txt_BuscarCuit.Text));
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

        

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            DataTable Verificacion = new DataTable();
            Verificacion = Barrios.Buscar_Barrio_Codigo(this.cuit);
            if (Verificacion.Rows.Count == 0)
            {

                MessageBox.Show("El barrio que desea eliminar no existe. ", "ATENCION");

            }
            else
            {
                Barrios.Borrar(this.cuit);
                Panel_ModificarCliente.Visible = false;
          
            }
            
        }

        private void BorrarBarrio_Load(object sender, EventArgs e)
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
