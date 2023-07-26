using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace SINFO.CapaDatos.ServiciodeCorreoE
{
    public abstract class ServidordeCorreoMaestro
    {
        //declaracion de atributo 

        private SmtpClient smtpClient;
        protected string senderMail { get; set; } //correo remitente
        protected string password { get; set; } //contraseña
        protected string host { get; set; } //servidor
        protected int port { get; set; } //puerto de entrada y salida de correos
        protected bool ssl { get; set; } //protocolo a utilizar

        //metodo para inicializar el cliente Smtp

        #region metodo para inicializar el cliente Smtp
        protected void Inicializacionsmtp()
        {
            smtpClient = new SmtpClient();

            smtpClient.Credentials = new NetworkCredential(senderMail, password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;

        }
        #endregion


        //metodo para enviar mensajes de correo

        #region Metodo para enviar mensajes de correo
        public void enviarmensajes(string subject, string body, List<string> recipientMail)
        {
            var mailMessage = new MailMessage(); //clase mensaje de correo instancia
            try
            {
                mailMessage.From = new MailAddress(senderMail); //indicamos de quien es enviado el correo campo senderMail 
                foreach (string mail in recipientMail) //para quien sera enviado mediante un foreach que recorre todo los correos seleccionados
                {
                    mailMessage.To.Add(mail); //agragmos cada correo electronico de la lista
                }
                mailMessage.Subject = subject;  //asunto del correo lo especificamos con el parametro asunto
                mailMessage.Body = body; //espeficiamos el cuerpo o el mensaje con el parametro cuerpo
                mailMessage.Priority = MailPriority.Normal; //indicamos como prioridad normal
                smtpClient.Send(mailMessage);//Enviar mensaje mediante el protocolo simple de transferencia de correo (smtp)
            }
            catch (Exception ex) { }
            finally
            {
                //desechamos los objetos
                mailMessage.Dispose();
                smtpClient.Dispose();
            }
        }
        #endregion
    }
}
