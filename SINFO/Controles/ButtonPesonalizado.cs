using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Librerias
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace ControlesPersonalizados.Controls
{
    public class ButtonPesonalizado : Button
    {
        //campos para la apariencia y sus valores predeterminados

        private int borderSize = 0;
        private int borderRadius = 20;
        private Color borderColor = Color.PaleVioletRed;

        [Category("ButtonPersonalizadoKevin")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("ButtonPersonalizadoKevin")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        [Category("ButtonPersonalizadoKevin")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("ButtonPersonalizadoKevin")]
        public Color BackgroundColor //color de fondo
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        [Category("ButtonPersonalizadoKevin")]
        public Color TextColor  //color de texto
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        //Constructor para inicializar algunas propiedades del control para la apariencia predeterminada
        public ButtonPesonalizado()
        {
            this.FlatStyle = FlatStyle.Flat; //estilo plano y sin borde
            this.FlatAppearance.BorderSize = 0;  //tamaño de borde 
            this.Size = new Size(150, 40); //tamaño del control
            this.BackColor = Color.MediumSlateBlue; //color de fondo
            this.ForeColor = Color.White; //color de texto
            this.Resize += new EventHandler(Button_Resize);
        }
        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }

        //radio de borde personalizable
        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();  //ruta de grafico
            float curveSize = radius * 2F; //arco
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90); //esquina
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90); //esquina
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90); //esquina
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90); //esquina
            path.CloseFigure(); 
            return path; //retornamos la ruta de graficos
        }

        //anularemos el evento
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Rectangle rectSurface = this.ClientRectangle; //objeto rectangulo 
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize); //objeto rectangulo
            int smoothSize = 2;
            if (borderSize > 0) 
                smoothSize = borderSize;
            if (borderRadius > 2) //si radio del borde es mayor que 2 entonces sera un button con esquinas redondeadas
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius)) //objeto ruta de grafico para la superficie
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize)) //para el borde
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize)) //objeto boligrafo
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Button superficie
                    this.Region = new Region(pathSurface);
                    //Dibujando el borde de la superficie para una buena calidad usando los objetos creados anteriormente
                    pevent.Graphics.DrawPath(penSurface, pathSurface);


                    //dibujaremos el borde del boton siempre y cuando que el tamaño de borde sea mayor o igual a 1                   
                    if (borderSize >= 1)
                        //dibujando el borde
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else //Boutton Cuadrado Normal
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;

                //Button surface
                this.Region = new Region(rectSurface);

                //Button border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        //anulacion del evento
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
