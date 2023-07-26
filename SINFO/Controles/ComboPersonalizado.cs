using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Design;

namespace ControlesPersonalizados.Controls
{
    [DefaultEvent("OnSelectedIndexChanged")]
    public class ComboPersonalizado : UserControl
    {
        //campos para la apariencia y sus colores predeterminados

        private Color backColor = Color.WhiteSmoke; //color de fondo
        private Color iconColor = Color.MediumSlateBlue; //color de icono
        private Color listBackColor = Color.FromArgb(230, 228, 245); //color de fondo de la lista desplegable
        private Color listTextColor = Color.DimGray; //color de texto de la lista desplegable
        private Color borderColor = Color.MediumSlateBlue;//color de tamaño de borde
        private int borderSize = 1;//tamaño de borde

        //elementos necesarios que conformaran el combo personalizado

        private ComboBox cmbList; //comobox estandar para exponer sus propiedades mostrar la lista desplegable
        private Label lblText; //etiqueta para mostrar el texto
        private Button btnIcon; //boton para el icono y asi abrir la lista desplegable

        //propiedades de los campos
        [Category("ComboAparienciaControlKevin")]
        public new Color BackColor //color de fondo
        { 
            get 
            { 
                return backColor; 
            } 
            set 
            {
                backColor = value;
                lblText.BackColor = backColor;
                btnIcon.BackColor = backColor;
            } 
        }

        [Category("ComboAparienciaControlKevin")]
        public Color IconColor //color de icono
        { 
            get 
            { 
                return iconColor; 
            } 
            set 
            {
                iconColor = value;
                btnIcon.Invalidate(); //metodo invalidar para volver a dibujar el icono en el color especificado
            } 
        }

        [Category("ComboAparienciaControlKevin")]
        public Color ListBackColor //color de fondo de lista
        { 
            get
            {
                return listBackColor;
            }
            set
            {
                listBackColor = value;
                cmbList.BackColor = listBackColor;
            }
        }

        [Category("ComboAparienciaControlKevin")]
        public Color ListTextColor //color de texto de lista
        { 
            get
            {
                return listTextColor;
            }
            set
            {
                listTextColor = value;
                cmbList.ForeColor = listTextColor;
            } 
        }

        [Category("ComboAparienciaControlKevin")]
        public Color BorderColor //color de borde
        { 
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                base.BackColor = borderColor;
            }
        }

        [Category("ComboAparienciaControlKevin")]
        public int BorderSize 
        { 
            get 
            { 
                return borderSize ; 
            
            } 
            set 
            {
                borderSize = value;
                this.Padding = new Padding(borderSize);//Border Size
                AdjustComboBoxDimensions();
            }
        }

        [Category("ComboAparienciaControlKevin")]
        public override Color ForeColor //color de texto de la etiqueta
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                lblText.ForeColor = value;
            }
        }

        [Category("ComboAparienciaControlKevin")]
        public override Font Font //propiedad fuente
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                lblText.Font = value;
                cmbList.Font = value;//Optional
            }
        }

        [Category("ComboAparienciaControlKevin")]
        public string Texts //propiedad para el texto
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }

        [Category("ComboAparienciaControlKevin")]
        public ComboBoxStyle DropDownStyle //estilo lista desplegable
        {
            get { return cmbList.DropDownStyle; }
            set
            {
                if (cmbList.DropDownStyle != ComboBoxStyle.Simple)
                    cmbList.DropDownStyle = value;
            }
        }

        //propiedades relacionadas a los datos del combo box

        [Category("ComboDatosControlKevin")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items
        {
            get { return cmbList.Items; }
        }

        [Category("ComboDatosControlKevin")]
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        public object DataSource
        {
            get { return cmbList.DataSource; }
            set { cmbList.DataSource = value; }
        }

        [Category("ComboDatosControlKevin")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]
        public AutoCompleteStringCollection AutoCompleteCustomSource 
        {
            get { return cmbList.AutoCompleteCustomSource; }
            set { cmbList.AutoCompleteCustomSource = value; }
        }

        [Category("ComboDatosControlKevin")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource 
        {
            get { return cmbList.AutoCompleteSource; }
            set { cmbList.AutoCompleteSource = value; }
        }

        [Category("ComboDatosControlKevin")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode 
        {
            get { return cmbList.AutoCompleteMode; }
            set { cmbList.AutoCompleteMode = value; }
        }

        [Category("ComboDatosControlKevin")]
        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]    
        public object SelectedItem 
        {
            get { return cmbList.SelectedItem; }
            set { cmbList.SelectedItem = value; }
        }

        [Category("ComboDatosControlKevin")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex 
        {
            get { return cmbList.SelectedIndex; }
            set { cmbList.SelectedIndex = value; }
        }

        public string DisplayMember { get; internal set; }
        public string ValueMember { get; internal set; }

        public event EventHandler OnSelectedIndexChanged;//campo de evento por defecto o predeterminado

        public ComboPersonalizado()
        {
            cmbList = new ComboBox();
            lblText = new Label();
            btnIcon = new Button();
            this.SuspendLayout();

            //ComboBox: lista desplegable

            cmbList.BackColor = listBackColor;  //color de fondo
            cmbList.Font = new Font(this.Font.Name, 8.25F); //tamaño de fuente
            cmbList.ForeColor = listTextColor; //color de texto
            cmbList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);//Default event
            cmbList.TextChanged += new EventHandler(ComboBox_TextChanged);//Actualiza el Texto del control cada vez que cambie el texto
                                                                          //Button: Icon

           //inicializando las propiedades de apariencia del boton de icono
            btnIcon.Dock = DockStyle.Right;  //boton acoplado al lado derecho del control
            btnIcon.FlatStyle = FlatStyle.Flat; //estilo plano 
            btnIcon.FlatAppearance.BorderSize = 0; //sin borde
            btnIcon.BackColor = backColor; //color de fondo
            btnIcon.Size = new Size(30, 30); //tamaño de 30
            btnIcon.Cursor = Cursors.Hand; //cambiar cursor a mano (hand)

            btnIcon.Click += new EventHandler(Icon_Click);//evento click del boton para abrir la lista desplegable del boton
            btnIcon.Paint += new PaintEventHandler(Icon_Paint);//evento paint para dibujar el icono de flecha hacia abajo con el color determinado
                                                               //Label: Text

            lblText.Dock = DockStyle.Fill; //la etiqueda se acopla en el espacio restante ya que anteriormente acoplamos el icono a la derecha
            lblText.AutoSize = false;
            lblText.BackColor = backColor;
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            lblText.Padding = new Padding(8, 0, 0, 0);
            lblText.Font = new Font(this.Font.Name, 10F);

            //->Attach label events to user control event
            lblText.Click += new EventHandler(Superficie_Click);//se encargara de seleccionar el combo box
            lblText.MouseEnter += new EventHandler(Surface_MouseEnter);
            lblText.MouseLeave += new EventHandler(Surface_MouseLeave);


            //control de usuario agregamos los componentes anteriores
            this.Controls.Add(lblText);//2
            this.Controls.Add(btnIcon);//1
            this.Controls.Add(cmbList);//0
            this.MinimumSize = new Size(150, 30); //tamaño minimo
            this.Size = new Size(200, 30); //el tamaño
            this.ForeColor = Color.DimGray; //color de texto
            this.Padding = new Padding(borderSize);//asignamos el campo tamaño de borde //padding es responsable de establecer el tamaño de borde
            this.Font = new Font(this.Font.Name, 10F); 
            base.BackColor = borderColor; //color de fondo del control de usuario es responsable de asignar el color de borde
            this.ResumeLayout(); //reanudamos el diseño
            AdjustComboBoxDimensions(); //metodo para ajustar las dimensiones del combo box // en encarga de establecer en ancho adecuado del combo box y ubicacion
        }

       

        //metodo ajustar dimensiones
        private void AdjustComboBoxDimensions()
        {
            cmbList.Width = lblText.Width; //en ancho del combobox sera igual al ancho del labeltext
            cmbList.Location = new Point() //ubicado en la parte inferior derecha del control de usuario
            {
                X = this.Width - this.Padding.Right - cmbList.Width,
                Y = lblText.Bottom - cmbList.Height
            };
        }

        //metodos de eventos

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e) //evento predeterminado de nuestro control //cuando el indice seleccionado del combobox cambie 
        {
            if (OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(sender, e);
            //Refresh text
            lblText.Text = cmbList.Text;
        }

        private void Icon_Paint(object sender, PaintEventArgs e) //para dibujar el icono del combobox en el boton
        {
            //definicion de los campos

            int iconWidht = 14; //ancho del icono
            int iconHeight = 6; //alto del icono
            var rectIcon = new Rectangle((btnIcon.Width - iconWidht) / 2, (btnIcon.Height - iconHeight) / 2, iconWidht, iconHeight);  //rectangulo para determinar los limites y dimenciones centrado en el boton 
            Graphics graph = e.Graphics; //objeto de graficos

            //dibujando el icono de fleca hacia abajo
            using (GraphicsPath path = new GraphicsPath()) //objeto de ruta de graficos para crear la figura del icono
            using (Pen pen = new Pen(iconColor, 2)) //objeto lapiz para el trazo del icono 
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias; //modo de suavizado del grafico 
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidht / 2), rectIcon.Bottom); //ruta de grafico, agregamos una linea en eje inicial del rectangulo hasta el punto medio inferior del rectangulo
                path.AddLine(rectIcon.X + (iconWidht / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y); //segunda linea empezando en el punto final de la linea anterior hasta la parte derecha superior
                graph.DrawPath(pen, path); //dibujamos la ruta creada
            }
        }

        private void Icon_Click(object sender, EventArgs e)
        {
            cmbList.Select(); //seleccionaremos el combobox 
            cmbList.DroppedDown = true; //se abrira la lista deplegable
        }
        private void Superficie_Click(object sender, EventArgs e) //cuando se haga click en la etiqueta es decir en la superficie del control
        {
            this.OnClick(e);

            cmbList.Select();//seleccionaremos el combobox 
            if (cmbList.DropDownStyle == ComboBoxStyle.DropDownList)//y si es lista se abrira la lista deplegable
                cmbList.DroppedDown = true;

        }
        private void ComboBox_TextChanged(object sender, EventArgs e) //cuando el texto del combo box cambie
        {
            //actualizar el texto es decir el texto de la etiqueta es igual al texto del combobox
            lblText.Text = cmbList.Text;
        }

        private void Surface_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void Surface_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        protected override void OnResize(EventArgs e) //anula evento redimensionado para ajustar las dimensiones adecuadas del combo box cada vez que el control de usuario cambie de tamaño
        {
            base.OnResize(e);
            AdjustComboBoxDimensions();
        }
    }
}
