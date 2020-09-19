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
    public partial class ModificarCliente : Form
    {
        Ng_Clientes cliente = new Ng_Clientes();
        public string cuit { get; set; } 
        
        public ModificarCliente()
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
                MessageBox.Show("No selecciono ningun registro de la grilla","Importante",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Panel_ModificarCliente.Visible = true;
                this.cuit = grid01.CurrentRow.Cells[0].Value.ToString();
                DataTable tabla = new DataTable();
                tabla = cliente.RecuperarCliente(cuit);
                txt_CuitNuevo.Text = tabla.Rows[0]["cuitCliente"].ToString();
                txt_NombreNuevo.Text = tabla.Rows[0]["nombre"].ToString();
                txt_ApellidoNuevo.Text = tabla.Rows[0]["apellido"].ToString();
                txt_activo.Text = tabla.Rows[0]["activo"].ToString();
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
                Cargar_grilla(cliente.Todos_los_Clientes());
            }
            else
            {
                if (txt_BuscarCuit.Text == "")
                {
                    MessageBox.Show("No se ingreso parametro de busqueda");
                }
                else
                {
                    Cargar_grilla(cliente.Buscar_Cliente(txt_BuscarCuit.Text));
                }
            }
        }
        private void Cargar_grilla (DataTable tabla)
        {
            grid01.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid01.Rows.Add();
                grid01.Rows[i].Cells[0].Value = tabla.Rows[i]["cuitCliente"].ToString();
                grid01.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre"].ToString();
                grid01.Rows[i].Cells[2].Value = tabla.Rows[i]["apellido"].ToString();

            }
        }
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_BuscarCuit.Text = "";
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_Clientes _EC = new Es_Clientes();
            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                _EC.cuitCliente = txt_CuitNuevo.Text;
                _EC.nombre = txt_NombreNuevo.Text;
                _EC.apellido = txt_ApellidoNuevo.Text;

                cliente.Modificar(_EC);
                Panel_ModificarCliente.Visible = false;
            }
            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
