using AccesoDatos.DaoEntidades;
using entReserva;
using LogicaNegocio.MantenedorPago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.MantenedorReserva
{
    public class logReserva
    {
        private static readonly logReserva _instancia = new logReserva();

        public static logReserva Instancia
        {
            get
            {
                return logReserva._instancia;
            }
        }
        public List<entReserva.Reserva> ListarReserva()
        {
            return datReserva.Instancia.ListarReserva();
        }
        public int InsertarReserva(entReserva.Reserva r)
        {
            return datReserva.Instancia.InsertarReserva(r);
        }
        public bool EditaReserva(entReserva.Reserva r)
        {
            return datReserva.Instancia.EditarReserva(r);
        }
        public Reserva buscarReservaPorId(int id)
        {
            return datReserva.Instancia.BuscarReservaPorId(id);
        }
        public int validarReserva(int id, DateTime inicio, DateTime fin)
        {
            return datReserva.Instancia.validarReserva(id, inicio, fin);
        }
    }
}
