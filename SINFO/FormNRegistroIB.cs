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
    public partial class FormNRegistroIB : Form
    {
        inseminacionBovina objIBovina = new inseminacionBovina();
        N_InseminacionB oBjIb = new N_InseminacionB();
        public FormNRegistroIB()
        {
            InitializeComponent();

            //no se cambie el contenido del combo osea que no se pueda editar una evz que seleccione el combo
            cmbCombi1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCombi2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbComunidadIB.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMunicipioIB.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEsCruze.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRazaVacas.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        
        private void FormNRegistroIB_Load(object sender, EventArgs e)
        {

            Cargarcmbinstitucion();
            Cargarcmbmunicipio();

        }


        #region carga de combo municipio y combo comunidad

        //metodo para cargar el como municipio
        private void Cargarcmbmunicipio()
        {
            N_InseminacionB objInseminacionB = new N_InseminacionB();
            var lst = objInseminacionB.ObtenerCmbMunicipio();
            if (lst.Count > 0)
            {
                cmbMunicipioIB.DisplayMember = "nombremunicipio"; //lo que se muestra
                cmbMunicipioIB.ValueMember = "idmunicipio"; //lo que almacena
                cmbMunicipioIB.DataSource = lst; //muestra lo que he cargado en lst
            }
        }
        //metodo para cargar el como comunidad
        private void Cargarcmbcomunidad()
        {
            N_InseminacionB objInseminacionB = new N_InseminacionB();
            var id = (int)cmbMunicipioIB.SelectedValue;  // almaceno lo que se selecciona en municipio y un type cast para que sea entero
            var lst = objInseminacionB.ObtenerCmbComunidad(id); // obtengo los datos y pide un parametro id tipo int que se envia al where del metodo obtener
            if (lst.Count > 0)
            {
                cmbComunidadIB.DisplayMember = "nombrecomunidad"; //lo que se muestra
                cmbComunidadIB.ValueMember = "idcomunidad"; //lo que almacena
                cmbComunidadIB.DataSource = lst; //muestra lo que he cargado en lst
            }
        }

        //cuando cambie el index de combo municipio me carge lo que tengo en comunidad
        private void cmbMunicipioIB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)cmbComunidadIB.SelectedIndex != -1) { }//osea si hay alguna informacion cargada
            Cargarcmbcomunidad();  //que ejecute la el metodo
        }

        #endregion

        #region Carga de combo Institucion
        private void Cargarcmbinstitucion()
        {
            N_InseminacionB objInseminacionB = new N_InseminacionB();
            var lst = objInseminacionB.ObtenerCmbInstitucion();
            if (lst.Count > 0)
            {
                cmbInstitucion.DisplayMember = "nombreinstitucion"; //lo que se muestra
                cmbInstitucion.ValueMember = "idinstitucion"; //lo que almacena
                cmbInstitucion.DataSource = lst; //muestra lo que he cargado en lst
            }
        }

        #endregion

        #region al seleccionar el combo es cruze ver si la seleccion es igual a "SI" si es asi que muestre los demas controles
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string confi = cmbEsCruze.SelectedItem.ToString();
            if (confi == "SI")
            {
                lblCombi1.Visible = true;
                lblCombi2.Visible = true;
                cmbCombi1.Visible = true;
                cmbCombi2.Visible = true;
                btnAgregarcombi.Visible = true;
                btnCancelar.Visible = false;
                btnguardar.Visible = false;
            }
        }
        #endregion

        #region agregar la nueva combinacion de razas al combo de seleccion de razas para guardarla
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string combi1 = cmbCombi1.SelectedItem.ToString();
            string combi2 = cmbCombi2.SelectedItem.ToString();
            cmbRazaVacas.Items.Add(combi1 + "/" + combi2);
            cmbRazaUsada.Items.Add(combi1 + "/" + combi2);
            cmbRazaInteres.Items.Add(combi1 + "/" + combi2);

            lblCombi1.Visible = false;
            lblCombi2.Visible = false;
            cmbCombi1.Visible = false;
            cmbCombi2.Visible = false;
            btnAgregarcombi.Visible = false;
            btnCancelar.Visible = true;
            btnguardar.Visible = true;
        }




        #endregion

        #region boton cancelar
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region boton cerrar
        private void button1_Click_1(object sender, EventArgs e)
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

        #region boton Minimizar
        private void button2_Click(object sender, EventArgs e)
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
            objIBovina.cedulaproductorB = txtCedula.Text;
            objIBovina.nombreproductorB = txtNombre.Text;
            objIBovina.numerotelfonoB = txtTelefono.Text;
            objIBovina.idmunicipio5 = Convert.ToInt32(cmbMunicipioIB.SelectedValue);       //el select value se usa porque es el valor real
            objIBovina.idcomunidad4 = Convert.ToInt32(cmbComunidadIB.SelectedValue);      //se convierte a entero porque la base recibe en estos campos parametros 
            objIBovina.coordenadaXB = txtCoordenadaXB.Text;                                //en enteros ya que son llaves foraneas
            objIBovina.coordenadaYB = txtCoordenadaYB.Text;
            objIBovina.varones = Convert.ToInt32(txtVarones.Text);
            objIBovina.mujeres = Convert.ToInt32(txtMujeres.Text);
            objIBovina.direccion = txtDireccion.Text;
            
            objIBovina.nombrevaca = txtNombreVaca.Text;
            objIBovina.arete = txtNArete.Text;
            objIBovina.RazaVaca = cmbRazaVacas.SelectedItem.ToString();
            objIBovina.edad = Convert.ToInt32(txtEdadVaca.Text);
            objIBovina.numerodeparto = Convert.ToInt32(txtEdadVaca.Text);
            objIBovina.condicioncorporal = Convert.ToDouble(txtCondicionCorporal.Text);
            objIBovina.razadeinteres = cmbRazaInteres.SelectedItem.ToString();
            objIBovina.razausada = cmbRazaUsada.SelectedItem.ToString();
            objIBovina.fechaaplicacionds = dtpFechaAplicacionDs.Value;
            objIBovina.fecharetirods = dtpFechaRetiroDS.Value;
            objIBovina.fechainseminacionB = dtpFechaInseminacionB.Value;
            objIBovina.idinstitucion4 = Convert.ToInt32(cmbInstitucion.SelectedValue);
            objIBovina.observacion = txtObsevacion.Text;
            objIBovina.presentocelo1 = "PENDIENTE";
        }

        #endregion

        #region Boton Guardar un Nuevo Registro Inseminacion Bovina
        private void btnguardar_Click(object sender, EventArgs e)
        {
            guardar();
            oBjIb.GuardarNuevaInseminacionB(objIBovina);
            MessageBox.Show("Actualizador Correctamente");
        }
        #endregion

        private void dtpFechaAplicacionDs_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaaplicacion = dtpFechaAplicacionDs.Value;
            dtpFechaRetiroDS.Value = fechaaplicacion.AddDays(7);
            DateTime RetiroDS = dtpFechaRetiroDS.Value;
            dtpFechaInseminacionB.Value = RetiroDS.AddDays(2);
        }
    }
}
