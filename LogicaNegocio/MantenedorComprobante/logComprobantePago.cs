using AccesoDatos.DaoEntidades;
using entComprobantePago;
using LogicaNegocio.Mantenedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.MantenedorComprobante
{
    public class logComprobantePago
    {
        private static readonly logComprobantePago _instancia = new logComprobantePago();

        public static logComprobantePago Instancia
        {
            get
            {
                return logComprobantePago._instancia;
            }
        }
        public List<entComprobantePago.ComprobanteDePago> ListarComprobantePago()
        {
            return datComprobantePago.Instancia.ListarComprobanteDePago();
        }
        public int InsertarComprobantePago(entComprobantePago.ComprobanteDePago c)
        {
            return datComprobantePago.Instancia.InsertarComprobanteDePago(c);
        }
        public void EditaComprobantePago(entComprobantePago.ComprobanteDePago c)
        {
            datComprobantePago.Instancia.EditarComprobanteDePago(c);

        }
        public ComprobanteDePago BuscarComprobantePorReserva(int id_reserva)
        {
            return datComprobantePago.Instancia.BuscarComprobantePorReserva(id_reserva);

        }
    }
}
