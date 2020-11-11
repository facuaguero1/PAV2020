namespace TuLuz.Forums
{
    partial class AltaProducto
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grp_detalle = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.grdDetalle = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_crearProducto = new System.Windows.Forms.Button();
            this.txt_Stock = new TuLuz.Clases.TextBox01();
            this.cmb_Proveedor = new TuLuz.Clases.ComboBox01();
            this.cmb_Componente = new TuLuz.Clases.ComboBox01();
            this.txt_Subtotal = new TuLuz.Clases.TextBox01();
            this.txt_CantComp = new TuLuz.Clases.TextBox01();
            this.txt_Producto = new TuLuz.Clases.TextBox01();
            this.cmb_Producto = new TuLuz.Clases.ComboBox01();
            this.txt_Precio = new TuLuz.Clases.TextBox01();
            this.txt_codProd = new TuLuz.Clases.TextBox01();
            this.txt_Desc = new TuLuz.Clases.TextBox01();
            this.txt_nombre = new TuLuz.Clases.TextBox01();
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
            this.label1.Size = new System.Drawing.Size(542, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta de Producto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripcion";
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
            this.label5.Location = new System.Drawing.Point(345, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Codigo ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(355, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Precio";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(229, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Producto Equivalente";
            // 
            // grp_detalle
            // 
            this.grp_detalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_detalle.Controls.Add(this.cmb_Componente);
            this.grp_detalle.Controls.Add(this.button1);
            this.grp_detalle.Controls.Add(this.label8);
            this.grp_detalle.Controls.Add(this.label2);
            this.grp_detalle.Controls.Add(this.txt_Subtotal);
            this.grp_detalle.Controls.Add(this.txt_CantComp);
            this.grp_detalle.Controls.Add(this.label12);
            this.grp_detalle.Controls.Add(this.label11);
            this.grp_detalle.Controls.Add(this.txt_Producto);
            this.grp_detalle.Location = new System.Drawing.Point(851, 226);
            this.grp_detalle.Name = "grp_detalle";
            this.grp_detalle.Size = new System.Drawing.Size(375, 214);
            this.grp_detalle.TabIndex = 22;
            this.grp_detalle.TabStop = false;
            this.grp_detalle.Text = "Detalle del Producto";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Crear Detalle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Producto Componente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(90, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Producto";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(276, 350);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 25);
            this.label13.TabIndex = 27;
            this.label13.Text = "Cantidad Stock";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(268, 388);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 25);
            this.label14.TabIndex = 28;
            this.label14.Text = "CUIT Proveedor";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_aceptar.BackgroundImage = global::TuLuz.Properties.Resources._4115235_exit_logout_sign_out_114030;
            this.btn_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_aceptar.FlatAppearance.BorderSize = 0;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Location = new System.Drawing.Point(1030, 626);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(107, 95);
            this.btn_aceptar.TabIndex = 13;
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
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
            this.Column1.HeaderText = "Producto";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Componente";
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
            this.checkBox2.Location = new System.Drawing.Point(857, 159);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(121, 17);
            this.checkBox2.TabIndex = 32;
            this.checkBox2.Text = "Tiene Componentes";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(753, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_crearProducto
            // 
            this.btn_crearProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_crearProducto.Location = new System.Drawing.Point(465, 462);
            this.btn_crearProducto.Name = "btn_crearProducto";
            this.btn_crearProducto.Size = new System.Drawing.Size(281, 33);
            this.btn_crearProducto.TabIndex = 34;
            this.btn_crearProducto.Text = "Insertar Producto";
            this.btn_crearProducto.UseVisualStyleBackColor = true;
            this.btn_crearProducto.Click += new System.EventHandler(this.btn_crearProducto_Click);
            // 
            // txt_Stock
            // 
            this.txt_Stock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Stock.Location = new System.Drawing.Point(465, 348);
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.pp_mensaje_error = "No ingreso una direccion";
            this.txt_Stock.pp_nombre_campo = "direccion";
            this.txt_Stock.pp_nombre_tabla = "Empleados";
            this.txt_Stock.pp_validable = false;
            this.txt_Stock.Size = new System.Drawing.Size(281, 30);
            this.txt_Stock.TabIndex = 29;
            this.txt_Stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Stock_KeyPress);
            // 
            // cmb_Proveedor
            // 
            this.cmb_Proveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Proveedor.FormattingEnabled = true;
            this.cmb_Proveedor.Location = new System.Drawing.Point(465, 386);
            this.cmb_Proveedor.Name = "cmb_Proveedor";
            this.cmb_Proveedor.pp_Display = null;
            this.cmb_Proveedor.pp_mensaje_error = null;
            this.cmb_Proveedor.pp_nombre_campo = null;
            this.cmb_Proveedor.pp_nombre_tabla = null;
            this.cmb_Proveedor.pp_Seleccionado = false;
            this.cmb_Proveedor.pp_Tabla = null;
            this.cmb_Proveedor.pp_validable = false;
            this.cmb_Proveedor.pp_Value = null;
            this.cmb_Proveedor.Size = new System.Drawing.Size(281, 32);
            this.cmb_Proveedor.TabIndex = 6;
            // 
            // cmb_Componente
            // 
            this.cmb_Componente.FormattingEnabled = true;
            this.cmb_Componente.Location = new System.Drawing.Point(146, 77);
            this.cmb_Componente.Name = "cmb_Componente";
            this.cmb_Componente.pp_Display = null;
            this.cmb_Componente.pp_mensaje_error = null;
            this.cmb_Componente.pp_nombre_campo = null;
            this.cmb_Componente.pp_nombre_tabla = null;
            this.cmb_Componente.pp_Seleccionado = false;
            this.cmb_Componente.pp_Tabla = null;
            this.cmb_Componente.pp_validable = false;
            this.cmb_Componente.pp_Value = null;
            this.cmb_Componente.Size = new System.Drawing.Size(100, 21);
            this.cmb_Componente.TabIndex = 9;
            // 
            // txt_Subtotal
            // 
            this.txt_Subtotal.Enabled = false;
            this.txt_Subtotal.Location = new System.Drawing.Point(146, 144);
            this.txt_Subtotal.Name = "txt_Subtotal";
            this.txt_Subtotal.pp_mensaje_error = null;
            this.txt_Subtotal.pp_nombre_campo = null;
            this.txt_Subtotal.pp_nombre_tabla = null;
            this.txt_Subtotal.pp_validable = false;
            this.txt_Subtotal.Size = new System.Drawing.Size(100, 20);
            this.txt_Subtotal.TabIndex = 5;
            // 
            // txt_CantComp
            // 
            this.txt_CantComp.Location = new System.Drawing.Point(146, 111);
            this.txt_CantComp.Name = "txt_CantComp";
            this.txt_CantComp.pp_mensaje_error = null;
            this.txt_CantComp.pp_nombre_campo = null;
            this.txt_CantComp.pp_nombre_tabla = null;
            this.txt_CantComp.pp_validable = false;
            this.txt_CantComp.Size = new System.Drawing.Size(100, 20);
            this.txt_CantComp.TabIndex = 4;
            this.txt_CantComp.TextChanged += new System.EventHandler(this.txt_CantComp_TextChanged);
            this.txt_CantComp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CantComp_KeyPress);
            // 
            // txt_Producto
            // 
            this.txt_Producto.Enabled = false;
            this.txt_Producto.Location = new System.Drawing.Point(146, 41);
            this.txt_Producto.Name = "txt_Producto";
            this.txt_Producto.pp_mensaje_error = null;
            this.txt_Producto.pp_nombre_campo = null;
            this.txt_Producto.pp_nombre_tabla = null;
            this.txt_Producto.pp_validable = false;
            this.txt_Producto.Size = new System.Drawing.Size(100, 20);
            this.txt_Producto.TabIndex = 0;
            // 
            // cmb_Producto
            // 
            this.cmb_Producto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Producto.FormattingEnabled = true;
            this.cmb_Producto.Location = new System.Drawing.Point(465, 424);
            this.cmb_Producto.Name = "cmb_Producto";
            this.cmb_Producto.pp_Display = null;
            this.cmb_Producto.pp_mensaje_error = "No ingreso el barrio";
            this.cmb_Producto.pp_nombre_campo = "codBarrio";
            this.cmb_Producto.pp_nombre_tabla = "Empleados";
            this.cmb_Producto.pp_Seleccionado = false;
            this.cmb_Producto.pp_Tabla = null;
            this.cmb_Producto.pp_validable = false;
            this.cmb_Producto.pp_Value = null;
            this.cmb_Producto.Size = new System.Drawing.Size(281, 32);
            this.cmb_Producto.TabIndex = 7;
            // 
            // txt_Precio
            // 
            this.txt_Precio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Precio.Location = new System.Drawing.Point(465, 312);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.pp_mensaje_error = "No ingreso una direccion";
            this.txt_Precio.pp_nombre_campo = "direccion";
            this.txt_Precio.pp_nombre_tabla = "Empleados";
            this.txt_Precio.pp_validable = false;
            this.txt_Precio.Size = new System.Drawing.Size(281, 30);
            this.txt_Precio.TabIndex = 4;
            this.txt_Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Precio_KeyPress);
            // 
            // txt_codProd
            // 
            this.txt_codProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_codProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codProd.Location = new System.Drawing.Point(465, 204);
            this.txt_codProd.Name = "txt_codProd";
            this.txt_codProd.pp_mensaje_error = "Falta Numero de Documento";
            this.txt_codProd.pp_nombre_campo = "numDoc";
            this.txt_codProd.pp_nombre_tabla = "Empleados";
            this.txt_codProd.pp_validable = false;
            this.txt_codProd.Size = new System.Drawing.Size(281, 30);
            this.txt_codProd.TabIndex = 1;
            this.txt_codProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codProd_KeyPress);
            // 
            // txt_Desc
            // 
            this.txt_Desc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Desc.Location = new System.Drawing.Point(465, 276);
            this.txt_Desc.Name = "txt_Desc";
            this.txt_Desc.pp_mensaje_error = "No se ingreso APELLIDO!!";
            this.txt_Desc.pp_nombre_campo = "apellido";
            this.txt_Desc.pp_nombre_tabla = "Empleados";
            this.txt_Desc.pp_validable = true;
            this.txt_Desc.Size = new System.Drawing.Size(281, 30);
            this.txt_Desc.TabIndex = 3;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(465, 240);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.pp_mensaje_error = "No se ingreso NOMBRE!!";
            this.txt_nombre.pp_nombre_campo = "nombre";
            this.txt_nombre.pp_nombre_tabla = "Empleados";
            this.txt_nombre.pp_validable = true;
            this.txt_nombre.Size = new System.Drawing.Size(281, 30);
            this.txt_nombre.TabIndex = 2;
            // 
            // AltaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 749);
            this.Controls.Add(this.btn_crearProducto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.grdDetalle);
            this.Controls.Add(this.txt_Stock);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmb_Proveedor);
            this.Controls.Add(this.grp_detalle);
            this.Controls.Add(this.cmb_Producto);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.txt_codProd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_Desc);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AltaProducto";
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
        private Clases.TextBox01 txt_nombre;
        private Clases.TextBox01 txt_Desc;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Clases.TextBox01 txt_codProd;
        private Clases.TextBox01 txt_Precio;
        private Clases.ComboBox01 cmb_Producto;
        private System.Windows.Forms.GroupBox grp_detalle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private Clases.TextBox01 txt_Producto;
        private Clases.ComboBox01 cmb_Proveedor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private Clases.TextBox01 txt_Stock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private Clases.TextBox01 txt_Subtotal;
        private Clases.TextBox01 txt_CantComp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grdDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_crearProducto;
        private Clases.ComboBox01 cmb_Componente;
    }
}