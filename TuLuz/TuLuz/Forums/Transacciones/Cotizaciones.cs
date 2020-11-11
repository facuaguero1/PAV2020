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
    public partial class Cotizaciones : Form
    {
        Ng_Cotizaciones Cotizacion = new Ng_Cotizaciones();
        Ng_Empleados Empleados = new Ng_Empleados();
        Ng_Clientes Clientes = new Ng_Clientes();
        Es_Cotizaciones _Ec = new Es_Cotizaciones();
        Ng_EstadosCotizaciones EstadosCot = new Ng_EstadosCotizaciones();

        public string num { get; set; }

        public Cotizaciones()
        {
            InitializeComponent();

            cmb_cliente.Cargar(Clientes.EstructuraCombo());
            cmb_Vendedor.Cargar(Empleados.EstructuraCombo());
            cmb_Estado.Cargar(EstadosCot.EstructuraCombo());
            groupBox1.Visible = false;
        }
        private void Cotizaciones_Load(object sender, EventArgs e)
        {
            Cotizacion.IniciarTransaccion();
            Cargar_grilla(Cotizacion.Todas_Las_Cotizciones());

            txt_ApellidoSolicitante.Enabled = false;
            txt_Año.Enabled = false;
            txt_Año2.Enabled = false;
            txt_nombreSolicitante.Enabled = false;
            txt_numeroCotizacion.Enabled = false;
            txt_Observaciones.Enabled = false;
            txt_Precio.Enabled = false;

            cmb_cliente.SelectedIndex = -1;
            cmb_Dia.SelectedIndex = -1;
            cmb_Estado.SelectedIndex = -1;
            cmb_Mes.SelectedIndex = -1;
            cmb_Vendedor.SelectedIndex = -1;

            cmb_cliente.Enabled = false;
            cmb_Dia.Enabled = false;
            cmb_Estado.Enabled = false;
            cmb_Mes.Enabled = false;
            cmb_Vendedor.Enabled = false;

            solicita.Enabled = false;

            btn_aceptar_cotizacion.Visible = false;
            btn_guardar_cotizacion.Visible = false;
        }
        private void Cargar_grilla(DataTable tabla)
        {
            grid01.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid01.Rows.Add();
                grid01.Rows[i].Cells[0].Value = tabla.Rows[i]["numeroCotizacion"].ToString();
                grid01.Rows[i].Cells[1].Value = tabla.Rows[i]["fecha"].ToString();
                grid01.Rows[i].Cells[2].Value = tabla.Rows[i]["cuitCliente"].ToString();
                grid01.Rows[i].Cells[3].Value = tabla.Rows[i]["numDocVendedor"].ToString();
                grid01.Rows[i].Cells[4].Value = tabla.Rows[i]["codEstadoCotizacion"].ToString();
                grid01.Rows[i].Cells[5].Value = tabla.Rows[i]["precioTotal"].ToString();
            }
        }
        private void solicita_CheckedChanged(object sender, EventArgs e)
        {
            if (solicita.Checked == true)
            {
                if (cmb_cliente.SelectedIndex == -1)
                {
                    MessageBox.Show("Primero debe seleccionar un cliente", "Atencion");
                }
                else
                {
                    DataTable Vendedor = new DataTable();
                    Vendedor = Clientes.Buscar_ClienteMasBajos(cmb_cliente.SelectedValue.ToString());
                    txt_nombreSolicitante.Enabled = false;
                    txt_ApellidoSolicitante.Enabled = false;
                    txt_ApellidoSolicitante.Text = Vendedor.Rows[0]["apellido"].ToString();
                    txt_nombreSolicitante.Text = Vendedor.Rows[0]["nombre"].ToString();
                }
            }
            else
            {
                txt_nombreSolicitante.Enabled = true;
                txt_ApellidoSolicitante.Enabled = true;
            }
        }
        private void txt_Año_TextChanged(object sender, EventArgs e)
        {
            txt_Año2.Text = txt_Año.Text;
        }

        private void cmb_Vendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Vendedor.SelectedIndex == -1)
            {

            }
            else
            {
                DataTable Vendedor = new DataTable();
                Vendedor = Empleados.Buscar_Empleados(cmb_Vendedor.SelectedValue.ToString());
                _Ec.tipoDocVendedor = Vendedor.Rows[0]["tipoDoc"].ToString();
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

        private void cmb_Estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Estado.SelectedValue == null)
            {
                groupBox1.Visible = false;
            }
            else
            {
                if (cmb_Estado.SelectedValue.ToString() == "5")
                {
                    groupBox1.Visible = true;
                }
                else
                {
                    groupBox1.Visible = false;
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
        private void btn_ingresar_cotizacion_Click(object sender, EventArgs e)
        {
            txt_ApellidoSolicitante.Enabled = true;
            txt_Año.Enabled = true;
            txt_nombreSolicitante.Enabled = true;
            txt_numeroCotizacion.Enabled = true;
            txt_Observaciones.Enabled = true;
            txt_Precio.Enabled = true;

            txt_ApellidoSolicitante.Text = "";
            txt_Año.Text = "";
            txt_Año2.Text = "";
            txt_nombreSolicitante.Text = "";
            txt_numeroCotizacion.Text = "";
            txt_Observaciones.Text = "";
            txt_Precio.Text = "";

            cmb_cliente.SelectedIndex = 0;
            cmb_Estado.SelectedIndex = 0;
            cmb_Mes.SelectedIndex = 0;
            cmb_Vendedor.SelectedIndex = 0;

            cmb_cliente.Enabled = true;
            cmb_Dia.Enabled = true;
            cmb_Estado.Enabled = true;
            cmb_Mes.Enabled = true;
            cmb_Vendedor.Enabled = true;

            solicita.Enabled = true;

            btn_aceptar_cotizacion.Visible = true;
            btn_guardar_cotizacion.Visible = false;
        }
        private void grid01_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ApellidoSolicitante.Enabled = true;
            txt_Año.Enabled = false;
            txt_nombreSolicitante.Enabled = true;
            txt_numeroCotizacion.Enabled = false;
            txt_Observaciones.Enabled = true;
            txt_Precio.Enabled = true;

            txt_ApellidoSolicitante.Text = "";
            txt_Año.Text = "";
            txt_Año2.Text = "";
            txt_nombreSolicitante.Text = "";
            txt_numeroCotizacion.Text = "";
            txt_Observaciones.Text = "";
            txt_Precio.Text = "";


            cmb_cliente.SelectedIndex = 0;
            cmb_Estado.SelectedIndex = 0;
            cmb_Mes.SelectedIndex = 0;
            cmb_Vendedor.SelectedIndex = 0;

            cmb_cliente.Enabled = true;
            cmb_Dia.Enabled = true;
            cmb_Estado.Enabled = true;
            cmb_Mes.Enabled = true;
            cmb_Vendedor.Enabled = true;

            solicita.Enabled = true;

            this.num = grid01.CurrentRow.Cells[0].Value.ToString();
            DataTable tabla = new DataTable();
            tabla = Cotizacion.Buscar_Cotizcion(num);

            txt_numeroCotizacion.Text = tabla.Rows[0]["numeroCotizacion"].ToString();
            txt_Año.Text = tabla.Rows[0]["año"].ToString();
            cmb_Estado.SelectedValue = tabla.Rows[0]["codEstadoCotizacion"].ToString();
            cmb_Vendedor.SelectedValue = tabla.Rows[0]["numDocVendedor"].ToString();
            txt_ApellidoSolicitante.Text = tabla.Rows[0]["apellidoSolicitante"].ToString();
            txt_Precio.Text = tabla.Rows[0]["precioTotal"].ToString();
            cmb_Mes.SelectedItem = Cotizacion.TraerMes(txt_numeroCotizacion.Text);
            cmb_Dia.Text = Cotizacion.TraerDia(txt_numeroCotizacion.Text);
            txt_nombreSolicitante.Text = tabla.Rows[0]["nombreSolicitante"].ToString();
            txt_motivoPerdida.Text = tabla.Rows[0]["motivoPerdida"].ToString();
            txt_Competidor.Text = tabla.Rows[0]["nomCompetidor"].ToString();
            txt_Observaciones.Text = tabla.Rows[0]["observaciones"].ToString();

            btn_guardar_cotizacion.Visible = true;
            btn_aceptar_cotizacion.Visible = false;
        }


        private void btn_guardar_cotizacion_Click(object sender, EventArgs e)
        {
            
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_Cotizaciones _Ec = new Es_Cotizaciones();
            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                DataTable tabla = new DataTable();
                tabla = Cotizacion.Buscar_Cotizcion(txt_numeroCotizacion.Text);
                _Ec.numeroCotizacicon = txt_numeroCotizacion.Text;
                _Ec.año = txt_Año.Text;
                _Ec.cuitCliente = cmb_cliente.SelectedValue.ToString();
                _Ec.numDocVendedor = cmb_Vendedor.SelectedValue.ToString();
                _Ec.codEstadoCotizacion = cmb_Estado.SelectedValue.ToString();
                _Ec.nombreSolicitante = txt_nombreSolicitante.Text;
                _Ec.tipoDocVendedor = tabla.Rows[0]["tipoDocVendedor"].ToString();
                _Ec.apellidoSolicitante = txt_ApellidoSolicitante.Text;
                _Ec.observaciones = txt_Observaciones.Text;
                _Ec.fecha = cmb_Dia.SelectedItem.ToString() + "/" + cmb_Mes.SelectedItem.ToString() + "/" + txt_Año2.Text;
                _Ec.precioTotal = txt_Precio.Text;
                _Ec.motivoPerdida = txt_motivoPerdida.Text;
                _Ec.nomCompetidor = txt_Competidor.Text;
                Cotizacion.Modificar(_Ec);
                Cargar_grilla(Cotizacion.Todas_Las_Cotizciones());
            }
        }

        private void btn_aceptar_cotizacion_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            DataTable Verificacion = new DataTable();

            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                _Ec.numeroCotizacicon = txt_numeroCotizacion.Text;
                _Ec.año = txt_Año.Text;
                _Ec.cuitCliente = cmb_cliente.SelectedValue.ToString();
                _Ec.numDocVendedor = cmb_Vendedor.SelectedValue.ToString();
                _Ec.codEstadoCotizacion = cmb_Estado.SelectedValue.ToString();
                _Ec.nombreSolicitante = txt_nombreSolicitante.Text;
                _Ec.apellidoSolicitante = txt_ApellidoSolicitante.Text;
                _Ec.observaciones = txt_Observaciones.Text;
                _Ec.fecha = cmb_Dia.SelectedItem.ToString() + "/" + cmb_Mes.SelectedItem.ToString() + "/" + txt_Año2.Text;
                _Ec.precioTotal = txt_Precio.Text;
                _Ec.motivoPerdida = txt_motivoPerdida.Text;
                _Ec.nomCompetidor = txt_Competidor.Text;
                Verificacion = Cotizacion.Buscar_Cotizcion(_Ec.numeroCotizacicon);
                if (Verificacion.Rows.Count > 0)
                {

                    MessageBox.Show("La cotizacion que desea insertar ya existe. ", "ATENCION");

                }
                else
                {
                    Cotizacion.Insertar(_Ec);
                    Cargar_grilla(Cotizacion.Todas_Las_Cotizciones());
                }
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Cotizacion.CerrarTransaccion();
            this.Close();
        }

        private void grid01_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

