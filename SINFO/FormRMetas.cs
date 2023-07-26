using SINFO.CapaNegocio;
using SINFO.models;
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
    public partial class FormRMetas : Form
    {
        N_Metas objmetas = new N_Metas();
        metas tablametas = new metas();
        public FormRMetas()
        {
            InitializeComponent();
        }

        private void FormRMetas_Load(object sender, EventArgs e)
        {
            Cargarcmbinstitucion();
            Cargarcmbestrategia();
        }

        #region carga de combo Estrategia y combo Tipos de Actividades
        private void Cargarcmbestrategia()
        {
            N_Metas objMetas = new N_Metas();
            var lst = objMetas.ObCEst();
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
        private void cmbEstrategia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)cmbTipodeActividad.SelectedIndex != -1) { }//osea si hay alguna informacion cargada
            Cargarcmbtiposdeactividades();//que ejecute la el metodo
        }

        #endregion

        #region Carga de combo Institucion
        private void Cargarcmbinstitucion()
        {
            N_Metas objMetas = new N_Metas();
            var lst = objMetas.ObtenerCmbInstitucion();
            if (lst.Count > 0)
            {
                cmbInstitucion.DisplayMember = "nombreinstitucion"; //lo que se muestra
                cmbInstitucion.ValueMember = "idinstitucion"; //lo que almacena
                cmbInstitucion.DataSource = lst; //muestra lo que he cargado en lst
            }
        }

        #endregion

        #region Metodo para Guardar los Datos y sus Respectivas Conversiones
        public void guardar()
        {
            tablametas.fechaderegistro = dtpFechaRegistro.Value;
            tablametas.idestrategia2 = Convert.ToInt32(cmbEstrategia.SelectedValue);
            tablametas.idtiposactividad2 = Convert.ToInt32(cmbTipodeActividad.SelectedValue); //el select value se usa porque es el valor real
            tablametas.idinstitucion2 = Convert.ToInt32(cmbInstitucion.SelectedValue);      //se convierte a entero porque la base recibe en estos campos parametros 
            tablametas.cantidad = Convert.ToInt32(txtCantidad.Text);                                  //en enteros ya que son llaves foraneas
        }

        #endregion

        #region Boton Guardar Nueva Meta
        private void btnGuardarMetas_Click(object sender, EventArgs e)
        {
            guardar();                                           //metodo guardar activa el guardado y se guarda en tablaseguimiento por medio el motodo GuardarNuevaActividad ya que este metodo esta esperando la tabla con los datos cargados
            objmetas.GuardarNuevaActividadMestas(tablametas);       //objeto dato pido el metodo GuardarNuevaActividad y lo que esta en objeto tablaseguimiento
            MessageBox.Show("guardado");
        }
        #endregion 
    }
}
