using ServiciosLinqEscolar.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiciosLinqEscolar
{
    public class Service1 : IService1
    {
        public Mensaje IniciarSesion(string username, string password)
        {
            return UsuarioDAO.iniciarSesion(username, password);
        } 

        public List<usuario> ObtenerUsuario()
        {
            return UsuarioDAO.obtenerUsuarios();
        }
        public bool GuardarUsuario(usuario UsuarioNuevo)
        {
            return UsuarioDAO.guardarUsuario(UsuarioNuevo);
        }

        public bool EditarUsuario(usuario UsuarioEdicion)
        {
            return UsuarioDAO.editarUsuario(UsuarioEdicion);
        }

        public bool EliminarUsuario(int idUsuario)
        {
            return UsuarioDAO.eliminarUsuario(idUsuario);
        }
    }
}
