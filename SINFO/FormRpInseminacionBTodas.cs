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
    public partial class FormRpInseminacionBTodas : Form
    {
        public FormRpInseminacionBTodas()
        {
            InitializeComponent();
        }

        private void FormRpInseminacionBTodas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSInseminacionBovina.DataTable2' Puede moverla o quitarla según sea necesario.
            this.DataTable2TableAdapter.Fill(this.DSInseminacionBovina.DataTable2);
            // TODO: esta línea de código carga datos en la tabla 'DSInseminacionBovina.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DSInseminacionBovina.DataTable1);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
