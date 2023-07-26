using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;
using SINFO.Models;
using SINFO.CapaSoporte.Cache;

namespace CapaDatos
{
    public class usuarios:connectiontosql
    {
        #region Metodo de iniciar sesion

        //en este metodo se carga el cache de los datos de usuario
        public bool login(string user, string pass)
        {
            using (var conecction = getconnection())
            {
                conecction.Open();
                using (var coman = new SqlCommand())
                {
                    coman.Connection = conecction;
                    coman.CommandText = "select * from usuarios where LoginName=@usuario and password=@pass";
                    coman.Parameters.AddWithValue("@usuario", user);
                    coman.Parameters.AddWithValue("@pass", pass);
                    coman.CommandType = CommandType.Text;
                    SqlDataReader reader = coman.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CacheInicioSesionUsuario.IdUser = reader.GetInt32(0); //se especifica el numero de columna que sera igual al CacheInicioSesionUsuario.IdUser el reader lee la consulta a la base de datos y GetInt32 obtiene un entero
                            CacheInicioSesionUsuario.LoginName = reader.GetString(1);
                            CacheInicioSesionUsuario.Password = reader.GetString(2);
                            CacheInicioSesionUsuario.FirstName = reader.GetString(3);
                            CacheInicioSesionUsuario.LastName = reader.GetString(4);
                            CacheInicioSesionUsuario.Position = reader.GetString(5);
                            CacheInicioSesionUsuario.Email = reader.GetString(6);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
        #endregion

        //metodo de tipo string y de nombre recuperar contraseña con un parametro de entrada de tipo string para
        //obtener el dato del usuario solicitado
        public string recuperarcontraseñaC(string usuar)
        {
            using (var conecction = getconnection())
            {
                conecction.Open();
                using (var coman = new SqlCommand())
                {
                    coman.Connection = conecction;
                    coman.CommandText = "select *from usuarios where LoginName=@usuario or Email=@mail";
                    coman.Parameters.AddWithValue("@usuario", usuar);
                    coman.Parameters.AddWithValue("@mail", usuar);
                    coman.CommandType = CommandType.Text;
                    SqlDataReader reader = coman.ExecuteReader();

                    if (reader.Read() == true) //si el lector tiene filasosea si es correcta la consulta
                    {
                        //obtenemos los datos
                        string userName = reader.GetString(3) + ", " + reader.GetString(4);
                        string userMail = reader.GetString(6);
                        string accountPassword = reader.GetString(2);
                        var mailService = new SINFO.CapaDatos.ServiciodeCorreoE.administracionyenviodecorreo();
                        mailService.enviarmensajes(
                          subject: "Solicitud de recuperacion de Contraseñas", //Asunto del mensaje
                          body: "Hola, " + userName + "\nUsted solicitó recuperar su contraseña.\n" + //cuerpo del mensaje
                          "tu contraseña actual es: " + accountPassword +
                          "\nLe solicitamos que por favor cambie su contraseña una vez que ingrese al sistema",
                          recipientMail: new List<string> { userMail } //Correo a quien sera enviado
                          );
                        return "Hola, " + userName + "\nUsted solicitó recuperar su contraseña\n" +
                          "Por favor revise su correo: " + userMail +
                          "\nSin embargo, le pedimos que cambie su contraseña inmediatamente una vez que ingrese al sistema.";
                    }
                    else
                        return "Lo sentimos, no tiene una cuenta con ese correo o nombre de usuario";
                }

            }
            

        }
        #region metodo para aplicar seguridad y permisos de usuario
        public void Validarcargodeusuario() //preguntamos si la posicion del usuario es igual a administrador
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

        #endregion

    }
}
