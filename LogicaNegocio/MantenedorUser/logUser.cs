using System;
using System.Collections.Generic;
using AccesoDatos.DaoEntidades;
using entUser;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.MantenedorUser
{
    public class logUser
    {
        
        private static readonly logUser _instancia = new logUser();
        public static logUser Instancia
        {
            get
            {
                return logUser._instancia;
            }
        }
        public int validarInicioSesion(string user, string passsword) => datUser.Instancia.ValidarSesion(user, passsword);

        public List<User> listarUsuarios() => datUser.Instancia.listarUsuarios();

        public User buscarUsuario(int id_usuario) => datUser.Instancia.buscarUsuario(id_usuario);

        public int insertarUsuario(User usuario) => datUser.Instancia.insertarUsuario(usuario);

        public bool editarUsuario(User usuario) => datUser.Instancia.editarUsuario(usuario);

        public bool deshabilitarUsuario(User usuario) => datUser.Instancia.deshabilitarUsuario(usuario);
    }
}
