using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace ServiciosLinqEscolar.Modelo
{
    public static class UsuarioDAO
    {
        /*     public static usuario iniciarSesion(string username, string password)
             {
                 try
                 {
                     DataClassesEscolarUVDataContext conexionBD = getConnection();

                     var usuario = (from usuarioSesion in conexionBD.usuario
                                          where usuarioSesion.username == username
                                          && usuarioSesion.password == password
                                          select usuarioSesion).FirstOrDefault();
                     return usuario;
                 }
                 catch (Exception ex)
                 {
                     return null;
                 }
             }*/

        public static Mensaje iniciarSesion(string username, string password)
        {

            DataClassesEscolarUVDataContext conexionBD = getConnection();

            var usuarioSesion = (from usuario in conexionBD.usuario
                                 where usuario.username == username
                                 && usuario.password == password
                                 select usuario).FirstOrDefault();

            if (usuarioSesion != null)
            {
                Mensaje msj = new Mensaje()
                {
                    error = false,
                    mensaje = "Usuario encontrado",
                    usuarioLogin = usuarioSesion

                };
                return msj;
            }
            else
            {
                Mensaje msj = new Mensaje()
                {
                    error = true,
                    mensaje = "Usuario no encontrado",
                    usuarioLogin = null
                };
                return msj;
            }
        }

            public static List<usuario> obtenerUsuarios()
        {
            DataClassesEscolarUVDataContext conexionBD = getConnection();

            IQueryable<usuario> usuariosBD = from usuarioQuery in conexionBD.usuario
                                             select usuarioQuery;
            return usuariosBD.ToList();
        }

        public static Boolean guardarUsuario(usuario UsuarioNuevo)
        {
            try
            {
                DataClassesEscolarUVDataContext conexionBD = getConnection();

                var usuario = new usuario()
                {
                    nombre = UsuarioNuevo.nombre,
                    apellidoPaterno = UsuarioNuevo.apellidoPaterno,
                    apellidoMaterno = UsuarioNuevo.apellidoMaterno,
                    username = UsuarioNuevo.username,
                    password = UsuarioNuevo.password
                };
                conexionBD.usuario.InsertOnSubmit(usuario);
                conexionBD.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }

        public static Boolean editarUsuario(usuario UsuarioEdicion)
        {
            try
            {
                DataClassesEscolarUVDataContext conexionBD = getConnection();

                var usuario = (from usuarioEdicion in conexionBD.usuario
                               where usuarioEdicion.idUsuario == UsuarioEdicion.idUsuario
                               select usuarioEdicion).FirstOrDefault();

                if (usuario != null)
                {
                    usuario.nombre = UsuarioEdicion.nombre;
                    usuario.apellidoPaterno = UsuarioEdicion.apellidoPaterno;
                    usuario.apellidoMaterno = UsuarioEdicion.apellidoMaterno;
                    usuario.password = UsuarioEdicion.password;
                    conexionBD.SubmitChanges();
                    return true;
                }
                else { return false; }
            }
            catch (Exception e) 
            { 
                return false; 
            }      
        }

        public static Boolean eliminarUsuario(int idUsuario)
        {
            try
            {
                DataClassesEscolarUVDataContext conexionBD = getConnection();
                
                usuario UsuarioEliminacion = (from usuario in conexionBD.usuario
                                              where usuario.idUsuario == idUsuario
                                              select usuario).FirstOrDefault();
                if(UsuarioEliminacion != null)
                {
                    conexionBD.usuario.DeleteOnSubmit(UsuarioEliminacion);
                    conexionBD.SubmitChanges();
                    return true;
                }
                else { return false; }
            }
            catch (Exception e) 
            { 
                return false; 
            
            }
        }
        public static DataClassesEscolarUVDataContext getConnection()
        {
            return new DataClassesEscolarUVDataContext(global::System.Configuration.
                   ConfigurationManager.ConnectionStrings["escolaruvConnectionString"].ConnectionString);
        }

    }
}