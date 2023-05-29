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
        [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Mensaje IniciarSesion(string username, string password);
        [OperationContract]
        List<usuario> ObtenerUsuario();
        [OperationContract]
        Boolean GuardarUsuario(usuario UsuarioNuevo);
        [OperationContract]
        Boolean EditarUsuario(usuario UsuarioEdicion);
        [OperationContract]
        Boolean EliminarUsuario(int idUsuario);
    }

    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
