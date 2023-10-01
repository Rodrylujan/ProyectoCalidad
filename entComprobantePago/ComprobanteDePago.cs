using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entComprobantePago
{
    public class ComprobanteDePago
    {
        public int id_Comprobante { get; set; }
        public DateTime Fecreg_comprobante { get; set; }
        public float Monpag_comprobante { get; set; }
        public string Detalle { get; set; }
        public string Forpago_comprobante { get; set; }
        public bool Est_comprobante { get; set; }
        public entHospedaje.Hospedaje id_Hospedaje { get; set; }
        public entReserva.Reserva id_Reserva { get; set; }
        public entTarjeta.Tarjeta id_Tarjeta { get; set; }
    }
}
