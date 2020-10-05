namespace TuLuz.Forums.Provincias
{
    partial class ConsultarProveedor
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
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.grid01 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_BuscarCodigo = new TuLuz.Clases.TextBox01();
            this.chk_activos = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.Panel_ConsultarCliente = new System.Windows.Forms.Panel();
            this.txt_telefono = new TuLuz.Clases.TextBox01();
            this.txt_Contacto = new TuLuz.Clases.TextBox01();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_razonsocial = new TuLuz.Clases.TextBox01();
            this.txt_cuit = new TuLuz.Clases.TextBox01();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.chk_noActivos = new System.Windows.Forms.CheckBox();
            this.btn_limpiarCampo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Panel_ConsultarCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_limpiarCampo
            // 
            this.btn_limpiarCampo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_limpiarCampo.Controls.Add(this.chk_noActivos);
            this.btn_limpiarCampo.Controls.Add(this.btn_Limpiar);
            this.btn_limpiarCampo.Controls.Add(this.grid01);
            this.btn_limpiarCampo.Controls.Add(this.btn_Buscar);
            this.btn_limpiarCampo.Controls.Add(this.txt_BuscarCodigo);
            this.btn_limpiarCampo.Controls.Add(this.chk_activos);
            this.btn_limpiarCampo.Controls.Add(this.label6);
            this.btn_limpiarCampo.Location = new System.Drawing.Point(110, 9);
            this.btn_limpiarCampo.Margin = new System.Windows.Forms.Padding(6);
            this.btn_limpiarCampo.Name = "btn_limpiarCampo";
            this.btn_limpiarCampo.Padding = new System.Windows.Forms.Padding(6);
            this.btn_limpiarCampo.Size = new System.Drawing.Size(639, 326);
            this.btn_limpiarCampo.TabIndex = 0;
            this.btn_limpiarCampo.TabStop = false;
            this.btn_limpiarCampo.Text = "Filtros";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackgroundImage = global::TuLuz.Properties.Resources.___;
            this.btn_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(339, 47);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(31, 30);
            this.btn_Limpiar.TabIndex = 5;
            this.btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // grid01
            // 
            this.grid01.AllowUserToAddRows = false;
            this.grid01.AllowUserToDeleteRows = false;
            this.grid01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid01.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.grid01.Location = new System.Drawing.Point(9, 141);
            this.grid01.Name = "grid01";
            this.grid01.ReadOnly = true;
            this.grid01.RowTemplate.Height = 30;
            this.grid01.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid01.Size = new System.Drawing.Size(621, 176);
            this.grid01.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cuit";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Razon social";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Contacto";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telefono";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 140;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(523, 96);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(107, 39);
            this.btn_Buscar.TabIndex = 3;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_BuscarCodigo
            // 
            this.txt_BuscarCodigo.Location = new System.Drawing.Point(136, 47);
            this.txt_BuscarCodigo.Name = "txt_BuscarCodigo";
            this.txt_BuscarCodigo.pp_mensaje_error = null;
            this.txt_BuscarCodigo.pp_nombre_campo = null;
            this.txt_BuscarCodigo.pp_nombre_tabla = null;
            this.txt_BuscarCodigo.pp_validable = false;
            this.txt_BuscarCodigo.Size = new System.Drawing.Size(197, 30);
            this.txt_BuscarCodigo.TabIndex = 2;
            // 
            // chk_activos
            // 
            this.chk_activos.AutoSize = true;
            this.chk_activos.Location = new System.Drawing.Point(136, 96);
            this.chk_activos.Name = "chk_activos";
            this.chk_activos.Size = new System.Drawing.Size(95, 29);
            this.chk_activos.TabIndex = 1;
            this.chk_activos.Text = "Activos";
            this.chk_activos.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cuit";
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
            // Panel_ConsultarCliente
            // 
            this.Panel_ConsultarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel_ConsultarCliente.Controls.Add(this.txt_telefono);
            this.Panel_ConsultarCliente.Controls.Add(this.txt_Contacto);
            this.Panel_ConsultarCliente.Controls.Add(this.label11);
            this.Panel_ConsultarCliente.Controls.Add(this.label9);
            this.Panel_ConsultarCliente.Controls.Add(this.label10);
            this.Panel_ConsultarCliente.Controls.Add(this.btn_Aceptar);
            this.Panel_ConsultarCliente.Controls.Add(this.label8);
            this.Panel_ConsultarCliente.Controls.Add(this.label7);
            this.Panel_ConsultarCliente.Controls.Add(this.txt_razonsocial);
            this.Panel_ConsultarCliente.Controls.Add(this.txt_cuit);
            this.Panel_ConsultarCliente.Location = new System.Drawing.Point(110, 421);
            this.Panel_ConsultarCliente.Name = "Panel_ConsultarCliente";
            this.Panel_ConsultarCliente.Size = new System.Drawing.Size(639, 299);
            this.Panel_ConsultarCliente.TabIndex = 5;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Enabled = false;
            this.txt_telefono.Location = new System.Drawing.Point(182, 206);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.pp_mensaje_error = null;
            this.txt_telefono.pp_nombre_campo = null;
            this.txt_telefono.pp_nombre_tabla = null;
            this.txt_telefono.pp_validable = false;
            this.txt_telefono.Size = new System.Drawing.Size(208, 30);
            this.txt_telefono.TabIndex = 13;
            // 
            // txt_Contacto
            // 
            this.txt_Contacto.Enabled = false;
            this.txt_Contacto.Location = new System.Drawing.Point(182, 170);
            this.txt_Contacto.Name = "txt_Contacto";
            this.txt_Contacto.pp_mensaje_error = null;
            this.txt_Contacto.pp_nombre_campo = null;
            this.txt_Contacto.pp_nombre_tabla = null;
            this.txt_Contacto.pp_validable = false;
            this.txt_Contacto.Size = new System.Drawing.Size(208, 30);
            this.txt_Contacto.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(68, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 25);
            this.label11.TabIndex = 11;
            this.label11.Text = "Telefono";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Contacto";
            // 
            // label10
            // 
            this.label10.AutoEllipsis = true;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-13, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(663, 76);
            this.label10.TabIndex = 8;
            this.label10.Text = "Consultar Proveedor";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(508, 231);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(99, 42);
            this.btn_Aceptar.TabIndex = 7;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Razon social";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Cuit";
            // 
            // txt_razonsocial
            // 
            this.txt_razonsocial.Enabled = false;
            this.txt_razonsocial.Location = new System.Drawing.Point(182, 134);
            this.txt_razonsocial.Name = "txt_razonsocial";
            this.txt_razonsocial.pp_mensaje_error = null;
            this.txt_razonsocial.pp_nombre_campo = null;
            this.txt_razonsocial.pp_nombre_tabla = null;
            this.txt_razonsocial.pp_validable = false;
            this.txt_razonsocial.Size = new System.Drawing.Size(208, 30);
            this.txt_razonsocial.TabIndex = 2;
            // 
            // txt_cuit
            // 
            this.txt_cuit.Enabled = false;
            this.txt_cuit.Location = new System.Drawing.Point(182, 98);
            this.txt_cuit.Name = "txt_cuit";
            this.txt_cuit.pp_mensaje_error = null;
            this.txt_cuit.pp_nombre_campo = null;
            this.txt_cuit.pp_nombre_tabla = null;
            this.txt_cuit.pp_validable = false;
            this.txt_cuit.Size = new System.Drawing.Size(208, 30);
            this.txt_cuit.TabIndex = 0;
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
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(795, 9);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(42, 31);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "X";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Consultar.BackgroundImage = global::TuLuz.Properties.Resources.arrow_down_23784;
            this.btn_Consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Consultar.FlatAppearance.BorderSize = 0;
            this.btn_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Consultar.Location = new System.Drawing.Point(379, 342);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(75, 60);
            this.btn_Consultar.TabIndex = 3;
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // chk_noActivos
            // 
            this.chk_noActivos.AutoSize = true;
            this.chk_noActivos.Location = new System.Drawing.Point(246, 96);
            this.chk_noActivos.Name = "chk_noActivos";
            this.chk_noActivos.Size = new System.Drawing.Size(125, 29);
            this.chk_noActivos.TabIndex = 6;
            this.chk_noActivos.Text = "No Activos";
            this.chk_noActivos.UseVisualStyleBackColor = true;
            // 
            // ConsultarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 749);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.Panel_ConsultarCliente);
            this.Controls.Add(this.btn_Consultar);
            this.Controls.Add(this.btn_limpiarCampo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ConsultarProveedor";
            this.Text = "Consultar Barrio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ConsultarProveedor_Load);
            this.btn_limpiarCampo.ResumeLayout(false);
            this.btn_limpiarCampo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Panel_ConsultarCliente.ResumeLayout(false);
            this.Panel_ConsultarCliente.PerformLayout();
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
        private System.Windows.Forms.Panel Panel_ConsultarCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chk_activos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Buscar;
        private Clases.TextBox01 txt_BuscarCodigo;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Clases.TextBox01 txt_razonsocial;
        private Clases.TextBox01 txt_cuit;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView grid01;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label9;
        private Clases.TextBox01 txt_Contacto;
        private System.Windows.Forms.Label label11;
        private Clases.TextBox01 txt_telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.CheckBox chk_noActivos;
    }
}