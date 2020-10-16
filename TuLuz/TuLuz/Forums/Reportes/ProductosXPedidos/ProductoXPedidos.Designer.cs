namespace TuLuz.Forums
{
    partial class ProductoXPedidos
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
            this.label4 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ProdcutXPedidos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_Pedidos = new TuLuz.Clases.ComboBox01();
            this.cmb_Localidad = new TuLuz.Clases.ComboBox01();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(134, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de Productos por Pedidos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pedido";
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(749, 12);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(35, 39);
            this.btn_salir.TabIndex = 9;
            this.btn_salir.Text = "X";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Localidad";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackgroundImage = global::TuLuz.Properties.Resources._1486485588_add_create_new_math_sign_cross_plus_81186;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(647, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 33);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(114, 151);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Todos los pedidos";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ProdcutXPedidos
            // 
            this.ProdcutXPedidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProdcutXPedidos.Location = new System.Drawing.Point(23, 174);
            this.ProdcutXPedidos.Name = "ProdcutXPedidos";
            this.ProdcutXPedidos.ServerReport.BearerToken = null;
            this.ProdcutXPedidos.Size = new System.Drawing.Size(732, 313);
            this.ProdcutXPedidos.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(606, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_Pedidos
            // 
            this.cmb_Pedidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Pedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Pedidos.FormattingEnabled = true;
            this.cmb_Pedidos.Location = new System.Drawing.Point(114, 102);
            this.cmb_Pedidos.Name = "cmb_Pedidos";
            this.cmb_Pedidos.pp_Display = null;
            this.cmb_Pedidos.pp_mensaje_error = null;
            this.cmb_Pedidos.pp_nombre_campo = null;
            this.cmb_Pedidos.pp_nombre_tabla = null;
            this.cmb_Pedidos.pp_Seleccionado = false;
            this.cmb_Pedidos.pp_Tabla = null;
            this.cmb_Pedidos.pp_validable = false;
            this.cmb_Pedidos.pp_Value = null;
            this.cmb_Pedidos.Size = new System.Drawing.Size(466, 33);
            this.cmb_Pedidos.TabIndex = 13;
            this.cmb_Pedidos.SelectedIndexChanged += new System.EventHandler(this.cmb_Pedidos_SelectedIndexChanged);
            // 
            // cmb_Localidad
            // 
            this.cmb_Localidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Localidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Localidad.FormattingEnabled = true;
            this.cmb_Localidad.Location = new System.Drawing.Point(175, 366);
            this.cmb_Localidad.Name = "cmb_Localidad";
            this.cmb_Localidad.pp_Display = null;
            this.cmb_Localidad.pp_mensaje_error = null;
            this.cmb_Localidad.pp_nombre_campo = null;
            this.cmb_Localidad.pp_nombre_tabla = null;
            this.cmb_Localidad.pp_Seleccionado = false;
            this.cmb_Localidad.pp_Tabla = null;
            this.cmb_Localidad.pp_validable = false;
            this.cmb_Localidad.pp_Value = null;
            this.cmb_Localidad.Size = new System.Drawing.Size(466, 33);
            this.cmb_Localidad.TabIndex = 10;
            // 
            // ProductoXPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 508);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProdcutXPedidos);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_Pedidos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmb_Localidad);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "ProductoXPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AltaBarrio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_salir;
        private Clases.ComboBox01 cmb_Localidad;
        private System.Windows.Forms.Button button2;
        private Clases.ComboBox01 cmb_Pedidos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private Microsoft.Reporting.WinForms.ReportViewer ProdcutXPedidos;
        private System.Windows.Forms.Button button1;
    }
}