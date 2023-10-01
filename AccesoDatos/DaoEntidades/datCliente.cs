using AccesoDatos.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entCliente;
using entHabitacion;
using entTipoHabitacion;
using System.Xml.Linq;

namespace AccesoDatos.DaoEntidades
{

    public class datCliente
    {
        #region sigleton
        private static readonly datCliente _instancia = new datCliente();
        public static datCliente Instancia
        {
            get
            {
                return datCliente._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entCliente.Cliente> ListarCliente()
        {
            SqlCommand cmd = null;
            List<entCliente.Cliente> lista = new List<entCliente.Cliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente.Cliente Cli = new entCliente.Cliente();
                    Cli.idCliente = Convert.ToInt32(dr["idCliente"]);
                    Cli.nombCliente = dr["nombCliente"].ToString();
                    Cli.apelCliente = dr["apelCliente"].ToString();
                    Cli.direcCliente = dr["direcCliente"].ToString();
                    Cli.celular = dr["celular"].ToString();
                    Cli.dni = dr["dni"].ToString();
                    Cli.estCliente = Convert.ToBoolean(dr["estCliente"]);
                    Cli.fecRegCliente = Convert.ToDateTime(dr["fecRegCliente"]);

                    lista.Add(Cli);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        public List<entCliente.Cliente> listarClienteNombre(string name)
        {
            SqlCommand cmd = null;
            List<entCliente.Cliente> lista = new List<entCliente.Cliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("splistaClienteNombre", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", name);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente.Cliente Cli = new entCliente.Cliente();
                    Cli.idCliente = Convert.ToInt32(dr["idCliente"]);
                    Cli.nombCliente = dr["nombCliente"].ToString();
                    Cli.apelCliente = dr["apelCliente"].ToString();
                    Cli.direcCliente = dr["direcCliente"].ToString();
                    Cli.celular = dr["celular"].ToString();
                    Cli.dni = dr["dni"].ToString();
                    Cli.estCliente = Convert.ToBoolean(dr["estCliente"]);
                    Cli.fecRegCliente = Convert.ToDateTime(dr["fecRegCliente"]);

                    lista.Add(Cli);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        public List<entCliente.Cliente> listarClienteDni(int dni)
        {
            SqlCommand cmd = null;
            List<entCliente.Cliente> lista = new List<entCliente.Cliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("splistaClienteDni", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", dni);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente.Cliente Cli = new entCliente.Cliente();
                    Cli.idCliente = Convert.ToInt32(dr["idCliente"]);
                    Cli.nombCliente = dr["nombCliente"].ToString();
                    Cli.apelCliente = dr["apelCliente"].ToString();
                    Cli.direcCliente = dr["direcCliente"].ToString();
                    Cli.celular = dr["celular"].ToString();
                    Cli.dni = dr["dni"].ToString();
                    Cli.estCliente = Convert.ToBoolean(dr["estCliente"]);
                    Cli.fecRegCliente = Convert.ToDateTime(dr["fecRegCliente"]);

                    lista.Add(Cli);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        public List<entCliente.Cliente> listarClienteId(int id)
        {
            SqlCommand cmd = null;
            List<entCliente.Cliente> lista = new List<entCliente.Cliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("splistaClienteId", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente.Cliente Cli = new entCliente.Cliente();
                    Cli.idCliente = Convert.ToInt32(dr["idCliente"]);
                    Cli.nombCliente = dr["nombCliente"].ToString();
                    Cli.apelCliente = dr["apelCliente"].ToString();
                    Cli.direcCliente = dr["direcCliente"].ToString();
                    Cli.celular = dr["celular"].ToString();
                    Cli.dni = dr["dni"].ToString();
                    Cli.estCliente = Convert.ToBoolean(dr["estCliente"]);
                    Cli.fecRegCliente = Convert.ToDateTime(dr["fecRegCliente"]);

                    lista.Add(Cli);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        /////////////////////////InsertaCliente
        public Boolean InsertarCliente(entCliente.Cliente Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombCliente", Cli.nombCliente);
                cmd.Parameters.AddWithValue("@apelCliente", Cli.apelCliente);
                cmd.Parameters.AddWithValue("@direcCliente", Cli.direcCliente);
                cmd.Parameters.AddWithValue("@celular", Cli.celular);
                cmd.Parameters.AddWithValue("@dni", Cli.dni);
                cmd.Parameters.AddWithValue("@estCliente", Cli.estCliente);
                cmd.Parameters.AddWithValue("@fecRegCliente", Cli.fecRegCliente);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }


        public Boolean EditarCliente(entCliente.Cliente Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", Cli.idCliente);
                cmd.Parameters.AddWithValue("@nombCliente", Cli.nombCliente);
                cmd.Parameters.AddWithValue("@apelCliente", Cli.apelCliente);
                cmd.Parameters.AddWithValue("@direcCliente", Cli.direcCliente);
                cmd.Parameters.AddWithValue("@celular", Cli.celular);
                cmd.Parameters.AddWithValue("@dni", Cli.dni);
                cmd.Parameters.AddWithValue("@estCliente", Cli.estCliente);
                cmd.Parameters.AddWithValue("@fecRegCliente", Cli.fecRegCliente);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        //deshabilitaCliente

        public Boolean DeshabilitarCliente(entCliente.Cliente Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("DeshabilitarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", Cli.idCliente);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }


        public Cliente BuscarClientePorDni(int dni)
        {
            SqlCommand cmd = null;
            Cliente Cli = new Cliente(); ;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("BuscarClientePorDni", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", dni);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Cli.idCliente = Convert.ToInt32(dr["idCliente"]);
                    Cli.nombCliente = dr["nombCliente"].ToString();
                    Cli.apelCliente = dr["apelCliente"].ToString();
                    Cli.direcCliente = dr["direcCliente"].ToString();
                    Cli.celular = dr["celular"].ToString();
                    Cli.dni = dr["dni"].ToString();
                    Cli.estCliente = Convert.ToBoolean(dr["estCliente"]);
                    Cli.fecRegCliente = Convert.ToDateTime(dr["fecRegCliente"]);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return Cli;
        }
        public Cliente BuscarClientePorId(int id)
        {
            SqlCommand cmd = null;
            Cliente Cli = new Cliente(); ;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("BuscarClientePorId", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", id);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Cli.idCliente = Convert.ToInt32(dr["idCliente"]);
                    Cli.nombCliente = dr["nombCliente"].ToString();
                    Cli.apelCliente = dr["apelCliente"].ToString();
                    Cli.direcCliente = dr["direcCliente"].ToString();
                    Cli.celular = dr["celular"].ToString();
                    Cli.dni = dr["dni"].ToString();
                    Cli.estCliente = Convert.ToBoolean(dr["estCliente"]);
                    Cli.fecRegCliente = Convert.ToDateTime(dr["fecRegCliente"]);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return Cli;
        }
        #endregion metodos
    }
}

