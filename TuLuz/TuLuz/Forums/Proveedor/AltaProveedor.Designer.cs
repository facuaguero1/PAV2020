namespace TuLuz.Forums
{
    partial class AltaProveedor
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
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_telefono = new TuLuz.Clases.TextBox01();
            this.txt_contacto = new TuLuz.Clases.TextBox01();
            this.txt_RazonSocial = new TuLuz.Clases.TextBox01();
            this.txt_Cuit_Proveedor = new TuLuz.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(79, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta de Proveedor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cuit";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Razon Social";
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(712, 12);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(35, 39);
            this.btn_salir.TabIndex = 9;
            this.btn_salir.Text = "X";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Contacto";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancelar.BackgroundImage = global::TuLuz.Properties.Resources.cancel_77947;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(531, 345);
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
            this.btn_aceptar.Location = new System.Drawing.Point(155, 345);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(90, 80);
            this.btn_aceptar.TabIndex = 7;
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Telefono";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.Location = new System.Drawing.Point(168, 277);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.pp_mensaje_error = "No se ingreso algun dato";
            this.txt_telefono.pp_nombre_campo = null;
            this.txt_telefono.pp_nombre_tabla = null;
            this.txt_telefono.pp_validable = false;
            this.txt_telefono.Size = new System.Drawing.Size(466, 30);
            this.txt_telefono.TabIndex = 12;
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_KeyPress);
            // 
            // txt_contacto
            // 
            this.txt_contacto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_contacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contacto.Location = new System.Drawing.Point(168, 231);
            this.txt_contacto.Name = "txt_contacto";
            this.txt_contacto.pp_mensaje_error = "No se ingreso algun dato";
            this.txt_contacto.pp_nombre_campo = null;
            this.txt_contacto.pp_nombre_tabla = null;
            this.txt_contacto.pp_validable = false;
            this.txt_contacto.Size = new System.Drawing.Size(466, 30);
            this.txt_contacto.TabIndex = 11;
            // 
            // txt_RazonSocial
            // 
            this.txt_RazonSocial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_RazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RazonSocial.Location = new System.Drawing.Point(168, 183);
            this.txt_RazonSocial.Name = "txt_RazonSocial";
            this.txt_RazonSocial.pp_mensaje_error = "No se ingreso algun dato";
            this.txt_RazonSocial.pp_nombre_campo = "nombre";
            this.txt_RazonSocial.pp_nombre_tabla = "Provincia";
            this.txt_RazonSocial.pp_validable = true;
            this.txt_RazonSocial.Size = new System.Drawing.Size(466, 30);
            this.txt_RazonSocial.TabIndex = 5;
            // 
            // txt_Cuit_Proveedor
            // 
            this.txt_Cuit_Proveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Cuit_Proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cuit_Proveedor.Location = new System.Drawing.Point(168, 138);
            this.txt_Cuit_Proveedor.Name = "txt_Cuit_Proveedor";
            this.txt_Cuit_Proveedor.pp_mensaje_error = "No se ingreso algun dato";
            this.txt_Cuit_Proveedor.pp_nombre_campo = "codProvincia";
            this.txt_Cuit_Proveedor.pp_nombre_tabla = "Provincia";
            this.txt_Cuit_Proveedor.pp_validable = true;
            this.txt_Cuit_Proveedor.Size = new System.Drawing.Size(466, 30);
            this.txt_Cuit_Proveedor.TabIndex = 4;
            this.txt_Cuit_Proveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cuit_Proveedor_KeyPress);
            // 
            // AltaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 465);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_contacto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_RazonSocial);
            this.Controls.Add(this.txt_Cuit_Proveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AltaProveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Clases.TextBox01 txt_Cuit_Proveedor;
        private Clases.TextBox01 txt_RazonSocial;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label4;
        private Clases.TextBox01 txt_contacto;
        private Clases.TextBox01 txt_telefono;
        private System.Windows.Forms.Label label5;
    }
}