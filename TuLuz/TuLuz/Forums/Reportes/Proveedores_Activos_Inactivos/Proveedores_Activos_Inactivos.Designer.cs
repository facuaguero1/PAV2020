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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RepProveedores_Activos_Inactivos = new TuLuz.Forums.Reportes.Proveedores_Activos_Inactivos.RepProveedores_Activos_Inactivos();
            this.label1 = new System.Windows.Forms.Label();
            this.rv_Proveedores_Activos_NoActivos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.checkBoxActivo = new System.Windows.Forms.CheckBox();
            this.checkBoxNoActivo = new System.Windows.Forms.CheckBox();
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
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROVEEDORES ACTIVOS Y NO ACTIVOS";
            // 
            // rv_Proveedores_Activos_NoActivos
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.DataTable1BindingSource;
            this.rv_Proveedores_Activos_NoActivos.LocalReport.DataSources.Add(reportDataSource2);
            this.rv_Proveedores_Activos_NoActivos.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Reportes.Proveedores_Activos_Inactivos.Proveedores_Activos_Inactivos" +
    ".rdlc";
            this.rv_Proveedores_Activos_NoActivos.Location = new System.Drawing.Point(44, 103);
            this.rv_Proveedores_Activos_NoActivos.Name = "rv_Proveedores_Activos_NoActivos";
            this.rv_Proveedores_Activos_NoActivos.ServerReport.BearerToken = null;
            this.rv_Proveedores_Activos_NoActivos.Size = new System.Drawing.Size(685, 271);
            this.rv_Proveedores_Activos_NoActivos.TabIndex = 1;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancelar.BackgroundImage = global::TuLuz.Properties.Resources.cancel_77947;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(492, 408);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(72, 68);
            this.btn_cancelar.TabIndex = 54;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_buscar.BackgroundImage = global::TuLuz.Properties.Resources.buscar;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(150, 408);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(66, 55);
            this.btn_buscar.TabIndex = 53;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click_1);
            // 
            // checkBoxActivo
            // 
            this.checkBoxActivo.AutoSize = true;
            this.checkBoxActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxActivo.Location = new System.Drawing.Point(208, 63);
            this.checkBoxActivo.Name = "checkBoxActivo";
            this.checkBoxActivo.Size = new System.Drawing.Size(77, 24);
            this.checkBoxActivo.TabIndex = 55;
            this.checkBoxActivo.Text = "Activo";
            this.checkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // checkBoxNoActivo
            // 
            this.checkBoxNoActivo.AutoSize = true;
            this.checkBoxNoActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNoActivo.Location = new System.Drawing.Point(391, 63);
            this.checkBoxNoActivo.Name = "checkBoxNoActivo";
            this.checkBoxNoActivo.Size = new System.Drawing.Size(104, 24);
            this.checkBoxNoActivo.TabIndex = 56;
            this.checkBoxNoActivo.Text = "No Activo";
            this.checkBoxNoActivo.UseVisualStyleBackColor = true;
            // 
            // Proveedores_Activos_Inactivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 497);
            this.Controls.Add(this.checkBoxNoActivo);
            this.Controls.Add(this.checkBoxActivo);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.rv_Proveedores_Activos_NoActivos);
            this.Controls.Add(this.label1);
            this.Name = "Proveedores_Activos_Inactivos";
            this.Text = "Proveedores_Activos_Inactivos";
            this.Load += new System.EventHandler(this.Proveedores_Activos_Inactivos_Load);
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
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.CheckBox checkBoxActivo;
        private System.Windows.Forms.CheckBox checkBoxNoActivo;
    }
}