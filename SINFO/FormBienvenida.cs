using SINFO.CapaSoporte.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SINFO
{
    public partial class FormBienvenida : Form
    {
        public FormBienvenida()
        {
            InitializeComponent();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //aparece gradualmente
            if (this.Opacity < 1) this.Opacity += 0.05;
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString();

            if (circularProgressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //dezbanecerse

            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }

        }

        private void FormBienvenida_Load(object sender, EventArgs e)
        {
            lblUsuario.Text= CacheInicioSesionUsuario.FirstName + ", " + CacheInicioSesionUsuario.LastName; //mensaje de bienvenida
            this.Opacity = 0.0;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            timer1.Start();
        }
    }
}
