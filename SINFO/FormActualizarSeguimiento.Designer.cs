namespace SINFO
{
    partial class FormActualizarSeguimiento
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
            this.dgvActualizar = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.cmbTipodeActividad = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEstrategia = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbInstitucion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbComunidad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMunicipio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.txtMujeres = new System.Windows.Forms.TextBox();
            this.txtVarones = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtActualizarSeguimiento = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActualizar
            // 
            this.dgvActualizar.AllowUserToAddRows = false;
            this.dgvActualizar.AllowUserToDeleteRows = false;
            this.dgvActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActualizar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvActualizar.BackgroundColor = System.Drawing.Color.White;
            this.dgvActualizar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvActualizar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvActualizar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActualizar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActualizar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            this.dgvActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActualizar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvActualizar.Location = new System.Drawing.Point(28, 205);
            this.dgvActualizar.Name = "dgvActualizar";
            this.dgvActualizar.ReadOnly = true;
            this.dgvActualizar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActualizar.Size = new System.Drawing.Size(874, 391);
            this.dgvActualizar.TabIndex = 0;
            this.dgvActualizar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActualizar_CellClick_1);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::SINFO.Properties.Resources.editar;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 40;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::SINFO.Properties.Resources.borrar;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 49;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(220)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(38, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 37);
            this.button4.TabIndex = 32;
            this.button4.Text = "Nuevo Registro";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cmbTipodeActividad
            // 
            this.cmbTipodeActividad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbTipodeActividad.FormattingEnabled = true;
            this.cmbTipodeActividad.Location = new System.Drawing.Point(544, 93);
            this.cmbTipodeActividad.Name = "cmbTipodeActividad";
            this.cmbTipodeActividad.Size = new System.Drawing.Size(200, 21);
            this.cmbTipodeActividad.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(475, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 43;
            this.label7.Text = "Estrategia:";
            // 
            // cmbEstrategia
            // 
            this.cmbEstrategia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbEstrategia.FormattingEnabled = true;
            this.cmbEstrategia.Location = new System.Drawing.Point(532, 58);
            this.cmbEstrategia.Name = "cmbEstrategia";
            this.cmbEstrategia.Size = new System.Drawing.Size(212, 21);
            this.cmbEstrategia.TabIndex = 42;
            this.cmbEstrategia.SelectedIndexChanged += new System.EventHandler(this.cmbEstrategia_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(450, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Tipo de Actividad:";
            // 
            // cmbInstitucion
            // 
            this.cmbInstitucion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbInstitucion.FormattingEnabled = true;
            this.cmbInstitucion.Location = new System.Drawing.Point(565, 134);
            this.cmbInstitucion.Name = "cmbInstitucion";
            this.cmbInstitucion.Size = new System.Drawing.Size(147, 21);
            this.cmbInstitucion.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(446, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Institucion Responsable:";
            // 
            // cmbComunidad
            // 
            this.cmbComunidad.FormattingEnabled = true;
            this.cmbComunidad.Location = new System.Drawing.Point(146, 99);
            this.cmbComunidad.Name = "cmbComunidad";
            this.cmbComunidad.Size = new System.Drawing.Size(283, 21);
            this.cmbComunidad.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(20, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Comunidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(21, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Municipio/Distrito:";
            // 
            // cmbMunicipio
            // 
            this.cmbMunicipio.FormattingEnabled = true;
            this.cmbMunicipio.Location = new System.Drawing.Point(146, 59);
            this.cmbMunicipio.Name = "cmbMunicipio";
            this.cmbMunicipio.Size = new System.Drawing.Size(283, 21);
            this.cmbMunicipio.TabIndex = 35;
            this.cmbMunicipio.SelectedIndexChanged += new System.EventHandler(this.cmbMunicipio_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(20, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Fecha";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(73, 15);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(194, 20);
            this.dtpFechaRegistro.TabIndex = 33;
            // 
            // txtMujeres
            // 
            this.txtMujeres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMujeres.Location = new System.Drawing.Point(973, 500);
            this.txtMujeres.Name = "txtMujeres";
            this.txtMujeres.ShortcutsEnabled = false;
            this.txtMujeres.Size = new System.Drawing.Size(18, 20);
            this.txtMujeres.TabIndex = 51;
            this.txtMujeres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVarones_KeyPress);
            // 
            // txtVarones
            // 
            this.txtVarones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVarones.Location = new System.Drawing.Point(973, 461);
            this.txtVarones.Name = "txtVarones";
            this.txtVarones.ShortcutsEnabled = false;
            this.txtVarones.Size = new System.Drawing.Size(18, 20);
            this.txtVarones.TabIndex = 50;
            this.txtVarones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVarones_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(905, 500);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 17);
            this.label11.TabIndex = 49;
            this.label11.Text = "Mujeres:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(902, 464);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 48;
            this.label10.Text = "Varones:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(902, 435);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 17);
            this.label9.TabIndex = 47;
            this.label9.Text = "Participantes:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Location = new System.Drawing.Point(908, 205);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ShortcutsEnabled = false;
            this.txtDescripcion.Size = new System.Drawing.Size(178, 223);
            this.txtDescripcion.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(905, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 45;
            this.label8.Text = "Descripcion:";
            // 
            // txtActualizarSeguimiento
            // 
            this.txtActualizarSeguimiento.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtActualizarSeguimiento.FlatAppearance.BorderSize = 0;
            this.txtActualizarSeguimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(220)))));
            this.txtActualizarSeguimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtActualizarSeguimiento.Location = new System.Drawing.Point(146, 153);
            this.txtActualizarSeguimiento.Name = "txtActualizarSeguimiento";
            this.txtActualizarSeguimiento.Size = new System.Drawing.Size(97, 37);
            this.txtActualizarSeguimiento.TabIndex = 52;
            this.txtActualizarSeguimiento.Text = "Actualizar";
            this.txtActualizarSeguimiento.UseVisualStyleBackColor = false;
            this.txtActualizarSeguimiento.Click += new System.EventHandler(this.txtActualizarSeguimiento_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::SINFO.Properties.Resources.editar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 40;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::SINFO.Properties.Resources.borrar;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 49;
            // 
            // FormActualizarSeguimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1112, 608);
            this.Controls.Add(this.txtActualizarSeguimiento);
            this.Controls.Add(this.txtMujeres);
            this.Controls.Add(this.txtVarones);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbTipodeActividad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbEstrategia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbInstitucion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbComunidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMunicipio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaRegistro);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dgvActualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormActualizarSeguimiento";
            this.Text = "FormActualizarSeguimiento";
            this.Load += new System.EventHandler(this.FormActualizarSeguimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridView dgvActualizar;
        public System.Windows.Forms.ComboBox cmbTipodeActividad;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cmbEstrategia;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cmbInstitucion;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cmbComunidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cmbMunicipio;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        public System.Windows.Forms.TextBox txtMujeres;
        public System.Windows.Forms.TextBox txtVarones;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button txtActualizarSeguimiento;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}