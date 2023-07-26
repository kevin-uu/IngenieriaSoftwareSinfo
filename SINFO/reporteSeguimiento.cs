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
    public partial class reporteSeguimiento : Form
    {
        public reporteSeguimiento()
        {
            InitializeComponent();
        }

        private void reporteSeguimiento_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormRpSeguimientoTodas RpM = new FormRpSeguimientoTodas();
            RpM.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FormRpSeguimiento RpM = new FormRpSeguimiento();
            RpM.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormRpSeguimientoFechas RpM = new FormRpSeguimientoFechas();
            RpM.ShowDialog();
        }
    }
}
