namespace TuLuz.Forums
{
    partial class ProductoXrangoPrecio
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.RVproductoXprecio = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_precioMax = new TuLuz.Clases.TextBox01();
            this.txt_pracioMin = new TuLuz.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(194, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de producto por rango de precio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio Minimo";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio Maximo";
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
            // RVproductoXprecio
            // 
            this.RVproductoXprecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RVproductoXprecio.Location = new System.Drawing.Point(99, 125);
            this.RVproductoXprecio.Name = "RVproductoXprecio";
            this.RVproductoXprecio.ServerReport.BearerToken = null;
            this.RVproductoXprecio.Size = new System.Drawing.Size(702, 408);
            this.RVproductoXprecio.TabIndex = 10;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_buscar.BackgroundImage = global::TuLuz.Properties.Resources.buscar;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(645, 84);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(54, 30);
            this.btn_buscar.TabIndex = 11;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_precioMax
            // 
            this.txt_precioMax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_precioMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precioMax.Location = new System.Drawing.Point(505, 84);
            this.txt_precioMax.Name = "txt_precioMax";
            this.txt_precioMax.pp_mensaje_error = "No se ingreso NOMBRE!!";
            this.txt_precioMax.pp_nombre_campo = "nombre";
            this.txt_precioMax.pp_nombre_tabla = "Cliente";
            this.txt_precioMax.pp_validable = true;
            this.txt_precioMax.Size = new System.Drawing.Size(86, 30);
            this.txt_precioMax.TabIndex = 5;
            this.txt_precioMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precioMax_KeyPress);
            // 
            // txt_pracioMin
            // 
            this.txt_pracioMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_pracioMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pracioMin.Location = new System.Drawing.Point(235, 84);
            this.txt_pracioMin.Name = "txt_pracioMin";
            this.txt_pracioMin.pp_mensaje_error = "No se ingreso CUIT!!";
            this.txt_pracioMin.pp_nombre_campo = "codBarrio";
            this.txt_pracioMin.pp_nombre_tabla = "Cliente";
            this.txt_pracioMin.pp_validable = true;
            this.txt_pracioMin.Size = new System.Drawing.Size(86, 30);
            this.txt_pracioMin.TabIndex = 4;
            this.txt_pracioMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pracioMin_KeyPress);
            // 
            // ProductoXrangoPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 545);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.RVproductoXprecio);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.txt_precioMax);
            this.Controls.Add(this.txt_pracioMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductoXrangoPrecio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductoXrangoPrecio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Clases.TextBox01 txt_pracioMin;
        private Clases.TextBox01 txt_precioMax;
        private System.Windows.Forms.Button btn_salir;
        private Microsoft.Reporting.WinForms.ReportViewer RVproductoXprecio;
        private System.Windows.Forms.Button btn_buscar;
    }
}