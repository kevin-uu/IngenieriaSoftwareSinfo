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
    public partial class FormRpMetasTodas : Form
    {
        public FormRpMetasTodas()
        {
            InitializeComponent();
        }

        private void FormRpMetasTodas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSMetas.DataTable2' Puede moverla o quitarla según sea necesario.
            this.DataTable2TableAdapter.Fill(this.DSMetas.DataTable2);

            this.reportViewer1.RefreshReport();
        }
    }
}
