﻿namespace TuLuz.Forums.Reportes.Empleados_Jefes
{
    partial class Empleados_Jefes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.rv_listadoEmpleados_Jefes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteEmpleados_Jefe = new TuLuz.Forums.Reportes.Empleados_Jefes.ReporteEmpleados_Jefe();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteEmpleados_Jefe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(41, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(697, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de Empleados (Jefes o Sup)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rv_listadoEmpleados_Jefes
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.DataTable1BindingSource;
            this.rv_listadoEmpleados_Jefes.LocalReport.DataSources.Add(reportDataSource2);
            this.rv_listadoEmpleados_Jefes.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Reportes.Empleados_Jefes.ReporteEmpleados_Jefes.rdlc";
            this.rv_listadoEmpleados_Jefes.Location = new System.Drawing.Point(2, 91);
            this.rv_listadoEmpleados_Jefes.Name = "rv_listadoEmpleados_Jefes";
            this.rv_listadoEmpleados_Jefes.ServerReport.BearerToken = null;
            this.rv_listadoEmpleados_Jefes.Size = new System.Drawing.Size(821, 285);
            this.rv_listadoEmpleados_Jefes.TabIndex = 2;
            this.rv_listadoEmpleados_Jefes.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_buscar.BackgroundImage = global::TuLuz.Properties.Resources.buscar;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(178, 423);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(84, 64);
            this.btn_buscar.TabIndex = 51;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancelar.BackgroundImage = global::TuLuz.Properties.Resources.cancel_77947;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(511, 415);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(90, 80);
            this.btn_cancelar.TabIndex = 52;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.ReporteEmpleados_Jefe;
            // 
            // ReporteEmpleados_Jefe
            // 
            this.ReporteEmpleados_Jefe.DataSetName = "ReporteEmpleados_Jefe";
            this.ReporteEmpleados_Jefe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Empleados_Jefes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 557);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.rv_listadoEmpleados_Jefes);
            this.Controls.Add(this.label1);
            this.Name = "Empleados_Jefes";
            this.Text = "Empleados_Jefes";
            this.Load += new System.EventHandler(this.Empleados_Jefes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteEmpleados_Jefe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer rv_listadoEmpleados_Jefes;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private ReporteEmpleados_Jefe ReporteEmpleados_Jefe;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}