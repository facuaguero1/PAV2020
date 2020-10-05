namespace TuLuz.Forums.Clientes
{
    partial class ModificarDetalle
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
            this.btn_limpiarCampo = new System.Windows.Forms.GroupBox();
            this.grid01 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Panel_ModificarProducto = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_componente = new TuLuz.Clases.TextBox01();
            this.txt_producto = new TuLuz.Clases.TextBox01();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_precio = new TuLuz.Clases.TextBox01();
            this.txt_cantidad = new TuLuz.Clases.TextBox01();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_limpiarCampo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Panel_ModificarProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_limpiarCampo
            // 
            this.btn_limpiarCampo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_limpiarCampo.Controls.Add(this.grid01);
            this.btn_limpiarCampo.Location = new System.Drawing.Point(36, 65);
            this.btn_limpiarCampo.Margin = new System.Windows.Forms.Padding(6);
            this.btn_limpiarCampo.Name = "btn_limpiarCampo";
            this.btn_limpiarCampo.Padding = new System.Windows.Forms.Padding(6);
            this.btn_limpiarCampo.Size = new System.Drawing.Size(868, 206);
            this.btn_limpiarCampo.TabIndex = 0;
            this.btn_limpiarCampo.TabStop = false;
            this.btn_limpiarCampo.Text = "Detalle";
            // 
            // grid01
            // 
            this.grid01.AllowUserToAddRows = false;
            this.grid01.AllowUserToDeleteRows = false;
            this.grid01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid01.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column4});
            this.grid01.Location = new System.Drawing.Point(9, 32);
            this.grid01.Name = "grid01";
            this.grid01.ReadOnly = true;
            this.grid01.RowTemplate.Height = 30;
            this.grid01.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid01.Size = new System.Drawing.Size(850, 165);
            this.grid01.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CodigoProducto";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 170;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "CodigoProductoComponente";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 280;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Nombre";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuit";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(123, 58);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 29);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Todos";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(603, 130);
            this.dataGridView1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cuit";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(280, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 30);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(495, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 38);
            this.button3.TabIndex = 8;
            this.button3.Text = "Aceptar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Location = new System.Drawing.Point(495, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 38);
            this.button4.TabIndex = 9;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Panel_ModificarProducto
            // 
            this.Panel_ModificarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel_ModificarProducto.Controls.Add(this.label11);
            this.Panel_ModificarProducto.Controls.Add(this.txt_componente);
            this.Panel_ModificarProducto.Controls.Add(this.txt_producto);
            this.Panel_ModificarProducto.Controls.Add(this.label10);
            this.Panel_ModificarProducto.Controls.Add(this.btn_Aceptar);
            this.Panel_ModificarProducto.Controls.Add(this.btn_Cancelar);
            this.Panel_ModificarProducto.Controls.Add(this.label9);
            this.Panel_ModificarProducto.Controls.Add(this.label8);
            this.Panel_ModificarProducto.Controls.Add(this.label7);
            this.Panel_ModificarProducto.Controls.Add(this.txt_precio);
            this.Panel_ModificarProducto.Controls.Add(this.txt_cantidad);
            this.Panel_ModificarProducto.Location = new System.Drawing.Point(36, 332);
            this.Panel_ModificarProducto.Name = "Panel_ModificarProducto";
            this.Panel_ModificarProducto.Size = new System.Drawing.Size(868, 415);
            this.Panel_ModificarProducto.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(496, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 25);
            this.label11.TabIndex = 15;
            this.label11.Text = "Precio";
            // 
            // txt_componente
            // 
            this.txt_componente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_componente.Enabled = false;
            this.txt_componente.Location = new System.Drawing.Point(235, 195);
            this.txt_componente.Name = "txt_componente";
            this.txt_componente.pp_mensaje_error = null;
            this.txt_componente.pp_nombre_campo = "numDoc";
            this.txt_componente.pp_nombre_tabla = "Empleados";
            this.txt_componente.pp_validable = false;
            this.txt_componente.Size = new System.Drawing.Size(208, 30);
            this.txt_componente.TabIndex = 11;
            // 
            // txt_producto
            // 
            this.txt_producto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_producto.Enabled = false;
            this.txt_producto.Location = new System.Drawing.Point(235, 159);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.pp_mensaje_error = null;
            this.txt_producto.pp_nombre_campo = null;
            this.txt_producto.pp_nombre_tabla = null;
            this.txt_producto.pp_validable = false;
            this.txt_producto.Size = new System.Drawing.Size(208, 30);
            this.txt_producto.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(184, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(490, 69);
            this.label10.TabIndex = 8;
            this.label10.Text = "Modificar Detalle";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Aceptar.Location = new System.Drawing.Point(333, 287);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(110, 57);
            this.btn_Aceptar.TabIndex = 7;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancelar.Location = new System.Drawing.Point(569, 287);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(110, 57);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.Text = "Salir";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(472, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Cantidad";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(104, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Componente";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(134, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Producto ";
            // 
            // txt_precio
            // 
            this.txt_precio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_precio.Enabled = false;
            this.txt_precio.Location = new System.Drawing.Point(569, 195);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.pp_mensaje_error = null;
            this.txt_precio.pp_nombre_campo = null;
            this.txt_precio.pp_nombre_tabla = null;
            this.txt_precio.pp_validable = false;
            this.txt_precio.Size = new System.Drawing.Size(208, 30);
            this.txt_precio.TabIndex = 2;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_cantidad.Location = new System.Drawing.Point(569, 159);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.pp_mensaje_error = null;
            this.txt_cantidad.pp_nombre_campo = null;
            this.txt_cantidad.pp_nombre_tabla = null;
            this.txt_cantidad.pp_validable = false;
            this.txt_cantidad.Size = new System.Drawing.Size(208, 30);
            this.txt_cantidad.TabIndex = 0;
            this.txt_cantidad.TextChanged += new System.EventHandler(this.txt_cantidad_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(432, 63);
            this.label5.TabIndex = 10;
            this.label5.Text = "Modificar Cliente";
            // 
            // btn_back
            // 
            this.btn_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_back.BackgroundImage = global::TuLuz.Properties.Resources.go_back256_24856;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Location = new System.Drawing.Point(923, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(89, 77);
            this.btn_back.TabIndex = 6;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Modificar.BackgroundImage = global::TuLuz.Properties.Resources.arrow_down_23784;
            this.btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Modificar.FlatAppearance.BorderSize = 0;
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modificar.Location = new System.Drawing.Point(476, 271);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(89, 59);
            this.btn_Modificar.TabIndex = 3;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // ModificarDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 749);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.Panel_ModificarProducto);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_limpiarCampo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(240, 0);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ModificarDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ModificarBarrio";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ModificarDetalle_Load);
            this.btn_limpiarCampo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Panel_ModificarProducto.ResumeLayout(false);
            this.Panel_ModificarProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox btn_limpiarCampo;
        private Clases.TextBox01 textBox011;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private Clases.TextBox01 textBox012;
        private Clases.TextBox01 textBox013;
        private Clases.TextBox01 textBox014;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel Panel_ModificarProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Clases.TextBox01 txt_precio;
        private Clases.TextBox01 txt_cantidad;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView grid01;
        private System.Windows.Forms.Label label11;
        private Clases.TextBox01 txt_componente;
        private Clases.TextBox01 txt_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btn_back;
    }
}