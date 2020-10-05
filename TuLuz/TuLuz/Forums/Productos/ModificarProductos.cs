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
    public partial class ModificarProductos : Form
    {
        Ng_Producto Productos = new Ng_Producto();
        Ng_Proveedor Proveedores = new Ng_Proveedor();
        Ng_DetalleProducto Detalle = new Ng_DetalleProducto();
        public string codigo { get; set; } 
        
        public ModificarProductos()
        {
            InitializeComponent();
            CerrarPanel();
           
            cmb_cuitProveedor.Cargar(Proveedores.EstructuraCombo());
            cmb_codProductoEq.Cargar(Productos.EstructuraCombo());
            

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
                this.codigo = grid01.CurrentRow.Cells[0].Value.ToString();
                DataTable tabla = new DataTable();
                DataTable tabla2 = new DataTable();
                tabla = Productos.Buscar_ProductoPorCodigo(codigo);
                tabla2 = Detalle.RecuperarDetallesProducto(int.Parse(codigo));
                if (tabla2.Rows.Count > 0 )

                {
                    btn_ModificarDetalle.Visible = true;
                }
                else
                {
                    btn_ModificarDetalle.Visible = false;
                }

                txt_codigo.Text = tabla.Rows[0]["codProducto"].ToString();
                txt_nombre.Text = tabla.Rows[0]["nombre"].ToString();
                txt_descripcion.Text = tabla.Rows[0]["descripcion"].ToString();
                txt_precio.Text = tabla.Rows[0]["precio"].ToString();
                txt_cantStock.Text = tabla.Rows[0]["cantStock"].ToString();
                cmb_cuitProveedor.SelectedValue = tabla.Rows[0]["cuitProveedor"].ToString();
                if (tabla.Rows[0]["codProductoEq"].ToString()=="")
                {
                    cmb_codProductoEq.SelectedIndex = -1;
                }
                else
                {
                    cmb_codProductoEq.SelectedValue = int.Parse(tabla.Rows[0]["codProductoEq"].ToString());

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
                Cargar_grilla(Productos.Todos_los_Productos());
            }
            else
            {
                if (txt_buscarCodigo.Text == "")
                {
                    MessageBox.Show("No se ingreso parametro de busqueda");
                }
                else
                {
                    Cargar_grilla(Productos.Buscar_ProductoPorCodigo(txt_buscarCodigo.Text));
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
            txt_buscarCodigo.Text = "";
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_Producto _EP = new Es_Producto();

            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                _EP.codProducto = txt_codigo.Text;
                _EP.nombre = txt_nombre.Text;
                _EP.descripcion = txt_descripcion.Text;
                _EP.precio = txt_precio.Text;
                _EP.cuitProveedor= cmb_cuitProveedor.SelectedValue.ToString();
                _EP.cantStock = txt_cantStock.Text;
                if (cmb_codProductoEq.SelectedIndex == -1)
                {
                    _EP.codProductoEq = "NULL";
                }
                else
                {
                    _EP.codProductoEq = cmb_codProductoEq.SelectedValue.ToString();
                }
                Productos.Modificar(_EP);
                Cargar_grilla(Productos.Todos_los_Productos());
                CerrarPanel();



            }
            
        }
        private void btn_limpiarr_Click(object sender, EventArgs e)
        {
           cmb_codProductoEq.SelectedIndex = -1;
        }

        private void btn_ModificarDetalle_Click(object sender, EventArgs e)
        {
            ModificarDetalle modDetalle = new ModificarDetalle(txt_codigo.Text);
            AbrirFormularioSubMenu(modDetalle);
            CerrarPanel();
        }

        public void AbrirFormularioSubMenu(Form FormularioSubMenu)
        {
            //this.SendToBack();      //si existe un formulario abierto, lo cerramos 
            FormularioSubMenu.TopLevel = true;
            FormularioSubMenu.FormBorderStyle = FormBorderStyle.None;   //sin bordes
            FormularioSubMenu.Dock = DockStyle.Fill;    //para rellenar formulario en el centro
            FormularioSubMenu.BringToFront(); //traer el formulario por delante de la imagen de fondo
            FormularioSubMenu.Show() ; //ejecutar formulario

        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
