using AccesoDatos.DaoEntidades;
using LogicaNegocio.MantenedorReserva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.MantenedorServicio
{
    public class logDetalleServicio
    {
        private static readonly logDetalleServicio _instancia = new logDetalleServicio();

        public static logDetalleServicio Instancia
        {
            get
            {
                return logDetalleServicio._instancia;
            }
        }

        public List<entDeatlleServicio.DetalleServicioAdicional> ListarDetalleServicio()
        {
            return datDetalleServicio.Instancia.ListarDetalleServicioAdicionalPorIdReserva();
        }
        public void InsertarDetalleServicio(entDeatlleServicio.DetalleServicioAdicional d)
        {
            datDetalleServicio.Instancia.InsertarDetalleServicio(d);
        }
        public int contCantidadReservasporComprobante(int d)
        {
            return datDetalleServicio.Instancia.contCantidadReservasporComprobante(d);
        }
    }
}
