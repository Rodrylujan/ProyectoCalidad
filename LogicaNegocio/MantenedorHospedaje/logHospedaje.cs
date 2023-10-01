using AccesoDatos.DaoEntidades;
using LogicaNegocio.MantenedorComprobante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.MantenedorHospedaje
{
    public class logHospedaje
    {
        private static readonly logHospedaje _instancia = new logHospedaje();

        public static logHospedaje Instancia
        {
            get
            {
                return logHospedaje._instancia;
            }
        }

        public List<entHospedaje.Hospedaje> ListarHospedaje()
        {
            return datHospedaje.Instancia.ListarHospedaje();
        }
        public void InsertarHospedaje(entHospedaje.Hospedaje h)
        {
            datHospedaje.Instancia.InsertarHospedaje(h);
        }
        public void EditaHospedaje(entHospedaje.Hospedaje h)
        {
            datHospedaje.Instancia.EditarHospedaje(h);
        }
    }
}
