using SINFO.CapaNegocio;
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
    public partial class FormActualizarIB : Form
    {
        public FormActualizarIB()
        {
            InitializeComponent();
        }

        private void FormActualizarIB_Load(object sender, EventArgs e)
        {
            CargadgvActualizarIP();
        }

        #region Cargar La Cosulta a la tabla Seguimiento
        public void CargadgvActualizarIP()
        {
            N_InseminacionB ObjIB = new N_InseminacionB();
            dgvActualizarIB.DataSource = ObjIB.ObtenerDatosIB();

            //esto de abajo es para racomodar el orden de las columnas
            dgvActualizarIB.Columns["Editar"].DisplayIndex = 15;
            dgvActualizarIB.Columns["Eliminar"].DisplayIndex = 15;
        }
        #endregion

        private void dgvActualizarIB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
