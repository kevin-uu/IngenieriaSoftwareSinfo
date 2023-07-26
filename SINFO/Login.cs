using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaNegocio;
using System.Data.SqlClient;
using SINFO;
using SINFO.CapaSoporte.Cache;

namespace SINFO
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        #region Formulario de inicio de Sesion textbox Usuario
        private void txtusuario_Enter(object sender, EventArgs e) // cuando el cursor del mouse esta dentro de la caja de texto
        {
            if (txtusuario.Text == "USUARIO                                                                                              ")
            {
                txtusuario.Text = ""; //de ser asi se vaciara
                txtusuario.ForeColor = Color.LightGray; //AL momento de escribir resalte mas el texto
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)//cuando el cursor del mouse sale del texto
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "USUARIO                                                                                              ";
                txtusuario.ForeColor = Color.DimGray;
            }   
        }
        #endregion

        #region Formulario de inicio de Sesion textbox Usuario
        private void txtcontraseña_Enter(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "CONTRASEÑA                                                                                         ")
            {
                txtcontraseña.Text = ""; //de ser asi se vaciara
                txtcontraseña.ForeColor = Color.LightGray; //AL momento de escribir resalte mas el texto
                txtcontraseña.UseSystemPasswordChar = true; //para que los caracteres se oculten
            }
        }

        private void txtcontraseña_Leave(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "CONTRASEÑA                                                                                         ")
            {
                txtcontraseña.Text = ""; //de ser asi se vaciara
                txtcontraseña.ForeColor = Color.LightGray; //AL momento de escribir resalte mas el texto
                txtcontraseña.UseSystemPasswordChar = false;
            }
        }
        #endregion

        #region boton cerrar
        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); //para cerrar
        }
        #endregion

        #region boton Minimizar
        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;  // para minimizar
        }
        #endregion

        #region codigo para movilizar los paneles

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Login_MouseDown(object sender, MouseEventArgs e) //para mover el form
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) //para mover el form desde el panel
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region metodo para logeo se envian como parametros los text box al metodo en la capa negocio
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text != "USUARIO                                                                                              ") {
                if (txtcontraseña.Text != "CONTRASEÑA                                                                                         ") {
                    user user = new user();
                    var validlogin = user.LoginName(txtusuario.Text,txtcontraseña.Text);
                    if(validlogin == true)
                    {
                        this.Hide();
                        FormBienvenida bien = new FormBienvenida();
                        bien.ShowDialog();
                        FormPrincipal mainMenu = new FormPrincipal();
                        //MessageBox.Show("Bienvenido "+ CacheInicioSesionUsuario.FirstName+", "+ CacheInicioSesionUsuario.LastName); //mensaje de bienvenida
                        mainMenu.Show();
                        mainMenu.FormClosed += cerrarsesion; //sobrecarga de formulario para cerrar sesion
                        
                    }
                    else
                    {
                        msgerror("usuario o contraseña incorrecta. \n         por favor intente de nuevo.");
                        txtcontraseña.Text= "CONTRASEÑA                                                                                         ";
                        txtusuario.Focus();
                    }
                }
                else msgerror("por favor ingrese su contraseña.");
            }
            else msgerror("por favor ingrese su nombre de usuario.");
        }

        #endregion

        #region metodo para hacer mensajes
        private void msgerror(string msg)
        {
            lblerrormensaje.Text = "         " + msg;
            lblerrormensaje.Visible = true;
        }
        #endregion

        #region Metodo para cerrar sesion
        private void cerrarsesion(object sender, FormClosedEventArgs e)
        {
            txtcontraseña.Text= "CONTRASEÑA                                                                                         ";
            txtcontraseña.UseSystemPasswordChar = false;
            txtusuario.Text= "USUARIO                                                                                              ";
            lblerrormensaje.Visible = false;
            this.Show();
            //txtusuario.Focus();
        }
        #endregion

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var FormRc = new FormRecuperarContraseña();
            FormRc.ShowDialog();
        }
    }
}
