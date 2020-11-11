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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteEmpleados_Jefe = new TuLuz.Forums.Reportes.Empleados_Jefes.ReporteEmpleados_Jefe();
            this.label1 = new System.Windows.Forms.Label();
            this.rv_listadoEmpleados_Jefes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.chk_todos = new System.Windows.Forms.CheckBox();
            this.cmb_nro_doc = new TuLuz.Clases.ComboBox01();
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
            this.label1.Location = new System.Drawing.Point(103, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(691, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de Empleados Supervisores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rv_listadoEmpleados_Jefes
            // 
            this.rv_listadoEmpleados_Jefes.Anchor = System.Windows.Forms.AnchorStyles.None;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.rv_listadoEmpleados_Jefes.LocalReport.DataSources.Add(reportDataSource1);
            this.rv_listadoEmpleados_Jefes.LocalReport.ReportEmbeddedResource = "TuLuz.Forums.Reportes.Empleados_Jefes.ReporteEmpleados_Jefes.rdlc";
            this.rv_listadoEmpleados_Jefes.Location = new System.Drawing.Point(64, 140);
            this.rv_listadoEmpleados_Jefes.Name = "rv_listadoEmpleados_Jefes";
            this.rv_listadoEmpleados_Jefes.ServerReport.BearerToken = null;
            this.rv_listadoEmpleados_Jefes.Size = new System.Drawing.Size(702, 393);
            this.rv_listadoEmpleados_Jefes.TabIndex = 2;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_buscar.BackgroundImage = global::TuLuz.Properties.Resources.buscar;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(480, 77);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(52, 32);
            this.btn_buscar.TabIndex = 51;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 25);
            this.label3.TabIndex = 56;
            this.label3.Text = "Numero Documento";
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
            this.btn_salir.TabIndex = 57;
            this.btn_salir.Text = "X";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // chk_todos
            // 
            this.chk_todos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chk_todos.AutoSize = true;
            this.chk_todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_todos.Location = new System.Drawing.Point(274, 113);
            this.chk_todos.Name = "chk_todos";
            this.chk_todos.Size = new System.Drawing.Size(123, 21);
            this.chk_todos.TabIndex = 59;
            this.chk_todos.Text = "Todos los jefes";
            this.chk_todos.UseVisualStyleBackColor = true;
            this.chk_todos.CheckedChanged += new System.EventHandler(this.chk_todos_CheckedChanged);
            // 
            // cmb_nro_doc
            // 
            this.cmb_nro_doc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_nro_doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_nro_doc.FormattingEnabled = true;
            this.cmb_nro_doc.Location = new System.Drawing.Point(274, 77);
            this.cmb_nro_doc.Name = "cmb_nro_doc";
            this.cmb_nro_doc.pp_Display = null;
            this.cmb_nro_doc.pp_mensaje_error = null;
            this.cmb_nro_doc.pp_nombre_campo = null;
            this.cmb_nro_doc.pp_nombre_tabla = null;
            this.cmb_nro_doc.pp_Seleccionado = false;
            this.cmb_nro_doc.pp_Tabla = null;
            this.cmb_nro_doc.pp_validable = false;
            this.cmb_nro_doc.pp_Value = null;
            this.cmb_nro_doc.Size = new System.Drawing.Size(187, 32);
            this.cmb_nro_doc.TabIndex = 58;
            this.cmb_nro_doc.SelectedIndexChanged += new System.EventHandler(this.cmb_nro_doc_SelectedIndexChanged);
            // 
            // Empleados_Jefes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 545);
            this.Controls.Add(this.chk_todos);
            this.Controls.Add(this.cmb_nro_doc);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_salir;
        private Clases.ComboBox01 cmb_nro_doc;
        private System.Windows.Forms.CheckBox chk_todos;
    }
}