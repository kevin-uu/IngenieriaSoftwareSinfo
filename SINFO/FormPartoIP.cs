using SINFO.CapaNegocio;
using SINFO.Models;
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
    public partial class FormPartoIP : Form
    {
        public FormPartoIP()
        {
            InitializeComponent();
        }

        private void FormPartoIP_Load(object sender, EventArgs e)
        {
            CargadgvActualizarIP();
        }

        #region Cargar La Cosulta a la tabla Inseminacion porcina
        public void CargadgvActualizarIP()
        {
            N_InseminacionP ObjIP = new N_InseminacionP();
            dgvActualizarIPpartos.DataSource = ObjIP.ObtenerDatosIPparto();

            //esto de abajo es para racomodar el orden de las columnas
            dgvActualizarIPpartos.Columns["Editar"].DisplayIndex = 16;
            dgvActualizarIPpartos.Columns["Eliminar"].DisplayIndex = 16;
        }


        #endregion

        #region validacion text box numero
        private void textBoxPersonalizado1_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.Numero(e);
        }

        #endregion

        #region evento cellclick al darle click a la columna editar sobre el icono carga los texbox de la fila seleccionada
        private void dgvActualizarIPpartos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvActualizarIPpartos.Columns[e.ColumnIndex].Name == "Editar")
            {

                txtCedula.Text = dgvActualizarIPpartos.CurrentRow.Cells["cedulaproductor"].Value.ToString();
                txtNombre.Text = dgvActualizarIPpartos.CurrentRow.Cells["nombreproductor"].Value.ToString();
                txtNombreCerdo.Text = dgvActualizarIPpartos.CurrentRow.Cells["nombrecerdo"].Value.ToString();
                txtNombreRaza.Text = dgvActualizarIPpartos.CurrentRow.Cells["nombrerazacerdo"].Value.ToString();
                txtTelefono.Text = dgvActualizarIPpartos.CurrentRow.Cells["numerotelfono"].Value.ToString();
                dtpFecharealparto.Text = dgvActualizarIPpartos.CurrentRow.Cells["fechainseminacion"].Value.ToString();
                
            }

            if (dgvActualizarIPpartos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                string idineminacion = dgvActualizarIPpartos.CurrentRow.Cells["idinseminacion"].Value.ToString();
                EliminarInseminacion(Convert.ToInt32(idineminacion));
                MessageBox.Show("El registro se Elimino correctamente");
                CargadgvActualizarIP();
            }
        }
        #endregion

        #region editar Registro de Tabla Inseminacion Porcina
        public void EditarinseminacionP(int id)
        {
            try
            {

                CDatos conex = new CDatos();
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = conex.AbrirConexion();
                Comando.CommandText = "ActualizarIPorcina2";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@idinseminacion", id);
                Comando.Parameters.AddWithValue("@fecharealdepartop", dtpFecharealparto.Value);
                Comando.Parameters.AddWithValue("@machos", textBoxPersonalizado1.Texts);
                Comando.Parameters.AddWithValue("@hembras", textBoxPersonalizado2.Texts);
                Comando.ExecuteNonQuery();
                Comando.Parameters.Clear();
                Comando.Connection = conex.CerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region Elimar Registro  Tabla Inseminacion Porcina
        public void EliminarInseminacion(int id)
        {
            try
            {
                CDatos conex = new CDatos();
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = conex.AbrirConexion();
                Comando.CommandText = "EliminarIPorcina";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@idinseminacion", id);
                Comando.ExecuteNonQuery();
                Comando.Parameters.Clear();
                Comando.Connection = conex.CerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region limpiar campos form Actualizar Inseminacion Porcina
        public void limpiar()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtNombreCerdo.Clear();
            txtNombreRaza.Clear();
            txtTelefono.Clear();
        }
        #endregion

        #region evento click de boton Actualizar para Guardar un Registro
        private void btnguardarIPParto_Click(object sender, EventArgs e)
        {
            string idineminacion = dgvActualizarIPpartos.CurrentRow.Cells["idinseminacion"].Value.ToString();
            EditarinseminacionP(Convert.ToInt32(idineminacion));
            MessageBox.Show("El registro se edito correctamente");
            CargadgvActualizarIP();
            limpiar();
            textBoxPersonalizado1.Texts = "";
            textBoxPersonalizado2.Texts = "";
        }
        #endregion
    }
}
