
namespace SINFO
{
    partial class FormRpSeguimientoFechas
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnver = new System.Windows.Forms.Button();
            this.ReporteporfechasseguimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSSeguimiento = new SINFO.DSSeguimiento();
            this.ReporteporfechasseguimientoTableAdapter = new SINFO.DSSeguimientoTableAdapters.ReporteporfechasseguimientoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteporfechasseguimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSSeguimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReporteporfechasseguimientoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SINFO.InfSeguimientoFechas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 72);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(805, 378);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(142, 13);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 1;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(435, 13);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFinal.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(72, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 69;
            this.label7.Text = "Desde:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(366, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 70;
            this.label1.Text = "Hasta:";
            // 
            // btnver
            // 
            this.btnver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnver.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnver.FlatAppearance.BorderSize = 0;
            this.btnver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(220)))));
            this.btnver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnver.Location = new System.Drawing.Point(662, 11);
            this.btnver.Name = "btnver";
            this.btnver.Size = new System.Drawing.Size(126, 21);
            this.btnver.TabIndex = 71;
            this.btnver.Text = "Ver Informe";
            this.btnver.UseVisualStyleBackColor = false;
            this.btnver.Click += new System.EventHandler(this.btnver_Click);
            // 
            // ReporteporfechasseguimientoBindingSource
            // 
            this.ReporteporfechasseguimientoBindingSource.DataMember = "Reporteporfechasseguimiento";
            this.ReporteporfechasseguimientoBindingSource.DataSource = this.DSSeguimiento;
            // 
            // DSSeguimiento
            // 
            this.DSSeguimiento.DataSetName = "DSSeguimiento";
            this.DSSeguimiento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReporteporfechasseguimientoTableAdapter
            // 
            this.ReporteporfechasseguimientoTableAdapter.ClearBeforeFill = true;
            // 
            // FormRpSeguimientoFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRpSeguimientoFechas";
            this.Text = "FormRpSeguimientoFechas";
            this.Load += new System.EventHandler(this.FormRpSeguimientoFechas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteporfechasseguimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSSeguimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnver;
        private System.Windows.Forms.BindingSource ReporteporfechasseguimientoBindingSource;
        private DSSeguimiento DSSeguimiento;
        private DSSeguimientoTableAdapters.ReporteporfechasseguimientoTableAdapter ReporteporfechasseguimientoTableAdapter;
    }
}