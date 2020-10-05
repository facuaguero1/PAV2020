namespace TuLuz.Forums.Clientes
{
    partial class ConsultarProductos
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
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Panel_ConsultarProducto = new System.Windows.Forms.Panel();
            this.grp_detalle_compo = new System.Windows.Forms.GroupBox();
            this.grd_DetalleComponente = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_precio = new TuLuz.Clases.TextBox01();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_codProductoEq = new TuLuz.Clases.TextBox01();
            this.txt_nombre = new TuLuz.Clases.TextBox01();
            this.txt_codigo = new TuLuz.Clases.TextBox01();
            this.cmb_cuitProveedor = new TuLuz.Clases.ComboBox01();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_cantStock = new TuLuz.Clases.TextBox01();
            this.txt_descripcion = new TuLuz.Clases.TextBox01();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_limpiarCampo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Panel_ConsultarProducto.SuspendLayout();
            this.grp_detalle_compo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_DetalleComponente)).BeginInit();
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
            this.btn_limpiarCampo.Size = new System.Drawing.Size(940, 279);
            this.btn_limpiarCampo.TabIndex = 0;
            this.btn_limpiarCampo.TabStop = false;
            this.btn_limpiarCampo.Text = "Filtros";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackgroundImage = global::TuLuz.Properties.Resources.___;
            this.btn_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(362, 17);
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
            this.grid01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grid01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid01.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.grid01.Location = new System.Drawing.Point(10, 98);
            this.grid01.Name = "grid01";
            this.grid01.ReadOnly = true;
            this.grid01.RowTemplate.Height = 30;
            this.grid01.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid01.Size = new System.Drawing.Size(921, 176);
            this.grid01.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 90;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Descripcion";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 140;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Stock";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "cuitProveedor";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 160;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "codProductoEq";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 180;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(693, 53);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(107, 39);
            this.btn_Buscar.TabIndex = 3;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_BuscarDoc
            // 
            this.txt_BuscarDoc.Location = new System.Drawing.Point(159, 17);
            this.txt_BuscarDoc.Name = "txt_BuscarDoc";
            this.txt_BuscarDoc.pp_mensaje_error = null;
            this.txt_BuscarDoc.pp_nombre_campo = null;
            this.txt_BuscarDoc.pp_nombre_tabla = null;
            this.txt_BuscarDoc.pp_validable = false;
            this.txt_BuscarDoc.Size = new System.Drawing.Size(197, 30);
            this.txt_BuscarDoc.TabIndex = 2;
            // 
            // chk_Todos
            // 
            this.chk_Todos.AutoSize = true;
            this.chk_Todos.Location = new System.Drawing.Point(159, 53);
            this.chk_Todos.Name = "chk_Todos";
            this.chk_Todos.Size = new System.Drawing.Size(87, 29);
            this.chk_Todos.TabIndex = 1;
            this.chk_Todos.Text = "Todos";
            this.chk_Todos.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Codigo";
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
            // Panel_ConsultarProducto
            // 
            this.Panel_ConsultarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel_ConsultarProducto.Controls.Add(this.grp_detalle_compo);
            this.Panel_ConsultarProducto.Controls.Add(this.label12);
            this.Panel_ConsultarProducto.Controls.Add(this.txt_precio);
            this.Panel_ConsultarProducto.Controls.Add(this.label14);
            this.Panel_ConsultarProducto.Controls.Add(this.label13);
            this.Panel_ConsultarProducto.Controls.Add(this.label11);
            this.Panel_ConsultarProducto.Controls.Add(this.txt_codProductoEq);
            this.Panel_ConsultarProducto.Controls.Add(this.txt_nombre);
            this.Panel_ConsultarProducto.Controls.Add(this.txt_codigo);
            this.Panel_ConsultarProducto.Controls.Add(this.cmb_cuitProveedor);
            this.Panel_ConsultarProducto.Controls.Add(this.label10);
            this.Panel_ConsultarProducto.Controls.Add(this.btn_Aceptar);
            this.Panel_ConsultarProducto.Controls.Add(this.btn_Cancelar);
            this.Panel_ConsultarProducto.Controls.Add(this.label9);
            this.Panel_ConsultarProducto.Controls.Add(this.label8);
            this.Panel_ConsultarProducto.Controls.Add(this.label7);
            this.Panel_ConsultarProducto.Controls.Add(this.txt_cantStock);
            this.Panel_ConsultarProducto.Controls.Add(this.txt_descripcion);
            this.Panel_ConsultarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel_ConsultarProducto.Location = new System.Drawing.Point(32, 343);
            this.Panel_ConsultarProducto.Name = "Panel_ConsultarProducto";
            this.Panel_ConsultarProducto.Size = new System.Drawing.Size(940, 412);
            this.Panel_ConsultarProducto.TabIndex = 5;
            // 
            // grp_detalle_compo
            // 
            this.grp_detalle_compo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_detalle_compo.Controls.Add(this.grd_DetalleComponente);
            this.grp_detalle_compo.Location = new System.Drawing.Point(10, 201);
            this.grp_detalle_compo.Name = "grp_detalle_compo";
            this.grp_detalle_compo.Size = new System.Drawing.Size(921, 137);
            this.grp_detalle_compo.TabIndex = 21;
            this.grp_detalle_compo.TabStop = false;
            this.grp_detalle_compo.Text = "Componentes";
            // 
            // grd_DetalleComponente
            // 
            this.grd_DetalleComponente.AllowUserToAddRows = false;
            this.grd_DetalleComponente.AllowUserToDeleteRows = false;
            this.grd_DetalleComponente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grd_DetalleComponente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_DetalleComponente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.grd_DetalleComponente.Location = new System.Drawing.Point(111, 25);
            this.grd_DetalleComponente.Name = "grd_DetalleComponente";
            this.grd_DetalleComponente.ReadOnly = true;
            this.grd_DetalleComponente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_DetalleComponente.Size = new System.Drawing.Size(751, 106);
            this.grd_DetalleComponente.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(95, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Precio";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txt_precio
            // 
            this.txt_precio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_precio.Enabled = false;
            this.txt_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.Location = new System.Drawing.Point(170, 169);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.pp_mensaje_error = null;
            this.txt_precio.pp_nombre_campo = null;
            this.txt_precio.pp_nombre_tabla = null;
            this.txt_precio.pp_validable = false;
            this.txt_precio.Size = new System.Drawing.Size(208, 26);
            this.txt_precio.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(473, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 20);
            this.label14.TabIndex = 18;
            this.label14.Text = "codProductoEq";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(486, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 20);
            this.label13.TabIndex = 17;
            this.label13.Text = "cuitProveedor";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(508, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "CantStock";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txt_codProductoEq
            // 
            this.txt_codProductoEq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_codProductoEq.Enabled = false;
            this.txt_codProductoEq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codProductoEq.Location = new System.Drawing.Point(621, 134);
            this.txt_codProductoEq.Name = "txt_codProductoEq";
            this.txt_codProductoEq.pp_mensaje_error = null;
            this.txt_codProductoEq.pp_nombre_campo = null;
            this.txt_codProductoEq.pp_nombre_tabla = null;
            this.txt_codProductoEq.pp_validable = false;
            this.txt_codProductoEq.Size = new System.Drawing.Size(208, 26);
            this.txt_codProductoEq.TabIndex = 13;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(170, 105);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.pp_mensaje_error = null;
            this.txt_nombre.pp_nombre_campo = "numDoc";
            this.txt_nombre.pp_nombre_tabla = "Empleados";
            this.txt_nombre.pp_validable = false;
            this.txt_nombre.Size = new System.Drawing.Size(208, 26);
            this.txt_nombre.TabIndex = 11;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(170, 73);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.pp_mensaje_error = null;
            this.txt_codigo.pp_nombre_campo = null;
            this.txt_codigo.pp_nombre_tabla = null;
            this.txt_codigo.pp_validable = false;
            this.txt_codigo.Size = new System.Drawing.Size(208, 26);
            this.txt_codigo.TabIndex = 10;
            // 
            // cmb_cuitProveedor
            // 
            this.cmb_cuitProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_cuitProveedor.Enabled = false;
            this.cmb_cuitProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_cuitProveedor.FormattingEnabled = true;
            this.cmb_cuitProveedor.Location = new System.Drawing.Point(621, 71);
            this.cmb_cuitProveedor.Name = "cmb_cuitProveedor";
            this.cmb_cuitProveedor.pp_Display = null;
            this.cmb_cuitProveedor.pp_mensaje_error = null;
            this.cmb_cuitProveedor.pp_nombre_campo = null;
            this.cmb_cuitProveedor.pp_nombre_tabla = null;
            this.cmb_cuitProveedor.pp_Seleccionado = false;
            this.cmb_cuitProveedor.pp_Tabla = null;
            this.cmb_cuitProveedor.pp_validable = false;
            this.cmb_cuitProveedor.pp_Value = null;
            this.cmb_cuitProveedor.Size = new System.Drawing.Size(208, 26);
            this.cmb_cuitProveedor.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(154, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(558, 69);
            this.label10.TabIndex = 8;
            this.label10.Text = "Consultar Producto";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Aceptar.Location = new System.Drawing.Point(285, 344);
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
            this.btn_Cancelar.Location = new System.Drawing.Point(490, 344);
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
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(56, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Descripcion";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(83, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(89, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Codigo";
            // 
            // txt_cantStock
            // 
            this.txt_cantStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_cantStock.Enabled = false;
            this.txt_cantStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantStock.Location = new System.Drawing.Point(621, 102);
            this.txt_cantStock.Name = "txt_cantStock";
            this.txt_cantStock.pp_mensaje_error = null;
            this.txt_cantStock.pp_nombre_campo = null;
            this.txt_cantStock.pp_nombre_tabla = null;
            this.txt_cantStock.pp_validable = false;
            this.txt_cantStock.Size = new System.Drawing.Size(208, 26);
            this.txt_cantStock.TabIndex = 2;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_descripcion.Enabled = false;
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(170, 137);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.pp_mensaje_error = null;
            this.txt_descripcion.pp_nombre_campo = null;
            this.txt_descripcion.pp_nombre_tabla = null;
            this.txt_descripcion.pp_validable = false;
            this.txt_descripcion.Size = new System.Drawing.Size(208, 26);
            this.txt_descripcion.TabIndex = 0;
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
            this.btn_Modificar.Location = new System.Drawing.Point(472, 284);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 60);
            this.btn_Modificar.TabIndex = 3;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Nombre";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 250;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Cantidad";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 120;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Precio Unitario";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 200;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "SubTotal";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 120;
            // 
            // ConsultarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 749);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.Panel_ConsultarProducto);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_limpiarCampo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ConsultarProductos";
            this.Text = "ModificarBarrio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.btn_limpiarCampo.ResumeLayout(false);
            this.btn_limpiarCampo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Panel_ConsultarProducto.ResumeLayout(false);
            this.Panel_ConsultarProducto.PerformLayout();
            this.grp_detalle_compo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_DetalleComponente)).EndInit();
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
        private System.Windows.Forms.Panel Panel_ConsultarProducto;
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
        private Clases.TextBox01 txt_cantStock;
        private Clases.TextBox01 txt_descripcion;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView grid01;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_salir;
        private Clases.ComboBox01 cmb_cuitProveedor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private Clases.TextBox01 txt_codProductoEq;
        private Clases.TextBox01 txt_nombre;
        private Clases.TextBox01 txt_codigo;
        private System.Windows.Forms.Label label12;
        private Clases.TextBox01 txt_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.GroupBox grp_detalle_compo;
        private System.Windows.Forms.DataGridView grd_DetalleComponente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}