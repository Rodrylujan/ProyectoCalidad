using AccesoDatos.DaoEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.MantenedorPago
{
    public class logTarjeta
    {
        private static readonly logTarjeta _instancia = new logTarjeta();

        public static logTarjeta Instancia
        {
            get
            {
                return logTarjeta._instancia;
            }
        }
        public List<entTarjeta.Tarjeta> ListarTarjeta()
        {
            return datTarjeta.Instancia.ListarTarjeta();
        }
        public void InsertarTarjeta(entTarjeta.Tarjeta t)
        {
            datTarjeta.Instancia.InsertarTarjeta(t);
        }
        public void EditaTarjeta(entTarjeta.Tarjeta t)
        {
            datTarjeta.Instancia.EditarTarjeta(t);
        }
        public void DeshabilitarTarjeta(entTarjeta.Tarjeta t)
        {
            datTarjeta.Instancia.DeshabilitarTarjeta(t);
        }
    }
}
