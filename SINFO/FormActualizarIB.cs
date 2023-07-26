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
    public partial class FormActualizarIB : Form
    {
        public FormActualizarIB()
        {
            InitializeComponent();
            cmbRazaUsada.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPreñada.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FormActualizarIB_Load(object sender, EventArgs e)
        {
            CargadgvActualizarIB();
        }

        #region Cargar La Cosulta a la tabla Seguimiento
        public void CargadgvActualizarIB()
        {
            N_InseminacionB ObjIB = new N_InseminacionB();
            dgvActualizarIB.DataSource = ObjIB.ObtenerDatosIB();

            //esto de abajo es para racomodar el orden de las columnas
            dgvActualizarIB.Columns["Editar"].DisplayIndex = 16;
            dgvActualizarIB.Columns["Eliminar"].DisplayIndex = 16;
        }
        #endregion

        #region editar Registro de Tabla Inseminacion Bovina
        public void Editarinseminacion(int id)
        {
            try
            {

                CDatos conex = new CDatos();
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = conex.AbrirConexion();
                Comando.CommandText = "ActualizarIBovina2";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@idinseminacionB", id);
                Comando.Parameters.AddWithValue("@cedulaproductorB", txtCedula.Text);
                Comando.Parameters.AddWithValue("@nombreproductorB", txtNombre.Text);
                Comando.Parameters.AddWithValue("@numerotelfonoB", txtTelefono.Text);
                Comando.Parameters.AddWithValue("@nombrevaca", txtNombreVaca.Text);
                Comando.Parameters.AddWithValue("@arete", txtNArete.Text);
                Comando.Parameters.AddWithValue("@razausada", cmbRazaUsada.SelectedItem.ToString());
                Comando.Parameters.AddWithValue("@presentocelo1", cmbPreñada.SelectedItem.ToString());
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

        #region evento cellclick al darle click a la columna editar sobre el icono carga los texbox de la fila seleccionada
        private void dgvActualizarIB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvActualizarIB.Columns[e.ColumnIndex].Name == "Editar")
            {

                txtCedula.Text = dgvActualizarIB.CurrentRow.Cells["Cedula"].Value.ToString();
                txtNombre.Text = dgvActualizarIB.CurrentRow.Cells["Nombre_Completo"].Value.ToString();
                txtTelefono.Text = dgvActualizarIB.CurrentRow.Cells["No_Telefono"].Value.ToString();
                dtpFechaInseminacionB.Text = dgvActualizarIB.CurrentRow.Cells["Fecha_de_Inseminacion"].Value.ToString();
                txtNombreVaca.Text = dgvActualizarIB.CurrentRow.Cells["Nombre_de_la_Vaca"].Value.ToString();
                txtNArete.Text = dgvActualizarIB.CurrentRow.Cells["No_Arete"].Value.ToString();
                cmbRazaUsada.Text = dgvActualizarIB.CurrentRow.Cells["Raza_Usada"].Value.ToString();
                cmbPreñada.Text = dgvActualizarIB.CurrentRow.Cells["Presento_Celo_"].Value.ToString();
                
            }

            if (dgvActualizarIB.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                string idineminacion = dgvActualizarIB.CurrentRow.Cells["IDIB"].Value.ToString();
                EliminarInseminacion(Convert.ToInt32(idineminacion));
                MessageBox.Show("El registro se Elimino correctamente");
                CargadgvActualizarIB();
            }
        }
        #endregion

        #region Boton Actualizar Registro Inseminacion Bovina
        private void btnguardarIB_Click(object sender, EventArgs e)
        {
            string idineminacion = dgvActualizarIB.CurrentRow.Cells["IDIB"].Value.ToString();
            Editarinseminacion(Convert.ToInt32(idineminacion));
            MessageBox.Show("El registro se edito correctamente");
            CargadgvActualizarIB();
            limpiar();
        }
        #endregion

        #region Boton Nuevo Registro Inseminacion Bovina
        private void btnNRInseminacionB_Click(object sender, EventArgs e)
        {
            FormNRegistroIB ib = new FormNRegistroIB();
            ib.Show();
        }
        #endregion

        #region Boton Recargar data grid
        private void pbRecargar_Click(object sender, EventArgs e)
        {
            CargadgvActualizarIB();
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
        }
        #endregion

        #region validacion text box letras
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.Letras(e);
        }
        #endregion

        #region validacion  text box numero
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.Numero(e);
        }
        #endregion
    }
}
