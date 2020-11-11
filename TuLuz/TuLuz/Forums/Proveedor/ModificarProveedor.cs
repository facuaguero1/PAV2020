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
    public partial class ModificarProveedor : Form
    {
        Ng_Proveedor Proveedor = new Ng_Proveedor();
        public string cuit { get; set; } 
        
        public ModificarProveedor()
        {
            InitializeComponent();
            CerrarPanel(); 
        }
         private void CerrarPanel ()
        {
            Panel_ModificarProveedor.Visible = false;
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
                Panel_ModificarProveedor.Visible = true;
                this.cuit = grid01.CurrentRow.Cells[0].Value.ToString();
                DataTable tabla = new DataTable();
                tabla = Proveedor.Buscar_Proveedor_Codigo(cuit);
                txt_Cuit.Text = tabla.Rows[0]["cuitProveedor"].ToString();
                txt_razonSocial.Text = tabla.Rows[0]["razonSocial"].ToString();
                txt_contacto.Text = tabla.Rows[0]["contacto"].ToString();
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

                    if (txt_BuscarCuit.Text == "")
                    {
                        MessageBox.Show("No se ingreso parametro de busqueda");
                    }
                    else
                    {
                        Cargar_grilla(Proveedor.RecuperarProveedor_Codigo(txt_BuscarCuit.Text));
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
            txt_BuscarCuit.Text = "";
        }
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_Proveedor _EC = new Es_Proveedor();
            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                _EC.cuitProveedor = txt_Cuit.Text;
                _EC.razonSocial = txt_razonSocial.Text;
                _EC.contacto = txt_contacto.Text;
                _EC.telefono = txt_telefono.Text;

                Proveedor.Modificar(_EC);
                Panel_ModificarProveedor.Visible = false;
            } 
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
