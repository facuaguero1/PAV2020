namespace TuLuz.Forums.Estadisticas.VentasXMes
{
    partial class Estadistica_ClienteXMonto
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
            this.rv_ClienteXMonto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Desde = new System.Windows.Forms.TextBox();
            this.lbl_Hasta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rv_ClienteXMonto
            // 
            this.rv_ClienteXMonto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rv_ClienteXMonto.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Estadisticas.VentasXMes.Rv_VentasXMes.rdlc";
            this.rv_ClienteXMonto.Location = new System.Drawing.Point(12, 143);
            this.rv_ClienteXMonto.Name = "rv_ClienteXMonto";
            this.rv_ClienteXMonto.ServerReport.BearerToken = null;
            this.rv_ClienteXMonto.Size = new System.Drawing.Size(905, 368);
            this.rv_ClienteXMonto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(84, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(767, 46);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cliente con pedidos dentro de un monto";
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
            this.btn_Buscar.Location = new System.Drawing.Point(802, 83);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(62, 44);
            this.btn_Buscar.TabIndex = 20;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Minimo";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(323, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Maximo";
            // 
            // lbl_Desde
            // 
            this.lbl_Desde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Desde.Location = new System.Drawing.Point(179, 90);
            this.lbl_Desde.Name = "lbl_Desde";
            this.lbl_Desde.Size = new System.Drawing.Size(100, 29);
            this.lbl_Desde.TabIndex = 23;
            // 
            // lbl_Hasta
            // 
            this.lbl_Hasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hasta.Location = new System.Drawing.Point(418, 90);
            this.lbl_Hasta.Name = "lbl_Hasta";
            this.lbl_Hasta.Size = new System.Drawing.Size(100, 29);
            this.lbl_Hasta.TabIndex = 24;
            // 
            // Estadistica_ClienteXMonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 545);
            this.Controls.Add(this.lbl_Hasta);
            this.Controls.Add(this.lbl_Desde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rv_ClienteXMonto);
            this.Name = "Estadistica_ClienteXMonto";
            this.Text = "Estadistica_VentaXMes";
            this.Load += new System.EventHandler(this.Estadistica_VentaXMes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_ClienteXMonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lbl_Desde;
        private System.Windows.Forms.TextBox lbl_Hasta;
    }
}