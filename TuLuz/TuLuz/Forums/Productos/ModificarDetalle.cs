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
    public partial class ModificarDetalle : Form
    {
        Ng_Producto Productos = new Ng_Producto();
        Ng_DetalleProducto Detalle = new Ng_DetalleProducto();
        public int salir = 0;
        public string codigo { get; set; } 
        
        public ModificarDetalle(string cod)
        {
            InitializeComponent();
            CerrarPanel();
            codigo = cod;
        }
         private void CerrarPanel ()
        {
            Panel_ModificarProducto.Visible = false;
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
                Panel_ModificarProducto.Visible = true;
                DataTable tabla = new DataTable();
                tabla = Detalle.RecuperarDetallesProductoEspecifico(grid01.CurrentRow.Cells[0].Value.ToString(), grid01.CurrentRow.Cells[1].Value.ToString());

                txt_producto.Text = tabla.Rows[0]["codProductoGenerico"].ToString();
                txt_componente.Text = tabla.Rows[0]["codProductoComponente"].ToString();
                txt_cantidad.Text = tabla.Rows[0]["cantidad"].ToString();
                txt_precio.Text = tabla.Rows[0]["precio"].ToString();
            }
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            CerrarPanel();
        }

        private void Cargar_grilla (DataTable tabla)
        {
            DataTable tabla2 = new DataTable();
            grid01.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                tabla2 = Productos.Buscar_ProductoPorCodigo(tabla.Rows[i]["codProductoComponente"].ToString());
                grid01.Rows.Add();
                grid01.Rows[i].Cells[0].Value = tabla.Rows[i]["codProductoGenerico"].ToString();
                grid01.Rows[i].Cells[1].Value = tabla.Rows[i]["codProductoComponente"].ToString();
                grid01.Rows[i].Cells[2].Value = tabla2.Rows[0]["nombre"].ToString();
                grid01.Rows[i].Cells[3].Value = tabla.Rows[i]["cantidad"].ToString();
                
                grid01.Rows[i].Cells[4].Value = tabla.Rows[i]["precio"].ToString();
            }
        }
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_DetalleProducto _DP = new Es_DetalleProducto();

            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                _DP.codigoProducto = txt_producto.Text;
                _DP.CodigoComponente = txt_componente.Text;
                _DP.cantidad = txt_cantidad.Text;
                _DP.precio = txt_precio.Text;

                Detalle.Modificar(_DP);
                Cargar_grilla(Detalle.RecuperarDetallesProducto(int.Parse(codigo)));
                CerrarPanel();
            }
        }
        private void ModificarDetalle_Load(object sender, EventArgs e)
        {
            Cargar_grilla(Detalle.RecuperarDetallesProducto(int.Parse(codigo)));
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txt_cantidad_TextChanged(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = Productos.Buscar_ProductoPorCodigo(txt_componente.Text);
            if (txt_cantidad.Text == "")
            {
                txt_precio.Text = "0";
                txt_cantidad.Text = "0";
            }
            else
            {
                txt_precio.Text = (int.Parse(tabla.Rows[0]["precio"].ToString()) * int.Parse(txt_cantidad.Text)).ToString(); 
            }
        }
    }
}
