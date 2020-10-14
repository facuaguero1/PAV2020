namespace TuLuz.Forums
{
    partial class Pedidos
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.chk_agregarDetalles = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmb_Dia = new System.Windows.Forms.ComboBox();
            this.cmb_Mes = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_Productos = new TuLuz.Clases.ComboBox01();
            this.txt_Cantidad = new TuLuz.Clases.TextBox01();
            this.txt_subTotal = new TuLuz.Clases.TextBox01();
            this.grd_Pedidos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_NuevoPedido = new System.Windows.Forms.Button();
            this.grd_Detalles = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalles = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_NuevoDetalle = new System.Windows.Forms.Button();
            this.cmb_Año = new System.Windows.Forms.ComboBox();
            this.cmb_Cotizaciones = new TuLuz.Clases.ComboBox01();
            this.txt_CondicionPago = new TuLuz.Clases.TextBox01();
            this.cmb_cliente = new TuLuz.Clases.ComboBox01();
            this.cmb_Vendedor = new TuLuz.Clases.ComboBox01();
            this.txt_numeroPedido = new TuLuz.Clases.TextBox01();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Pedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Detalles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(408, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedidos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(756, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero Pedido";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(804, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vendedor";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(724, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Numero Cotizacion";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(716, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Condicion De Pago";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cantidad";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(946, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Dia";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(828, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Fecha";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "Subtotal";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(784, 255);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 25);
            this.label13.TabIndex = 27;
            this.label13.Text = "Cuit Cliente";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(32, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 25);
            this.label14.TabIndex = 28;
            this.label14.Text = "Producto";
            // 
            // chk_agregarDetalles
            // 
            this.chk_agregarDetalles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chk_agregarDetalles.AutoSize = true;
            this.chk_agregarDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_agregarDetalles.Location = new System.Drawing.Point(897, 363);
            this.chk_agregarDetalles.Name = "chk_agregarDetalles";
            this.chk_agregarDetalles.Size = new System.Drawing.Size(133, 21);
            this.chk_agregarDetalles.TabIndex = 5;
            this.chk_agregarDetalles.Text = "Agregar Detalles";
            this.chk_agregarDetalles.UseVisualStyleBackColor = true;
            this.chk_agregarDetalles.CheckedChanged += new System.EventHandler(this.solicita_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(1032, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Mes";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(1124, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 17);
            this.label11.TabIndex = 33;
            this.label11.Text = "Año";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(999, 319);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 17);
            this.label12.TabIndex = 36;
            this.label12.Text = "/";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(1090, 319);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(12, 17);
            this.label15.TabIndex = 37;
            this.label15.Text = "/";
            // 
            // cmb_Dia
            // 
            this.cmb_Dia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Dia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Dia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Dia.FormattingEnabled = true;
            this.cmb_Dia.Location = new System.Drawing.Point(935, 318);
            this.cmb_Dia.Name = "cmb_Dia";
            this.cmb_Dia.Size = new System.Drawing.Size(58, 24);
            this.cmb_Dia.TabIndex = 9;
            // 
            // cmb_Mes
            // 
            this.cmb_Mes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Mes.FormattingEnabled = true;
            this.cmb_Mes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmb_Mes.Location = new System.Drawing.Point(1018, 318);
            this.cmb_Mes.Name = "cmb_Mes";
            this.cmb_Mes.Size = new System.Drawing.Size(58, 24);
            this.cmb_Mes.TabIndex = 8;
            this.cmb_Mes.SelectedIndexChanged += new System.EventHandler(this.cmb_Mes_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.cmb_Productos);
            this.groupBox1.Controls.Add(this.txt_Cantidad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_subTotal);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(753, 390);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 151);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // cmb_Productos
            // 
            this.cmb_Productos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Productos.FormattingEnabled = true;
            this.cmb_Productos.Location = new System.Drawing.Point(133, 24);
            this.cmb_Productos.Name = "cmb_Productos";
            this.cmb_Productos.pp_Display = null;
            this.cmb_Productos.pp_mensaje_error = "No se Ingreso algun dato";
            this.cmb_Productos.pp_nombre_campo = null;
            this.cmb_Productos.pp_nombre_tabla = null;
            this.cmb_Productos.pp_Seleccionado = false;
            this.cmb_Productos.pp_Tabla = null;
            this.cmb_Productos.pp_validable = false;
            this.cmb_Productos.pp_Value = null;
            this.cmb_Productos.Size = new System.Drawing.Size(281, 32);
            this.cmb_Productos.TabIndex = 58;
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cantidad.Location = new System.Drawing.Point(133, 66);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.pp_mensaje_error = "No se Ingreso algun dato";
            this.txt_Cantidad.pp_nombre_campo = "telefono";
            this.txt_Cantidad.pp_nombre_tabla = "Empleados";
            this.txt_Cantidad.pp_validable = true;
            this.txt_Cantidad.Size = new System.Drawing.Size(281, 30);
            this.txt_Cantidad.TabIndex = 7;
            this.txt_Cantidad.TextChanged += new System.EventHandler(this.txt_Cantidad_TextChanged);
            // 
            // txt_subTotal
            // 
            this.txt_subTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_subTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subTotal.Location = new System.Drawing.Point(133, 105);
            this.txt_subTotal.Name = "txt_subTotal";
            this.txt_subTotal.pp_mensaje_error = "No se Ingreso algun dato";
            this.txt_subTotal.pp_nombre_campo = "numDocJefe";
            this.txt_subTotal.pp_nombre_tabla = "Empleados";
            this.txt_subTotal.pp_validable = false;
            this.txt_subTotal.Size = new System.Drawing.Size(281, 30);
            this.txt_subTotal.TabIndex = 11;
            // 
            // grd_Pedidos
            // 
            this.grd_Pedidos.AllowUserToAddRows = false;
            this.grd_Pedidos.AllowUserToDeleteRows = false;
            this.grd_Pedidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grd_Pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Pedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grd_Pedidos.Location = new System.Drawing.Point(113, 108);
            this.grd_Pedidos.Name = "grd_Pedidos";
            this.grd_Pedidos.ReadOnly = true;
            this.grd_Pedidos.Size = new System.Drawing.Size(561, 217);
            this.grd_Pedidos.TabIndex = 48;
            this.grd_Pedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid01_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numero Pedido";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fecha";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CuitCliente";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "NumDocVendedor";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Condicion de Pago";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackgroundImage = global::TuLuz.Properties.Resources._4115235_exit_logout_sign_out_114030;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1121, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 59);
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
            this.btn_guardar.Location = new System.Drawing.Point(1087, 564);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(70, 58);
            this.btn_guardar.TabIndex = 14;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_NuevoPedido
            // 
            this.btn_NuevoPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_NuevoPedido.BackgroundImage = global::TuLuz.Properties.Resources._1486485588_add_create_new_math_sign_cross_plus_81186;
            this.btn_NuevoPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_NuevoPedido.FlatAppearance.BorderSize = 0;
            this.btn_NuevoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NuevoPedido.Location = new System.Drawing.Point(997, 564);
            this.btn_NuevoPedido.Name = "btn_NuevoPedido";
            this.btn_NuevoPedido.Size = new System.Drawing.Size(69, 58);
            this.btn_NuevoPedido.TabIndex = 13;
            this.btn_NuevoPedido.UseVisualStyleBackColor = true;
            this.btn_NuevoPedido.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // grd_Detalles
            // 
            this.grd_Detalles.AllowUserToAddRows = false;
            this.grd_Detalles.AllowUserToDeleteRows = false;
            this.grd_Detalles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grd_Detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Detalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column6,
            this.Column7,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.grd_Detalles.Location = new System.Drawing.Point(113, 445);
            this.grd_Detalles.Name = "grd_Detalles";
            this.grd_Detalles.ReadOnly = true;
            this.grd_Detalles.Size = new System.Drawing.Size(561, 177);
            this.grd_Detalles.TabIndex = 51;
            this.grd_Detalles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Detalles_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Numero Pedido";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Numero Producto";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Producto";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Detalles
            // 
            this.Detalles.AutoSize = true;
            this.Detalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Detalles.Location = new System.Drawing.Point(109, 411);
            this.Detalles.Name = "Detalles";
            this.Detalles.Size = new System.Drawing.Size(76, 24);
            this.Detalles.TabIndex = 52;
            this.Detalles.Text = "Detalles";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(113, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(561, 48);
            this.button2.TabIndex = 53;
            this.button2.Text = "INGRESAR NUEVO PEDIDO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_NuevoDetalle
            // 
            this.btn_NuevoDetalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_NuevoDetalle.BackgroundImage = global::TuLuz.Properties.Resources._1486485588_add_create_new_math_sign_cross_plus_81186;
            this.btn_NuevoDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_NuevoDetalle.FlatAppearance.BorderSize = 0;
            this.btn_NuevoDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NuevoDetalle.Location = new System.Drawing.Point(909, 564);
            this.btn_NuevoDetalle.Name = "btn_NuevoDetalle";
            this.btn_NuevoDetalle.Size = new System.Drawing.Size(69, 58);
            this.btn_NuevoDetalle.TabIndex = 54;
            this.btn_NuevoDetalle.UseVisualStyleBackColor = true;
            this.btn_NuevoDetalle.Click += new System.EventHandler(this.btn_NuevoDetalle_Click);
            // 
            // cmb_Año
            // 
            this.cmb_Año.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Año.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Año.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Año.FormattingEnabled = true;
            this.cmb_Año.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cmb_Año.Location = new System.Drawing.Point(1109, 319);
            this.cmb_Año.Name = "cmb_Año";
            this.cmb_Año.Size = new System.Drawing.Size(58, 24);
            this.cmb_Año.TabIndex = 57;
            // 
            // cmb_Cotizaciones
            // 
            this.cmb_Cotizaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Cotizaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Cotizaciones.FormattingEnabled = true;
            this.cmb_Cotizaciones.Location = new System.Drawing.Point(908, 141);
            this.cmb_Cotizaciones.Name = "cmb_Cotizaciones";
            this.cmb_Cotizaciones.pp_Display = null;
            this.cmb_Cotizaciones.pp_mensaje_error = "No se Ingreso algun dato";
            this.cmb_Cotizaciones.pp_nombre_campo = "tipoDoc";
            this.cmb_Cotizaciones.pp_nombre_tabla = "Empleados";
            this.cmb_Cotizaciones.pp_Seleccionado = false;
            this.cmb_Cotizaciones.pp_Tabla = null;
            this.cmb_Cotizaciones.pp_validable = false;
            this.cmb_Cotizaciones.pp_Value = null;
            this.cmb_Cotizaciones.Size = new System.Drawing.Size(281, 32);
            this.cmb_Cotizaciones.TabIndex = 1;
            // 
            // txt_CondicionPago
            // 
            this.txt_CondicionPago.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_CondicionPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CondicionPago.Location = new System.Drawing.Point(908, 217);
            this.txt_CondicionPago.Name = "txt_CondicionPago";
            this.txt_CondicionPago.pp_mensaje_error = "No se Ingreso algun dato";
            this.txt_CondicionPago.pp_nombre_campo = "apellido";
            this.txt_CondicionPago.pp_nombre_tabla = "Empleados";
            this.txt_CondicionPago.pp_validable = true;
            this.txt_CondicionPago.Size = new System.Drawing.Size(281, 30);
            this.txt_CondicionPago.TabIndex = 3;
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_cliente.FormattingEnabled = true;
            this.cmb_cliente.Location = new System.Drawing.Point(909, 253);
            this.cmb_cliente.Name = "cmb_cliente";
            this.cmb_cliente.pp_Display = null;
            this.cmb_cliente.pp_mensaje_error = "No se Ingreso algun dato";
            this.cmb_cliente.pp_nombre_campo = null;
            this.cmb_cliente.pp_nombre_tabla = null;
            this.cmb_cliente.pp_Seleccionado = false;
            this.cmb_cliente.pp_Tabla = null;
            this.cmb_cliente.pp_validable = false;
            this.cmb_cliente.pp_Value = null;
            this.cmb_cliente.Size = new System.Drawing.Size(281, 32);
            this.cmb_cliente.TabIndex = 4;
            // 
            // cmb_Vendedor
            // 
            this.cmb_Vendedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Vendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Vendedor.FormattingEnabled = true;
            this.cmb_Vendedor.Location = new System.Drawing.Point(908, 177);
            this.cmb_Vendedor.Name = "cmb_Vendedor";
            this.cmb_Vendedor.pp_Display = null;
            this.cmb_Vendedor.pp_mensaje_error = "No se Ingreso algun dato";
            this.cmb_Vendedor.pp_nombre_campo = "tipoDoc";
            this.cmb_Vendedor.pp_nombre_tabla = "Empleados";
            this.cmb_Vendedor.pp_Seleccionado = false;
            this.cmb_Vendedor.pp_Tabla = null;
            this.cmb_Vendedor.pp_validable = false;
            this.cmb_Vendedor.pp_Value = null;
            this.cmb_Vendedor.Size = new System.Drawing.Size(281, 32);
            this.cmb_Vendedor.TabIndex = 2;
            this.cmb_Vendedor.SelectedIndexChanged += new System.EventHandler(this.cmb_Vendedor_SelectedIndexChanged);
            // 
            // txt_numeroPedido
            // 
            this.txt_numeroPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_numeroPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numeroPedido.Location = new System.Drawing.Point(908, 105);
            this.txt_numeroPedido.Name = "txt_numeroPedido";
            this.txt_numeroPedido.pp_mensaje_error = "No se Ingreso algun dato";
            this.txt_numeroPedido.pp_nombre_campo = "apellido";
            this.txt_numeroPedido.pp_nombre_tabla = "Empleados";
            this.txt_numeroPedido.pp_validable = true;
            this.txt_numeroPedido.Size = new System.Drawing.Size(281, 30);
            this.txt_numeroPedido.TabIndex = 0;
            this.txt_numeroPedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numeroCotizacion_KeyPress);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 749);
            this.Controls.Add(this.cmb_Año);
            this.Controls.Add(this.cmb_Cotizaciones);
            this.Controls.Add(this.txt_CondicionPago);
            this.Controls.Add(this.btn_NuevoDetalle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Detalles);
            this.Controls.Add(this.grd_Detalles);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grd_Pedidos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_Mes);
            this.Controls.Add(this.cmb_Dia);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chk_agregarDetalles);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmb_cliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmb_Vendedor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_NuevoPedido);
            this.Controls.Add(this.txt_numeroPedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Datos de Usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.brn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Pedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Detalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Clases.TextBox01 txt_Cantidad;
        private Clases.TextBox01 txt_numeroPedido;
        private System.Windows.Forms.Button btn_NuevoPedido;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Clases.ComboBox01 cmb_Vendedor;
        private Clases.TextBox01 txt_subTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Clases.ComboBox01 cmb_cliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chk_agregarDetalles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmb_Dia;
        private System.Windows.Forms.ComboBox cmb_Mes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grd_Pedidos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grd_Detalles;
        private System.Windows.Forms.Label Detalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_NuevoDetalle;
        private Clases.TextBox01 txt_CondicionPago;
        private Clases.ComboBox01 cmb_Cotizaciones;
        private System.Windows.Forms.ComboBox cmb_Año;
        private Clases.ComboBox01 cmb_Productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}