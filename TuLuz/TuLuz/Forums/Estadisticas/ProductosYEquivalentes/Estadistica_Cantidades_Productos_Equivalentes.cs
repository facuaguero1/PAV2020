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

namespace TuLuz.Forums.Estadisticas.Cantidades_Jefes_Empleados
{
    public partial class Estadistica_Cantidades_Productos_Equivalentes : Form
    {
        Ng_Producto producto = new Ng_Producto();
        public Estadistica_Cantidades_Productos_Equivalentes()
        {
            InitializeComponent();
        }

        private void Estadistica_Cantidades_Jefes_Empleados_Load(object sender, EventArgs e)
        {

            this.RV_Cantidades_Productos_Equivalentes.RefreshReport();
        }

        private void CalcularEstadistica()
        {

            DataTable tabla = new DataTable();
            DataTable tabla2 = new DataTable();
            tabla = producto.ContarEquivalente();
            tabla2 = producto.BuscarProductoEq();
            Be_BaseDatos _BD = new Be_BaseDatos();
            ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
            ReportDataSource Datos1 = new ReportDataSource("DataSet2", tabla2);
            RV_Cantidades_Productos_Equivalentes.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Estadisticas.ProductosYEquivalentes.Estadistica_Cantidades_Productos_Equivalentes.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("RP02", "Fecha: " + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString());
            RV_Cantidades_Productos_Equivalentes.LocalReport.DataSources.Clear();
            RV_Cantidades_Productos_Equivalentes.LocalReport.SetParameters(parametros);
            RV_Cantidades_Productos_Equivalentes.LocalReport.DataSources.Add(Datos);
            RV_Cantidades_Productos_Equivalentes.LocalReport.DataSources.Add(Datos1);
            RV_Cantidades_Productos_Equivalentes.RefreshReport();

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            CalcularEstadistica();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}