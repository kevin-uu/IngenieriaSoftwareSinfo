
namespace SINFO
{
    partial class FormRpSeguimiento
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRpSeguimiento));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSSeguimiento = new SINFO.DSSeguimiento();
            this.DataTable1TableAdapter = new SINFO.DSSeguimientoTableAdapters.DataTable1TableAdapter();
            this.btnver = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSSeguimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SINFO.InfSeguimiento.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-2, 83);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(806, 368);
            this.reportViewer1.TabIndex = 64;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DSSeguimiento;
            // 
            // DSSeguimiento
            // 
            this.DSSeguimiento.DataSetName = "DSSeguimiento";
            this.DSSeguimiento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // btnver
            // 
            this.btnver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnver.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnver.FlatAppearance.BorderSize = 0;
            this.btnver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(220)))));
            this.btnver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnver.Location = new System.Drawing.Point(551, 19);
            this.btnver.Name = "btnver";
            this.btnver.Size = new System.Drawing.Size(126, 21);
            this.btnver.TabIndex = 66;
            this.btnver.Text = "Ver Informe";
            this.btnver.UseVisualStyleBackColor = false;
            this.btnver.Click += new System.EventHandler(this.btnver_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Estrategia Nacional Para El Desarrollo De La Ganadería Bovina Y Estrategia Para P" +
                "otenciar El Crecimiento Productivo Y Reproductivo Del Hato Ganadero",
            "Estrategia Nacional Para El Desarrollo Del Sector Porcino Nicaragüense",
            resources.GetString("comboBox1.Items")});
            this.comboBox1.Location = new System.Drawing.Point(150, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(382, 21);
            this.comboBox1.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(58, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 68;
            this.label7.Text = "Estrategia:";
            // 
            // FormRpSeguimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnver);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRpSeguimiento";
            this.Text = "FormRpSeguimiento";
            this.Load += new System.EventHandler(this.FormRpSeguimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSSeguimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DSSeguimiento DSSeguimiento;
        private DSSeguimientoTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        public System.Windows.Forms.Button btnver;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
    }
}