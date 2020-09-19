namespace TuLuz.Forums.Clientes
{
    partial class ConsultarEmpleados
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
            this.Panel_ModificarCliente = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_NumDocJefe = new TuLuz.Clases.TextBox01();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_TipoDocJefe = new TuLuz.Clases.ComboBox01();
            this.txt_Telefono = new TuLuz.Clases.TextBox01();
            this.txt_Direccion = new TuLuz.Clases.TextBox01();
            this.txt_NumDoc = new TuLuz.Clases.TextBox01();
            this.txt_TipoDoc = new TuLuz.Clases.TextBox01();
            this.cmb_barrio = new TuLuz.Clases.ComboBox01();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Apellido = new TuLuz.Clases.TextBox01();
            this.txt_Nombre = new TuLuz.Clases.TextBox01();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_limpiarCampo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Panel_ModificarCliente.SuspendLayout();
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
            this.Column6});
            this.grid01.Location = new System.Drawing.Point(10, 122);
            this.grid01.Name = "grid01";
            this.grid01.ReadOnly = true;
            this.grid01.RowTemplate.Height = 30;
            this.grid01.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid01.Size = new System.Drawing.Size(919, 176);
            this.grid01.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nro Documento";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Apellido";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 160;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Direccion";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 160;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Barrio";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 70;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Telefono";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
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
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nro Documento";
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
            // Panel_ModificarCliente
            // 
            this.Panel_ModificarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel_ModificarCliente.Controls.Add(this.label16);
            this.Panel_ModificarCliente.Controls.Add(this.txt_NumDocJefe);
            this.Panel_ModificarCliente.Controls.Add(this.label15);
            this.Panel_ModificarCliente.Controls.Add(this.label14);
            this.Panel_ModificarCliente.Controls.Add(this.label13);
            this.Panel_ModificarCliente.Controls.Add(this.label12);
            this.Panel_ModificarCliente.Controls.Add(this.label11);
            this.Panel_ModificarCliente.Controls.Add(this.cmb_TipoDocJefe);
            this.Panel_ModificarCliente.Controls.Add(this.txt_Telefono);
            this.Panel_ModificarCliente.Controls.Add(this.txt_Direccion);
            this.Panel_ModificarCliente.Controls.Add(this.txt_NumDoc);
            this.Panel_ModificarCliente.Controls.Add(this.txt_TipoDoc);
            this.Panel_ModificarCliente.Controls.Add(this.cmb_barrio);
            this.Panel_ModificarCliente.Controls.Add(this.label10);
            this.Panel_ModificarCliente.Controls.Add(this.btn_Aceptar);
            this.Panel_ModificarCliente.Controls.Add(this.btn_Cancelar);
            this.Panel_ModificarCliente.Controls.Add(this.label9);
            this.Panel_ModificarCliente.Controls.Add(this.label8);
            this.Panel_ModificarCliente.Controls.Add(this.label7);
            this.Panel_ModificarCliente.Controls.Add(this.txt_Apellido);
            this.Panel_ModificarCliente.Controls.Add(this.txt_Nombre);
            this.Panel_ModificarCliente.Location = new System.Drawing.Point(32, 379);
            this.Panel_ModificarCliente.Name = "Panel_ModificarCliente";
            this.Panel_ModificarCliente.Size = new System.Drawing.Size(940, 358);
            this.Panel_ModificarCliente.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(486, 193);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 25);
            this.label16.TabIndex = 21;
            this.label16.Text = "Nro Doc Jefe";
            // 
            // txt_NumDocJefe
            // 
            this.txt_NumDocJefe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_NumDocJefe.Enabled = false;
            this.txt_NumDocJefe.Location = new System.Drawing.Point(621, 187);
            this.txt_NumDocJefe.Name = "txt_NumDocJefe";
            this.txt_NumDocJefe.pp_mensaje_error = null;
            this.txt_NumDocJefe.pp_nombre_campo = null;
            this.txt_NumDocJefe.pp_nombre_tabla = null;
            this.txt_NumDocJefe.pp_validable = false;
            this.txt_NumDocJefe.Size = new System.Drawing.Size(206, 30);
            this.txt_NumDocJefe.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(478, 154);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 25);
            this.label15.TabIndex = 19;
            this.label15.Text = "Tipo Doc Jefe";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(523, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 25);
            this.label14.TabIndex = 18;
            this.label14.Text = "Telefono";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(552, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 25);
            this.label13.TabIndex = 17;
            this.label13.Text = "Barrio";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(71, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 25);
            this.label12.TabIndex = 16;
            this.label12.Text = "Direccion";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(82, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 25);
            this.label11.TabIndex = 15;
            this.label11.Text = "Apellido";
            // 
            // cmb_TipoDocJefe
            // 
            this.cmb_TipoDocJefe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_TipoDocJefe.Enabled = false;
            this.cmb_TipoDocJefe.FormattingEnabled = true;
            this.cmb_TipoDocJefe.Location = new System.Drawing.Point(621, 149);
            this.cmb_TipoDocJefe.Name = "cmb_TipoDocJefe";
            this.cmb_TipoDocJefe.pp_Display = null;
            this.cmb_TipoDocJefe.pp_mensaje_error = null;
            this.cmb_TipoDocJefe.pp_nombre_campo = null;
            this.cmb_TipoDocJefe.pp_nombre_tabla = null;
            this.cmb_TipoDocJefe.pp_Seleccionado = false;
            this.cmb_TipoDocJefe.pp_Tabla = null;
            this.cmb_TipoDocJefe.pp_validable = false;
            this.cmb_TipoDocJefe.pp_Value = null;
            this.cmb_TipoDocJefe.Size = new System.Drawing.Size(208, 33);
            this.cmb_TipoDocJefe.TabIndex = 14;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Telefono.Enabled = false;
            this.txt_Telefono.Location = new System.Drawing.Point(621, 115);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.pp_mensaje_error = null;
            this.txt_Telefono.pp_nombre_campo = null;
            this.txt_Telefono.pp_nombre_tabla = null;
            this.txt_Telefono.pp_validable = false;
            this.txt_Telefono.Size = new System.Drawing.Size(208, 30);
            this.txt_Telefono.TabIndex = 13;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Direccion.Enabled = false;
            this.txt_Direccion.Location = new System.Drawing.Point(170, 223);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.pp_mensaje_error = null;
            this.txt_Direccion.pp_nombre_campo = null;
            this.txt_Direccion.pp_nombre_tabla = null;
            this.txt_Direccion.pp_validable = false;
            this.txt_Direccion.Size = new System.Drawing.Size(208, 30);
            this.txt_Direccion.TabIndex = 12;
            // 
            // txt_NumDoc
            // 
            this.txt_NumDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_NumDoc.Enabled = false;
            this.txt_NumDoc.Location = new System.Drawing.Point(170, 115);
            this.txt_NumDoc.Name = "txt_NumDoc";
            this.txt_NumDoc.pp_mensaje_error = null;
            this.txt_NumDoc.pp_nombre_campo = "numDoc";
            this.txt_NumDoc.pp_nombre_tabla = "Empleados";
            this.txt_NumDoc.pp_validable = false;
            this.txt_NumDoc.Size = new System.Drawing.Size(208, 30);
            this.txt_NumDoc.TabIndex = 11;
            // 
            // txt_TipoDoc
            // 
            this.txt_TipoDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TipoDoc.Enabled = false;
            this.txt_TipoDoc.Location = new System.Drawing.Point(170, 79);
            this.txt_TipoDoc.Name = "txt_TipoDoc";
            this.txt_TipoDoc.pp_mensaje_error = null;
            this.txt_TipoDoc.pp_nombre_campo = null;
            this.txt_TipoDoc.pp_nombre_tabla = null;
            this.txt_TipoDoc.pp_validable = false;
            this.txt_TipoDoc.Size = new System.Drawing.Size(208, 30);
            this.txt_TipoDoc.TabIndex = 10;
            // 
            // cmb_barrio
            // 
            this.cmb_barrio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_barrio.Enabled = false;
            this.cmb_barrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_barrio.FormattingEnabled = true;
            this.cmb_barrio.Location = new System.Drawing.Point(621, 77);
            this.cmb_barrio.Name = "cmb_barrio";
            this.cmb_barrio.pp_Display = null;
            this.cmb_barrio.pp_mensaje_error = null;
            this.cmb_barrio.pp_nombre_campo = null;
            this.cmb_barrio.pp_nombre_tabla = null;
            this.cmb_barrio.pp_Seleccionado = false;
            this.cmb_barrio.pp_Tabla = null;
            this.cmb_barrio.pp_validable = false;
            this.cmb_barrio.pp_Value = null;
            this.cmb_barrio.Size = new System.Drawing.Size(208, 32);
            this.cmb_barrio.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(154, -3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(587, 69);
            this.label10.TabIndex = 8;
            this.label10.Text = "Consultar Empleado";
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
            this.label9.Location = new System.Drawing.Point(83, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nro Documento";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tipo Documento";
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Apellido.Enabled = false;
            this.txt_Apellido.Location = new System.Drawing.Point(170, 187);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.pp_mensaje_error = null;
            this.txt_Apellido.pp_nombre_campo = null;
            this.txt_Apellido.pp_nombre_tabla = null;
            this.txt_Apellido.pp_validable = false;
            this.txt_Apellido.Size = new System.Drawing.Size(208, 30);
            this.txt_Apellido.TabIndex = 2;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Nombre.Enabled = false;
            this.txt_Nombre.Location = new System.Drawing.Point(170, 151);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.pp_mensaje_error = null;
            this.txt_Nombre.pp_nombre_campo = null;
            this.txt_Nombre.pp_nombre_tabla = null;
            this.txt_Nombre.pp_validable = false;
            this.txt_Nombre.Size = new System.Drawing.Size(208, 30);
            this.txt_Nombre.TabIndex = 0;
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
            // ConsultarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 749);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.Panel_ModificarCliente);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_limpiarCampo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ConsultarEmpleados";
            this.Text = "ModificarBarrio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.btn_limpiarCampo.ResumeLayout(false);
            this.btn_limpiarCampo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Panel_ModificarCliente.ResumeLayout(false);
            this.Panel_ModificarCliente.PerformLayout();
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
        private System.Windows.Forms.Panel Panel_ModificarCliente;
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
        private Clases.TextBox01 txt_Apellido;
        private Clases.TextBox01 txt_Nombre;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView grid01;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_salir;
        private Clases.ComboBox01 cmb_barrio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private Clases.ComboBox01 cmb_TipoDocJefe;
        private Clases.TextBox01 txt_Telefono;
        private Clases.TextBox01 txt_Direccion;
        private Clases.TextBox01 txt_NumDoc;
        private Clases.TextBox01 txt_TipoDoc;
        private System.Windows.Forms.Label label16;
        private Clases.TextBox01 txt_NumDocJefe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}