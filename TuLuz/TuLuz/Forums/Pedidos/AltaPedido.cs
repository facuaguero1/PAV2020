using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuLuz.Negocio;
using TuLuz.Clases;
using TuLuz.Negocio.EstructuraNegocios;

namespace TuLuz.Forums
{
    public partial class AltaPedido : Form
    {
        Ng_Pedidos Pedidos = new Ng_Pedidos();
        Ng_Producto Producto = new Ng_Producto();
        Ng_Clientes Clientes = new Ng_Clientes();
        Be_BaseDatos _BD = new Be_BaseDatos();
        Ng_DetallePedidos Detalle = new Ng_DetallePedidos();
        Ng_Empleados Empleados = new Ng_Empleados();
        Ng_Cotizaciones Cotizaciones = new Ng_Cotizaciones();

        public AltaPedido()
        {
            InitializeComponent();
            cmb_CuitCliente.Cargar(Clientes.EstructuraCombo());
            cmb_vendedor.Cargar(Empleados.EstructuraCombo());
            cmb_cotizaciones.Cargar(Cotizaciones.EstructuraCombo());

        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void brn_Load(object sender, EventArgs e)
        {
            grp_detalle.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (grp_detalle.Visible == true)
            {
                grp_detalle.Visible = false;
            }
            else
            {
                grp_detalle.Visible = true;
            }
        }

        private void Cargar_grilla(DataTable tabla)
        {
            grdDetalle.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grdDetalle.Rows.Add();
                grdDetalle.Rows[i].Cells[0].Value = tabla.Rows[i]["numeroPedido"].ToString();
                grdDetalle.Rows[i].Cells[1].Value = tabla.Rows[i]["codigoProducto"].ToString();
                grdDetalle.Rows[i].Cells[2].Value = tabla.Rows[i]["cantidad"].ToString();
                grdDetalle.Rows[i].Cells[3].Value = tabla.Rows[i]["precio"].ToString();

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataTable Consulta = new DataTable();
            Consulta = Pedidos.Buscar_PedidoPorNumero(int.Parse(txt_NumPedido.Text));
           if (Consulta.Rows.Count > 0)
            {
            Es_DetallePedido _Ep = new Es_DetallePedido();
            _Ep.numeroPedido = txt_NumPedido.Text;
            _Ep.codigoProducto = cmb_CodProducto.SelectedValue.ToString();
            _Ep.cantidad = txt_Cant.Text;
            _Ep.precio = txt_Subtotal.Text;
            Detalle.Insertar(_Ep);
            Cargar_grilla(Detalle.RecuperarDetalles());
            }
            else
            {
                MessageBox.Show("Primero debe crear al pedido", "Atencion");
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox2.Checked == true)
                if (txt_NumPedido.Text == "")
                {
                    checkBox2.Checked = false;
                    MessageBox.Show("Primero debe insertar el codigo del pedido a agregar", "Atencion");
                    
                }
                else
                {
                    grp_detalle.Visible = true;
                    txt_NumeroPedidoDetalle.Text = txt_NumPedido.Text;
                    txt_NumPedido.Enabled = false;
                    cmb_CodProducto.Cargar(Producto.EstructuraCombo());

                }
            else
            {

                grp_detalle.Visible = false;
                txt_NumPedido.Enabled = true;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmb_CuitCliente.SelectedIndex = -1;
        }

        private void btn_crearProducto_Click(object sender, EventArgs e)
        {

            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_Pedidos _Ep = new Es_Pedidos();
            DataTable Verificacion = new DataTable();


            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                _Ep.numeroPedido = txt_NumPedido.Text;
                _Ep.numeroCotizacion = cmb_cotizaciones.SelectedValue.ToString();
                _Ep.fechaPedido = cmb_Dia.SelectedItem.ToString() + "/" + cmb_Mes.SelectedItem.ToString() + "/" + cmb_Año.SelectedItem.ToString();
                _Ep.numDniVendedor = cmb_vendedor.SelectedValue.ToString();
                DataTable tabla = new DataTable();
                tabla = Empleados.Buscar_Empleados(cmb_vendedor.SelectedValue.ToString());
                _Ep.tipoDniVendedor = tabla.Rows[0]["tipoDoc"].ToString();
                _Ep.condicionPago = txt_CondicionPago.Text;
                _Ep.cuitCliente = cmb_CuitCliente.SelectedValue.ToString();
                Verificacion = Pedidos.Buscar_PedidoPorNumero(int.Parse(_Ep.numeroPedido));
                if (Verificacion.Rows.Count > 0)
                {

                    MessageBox.Show("El pedido que desea insertar ya existe. ", "ATENCION");

                }
                else
                {
                    Pedidos.Insertar(_Ep);
                    this.Close();
                }
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_NumPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox012_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Mes.SelectedItem.ToString() == "2")
            {
                cmb_Dia.Items.Clear();
                for (int i = 1; i < 29; i++)
                {
                    cmb_Dia.Items.Add(i);
                }
            }
            else
            {
                if (cmb_Mes.SelectedItem.ToString() == "4" || cmb_Mes.SelectedItem.ToString() == "6" || cmb_Mes.SelectedItem.ToString() == "9" || cmb_Mes.SelectedItem.ToString() == "11")
                {
                    cmb_Dia.Items.Clear();
                    for (int i = 1; i < 31; i++)
                    {

                        cmb_Dia.Items.Add(i);
                    }
                }
                else
                {
                    cmb_Dia.Items.Clear();
                    for (int i = 1; i < 32; i++)
                    {

                        cmb_Dia.Items.Add(i);
                    }
                }

            }
        }
    }
}
