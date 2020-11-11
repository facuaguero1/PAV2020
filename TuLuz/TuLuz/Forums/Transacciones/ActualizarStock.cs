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
    public partial class ActualizarStock : Form
    {
        Ng_Producto Producto = new Ng_Producto();

        public string num { get; set; }

        public ActualizarStock()
        {
            InitializeComponent();

        }
        private void ActualizarStock_Load(object sender, EventArgs e)
        {
            Producto.IniciarTransaccion();
            Cargar_grilla(Producto.Todos_los_Productos());
            txt_agregar.Enabled = false;
            txt_cantStock.Enabled = false;
            txt_codigo.Enabled = false;
            txt_nombre.Enabled = false;
            txt_total.Enabled = false;
        }
        private void Cargar_grilla(DataTable tabla)
        {
            grid01.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid01.Rows.Add();
                grid01.Rows[i].Cells[0].Value = tabla.Rows[i]["codProducto"].ToString();
                grid01.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre"].ToString();
                grid01.Rows[i].Cells[2].Value = tabla.Rows[i]["cantStock"].ToString();
            }
        }

        private void grid01_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_agregar.Enabled = true;
            txt_agregar.Text = "";
            this.num = grid01.CurrentRow.Cells[0].Value.ToString();
            DataTable tabla = new DataTable();
            tabla = Producto.Buscar_ProductoPorCodigo(num);
            txt_codigo.Text = tabla.Rows[0]["codProducto"].ToString();
            txt_cantStock.Text= tabla.Rows[0]["cantStock"].ToString();
            txt_nombre.Text= tabla.Rows[0]["nombre"].ToString();
           
        }
        private void txt_agregar_TextChanged(object sender, EventArgs e)
        {
            if (txt_agregar.Text == "")
            {
                txt_total.Text = txt_cantStock.Text;
            }
            else
            {
              txt_total.Text = (int.Parse(txt_cantStock.Text) + int.Parse(txt_agregar.Text)).ToString();
            }
            
        }

        private void txt_agregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Producto.sumarStock(int.Parse(txt_agregar.Text), txt_codigo.Text);
            Cargar_grilla(Producto.Todos_los_Productos());
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Producto.CerrarTransaccion();
            this.Close();
        }
    }
}

