using CapaNegocio;
using SINFO.CapaNegocio;
using SINFO.models;
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

namespace SINFO
{
    public partial class FormNRegistro : Form
    {
        N_Seguimiento objSeguimeinto = new N_Seguimiento();  //instancia a la capaNegocio clase N_Seguimiento que contiene las consultas a la base de datos
        seguimiento tablaseguimiento = new seguimiento();
        public string Idse;
        public FormNRegistro()
        {
            InitializeComponent();
            
        }         

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
        private void cmbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
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

        private void cmbEstrategia_SelectedIndexChanged(object sender, EventArgs e)
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

    
        private void FormNRegistro_Load(object sender, EventArgs e)
        {
            Cargarcmbmunicipio();
            Cargarcmbestrategia();
            Cargarcmbinstitucion();
        }

        #region Boton Guardar Registro
        private void btnguardar_Click(object sender, EventArgs e)
        {
            guardar();                                           //metodo guardar activa el guardado y se guarda en tablaseguimiento por medio el motodo GuardarNuevaActividad ya que este metodo esta esperando la tabla con los datos cargados
            objSeguimeinto.GuardarNuevaActividad(tablaseguimiento);       //objeto dato pido el metodo GuardarNuevaActividad y lo que esta en objeto tablaseguimiento
            MessageBox.Show("guardado");
            
        }
        #endregion

        #region Metodo para Guardar los Datos y sus Respectivas Conversiones
        public void guardar()
        {
            tablaseguimiento.fecha = dtpFechaRegistro.Value;
            tablaseguimiento.idmunicipio1 = Convert.ToInt32(cmbMunicipio.SelectedValue);       //el select value se usa porque es el valor real
            tablaseguimiento.idcomunidad1 = Convert.ToInt32(cmbComunidad.SelectedValue);      //se convierte a entero porque la base recibe en estos campos parametros 
            tablaseguimiento.idestrategia1 = Convert.ToInt32(cmbEstrategia.SelectedValue);    //en enteros ya que son llaves foraneas
            tablaseguimiento.idtiposactividad1 = Convert.ToInt32(cmbTipodeActividad.SelectedValue);
            tablaseguimiento.idinstitucion1 = Convert.ToInt32(cmbInstitucion.SelectedValue);
            tablaseguimiento.descripcion = txtDescripcion.Text;
            tablaseguimiento.varones = Convert.ToInt32(txtVarones.Text);
            tablaseguimiento.mujeres = Convert.ToInt32(txtMujeres.Text);
        }

        #endregion

        #region boton cerrar
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region boton maximizar
        private void button3_Click(object sender, EventArgs e)
        {
            //si esta norma lo maximiza, si esta maximizado lo vuelve normar
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
        }
        #endregion

        #region boton minimizar
        private void button2_Click(object sender, EventArgs e)
        {
            //si esta normal minimiza, si esta maximizado minimiza
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
        }
        #endregion
       

    }


}

