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
using TuLuz.Clases;
using TuLuz.Negocio;

namespace TuLuz.Forums
{
    public partial class VerPerfil : Form
    {
        string usuario { set; get; }

        public VerPerfil(string str)
        {
            usuario = str;
            InitializeComponent();
        }
        public void Cargar()
        {
            Ng_Empleados Empleado = new Ng_Empleados();
            Ng_Barrios Barrio = new Ng_Barrios();
            DataTable tablaBarrio = new DataTable();
            DataTable tabla = new DataTable();
            tabla = Empleado.Buscar_Empleados_Usuario(usuario);
            tablaBarrio = Barrio.Buscar_Barrio_Codigo(tabla.Rows[0]["codBarrio"].ToString());

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                string tDoc = tabla.Rows[0]["tipoDoc"].ToString();
                if (tDoc == "1")
                    txt_tipodoc.Text = "DNI";
                txt_numdoc.Text = tabla.Rows[0]["numDoc"].ToString();
                txt_nombre.Text = tabla.Rows[0]["nombre"].ToString();
                txt_apellido.Text = tabla.Rows[0]["apellido"].ToString();
                txt_direccion.Text = tabla.Rows[0]["direccion"].ToString();
                txt_barrio.Text = tablaBarrio.Rows[0]["nombre"].ToString();
                txt_telefono.Text = tabla.Rows[0]["telefono"].ToString();
                string jefe = tabla.Rows[0]["numDocJefe"].ToString();
                
                if (jefe == "")
                {
                    textRango.Text = "Jefe";
                }
                else
                {
                    textRango.Text = "Subordinado";
                }

                if (textRango.Text == "Subordinado")
                {
                    groupJefe.Visible = true;
                    DataTable tabla2 = new DataTable();
                    tabla2 = Empleado.Buscar_Empleados(tabla.Rows[0]["numDocJefe"].ToString());
                    txt_NumDocJefe.Text = tabla.Rows[0]["numDocJefe"].ToString();
                    txt_nombreJefe.Text = tabla2.Rows[0]["nombre"].ToString();
                    txt_apellidoJefe.Text = tabla2.Rows[0]["apellido"].ToString();
                }
            }
           
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VerPerfil_Load(object sender, EventArgs e)
        {
            groupJefe.Visible = false;
            Cargar();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
    
}
