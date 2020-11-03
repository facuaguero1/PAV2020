namespace TuLuz.Forums
{
    partial class CotizacionXEstado
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.rpv_CotizacionXEstado = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(882, 12);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(35, 39);
            this.btn_salir.TabIndex = 9;
            this.btn_salir.Text = "X";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // rpv_CotizacionXEstado
            // 
            this.rpv_CotizacionXEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rpv_CotizacionXEstado.Location = new System.Drawing.Point(12, 143);
            this.rpv_CotizacionXEstado.Name = "rpv_CotizacionXEstado";
            this.rpv_CotizacionXEstado.ServerReport.BearerToken = null;
            this.rpv_CotizacionXEstado.Size = new System.Drawing.Size(905, 368);
            this.rpv_CotizacionXEstado.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackgroundImage = global::TuLuz.Properties.Resources.buscar;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(412, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 45);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(207, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 46);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cotizaciones por estado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CotizacionXEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 545);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rpv_CotizacionXEstado);
            this.Controls.Add(this.btn_salir);
            this.Name = "CotizacionXEstado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AltaBarrio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_salir;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_CotizacionXEstado;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}