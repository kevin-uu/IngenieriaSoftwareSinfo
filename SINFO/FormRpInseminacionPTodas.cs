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
    public partial class FormRpInseminacionPTodas : Form
    {
        public FormRpInseminacionPTodas()
        {
            InitializeComponent();
        }

        private void FormRpInseminacionPTodas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSInseminacionPorcina.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DSInseminacionPorcina.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
