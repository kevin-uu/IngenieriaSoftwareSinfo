
namespace SINFO
{
    partial class FormRpInseminacionBFechas
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
            this.btnver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DSInseminacionBovina = new SINFO.DSInseminacionBovina();
            this.ReporteporfechasInseminacionBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteporfechasInseminacionBTableAdapter = new SINFO.DSInseminacionBovinaTableAdapters.ReporteporfechasInseminacionBTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSInseminacionBovina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteporfechasInseminacionBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnver
            // 
            this.btnver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnver.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnver.FlatAppearance.BorderSize = 0;
            this.btnver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(220)))));
            this.btnver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnver.Location = new System.Drawing.Point(623, 25);
            this.btnver.Name = "btnver";
            this.btnver.Size = new System.Drawing.Size(126, 21);
            this.btnver.TabIndex = 76;
            this.btnver.Text = "Ver Informe";
            this.btnver.UseVisualStyleBackColor = false;
            this.btnver.Click += new System.EventHandler(this.btnver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(327, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 75;
            this.label1.Text = "Hasta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(33, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 74;
            this.label7.Text = "Desde:";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(396, 27);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFinal.TabIndex = 73;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(103, 27);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 72;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReporteporfechasInseminacionBBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SINFO.InfInseminacionBovinaFechas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(798, 388);
            this.reportViewer1.TabIndex = 77;
            // 
            // DSInseminacionBovina
            // 
            this.DSInseminacionBovina.DataSetName = "DSInseminacionBovina";
            this.DSInseminacionBovina.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReporteporfechasInseminacionBBindingSource
            // 
            this.ReporteporfechasInseminacionBBindingSource.DataMember = "ReporteporfechasInseminacionB";
            this.ReporteporfechasInseminacionBBindingSource.DataSource = this.DSInseminacionBovina;
            // 
            // ReporteporfechasInseminacionBTableAdapter
            // 
            this.ReporteporfechasInseminacionBTableAdapter.ClearBeforeFill = true;
            // 
            // FormRpInseminacionBFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.dtpFechaInicio);
            this.Name = "FormRpInseminacionBFechas";
            this.Text = "FormRpInseminacionBFechas";
            this.Load += new System.EventHandler(this.FormRpInseminacionBFechas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSInseminacionBovina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteporfechasInseminacionBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteporfechasInseminacionBBindingSource;
        private DSInseminacionBovina DSInseminacionBovina;
        private DSInseminacionBovinaTableAdapters.ReporteporfechasInseminacionBTableAdapter ReporteporfechasInseminacionBTableAdapter;
    }
}