﻿namespace TuLuz.Forums.Clientes
{
    partial class ConsultarPedidos
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
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_BuscarDoc = new TuLuz.Clases.TextBox01();
            this.chk_Todos = new System.Windows.Forms.CheckBox();
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
            this.Panel_ConsultarPedidos = new System.Windows.Forms.Panel();
            this.txt_numDniVendedor = new TuLuz.Clases.TextBox01();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_tipoDniVendedor = new TuLuz.Clases.TextBox01();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_cuitCliente = new TuLuz.Clases.TextBox01();
            this.txt_numCotizacion = new TuLuz.Clases.TextBox01();
            this.txt_NumPedido = new TuLuz.Clases.TextBox01();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_condicionPago = new TuLuz.Clases.TextBox01();
            this.txt_fecha = new TuLuz.Clases.TextBox01();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_limpiarCampo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Panel_ConsultarPedidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_limpiarCampo
            // 
            this.btn_limpiarCampo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_limpiarCampo.Controls.Add(this.btn_Limpiar);
            this.btn_limpiarCampo.Controls.Add(this.grid01);
            this.btn_limpiarCampo.Controls.Add(this.btn_Buscar);
            this.btn_limpiarCampo.Controls.Add(this.txt_BuscarDoc);
            this.btn_limpiarCampo.Controls.Add(this.chk_Todos);
            this.btn_limpiarCampo.Controls.Add(this.label6);
            this.btn_limpiarCampo.Location = new System.Drawing.Point(32, 9);
            this.btn_limpiarCampo.Margin = new System.Windows.Forms.Padding(6);
            this.btn_limpiarCampo.Name = "btn_limpiarCampo";
            this.btn_limpiarCampo.Padding = new System.Windows.Forms.Padding(6);
            this.btn_limpiarCampo.Size = new System.Drawing.Size(940, 305);
            this.btn_limpiarCampo.TabIndex = 0;
            this.btn_limpiarCampo.TabStop = false;
            this.btn_limpiarCampo.Text = "Filtros";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackgroundImage = global::TuLuz.Properties.Resources.___;
            this.btn_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(362, 41);
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
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.grid01.Location = new System.Drawing.Point(10, 122);
            this.grid01.Name = "grid01";
            this.grid01.ReadOnly = true;
            this.grid01.RowTemplate.Height = 30;
            this.grid01.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid01.Size = new System.Drawing.Size(919, 176);
            this.grid01.TabIndex = 4;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(693, 77);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(107, 39);
            this.btn_Buscar.TabIndex = 3;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_BuscarDoc
            // 
            this.txt_BuscarDoc.Location = new System.Drawing.Point(159, 41);
            this.txt_BuscarDoc.Name = "txt_BuscarDoc";
            this.txt_BuscarDoc.pp_mensaje_error = null;
            this.txt_BuscarDoc.pp_nombre_campo = null;
            this.txt_BuscarDoc.pp_nombre_tabla = null;
            this.txt_BuscarDoc.pp_validable = false;
            this.txt_BuscarDoc.Size = new System.Drawing.Size(197, 30);
            this.txt_BuscarDoc.TabIndex = 2;
            this.txt_BuscarDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_BuscarDoc_KeyPress);
            // 
            // chk_Todos
            // 
            this.chk_Todos.AutoSize = true;
            this.chk_Todos.Location = new System.Drawing.Point(159, 77);
            this.chk_Todos.Name = "chk_Todos";
            this.chk_Todos.Size = new System.Drawing.Size(87, 29);
            this.chk_Todos.TabIndex = 1;
            this.chk_Todos.Text = "Todos";
            this.chk_Todos.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Numero Pedido";
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
            // Panel_ConsultarPedidos
            // 
            this.Panel_ConsultarPedidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel_ConsultarPedidos.Controls.Add(this.txt_numDniVendedor);
            this.Panel_ConsultarPedidos.Controls.Add(this.label12);
            this.Panel_ConsultarPedidos.Controls.Add(this.txt_tipoDniVendedor);
            this.Panel_ConsultarPedidos.Controls.Add(this.label14);
            this.Panel_ConsultarPedidos.Controls.Add(this.label13);
            this.Panel_ConsultarPedidos.Controls.Add(this.label11);
            this.Panel_ConsultarPedidos.Controls.Add(this.txt_cuitCliente);
            this.Panel_ConsultarPedidos.Controls.Add(this.txt_numCotizacion);
            this.Panel_ConsultarPedidos.Controls.Add(this.txt_NumPedido);
            this.Panel_ConsultarPedidos.Controls.Add(this.label10);
            this.Panel_ConsultarPedidos.Controls.Add(this.btn_Aceptar);
            this.Panel_ConsultarPedidos.Controls.Add(this.btn_Cancelar);
            this.Panel_ConsultarPedidos.Controls.Add(this.label9);
            this.Panel_ConsultarPedidos.Controls.Add(this.label8);
            this.Panel_ConsultarPedidos.Controls.Add(this.label7);
            this.Panel_ConsultarPedidos.Controls.Add(this.txt_condicionPago);
            this.Panel_ConsultarPedidos.Controls.Add(this.txt_fecha);
            this.Panel_ConsultarPedidos.Location = new System.Drawing.Point(32, 379);
            this.Panel_ConsultarPedidos.Name = "Panel_ConsultarPedidos";
            this.Panel_ConsultarPedidos.Size = new System.Drawing.Size(940, 358);
            this.Panel_ConsultarPedidos.TabIndex = 5;
            // 
            // txt_numDniVendedor
            // 
            this.txt_numDniVendedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_numDniVendedor.Enabled = false;
            this.txt_numDniVendedor.Location = new System.Drawing.Point(621, 79);
            this.txt_numDniVendedor.Name = "txt_numDniVendedor";
            this.txt_numDniVendedor.pp_mensaje_error = null;
            this.txt_numDniVendedor.pp_nombre_campo = null;
            this.txt_numDniVendedor.pp_nombre_tabla = null;
            this.txt_numDniVendedor.pp_validable = false;
            this.txt_numDniVendedor.Size = new System.Drawing.Size(208, 30);
            this.txt_numDniVendedor.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 25);
            this.label12.TabIndex = 20;
            this.label12.Text = "TipoDni Vnededor";
            // 
            // txt_tipoDniVendedor
            // 
            this.txt_tipoDniVendedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tipoDniVendedor.Enabled = false;
            this.txt_tipoDniVendedor.Location = new System.Drawing.Point(189, 187);
            this.txt_tipoDniVendedor.Name = "txt_tipoDniVendedor";
            this.txt_tipoDniVendedor.pp_mensaje_error = null;
            this.txt_tipoDniVendedor.pp_nombre_campo = null;
            this.txt_tipoDniVendedor.pp_nombre_tabla = null;
            this.txt_tipoDniVendedor.pp_validable = false;
            this.txt_tipoDniVendedor.Size = new System.Drawing.Size(208, 30);
            this.txt_tipoDniVendedor.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(490, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 25);
            this.label14.TabIndex = 18;
            this.label14.Text = "CUIT Cliente";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(451, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(170, 25);
            this.label13.TabIndex = 17;
            this.label13.Text = "numDni Vendedor";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(445, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 25);
            this.label11.TabIndex = 15;
            this.label11.Text = "Condicion de pago";
            // 
            // txt_cuitCliente
            // 
            this.txt_cuitCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_cuitCliente.Enabled = false;
            this.txt_cuitCliente.Location = new System.Drawing.Point(621, 153);
            this.txt_cuitCliente.Name = "txt_cuitCliente";
            this.txt_cuitCliente.pp_mensaje_error = null;
            this.txt_cuitCliente.pp_nombre_campo = null;
            this.txt_cuitCliente.pp_nombre_tabla = null;
            this.txt_cuitCliente.pp_validable = false;
            this.txt_cuitCliente.Size = new System.Drawing.Size(208, 30);
            this.txt_cuitCliente.TabIndex = 13;
            // 
            // txt_numCotizacion
            // 
            this.txt_numCotizacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_numCotizacion.Enabled = false;
            this.txt_numCotizacion.Location = new System.Drawing.Point(189, 115);
            this.txt_numCotizacion.Name = "txt_numCotizacion";
            this.txt_numCotizacion.pp_mensaje_error = null;
            this.txt_numCotizacion.pp_nombre_campo = "numDoc";
            this.txt_numCotizacion.pp_nombre_tabla = "Empleados";
            this.txt_numCotizacion.pp_validable = false;
            this.txt_numCotizacion.Size = new System.Drawing.Size(208, 30);
            this.txt_numCotizacion.TabIndex = 11;
            // 
            // txt_NumPedido
            // 
            this.txt_NumPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_NumPedido.Enabled = false;
            this.txt_NumPedido.Location = new System.Drawing.Point(189, 79);
            this.txt_NumPedido.Name = "txt_NumPedido";
            this.txt_NumPedido.pp_mensaje_error = null;
            this.txt_NumPedido.pp_nombre_campo = null;
            this.txt_NumPedido.pp_nombre_tabla = null;
            this.txt_NumPedido.pp_validable = false;
            this.txt_NumPedido.Size = new System.Drawing.Size(208, 30);
            this.txt_NumPedido.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(154, -3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(533, 69);
            this.label10.TabIndex = 8;
            this.label10.Text = "Consultar Pedidos";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Aceptar.Location = new System.Drawing.Point(283, 289);
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
            this.btn_Cancelar.Location = new System.Drawing.Point(489, 289);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(110, 57);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(111, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Fecha ";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Numero Cotizacion";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Numero Pedido";
            // 
            // txt_condicionPago
            // 
            this.txt_condicionPago.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_condicionPago.Enabled = false;
            this.txt_condicionPago.Location = new System.Drawing.Point(621, 115);
            this.txt_condicionPago.Name = "txt_condicionPago";
            this.txt_condicionPago.pp_mensaje_error = null;
            this.txt_condicionPago.pp_nombre_campo = null;
            this.txt_condicionPago.pp_nombre_tabla = null;
            this.txt_condicionPago.pp_validable = false;
            this.txt_condicionPago.Size = new System.Drawing.Size(208, 30);
            this.txt_condicionPago.TabIndex = 2;
            // 
            // txt_fecha
            // 
            this.txt_fecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_fecha.Enabled = false;
            this.txt_fecha.Location = new System.Drawing.Point(189, 151);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.pp_mensaje_error = null;
            this.txt_fecha.pp_nombre_campo = null;
            this.txt_fecha.pp_nombre_tabla = null;
            this.txt_fecha.pp_validable = false;
            this.txt_fecha.Size = new System.Drawing.Size(208, 30);
            this.txt_fecha.TabIndex = 0;
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
            this.btn_salir.Location = new System.Drawing.Point(970, 9);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(42, 31);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "X";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Modificar.BackgroundImage = global::TuLuz.Properties.Resources.arrow_down_23784;
            this.btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Modificar.FlatAppearance.BorderSize = 0;
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modificar.Location = new System.Drawing.Point(472, 313);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 60);
            this.btn_Modificar.TabIndex = 3;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "NumeroPedido";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 160;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NumeroCotizacion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 180;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "TipoDniVendedor";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 180;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "NumDniVendedor";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 180;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "CondicionPago";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 180;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "CuitCliente";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 160;
            // 
            // ConsultarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 749);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.Panel_ConsultarPedidos);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_limpiarCampo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ConsultarPedidos";
            this.Text = "ModificarBarrio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.btn_limpiarCampo.ResumeLayout(false);
            this.btn_limpiarCampo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Panel_ConsultarPedidos.ResumeLayout(false);
            this.Panel_ConsultarPedidos.PerformLayout();
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
        private System.Windows.Forms.Panel Panel_ConsultarPedidos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chk_Todos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Buscar;
        private Clases.TextBox01 txt_BuscarDoc;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Clases.TextBox01 txt_condicionPago;
        private Clases.TextBox01 txt_fecha;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView grid01;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private Clases.TextBox01 txt_cuitCliente;
        private Clases.TextBox01 txt_numCotizacion;
        private Clases.TextBox01 txt_NumPedido;
        private System.Windows.Forms.Label label12;
        private Clases.TextBox01 txt_tipoDniVendedor;
        private Clases.TextBox01 txt_numDniVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}