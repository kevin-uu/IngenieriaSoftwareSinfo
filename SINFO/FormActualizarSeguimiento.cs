using SINFO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using SINFO.models;
using System.Data.SqlClient;
using SINFO.CapaNegocio;

namespace SINFO
{
    public partial class FormActualizarSeguimiento : Form
    {
        
        N_Seguimiento objSeguimeinto = new N_Seguimiento();
        seguimiento tablaseguimiento = new seguimiento();
        FormNRegistro formnregistro = new FormNRegistro();
        CDatos datos = new CDatos();
        
        public FormActualizarSeguimiento()
        {
            InitializeComponent();
        }

        #region Cargar La Cosulta a la tabla Seguimiento
        private void CargadgvActualizar()
        {
            N_Seguimiento objSeguimeinto = new N_Seguimiento();
            dgvActualizar.DataSource = objSeguimeinto.ObtenerDatosSeguimient();

            //esto de abajo es para racomodar el orden de las columnas
            dgvActualizar.Columns["Editar"].DisplayIndex = 13;
            dgvActualizar.Columns["Eliminar"].DisplayIndex = 13;
        }
        #endregion

        #region carga de combo municipio y combo comunidad

        //metodo para cargar el como municipio
        private void Cargarcmbmunicipio()
        {
            N_Seguimiento objSeguimeinto = new N_Seguimiento();
            var lst = objSeguimeinto.ObtenerCmbMunicipio();
            if (lst.Count > 0)
            {
                cmbMunicipio.DisplayMember = "nombremunicipio"; //lo que se muestra
                cmbMunicipio.ValueMember = "idmunicipio"; //lo que almacena
                cmbMunicipio.DataSource = lst; //muestra lo que he cargado en lst
            }
        }
        //metodo para cargar el como comunidad
        private void Cargarcmbcomunidad()
        {
            N_Seguimiento objSeguimeinto = new N_Seguimiento();
            var id = (int)cmbMunicipio.SelectedValue;  // almaceno lo que se selecciona en municipio y un type cast para que sea entero
            var lst = objSeguimeinto.ObtenerCmbComunidad(id); // obtengo los datos y pide un parametro id tipo int que se envia al where del metodo obtener
            if (lst.Count > 0)
            {
                cmbComunidad.DisplayMember = "nombrecomunidad"; //lo que se muestra
                cmbComunidad.ValueMember = "idcomunidad"; //lo que almacena
                cmbComunidad.DataSource = lst; //muestra lo que he cargado en lst
            }
        }

        //cuando cambie el index de combo municipio me carge lo que tengo en comunidad
        private void cmbMunicipio_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if ((int)cmbComunidad.SelectedIndex != -1) { }//osea si hay alguna informacion cargada
            Cargarcmbcomunidad();  //que ejecute la el metodo
        }

        #endregion

        #region carga de combo Estrategia y combo Tipos de Actividades
        private void Cargarcmbestrategia()
        {
            N_Estrategia objEstrategia = new N_Estrategia();
            var lst = objEstrategia.ObCEst();
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
            N_TipoActividad objTipoActividad = new N_TipoActividad();
            var id = (int)cmbEstrategia.SelectedValue;  // almaceno lo que se selecciona en municipio y un type cast para que sea entero
            var lst = objTipoActividad.ObCtipoA(id); // obtengo los datos y pide un parametro id tipo int que se envia al where del metodo obtener
            if (lst.Count > 0)
            {
                cmbTipodeActividad.DisplayMember = "nombreactividad"; //lo que se muestra
                cmbTipodeActividad.ValueMember = "idtiposactividad"; //lo que almacena
                cmbTipodeActividad.DataSource = lst; //muestra lo que he cargado en lst
            }
        }

        private void cmbEstrategia_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if ((int)cmbTipodeActividad.SelectedIndex != -1) { }//osea si hay alguna informacion cargada
            Cargarcmbtiposdeactividades();//que ejecute la el metodo
        }

        #endregion

        #region Carga de combo Institucion
        private void Cargarcmbinstitucion()
        {
            N_Seguimiento objSeguimeinto = new N_Seguimiento();
            var lst = objSeguimeinto.ObtenerCmbInstitucion();
            if (lst.Count > 0)
            {
                cmbInstitucion.DisplayMember = "nombreinstitucion"; //lo que se muestra
                cmbInstitucion.ValueMember = "idinstitucion"; //lo que almacena
                cmbInstitucion.DataSource = lst; //muestra lo que he cargado en lst
            }
        }

        #endregion

        private void FormActualizarSeguimiento_Load(object sender, EventArgs e)
        {
            CargadgvActualizar();
            Cargarcmbinstitucion();
            Cargarcmbmunicipio();
            Cargarcmbestrategia();

        }


        #region Boton Nuevo Registro
        private void button4_Click(object sender, EventArgs e)
        {
            FormNRegistro formnregistro = new FormNRegistro();   //instancia al form nuevo registro
            formnregistro.ShowDialog();                          //en todo el foco principal
            CargadgvActualizar();                              //actualiza la vista
        }
        #endregion

        #region Evento cell click para mostrar el Form Nuevo Registro y Actualizar un dato
        private void dgvActualizar_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvActualizar.Columns[e.ColumnIndex].Name == "Editar")
            {
                dtpFechaRegistro.Text = dgvActualizar.CurrentRow.Cells["fecha"].Value.ToString();//
                cmbMunicipio.Text = dgvActualizar.CurrentRow.Cells["Municipio"].Value.ToString();//
                cmbComunidad.Text = dgvActualizar.CurrentRow.Cells["Comunidad"].Value.ToString();//
                cmbInstitucion.Text = dgvActualizar.CurrentRow.Cells["Institucion"].Value.ToString();//
                cmbEstrategia.Text = dgvActualizar.CurrentRow.Cells["Estrategias"].Value.ToString();//
                cmbTipodeActividad.Text = dgvActualizar.CurrentRow.Cells["Actividad"].Value.ToString();//
                txtDescripcion.Text = dgvActualizar.CurrentRow.Cells["Descripcion"].Value.ToString();//
                txtVarones.Text = dgvActualizar.CurrentRow.Cells["Varones"].Value.ToString();//
                txtMujeres.Text = dgvActualizar.CurrentRow.Cells["Mujeres"].Value.ToString();//
            }

            if (dgvActualizar.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                string idineminacion = dgvActualizar.CurrentRow.Cells["IDS"].Value.ToString();
                EliminarSeguimiento(Convert.ToInt32(idineminacion));
                MessageBox.Show("El registro se Elimino correctamente");
                CargadgvActualizar();
            }


        }
        #endregion

        #region metodo para editar Datos tabla seguimiento
        public void EditarSeguimiento(int id)
        {
            try
            {

                CDatos conex = new CDatos();
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = conex.AbrirConexion();
                Comando.CommandText = "ActualizarSeguimiento";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@idsegimiento", id);
                Comando.Parameters.AddWithValue("@fecha", dtpFechaRegistro.Value);
                Comando.Parameters.AddWithValue("@idmunicipio1", Convert.ToInt32(cmbMunicipio.SelectedValue));
                Comando.Parameters.AddWithValue("@idcomunidad1", Convert.ToInt32(cmbComunidad.SelectedValue));
                Comando.Parameters.AddWithValue("@idinstitucion1", Convert.ToInt32(cmbInstitucion.SelectedValue));
                Comando.Parameters.AddWithValue("@idestrategia1", Convert.ToInt32(cmbEstrategia.SelectedValue));
                Comando.Parameters.AddWithValue("@idtiposactividad1", Convert.ToInt32(cmbTipodeActividad.SelectedValue));
                Comando.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                Comando.Parameters.AddWithValue("@varones", Convert.ToInt32(txtVarones.Text));
                Comando.Parameters.AddWithValue("@mujeres", Convert.ToInt32(txtMujeres.Text));
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

        #region boton Actualizar los datos seguimiento cargados en los componentes 
        private void txtActualizarSeguimiento_Click(object sender, EventArgs e)
        {
            string idseguimiento = dgvActualizar.CurrentRow.Cells["IDS"].Value.ToString();
            EditarSeguimiento(Convert.ToInt32(idseguimiento));
            MessageBox.Show("El registro se edito correctamente");
            CargadgvActualizar();
            limpiar();
        }
        #endregion

        #region Elimar Registro Tabla seguimiento
        public void EliminarSeguimiento(int id)
        {
            try
            {
                CDatos conex = new CDatos();
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = conex.AbrirConexion();
                Comando.CommandText = "EliminarSeguimiento";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@idsegimiento", id);
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

        #region limpiar campos form Actualizar Seguimiento
        public void limpiar()
        {
            txtDescripcion.Clear();
            txtMujeres.Clear();
            txtVarones.Clear();
        }


        #endregion

        
    }
}
