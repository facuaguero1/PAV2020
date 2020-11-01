namespace TuLuz.Forums.Estadisticas.VentasXMes
{
    partial class Estadistica_VentaXMes
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
            this.rv_VentasXMes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_CodProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rv_VentasXMes
            // 
            this.rv_VentasXMes.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Estadisticas.VentasXMes.Rv_VentasXMes.rdlc";
            this.rv_VentasXMes.Location = new System.Drawing.Point(91, 166);
            this.rv_VentasXMes.Name = "rv_VentasXMes";
            this.rv_VentasXMes.ServerReport.BearerToken = null;
            this.rv_VentasXMes.Size = new System.Drawing.Size(836, 272);
            this.rv_VentasXMes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(98, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(642, 46);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cantidad de Ventas por Producto";
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
            this.btn_Buscar.Location = new System.Drawing.Point(771, 98);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(62, 44);
            this.btn_Buscar.TabIndex = 20;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_CodProducto
            // 
            this.txt_CodProducto.Location = new System.Drawing.Point(348, 121);
            this.txt_CodProducto.Name = "txt_CodProducto";
            this.txt_CodProducto.Size = new System.Drawing.Size(100, 20);
            this.txt_CodProducto.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Codigo de Producto";
            // 
            // Estadistica_VentaXMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_CodProducto);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rv_VentasXMes);
            this.Name = "Estadistica_VentaXMes";
            this.Text = "Estadistica_VentaXMes";
            this.Load += new System.EventHandler(this.Estadistica_VentaXMes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_VentasXMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_CodProducto;
        private System.Windows.Forms.Label label2;
    }
}