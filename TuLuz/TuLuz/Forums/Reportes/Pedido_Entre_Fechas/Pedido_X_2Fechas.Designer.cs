namespace TuLuz.Forums
{
    partial class Pedido_X_2Fechas
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.cmb_Mes_desde = new System.Windows.Forms.ComboBox();
            this.cmb_Dia_Desde = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_Mes_Hasta = new System.Windows.Forms.ComboBox();
            this.cmb_Dia_Hasta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_Año_Desde = new System.Windows.Forms.ComboBox();
            this.cmb_Año_Hasta = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.rv_listadoPedido_x_fecha = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(106, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(696, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de pedidos entre dos fechas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(882, 12);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(35, 39);
            this.btn_salir.TabIndex = 9;
            this.btn_salir.Text = "X";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // cmb_Mes_desde
            // 
            this.cmb_Mes_desde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Mes_desde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Mes_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Mes_desde.FormattingEnabled = true;
            this.cmb_Mes_desde.Items.AddRange(new object[] {
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
            this.cmb_Mes_desde.Location = new System.Drawing.Point(148, 93);
            this.cmb_Mes_desde.Name = "cmb_Mes_desde";
            this.cmb_Mes_desde.Size = new System.Drawing.Size(58, 24);
            this.cmb_Mes_desde.TabIndex = 34;
            this.cmb_Mes_desde.SelectedIndexChanged += new System.EventHandler(this.cmb_Mes_desde_SelectedIndexChanged);
            // 
            // cmb_Dia_Desde
            // 
            this.cmb_Dia_Desde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Dia_Desde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Dia_Desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Dia_Desde.FormattingEnabled = true;
            this.cmb_Dia_Desde.Location = new System.Drawing.Point(84, 93);
            this.cmb_Dia_Desde.Name = "cmb_Dia_Desde";
            this.cmb_Dia_Desde.Size = new System.Drawing.Size(58, 24);
            this.cmb_Dia_Desde.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(228, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 17);
            this.label11.TabIndex = 40;
            this.label11.Text = "Año";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(162, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Mes";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 38;
            this.label9.Text = "Desde";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(99, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Dia";
            // 
            // cmb_Mes_Hasta
            // 
            this.cmb_Mes_Hasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Mes_Hasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Mes_Hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Mes_Hasta.FormattingEnabled = true;
            this.cmb_Mes_Hasta.Items.AddRange(new object[] {
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
            this.cmb_Mes_Hasta.Location = new System.Drawing.Point(448, 94);
            this.cmb_Mes_Hasta.Name = "cmb_Mes_Hasta";
            this.cmb_Mes_Hasta.Size = new System.Drawing.Size(58, 24);
            this.cmb_Mes_Hasta.TabIndex = 41;
            this.cmb_Mes_Hasta.SelectedIndexChanged += new System.EventHandler(this.cmb_Mes_Hasta_SelectedIndexChanged);
            // 
            // cmb_Dia_Hasta
            // 
            this.cmb_Dia_Hasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Dia_Hasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Dia_Hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Dia_Hasta.FormattingEnabled = true;
            this.cmb_Dia_Hasta.Location = new System.Drawing.Point(384, 94);
            this.cmb_Dia_Hasta.Name = "cmb_Dia_Hasta";
            this.cmb_Dia_Hasta.Size = new System.Drawing.Size(58, 24);
            this.cmb_Dia_Hasta.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(528, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Año";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(462, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Mes";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(312, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 45;
            this.label5.Text = "Hasta";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(399, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Dia";
            // 
            // cmb_Año_Desde
            // 
            this.cmb_Año_Desde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Año_Desde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Año_Desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Año_Desde.FormattingEnabled = true;
            this.cmb_Año_Desde.Location = new System.Drawing.Point(212, 93);
            this.cmb_Año_Desde.Name = "cmb_Año_Desde";
            this.cmb_Año_Desde.Size = new System.Drawing.Size(58, 24);
            this.cmb_Año_Desde.TabIndex = 48;
            this.cmb_Año_Desde.SelectedIndexChanged += new System.EventHandler(this.cmb_Año_Desde_SelectedIndexChanged_1);
            this.cmb_Año_Desde.Click += new System.EventHandler(this.cmb_Año_Desde_Click);
            // 
            // cmb_Año_Hasta
            // 
            this.cmb_Año_Hasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Año_Hasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Año_Hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Año_Hasta.FormattingEnabled = true;
            this.cmb_Año_Hasta.Location = new System.Drawing.Point(512, 95);
            this.cmb_Año_Hasta.Name = "cmb_Año_Hasta";
            this.cmb_Año_Hasta.Size = new System.Drawing.Size(58, 24);
            this.cmb_Año_Hasta.TabIndex = 49;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_buscar.Location = new System.Drawing.Point(778, 92);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(95, 27);
            this.btn_buscar.TabIndex = 50;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // rv_listadoPedido_x_fecha
            // 
            this.rv_listadoPedido_x_fecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rv_listadoPedido_x_fecha.Location = new System.Drawing.Point(17, 147);
            this.rv_listadoPedido_x_fecha.Name = "rv_listadoPedido_x_fecha";
            this.rv_listadoPedido_x_fecha.ServerReport.BearerToken = null;
            this.rv_listadoPedido_x_fecha.Size = new System.Drawing.Size(856, 300);
            this.rv_listadoPedido_x_fecha.TabIndex = 51;
            // 
            // Pedido_X_2Fechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 545);
            this.Controls.Add(this.rv_listadoPedido_x_fecha);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.cmb_Año_Hasta);
            this.Controls.Add(this.cmb_Año_Desde);
            this.Controls.Add(this.cmb_Mes_Hasta);
            this.Controls.Add(this.cmb_Dia_Hasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_Mes_desde);
            this.Controls.Add(this.cmb_Dia_Desde);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label1);
            this.Name = "Pedido_X_2Fechas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pedido_X_2Fechas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.ComboBox cmb_Mes_desde;
        private System.Windows.Forms.ComboBox cmb_Dia_Desde;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_Mes_Hasta;
        private System.Windows.Forms.ComboBox cmb_Dia_Hasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_Año_Desde;
        private System.Windows.Forms.ComboBox cmb_Año_Hasta;
        private System.Windows.Forms.Button btn_buscar;
        private Microsoft.Reporting.WinForms.ReportViewer rv_listadoPedido_x_fecha;
    }
}