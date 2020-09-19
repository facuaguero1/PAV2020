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
    public partial class ModificarEmpleados : Form
    {
        Ng_Localidad Localidad = new Ng_Localidad();
        Ng_Barrios Barrio = new Ng_Barrios();
        Ng_Empleados Empleados = new Ng_Empleados();
        Ng_Tipo_Documentos TipoDoc = new Ng_Tipo_Documentos();
        string EsNull = "";

        public string Doc { get; set; } 
        
        public ModificarEmpleados()
        {
            InitializeComponent();
            CerrarPanel();
            cmb_barrio.Cargar(Barrio.EstructuraCombo());

        }
         private void CerrarPanel ()
        {
            Panel_ModificarCliente.Visible = false;
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
                
                Panel_ModificarCliente.Visible = true;
                this.Doc = grid01.CurrentRow.Cells[0].Value.ToString();
                DataTable tabla = new DataTable();
                tabla = Empleados.RecuperarEmpleados(Doc);

                EsNull = tabla.Rows[0]["numDocJefe"].ToString();

                txt_TipoDoc.Text = tabla.Rows[0]["tipoDoc"].ToString();
                txt_NumDoc.Text = tabla.Rows[0]["numDoc"].ToString();
                txt_Nombre.Text = tabla.Rows[0]["nombre"].ToString();
                txt_Apellido.Text = tabla.Rows[0]["apellido"].ToString();
                txt_Direccion.Text = tabla.Rows[0]["direccion"].ToString();
                cmb_barrio.SelectedValue = int.Parse(tabla.Rows[0]["codBarrio"].ToString());
                txt_Telefono.Text = tabla.Rows[0]["telefono"].ToString();

                if (EsNull == "")
                {
                    cmb_TipoDocJefe.Cargar(TipoDoc.EstructuraCombo());
                    cmb_TipoDocJefe.SelectedValue = -1;
                    txt_NumDocJefe.Text = "";
                    cmb_TipoDocJefe.Enabled = false;
                    txt_NumDocJefe.Enabled = false;
                }
                else
                {
                    cmb_TipoDocJefe.Cargar(TipoDoc.EstructuraCombo());
                    txt_NumDocJefe.Text = tabla.Rows[0]["numDocJefe"].ToString();
                    cmb_TipoDocJefe.Enabled = true;
                    txt_NumDocJefe.Enabled = true;
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
                Cargar_grilla(Empleados.Todos_los_Empleados());
            }
            else
            {
                if (txt_BuscarDoc.Text == "")
                {
                    MessageBox.Show("No se ingreso parametro de busqueda");
                }
                else
                {
                    Cargar_grilla(Empleados.Buscar_Empleados(txt_BuscarDoc.Text));
                }
            }
        }
        private void Cargar_grilla (DataTable tabla)
        {
            grid01.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid01.Rows.Add();
                grid01.Rows[i].Cells[0].Value = tabla.Rows[i]["numDoc"].ToString();
                grid01.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre"].ToString();
                grid01.Rows[i].Cells[2].Value = tabla.Rows[i]["apellido"].ToString();
                grid01.Rows[i].Cells[3].Value = tabla.Rows[i]["direccion"].ToString();
                grid01.Rows[i].Cells[4].Value = tabla.Rows[i]["codBarrio"].ToString();
                grid01.Rows[i].Cells[5].Value = tabla.Rows[i]["telefono"].ToString();

            }
        }
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_BuscarDoc.Text = "";
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_Empleados _EE = new Es_Empleados();
            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                _EE.numDoc = txt_NumDoc.Text;
                _EE.nombre = txt_Nombre.Text;
                _EE.apellido = txt_Apellido.Text;
                _EE.direccion = txt_Direccion.Text;
                _EE.codBarrio= cmb_barrio.SelectedValue.ToString();
                _EE.telefono = txt_Telefono.Text;
                if (EsNull == "")
                {
                    _EE.tipoDocJefe = null;
                    _EE.numDocJefe = null;
                    Empleados.Modificar(_EE);
                    Panel_ModificarCliente.Visible = false;

                }
                else
                {
                    _EE.tipoDocJefe = cmb_TipoDocJefe.SelectedValue.ToString();
                    _EE.numDocJefe = txt_NumDocJefe.Text;
                    Empleados.Modificar(_EE);
                    Panel_ModificarCliente.Visible = false;
                }
                     
                
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
           cmb_TipoDocJefe.SelectedIndex = -1;
        }
    }
}
