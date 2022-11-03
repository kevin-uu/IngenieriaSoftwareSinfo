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

namespace SINFO
{
    public partial class FormActualizarSeguimiento : Form
    {
        
        N_Seguimiento objSeguimeinto = new N_Seguimiento();
        seguimiento tablaseguimiento = new seguimiento();
        FormNRegistro formnregistro = new FormNRegistro();
        CDatos datos = new CDatos();
        int idSegu;  //variable para almacenar el id seguimiento y no mostrarlo en el formulario
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

        private void FormActualizarSeguimiento_Load(object sender, EventArgs e)
        {
            CargadgvActualizar();

        }

        #region Boton Nuevo Registro
        private void button4_Click(object sender, EventArgs e)
        {
            FormNRegistro formnregistro = new FormNRegistro();   //instancia al form nuevo registro
            formnregistro.ShowDialog();                          //en todo el foco principal
            CargadgvActualizar();                              //actualiza la vista
        }
        #endregion

        #region Boton Actualizar
        private void button2_Click(object sender, EventArgs e)
        {/*
            formnregistro.ShowDialog();
            if (idSegu > 0)  //si tengo seleccionado un registro
            {
                formnregistro.guardar();
                objSeguimeinto.ActualizarActividad(tablaseguimiento);
            }
            else
            {
                MessageBox.Show("Debe Seleccionar 1 registro");
            }*/

            

            /*
            if (dgvActualizar.SelectedRows.Count > 0)
            {
                FormNRegistro formnregistro = new FormNRegistro();   //instancia al form nuevo registro
                formnregistro.Idse = Convert.ToString(idSegu);
                formnregistro.cmbMunicipio.Text = dgvActualizar.CurrentRow.Cells[3].Value.ToString();
                formnregistro.cmbComunidad.Text = dgvActualizar.CurrentRow.Cells[4].Value.ToString();
                formnregistro.cmbInstitucion.Text = dgvActualizar.CurrentRow.Cells[5].Value.ToString();
                formnregistro.cmbEstrategia.Text = dgvActualizar.CurrentRow.Cells["Estrategias"].Value.ToString();
                formnregistro.cmbTipodeActividad.Text = dgvActualizar.CurrentRow.Cells["Actividad"].Value.ToString();
                formnregistro.txtDescripcion.Text = dgvActualizar.CurrentRow.Cells["Descripcion"].Value.ToString();
                formnregistro.txtVarones.Text = dgvActualizar.CurrentRow.Cells["Varones"].Value.ToString();
                formnregistro.txtMujeres.Text = dgvActualizar.CurrentRow.Cells["Mujeres"].Value.ToString();
                formnregistro.ShowDialog();                          //en todo el foco principal se muestra encima
                CargadgvActualizar();
            }          
            */
        }
        #endregion

        #region Evento cell click para mostrar el Form Nuevo Registro y Actualizar un dato
        private void dgvActualizar_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvActualizar.Columns[e.ColumnIndex].Name == "Editar")
            {
                FormNRegistro fN = new FormNRegistro();
                idSegu = Convert.ToInt32(dgvActualizar.CurrentRow.Cells["IDS"].Value.ToString());
                fN.dtpFechaRegistro.Text = dgvActualizar.CurrentRow.Cells["fecha"].Value.ToString();
                fN.cmbMunicipio.Text = dgvActualizar.CurrentRow.Cells["Municipio"].Value.ToString();
                fN.cmbComunidad.Text = dgvActualizar.CurrentRow.Cells["Comunidad"].Value.ToString();
                fN.cmbInstitucion.Text = dgvActualizar.CurrentRow.Cells["Institucion"].Value.ToString();
                fN.cmbEstrategia.Text = dgvActualizar.CurrentRow.Cells["Estrategias"].Value.ToString();
                fN.cmbTipodeActividad.Text = dgvActualizar.CurrentRow.Cells["Actividad"].Value.ToString();
                fN.txtDescripcion.Text = dgvActualizar.CurrentRow.Cells["Descripcion"].Value.ToString();
                fN.txtVarones.Text = dgvActualizar.CurrentRow.Cells["Varones"].Value.ToString();
                fN.txtMujeres.Text = dgvActualizar.CurrentRow.Cells["Mujeres"].Value.ToString();

                
                fN.Show();
                fN.btnguardar.Text = "Actualizar";

                CargadgvActualizar();
            }
            
            /*
            if (dgvActualizar.Columns[e.ColumnIndex].Name == "Editar")
            {
                FormNRegistro fN = new FormNRegistro();
                idSegu = Convert.ToInt32(dgvActualizar.CurrentRow.Cells["IDS"].Value.ToString());
                fN.dtpFechaRegistro.Text = dgvActualizar.CurrentRow.Cells["fecha"].Value.ToString();
                fN.cmbMunicipio.Text = dgvActualizar.CurrentRow.Cells["Municipio"].Value.ToString();
                fN.cmbComunidad.Text = dgvActualizar.CurrentRow.Cells["Comunidad"].Value.ToString();
                fN.cmbInstitucion.Text = dgvActualizar.CurrentRow.Cells["Institucion"].Value.ToString();
                fN.cmbEstrategia.Text = dgvActualizar.CurrentRow.Cells["Estrategias"].Value.ToString();
                fN.cmbTipodeActividad.Text = dgvActualizar.CurrentRow.Cells["Actividad"].Value.ToString();
                fN.txtDescripcion.Text = dgvActualizar.CurrentRow.Cells["Descripcion"].Value.ToString();
                fN.txtVarones.Text = dgvActualizar.CurrentRow.Cells["Varones"].Value.ToString();
                fN.txtMujeres.Text = dgvActualizar.CurrentRow.Cells["Mujeres"].Value.ToString();


                fN.Show();


                CargadgvActualizar();
            }*/
        }
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dgvActualizar.DataSource as DataTable).DefaultView.RowFilter = $"Institucion LIKE '{textBox1.Text}%'";
        }
    }
}
