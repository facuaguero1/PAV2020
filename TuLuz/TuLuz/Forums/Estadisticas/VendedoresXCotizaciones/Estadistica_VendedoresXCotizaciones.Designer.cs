﻿namespace TuLuz.Forums.Estadisticas.VendedoresXCotizaciones
{
    partial class Estadistica_VendedoresXCotizaciones
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
            this.rv_VendedoresXCotizaciones = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rv_VendedoresXCotizaciones
            // 
            this.rv_VendedoresXCotizaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rv_VendedoresXCotizaciones.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Estadisticas.VendedoresXCotizaciones.Rv_VendedoresXCotizaciones.rdlc" +
    "";
            this.rv_VendedoresXCotizaciones.Location = new System.Drawing.Point(14, 147);
            this.rv_VendedoresXCotizaciones.Name = "rv_VendedoresXCotizaciones";
            this.rv_VendedoresXCotizaciones.ServerReport.BearerToken = null;
            this.rv_VendedoresXCotizaciones.Size = new System.Drawing.Size(905, 368);
            this.rv_VendedoresXCotizaciones.TabIndex = 20;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Buscar.BackgroundImage = global::TuLuz.Properties.Resources.buscar;
            this.btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Location = new System.Drawing.Point(410, 96);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(62, 44);
            this.btn_Buscar.TabIndex = 20;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(81, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(736, 46);
            this.label1.TabIndex = 16;
            this.label1.Text = "Vendedores por cotizaciones ganadas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Estadistica_VendedoresXCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 545);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.rv_VendedoresXCotizaciones);
            this.Name = "Estadistica_VendedoresXCotizaciones";
            this.Text = "Estadistica_VendedoresXCotizaciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_VendedoresXCotizaciones;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label label1;
    }
}