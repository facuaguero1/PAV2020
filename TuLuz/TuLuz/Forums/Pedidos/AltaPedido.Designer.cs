namespace TuLuz.Forums
{
    partial class AltaPedido
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grp_detalle = new System.Windows.Forms.GroupBox();
            this.cmb_CodProducto = new TuLuz.Clases.ComboBox01();
            this.btn_CrearDetalle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Subtotal = new TuLuz.Clases.TextBox01();
            this.txt_Cant = new TuLuz.Clases.TextBox01();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_NumeroPedidoDetalle = new TuLuz.Clases.TextBox01();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.grdDetalle = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btn_crearPedido = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_Año = new TuLuz.Clases.ComboBox01();
            this.cmb_Mes = new TuLuz.Clases.ComboBox01();
            this.cmb_Dia = new TuLuz.Clases.ComboBox01();
            this.cmb_vendedor = new TuLuz.Clases.ComboBox01();
            this.cmb_cotizaciones = new TuLuz.Clases.ComboBox01();
            this.txt_CondicionPago = new TuLuz.Clases.TextBox01();
            this.cmb_CuitCliente = new TuLuz.Clases.ComboBox01();
            this.txt_NumPedido = new TuLuz.Clases.TextBox01();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.grp_detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(304, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta de Pedido";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(266, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero Cotizacion";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(311, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Pedido";
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(1185, 12);
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
            this.label5.Location = new System.Drawing.Point(298, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Numero Pedido";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(331, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cuit Cliente";
            // 
            // grp_detalle
            // 
            this.grp_detalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_detalle.Controls.Add(this.cmb_CodProducto);
            this.grp_detalle.Controls.Add(this.btn_CrearDetalle);
            this.grp_detalle.Controls.Add(this.label8);
            this.grp_detalle.Controls.Add(this.label2);
            this.grp_detalle.Controls.Add(this.txt_Subtotal);
            this.grp_detalle.Controls.Add(this.txt_Cant);
            this.grp_detalle.Controls.Add(this.label12);
            this.grp_detalle.Controls.Add(this.label11);
            this.grp_detalle.Controls.Add(this.txt_NumeroPedidoDetalle);
            this.grp_detalle.Location = new System.Drawing.Point(851, 226);
            this.grp_detalle.Name = "grp_detalle";
            this.grp_detalle.Size = new System.Drawing.Size(375, 214);
            this.grp_detalle.TabIndex = 22;
            this.grp_detalle.TabStop = false;
            this.grp_detalle.Text = "Detalle del Pedido";
            // 
            // cmb_CodProducto
            // 
            this.cmb_CodProducto.FormattingEnabled = true;
            this.cmb_CodProducto.Location = new System.Drawing.Point(146, 77);
            this.cmb_CodProducto.Name = "cmb_CodProducto";
            this.cmb_CodProducto.pp_Display = null;
            this.cmb_CodProducto.pp_mensaje_error = null;
            this.cmb_CodProducto.pp_nombre_campo = null;
            this.cmb_CodProducto.pp_nombre_tabla = null;
            this.cmb_CodProducto.pp_Seleccionado = false;
            this.cmb_CodProducto.pp_Tabla = null;
            this.cmb_CodProducto.pp_validable = false;
            this.cmb_CodProducto.pp_Value = null;
            this.cmb_CodProducto.Size = new System.Drawing.Size(100, 21);
            this.cmb_CodProducto.TabIndex = 9;
            // 
            // btn_CrearDetalle
            // 
            this.btn_CrearDetalle.Location = new System.Drawing.Point(146, 182);
            this.btn_CrearDetalle.Name = "btn_CrearDetalle";
            this.btn_CrearDetalle.Size = new System.Drawing.Size(100, 23);
            this.btn_CrearDetalle.TabIndex = 8;
            this.btn_CrearDetalle.Text = "Crear Detalle";
            this.btn_CrearDetalle.UseVisualStyleBackColor = true;
            this.btn_CrearDetalle.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(90, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "SubTotal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad";
            // 
            // txt_Subtotal
            // 
            this.txt_Subtotal.Location = new System.Drawing.Point(146, 144);
            this.txt_Subtotal.Name = "txt_Subtotal";
            this.txt_Subtotal.pp_mensaje_error = null;
            this.txt_Subtotal.pp_nombre_campo = null;
            this.txt_Subtotal.pp_nombre_tabla = null;
            this.txt_Subtotal.pp_validable = false;
            this.txt_Subtotal.Size = new System.Drawing.Size(100, 20);
            this.txt_Subtotal.TabIndex = 5;
            // 
            // txt_Cant
            // 
            this.txt_Cant.Location = new System.Drawing.Point(146, 111);
            this.txt_Cant.Name = "txt_Cant";
            this.txt_Cant.pp_mensaje_error = null;
            this.txt_Cant.pp_nombre_campo = null;
            this.txt_Cant.pp_nombre_tabla = null;
            this.txt_Cant.pp_validable = false;
            this.txt_Cant.Size = new System.Drawing.Size(100, 20);
            this.txt_Cant.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(89, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Producto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(60, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Numero Pedido";
            // 
            // txt_NumeroPedidoDetalle
            // 
            this.txt_NumeroPedidoDetalle.Enabled = false;
            this.txt_NumeroPedidoDetalle.Location = new System.Drawing.Point(146, 41);
            this.txt_NumeroPedidoDetalle.Name = "txt_NumeroPedidoDetalle";
            this.txt_NumeroPedidoDetalle.pp_mensaje_error = null;
            this.txt_NumeroPedidoDetalle.pp_nombre_campo = null;
            this.txt_NumeroPedidoDetalle.pp_nombre_tabla = null;
            this.txt_NumeroPedidoDetalle.pp_validable = false;
            this.txt_NumeroPedidoDetalle.Size = new System.Drawing.Size(100, 20);
            this.txt_NumeroPedidoDetalle.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(241, 325);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(203, 25);
            this.label13.TabIndex = 27;
            this.label13.Text = "Documento Vendedor";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(269, 364);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(176, 25);
            this.label14.TabIndex = 28;
            this.label14.Text = "Condicion de pago";
            // 
            // grdDetalle
            // 
            this.grdDetalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.grdDetalle.Location = new System.Drawing.Point(273, 501);
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.Size = new System.Drawing.Size(512, 150);
            this.grdDetalle.TabIndex = 30;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numero Pedido";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Producto";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio";
            this.Column4.Name = "Column4";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(851, 203);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(89, 17);
            this.checkBox2.TabIndex = 32;
            this.checkBox2.Text = "Tiene Detalle";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // btn_crearPedido
            // 
            this.btn_crearPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_crearPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crearPedido.Location = new System.Drawing.Point(459, 438);
            this.btn_crearPedido.Name = "btn_crearPedido";
            this.btn_crearPedido.Size = new System.Drawing.Size(281, 33);
            this.btn_crearPedido.TabIndex = 34;
            this.btn_crearPedido.Text = "Insertar Pedido";
            this.btn_crearPedido.UseVisualStyleBackColor = true;
            this.btn_crearPedido.Click += new System.EventHandler(this.btn_crearProducto_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_aceptar.BackgroundImage = global::TuLuz.Properties.Resources._4115235_exit_logout_sign_out_114030;
            this.btn_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_aceptar.FlatAppearance.BorderSize = 0;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Location = new System.Drawing.Point(1015, 631);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(110, 92);
            this.btn_aceptar.TabIndex = 13;
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(472, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Dia";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(590, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Mes";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(698, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Año";
            // 
            // cmb_Año
            // 
            this.cmb_Año.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.cmb_Año.Location = new System.Drawing.Point(678, 295);
            this.cmb_Año.Name = "cmb_Año";
            this.cmb_Año.pp_Display = null;
            this.cmb_Año.pp_mensaje_error = null;
            this.cmb_Año.pp_nombre_campo = null;
            this.cmb_Año.pp_nombre_tabla = null;
            this.cmb_Año.pp_Seleccionado = false;
            this.cmb_Año.pp_Tabla = null;
            this.cmb_Año.pp_validable = false;
            this.cmb_Año.pp_Value = null;
            this.cmb_Año.Size = new System.Drawing.Size(62, 21);
            this.cmb_Año.TabIndex = 40;
            // 
            // cmb_Mes
            // 
            this.cmb_Mes.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.cmb_Mes.Location = new System.Drawing.Point(573, 295);
            this.cmb_Mes.Name = "cmb_Mes";
            this.cmb_Mes.pp_Display = null;
            this.cmb_Mes.pp_mensaje_error = null;
            this.cmb_Mes.pp_nombre_campo = null;
            this.cmb_Mes.pp_nombre_tabla = null;
            this.cmb_Mes.pp_Seleccionado = false;
            this.cmb_Mes.pp_Tabla = null;
            this.cmb_Mes.pp_validable = false;
            this.cmb_Mes.pp_Value = null;
            this.cmb_Mes.Size = new System.Drawing.Size(62, 21);
            this.cmb_Mes.TabIndex = 39;
            this.cmb_Mes.SelectedIndexChanged += new System.EventHandler(this.comboBox012_SelectedIndexChanged);
            // 
            // cmb_Dia
            // 
            this.cmb_Dia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Dia.FormattingEnabled = true;
            this.cmb_Dia.Location = new System.Drawing.Point(459, 294);
            this.cmb_Dia.Name = "cmb_Dia";
            this.cmb_Dia.pp_Display = null;
            this.cmb_Dia.pp_mensaje_error = null;
            this.cmb_Dia.pp_nombre_campo = null;
            this.cmb_Dia.pp_nombre_tabla = null;
            this.cmb_Dia.pp_Seleccionado = false;
            this.cmb_Dia.pp_Tabla = null;
            this.cmb_Dia.pp_validable = false;
            this.cmb_Dia.pp_Value = null;
            this.cmb_Dia.Size = new System.Drawing.Size(62, 21);
            this.cmb_Dia.TabIndex = 38;
            // 
            // cmb_vendedor
            // 
            this.cmb_vendedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_vendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmb_vendedor.FormattingEnabled = true;
            this.cmb_vendedor.Location = new System.Drawing.Point(459, 323);
            this.cmb_vendedor.Name = "cmb_vendedor";
            this.cmb_vendedor.pp_Display = null;
            this.cmb_vendedor.pp_mensaje_error = null;
            this.cmb_vendedor.pp_nombre_campo = null;
            this.cmb_vendedor.pp_nombre_tabla = null;
            this.cmb_vendedor.pp_Seleccionado = false;
            this.cmb_vendedor.pp_Tabla = null;
            this.cmb_vendedor.pp_validable = false;
            this.cmb_vendedor.pp_Value = null;
            this.cmb_vendedor.Size = new System.Drawing.Size(281, 32);
            this.cmb_vendedor.TabIndex = 37;
            // 
            // cmb_cotizaciones
            // 
            this.cmb_cotizaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_cotizaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmb_cotizaciones.FormattingEnabled = true;
            this.cmb_cotizaciones.Location = new System.Drawing.Point(459, 240);
            this.cmb_cotizaciones.Name = "cmb_cotizaciones";
            this.cmb_cotizaciones.pp_Display = null;
            this.cmb_cotizaciones.pp_mensaje_error = null;
            this.cmb_cotizaciones.pp_nombre_campo = null;
            this.cmb_cotizaciones.pp_nombre_tabla = null;
            this.cmb_cotizaciones.pp_Seleccionado = false;
            this.cmb_cotizaciones.pp_Tabla = null;
            this.cmb_cotizaciones.pp_validable = false;
            this.cmb_cotizaciones.pp_Value = null;
            this.cmb_cotizaciones.Size = new System.Drawing.Size(281, 32);
            this.cmb_cotizaciones.TabIndex = 36;
            // 
            // txt_CondicionPago
            // 
            this.txt_CondicionPago.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_CondicionPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CondicionPago.Location = new System.Drawing.Point(459, 361);
            this.txt_CondicionPago.Name = "txt_CondicionPago";
            this.txt_CondicionPago.pp_mensaje_error = "No ingreso una direccion";
            this.txt_CondicionPago.pp_nombre_campo = "direccion";
            this.txt_CondicionPago.pp_nombre_tabla = "Empleados";
            this.txt_CondicionPago.pp_validable = false;
            this.txt_CondicionPago.Size = new System.Drawing.Size(281, 30);
            this.txt_CondicionPago.TabIndex = 35;
            // 
            // cmb_CuitCliente
            // 
            this.cmb_CuitCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_CuitCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CuitCliente.FormattingEnabled = true;
            this.cmb_CuitCliente.Location = new System.Drawing.Point(459, 400);
            this.cmb_CuitCliente.Name = "cmb_CuitCliente";
            this.cmb_CuitCliente.pp_Display = null;
            this.cmb_CuitCliente.pp_mensaje_error = "No ingreso el barrio";
            this.cmb_CuitCliente.pp_nombre_campo = "codBarrio";
            this.cmb_CuitCliente.pp_nombre_tabla = "Empleados";
            this.cmb_CuitCliente.pp_Seleccionado = false;
            this.cmb_CuitCliente.pp_Tabla = null;
            this.cmb_CuitCliente.pp_validable = false;
            this.cmb_CuitCliente.pp_Value = null;
            this.cmb_CuitCliente.Size = new System.Drawing.Size(281, 32);
            this.cmb_CuitCliente.TabIndex = 7;
            // 
            // txt_NumPedido
            // 
            this.txt_NumPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_NumPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NumPedido.Location = new System.Drawing.Point(459, 204);
            this.txt_NumPedido.Name = "txt_NumPedido";
            this.txt_NumPedido.pp_mensaje_error = "Falta Numero de Documento";
            this.txt_NumPedido.pp_nombre_campo = "numDoc";
            this.txt_NumPedido.pp_nombre_tabla = "Empleados";
            this.txt_NumPedido.pp_validable = false;
            this.txt_NumPedido.Size = new System.Drawing.Size(281, 30);
            this.txt_NumPedido.TabIndex = 1;
            this.txt_NumPedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NumPedido_KeyPress);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label15.Location = new System.Drawing.Point(534, 298);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(12, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "/";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label16.Location = new System.Drawing.Point(649, 299);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(12, 13);
            this.label16.TabIndex = 45;
            this.label16.Text = "/";
            // 
            // AltaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 749);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_Año);
            this.Controls.Add(this.cmb_Mes);
            this.Controls.Add(this.cmb_Dia);
            this.Controls.Add(this.cmb_vendedor);
            this.Controls.Add(this.cmb_cotizaciones);
            this.Controls.Add(this.txt_CondicionPago);
            this.Controls.Add(this.btn_crearPedido);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.grdDetalle);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.grp_detalle);
            this.Controls.Add(this.cmb_CuitCliente);
            this.Controls.Add(this.txt_NumPedido);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AltaPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Datos de Usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.brn_Load);
            this.grp_detalle.ResumeLayout(false);
            this.grp_detalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private Clases.TextBox01 txt_NumPedido;
        private Clases.ComboBox01 cmb_CuitCliente;
        private System.Windows.Forms.GroupBox grp_detalle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private Clases.TextBox01 txt_NumeroPedidoDetalle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private Clases.TextBox01 txt_Subtotal;
        private Clases.TextBox01 txt_Cant;
        private System.Windows.Forms.Button btn_CrearDetalle;
        private System.Windows.Forms.DataGridView grdDetalle;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btn_crearPedido;
        private Clases.ComboBox01 cmb_CodProducto;
        private Clases.TextBox01 txt_CondicionPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Clases.ComboBox01 cmb_cotizaciones;
        private Clases.ComboBox01 cmb_vendedor;
        private Clases.ComboBox01 cmb_Dia;
        private Clases.ComboBox01 cmb_Mes;
        private Clases.ComboBox01 cmb_Año;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}