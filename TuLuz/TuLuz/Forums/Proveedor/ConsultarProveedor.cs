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
using TuLuz.Forums.Provincias;
using TuLuz.Clases;
using TuLuz.Negocio;
using TuLuz.Negocio.EstructuraNegocios;




namespace TuLuz.Forums.Provincias
{
    public partial class ConsultarProveedor : Form
    {
        Ng_Proveedor Proveedor = new Ng_Proveedor();
        public string cod { get; set; } 
        
        public ConsultarProveedor()
        {
            InitializeComponent();
            CerrarPanel();  
        }
         private void CerrarPanel ()
        {
            Panel_ConsultarCliente.Visible = false;
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            if (this.grid01.Rows.Count == 0)
            {
                MessageBox.Show("No selecciono ningun registro de la grilla", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Panel_ConsultarCliente.Visible = true;
                this.cod = grid01.CurrentRow.Cells[0].Value.ToString();
                DataTable tabla = new DataTable();
                tabla = Proveedor.RecuperarProveedor_Codigo(cod);
                txt_cuit.Text = tabla.Rows[0]["cuitProveedor"].ToString();
                txt_razonsocial.Text = tabla.Rows[0]["razonSocial"].ToString();
                txt_Contacto.Text = tabla.Rows[0]["contacto"].ToString();
                txt_telefono.Text = tabla.Rows[0]["telefono"].ToString();

            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            CerrarPanel();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (chk_activos.Checked == true)
            {
                if (chk_noActivos.Checked == true)
                {
                    Cargar_grilla(Proveedor.Todos_los_proveedores());
                }
                else
                {
                    Cargar_grilla(Proveedor.Todos_los_proveedoresActivos());
                }
            }
            else
            {
                if (chk_noActivos.Checked == true)
                {
                    Cargar_grilla(Proveedor.Todos_los_proveedoresNoActivos());
                }
                else
                {

                    if (txt_BuscarCodigo.Text == "")
                    {
                        MessageBox.Show("No se ingreso parametro de busqueda");
                    }
                    else
                    {
                        Cargar_grilla(Proveedor.RecuperarProveedor_Codigo(txt_BuscarCodigo.Text));
                    }
                }
            }
        }
        private void Cargar_grilla (DataTable tabla)
        {
            grid01.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid01.Rows.Add();
                grid01.Rows[i].Cells[0].Value = tabla.Rows[i]["cuitProveedor"].ToString();
                grid01.Rows[i].Cells[1].Value = tabla.Rows[i]["razonSocial"].ToString();
                grid01.Rows[i].Cells[2].Value = tabla.Rows[i]["contacto"].ToString();
                grid01.Rows[i].Cells[3].Value = tabla.Rows[i]["telefono"].ToString();

            }
        }
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_BuscarCodigo.Text = "";
        }

        

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            Panel_ConsultarCliente.Visible = false;
        }

        private void ConsultarProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
