namespace TuLuz.Forums.Reportes.Proveedores_Activos_Inactivos
{
    partial class Proveedores_Activos_Inactivos
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RepProveedores_Activos_Inactivos = new TuLuz.Forums.Reportes.Proveedores_Activos_Inactivos.RepProveedores_Activos_Inactivos();
            this.label1 = new System.Windows.Forms.Label();
            this.rv_Proveedores_Activos_NoActivos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.checkBoxActivo = new System.Windows.Forms.CheckBox();
            this.checkBoxNoActivo = new System.Windows.Forms.CheckBox();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepProveedores_Activos_Inactivos)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.RepProveedores_Activos_Inactivos;
            // 
            // RepProveedores_Activos_Inactivos
            // 
            this.RepProveedores_Activos_Inactivos.DataSetName = "RepProveedores_Activos_Inactivos";
            this.RepProveedores_Activos_Inactivos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(654, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedores Activos y No Activos\r\n";
            // 
            // rv_Proveedores_Activos_NoActivos
            // 
            this.rv_Proveedores_Activos_NoActivos.Anchor = System.Windows.Forms.AnchorStyles.None;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.DataTable1BindingSource;
            this.rv_Proveedores_Activos_NoActivos.LocalReport.DataSources.Add(reportDataSource4);
            this.rv_Proveedores_Activos_NoActivos.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Reportes.Proveedores_Activos_Inactivos.Proveedores_Activos_Inactivos" +
    ".rdlc";
            this.rv_Proveedores_Activos_NoActivos.Location = new System.Drawing.Point(100, 103);
            this.rv_Proveedores_Activos_NoActivos.Name = "rv_Proveedores_Activos_NoActivos";
            this.rv_Proveedores_Activos_NoActivos.ServerReport.BearerToken = null;
            this.rv_Proveedores_Activos_NoActivos.Size = new System.Drawing.Size(702, 408);
            this.rv_Proveedores_Activos_NoActivos.TabIndex = 1;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_buscar.BackgroundImage = global::TuLuz.Properties.Resources.buscar;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(277, 52);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(54, 45);
            this.btn_buscar.TabIndex = 53;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click_1);
            // 
            // checkBoxActivo
            // 
            this.checkBoxActivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxActivo.AutoSize = true;
            this.checkBoxActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxActivo.Location = new System.Drawing.Point(106, 52);
            this.checkBoxActivo.Name = "checkBoxActivo";
            this.checkBoxActivo.Size = new System.Drawing.Size(77, 24);
            this.checkBoxActivo.TabIndex = 55;
            this.checkBoxActivo.Text = "Activo";
            this.checkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // checkBoxNoActivo
            // 
            this.checkBoxNoActivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxNoActivo.AutoSize = true;
            this.checkBoxNoActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNoActivo.Location = new System.Drawing.Point(106, 73);
            this.checkBoxNoActivo.Name = "checkBoxNoActivo";
            this.checkBoxNoActivo.Size = new System.Drawing.Size(104, 24);
            this.checkBoxNoActivo.TabIndex = 56;
            this.checkBoxNoActivo.Text = "No Activo";
            this.checkBoxNoActivo.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(882, 12);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(35, 37);
            this.btn_salir.TabIndex = 57;
            this.btn_salir.Text = "X";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Proveedores_Activos_Inactivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 545);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.checkBoxNoActivo);
            this.Controls.Add(this.checkBoxActivo);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.rv_Proveedores_Activos_NoActivos);
            this.Controls.Add(this.label1);
            this.Name = "Proveedores_Activos_Inactivos";
            this.Text = "Proveedores_Activos_Inactivos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepProveedores_Activos_Inactivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer rv_Proveedores_Activos_NoActivos;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private RepProveedores_Activos_Inactivos RepProveedores_Activos_Inactivos;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.CheckBox checkBoxActivo;
        private System.Windows.Forms.CheckBox checkBoxNoActivo;
        private System.Windows.Forms.Button btn_salir;
    }
}