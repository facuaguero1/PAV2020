namespace TuLuz.Forums
{
    partial class cotizacionXprecio
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.RVcotizacionXprecio = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_precioMaximo = new TuLuz.Clases.TextBox01();
            this.txt_pracioMinimo = new TuLuz.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(239, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cotizaciones Por Precio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // RVcotizacionXprecio
            // 
            this.RVcotizacionXprecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RVcotizacionXprecio.Location = new System.Drawing.Point(74, 125);
            this.RVcotizacionXprecio.Name = "RVcotizacionXprecio";
            this.RVcotizacionXprecio.ServerReport.BearerToken = null;
            this.RVcotizacionXprecio.Size = new System.Drawing.Size(702, 408);
            this.RVcotizacionXprecio.TabIndex = 10;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_buscar.BackgroundImage = global::TuLuz.Properties.Resources.buscar;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(585, 87);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(45, 33);
            this.btn_buscar.TabIndex = 16;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Precio Maximo";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Precio Minimo";
            // 
            // txt_precioMaximo
            // 
            this.txt_precioMaximo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_precioMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precioMaximo.Location = new System.Drawing.Point(452, 90);
            this.txt_precioMaximo.Name = "txt_precioMaximo";
            this.txt_precioMaximo.pp_mensaje_error = "No se ingreso NOMBRE!!";
            this.txt_precioMaximo.pp_nombre_campo = "nombre";
            this.txt_precioMaximo.pp_nombre_tabla = "Cliente";
            this.txt_precioMaximo.pp_validable = true;
            this.txt_precioMaximo.Size = new System.Drawing.Size(106, 30);
            this.txt_precioMaximo.TabIndex = 15;
            // 
            // txt_pracioMinimo
            // 
            this.txt_pracioMinimo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_pracioMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pracioMinimo.Location = new System.Drawing.Point(213, 87);
            this.txt_pracioMinimo.Name = "txt_pracioMinimo";
            this.txt_pracioMinimo.pp_mensaje_error = "No se ingreso CUIT!!";
            this.txt_pracioMinimo.pp_nombre_campo = "codBarrio";
            this.txt_pracioMinimo.pp_nombre_tabla = "Cliente";
            this.txt_pracioMinimo.pp_validable = true;
            this.txt_pracioMinimo.Size = new System.Drawing.Size(86, 30);
            this.txt_pracioMinimo.TabIndex = 14;
            // 
            // cotizacionXprecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 545);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_precioMaximo);
            this.Controls.Add(this.txt_pracioMinimo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RVcotizacionXprecio);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label1);
            this.Name = "cotizacionXprecio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AltaBarrio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_salir;
        private Microsoft.Reporting.WinForms.ReportViewer RVcotizacionXprecio;
        private System.Windows.Forms.Button btn_buscar;
        private Clases.TextBox01 txt_precioMaximo;
        private Clases.TextBox01 txt_pracioMinimo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}