namespace TuLuz.Forums
{
    partial class ActualizarStock
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
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.grid01 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_codigo = new TuLuz.Clases.TextBox01();
            this.txt_nombre = new TuLuz.Clases.TextBox01();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cantStock = new TuLuz.Clases.TextBox01();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_agregar = new TuLuz.Clases.TextBox01();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_total = new TuLuz.Clases.TextBox01();
            ((System.ComponentModel.ISupportInitialize)(this.grid01)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(331, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actualizar Stock";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(946, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(561, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Cantidad en Stock";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(659, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 25);
            this.label14.TabIndex = 28;
            this.label14.Text = "Codigo";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // grid01
            // 
            this.grid01.AllowUserToAddRows = false;
            this.grid01.AllowUserToDeleteRows = false;
            this.grid01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grid01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid01.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.grid01.Location = new System.Drawing.Point(43, 92);
            this.grid01.Name = "grid01";
            this.grid01.ReadOnly = true;
            this.grid01.Size = new System.Drawing.Size(464, 351);
            this.grid01.TabIndex = 48;
            this.grid01.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid01_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad en Stock";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(751, 97);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.pp_mensaje_error = "No se Ingreso algun dato";
            this.txt_codigo.pp_nombre_campo = "direccion";
            this.txt_codigo.pp_nombre_tabla = "Empleados";
            this.txt_codigo.pp_validable = false;
            this.txt_codigo.Size = new System.Drawing.Size(281, 30);
            this.txt_codigo.TabIndex = 6;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(751, 144);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.pp_mensaje_error = "No se Ingreso algun dato";
            this.txt_nombre.pp_nombre_campo = "telefono";
            this.txt_nombre.pp_nombre_tabla = "Empleados";
            this.txt_nombre.pp_validable = true;
            this.txt_nombre.Size = new System.Drawing.Size(281, 30);
            this.txt_nombre.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::TuLuz.Properties.Resources._4115235_exit_logout_sign_out_114030;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1008, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 52);
            this.button1.TabIndex = 49;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_guardar.BackgroundImage = global::TuLuz.Properties.Resources.savetheapplication_guardar_2958;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Location = new System.Drawing.Point(834, 385);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(70, 58);
            this.btn_guardar.TabIndex = 14;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(653, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 50;
            this.label2.Text = "Nombre";
            // 
            // txt_cantStock
            // 
            this.txt_cantStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_cantStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantStock.Location = new System.Drawing.Point(751, 187);
            this.txt_cantStock.Name = "txt_cantStock";
            this.txt_cantStock.pp_mensaje_error = "No se Ingreso algun dato";
            this.txt_cantStock.pp_nombre_campo = "telefono";
            this.txt_cantStock.pp_nombre_tabla = "Empleados";
            this.txt_cantStock.pp_validable = true;
            this.txt_cantStock.Size = new System.Drawing.Size(281, 30);
            this.txt_cantStock.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(561, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 25);
            this.label4.TabIndex = 52;
            this.label4.Text = "Cantidad a agregar";
            // 
            // txt_agregar
            // 
            this.txt_agregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_agregar.Location = new System.Drawing.Point(751, 240);
            this.txt_agregar.Name = "txt_agregar";
            this.txt_agregar.pp_mensaje_error = "No se Ingreso algun dato";
            this.txt_agregar.pp_nombre_campo = "telefono";
            this.txt_agregar.pp_nombre_tabla = "Empleados";
            this.txt_agregar.pp_validable = true;
            this.txt_agregar.Size = new System.Drawing.Size(281, 30);
            this.txt_agregar.TabIndex = 53;
            this.txt_agregar.TextChanged += new System.EventHandler(this.txt_agregar_TextChanged);
            this.txt_agregar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_agregar_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(623, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 54;
            this.label5.Text = "Stock Total";
            // 
            // txt_total
            // 
            this.txt_total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(751, 301);
            this.txt_total.Name = "txt_total";
            this.txt_total.pp_mensaje_error = "No se Ingreso algun dato";
            this.txt_total.pp_nombre_campo = "telefono";
            this.txt_total.pp_nombre_tabla = "Empleados";
            this.txt_total.pp_validable = true;
            this.txt_total.Size = new System.Drawing.Size(281, 30);
            this.txt_total.TabIndex = 55;
            // 
            // ActualizarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 545);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_agregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_cantStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grid01);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Name = "ActualizarStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Datos de Usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.brn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Clases.TextBox01 txt_nombre;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label7;
        private Clases.TextBox01 txt_codigo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView grid01;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label2;
        private Clases.TextBox01 txt_cantStock;
        private System.Windows.Forms.Label label4;
        private Clases.TextBox01 txt_agregar;
        private System.Windows.Forms.Label label5;
        private Clases.TextBox01 txt_total;
    }
}