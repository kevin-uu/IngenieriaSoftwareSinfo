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
    public partial class reporteInseminacionP : Form
    {
        public reporteInseminacionP()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormRpInseminacionPTodas RpM = new FormRpInseminacionPTodas();
            RpM.ShowDialog();
        }
    }
}
