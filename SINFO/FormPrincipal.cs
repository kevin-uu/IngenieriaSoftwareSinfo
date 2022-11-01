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
            //debajo de todo el codigo de accion de cada uno de los botones del sub menu siempre invocar al metodo ocultarsubmenu
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
            //debajo de todo el codigo de accion de cada uno de los botones del sub menu siempre invocar al metodo ocultarsubmenu
            ocultarsubmenu();
        }

        private void btnactualizarregistroIB_Click(object sender, EventArgs e)
        {
            //debajo de todo el codigo de accion de cada uno de los botones del sub menu siempre invocar al metodo ocultarsubmenu
            ocultarsubmenu();
        }

        private void btnreporteIB_Click(object sender, EventArgs e)
        {
            //debajo de todo el codigo de accion de cada uno de los botones del sub menu siempre invocar al metodo ocultarsubmenu
            ocultarsubmenu();
        }
        #endregion

        
    }
}
