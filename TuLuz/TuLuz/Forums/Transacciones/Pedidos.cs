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
    public partial class Pedidos : Form
    {
        

        Be_BaseDatos _BD = new Be_BaseDatos();
        Ng_Pedidos Pedido = new Ng_Pedidos();
        Ng_Empleados Empleados = new Ng_Empleados();
        Ng_Clientes Clientes = new Ng_Clientes();
        Ng_Producto Producto = new Ng_Producto();
        Ng_Cotizaciones Cotizacion = new Ng_Cotizaciones();
        Ng_DetallePedidos Detalle = new Ng_DetallePedidos();
        Es_Pedidos EP = new Es_Pedidos();
        Ng_EstadosCotizaciones EstadosCot = new Ng_EstadosCotizaciones();

        public string num { get; set; }

        public Pedidos()
        {
            InitializeComponent();
            
            cmb_cliente.Cargar(Clientes.EstructuraCombo());
            cmb_Vendedor.Cargar(Empleados.EstructuraCombo());
            cmb_Cotizaciones.Cargar(Cotizacion.EstructuraCombo());
            cmb_Productos.Cargar(Producto.EstructuraCombo());
            groupBox1.Visible = false;
        }

        //BOTON MODIFICAR....
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_Pedidos _EP = new Es_Pedidos();

            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                DataTable tabla = new DataTable();
                tabla =Pedido.Buscar_PedidoPorNumero(int.Parse(txt_numeroPedido.Text));
                _EP.numeroPedido = txt_numeroPedido.Text;
                _EP.numeroCotizacion = cmb_Cotizaciones.SelectedValue.ToString();
                _EP.fechaPedido = cmb_Dia.SelectedItem +"/"+ cmb_Mes.SelectedItem + "/" + cmb_Año.SelectedItem;
                _EP.condicionPago = txt_CondicionPago.Text;
                _EP.numDniVendedor = cmb_Vendedor.SelectedValue.ToString();
                _EP.cuitCliente = cmb_cliente.SelectedValue.ToString();
                _EP.tipoDniVendedor = tabla.Rows[0]["tipoDniVendedor"].ToString();


                Pedido.Modificar(_EP);
                Cargar_grilla(Pedido.Todos_los_Pedidos());

            }
        }
            private void btn_aceptar_Click(object sender, EventArgs e)
        {

            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_Pedidos _Ep = new Es_Pedidos();
            DataTable Verificacion = new DataTable();


            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                _Ep.numeroPedido = txt_numeroPedido.Text;
                _Ep.numeroCotizacion = cmb_Cotizaciones.SelectedValue.ToString();
                _Ep.fechaPedido = cmb_Dia.SelectedItem + "/" + cmb_Mes.SelectedItem+ "/" + cmb_Año.SelectedItem;
                _Ep.numDniVendedor = cmb_Vendedor.SelectedValue.ToString();
                DataTable tabla = new DataTable();
                tabla = Empleados.Buscar_Empleados(cmb_Vendedor.SelectedValue.ToString());
                _Ep.tipoDniVendedor = tabla.Rows[0]["tipoDoc"].ToString();
                _Ep.condicionPago = txt_CondicionPago.Text;
                _Ep.cuitCliente = cmb_cliente.SelectedValue.ToString();
                Verificacion = Pedido.Buscar_PedidoPorNumero(int.Parse(_Ep.numeroPedido));
                if (Verificacion.Rows.Count > 0)
                {

                    MessageBox.Show("El pedido que desea insertar ya existe. ", "ATENCION");

                }
                else
                {
                    Pedido.Insertar(_Ep);
                    Pedido.CerrarTransaccion();
                    Pedido.IniciarTransaccion();
                    Cargar_grilla(Pedido.Todos_los_Pedidos());

                }
            }
        }
            

        private void brn_Load(object sender, EventArgs e)
        {
            Pedido.IniciarTransaccion();
            Cargar_grilla(Pedido.Todos_los_Pedidos());
  

            txt_Cantidad.Enabled = false;
            cmb_Cotizaciones.Enabled = false;
            cmb_Año.Enabled = false;
            cmb_Productos.Enabled = false;
            txt_numeroPedido.Enabled = false;
            txt_subTotal.Enabled = false;
            txt_CondicionPago.Enabled = false; 


            cmb_cliente.SelectedIndex = -1;
            cmb_Dia.SelectedIndex = -1;
            cmb_Año.SelectedIndex = -1;
            cmb_Cotizaciones.SelectedIndex = -1;
            cmb_Mes.SelectedIndex = -1;
            cmb_Vendedor.SelectedIndex = -1;

            cmb_cliente.Enabled = false;
            cmb_Dia.Enabled = false;
            cmb_Año.Enabled = false;
            cmb_Cotizaciones.Enabled = false;
            cmb_Mes.Enabled = false;
            cmb_Vendedor.Enabled = false;

            chk_agregarDetalles.Enabled = false;
            groupBox1.Visible = false;
            btn_NuevoPedido.Visible = false;
            btn_guardar.Visible = false;
            btn_NuevoDetalle.Visible = false;
        }
        private void Cargar_grilla(DataTable tabla)
        {
            grd_Pedidos.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grd_Pedidos.Rows.Add();
                grd_Pedidos.Rows[i].Cells[0].Value = tabla.Rows[i]["numeroPedido"].ToString();
                grd_Pedidos.Rows[i].Cells[1].Value = tabla.Rows[i]["fechaPedido"].ToString();
                grd_Pedidos.Rows[i].Cells[2].Value = tabla.Rows[i]["cuitCliente"].ToString();
                grd_Pedidos.Rows[i].Cells[3].Value = tabla.Rows[i]["numDniVendedor"].ToString();
                grd_Pedidos.Rows[i].Cells[4].Value = tabla.Rows[i]["condicionPago"].ToString();
            }
        }
        private void Cargar_grilla_Detalle(DataTable tabla)
        {
            grd_Detalles.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                
                grd_Detalles.Rows.Add();
                grd_Detalles.Rows[i].Cells[0].Value = tabla.Rows[i]["numeroPedido"].ToString();
                grd_Detalles.Rows[i].Cells[1].Value = tabla.Rows[i]["codigoProducto"].ToString();
                DataTable tabla2 = new DataTable();
                tabla2 = Producto.Buscar_ProductoPorCodigo(tabla.Rows[i]["codigoProducto"].ToString());
                grd_Detalles.Rows[i].Cells[2].Value = tabla2.Rows[0]["nombre"].ToString();
                grd_Detalles.Rows[i].Cells[4].Value = tabla.Rows[i]["cantidad"].ToString();
                grd_Detalles.Rows[i].Cells[5].Value = tabla.Rows[i]["precio"].ToString();
            }
        }

        private void solicita_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_agregarDetalles.Checked == true)
            {
                if(txt_numeroPedido.Text == "")
                {
                    MessageBox.Show("No se ha seleccionado ningun pedido", "Atencion");
                    chk_agregarDetalles.Checked = false; 
                }
                else
                {
                    DataTable tabla = new DataTable();
                    tabla = Pedido.Buscar_PedidoPorNumero(int.Parse(txt_numeroPedido.Text));

                    if (tabla.Rows.Count > 0)
                    {

                        groupBox1.Visible = true;
                        txt_numeroPedido.Enabled = false;
                        cmb_Año.Enabled = false;
                        cmb_cliente.Enabled = false;
                        cmb_Cotizaciones.Enabled = false;
                        cmb_Mes.Enabled = false;
                        cmb_Dia.Enabled = false;
                        cmb_Vendedor.Enabled = false;
                        txt_CondicionPago.Enabled = false;
                        cmb_Productos.Enabled = true;
                        txt_Cantidad.Enabled = true;
                        btn_guardar.Visible = false;
                        btn_NuevoDetalle.Visible = true;
                        btn_NuevoPedido.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("El pedido Seleccionado no ha sido ingresado aun, Por favor asegurese de ingresar el pedido antes de querer agregar detalles.", "ATENCION");
                        chk_agregarDetalles.Checked = false;
                    }

                }

   
            }
            else
            {
                groupBox1.Visible = false;
                txt_numeroPedido.Enabled = true;
                cmb_Año.Enabled = true;
                cmb_cliente.Enabled = true;
                cmb_Cotizaciones.Enabled = true;
                cmb_Mes.Enabled = true;
                cmb_Dia.Enabled = true;
                cmb_Vendedor.Enabled = true;
                txt_CondicionPago.Enabled = true;

            }

        }

        private void cmb_Vendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_Vendedor.SelectedIndex==-1)
            {
                
            }
            else
            {
                DataTable Vendedor = new DataTable();
                Vendedor= Empleados.Buscar_Empleados(cmb_Vendedor.SelectedValue.ToString());
                EP.tipoDniVendedor = Vendedor.Rows[0]["tipoDoc"].ToString();
            }
            
        }

        private void cmb_Mes_SelectedIndexChanged(object sender, EventArgs e)
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


        private void txt_numeroCotizacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Año_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void grid01_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox1.Visible = false;
            chk_agregarDetalles.Checked = false;
            txt_numeroPedido.Enabled = false;
            txt_CondicionPago.Enabled = true;
       
            cmb_cliente.SelectedIndex = 0;
            cmb_Mes.SelectedIndex = 0;
            cmb_Vendedor.SelectedIndex = 0;

            cmb_cliente.Enabled = true;
            cmb_Dia.Enabled = true;
            cmb_Año.Enabled = true;
            cmb_Cotizaciones.Enabled = true;
            cmb_Mes.Enabled = true;
            cmb_Vendedor.Enabled = true;

            chk_agregarDetalles.Enabled = true;
            btn_guardar.Visible = true;
           
            this.num = grd_Pedidos.CurrentRow.Cells[0].Value.ToString();
            Cargar_grilla_Detalle(Detalle.RecuperarDetallesPedido(this.num));
            DataTable tabla = new DataTable();
            tabla = Pedido.Buscar_PedidoPorNumero(int.Parse(num));
            txt_numeroPedido.Text = tabla.Rows[0]["numeroPedido"].ToString();
            cmb_Cotizaciones.SelectedValue= tabla.Rows[0]["numeroCotizacion"].ToString();
            cmb_Vendedor.SelectedValue = tabla.Rows[0]["numDniVendedor"].ToString();
            cmb_Mes.SelectedItem = Pedido.TraerMes(txt_numeroPedido.Text);
            cmb_Dia.Text = Pedido.TraerDia(txt_numeroPedido.Text).ToString();
            cmb_Año.SelectedItem = Pedido.TraerAño(txt_numeroPedido.Text);
            cmb_cliente.SelectedValue = tabla.Rows[0]["cuitCliente"].ToString();
            txt_CondicionPago.Text = tabla.Rows[0]["condicionPago"].ToString();
            btn_NuevoDetalle.Visible = false;
            btn_NuevoPedido.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pedido.CerrarTransaccion();
            this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cmb_Cotizaciones.Enabled = true;
            txt_numeroPedido.Enabled = true;
            txt_CondicionPago.Enabled = true;
            txt_numeroPedido.Text = "";
            txt_CondicionPago.Text = "";


            cmb_cliente.SelectedIndex = 0;
            cmb_Cotizaciones.SelectedIndex = 0;
            cmb_Mes.SelectedIndex = 0;
            cmb_Vendedor.SelectedIndex = 0;
            cmb_Año.SelectedIndex = 0;

            cmb_cliente.Enabled = true;
            cmb_Dia.Enabled = true;
            cmb_Año.Enabled = true;
            cmb_Mes.Enabled = true;
            cmb_Vendedor.Enabled = true;
            cmb_Cotizaciones.Enabled = true;

            chk_agregarDetalles.Enabled = true;

            btn_NuevoPedido.Visible = true;
            btn_guardar.Visible = false;
            btn_NuevoDetalle.Visible = false;
        }

        private void btn_NuevoDetalle_Click(object sender, EventArgs e)
        {
            Es_DetallePedido _Ed = new Es_DetallePedido();
            DataTable prod = new DataTable();
            _Ed.numeroPedido = txt_numeroPedido.Text;
            _Ed.codigoProducto = cmb_Productos.SelectedValue.ToString();
            prod = Producto.Buscar_ProductoPorCodigo(cmb_Productos.SelectedValue.ToString());
            _Ed.cantidad = txt_Cantidad.Text;
            _Ed.precio = (int.Parse(prod.Rows[0]["precio"].ToString())*int.Parse(txt_Cantidad.Text)).ToString();
            if (int.Parse(prod.Rows[0]["cantStock"].ToString()) >= int.Parse(txt_Cantidad.Text))
            {
                Detalle.Insertar(_Ed);
                Producto.actualizarStock(int.Parse(txt_Cantidad.Text), cmb_Productos.SelectedValue.ToString());               
                Cargar_grilla_Detalle(Detalle.RecuperarDetallesPedido(txt_numeroPedido.Text));
            }
            else
            {
                MessageBox.Show("No hay stock suficiente del producto seleccionado." + "El stock del prodcuto es de: " + prod.Rows[0]["cantStock"].ToString(), "Atencion");
            }
           
        }

        private void txt_Cantidad_TextChanged(object sender, EventArgs e)
        {
            if (txt_Cantidad.Text == "")
            {
                txt_subTotal.Text = "0";

            }
            else
            {
                DataTable prod = new DataTable();
                prod = Producto.Buscar_ProductoPorCodigo(cmb_Productos.SelectedValue.ToString());
                txt_subTotal.Text = (int.Parse(prod.Rows[0]["precio"].ToString()) * int.Parse(txt_Cantidad.Text)).ToString();
            }
        }

        private void grd_Detalles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Desea borrar el detalle?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Detalle.Borrar(txt_numeroPedido.Text,grd_Detalles.CurrentRow.Cells[1].Value.ToString());
                grd_Detalles.Rows.Remove(grd_Detalles.CurrentRow);
            }
        }
    }
}


