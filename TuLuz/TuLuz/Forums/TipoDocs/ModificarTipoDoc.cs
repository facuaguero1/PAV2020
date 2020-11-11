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
    public partial class ModificarTipoDoc : Form
    {
        Ng_Tipo_Documentos Documentos = new Ng_Tipo_Documentos();
        public string id { get; set; } 
        
        public ModificarTipoDoc()
        {
            InitializeComponent();
            CerrarPanel();  
        }
         private void CerrarPanel ()
        {
            Panel_ModificarIdTipoDoc.Visible = false;
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
 
                Panel_ModificarIdTipoDoc.Visible = true;
                this.id = grid01.CurrentRow.Cells[0].Value.ToString();
                DataTable tabla = new DataTable();
                tabla = Documentos.Buscar_TiposDoc_Codigo(id);
                txt_idTipoDoc.Text = tabla.Rows[0]["idTipoDoc"].ToString();
                txt_NombreNuevo.Text = tabla.Rows[0]["nombre"].ToString();
                textSiglas.Text = tabla.Rows[0]["siglas"].ToString();
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
                Cargar_grilla(Documentos.Todos_las_Tipos_Doc());
            }
            else
            {
                if (txt_BuscarCuit.Text == "")
                {
                    MessageBox.Show("No se ingreso parametro de busqueda");
                }
                else
                {
                    Cargar_grilla(Documentos.Buscar_TiposDoc_Codigo(txt_BuscarCuit.Text));
                }
            }
        }
        private void Cargar_grilla (DataTable tabla)
        {
            grid01.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid01.Rows.Add();
                grid01.Rows[i].Cells[0].Value = tabla.Rows[i]["idTipoDoc"].ToString();
                grid01.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre"].ToString();
                grid01.Rows[i].Cells[2].Value = tabla.Rows[i]["siglas"].ToString();
            }
        }
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_BuscarCuit.Text = "";
        }
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_TipoDocs Docs = new Es_TipoDocs();
            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                Docs.idTipoDoc = txt_idTipoDoc.Text;
                Docs.nombre = txt_NombreNuevo.Text;
                Docs.siglas = textSiglas.Text;

                Documentos.Modificar(Docs);
                Panel_ModificarIdTipoDoc.Visible = false;
            }
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txt_BuscarCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
