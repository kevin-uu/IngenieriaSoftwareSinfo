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
    public partial class FormPartoIB : Form
    {
        public FormPartoIB()
        {
            InitializeComponent();
        }

        private void FormPartoIB_Load(object sender, EventArgs e)
        {
            btnguardarIBPartos.Enabled = false;
            CargadgvActualizarIBPartos();
        }

        #region Cargar La Cosulta a la tabla Inseminacion porcina
        public void CargadgvActualizarIBPartos()
        {
            N_InseminacionB ObjIP = new N_InseminacionB();
            dgvActualizarIBParto.DataSource = ObjIP.ObtenerDatosIPparto();

            //esto de abajo es para racomodar el orden de las columnas
            dgvActualizarIBParto.Columns["Editar"].DisplayIndex = 18;
            dgvActualizarIBParto.Columns["Eliminar"].DisplayIndex = 18;
        }
        #endregion

        #region Evento Cellclick para Moverlos campos a los texto Box Correspondientes

        private void dgvActualizarIBParto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvActualizarIBParto.Columns[e.ColumnIndex].Name == "Editar")
            {

                txtCedula.Text = dgvActualizarIBParto.CurrentRow.Cells["Cedula"].Value.ToString();
                txtNombre.Text = dgvActualizarIBParto.CurrentRow.Cells["Nombre_Completo"].Value.ToString();
                txtTelefono.Text = dgvActualizarIBParto.CurrentRow.Cells["No_Telefono"].Value.ToString();
                txtNombreVaca.Text = dgvActualizarIBParto.CurrentRow.Cells["Nombre_de_la_Vaca"].Value.ToString();
                txtNArete.Text = dgvActualizarIBParto.CurrentRow.Cells["No_Arete"].Value.ToString();
            }

            if (dgvActualizarIBParto.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                string idineminacion = dgvActualizarIBParto.CurrentRow.Cells["IDIB"].Value.ToString();
                EliminarInseminacion(Convert.ToInt32(idineminacion));
                MessageBox.Show("El registro se Elimino correctamente");
                CargadgvActualizarIBPartos();
            }
        }
        #endregion

        #region editar Registro de Tabla Inseminacion Bovina
        public void EditarinseminacionBPartos(int id)
        {
            try
            {

                CDatos conex = new CDatos();
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = conex.AbrirConexion();
                Comando.CommandText = "ActualizarIBovina3";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@idinseminacionB", id);
                Comando.Parameters.AddWithValue("@fecharealdepartob", dtpfecharealparto.Value);
                Comando.Parameters.AddWithValue("@machos", Convert.ToInt32(txtMachos.Text));
                Comando.Parameters.AddWithValue("@hembras", Convert.ToInt32(txtHembras.Text));
 
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

        #region Elimar Registro  Tabla Inseminacion Bovina
        public void EliminarInseminacion(int id)
        {
            try
            {
                CDatos conex = new CDatos();
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = conex.AbrirConexion();
                Comando.CommandText = "EliminarIBovina";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@idinseminacionB", id);
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

        #region boton Actualizar Registro de un parto
        private void btnguardarIBPartos_Click(object sender, EventArgs e)
        {
            string idineminacion = dgvActualizarIBParto.CurrentRow.Cells["IDIB"].Value.ToString();
            EditarinseminacionBPartos(Convert.ToInt32(idineminacion));
            MessageBox.Show("El registro se edito correctamente");
            CargadgvActualizarIBPartos();
            limpiar();
        }
        #endregion

        #region limpiar controles form Actualizar Inseminacion Bovina
        public void limpiar()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtNombreVaca.Clear();
            txtNArete.Clear();
            txtHembras.Clear();
            txtMachos.Clear();
        }

        #endregion

        #region validacion  text box numero
        private void txtMachos_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.Numero(e);  
        }
        #endregion

        #region Metodo de validacion de espacios vacios
        public void Validaciondeespaciovacios()
        {
            var vr = !string.IsNullOrEmpty(txtMachos.Text) && !string.IsNullOrEmpty(txtHembras.Text);
            btnguardarIBPartos.Enabled = vr;
        }
        #endregion

        private void txtMachos_TextChanged(object sender, EventArgs e)
        {
            Validaciondeespaciovacios();
        }
    }
}
