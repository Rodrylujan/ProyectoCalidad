using entTipoHabitacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entHabitacion
{
    public class Habitacion
    {
        public int idHabitacion { get; set; }
        public int numHabitacion { get; set; }
        public int numPisoHabitacion { get; set; }
        public string DisHabitacion { get; set; }
        public entTipoHabitacion.TipoHabitacion idTipoHabitacion { get; set; }
    }
}
