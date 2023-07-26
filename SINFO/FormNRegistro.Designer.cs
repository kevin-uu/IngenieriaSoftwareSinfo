
namespace SINFO
{
    partial class FormNRegistro
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
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMunicipio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbComunidad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbInstitucion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEstrategia = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipodeActividad = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVarones = new System.Windows.Forms.TextBox();
            this.txtMujeres = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnCerrarB = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(73, 30);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(194, 20);
            this.dtpFechaRegistro.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(20, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha";
            // 
            // cmbMunicipio
            // 
            this.cmbMunicipio.FormattingEnabled = true;
            this.cmbMunicipio.Location = new System.Drawing.Point(146, 74);
            this.cmbMunicipio.Name = "cmbMunicipio";
            this.cmbMunicipio.Size = new System.Drawing.Size(283, 21);
            this.cmbMunicipio.TabIndex = 5;
            this.cmbMunicipio.SelectedIndexChanged += new System.EventHandler(this.cmbMunicipio_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(21, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Municipio/Distrito:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(20, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Comunidad:";
            // 
            // cmbComunidad
            // 
            this.cmbComunidad.FormattingEnabled = true;
            this.cmbComunidad.Location = new System.Drawing.Point(146, 114);
            this.cmbComunidad.Name = "cmbComunidad";
            this.cmbComunidad.Size = new System.Drawing.Size(283, 21);
            this.cmbComunidad.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(446, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Institucion Responsable:";
            // 
            // cmbInstitucion
            // 
            this.cmbInstitucion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbInstitucion.FormattingEnabled = true;
            this.cmbInstitucion.Location = new System.Drawing.Point(576, 149);
            this.cmbInstitucion.Name = "cmbInstitucion";
            this.cmbInstitucion.Size = new System.Drawing.Size(356, 21);
            this.cmbInstitucion.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(450, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tipo de Actividad:";
            // 
            // cmbEstrategia
            // 
            this.cmbEstrategia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEstrategia.FormattingEnabled = true;
            this.cmbEstrategia.Location = new System.Drawing.Point(552, 70);
            this.cmbEstrategia.Name = "cmbEstrategia";
            this.cmbEstrategia.Size = new System.Drawing.Size(380, 21);
            this.cmbEstrategia.TabIndex = 13;
            this.cmbEstrategia.SelectedIndexChanged += new System.EventHandler(this.cmbEstrategia_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(475, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Estrategia:";
            // 
            // cmbTipodeActividad
            // 
            this.cmbTipodeActividad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipodeActividad.FormattingEnabled = true;
            this.cmbTipodeActividad.Location = new System.Drawing.Point(552, 108);
            this.cmbTipodeActividad.Name = "cmbTipodeActividad";
            this.cmbTipodeActividad.Size = new System.Drawing.Size(380, 21);
            this.cmbTipodeActividad.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(46, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Location = new System.Drawing.Point(159, 206);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ShortcutsEnabled = false;
            this.txtDescripcion.Size = new System.Drawing.Size(562, 264);
            this.txtDescripcion.TabIndex = 17;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(22, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Participantes:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(27, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Varones:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(25, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Mujeres:";
            // 
            // txtVarones
            // 
            this.txtVarones.Location = new System.Drawing.Point(93, 323);
            this.txtVarones.Name = "txtVarones";
            this.txtVarones.ShortcutsEnabled = false;
            this.txtVarones.Size = new System.Drawing.Size(39, 20);
            this.txtVarones.TabIndex = 22;
            this.txtVarones.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            this.txtVarones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVarones_KeyPress);
            // 
            // txtMujeres
            // 
            this.txtMujeres.Location = new System.Drawing.Point(93, 370);
            this.txtMujeres.Name = "txtMujeres";
            this.txtMujeres.ShortcutsEnabled = false;
            this.txtMujeres.Size = new System.Drawing.Size(39, 20);
            this.txtMujeres.TabIndex = 23;
            this.txtMujeres.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            this.txtMujeres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVarones_KeyPress);
            // 
            // btnguardar
            // 
            this.btnguardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnguardar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(220)))));
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Location = new System.Drawing.Point(624, 491);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(97, 32);
            this.btnguardar.TabIndex = 26;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnCerrarB
            // 
            this.btnCerrarB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarB.FlatAppearance.BorderSize = 0;
            this.btnCerrarB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(101)))), ((int)(((byte)(113)))));
            this.btnCerrarB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(3)))));
            this.btnCerrarB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarB.Image = global::SINFO.Properties.Resources.cerrar__2_;
            this.btnCerrarB.Location = new System.Drawing.Point(891, 1);
            this.btnCerrarB.Name = "btnCerrarB";
            this.btnCerrarB.Size = new System.Drawing.Size(47, 30);
            this.btnCerrarB.TabIndex = 27;
            this.btnCerrarB.UseVisualStyleBackColor = true;
            this.btnCerrarB.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(187)))), ((int)(((byte)(110)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::SINFO.Properties.Resources.maximizar;
            this.button3.Location = new System.Drawing.Point(850, -2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 33);
            this.button3.TabIndex = 29;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(187)))), ((int)(((byte)(110)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::SINFO.Properties.Resources.minimizar__1_;
            this.button2.Location = new System.Drawing.Point(803, -2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 33);
            this.button2.TabIndex = 30;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormNRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(944, 599);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCerrarB);
            this.Controls.Add(this.btnguardar);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNRegistro";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormNRegistro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCerrarB;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ComboBox cmbMunicipio;
        public System.Windows.Forms.ComboBox cmbComunidad;
        public System.Windows.Forms.ComboBox cmbInstitucion;
        public System.Windows.Forms.ComboBox cmbEstrategia;
        public System.Windows.Forms.ComboBox cmbTipodeActividad;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.TextBox txtVarones;
        public System.Windows.Forms.TextBox txtMujeres;
        public System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        public System.Windows.Forms.Button btnguardar;
    }
}