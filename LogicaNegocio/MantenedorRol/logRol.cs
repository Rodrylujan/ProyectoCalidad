using LogicaNegocio.MantenedorServicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.DaoEntidades;
using entRol;

namespace LogicaNegocio.MantenedorRol
{
    public class logRol
    {
        private static readonly logRol _instancia = new logRol();

        public static logRol Instancia
        {
            get
            {
                return logRol._instancia;
            }
        }


        #region Métodos
        public List<Rol> listarRol() => datRol.Instancia.listarRol();

        public Rol buscarRolId(int id_rol) => datRol.Instancia.buscarRolId(id_rol);

        public Rol buscarRolNombre(string name_rol) => datRol.Instancia.buscarRolNombre(name_rol);
        #endregion
    }
}
