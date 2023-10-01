using AccesoDatos.DataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AccesoDatos.DaoEntidades
{
    public class datDetalleServicio
    {
        #region sigleton
        private static readonly datDetalleServicio _instancia = new datDetalleServicio();
        public static datDetalleServicio Instancia
        {
            get
            {
                return datDetalleServicio._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entDeatlleServicio.DetalleServicioAdicional> ListarDetalleServicioAdicionalPorIdReserva()
        {
            SqlCommand cmd = null;
            List<entDeatlleServicio.DetalleServicioAdicional> lista = new List<entDeatlleServicio.DetalleServicioAdicional>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entDeatlleServicio.DetalleServicioAdicional d = new entDeatlleServicio.DetalleServicioAdicional();
                    
                    //Cli.idCliente = Convert.ToInt32(dr["idCliente"]);
                    //Cli.nombCliente = dr["nombCliente"].ToString();
                    //Cli.apelCliente = dr["apelCliente"].ToString();
                    //Cli.direcCliente = dr["direcCliente"].ToString();
                    //Cli.celular = dr["celular"].ToString();
                    //Cli.dni = dr["dni"].ToString();
                    //Cli.estCliente = Convert.ToBoolean(dr["estCliente"]);
                    //Cli.fecRegCliente = Convert.ToDateTime(dr["fecRegCliente"]);

                    lista.Add(d);
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

        public int contCantidadReservasporComprobante(int id)
        {
            SqlCommand cmd = null;
            int cantidad = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); // Singleton
                cmd = new SqlCommand("ContarDetallesServicioAdicionalPorIdComprobanteYIdReserva", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Configura el parámetro de entrada
                cmd.Parameters.AddWithValue("@id_Comprobante", id);

                cn.Open();
                // Ejecuta el procedimiento almacenado y obtiene el resultado
                cantidad = (int)cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return cantidad;

        }

        public Boolean InsertarDetalleServicio(entDeatlleServicio.DetalleServicioAdicional d)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarDetalleServicioAdicional", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_SerAdicional", d.id_SerAdicional.idServicio);
                cmd.Parameters.AddWithValue("@id_Comprobante", d.id_comprobante.id_Comprobante);


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

        #endregion metodos
    }
}
