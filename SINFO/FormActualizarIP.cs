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
    public partial class FormActualizarIP : Form
    {
        public FormActualizarIP()
        {
            InitializeComponent();
            cmbMunicipioIP.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbComunidadIP.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPreñada.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRaza.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FormActualizarIP_Load(object sender, EventArgs e)
        {
            CargadgvActualizarIP();
            Cargarcmbmunicipio();
            Cargarcmbrazas();
        }

        #region Cargar La Cosulta a la tabla Inseminacion Porcina
        public void CargadgvActualizarIP()
        {
            N_InseminacionP ObjIP = new N_InseminacionP();
            dgvActualizarIP.DataSource = ObjIP.ObtenerDatosIP();

            //esto de abajo es para racomodar el orden de las columnas
            dgvActualizarIP.Columns["Editar"].DisplayIndex = 16;
            dgvActualizarIP.Columns["Eliminar"].DisplayIndex = 16;
        }
        #endregion

        #region evento cellclick al darle click a la columna editar sobre el icono carga los texbox de la fila seleccionada
        private void dgvActualizarIP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvActualizarIP.Columns[e.ColumnIndex].Name == "Editar")
            {
                
                txtCedula.Text = dgvActualizarIP.CurrentRow.Cells["cedulaproductor"].Value.ToString();
                txtNombre.Text = dgvActualizarIP.CurrentRow.Cells["nombreproductor"].Value.ToString();
                txtCoordenadaX.Text = dgvActualizarIP.CurrentRow.Cells["coordenadaX"].Value.ToString();
                txtCoordenadaY.Text = dgvActualizarIP.CurrentRow.Cells["coordenadaY"].Value.ToString();
                txtTelefono.Text = dgvActualizarIP.CurrentRow.Cells["numerotelfono"].Value.ToString();
                dtpFechaRegistroIP.Text = dgvActualizarIP.CurrentRow.Cells["fechainseminacion"].Value.ToString();
                txtNombreCerdo.Text = dgvActualizarIP.CurrentRow.Cells["nombrecerdo"].Value.ToString();
                cmbMunicipioIP.Text = dgvActualizarIP.CurrentRow.Cells["nombremunicipio"].Value.ToString();
                cmbComunidadIP.Text = dgvActualizarIP.CurrentRow.Cells["nombrecomunidad"].Value.ToString();
                cmbRaza.Text = dgvActualizarIP.CurrentRow.Cells["nombrerazacerdo"].Value.ToString();
                cmbSexo.Text = dgvActualizarIP.CurrentRow.Cells["sexo"].Value.ToString();
            }

            if (dgvActualizarIP.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                string idineminacion = dgvActualizarIP.CurrentRow.Cells["idinseminacion"].Value.ToString();
                EliminarInseminacion(Convert.ToInt32(idineminacion));
                MessageBox.Show("El registro se Elimino correctamente");
                CargadgvActualizarIP();
            }
        }
        #endregion

        #region limpiar campos form Actualizar Inseminacion Porcina
        public void limpiar()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtCoordenadaX.Clear();
            txtCoordenadaY.Clear();
            txtNombreCerdo.Clear();
            txtTelefono.Clear();
        }
        #endregion

        #region carga de combo municipio y combo comunidad

        //metodo para cargar el como municipio
        private void Cargarcmbmunicipio()
        {
            N_InseminacionP objInseminacionP = new N_InseminacionP();
            var lst = objInseminacionP.ObtenerCmbMunicipio();
            if (lst.Count > 0)
            {
                cmbMunicipioIP.DisplayMember = "nombremunicipio"; //lo que se muestra
                cmbMunicipioIP.ValueMember = "idmunicipio"; //lo que almacena
                cmbMunicipioIP.DataSource = lst; //muestra lo que he cargado en lst
            }
        }

        //metodo para cargar el como comunidad
        private void Cargarcmbcomunidad()
        {
            N_InseminacionP objInseminacionP = new N_InseminacionP();
            var id = (int)cmbMunicipioIP.SelectedValue;  // almaceno lo que se selecciona en municipio y un type cast para que sea entero
            var lst = objInseminacionP.ObtenerCmbComunidad(id); // obtengo los datos y pide un parametro id tipo int que se envia al where del metodo obtener
            if (lst.Count > 0)
            {
                cmbComunidadIP.DisplayMember = "nombrecomunidad"; //lo que se muestra
                cmbComunidadIP.ValueMember = "idcomunidad"; //lo que almacena
                cmbComunidadIP.DataSource = lst; //muestra lo que he cargado en lst
            }
        }

        //cuando cambie el index de combo municipio me carge lo que tengo en comunidad
        private void cmbMunicipioIP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)cmbComunidadIP.SelectedIndex != -1) { }//osea si hay alguna informacion cargada
            Cargarcmbcomunidad();  //que ejecute la el metodo
        }

        #endregion

        #region Cargar combobox razas de cerdos
        //metodo para cargar el comboxrazas
        private void Cargarcmbrazas()
        {
            N_InseminacionP objInseminacionP = new N_InseminacionP();
            var lst = objInseminacionP.ObtenerRazas();
            if (lst.Count > 0)
            {
                cmbRaza.DisplayMember = "nombrerazacerdo"; //lo que se muestra
                cmbRaza.ValueMember = "idrazascerdos"; //lo que almacena
                cmbRaza.DataSource = lst; //muestra lo que he cargado en lst
            }
        }
        #endregion

        #region Abrir Form nuevo Registro Inseminacion Porcina
        private void btnNRInseminacionP_Click(object sender, EventArgs e)
        {
            FormNRegistroIP IP = new FormNRegistroIP();
            IP.ShowDialog();
            CargadgvActualizarIP();
        }
        #endregion

        #region editar Registro de Tabla Inseminacion Porcina
        public void Editarinseminacion(int id)
        {
            try
            {

                CDatos conex = new CDatos();
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = conex.AbrirConexion();
                Comando.CommandText = "ActualizarIPorcina";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@idinseminacion", id);
                Comando.Parameters.AddWithValue("@cedulaproductor", txtCedula.Text);
                Comando.Parameters.AddWithValue("@nombreproductor", txtNombre.Text);
                Comando.Parameters.AddWithValue("@idmunicipio3", Convert.ToInt32(cmbMunicipioIP.SelectedValue));
                Comando.Parameters.AddWithValue("@idcomunidad2", Convert.ToInt32(cmbComunidadIP.SelectedValue));
                Comando.Parameters.AddWithValue("@coordenadaX", txtCoordenadaX.Text);
                Comando.Parameters.AddWithValue("@coordenadaY", txtCoordenadaY.Text);
                Comando.Parameters.AddWithValue("@sexo", cmbSexo.SelectedItem.ToString());
                Comando.Parameters.AddWithValue("@numerotelfono", txtTelefono.Text);
                Comando.Parameters.AddWithValue("@fechainseminacion", dtpFechaRegistroIP.Value);
                Comando.Parameters.AddWithValue("@nombrecerdo", txtNombreCerdo.Text);
                Comando.Parameters.AddWithValue("@idrazascerdos1", Convert.ToInt32(cmbRaza.SelectedValue));
                Comando.Parameters.AddWithValue("@presentocelo", cmbPreñada.SelectedItem.ToString());
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

        #region Boton Actualizar para actualizar los datos ya cargados en los componentes
        private void btnguardarIP_Click(object sender, EventArgs e)
        {
           
            string idineminacion = dgvActualizarIP.CurrentRow.Cells["idinseminacion"].Value.ToString();
            Editarinseminacion(Convert.ToInt32(idineminacion));
            MessageBox.Show("El registro se edito correctamente");
            CargadgvActualizarIP();
            limpiar();   
        }

        #endregion

        #region validacion text box letras
        private void txtNombreCerdo_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.Letras(e);
        }
        #endregion

        #region validacion text box numero
        private void txtCoordenadaX_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.Numero(e);
        }
        #endregion

  
    }
}
