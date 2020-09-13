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
    public partial class BorrarProvincia : Form
    {
        Ng_Provincias Provincias = new Ng_Provincias();
        public string codProvincia { get; set; } 
        
        public BorrarProvincia()
        {
            InitializeComponent();
            CerrarPanel();
           
            
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
                Panel_DatosProvincia.Visible = true;
                this.codProvincia = grid01.CurrentRow.Cells[0].Value.ToString();
                DataTable tabla = new DataTable();
                tabla = Provincias.RecuperarProvincia_Codigo(codProvincia);
                txt_codProvincia.Text = tabla.Rows[0]["codProvincia"].ToString();
                txt_NombreProvincia.Text = tabla.Rows[0]["nombre"].ToString();
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
                Cargar_grilla(Provincias.Todas_las_Provincias());
            }
            else
            {
                if (txt_BuscarCodProvincia.Text == "")
                {
                    MessageBox.Show("No se ingreso parametro de busqueda");
                }
                else
                {
                    Cargar_grilla(Provincias.Buscar_Provincia_Codigo(txt_BuscarCodProvincia.Text));
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
            txt_BuscarCodProvincia.Text = "";
        }

        

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            Provincias.Borrar(this.codProvincia);
            Panel_DatosProvincia.Visible = false;
        }

        private void BorrarBarrio_Load(object sender, EventArgs e)
        {

        }
    }
}
