﻿using System;
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
    public partial class PedidosXEmpleados : Form
    {
        Ng_Pedidos Pedidos = new Ng_Pedidos();
        Ng_Empleados Empleados = new Ng_Empleados();

        public PedidosXEmpleados()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            Es_TipoDocs Docs = new Es_TipoDocs();
            DataTable Verificacion = new DataTable();

            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {

                
               
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AltaBarrio_Load(object sender, EventArgs e)
        {
            cmb_Empleados.Cargar(Empleados.EstructuraComboxListado());
            cmb_Empleados.SelectedIndex = -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_CuitCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_idTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox011_SelectedIndexChanged(object sender, EventArgs e)
        {
          if (cmb_Empleados.SelectedIndex == -1)
            {
                cmb_Empleados.Text = "Seleccionar.";
            }
        }
    }
}
