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
    public partial class reporteInseminacionB : Form
    {
        public reporteInseminacionB()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FormRpInseminacionBTodas RpM = new FormRpInseminacionBTodas();
            RpM.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormRpInseminacionBFechas RpM = new FormRpInseminacionBFechas();
            RpM.ShowDialog();
        }
    }
}
