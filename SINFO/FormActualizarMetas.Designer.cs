
namespace SINFO
{
    partial class FormActualizarMetas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvActualizarMetas = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnguardarM = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipodeActividad = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEstrategia = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbInstitucion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualizarMetas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActualizarMetas
            // 
            this.dgvActualizarMetas.AllowUserToAddRows = false;
            this.dgvActualizarMetas.AllowUserToDeleteRows = false;
            this.dgvActualizarMetas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActualizarMetas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActualizarMetas.BackgroundColor = System.Drawing.Color.White;
            this.dgvActualizarMetas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvActualizarMetas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvActualizarMetas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(69)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(69)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActualizarMetas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActualizarMetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActualizarMetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            this.dgvActualizarMetas.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(69)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActualizarMetas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvActualizarMetas.Location = new System.Drawing.Point(12, 136);
            this.dgvActualizarMetas.Name = "dgvActualizarMetas";
            this.dgvActualizarMetas.ReadOnly = true;
            this.dgvActualizarMetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActualizarMetas.Size = new System.Drawing.Size(828, 350);
            this.dgvActualizarMetas.TabIndex = 1;
            this.dgvActualizarMetas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActualizarMetas_CellClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::SINFO.Properties.Resources.editar;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::SINFO.Properties.Resources.borrar;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // btnguardarM
            // 
            this.btnguardarM.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnguardarM.FlatAppearance.BorderSize = 0;
            this.btnguardarM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(220)))));
            this.btnguardarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(69)))), ((int)(((byte)(27)))));
            this.btnguardarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarM.Location = new System.Drawing.Point(12, 89);
            this.btnguardarM.Name = "btnguardarM";
            this.btnguardarM.Size = new System.Drawing.Size(97, 32);
            this.btnguardarM.TabIndex = 153;
            this.btnguardarM.Text = "Actualizar";
            this.btnguardarM.UseVisualStyleBackColor = false;
            this.btnguardarM.Click += new System.EventHandler(this.btnguardarM_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(552, 55);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 161;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(473, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 160;
            this.label2.Text = "Cantidad:";
            // 
            // cmbTipodeActividad
            // 
            this.cmbTipodeActividad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipodeActividad.FormattingEnabled = true;
            this.cmbTipodeActividad.Location = new System.Drawing.Point(552, 16);
            this.cmbTipodeActividad.Name = "cmbTipodeActividad";
            this.cmbTipodeActividad.Size = new System.Drawing.Size(250, 21);
            this.cmbTipodeActividad.TabIndex = 159;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(28, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 158;
            this.label7.Text = "Estrategia:";
            // 
            // cmbEstrategia
            // 
            this.cmbEstrategia.FormattingEnabled = true;
            this.cmbEstrategia.Location = new System.Drawing.Point(110, 15);
            this.cmbEstrategia.Name = "cmbEstrategia";
            this.cmbEstrategia.Size = new System.Drawing.Size(283, 21);
            this.cmbEstrategia.TabIndex = 157;
            this.cmbEstrategia.SelectedIndexChanged += new System.EventHandler(this.cmbEstrategia_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(449, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 156;
            this.label6.Text = "Tipo de Actividad:";
            // 
            // cmbInstitucion
            // 
            this.cmbInstitucion.FormattingEnabled = true;
            this.cmbInstitucion.Location = new System.Drawing.Point(167, 51);
            this.cmbInstitucion.Name = "cmbInstitucion";
            this.cmbInstitucion.Size = new System.Drawing.Size(283, 21);
            this.cmbInstitucion.TabIndex = 155;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(-1, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 17);
            this.label5.TabIndex = 154;
            this.label5.Text = "Institucion Responsable:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(300, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 163;
            this.label1.Text = "Fecha de Registro:";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(403, 93);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaRegistro.TabIndex = 162;
            // 
            // FormActualizarMetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(852, 508);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaRegistro);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTipodeActividad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbEstrategia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbInstitucion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnguardarM);
            this.Controls.Add(this.dgvActualizarMetas);
            this.Name = "FormActualizarMetas";
            this.Text = "FormActualizarMetas";
            this.Load += new System.EventHandler(this.FormActualizarMetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualizarMetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActualizarMetas;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        public System.Windows.Forms.Button btnguardarM;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbTipodeActividad;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cmbEstrategia;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cmbInstitucion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
    }
}