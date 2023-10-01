using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entReserva
{
    public class Reserva
    {
        public int id_Reserva { get; set; }

        public bool Est_Reserva { get; set; }

        public DateTime Fecing_Reserva { get; set; }

        public DateTime Fecsal_Reserva { get; set; }

        public entCliente.Cliente id_Cliente { get; set; }

        public entHabitacion.Habitacion id_Habitacion { get; set; }
    }
}
