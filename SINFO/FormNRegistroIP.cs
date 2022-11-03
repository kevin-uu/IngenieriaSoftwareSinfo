using CapaNegocio;
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
    public partial class FormNRegistroIP : Form
    {
        N_InseminacionP objN_InseminacionP = new N_InseminacionP();
        inseminacionporcina objIPorcina = new inseminacionporcina();
        public FormNRegistroIP()
        {
            InitializeComponent();
        }

        private void FormNRegistroIP_Load(object sender, EventArgs e)
        {
            Cargarcmbmunicipio();
            Cargarcmbrazas();
        }

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

        #region boton cerrar
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region boton maximizar
        private void button3_Click_1(object sender, EventArgs e)
        {
            //si esta norma lo maximiza, si esta maximizado lo vuelve normar
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
        }
        #endregion

        #region boton minimizar
        private void button2_Click_1(object sender, EventArgs e)
        {
            //si esta normal minimiza, si esta maximizado minimiza
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Metodo para Guardar los Datos y sus Respectivas Conversiones
        public void guardar()
        {
            objIPorcina.cedulaproductor = txtCedula.Text;
            objIPorcina.nombreproductor = txtNombre.Text;
            objIPorcina.idmunicipio3 = Convert.ToInt32(cmbMunicipioIP.SelectedValue);       //el select value se usa porque es el valor real
            objIPorcina.idcomunidad2 = Convert.ToInt32(cmbComunidadIP.SelectedValue);      //se convierte a entero porque la base recibe en estos campos parametros 
            objIPorcina.coordenadaX = txtCoordenadaX.Text;                                //en enteros ya que son llaves foraneas
            objIPorcina.coordenadaY = txtCoordenadaY.Text;
            objIPorcina.sexo = cmbSexo.SelectedItem.ToString();
            objIPorcina.numerotelfono = txtTelefono.Text;
            objIPorcina.fechainseminacion = dtpFechaRegistroIP.Value;
            objIPorcina.nombrecerdo = txtNombreCerdo.Text;
            objIPorcina.idrazascerdos1 = Convert.ToInt32(cmbRaza.SelectedValue);
            if (cmbPreñada.SelectedIndex < -1) objIPorcina.presentocelo = "pendiente";
            else if (cmbPreñada.SelectedIndex >= 0) objIPorcina.presentocelo = cmbPreñada.SelectedItem.ToString();
                       
         }

        #endregion

        #region Boton Guardar Registro inseminacion Porcina
        private void btnguardarIP_Click(object sender, EventArgs e)
        {            
            guardar();
            objN_InseminacionP.GuardarNuevaInseminacion(objIPorcina);
            MessageBox.Show("Actualizador Correctamente");
            
        }
        #endregion
    }
}
