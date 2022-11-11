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
    public partial class reporteMetas : Form
    {
        public reporteMetas()
        {
            InitializeComponent();
        }

        #region reporte numero 1
        private void label1_Click(object sender, EventArgs e)
        {
            FormRpMetas RpM = new FormRpMetas();
            RpM.ShowDialog();
        }
        #endregion

        private void label2_Click(object sender, EventArgs e)
        {
            FormRpMetasTodas RpM = new FormRpMetasTodas();
            RpM.ShowDialog();
        }
    }
}
