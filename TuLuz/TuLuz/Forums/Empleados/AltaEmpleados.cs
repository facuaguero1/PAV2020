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
    public partial class AltaEmpleados : Form
    {
        Ng_Empleados Empleado = new Ng_Empleados();
        Ng_Barrios Barrio = new Ng_Barrios();
        Ng_Tipo_Documentos TipoDoc = new Ng_Tipo_Documentos();
        Ng_Users Usuario = new Ng_Users();
        Ng_Provincias Provincia = new Ng_Provincias();
        Ng_Localidad Localidad = new Ng_Localidad();

        Be_BaseDatos _BD = new Be_BaseDatos();

        public AltaEmpleados()
        {
            InitializeComponent();
            //cmb_Barrio.Cargar(Barrio.EstructuraCombo());
            cmb_provincia.Cargar(Provincia.EstructuraCombo());
            cmb_Tipo_Doc.Cargar(TipoDoc.EstructuraCombo());
            cmb_Tipo_Doc_Jefe.Cargar(TipoDoc.EstructuraCombo());
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_Empleados _Ee = new Es_Empleados();
            DataTable Verificacion = new DataTable();
            
            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                _Ee.tipoDoc = cmb_Tipo_Doc.SelectedValue.ToString();
                _Ee.numDoc = txt_Num_Doc.Text;
                _Ee.nombre = txt_nombreEmpleado.Text;
                _Ee.apellido = txt_ApellidoEmpleado.Text;
                _Ee.direccion = txt_Direccion.Text;
                _Ee.codBarrio = cmb_Barrio.SelectedValue.ToString();
                _Ee.telefono = txt_Telefono.Text;
                _Ee.tipoDocJefe = cmb_Tipo_Doc.SelectedValue.ToString();
                _Ee.numDocJefe = txt_Num_Doc_Jefe.Text;
                //string codProv = cmb_provincia.SelectedValue.ToString();
                //cmb_localidad.Cargar(Localidad.EstructuraComboCOD(codProv));
                _Ee.activo = "true";
                if (txt_Num_Doc_Jefe.Text=="")
                {
                    _Ee.tipoDocJefe = "NULL";
                    _Ee.numDocJefe = "NULL";
                }
                else
                {
                    _Ee.tipoDocJefe = cmb_Tipo_Doc.SelectedValue.ToString();
                    _Ee.numDocJefe = txt_Num_Doc_Jefe.Text;
                }
                Verificacion = Empleado.Buscar_Empleados(_Ee.numDoc);
                if (Verificacion.Rows.Count > 0)
                {

                    MessageBox.Show("El Empleado que desea insertar ya existe. ", "ATENCION");

                }
                else
                {
                    Empleado.Insertar(_Ee);
                    if (chk_usr.Checked == true)
                    {
                        Es_Usuario user = new Es_Usuario();
                        user.usuario = txt_user.Text;
                        user.password = txt_pass.Text;
                        user.numDocEmpleado = txt_Num_Doc.Text;
                        Usuario.Insertar(user);
                    }
                    this.Close();
                }
            }

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limpiar_campo_Click(object sender, EventArgs e)
        {
            cmb_Tipo_Doc_Jefe.SelectedIndex = -1;
        }

        private void brn_Load(object sender, EventArgs e)
        {
            grp_usr.Visible = false;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (grp_usr.Visible == true)
            {
                grp_usr.Visible = false;
            }
            else
            {
                grp_usr.Visible = true;
            }
        }

        private void cmb_provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_provincia.SelectedIndex == -1)
            {

            }
            else
            {
                cmb_localidad.Cargar(new EstructuraComboBox());
                cmb_localidad.Cargar(Localidad.EstructuraComboEspecial(int.Parse(cmb_provincia.SelectedValue.ToString())));
            }
            cmb_localidad.SelectedIndex = -1;

        }

        private void cmb_localidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_localidad.SelectedIndex == -1)
            {

            }
            else
            {
                cmb_Barrio.Cargar(new EstructuraComboBox());
                cmb_Barrio.Cargar(Barrio.EstructuraComboEspecial(int.Parse(cmb_localidad.SelectedValue.ToString())));
            }
            cmb_Barrio.SelectedIndex = -1;
        }

        private void txt_Num_Doc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
