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
    public partial class FormActualizarMetas : Form
    {

        public FormActualizarMetas()
        {
            InitializeComponent();
        }

        private void FormActualizarMetas_Load(object sender, EventArgs e)
        {
            CargadgvActualizarMetas();
            Cargarcmbinstitucion();
            Cargarcmbestrategia();
        }

        #region carga de combo Estrategia y combo Tipos de Actividades
        private void Cargarcmbestrategia()
        {
            N_Metas objEstrategiaM = new N_Metas();
            var lst = objEstrategiaM.ObCEst();
            if (lst.Count > 0)
            {
                cmbEstrategia.DisplayMember = "nombreestrategia"; //lo que se muestra
                cmbEstrategia.ValueMember = "idestrategia"; //lo que almacena
                cmbEstrategia.DataSource = lst; //muestra lo que he cargado en lst
            }
        }
        //metodo para cargar el como comunidad
        private void Cargarcmbtiposdeactividades()
        {
            N_Metas objTipoActividadM = new N_Metas();
            var id = (int)cmbEstrategia.SelectedValue;  // almaceno lo que se selecciona en municipio y un type cast para que sea entero
            var lst = objTipoActividadM.ObCtipoA(id); // obtengo los datos y pide un parametro id tipo int que se envia al where del metodo obtener
            if (lst.Count > 0)
            {
                cmbTipodeActividad.DisplayMember = "nombreactividad"; //lo que se muestra
                cmbTipodeActividad.ValueMember = "idtiposactividad"; //lo que almacena
                cmbTipodeActividad.DataSource = lst; //muestra lo que he cargado en lst
            }
        }

        private void cmbEstrategia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)cmbTipodeActividad.SelectedIndex != -1) { }//osea si hay alguna informacion cargada
            Cargarcmbtiposdeactividades();//que ejecute la el metodo
        }

        #endregion

        #region Carga de combo Institucion
        private void Cargarcmbinstitucion()
        {
            N_Metas objMetas= new N_Metas();
            var lst = objMetas.ObtenerCmbInstitucion();
            if (lst.Count > 0)
            {
                cmbInstitucion.DisplayMember = "nombreinstitucion"; //lo que se muestra
                cmbInstitucion.ValueMember = "idinstitucion"; //lo que almacena
                cmbInstitucion.DataSource = lst; //muestra lo que he cargado en lst
            }
        }

        #endregion

        #region Cargar La Cosulta a la tabla Seguimiento
        private void CargadgvActualizarMetas()
        {
            N_Metas objSeguimeinto = new N_Metas();
            dgvActualizarMetas.DataSource = objSeguimeinto.ObtenerDatosMetas();

            //esto de abajo es para racomodar el orden de las columnas
            dgvActualizarMetas.Columns["Editar"].DisplayIndex = 8;
            dgvActualizarMetas.Columns["Eliminar"].DisplayIndex = 8;
        }

        #endregion

        #region evento cellclik para editar
        private void dgvActualizarMetas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvActualizarMetas.Columns[e.ColumnIndex].Name == "Editar")
            {
                
                txtCantidad.Text = dgvActualizarMetas.CurrentRow.Cells["Cantidad"].Value.ToString();
                cmbEstrategia.Text = dgvActualizarMetas.CurrentRow.Cells["Estrategia"].Value.ToString();
                cmbInstitucion.Text = dgvActualizarMetas.CurrentRow.Cells["Institucion"].Value.ToString();
                cmbTipodeActividad.Text = dgvActualizarMetas.CurrentRow.Cells["Actividad"].Value.ToString();
                dtpFechaRegistro.Text = dgvActualizarMetas.CurrentRow.Cells["Fecha_de_Registro"].Value.ToString();
            }

            if (dgvActualizarMetas.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                string idineminacion = dgvActualizarMetas.CurrentRow.Cells["idmetas"].Value.ToString();
                EliminarMetas(Convert.ToInt32(idineminacion));
                MessageBox.Show("El registro se Elimino correctamente");
                CargadgvActualizarMetas();
            }
        }
        #endregion

        #region Editar Registro de Metas
        public void EditarMetas(int id)
        {
            try
            {

                CDatos conex = new CDatos();
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = conex.AbrirConexion();
                Comando.CommandText = "ActualizarMetas";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@idmetas", id);
                Comando.Parameters.AddWithValue("@fechaderegistro", dtpFechaRegistro.Value);
                Comando.Parameters.AddWithValue("@idestrategia2", Convert.ToInt32(cmbEstrategia.SelectedValue));
                Comando.Parameters.AddWithValue("@idtiposactividad2", Convert.ToInt32(cmbTipodeActividad.SelectedValue));
                Comando.Parameters.AddWithValue("@idinstitucion2", Convert.ToInt32(cmbInstitucion.SelectedValue));
                Comando.Parameters.AddWithValue("@cantidad", txtCantidad.Text);
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

        #region Elimar Registro Metas
        public void EliminarMetas(int id)
        {
            try
            {
                CDatos conex = new CDatos();
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = conex.AbrirConexion();
                Comando.CommandText = "EliminarMetas";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@idmetas", id);
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

        #region Boton Actualizar Metas
        private void btnguardarM_Click(object sender, EventArgs e)
        {
            string idineminacion = dgvActualizarMetas.CurrentRow.Cells["idmetas"].Value.ToString();
            EditarMetas(Convert.ToInt32(idineminacion));
            MessageBox.Show("El registro se edito correctamente");
            CargadgvActualizarMetas();
            limpiar();
        }
        #endregion

        #region limpiar campos form Actualizar metas
        public void limpiar()
        {
            txtCantidad.Clear();
        }
        #endregion

        
    }
}
