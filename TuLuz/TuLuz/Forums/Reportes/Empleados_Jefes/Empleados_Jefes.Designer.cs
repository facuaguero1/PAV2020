namespace TuLuz.Forums.Reportes.Empleados_Jefes
{
    partial class Empleados_Jefes
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
            this.ReporteEmpleados_Jefe = new TuLuz.Forums.Reportes.Empleados_Jefes.ReporteEmpleados_Jefe();
            this.label1 = new System.Windows.Forms.Label();
            this.rv_listadoEmpleados_Jefes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_tipoDoc = new System.Windows.Forms.TextBox();
            this.txt_numDoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteEmpleados_Jefe)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.ReporteEmpleados_Jefe;
            // 
            // ReporteEmpleados_Jefe
            // 
            this.ReporteEmpleados_Jefe.DataSetName = "ReporteEmpleados_Jefe";
            this.ReporteEmpleados_Jefe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(103, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(691, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de Empleados Supervisores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rv_listadoEmpleados_Jefes
            // 
            this.rv_listadoEmpleados_Jefes.Anchor = System.Windows.Forms.AnchorStyles.None;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.DataTable1BindingSource;
            this.rv_listadoEmpleados_Jefes.LocalReport.DataSources.Add(reportDataSource2);
            this.rv_listadoEmpleados_Jefes.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Reportes.Empleados_Jefes.ReporteEmpleados_Jefes.rdlc";
            this.rv_listadoEmpleados_Jefes.Location = new System.Drawing.Point(64, 125);
            this.rv_listadoEmpleados_Jefes.Name = "rv_listadoEmpleados_Jefes";
            this.rv_listadoEmpleados_Jefes.ServerReport.BearerToken = null;
            this.rv_listadoEmpleados_Jefes.Size = new System.Drawing.Size(702, 408);
            this.rv_listadoEmpleados_Jefes.TabIndex = 2;
            this.rv_listadoEmpleados_Jefes.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_buscar.BackgroundImage = global::TuLuz.Properties.Resources.buscar;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(710, 86);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(56, 32);
            this.btn_buscar.TabIndex = 51;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_tipoDoc
            // 
            this.txt_tipoDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tipoDoc.Location = new System.Drawing.Point(231, 99);
            this.txt_tipoDoc.Name = "txt_tipoDoc";
            this.txt_tipoDoc.Size = new System.Drawing.Size(37, 20);
            this.txt_tipoDoc.TabIndex = 53;
            // 
            // txt_numDoc
            // 
            this.txt_numDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_numDoc.Location = new System.Drawing.Point(531, 99);
            this.txt_numDoc.Name = "txt_numDoc";
            this.txt_numDoc.Size = new System.Drawing.Size(100, 20);
            this.txt_numDoc.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 24);
            this.label2.TabIndex = 55;
            this.label2.Text = "Tipo Doc (JEFE)";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 24);
            this.label3.TabIndex = 56;
            this.label3.Text = "Numero Doc (JEFE)";
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(868, 25);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(35, 39);
            this.btn_salir.TabIndex = 57;
            this.btn_salir.Text = "X";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Empleados_Jefes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 545);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_numDoc);
            this.Controls.Add(this.txt_tipoDoc);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.rv_listadoEmpleados_Jefes);
            this.Controls.Add(this.label1);
            this.Name = "Empleados_Jefes";
            this.Text = "Empleados_Jefes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Empleados_Jefes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteEmpleados_Jefe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer rv_listadoEmpleados_Jefes;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private ReporteEmpleados_Jefe ReporteEmpleados_Jefe;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_tipoDoc;
        private System.Windows.Forms.TextBox txt_numDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_salir;
    }
}