using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesPersonalizados.Controls
{
    [DefaultEvent("_TextChanged")] //especificamos como evento predeterminado
    public partial class TextBoxPersonalizado : UserControl
    {
        //campos para las apariencias y para inicializar lso valores predeterminados
        private Color borderColor = Color.MediumSlateBlue;  //campo para el color de borde
        private int borderSize = 2; // campo para el tamaño de borde
        private bool underlinedStyle = false; //campo para el estilo del cuadro de texto es decir un estilo de borde sudbrayado o rectangular
        private Color borderFocusColor = Color.HotPink; //declaramos un campo para el color de borde en estado enfocado osea dentro del textbox
        private bool isFocused = false; //para determinar di el cuadro de texto esta enfocado

        //para bordes redondos
        private int borderRadius = 0;

        //para marcador de posicion
        private Color placeholderColor = Color.DarkGray; //campo para el color del marcado de posicion
        private string placeholderText = ""; //campo para el texto del marcador de posicion
        private bool isPlaceholder = false; //campo para guardar el estado del marcador de posicion
        private bool isPasswordChar = false; //campo para determinar si el cuatro de texto es un campo de contraseña y asi mostrar o ocultar los caracteres
        public TextBoxPersonalizado()
        {
            InitializeComponent();
        }

        //eventos
        public event EventHandler _TextChanged; //evento por defecto de un textbox

        //propiedades

        [Category("TexControlKevin")] //para agrupar esta propiedades con un nombre
        public Color BorderColor //propiedad generada
        {

            get
            {
                return borderColor;

            }
            set
            {
                borderColor = value;
                this.Invalidate(); //metodo invalidar para volver a dibujar el control
            }
        }
        [Category("TexControlKevin")] //para agrupar esta propiedades con un nombre
        public int BorderSize //propiedad generada
        {
            get
            {
                return borderSize;

            }
            set
            {
                //creacion de propiedades
                borderSize = value;
                this.Invalidate(); //metodo invalidar para volver a dibujar el control
            }
        }
        [Category("TexControlKevin")] //para agrupar esta propiedades con un nombre
        public bool UnderlinedStyle //propiedad generada
        {
            get
            {
                return underlinedStyle;

            }
            set
            {
                //creacion de propiedades
                underlinedStyle = value;
                this.Invalidate(); //metodo invalidar para volver a dibujar el control
            }
        }

        [Category("TexControlKevin")] //para agrupar esta propiedades con un nombre
        public bool PasswordChar //propiedad generada
        {
            get { return isPasswordChar; }
            set
            {
                isPasswordChar = value;
                if (!isPlaceholder)
                    textBox1.UseSystemPasswordChar = value;
            }
        }

        [Category("TexControlKevin")] //para agrupar esta propiedades con un nombre
        public bool Multiline //permite cambiar el tamaño del control libremente //propiedad generada
        {
            get { return textBox1.Multiline; 
            
            }
            set { textBox1.Multiline = value;
            
            }
        }

        [Category("TexControlKevin")] //para agrupar esta propiedades con un nombre
        public override Color BackColor  //color de fondo es una propiedad que ya existe en control de usuario por lo cual lo vamos a anular
        {
            get { return base.BackColor; } 
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;  //cuando se asigne un color de fondo este tendra efecto en el control de usuario y cuadro te texto
            }
        }

        [Category("TexControlKevin")] //para agrupar esta propiedades con un nombre
        public override Color ForeColor //de igual forma par la propiedad texto //propiedad generada
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        [Category("TexControlKevin")] //para agrupar esta propiedades con un nombre
        public override Font Font //propiedad generada
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)  
                    UpdateControlHeight();//importante llamar el metodo actualizar el alto del control
            }
        }

        [Category("TexControlKevin")] //para agrupar esta propiedades con un nombre
        public string Texts  //propiedad texto //propiedad generada
        {
            get
            {
                if (isPlaceholder) return "";
                else return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
                SetPlaceholder();
            }
        }

        [Category("TexControlKevin")] //para agrupar esta propiedades con un nombre
        public Color BorderFocusColor //propiedad generada
        { 
            get { return borderFocusColor;
            
            } 
            set { borderFocusColor = value;
            
            }
        }

        [Category("TexControlKevin")] //para agrupar esta propiedades con un nombre
        public int BorderRadius   //propiedad generada border radios
        {
            get { return borderRadius; }
            set 
            {
                if (value >= 0) //condicion para que el valor sea igual o mayor a cero ya que no puede ser un valor negativo
                {
                    borderRadius = value;
                    this.Invalidate();//volvemos a dibujar el control para dibujar el control con la nueva apariencia
                }
            }
        }

        [Category("TexControlKevin")] //para agrupar esta propiedades con un nombre
        public Color PlaceholderColor
        {
            get { return placeholderColor; }
            set
            {
                placeholderColor = value;
                if (isPlaceholder)
                    textBox1.ForeColor = value;
            }
        }

        [Category("TexControlKevin")] //para agrupar esta propiedades con un nombre
        public string PlaceholderText 
        {
            get { return placeholderText; }
            set
            {
                placeholderText = value;
                textBox1.Text = "";
                SetPlaceholder();
            }
        }

        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) && placeholderText != "")
            {
                isPlaceholder = true;
                textBox1.Text = placeholderText;
                textBox1.ForeColor = placeholderColor;
                if (isPasswordChar)
                    textBox1.UseSystemPasswordChar = false;
            }
        }

        private void RemovePlaceholder()
        {
            if (isPlaceholder && placeholderText != "")
            {
                isPlaceholder = false;
                textBox1.Text = "";
                textBox1.ForeColor = this.ForeColor;
                if (isPasswordChar)
                    textBox1.UseSystemPasswordChar = true;
            }
        }

        //anulacion de metodos de eventos
        protected override void OnPaint(PaintEventArgs e) //metodo pintura
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics; //campo de tipo grafico y se le asignamos la propiedad graficos del evento de pintura
            if (borderRadius > 1)//si el radio de borde es mayor a 1 entonces es un cuadro de texto con esquinas redondeado
            {
                //-Fields
                var rectBorderSmooth = this.ClientRectangle; //variable rectangulo para las regiones del suavisado de borde, que es igual al rectangulo del control de usuario
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize); //rectangulo para las dimenciones del borde
                int smoothSize = borderSize > 0 ? borderSize : 1; //tamaño del suavizado que es igual al tamaño de borde, pero si el valor es 0 el tamaño de suavizado deber ser 1 como minimo
               
                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius)) //objeto de ruta de grafico para suavizado de borde o contorno
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize)) //objeto de ruta de grafico para el borde como parametros enviamos el rectBorder y el borderRadius suctrayendo el grosor de brode (- borderSize)
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))  //objeto boligrafo para el suavizado del contorno del mismo color de fondo de su contenedor con grosor definido en el campo tamaño del suavizado (smoothSize)
                using (Pen penBorder = new Pen(borderColor, borderSize)) //objeto boligrafo para el borde con el color de borde y tamaño definidos
                {
                    //se comienza a dibujar el control con bordes redondiados

                    this.Region = new Region(pathBorderSmooth);//la region del control debe ser igual a la ruta de graficos de suavizado de borde (pathBorderSmooth) ya que esta esta es la ruta de control con bordes redondeados
                    if (borderRadius > 15) SetTextBoxRoundedRegion();//si el radio de borde es mayo a 15 tambien se establecera una region redondeada al cuadro te texto interno
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    if (isFocused) penBorder.Color = borderFocusColor;
                    if (underlinedStyle) //estilo susbrayado
                    {
                        //dibujamos la ruta del suavizado de contorno de borde

                        //enviamos como parametros ruta de suavizado (pathBorderSmooth) y lapiz de suavizado(penBorderSmooth)
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);

                        //Dibujamos el borde del estilo subrayado

                        graph.SmoothingMode = SmoothingMode.None; //cambiamos el suavizado de pintura a ninguno para que se dibuje nitidamente sin suavizado
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else //estulo Normal rectangulo redondeado completo
                    {
                        //dibujamo el boligrafo con la ruta y el lapiz ya creados
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else //es un cuadro de texto cuadrado lo tradicional
            {
                //dibujar borde del cuadro de texto personalizado

                using (Pen penBorder = new Pen(borderColor, borderSize))  // creamos objeto tipo lapiz y como parametros el color del borde y el tamaño
                {
                    this.Region = new Region(this.ClientRectangle); //establecemos la region con la misma propiedad ClientRectangle del control de usuario para recuperar la forma rectangular cuando el radio de borde sea 0
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset; //especificamos la alineacion del lapiz en insertado
                    if (!isFocused)  //sino esta enfocado dubujamos el borde de color 
                    {
                        if (underlinedStyle) //si el estilo es subrayado 
                            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1); //dibujamos una linea en la parte inferio del control
                        else //si no es susbrayado 
                            graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F); // dibujamos un rectangulo como borde

                    }
                    else
                    {
                        penBorder.Color = borderFocusColor;
                        if (underlinedStyle) //si el estilo es subrayado 
                            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1); //dibujamos una linea en la parte inferio del control
                        else //si no es susbrayado 
                            graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F); // dibujamos un rectangulo como borde

                    }

                }
            }
        }

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt; //campo ruta de graficos
            if (Multiline) //si el cuadro de texto es multilinea
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderRadius - borderSize); //estalecemos la region rendondeada //el tamaño de radio de borde sera igual a la resta del valor de campo de radio de borde(borderRadius) y tamaño de borde (borderSize)
                textBox1.Region = new Region(pathTxt); //del cuadro de texto
            }
            else //sino es multilinea
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderSize * 2);
                textBox1.Region = new Region(pathTxt);
            }
            pathTxt.Dispose();
        }

        //Metodo para agregar arcos a los bordes de los controles

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnResize(EventArgs e) //anulacion del metodo redimencionado (onresize) para poder actualizar y establecer alto adecuado del control de usuario y el cuadro te texto
        {
            base.OnResize(e);
            if (this.DesignMode) //ejecutaremos el metodo UpdateControlHeight solo cuando el control de usuario este en modo de diseño para reducir el costo en tiempo de ejecucion
                UpdateControlHeight(); //metodo para dicho objetivo
        }
        protected override void OnLoad(EventArgs e) //establece el tamaño y la altura adecuado en tiempo de ejecucion
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()  //metodo se encargara de estblecer una altura adecuada y restringir el cambio de altura 
        {
            if (textBox1.Multiline == false) //siempre y cuando el cuatro de texto no sea multilinea
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1; //obtenemos el alto del texto y la fuente luego sumamos 1 al resultado para que el texto se muestre por completo
                textBox1.Multiline = true; //activar el cuatro de texto multilinea para poder establecer el tamaño minimo
                textBox1.MinimumSize = new Size(0, txtHeight); //establecemos el tamaño minimo
                textBox1.Multiline = false; //desactivamos la propiedad multilinea
                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom; //establecemo el alto adecuado del control de usuario que sera igual a la suma el alto del cuadro de texto + relleno superior(padding) + relleno inferior (padding)
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //invocamos el evento predeterminado del textbox al control de usuario
        {
            if (_TextChanged != null) //cuando el evento _TextChanged  del cuadro te texto se ejecute
                _TextChanged.Invoke(sender, e); //se ejecutara el evento _TextChanged del control
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e); //llamamos al evento onclick del control de usuario
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true; //el estado del foco esta verdadero al momento del evento enter
            this.Invalidate(); //volvemos a dibujar el control
            RemovePlaceholder();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false; //el estado del foco esta verdadero al momento del evento enter
            this.Invalidate(); //volvemos a dibujar el control
            SetPlaceholder();
        }
    }
}
