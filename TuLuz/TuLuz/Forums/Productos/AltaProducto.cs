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
    public partial class AltaProducto : Form
    {
        Ng_Proveedor Proveedor = new Ng_Proveedor();
        Ng_Producto Producto = new Ng_Producto();
        Ng_DetalleProducto Detalle = new Ng_DetalleProducto();


        Be_BaseDatos _BD = new Be_BaseDatos();

        public AltaProducto()
        {
            InitializeComponent();
            cmb_Proveedor.Cargar(Proveedor.EstructuraCombo());
            cmb_Producto.Cargar(Producto.EstructuraCombo());
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
            cmb_Componente.Cargar(Producto.EstructuraCombo());
            grdDetalle.Rows.Clear();
            cmb_Producto.SelectedIndex = -1;
        }
        private void Cargar_grilla(DataTable tabla)
        {
            grdDetalle.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grdDetalle.Rows.Add();
                grdDetalle.Rows[i].Cells[0].Value = tabla.Rows[i]["codProductoGenerico"].ToString();
                grdDetalle.Rows[i].Cells[1].Value = tabla.Rows[i]["codProductoComponente"].ToString();
                grdDetalle.Rows[i].Cells[2].Value = tabla.Rows[i]["cantidad"].ToString();
                grdDetalle.Rows[i].Cells[3].Value = tabla.Rows[i]["Precio"].ToString();
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            DataTable Consulta = new DataTable();
            Consulta = Producto.Buscar_ProductoPorCodigo(txt_codProd.Text);
           if (Consulta.Rows.Count > 0)
            {
                Es_DetalleProducto _ED = new Es_DetalleProducto();
                _ED.codigoProducto = txt_codProd.Text;
                _ED.CodigoComponente = cmb_Componente.SelectedValue.ToString();
                _ED.cantidad = txt_CantComp.Text;
                _ED.precio = txt_Subtotal.Text;
                Detalle.Insertar(_ED);
                Cargar_grilla(Detalle.RecuperarDetallesProducto(int.Parse(txt_codProd.Text)));
                txt_CantComp.Text = "";
                txt_Precio.Text = "";
                txt_Subtotal.Text = "";
            }
            else
            {
                MessageBox.Show("Primero debe crear al producto", "Atencion");
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked == true)
            {
                if (txt_codProd.Text == "")
                {
                    checkBox2.Checked = false;
                    MessageBox.Show("Primero debe insertar el codigo del Producto a agregar", "Atencion");

                }
                else
                {
                    grp_detalle.Visible = true;
                    txt_Producto.Text = txt_codProd.Text;
                    txt_codProd.Enabled = false;
                    txt_nombre.Enabled = false;
                    txt_Desc.Enabled = false;
                    txt_Precio.Enabled = false;
                    txt_Stock.Enabled = false;
                    cmb_Proveedor.Enabled = false;
                    cmb_Producto.Enabled = false;
                    btn_crearProducto.Enabled = false;
                    button2.Enabled = false;

                }
            } 
            else
            {
                grp_detalle.Visible = false;
                txt_codProd.Enabled = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            cmb_Producto.SelectedIndex = -1;
        }
        private void btn_crearProducto_Click(object sender, EventArgs e)
        {

            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_Producto _Ee = new Es_Producto();
            DataTable Verificacion = new DataTable();


            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                _Ee.codProducto = txt_codProd.Text;
                _Ee.nombre = txt_nombre.Text;
                _Ee.descripcion = txt_Desc.Text;
                _Ee.precio = txt_Precio.Text;
                _Ee.cantStock = txt_Stock.Text;
                _Ee.cuitProveedor = cmb_Proveedor.SelectedValue.ToString();
                if (cmb_Producto.SelectedValue == null)
                {
                    _Ee.codProductoEq = "NULL";
                }
                else
                {
                    _Ee.codProductoEq = cmb_Producto.SelectedValue.ToString();
                }
                Verificacion = Producto.Buscar_ProductoPorCodigo(_Ee.codProducto);
                if (Verificacion.Rows.Count > 0)
                {
                    MessageBox.Show("El Producto que desea insertar ya existe. ", "ATENCION");
                }
                else
                {
                    Producto.Insertar(_Ee);
                    txt_nombre.Enabled = false;
                    txt_Desc.Enabled = false;
                    txt_Precio.Enabled = false;
                    txt_Stock.Enabled = false;
                    cmb_Proveedor.Enabled = false;
                    cmb_Producto.Enabled = false;
                    btn_crearProducto.Enabled = false;
                    button2.Enabled = false;
                    checkBox2.Checked = true;
                }
            }
        }
        private void txt_codProd_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt_Stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_CantComp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_CantComp_TextChanged(object sender, EventArgs e)
        {
            int precio = Producto.cuantoVale(cmb_Componente.SelectedValue.ToString());
            if (txt_CantComp.Text == "")
            {

            }
            else
            {
                txt_Subtotal.Text = (int.Parse(txt_CantComp.Text) * precio).ToString();
            }   
        }
    }
}
