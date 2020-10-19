namespace TuLuz.Forums.Reportes.CotizacionesXEstado
{
    partial class CotizacionesXEstado
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
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.RVCotizacionesXEstados = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmb_Estados = new TuLuz.Clases.ComboBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Buscar.BackgroundImage = global::TuLuz.Properties.Resources.buscar;
            this.btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Location = new System.Drawing.Point(380, 89);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(52, 32);
            this.btn_Buscar.TabIndex = 17;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // RVCotizacionesXEstados
            // 
            this.RVCotizacionesXEstados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RVCotizacionesXEstados.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Reportes.PedidosXEmpleados.PedidosXEmpleados.rdlc";
            this.RVCotizacionesXEstados.Location = new System.Drawing.Point(115, 131);
            this.RVCotizacionesXEstados.Name = "RVCotizacionesXEstados";
            this.RVCotizacionesXEstados.ServerReport.BearerToken = null;
            this.RVCotizacionesXEstados.Size = new System.Drawing.Size(702, 408);
            this.RVCotizacionesXEstados.TabIndex = 16;
            // 
            // cmb_Estados
            // 
            this.cmb_Estados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Estados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Estados.FormattingEnabled = true;
            this.cmb_Estados.Location = new System.Drawing.Point(190, 89);
            this.cmb_Estados.Name = "cmb_Estados";
            this.cmb_Estados.pp_Display = null;
            this.cmb_Estados.pp_mensaje_error = null;
            this.cmb_Estados.pp_nombre_campo = null;
            this.cmb_Estados.pp_nombre_tabla = null;
            this.cmb_Estados.pp_Seleccionado = false;
            this.cmb_Estados.pp_Tabla = null;
            this.cmb_Estados.pp_validable = false;
            this.cmb_Estados.pp_Value = null;
            this.cmb_Estados.Size = new System.Drawing.Size(158, 32);
            this.cmb_Estados.TabIndex = 15;
            this.cmb_Estados.SelectedIndexChanged += new System.EventHandler(this.cmb_Estados_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Estado:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(97, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(685, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "Listado de Cotizaciones por Estado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(874, 9);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(35, 39);
            this.btn_salir.TabIndex = 18;
            this.btn_salir.Text = "X";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // CotizacionesXEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 545);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.RVCotizacionesXEstados);
            this.Controls.Add(this.cmb_Estados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CotizacionesXEstado";
            this.Text = "CotizacionesXEstado";
            this.Load += new System.EventHandler(this.CotizacionesXEstado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Buscar;
        private Microsoft.Reporting.WinForms.ReportViewer RVCotizacionesXEstados;
        private Clases.ComboBox01 cmb_Estados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_salir;
    }
}