using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;
using SINFO.CapaSoporte.Cache;

namespace CapaNegocio
{
    public class user
    {
        usuarios usuarios = new usuarios();
        public bool LoginName(string user, string pass)
        {
            return usuarios.login(user,pass);
        }

        public void metododevalidacioncargos()
        {
            if (CacheInicioSesionUsuario.Position == cargos.Administrator)
            {
                //codigo todo
            }
            if (CacheInicioSesionUsuario.Position == cargos.Tecnico)
            {
                //codigo solo guardar
            }
        }

        //metodo publico 
        public string recuperarcontraseña(string usuariosolicitante)
        {
            return usuarios.recuperarcontraseñaC(usuariosolicitante);
        }

        /*
        public bool editContraseña(int user, string pass) //para cambiar la contraseña
        {
            if (user == CacheInicioSesionUsuario.IdUser) // necesitamos que el usuario sea real
            { 
            
            }
            return true;
        }*/

    }
}
