
namespace SINFO
{
    partial class FormActualizarIB
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
            this.dgvActualizarIB = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dtpFechaInseminacionB = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.cmbRazaUsada = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtNArete = new System.Windows.Forms.TextBox();
            this.txtNombreVaca = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPreñada = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualizarIB)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActualizarIB
            // 
            this.dgvActualizarIB.AllowUserToAddRows = false;
            this.dgvActualizarIB.AllowUserToDeleteRows = false;
            this.dgvActualizarIB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActualizarIB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvActualizarIB.BackgroundColor = System.Drawing.Color.White;
            this.dgvActualizarIB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvActualizarIB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvActualizarIB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActualizarIB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActualizarIB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActualizarIB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            this.dgvActualizarIB.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActualizarIB.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvActualizarIB.Location = new System.Drawing.Point(28, 193);
            this.dgvActualizarIB.Name = "dgvActualizarIB";
            this.dgvActualizarIB.ReadOnly = true;
            this.dgvActualizarIB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActualizarIB.Size = new System.Drawing.Size(875, 300);
            this.dgvActualizarIB.TabIndex = 2;
            this.dgvActualizarIB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActualizarIB_CellContentClick);
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
            // dtpFechaInseminacionB
            // 
            this.dtpFechaInseminacionB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInseminacionB.Location = new System.Drawing.Point(500, 53);
            this.dtpFechaInseminacionB.Name = "dtpFechaInseminacionB";
            this.dtpFechaInseminacionB.Size = new System.Drawing.Size(134, 20);
            this.dtpFechaInseminacionB.TabIndex = 149;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label24.Location = new System.Drawing.Point(338, 52);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(157, 17);
            this.label24.TabIndex = 148;
            this.label24.Text = "Fecha de Inseminacion:";
            // 
            // cmbRazaUsada
            // 
            this.cmbRazaUsada.FormattingEnabled = true;
            this.cmbRazaUsada.Items.AddRange(new object[] {
            "Criolla",
            "Brahman",
            "Brahman Rojo",
            "Pardo",
            "Simental",
            "Jersey",
            "Gyr",
            "Holsteins"});
            this.cmbRazaUsada.Location = new System.Drawing.Point(500, 16);
            this.cmbRazaUsada.Name = "cmbRazaUsada";
            this.cmbRazaUsada.Size = new System.Drawing.Size(129, 21);
            this.cmbRazaUsada.TabIndex = 143;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label21.Location = new System.Drawing.Point(378, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(110, 17);
            this.label21.TabIndex = 142;
            this.label21.Text = "Raza de Usada:";
            // 
            // txtNArete
            // 
            this.txtNArete.Location = new System.Drawing.Point(182, 158);
            this.txtNArete.Name = "txtNArete";
            this.txtNArete.Size = new System.Drawing.Size(100, 20);
            this.txtNArete.TabIndex = 141;
            // 
            // txtNombreVaca
            // 
            this.txtNombreVaca.Location = new System.Drawing.Point(182, 124);
            this.txtNombreVaca.Name = "txtNombreVaca";
            this.txtNombreVaca.Size = new System.Drawing.Size(129, 20);
            this.txtNombreVaca.TabIndex = 140;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(87, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 17);
            this.label14.TabIndex = 139;
            this.label14.Text = "No de Arete:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(37, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 17);
            this.label13.TabIndex = 138;
            this.label13.Text = "Nombre de la Vaca:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(182, 53);
            this.txtNombre.MaxLength = 14;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(129, 20);
            this.txtNombre.TabIndex = 137;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(182, 89);
            this.txtTelefono.MaxLength = 8;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(129, 20);
            this.txtTelefono.TabIndex = 136;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(34, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 17);
            this.label8.TabIndex = 135;
            this.label8.Text = "Numero de Telefono:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(182, 16);
            this.txtCedula.MaxLength = 14;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(129, 20);
            this.txtCedula.TabIndex = 130;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(25, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 17);
            this.label9.TabIndex = 129;
            this.label9.Text = "Cedula del Productor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(25, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 128;
            this.label1.Text = "Nombre del Productor:";
            // 
            // cmbPreñada
            // 
            this.cmbPreñada.FormattingEnabled = true;
            this.cmbPreñada.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cmbPreñada.Location = new System.Drawing.Point(500, 88);
            this.cmbPreñada.Name = "cmbPreñada";
            this.cmbPreñada.Size = new System.Drawing.Size(89, 21);
            this.cmbPreñada.TabIndex = 151;
            this.cmbPreñada.Text = "Confirme";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(389, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 17);
            this.label12.TabIndex = 150;
            this.label12.Text = "Esta Preñada?:";
            // 
            // FormActualizarIB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 539);
            this.Controls.Add(this.cmbPreñada);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpFechaInseminacionB);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.cmbRazaUsada);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtNArete);
            this.Controls.Add(this.txtNombreVaca);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvActualizarIB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormActualizarIB";
            this.Text = "FormActualizarIB";
            this.Load += new System.EventHandler(this.FormActualizarIB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualizarIB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvActualizarIB;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DateTimePicker dtpFechaInseminacionB;
        private System.Windows.Forms.Label label24;
        public System.Windows.Forms.ComboBox cmbRazaUsada;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtNArete;
        private System.Windows.Forms.TextBox txtNombreVaca;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbPreñada;
        private System.Windows.Forms.Label label12;
    }
}