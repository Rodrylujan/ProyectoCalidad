using AccesoDatos.DataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.DaoEntidades
{
    public class datTarjeta
    {
        #region sigleton
        private static readonly datTarjeta _instancia = new datTarjeta();
        public static datTarjeta Instancia
        {
            get
            {
                return datTarjeta._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entTarjeta.Tarjeta> ListarTarjeta()
        {
            SqlCommand cmd = null;
            List<entTarjeta.Tarjeta> lista = new List<entTarjeta.Tarjeta>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTarjeta.Tarjeta t = new entTarjeta.Tarjeta();
                    //Cli.idCliente = Convert.ToInt32(dr["idCliente"]);
                    //Cli.nombCliente = dr["nombCliente"].ToString();
                    //Cli.apelCliente = dr["apelCliente"].ToString();
                    //Cli.direcCliente = dr["direcCliente"].ToString();
                    //Cli.celular = dr["celular"].ToString();
                    //Cli.dni = dr["dni"].ToString();
                    //Cli.estCliente = Convert.ToBoolean(dr["estCliente"]);
                    //Cli.fecRegCliente = Convert.ToDateTime(dr["fecRegCliente"]);

                    lista.Add(t);
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

        public Boolean InsertarTarjeta(entTarjeta.Tarjeta t)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@nombCliente", Cli.nombCliente);
                //cmd.Parameters.AddWithValue("@apelCliente", Cli.apelCliente);
                //cmd.Parameters.AddWithValue("@direcCliente", Cli.direcCliente);
                //cmd.Parameters.AddWithValue("@celular", Cli.celular);
                //cmd.Parameters.AddWithValue("@dni", Cli.dni);
                //cmd.Parameters.AddWithValue("@estCliente", Cli.estCliente);
                //cmd.Parameters.AddWithValue("@fecRegCliente", Cli.fecRegCliente);
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


        public Boolean EditarTarjeta(entTarjeta.Tarjeta t)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idCliente", Cli.idCliente);
                //cmd.Parameters.AddWithValue("@nombCliente", Cli.nombCliente);
                //cmd.Parameters.AddWithValue("@apelCliente", Cli.apelCliente);
                //cmd.Parameters.AddWithValue("@direcCliente", Cli.direcCliente);
                //cmd.Parameters.AddWithValue("@celular", Cli.celular);
                //cmd.Parameters.AddWithValue("@dni", Cli.dni);
                //cmd.Parameters.AddWithValue("@estCliente", Cli.estCliente);
                //cmd.Parameters.AddWithValue("@fecRegCliente", Cli.fecRegCliente);
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

        public Boolean DeshabilitarTarjeta(entTarjeta.Tarjeta t)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@idCliente", Cli.idCliente);
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

        #endregion metodos
    }
}
