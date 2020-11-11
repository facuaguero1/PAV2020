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
            this.rv_listadoPedido_x_fecha = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_fechaDesde = new TuLuz.Clases.LabelText01();
            this.txt_fechaHasta = new TuLuz.Clases.LabelText01();
            this.btn_buscar = new System.Windows.Forms.Button();
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
            // rv_listadoPedido_x_fecha
            // 
            this.rv_listadoPedido_x_fecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rv_listadoPedido_x_fecha.Location = new System.Drawing.Point(88, 125);
            this.rv_listadoPedido_x_fecha.Name = "rv_listadoPedido_x_fecha";
            this.rv_listadoPedido_x_fecha.ServerReport.BearerToken = null;
            this.rv_listadoPedido_x_fecha.Size = new System.Drawing.Size(702, 408);
            this.rv_listadoPedido_x_fecha.TabIndex = 51;
            // 
            // txt_fechaDesde
            // 
            this.txt_fechaDesde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_fechaDesde.Location = new System.Drawing.Point(88, 70);
            this.txt_fechaDesde.Name = "txt_fechaDesde";
            this.txt_fechaDesde.PP_Ancho = 10;
            this.txt_fechaDesde.PP_Decimales = 2;
            this.txt_fechaDesde.PP_Etiqueta = "Desde";
            this.txt_fechaDesde.PP_Mensaje_Error = null;
            this.txt_fechaDesde.PP_Nombre_Campo = null;
            this.txt_fechaDesde.PP_Nombre_Tabla = null;
            this.txt_fechaDesde.PP_ReadOnly = false;
            this.txt_fechaDesde.PP_Text = "  /  /";
            this.txt_fechaDesde.PP_TipoDato = TuLuz.Clases.LabelText01.TipoDato.fecha;
            this.txt_fechaDesde.PP_Validable = false;
            this.txt_fechaDesde.Size = new System.Drawing.Size(246, 49);
            this.txt_fechaDesde.TabIndex = 52;
            // 
            // txt_fechaHasta
            // 
            this.txt_fechaHasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_fechaHasta.Location = new System.Drawing.Point(365, 70);
            this.txt_fechaHasta.Name = "txt_fechaHasta";
            this.txt_fechaHasta.PP_Ancho = 10;
            this.txt_fechaHasta.PP_Decimales = 2;
            this.txt_fechaHasta.PP_Etiqueta = "Hasta";
            this.txt_fechaHasta.PP_Mensaje_Error = null;
            this.txt_fechaHasta.PP_Nombre_Campo = null;
            this.txt_fechaHasta.PP_Nombre_Tabla = null;
            this.txt_fechaHasta.PP_ReadOnly = false;
            this.txt_fechaHasta.PP_Text = "  /  /";
            this.txt_fechaHasta.PP_TipoDato = TuLuz.Clases.LabelText01.TipoDato.fecha;
            this.txt_fechaHasta.PP_Validable = false;
            this.txt_fechaHasta.Size = new System.Drawing.Size(249, 49);
            this.txt_fechaHasta.TabIndex = 53;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_buscar.BackgroundImage = global::TuLuz.Properties.Resources.buscar;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(728, 80);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(49, 39);
            this.btn_buscar.TabIndex = 50;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // Pedido_X_2Fechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 545);
            this.Controls.Add(this.txt_fechaHasta);
            this.Controls.Add(this.txt_fechaDesde);
            this.Controls.Add(this.rv_listadoPedido_x_fecha);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label1);
            this.Name = "Pedido_X_2Fechas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_buscar;
        private Microsoft.Reporting.WinForms.ReportViewer rv_listadoPedido_x_fecha;
        private Clases.LabelText01 txt_fechaDesde;
        private Clases.LabelText01 txt_fechaHasta;
    }
}