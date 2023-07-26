using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINFO.CapaDatos.ServiciodeCorreoE
{
    class administracionyenviodecorreo:ServidordeCorreoMaestro
    {
        //Constructor
        public administracionyenviodecorreo()
        {
            senderMail = "soportesinfo568@gmail.com";
            password = "yjbsosbckqlstpxf";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            Inicializacionsmtp();
        }

        
    }
}
