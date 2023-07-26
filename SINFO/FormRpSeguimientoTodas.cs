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
    public partial class FormRpSeguimientoTodas : Form
    {
        public FormRpSeguimientoTodas()
        {
            InitializeComponent();
        }

        private void FormRpSeguimiento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSSeguimiento.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DSSeguimiento.DataTable1);
            // TODO: esta línea de código carga datos en la tabla 'DSSeguimiento.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DSSeguimiento.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
