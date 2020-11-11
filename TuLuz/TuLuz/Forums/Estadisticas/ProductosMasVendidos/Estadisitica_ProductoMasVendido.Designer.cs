namespace TuLuz.Forums.Estadisticas.VentasXMes
{
    partial class Estadistica_ProductoMasVendido
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
            this.rv_productoMasVendido = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.chk_filtro = new System.Windows.Forms.CheckBox();
            this.lblHasta = new TuLuz.Clases.LabelText01();
            this.lbl_Desde = new TuLuz.Clases.LabelText01();
            this.SuspendLayout();
            // 
            // rv_productoMasVendido
            // 
            this.rv_productoMasVendido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rv_productoMasVendido.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Estadisticas.VentasXMes.Rv_VentasXMes.rdlc";
            this.rv_productoMasVendido.Location = new System.Drawing.Point(12, 147);
            this.rv_productoMasVendido.Name = "rv_productoMasVendido";
            this.rv_productoMasVendido.ServerReport.BearerToken = null;
            this.rv_productoMasVendido.Size = new System.Drawing.Size(905, 368);
            this.rv_productoMasVendido.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(245, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 46);
            this.label1.TabIndex = 16;
            this.label1.Text = "Productos por Pedido";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Buscar.BackgroundImage = global::TuLuz.Properties.Resources.buscar;
            this.btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Location = new System.Drawing.Point(584, 85);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(62, 44);
            this.btn_Buscar.TabIndex = 20;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // chk_filtro
            // 
            this.chk_filtro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chk_filtro.AutoSize = true;
            this.chk_filtro.Location = new System.Drawing.Point(76, 85);
            this.chk_filtro.Name = "chk_filtro";
            this.chk_filtro.Size = new System.Drawing.Size(112, 17);
            this.chk_filtro.TabIndex = 24;
            this.chk_filtro.Text = "Filtrar por periodos";
            this.chk_filtro.UseVisualStyleBackColor = true;
            this.chk_filtro.CheckedChanged += new System.EventHandler(this.chk_filtro_CheckedChanged);
            // 
            // lblHasta
            // 
            this.lblHasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHasta.Location = new System.Drawing.Point(275, 85);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.PP_Ancho = 10;
            this.lblHasta.PP_Decimales = 2;
            this.lblHasta.PP_Etiqueta = "Hasta";
            this.lblHasta.PP_Mensaje_Error = null;
            this.lblHasta.PP_Nombre_Campo = null;
            this.lblHasta.PP_Nombre_Tabla = null;
            this.lblHasta.PP_ReadOnly = false;
            this.lblHasta.PP_Text = "  /  /";
            this.lblHasta.PP_TipoDato = TuLuz.Clases.LabelText01.TipoDato.fecha;
            this.lblHasta.PP_Validable = false;
            this.lblHasta.Size = new System.Drawing.Size(243, 56);
            this.lblHasta.TabIndex = 23;
            // 
            // lbl_Desde
            // 
            this.lbl_Desde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Desde.Location = new System.Drawing.Point(76, 85);
            this.lbl_Desde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbl_Desde.Name = "lbl_Desde";
            this.lbl_Desde.PP_Ancho = 10;
            this.lbl_Desde.PP_Decimales = 2;
            this.lbl_Desde.PP_Etiqueta = "Desde";
            this.lbl_Desde.PP_Mensaje_Error = null;
            this.lbl_Desde.PP_Nombre_Campo = null;
            this.lbl_Desde.PP_Nombre_Tabla = null;
            this.lbl_Desde.PP_ReadOnly = false;
            this.lbl_Desde.PP_Text = "  /  /";
            this.lbl_Desde.PP_TipoDato = TuLuz.Clases.LabelText01.TipoDato.fecha;
            this.lbl_Desde.PP_Validable = false;
            this.lbl_Desde.Size = new System.Drawing.Size(243, 56);
            this.lbl_Desde.TabIndex = 22;
            // 
            // Estadistica_ProductoMasVendido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 545);
            this.Controls.Add(this.chk_filtro);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lbl_Desde);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rv_productoMasVendido);
            this.Name = "Estadistica_ProductoMasVendido";
            this.Text = "Estadistica_VentaXMes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_productoMasVendido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Buscar;
        private Clases.LabelText01 lbl_Desde;
        private Clases.LabelText01 lblHasta;
        private System.Windows.Forms.CheckBox chk_filtro;
    }
}