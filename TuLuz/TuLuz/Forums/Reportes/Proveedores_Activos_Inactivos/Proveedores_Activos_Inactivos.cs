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
using Microsoft.Reporting.WinForms;

namespace TuLuz.Forums.Reportes.Proveedores_Activos_Inactivos
{
    public partial class Proveedores_Activos_Inactivos : Form
    {
        Ng_Proveedor Proveedor = new Ng_Proveedor();
        DataTable Tabla = new DataTable();

        public Proveedores_Activos_Inactivos()
        {
            InitializeComponent();
        }

        private void Proveedores_Activos_Inactivos_Load(object sender, EventArgs e)
        {

            this.rv_Proveedores_Activos_NoActivos.RefreshReport();
        }
        private DataTable Todos_los_proveedoresActivos()
        {
            {
                //Tabla = 
                Tabla = Proveedor.Todos_los_proveedoresActivos();
            }
            return Tabla;
        }
        private DataTable Todos_los_proveedoresNoActivos()
        {
            {
                //Tabla = 
                Tabla = Proveedor.Todos_los_proveedoresNoActivos();
            }
            return Tabla;
        }

        private void CargarInforme(DataTable Tabla)
        {

            ReportDataSource Datos = new ReportDataSource("DataSet1", Tabla);
            rv_Proveedores_Activos_NoActivos.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Reportes.Proveedores_Activos_Inactivos.Proveedores_Activos_Inactivos.rdlc";
            rv_Proveedores_Activos_NoActivos.LocalReport.DataSources.Clear();
            rv_Proveedores_Activos_NoActivos.LocalReport.DataSources.Add(Datos);
            rv_Proveedores_Activos_NoActivos.RefreshReport();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            DataTable Tabla = new DataTable();

            //Verificar si estan o no activos

            if(checkBoxActivo.Checked == true)
            {
                Tabla = Todos_los_proveedoresActivos();
            }

            if (checkBoxNoActivo.Checked == true)
            {
                Tabla = Todos_los_proveedoresNoActivos();
            }


            CargarInforme(Tabla);
        }
    }
}
