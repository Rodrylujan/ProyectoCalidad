using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entCliente;
using AccesoDatos.DaoEntidades;

namespace LogicaNegocio.Mantenedor
{
    public class logCliente
    {
        private static readonly logCliente _instancia = new logCliente();
        
        public static logCliente Instancia
        {
            get
            {
                return logCliente._instancia;
            }
        }
        public List<entCliente.Cliente> ListarCliente()
        {
            return datCliente.Instancia.ListarCliente();
        }
        public List<entCliente.Cliente> listarClienteNombre(string name)
        {
            return datCliente.Instancia.listarClienteNombre(name);
        }
        public List<entCliente.Cliente> listarClienteDni(int dni)
        {
            return datCliente.Instancia.listarClienteDni(dni);
        }
        public List<entCliente.Cliente> listarClienteId(int id)
        {
            return datCliente.Instancia.listarClienteId(id);
        }
        public void InsertarCliente(entCliente.Cliente Cli)
        {
            datCliente.Instancia.InsertarCliente(Cli);
        }
        public void EditaCliente(entCliente.Cliente Cli)
        {
            datCliente.Instancia.EditarCliente(Cli);
        }
        public void DeshabilitarCliente(entCliente.Cliente Cli)
        {
            datCliente.Instancia.DeshabilitarCliente(Cli);
        }
        public Cliente BuscarClientePorDni(int dni)
        {
            return datCliente.Instancia.BuscarClientePorDni(dni);
        }
        public Cliente BuscarClientePorId(int id)
        {
            return datCliente.Instancia.BuscarClientePorId(id);
        }
    }
}
