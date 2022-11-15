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
    public partial class FormActualizarMetas : Form
    {

        public FormActualizarMetas()
        {
            InitializeComponent();
        }

        private void FormActualizarMetas_Load(object sender, EventArgs e)
        {
            CargadgvActualizarMetas();
        }

        #region Cargar La Cosulta a la tabla Seguimiento
        private void CargadgvActualizarMetas()
        {
            N_Metas objSeguimeinto = new N_Metas();
            dgvActualizarMetas.DataSource = objSeguimeinto.ObtenerDatosMetas();

            //esto de abajo es para racomodar el orden de las columnas
            dgvActualizarMetas.Columns["Editar"].DisplayIndex = 7;
            dgvActualizarMetas.Columns["Eliminar"].DisplayIndex = 7;
        }
        #endregion


    }
}
