namespace TuLuz.Forums
{
    partial class CotizacionesXEmpleados
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.RVCotizacionesXEmpleados = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmb_Empleados = new TuLuz.Clases.ComboBox01();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(97, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(737, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de Cotizaciones por empleado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empleado:";
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
            // RVCotizacionesXEmpleados
            // 
            this.RVCotizacionesXEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RVCotizacionesXEmpleados.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Reportes.PedidosXEmpleados.PedidosXEmpleados.rdlc";
            this.RVCotizacionesXEmpleados.Location = new System.Drawing.Point(105, 128);
            this.RVCotizacionesXEmpleados.Name = "RVCotizacionesXEmpleados";
            this.RVCotizacionesXEmpleados.ServerReport.BearerToken = null;
            this.RVCotizacionesXEmpleados.Size = new System.Drawing.Size(702, 408);
            this.RVCotizacionesXEmpleados.TabIndex = 11;
            // 
            // cmb_Empleados
            // 
            this.cmb_Empleados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Empleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Empleados.FormattingEnabled = true;
            this.cmb_Empleados.Location = new System.Drawing.Point(209, 90);
            this.cmb_Empleados.Name = "cmb_Empleados";
            this.cmb_Empleados.pp_Display = null;
            this.cmb_Empleados.pp_mensaje_error = null;
            this.cmb_Empleados.pp_nombre_campo = null;
            this.cmb_Empleados.pp_nombre_tabla = null;
            this.cmb_Empleados.pp_Seleccionado = false;
            this.cmb_Empleados.pp_Tabla = null;
            this.cmb_Empleados.pp_validable = false;
            this.cmb_Empleados.pp_Value = null;
            this.cmb_Empleados.Size = new System.Drawing.Size(158, 32);
            this.cmb_Empleados.TabIndex = 10;
            this.cmb_Empleados.SelectedIndexChanged += new System.EventHandler(this.cmb_Empleados_SelectedIndexChanged);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Buscar.BackgroundImage = global::TuLuz.Properties.Resources.buscar;
            this.btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Location = new System.Drawing.Point(399, 90);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(52, 32);
            this.btn_Buscar.TabIndex = 12;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // CotizacionesXEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 545);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.RVCotizacionesXEmpleados);
            this.Controls.Add(this.cmb_Empleados);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CotizacionesXEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CotizacionesXEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_salir;
        private Clases.ComboBox01 cmb_Empleados;
        private Microsoft.Reporting.WinForms.ReportViewer RVCotizacionesXEmpleados;
        private System.Windows.Forms.Button btn_Buscar;
    }
}