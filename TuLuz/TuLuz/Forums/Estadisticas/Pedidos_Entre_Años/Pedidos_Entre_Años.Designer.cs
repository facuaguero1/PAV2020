namespace TuLuz.Forums.Estadisticas.Pedidos_Entre_Años
{
    partial class Pedidos_Entre_Años
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblText_Desde = new TuLuz.Clases.LabelText01();
            this.LblTxt_FechaHasta = new TuLuz.Clases.LabelText01();
            this.rv_pedido_fechas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(95, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(732, 46);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cantidad de Pedidos entre dos fechas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblText_Desde
            // 
            this.LblText_Desde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblText_Desde.Location = new System.Drawing.Point(103, 79);
            this.LblText_Desde.Name = "LblText_Desde";
            this.LblText_Desde.PP_Ancho = 10;
            this.LblText_Desde.PP_Decimales = 2;
            this.LblText_Desde.PP_Etiqueta = "Desde";
            this.LblText_Desde.PP_Mensaje_Error = null;
            this.LblText_Desde.PP_Nombre_Campo = null;
            this.LblText_Desde.PP_Nombre_Tabla = null;
            this.LblText_Desde.PP_ReadOnly = false;
            this.LblText_Desde.PP_Text = "  /  /";
            this.LblText_Desde.PP_TipoDato = TuLuz.Clases.LabelText01.TipoDato.fecha;
            this.LblText_Desde.PP_Validable = false;
            this.LblText_Desde.Size = new System.Drawing.Size(241, 49);
            this.LblText_Desde.TabIndex = 16;
            // 
            // LblTxt_FechaHasta
            // 
            this.LblTxt_FechaHasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTxt_FechaHasta.Location = new System.Drawing.Point(381, 79);
            this.LblTxt_FechaHasta.Name = "LblTxt_FechaHasta";
            this.LblTxt_FechaHasta.PP_Ancho = 10;
            this.LblTxt_FechaHasta.PP_Decimales = 2;
            this.LblTxt_FechaHasta.PP_Etiqueta = "Hasta";
            this.LblTxt_FechaHasta.PP_Mensaje_Error = null;
            this.LblTxt_FechaHasta.PP_Nombre_Campo = null;
            this.LblTxt_FechaHasta.PP_Nombre_Tabla = null;
            this.LblTxt_FechaHasta.PP_ReadOnly = false;
            this.LblTxt_FechaHasta.PP_Text = "  /  /";
            this.LblTxt_FechaHasta.PP_TipoDato = TuLuz.Clases.LabelText01.TipoDato.fecha;
            this.LblTxt_FechaHasta.PP_Validable = false;
            this.LblTxt_FechaHasta.Size = new System.Drawing.Size(241, 49);
            this.LblTxt_FechaHasta.TabIndex = 17;
            // 
            // rv_pedido_fechas
            // 
            this.rv_pedido_fechas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rv_pedido_fechas.Location = new System.Drawing.Point(12, 165);
            this.rv_pedido_fechas.Name = "rv_pedido_fechas";
            this.rv_pedido_fechas.ServerReport.BearerToken = null;
            this.rv_pedido_fechas.Size = new System.Drawing.Size(905, 368);
            this.rv_pedido_fechas.TabIndex = 18;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Buscar.BackgroundImage = global::TuLuz.Properties.Resources.buscar;
            this.btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Location = new System.Drawing.Point(765, 84);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(62, 44);
            this.btn_Buscar.TabIndex = 19;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // Pedidos_Entre_Años
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 545);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.rv_pedido_fechas);
            this.Controls.Add(this.LblTxt_FechaHasta);
            this.Controls.Add(this.LblText_Desde);
            this.Controls.Add(this.label1);
            this.Name = "Pedidos_Entre_Años";
            this.Text = "Pedidos_Entre_Años";
            this.Load += new System.EventHandler(this.Pedidos_Entre_Años_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Clases.LabelText01 LblText_Desde;
        private Clases.LabelText01 LblTxt_FechaHasta;
        private Microsoft.Reporting.WinForms.ReportViewer rv_pedido_fechas;
        private System.Windows.Forms.Button btn_Buscar;
    }
}