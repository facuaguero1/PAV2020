namespace TuLuz.Forums
{
    partial class AltaLocalidad
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
            this.label3 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_provincia = new TuLuz.Clases.ComboBox01();
            this.txt_nombreLocalidad = new TuLuz.Clases.TextBox01();
            this.txt_Cod_localidad = new TuLuz.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(298, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta de Localidad";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(264, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(258, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.btn_salir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_salir.Location = new System.Drawing.Point(1087, 12);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(35, 39);
            this.btn_salir.TabIndex = 9;
            this.btn_salir.Text = "X";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancelar.BackgroundImage = global::TuLuz.Properties.Resources.cancel_77947;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_cancelar.Location = new System.Drawing.Point(719, 440);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(90, 80);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_aceptar.BackgroundImage = global::TuLuz.Properties.Resources.ok_accept_15562;
            this.btn_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_aceptar.FlatAppearance.BorderSize = 0;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_aceptar.Location = new System.Drawing.Point(343, 440);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(90, 80);
            this.btn_aceptar.TabIndex = 7;
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(247, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Provincia";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackgroundImage = global::TuLuz.Properties.Resources._1486485588_add_create_new_math_sign_cross_plus_81186;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(828, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 32);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_provincia
            // 
            this.cmb_provincia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmb_provincia.FormattingEnabled = true;
            this.cmb_provincia.Location = new System.Drawing.Point(356, 373);
            this.cmb_provincia.Name = "cmb_provincia";
            this.cmb_provincia.pp_Display = null;
            this.cmb_provincia.pp_mensaje_error = null;
            this.cmb_provincia.pp_nombre_campo = null;
            this.cmb_provincia.pp_nombre_tabla = null;
            this.cmb_provincia.pp_Seleccionado = false;
            this.cmb_provincia.pp_Tabla = null;
            this.cmb_provincia.pp_validable = false;
            this.cmb_provincia.pp_Value = null;
            this.cmb_provincia.Size = new System.Drawing.Size(466, 32);
            this.cmb_provincia.TabIndex = 11;
            this.cmb_provincia.Click += new System.EventHandler(this.cmb_provincia_Click);
            // 
            // txt_nombreLocalidad
            // 
            this.txt_nombreLocalidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nombreLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_nombreLocalidad.Location = new System.Drawing.Point(356, 327);
            this.txt_nombreLocalidad.Name = "txt_nombreLocalidad";
            this.txt_nombreLocalidad.pp_mensaje_error = "No se ingreso un nombre!";
            this.txt_nombreLocalidad.pp_nombre_campo = "nombre";
            this.txt_nombreLocalidad.pp_nombre_tabla = "Provincia";
            this.txt_nombreLocalidad.pp_validable = true;
            this.txt_nombreLocalidad.Size = new System.Drawing.Size(466, 30);
            this.txt_nombreLocalidad.TabIndex = 5;
            // 
            // txt_Cod_localidad
            // 
            this.txt_Cod_localidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Cod_localidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_Cod_localidad.Location = new System.Drawing.Point(356, 280);
            this.txt_Cod_localidad.Name = "txt_Cod_localidad";
            this.txt_Cod_localidad.pp_mensaje_error = "No se ingreso un código!";
            this.txt_Cod_localidad.pp_nombre_campo = "codProvincia";
            this.txt_Cod_localidad.pp_nombre_tabla = "Provincia";
            this.txt_Cod_localidad.pp_validable = true;
            this.txt_Cod_localidad.Size = new System.Drawing.Size(466, 30);
            this.txt_Cod_localidad.TabIndex = 4;
            this.txt_Cod_localidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cod_localidad_KeyPress);
            // 
            // AltaLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 749);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_provincia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_nombreLocalidad);
            this.Controls.Add(this.txt_Cod_localidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(240, 0);
            this.Name = "AltaLocalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.AltaLocalidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Clases.TextBox01 txt_Cod_localidad;
        private Clases.TextBox01 txt_nombreLocalidad;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label4;
        private Clases.ComboBox01 cmb_provincia;
        private System.Windows.Forms.Button button1;
    }
}