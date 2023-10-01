using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entDeatlleServicio
{
    public class DetalleServicioAdicional
    {
        public int id_DetalleSerAdicional { get; set; }
        public entServicio.Servicio id_SerAdicional { get; set; }
        public entComprobantePago.ComprobanteDePago id_comprobante { get; set; }
    }
}
