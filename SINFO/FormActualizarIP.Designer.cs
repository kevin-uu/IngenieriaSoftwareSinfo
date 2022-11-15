
namespace SINFO
{
    partial class FormActualizarIP
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
            this.dgvActualizarIP = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.cmbPreñada = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbRaza = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNombreCerdo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpFechaRegistroIP = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCoordenadaY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCoordenadaX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbComunidadIP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMunicipioIP = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnguardarIP = new System.Windows.Forms.Button();
            this.btnNRInseminacionP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualizarIP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActualizarIP
            // 
            this.dgvActualizarIP.AllowUserToAddRows = false;
            this.dgvActualizarIP.AllowUserToDeleteRows = false;
            this.dgvActualizarIP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActualizarIP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvActualizarIP.BackgroundColor = System.Drawing.Color.White;
            this.dgvActualizarIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvActualizarIP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvActualizarIP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActualizarIP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActualizarIP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActualizarIP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            this.dgvActualizarIP.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActualizarIP.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvActualizarIP.Location = new System.Drawing.Point(21, 225);
            this.dgvActualizarIP.Name = "dgvActualizarIP";
            this.dgvActualizarIP.ReadOnly = true;
            this.dgvActualizarIP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActualizarIP.Size = new System.Drawing.Size(803, 285);
            this.dgvActualizarIP.TabIndex = 1;
            this.dgvActualizarIP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActualizarIP_CellClick);
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
            // cmbPreñada
            // 
            this.cmbPreñada.FormattingEnabled = true;
            this.cmbPreñada.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cmbPreñada.Location = new System.Drawing.Point(600, 60);
            this.cmbPreñada.Name = "cmbPreñada";
            this.cmbPreñada.Size = new System.Drawing.Size(89, 21);
            this.cmbPreñada.TabIndex = 81;
            this.cmbPreñada.Text = "Confirme";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(498, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 17);
            this.label12.TabIndex = 80;
            this.label12.Text = "Esta Preñada?:";
            // 
            // cmbRaza
            // 
            this.cmbRaza.FormattingEnabled = true;
            this.cmbRaza.Location = new System.Drawing.Point(391, 187);
            this.cmbRaza.Name = "cmbRaza";
            this.cmbRaza.Size = new System.Drawing.Size(102, 21);
            this.cmbRaza.TabIndex = 79;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(296, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 17);
            this.label11.TabIndex = 78;
            this.label11.Text = "Raza del Berraco:";
            // 
            // txtNombreCerdo
            // 
            this.txtNombreCerdo.Location = new System.Drawing.Point(391, 148);
            this.txtNombreCerdo.Name = "txtNombreCerdo";
            this.txtNombreCerdo.Size = new System.Drawing.Size(102, 20);
            this.txtNombreCerdo.TabIndex = 77;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(286, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 17);
            this.label10.TabIndex = 76;
            this.label10.Text = "Nombre del Berraco:";
            // 
            // dtpFechaRegistroIP
            // 
            this.dtpFechaRegistroIP.Location = new System.Drawing.Point(99, 30);
            this.dtpFechaRegistroIP.Name = "dtpFechaRegistroIP";
            this.dtpFechaRegistroIP.Size = new System.Drawing.Size(116, 20);
            this.dtpFechaRegistroIP.TabIndex = 75;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(9, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 17);
            this.label9.TabIndex = 74;
            this.label9.Text = "Fecha de Inseminacion:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(400, 107);
            this.txtTelefono.MaxLength = 8;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(102, 20);
            this.txtTelefono.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(300, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 17);
            this.label8.TabIndex = 72;
            this.label8.Text = "Numero de Telefono:";
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbSexo.Location = new System.Drawing.Point(537, 30);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(89, 21);
            this.cmbSexo.TabIndex = 71;
            this.cmbSexo.Text = "Seleccione";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(498, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 70;
            this.label7.Text = "Sexo:";
            // 
            // txtCoordenadaY
            // 
            this.txtCoordenadaY.Location = new System.Drawing.Point(360, 68);
            this.txtCoordenadaY.MaxLength = 7;
            this.txtCoordenadaY.Name = "txtCoordenadaY";
            this.txtCoordenadaY.Size = new System.Drawing.Size(102, 20);
            this.txtCoordenadaY.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(250, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 17);
            this.label6.TabIndex = 68;
            this.label6.Text = "Coordenada Y (UTM):";
            // 
            // txtCoordenadaX
            // 
            this.txtCoordenadaX.Location = new System.Drawing.Point(360, 27);
            this.txtCoordenadaX.MaxLength = 6;
            this.txtCoordenadaX.Name = "txtCoordenadaX";
            this.txtCoordenadaX.Size = new System.Drawing.Size(102, 20);
            this.txtCoordenadaX.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(250, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 17);
            this.label5.TabIndex = 66;
            this.label5.Text = "Coordenada X (UTM):";
            // 
            // cmbComunidadIP
            // 
            this.cmbComunidadIP.FormattingEnabled = true;
            this.cmbComunidadIP.Location = new System.Drawing.Point(79, 194);
            this.cmbComunidadIP.Name = "cmbComunidadIP";
            this.cmbComunidadIP.Size = new System.Drawing.Size(181, 21);
            this.cmbComunidadIP.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(7, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 64;
            this.label4.Text = "Comunidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(7, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 63;
            this.label3.Text = "Municipio/Distrito:";
            // 
            // cmbMunicipioIP
            // 
            this.cmbMunicipioIP.FormattingEnabled = true;
            this.cmbMunicipioIP.Location = new System.Drawing.Point(99, 153);
            this.cmbMunicipioIP.Name = "cmbMunicipioIP";
            this.cmbMunicipioIP.Size = new System.Drawing.Size(181, 21);
            this.cmbMunicipioIP.TabIndex = 62;
            this.cmbMunicipioIP.SelectedIndexChanged += new System.EventHandler(this.cmbMunicipioIP_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(124, 106);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(179, 20);
            this.txtNombre.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(9, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 60;
            this.label2.Text = "Nombre del Productor:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(115, 67);
            this.txtCedula.MaxLength = 14;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(129, 20);
            this.txtCedula.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(9, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "Cedula del Productor:";
            // 
            // btnguardarIP
            // 
            this.btnguardarIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnguardarIP.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnguardarIP.FlatAppearance.BorderSize = 0;
            this.btnguardarIP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(220)))));
            this.btnguardarIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarIP.Location = new System.Drawing.Point(12, 516);
            this.btnguardarIP.Name = "btnguardarIP";
            this.btnguardarIP.Size = new System.Drawing.Size(97, 32);
            this.btnguardarIP.TabIndex = 82;
            this.btnguardarIP.Text = "Actualizar";
            this.btnguardarIP.UseVisualStyleBackColor = false;
            this.btnguardarIP.Click += new System.EventHandler(this.btnguardarIP_Click);
            // 
            // btnNRInseminacionP
            // 
            this.btnNRInseminacionP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNRInseminacionP.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNRInseminacionP.FlatAppearance.BorderSize = 0;
            this.btnNRInseminacionP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(220)))));
            this.btnNRInseminacionP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNRInseminacionP.Location = new System.Drawing.Point(128, 516);
            this.btnNRInseminacionP.Name = "btnNRInseminacionP";
            this.btnNRInseminacionP.Size = new System.Drawing.Size(154, 32);
            this.btnNRInseminacionP.TabIndex = 83;
            this.btnNRInseminacionP.Text = "Nueva Inseminacion";
            this.btnNRInseminacionP.UseVisualStyleBackColor = false;
            this.btnNRInseminacionP.Click += new System.EventHandler(this.btnNRInseminacionP_Click);
            // 
            // FormActualizarIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 555);
            this.Controls.Add(this.btnNRInseminacionP);
            this.Controls.Add(this.btnguardarIP);
            this.Controls.Add(this.cmbPreñada);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbRaza);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNombreCerdo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpFechaRegistroIP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCoordenadaY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCoordenadaX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbComunidadIP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMunicipioIP);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvActualizarIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormActualizarIP";
            this.Text = "FormActualizarIP";
            this.Load += new System.EventHandler(this.FormActualizarIP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualizarIP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        public System.Windows.Forms.ComboBox cmbPreñada;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.ComboBox cmbRaza;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNombreCerdo;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.DateTimePicker dtpFechaRegistroIP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCoordenadaY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCoordenadaX;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cmbComunidadIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cmbMunicipioIP;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnguardarIP;
        public System.Windows.Forms.Button btnNRInseminacionP;
        public System.Windows.Forms.DataGridView dgvActualizarIP;
    }
}