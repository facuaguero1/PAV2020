namespace TuLuz.Forums
{
    partial class Login
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.labelUsr = new System.Windows.Forms.Label();
            this.labelPswd = new System.Windows.Forms.Label();
            this.txt_Usr = new System.Windows.Forms.TextBox();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Login.Location = new System.Drawing.Point(190, 209);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(129, 23);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Iniciar Sesion";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // labelUsr
            // 
            this.labelUsr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsr.AutoSize = true;
            this.labelUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsr.Location = new System.Drawing.Point(133, 152);
            this.labelUsr.Name = "labelUsr";
            this.labelUsr.Size = new System.Drawing.Size(71, 20);
            this.labelUsr.TabIndex = 1;
            this.labelUsr.Text = "Usuario";
            // 
            // labelPswd
            // 
            this.labelPswd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPswd.AutoSize = true;
            this.labelPswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPswd.Location = new System.Drawing.Point(102, 181);
            this.labelPswd.Name = "labelPswd";
            this.labelPswd.Size = new System.Drawing.Size(102, 20);
            this.labelPswd.TabIndex = 2;
            this.labelPswd.Text = "Contraseña";
            // 
            // txt_Usr
            // 
            this.txt_Usr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Usr.Location = new System.Drawing.Point(219, 152);
            this.txt_Usr.Name = "txt_Usr";
            this.txt_Usr.Size = new System.Drawing.Size(100, 20);
            this.txt_Usr.TabIndex = 0;
            this.txt_Usr.TextChanged += new System.EventHandler(this.txt_Usr_TextChanged);
            // 
            // txtPsw
            // 
            this.txtPsw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPsw.Location = new System.Drawing.Point(219, 183);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.Size = new System.Drawing.Size(100, 20);
            this.txtPsw.TabIndex = 1;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Salir.Location = new System.Drawing.Point(106, 209);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(78, 23);
            this.btn_Salir.TabIndex = 2;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 400);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::TuLuz.Properties.Resources.slide_1472495120664_4845717524_c0ed47e25824430f4f77768391ecc60c1511935102_1920_1920;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.labelPswd);
            this.panel2.Controls.Add(this.labelUsr);
            this.panel2.Controls.Add(this.btn_Login);
            this.panel2.Controls.Add(this.txt_Usr);
            this.panel2.Controls.Add(this.btn_Salir);
            this.panel2.Controls.Add(this.txtPsw);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(240, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 400);
            this.panel2.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 400);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label labelUsr;
        private System.Windows.Forms.Label labelPswd;
        private System.Windows.Forms.TextBox txt_Usr;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}