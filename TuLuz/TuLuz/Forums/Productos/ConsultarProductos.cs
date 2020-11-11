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
    public partial class ConsultarProductos : Form
    {
        Ng_Producto Producto = new Ng_Producto();
        Ng_Proveedor Proveedores = new Ng_Proveedor();
        Ng_DetalleProducto DetalleProducto = new Ng_DetalleProducto();

        public string Doc { get; set; } 
        
        public ConsultarProductos()
        {
            InitializeComponent();
            CerrarPanel();
            cmb_cuitProveedor.Cargar(Proveedores.EstructuraCombo());
        }
         private void CerrarPanel ()
        {
            Panel_ConsultarProducto.Visible = false;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {

            grd_DetalleComponente.Rows.Clear();
            grp_detalle_compo.Visible = true;
            if (this.grid01.Rows.Count == 0)
            {
                MessageBox.Show("No selecciono ningun registro de la grilla","Importante",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                
                Panel_ConsultarProducto.Visible = true;
                this.Doc = grid01.CurrentRow.Cells[0].Value.ToString();
                DataTable tabla = new DataTable();
                tabla = Producto.Buscar_ProductoPorCodigo(Doc);
                

                txt_codigo.Text = tabla.Rows[0]["codProducto"].ToString();
                txt_nombre.Text = tabla.Rows[0]["nombre"].ToString();
                txt_descripcion.Text = tabla.Rows[0]["descripcion"].ToString();
                txt_cantStock.Text = tabla.Rows[0]["cantStock"].ToString();
                txt_precio.Text = tabla.Rows[0]["precio"].ToString();
                cmb_cuitProveedor.SelectedValue =tabla.Rows[0]["cuitProveedor"].ToString();
                txt_codProductoEq.Text = tabla.Rows[0]["codProductoEq"].ToString();

                DataTable tabla_Detalle = new DataTable();
                tabla_Detalle = DetalleProducto.RecuperarDetallesProducto(int.Parse(txt_codigo.Text));
                if (tabla_Detalle.Rows.Count > 0)
                {
                    DataTable tabla2 = new DataTable();

                    for (int i = 0; i < tabla_Detalle.Rows.Count; i++)
                    {
                        tabla2 = Producto.Buscar_ProductoPorCodigo(tabla_Detalle.Rows[i]["codProductoComponente"].ToString());
                        grd_DetalleComponente.Rows.Add();
                        grd_DetalleComponente.Rows[i].Cells[0].Value = tabla2.Rows[0]["nombre"].ToString();
                        grd_DetalleComponente.Rows[i].Cells[1].Value = tabla_Detalle.Rows[i]["cantidad"].ToString();
                        grd_DetalleComponente.Rows[i].Cells[2].Value = tabla2.Rows[0]["precio"].ToString();
                        grd_DetalleComponente.Rows[i].Cells[3].Value = tabla_Detalle.Rows[i]["precio"].ToString();
                    }
                }
                else
                {
                    grp_detalle_compo.Visible = false;
                }
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
                Cargar_grilla(Producto.Todos_los_Productos());
            }
            else
            {
                if (txt_BuscarDoc.Text == "")
                {
                    MessageBox.Show("No se ingreso parametro de busqueda");
                }
                else
                {
                    Cargar_grilla(Producto.Buscar_ProductoPorCodigo(txt_BuscarDoc.Text));
                }
            }
        }
        private void Cargar_grilla (DataTable tabla)
        {
            grid01.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid01.Rows.Add();
                grid01.Rows[i].Cells[0].Value = tabla.Rows[i]["codProducto"].ToString();
                grid01.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre"].ToString();
                grid01.Rows[i].Cells[2].Value = tabla.Rows[i]["descripcion"].ToString();
                grid01.Rows[i].Cells[3].Value = tabla.Rows[i]["precio"].ToString();
                grid01.Rows[i].Cells[4].Value = tabla.Rows[i]["cantStock"].ToString();
                grid01.Rows[i].Cells[5].Value = tabla.Rows[i]["cuitProveedor"].ToString();
                grid01.Rows[i].Cells[6].Value = tabla.Rows[i]["codProductoEq"].ToString();

            }
        }
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_BuscarDoc.Text = "";
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            Panel_ConsultarProducto.Visible = false;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
