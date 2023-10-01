using AccesoDatos.DataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using entHabitacion;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entTipoHabitacion;

namespace AccesoDatos.DaoEntidades
{
    public class datHabitacion
    {
        #region singleton
        private static readonly datHabitacion UnicaInstancia = new datHabitacion();
        public static datHabitacion Instancia
        {
            get
            {
                return datHabitacion.UnicaInstancia;
            }
        }
        #endregion singleton


        #region metodos

        //LISTAR HABITACIONES
        public List<Habitacion> ListarHabitacion()
        {
            SqlCommand cmd = null;
            List<Habitacion> lista = new List<Habitacion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("ListarHabitacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Habitacion ha = new Habitacion();
                    TipoHabitacion th = new TipoHabitacion();

                    ha.idHabitacion = Convert.ToInt32(dr["idHabitacion"]);
                    ha.numHabitacion = Convert.ToInt32(dr["numHabitacion"]);
                    ha.numPisoHabitacion = Convert.ToInt32(dr["numPisoHabitacion"]);
                    ha.DisHabitacion = dr["dispoHabitacion"].ToString();

                    th.idTipoHabitacion = Convert.ToInt32(dr["idTipoHabitacion"]);
                    th.nombTipoHabitacion = dr["nombTipoHabitacion"].ToString();
                    th.precTipoHabitacion = Convert.ToInt32(dr["precTipoHabitacion"]);
                    th.detalle = dr["detalle"].ToString();

                    ha.idTipoHabitacion = th;
                    lista.Add(ha);
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
        //INSERTAR HABITACION
        public Boolean InsertarHabitacion(Habitacion ha)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarHabitacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@numHabitacion", ha.numHabitacion);
                cmd.Parameters.AddWithValue("@numPisoHabitacion", ha.numPisoHabitacion);
                cmd.Parameters.AddWithValue("@dispoHabitacion", ha.DisHabitacion);
                cmd.Parameters.AddWithValue("@idTipoHabitacion", ha.idTipoHabitacion.idTipoHabitacion);

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
        //EDITAR HABITACION
        public Boolean EditarHabitacion(Habitacion ha)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EditarHabitacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idHabitacion", ha.idHabitacion);
                cmd.Parameters.AddWithValue("@numHabitacion", ha.numHabitacion);
                cmd.Parameters.AddWithValue("@numPisoHabitacion", ha.numPisoHabitacion);
                cmd.Parameters.AddWithValue("@dispoHabitacion", ha.DisHabitacion);
                cmd.Parameters.AddWithValue("@idTipoHabitacion", ha.idTipoHabitacion.idTipoHabitacion);
                
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

        public Habitacion BuscarHabitacion(int idHabitacion)
        {
            SqlCommand cmd = null;
            Habitacion ha = new Habitacion();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("BuscarHabitacionPorID", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idHabitacion", idHabitacion);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TipoHabitacion th = new TipoHabitacion();

                    ha.idHabitacion = Convert.ToInt32(dr["idHabitacion"]);
                    ha.numHabitacion = Convert.ToInt32(dr["numHabitacion"]);
                    ha.numPisoHabitacion = Convert.ToInt32(dr["numPisoHabitacion"]);
                    ha.DisHabitacion = dr["dispoHabitacion"].ToString();

                    th.idTipoHabitacion = Convert.ToInt32(dr["idTipoHabitacion"]);
                    th.nombTipoHabitacion = dr["nombTipoHabitacion"].ToString();
                    
                    ha.idTipoHabitacion = th;
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
            return ha;
        }

        public List<Habitacion> ListarHabitacionPorCodigo(int v)
        {
            SqlCommand cmd = null;
            List<Habitacion> lista = new List<Habitacion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("splistaHabitacionPorId", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", v);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Habitacion ha = new Habitacion();
                    TipoHabitacion th = new TipoHabitacion();

                    ha.idHabitacion = Convert.ToInt32(dr["idHabitacion"]);
                    ha.numHabitacion = Convert.ToInt32(dr["numHabitacion"]);
                    ha.numPisoHabitacion = Convert.ToInt32(dr["numPisoHabitacion"]);
                    ha.DisHabitacion = dr["dispoHabitacion"].ToString();

                    th.idTipoHabitacion = Convert.ToInt32(dr["idTipoHabitacion"]);
                    th.nombTipoHabitacion = dr["nombTipoHabitacion"].ToString();
                    th.precTipoHabitacion = Convert.ToInt32(dr["precTipoHabitacion"]);
                    th.detalle = dr["detalle"].ToString();

                    ha.idTipoHabitacion = th;
                    lista.Add(ha);
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

        public List<Habitacion> ListarHabitacionPorNumero(int v)
        {
            SqlCommand cmd = null;
            List<Habitacion> lista = new List<Habitacion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("splistaHabitacionPorNumero", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numero", v);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Habitacion ha = new Habitacion();
                    TipoHabitacion th = new TipoHabitacion();

                    ha.idHabitacion = Convert.ToInt32(dr["idHabitacion"]);
                    ha.numHabitacion = Convert.ToInt32(dr["numHabitacion"]);
                    ha.numPisoHabitacion = Convert.ToInt32(dr["numPisoHabitacion"]);
                    ha.DisHabitacion = dr["dispoHabitacion"].ToString();

                    th.idTipoHabitacion = Convert.ToInt32(dr["idTipoHabitacion"]);
                    th.nombTipoHabitacion = dr["nombTipoHabitacion"].ToString();
                    th.precTipoHabitacion = Convert.ToInt32(dr["precTipoHabitacion"]);
                    th.detalle = dr["detalle"].ToString();

                    ha.idTipoHabitacion = th;
                    lista.Add(ha);
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

        public List<Habitacion> ListarHabitacionPorPiso(int v)
        {
            SqlCommand cmd = null;
            List<Habitacion> lista = new List<Habitacion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("splistaHabitacionPorPiso", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@piso", v);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Habitacion ha = new Habitacion();
                    TipoHabitacion th = new TipoHabitacion();

                    ha.idHabitacion = Convert.ToInt32(dr["idHabitacion"]);
                    ha.numHabitacion = Convert.ToInt32(dr["numHabitacion"]);
                    ha.numPisoHabitacion = Convert.ToInt32(dr["numPisoHabitacion"]);
                    ha.DisHabitacion = dr["dispoHabitacion"].ToString();

                    th.idTipoHabitacion = Convert.ToInt32(dr["idTipoHabitacion"]);
                    th.nombTipoHabitacion = dr["nombTipoHabitacion"].ToString();
                    th.precTipoHabitacion = Convert.ToInt32(dr["precTipoHabitacion"]);
                    th.detalle = dr["detalle"].ToString();

                    ha.idTipoHabitacion = th;
                    lista.Add(ha);
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


        #endregion metodos
    }
}
