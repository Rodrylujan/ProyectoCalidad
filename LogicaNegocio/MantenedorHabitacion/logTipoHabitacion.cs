using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.DaoEntidades;
using entTipoHabitacion;

namespace LogicaNegocio.Mantenedor
{
    public class logTipoHabitacion
    {
        private static readonly logTipoHabitacion _instancia = new logTipoHabitacion();

        public static logTipoHabitacion Instancia
        {
            get
            {
                return logTipoHabitacion._instancia;
            }
        }
        public List<entTipoHabitacion.TipoHabitacion> ListarTipoHabitacion()
        {
            return datTipoHabitacion.Instancia.ListarTipoHabitacion();
        }
        public bool InsertarTipoHabitacion(entTipoHabitacion.TipoHabitacion tip)
        {
            return datTipoHabitacion.Instancia.InsertarTipoHabitacion(tip);
        }
        public void EditaTipoHabitacion(entTipoHabitacion.TipoHabitacion tip)
        {
            datTipoHabitacion.Instancia.EditarTipoHabitacion(tip);
        }
        public TipoHabitacion BuscarTipoHabitacionPorId(int id)
        {
            return datTipoHabitacion.Instancia.BuscarTipoHabitacionId(id);
        }
    }
}
