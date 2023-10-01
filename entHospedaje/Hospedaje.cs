using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entHospedaje
{
    public class Hospedaje
    {
        public int id_Hospedaje { get; set; }

        public bool Est_hospedaje { get; set; }

        public DateTime Fecing_hospedaje { get; set; }

        public DateTime Fecsal_hospedaje { get; set; }

        public entCliente.Cliente id_Cliente { get; set; }

        public entHabitacion.Habitacion id_Habitacion { get; set; }
    }
}
