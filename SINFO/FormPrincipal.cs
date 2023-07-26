﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Cells;
using CapaNegocio;
using SINFO.CapaSoporte.Cache;

namespace SINFO
{
    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {
            InitializeComponent();
            personalizardiseño();
        }

        #region metodo para abrir formulario hijos en el panel contenedor

        //para abrir 1 unico formulario es necesario cerrar el formulario anterior
        //para ello es necesario almacenar el formulario que se abre declaramos una variable privada
        private Form formularioactivo = null;
        private void abrirformulariohijo(Form formulariohijo) //creamos un parametro de tipo form para almacenar el formulario activo
        {
            if (formularioactivo != null) //si el formulario activo es diferente a nulo cerramos el formulario activo
                formularioactivo.Close(); //es decir si existe un formulario abrierto lo cerramos
            formularioactivo = formulariohijo; // guardamos el formulario que se abre en la variable formulario activo
            formulariohijo.TopLevel = false; //indicamo que el form hijo no es de nvel superior, osea se comportara igual que un control
            formulariohijo.FormBorderStyle = FormBorderStyle.None; //quitamos el borde del formulario
            formulariohijo.Dock = DockStyle.Fill; //establecemos la propiedad dock para llenar el fomulario al panel
            panelformhijo.Controls.Add(formulariohijo); //agregamos el formulario a la lista de controles del panel form hijo
            panelformhijo.Tag = formulariohijo; //asociamos el formulario con el panel form hijo
            formulariohijo.BringToFront(); //en caso de colocar un logo necesitamos traer el fomulario al frente
            formulariohijo.Show(); //mostramos el formulario hijo
        }

        #endregion

        #region metodos para mostrar y ocultar sub menu
        //oculta los paneles del sub menu
        private void personalizardiseño()
        {
            panelsubmenuIB.Visible = false;
            panelsubmenuIP.Visible = false;
            panelsubmenuseguimiento.Visible = false;
            panelsubmenumetas.Visible = false;
        }

        //oculta el submenu que se ha mostrado previamente
        private void ocultarsubmenu()
        {
            if (panelsubmenuseguimiento.Visible == true)
                panelsubmenuseguimiento.Visible = false;
            if (panelsubmenuIP.Visible == true)
                panelsubmenuIP.Visible = false;
            if (panelsubmenuIB.Visible == true)
                panelsubmenuIB.Visible = false;
            if (panelsubmenumetas.Visible == true)
                panelsubmenumetas.Visible = false;
        }

        //motrar el menu
        private void mostrasubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                ocultarsubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        #endregion

        #region sub menu seguimiento

        private void btnseguimiento_Click(object sender, EventArgs e)
        {
            mostrasubmenu(panelsubmenuseguimiento);
            
        }

        private void btnnuevoseguimiento_Click(object sender, EventArgs e)
        {
            abrirformulariohijo(new FormActualizarSeguimiento());
            //debajo de todo el codigo de accion de cada uno de los botones del sub menu siempre invocar al metodo ocultarsubmenu
            ocultarsubmenu();
        }

        private void btnreporseguimiento_Click(object sender, EventArgs e)
        {
            abrirformulariohijo(new reporteSeguimiento());
            ocultarsubmenu();
        }

        #endregion

        #region sub menu IP
        private void btninseminacionporcina_Click(object sender, EventArgs e)
        {
            mostrasubmenu(panelsubmenuIP);
            
        }

        private void btnnuevoregistroinseminacionP_Click(object sender, EventArgs e)
        {
            abrirformulariohijo(new FormActualizarIP());
            FormNRegistroIP IP = new FormNRegistroIP();
            IP.Show();
            //debajo de todo el codigo de accion de cada uno de los botones del sub menu siempre invocar al metodo ocultarsubmenu
            ocultarsubmenu();
        }

        private void btnactualizarregistroIP_Click(object sender, EventArgs e)
        {
            abrirformulariohijo(new FormActualizarIP());
            //debajo de todo el codigo de accion de cada uno de los botones del sub menu siempre invocar al metodo ocultarsubmenu
            ocultarsubmenu();
        }

        private void btnreporteIP_Click(object sender, EventArgs e)
        {
            abrirformulariohijo(new reporteInseminacionP());
            //debajo de todo el codigo de accion de cada uno de los botones del sub menu siempre invocar al metodo ocultarsubmenu
            ocultarsubmenu();
        }

        private void btnRegistroPartoP_Click(object sender, EventArgs e)
        {
            abrirformulariohijo(new FormPartoIP());
            ocultarsubmenu();
        }
        #endregion

        #region sub menu IB
        private void btninseminacionbovina_Click(object sender, EventArgs e)
        {
            mostrasubmenu(panelsubmenuIB);
            
        }

        private void btnnuevoregistroinseminacionB_Click(object sender, EventArgs e)
        {
            abrirformulariohijo(new FormActualizarIB());
            FormNRegistroIB IB = new FormNRegistroIB();
            IB.Show();
            //debajo de todo el codigo de accion de cada uno de los botones del sub menu siempre invocar al metodo ocultarsubmenu
            ocultarsubmenu();
        }

        private void btnactualizarregistroIB_Click(object sender, EventArgs e)
        {
            abrirformulariohijo(new FormActualizarIB());
            //debajo de todo el codigo de accion de cada uno de los botones del sub menu siempre invocar al metodo ocultarsubmenu
            ocultarsubmenu();
        }

        private void btnreporteIB_Click(object sender, EventArgs e)
        {
            abrirformulariohijo(new reporteInseminacionB());
            //debajo de todo el codigo de accion de cada uno de los botones del sub menu siempre invocar al metodo ocultarsubmenu
            ocultarsubmenu();
        }

        private void btnRegistroPartoB_Click(object sender, EventArgs e)
        {
            abrirformulariohijo(new FormPartoIB());
            //debajo de todo el codigo de accion de cada uno de los botones del sub menu siempre invocar al metodo ocultarsubmenu
            ocultarsubmenu();
        }
        #endregion

        #region sub menu metas

        private void btnmetas_Click(object sender, EventArgs e)
        {
            mostrasubmenu(panelsubmenumetas);
            
        }
        private void btnnuevoregistrometas_Click(object sender, EventArgs e)
        {
            abrirformulariohijo(new FormRMetas());
            ocultarsubmenu();
        }

        private void btnactualizarmetas_Click(object sender, EventArgs e)
        {
            abrirformulariohijo(new FormActualizarMetas());
            ocultarsubmenu();
        }

        private void btnreportemetas_Click(object sender, EventArgs e)
        {
            abrirformulariohijo(new reporteMetas());
            ocultarsubmenu();
        }


        #endregion

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            LoadUserData();
            //condicion donde preguntamos si el cargo del usuario
            // es tecnico 
            if (CacheInicioSesionUsuario.Position == cargos.Tecnico)
            {
                btnactualizarregistroIP.Enabled = false; // entonces desactivamos el boton actualizar
                btnactualizarregistroIB.Enabled = false;
                btnnuevoregistrometas.Enabled = false;
                btnactualizarmetas.Enabled = false;
            }
        }

        #region Boton Cerrar Sesion
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("desea cerrar esta aplicacion", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("desea cerrar esta aplicacion", "Warning",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        #endregion

        #region metodo para cargar los datos del cache en los label
        private void LoadUserData()
        {
            lblNombre.Text = CacheInicioSesionUsuario.LoginName;
            lblposicion.Text = CacheInicioSesionUsuario.Position;
            lblcorreo.Text = CacheInicioSesionUsuario.Email;

            //mamaño al que debe llegar le menu latera
            //298
        }


        #endregion

        
    }
}
