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
    public partial class BorrarCliente : Form
    {
        Ng_Clientes cliente = new Ng_Clientes();
        public string cuit { get; set; }

        public BorrarCliente()
        {
            InitializeComponent();
            CerrarPanel();
        }
        private void CerrarPanel()
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
                Verificacion = cliente.Buscar_Cliente(this.cuit);
                if (Verificacion.Rows.Count > 0)
                {
                    Panel_ModificarCliente.Visible = true;
                    this.cuit = grid01.CurrentRow.Cells[0].Value.ToString();
                    DataTable tabla = new DataTable();
                    tabla = cliente.RecuperarCliente(cuit);
                    txt_CuitNuevo.Text = tabla.Rows[0]["cuitCliente"].ToString();
                    txt_NombreNuevo.Text = tabla.Rows[0]["nombre"].ToString();
                    txt_ApellidoNuevo.Text = tabla.Rows[0]["apellido"].ToString();
                }

            }
        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (chk_activos.Checked == true)
            {
                if (chk_noActivos.Checked == true)
                {
                    Cargar_grilla(cliente.Todos_los_Clientes());
                }
                else
                {
                    Cargar_grilla(cliente.Todos_los_ClientesActivos());
                }
            }
            else
            {
                if (chk_noActivos.Checked == true)
                {
                    Cargar_grilla(cliente.Todos_los_ClientesNoActivos());
                }
                else
                {

                    if (txt_BuscarCuit.Text == "")
                    {
                        MessageBox.Show("No se ingreso parametro de busqueda");
                    }
                    else
                    {
                        Cargar_grilla(cliente.RecuperarCliente(txt_BuscarCuit.Text));
                    }
                }
            }
        }
        private void Cargar_grilla(DataTable tabla)
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
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (cliente.ContarPedidosDelCliente(this.cuit) > 0)
            {
                MessageBox.Show("El cliente tiene pedidos asignados, por lo tanto se lo dara de baja pero no se lo eliminara", "ATNENCION");
                cliente.DarBaja(this.cuit);
                Panel_ModificarCliente.Visible = false;
            }
            else
            {
                if (cliente.ContarCotizacionDelCliente(this.cuit) > 0)
                {

                    MessageBox.Show("El cliente tiene Cotizaciones asignados, por lo tanto se lo dara de baja pero no se lo eliminara", "ATNENCION");
                    cliente.DarBaja(this.cuit);
                    Panel_ModificarCliente.Visible = false;

                }
                else
                {
                    cliente.Borrar(this.cuit);
                    Panel_ModificarCliente.Visible = false;
                }
            }

        }
    }
}

