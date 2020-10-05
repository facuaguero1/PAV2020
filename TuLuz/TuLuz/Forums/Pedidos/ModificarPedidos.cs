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
    public partial class ModificarPedidos: Form
    {
        Ng_Pedidos Pedidos = new Ng_Pedidos();
        Ng_DetallePedidos Detalle = new Ng_DetallePedidos();
        Ng_Clientes Clientes = new Ng_Clientes();
        Ng_Empleados Empleados = new Ng_Empleados();
        Ng_Cotizaciones Cotizaciones = new Ng_Cotizaciones();

        public string codigo { get; set; } 
        
        public ModificarPedidos()
        {
            InitializeComponent();
            CerrarPanel();
           
            cmb_numDocVendedor.Cargar(Empleados.EstructuraCombo());
            cmb_cuitCliente.Cargar(Clientes.EstructuraCombo());
            cmb_Cotizaciones.Cargar(Cotizaciones.EstructuraCombo());

        }
         private void CerrarPanel ()
        {
            Panel_ModificarPedidos.Visible = false;
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

                Panel_ModificarPedidos.Visible = true;
                this.codigo = grid01.CurrentRow.Cells[0].Value.ToString();
                DataTable tabla = new DataTable();
                tabla = Pedidos.Buscar_PedidoPorNumero(int.Parse(codigo));



                txt_numeroPedido.Text = tabla.Rows[0]["numeroPedido"].ToString();
                cmb_Cotizaciones.SelectedValue= tabla.Rows[0]["numeroCotizacion"].ToString();
                txt_fecha.Text = tabla.Rows[0]["fechaPedido"].ToString();
                txt_condicionPago.Text = tabla.Rows[0]["condicionPago"].ToString();
                cmb_numDocVendedor.SelectedValue = int.Parse(tabla.Rows[0]["numDniVendedor"].ToString());
                cmb_cuitCliente.SelectedValue = tabla.Rows[0]["cuitCliente"].ToString();
               
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
                Cargar_grilla(Pedidos.Todos_los_Pedidos());
            }
            else
            {
                if (txt_BuscarDoc.Text == "")
                {
                    MessageBox.Show("No se ingreso parametro de busqueda");
                }
                else
                {
                    Cargar_grilla(Pedidos.Buscar_PedidoPorNumero(int.Parse(txt_BuscarDoc.Text)));
                }
            }
        }
        private void Cargar_grilla (DataTable tabla)
        {
            grid01.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid01.Rows.Add();
                grid01.Rows[i].Cells[0].Value = tabla.Rows[i]["numeroPedido"].ToString();
                grid01.Rows[i].Cells[1].Value = tabla.Rows[i]["numeroCotizacion"].ToString();
                grid01.Rows[i].Cells[2].Value = tabla.Rows[i]["fechaPedido"].ToString();
                grid01.Rows[i].Cells[3].Value = tabla.Rows[i]["tipoDniVendedor"].ToString();
                grid01.Rows[i].Cells[4].Value = tabla.Rows[i]["numDniVendedor"].ToString();
                grid01.Rows[i].Cells[5].Value = tabla.Rows[i]["condicionPago"].ToString();
                grid01.Rows[i].Cells[6].Value = tabla.Rows[i]["cuitCliente"].ToString();

            }
        }
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_BuscarDoc.Text = "";
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_Pedidos _EP = new Es_Pedidos();

            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                DataTable tabla = new DataTable();
                tabla = Pedidos.Buscar_PedidoPorNumero(int.Parse(txt_numeroPedido.Text));
                _EP.numeroPedido = txt_numeroPedido.Text;
                _EP.numeroCotizacion = cmb_Cotizaciones.SelectedValue.ToString();
                _EP.fechaPedido = txt_fecha.Text;
                _EP.condicionPago = txt_condicionPago.Text;
                _EP.numDniVendedor= cmb_numDocVendedor.SelectedValue.ToString();
                _EP.cuitCliente = cmb_cuitCliente.SelectedValue.ToString();
                _EP.tipoDniVendedor= tabla.Rows[0]["tipoDniVendedor"].ToString();


                Pedidos.Modificar(_EP);
               
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

        private void btn_limpiarr_Click(object sender, EventArgs e)
        {
           cmb_cuitCliente.SelectedIndex = -1;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt_BuscarDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
