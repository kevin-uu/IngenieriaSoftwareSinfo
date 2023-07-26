using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SINFO
{
    public partial class FormRpSeguimiento : Form
    {
        public FormRpSeguimiento()
        {
            InitializeComponent();
        }

        private void FormRpSeguimiento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSSeguimiento.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DSSeguimiento.DataTable1);

            this.reportViewer1.RefreshReport();
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            ReportParameter p = new ReportParameter("Estrategias",comboBox1.Text);
            reportViewer1.LocalReport.SetParameters(p);
            reportViewer1.RefreshReport();
        }
    }
}
