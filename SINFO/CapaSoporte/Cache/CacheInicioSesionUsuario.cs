using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINFO.CapaSoporte.Cache
{
    //statica significa que los valores son permentes mientras la aplicacion exista
    //almacena temporalmente los datos del usuario
    public static class CacheInicioSesionUsuario
    {
        public static int IdUser { get; set; }
        public static string LoginName { get; set; }
        public static string Password { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Position { get; set; }
        public static string Email { get; set; }
    }
}
