using CapaNegocio;
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
    public partial class FormRecuperarContraseña : Form
    {
        public FormRecuperarContraseña()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var usuario = new user();
            var resultado = usuario.recuperarcontraseña(txtCoU.Text);
            lblResultado.Text = resultado;
        }
    }
}
