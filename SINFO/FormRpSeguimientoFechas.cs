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
    public partial class FormRpSeguimientoFechas : Form
    {
        public FormRpSeguimientoFechas()
        {
            InitializeComponent();
        }
        public DateTime fecha1 { get; set; }
        public DateTime fecha2 { get; set; }

        private void FormRpSeguimientoFechas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSSeguimiento.Reporteporfechasseguimiento' Puede moverla o quitarla según sea necesario.
            this.ReporteporfechasseguimientoTableAdapter.Fill(this.DSSeguimiento.Reporteporfechasseguimiento,fecha1,fecha2);

            this.reportViewer1.RefreshReport();
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = dtpFechaInicio.Value;
            DateTime fecha2 = dtpFechaFinal.Value;

            this.ReporteporfechasseguimientoTableAdapter.Fill(this.DSSeguimiento.Reporteporfechasseguimiento, fecha1, fecha2);
            this.reportViewer1.RefreshReport();
        }
    }
}
