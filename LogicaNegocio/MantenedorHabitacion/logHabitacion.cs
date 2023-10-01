using System;
using System.Collections.Generic;
using entHabitacion;
using AccesoDatos.DaoEntidades;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.MantenedorHabitacion
{
    public class logHabitacion
    {
        #region singleton
        private static readonly logHabitacion UnicaInstancia = new logHabitacion();
        public static logHabitacion Instancia
        {
            get
            {
                return logHabitacion.UnicaInstancia;
            }
        }
        #endregion singleton

        #region metodos

        public List<Habitacion> ListarHabitacion()
        {
            try
            {
                List<Habitacion> lista = datHabitacion.Instancia.ListarHabitacion();
                return lista;
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public Boolean InsertarHabitacion(Habitacion ha)
        {
            try
            {
                return datHabitacion.Instancia.InsertarHabitacion(ha);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public Boolean EditaHabitacion(Habitacion ha)
        {
            try
            {
                return datHabitacion.Instancia.EditarHabitacion(ha);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Habitacion BuscarHabitacion(int idHabitacion)
        {
            try
            {
                return datHabitacion.Instancia.BuscarHabitacion(idHabitacion);
            }
            catch (Exception e)
            { throw e; }

        }

        public List<Habitacion> ListarHabitacionPorCodigo(int v)
        {
            return datHabitacion.Instancia.ListarHabitacionPorCodigo(v);
        }

        public List<Habitacion> ListarHabitacionPorNumero(int v)
        {
            return datHabitacion.Instancia.ListarHabitacionPorNumero(v);
        }

        public List<Habitacion> ListarHabitacionPorPiso(int v)
        {
            return datHabitacion.Instancia.ListarHabitacionPorPiso(v);
        }
        #endregion metodos
    }
}
