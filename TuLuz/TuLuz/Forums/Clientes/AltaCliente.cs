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
    public partial class AltaCliente : Form
    {
        Ng_Clientes Cliente = new Ng_Clientes(); 
        public AltaCliente()
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
            Es_Clientes _Ec = new Es_Clientes();
            DataTable Verificacion = new DataTable();

            if (tratamiento.validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                _Ec.cuitCliente = txt_CuitCliente.Text;
                _Ec.nombre = txt_nombreCliente.Text;
                _Ec.apellido = txt_ApellidoCliente.Text;
                _Ec.activo = "true";
                Verificacion = Cliente.Buscar_ClienteMasBajos(_Ec.cuitCliente);
                if (Verificacion.Rows.Count > 0)
                {

                    MessageBox.Show("El Cliente que desea insertar ya existe. ", "ATENCION");

                }
                else
                {
                    Cliente.Insertar(_Ec);
                    this.Close();
                }
            }
           
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_ApellidoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
