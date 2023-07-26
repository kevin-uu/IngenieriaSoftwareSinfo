
namespace SINFO
{
    partial class FormPartoIP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvActualizarIPpartos = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dtpFechaRegistroIP = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreRaza = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreCerdo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPersonalizado1 = new ControlesPersonalizados.Controls.TextBoxPersonalizado();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPersonalizado2 = new ControlesPersonalizados.Controls.TextBoxPersonalizado();
            this.dtpFecharealparto = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.btnguardarIPParto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualizarIPpartos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActualizarIPpartos
            // 
            this.dgvActualizarIPpartos.AllowUserToAddRows = false;
            this.dgvActualizarIPpartos.AllowUserToDeleteRows = false;
            this.dgvActualizarIPpartos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActualizarIPpartos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvActualizarIPpartos.BackgroundColor = System.Drawing.Color.White;
            this.dgvActualizarIPpartos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvActualizarIPpartos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvActualizarIPpartos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(67)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(67)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActualizarIPpartos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvActualizarIPpartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActualizarIPpartos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            this.dgvActualizarIPpartos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(67)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActualizarIPpartos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvActualizarIPpartos.Location = new System.Drawing.Point(42, 244);
            this.dgvActualizarIPpartos.Name = "dgvActualizarIPpartos";
            this.dgvActualizarIPpartos.ReadOnly = true;
            this.dgvActualizarIPpartos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActualizarIPpartos.Size = new System.Drawing.Size(814, 301);
            this.dgvActualizarIPpartos.TabIndex = 2;
            this.dgvActualizarIPpartos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActualizarIPpartos_CellClick);
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
            // dtpFechaRegistroIP
            // 
            this.dtpFechaRegistroIP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaRegistroIP.Location = new System.Drawing.Point(110, 23);
            this.dtpFechaRegistroIP.Name = "dtpFechaRegistroIP";
            this.dtpFechaRegistroIP.Size = new System.Drawing.Size(116, 20);
            this.dtpFechaRegistroIP.TabIndex = 87;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(20, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 17);
            this.label9.TabIndex = 86;
            this.label9.Text = "Fecha de Inseminacion:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(135, 218);
            this.txtTelefono.MaxLength = 8;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ShortcutsEnabled = false;
            this.txtTelefono.Size = new System.Drawing.Size(102, 20);
            this.txtTelefono.TabIndex = 85;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(35, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 17);
            this.label8.TabIndex = 84;
            this.label8.Text = "Numero de Telefono:";
            // 
            // txtNombreRaza
            // 
            this.txtNombreRaza.Location = new System.Drawing.Point(135, 178);
            this.txtNombreRaza.MaxLength = 7;
            this.txtNombreRaza.Name = "txtNombreRaza";
            this.txtNombreRaza.ShortcutsEnabled = false;
            this.txtNombreRaza.Size = new System.Drawing.Size(102, 20);
            this.txtNombreRaza.TabIndex = 83;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(25, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 17);
            this.label6.TabIndex = 82;
            this.label6.Text = "Coordenada Y (UTM):";
            // 
            // txtNombreCerdo
            // 
            this.txtNombreCerdo.Location = new System.Drawing.Point(135, 137);
            this.txtNombreCerdo.MaxLength = 6;
            this.txtNombreCerdo.Name = "txtNombreCerdo";
            this.txtNombreCerdo.ShortcutsEnabled = false;
            this.txtNombreCerdo.Size = new System.Drawing.Size(102, 20);
            this.txtNombreCerdo.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(25, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 80;
            this.label5.Text = "Nombre Cerdo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(135, 99);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(179, 20);
            this.txtNombre.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(20, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 78;
            this.label2.Text = "Nombre del Productor:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(126, 60);
            this.txtCedula.MaxLength = 14;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ShortcutsEnabled = false;
            this.txtCedula.Size = new System.Drawing.Size(129, 20);
            this.txtCedula.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(20, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 76;
            this.label1.Text = "Cedula del Productor:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(382, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 230);
            this.panel1.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 29);
            this.label3.TabIndex = 89;
            this.label3.Text = "Parto A registar";
            // 
            // textBoxPersonalizado1
            // 
            this.textBoxPersonalizado1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPersonalizado1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.textBoxPersonalizado1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(67)))), ((int)(((byte)(50)))));
            this.textBoxPersonalizado1.BorderRadius = 0;
            this.textBoxPersonalizado1.BorderSize = 2;
            this.textBoxPersonalizado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPersonalizado1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(67)))), ((int)(((byte)(50)))));
            this.textBoxPersonalizado1.Location = new System.Drawing.Point(472, 114);
            this.textBoxPersonalizado1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPersonalizado1.Multiline = false;
            this.textBoxPersonalizado1.Name = "textBoxPersonalizado1";
            this.textBoxPersonalizado1.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxPersonalizado1.PasswordChar = false;
            this.textBoxPersonalizado1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxPersonalizado1.PlaceholderText = "";
            this.textBoxPersonalizado1.Size = new System.Drawing.Size(93, 31);
            this.textBoxPersonalizado1.TabIndex = 90;
            this.textBoxPersonalizado1.Texts = "";
            this.textBoxPersonalizado1.UnderlinedStyle = false;
            this.textBoxPersonalizado1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPersonalizado1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(404, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 92;
            this.label7.Text = "Machos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(396, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 93;
            this.label4.Text = "Hembras:";
            // 
            // textBoxPersonalizado2
            // 
            this.textBoxPersonalizado2.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPersonalizado2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.textBoxPersonalizado2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(67)))), ((int)(((byte)(50)))));
            this.textBoxPersonalizado2.BorderRadius = 0;
            this.textBoxPersonalizado2.BorderSize = 2;
            this.textBoxPersonalizado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPersonalizado2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(67)))), ((int)(((byte)(50)))));
            this.textBoxPersonalizado2.Location = new System.Drawing.Point(472, 154);
            this.textBoxPersonalizado2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPersonalizado2.Multiline = false;
            this.textBoxPersonalizado2.Name = "textBoxPersonalizado2";
            this.textBoxPersonalizado2.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxPersonalizado2.PasswordChar = false;
            this.textBoxPersonalizado2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxPersonalizado2.PlaceholderText = "";
            this.textBoxPersonalizado2.Size = new System.Drawing.Size(93, 31);
            this.textBoxPersonalizado2.TabIndex = 94;
            this.textBoxPersonalizado2.Texts = "";
            this.textBoxPersonalizado2.UnderlinedStyle = false;
            this.textBoxPersonalizado2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPersonalizado1_KeyPress);
            // 
            // dtpFecharealparto
            // 
            this.dtpFecharealparto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecharealparto.Location = new System.Drawing.Point(560, 61);
            this.dtpFecharealparto.Name = "dtpFecharealparto";
            this.dtpFecharealparto.Size = new System.Drawing.Size(116, 20);
            this.dtpFecharealparto.TabIndex = 95;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(390, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 17);
            this.label10.TabIndex = 96;
            this.label10.Text = "Fecha de Real del parto:";
            // 
            // btnguardarIPParto
            // 
            this.btnguardarIPParto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnguardarIPParto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnguardarIPParto.FlatAppearance.BorderSize = 0;
            this.btnguardarIPParto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(220)))));
            this.btnguardarIPParto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(67)))), ((int)(((byte)(50)))));
            this.btnguardarIPParto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarIPParto.Location = new System.Drawing.Point(608, 114);
            this.btnguardarIPParto.Name = "btnguardarIPParto";
            this.btnguardarIPParto.Size = new System.Drawing.Size(97, 32);
            this.btnguardarIPParto.TabIndex = 97;
            this.btnguardarIPParto.Text = "Actualizar";
            this.btnguardarIPParto.UseVisualStyleBackColor = false;
            this.btnguardarIPParto.Click += new System.EventHandler(this.btnguardarIPParto_Click);
            // 
            // FormPartoIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(892, 557);
            this.Controls.Add(this.btnguardarIPParto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpFecharealparto);
            this.Controls.Add(this.textBoxPersonalizado2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPersonalizado1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpFechaRegistroIP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNombreRaza);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombreCerdo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvActualizarIPpartos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPartoIP";
            this.Text = "FormPartoIP";
            this.Load += new System.EventHandler(this.FormPartoIP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualizarIPpartos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvActualizarIPpartos;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        public System.Windows.Forms.DateTimePicker dtpFechaRegistroIP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreRaza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreCerdo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private ControlesPersonalizados.Controls.TextBoxPersonalizado textBoxPersonalizado1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private ControlesPersonalizados.Controls.TextBoxPersonalizado textBoxPersonalizado2;
        public System.Windows.Forms.DateTimePicker dtpFecharealparto;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button btnguardarIPParto;
    }
}