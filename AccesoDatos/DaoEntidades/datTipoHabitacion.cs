using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.DataBase;
using entHabitacion;
using entTipoHabitacion;

namespace AccesoDatos.DaoEntidades
{
    public class datTipoHabitacion
    {
        #region sigleton
        private static readonly datTipoHabitacion _instancia = new datTipoHabitacion();
        public static datTipoHabitacion Instancia
        {
            get
            {
                return datTipoHabitacion._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public Boolean InsertarTipoHabitacion(entTipoHabitacion.TipoHabitacion t)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarTipoHabitacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombTipoHabitacion", t.nombTipoHabitacion);
                cmd.Parameters.AddWithValue("@precTipoHabitacion", t.precTipoHabitacion);
                cmd.Parameters.AddWithValue("@detalle", t.detalle);

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

        public List<entTipoHabitacion.TipoHabitacion> ListarTipoHabitacion()
        {
            SqlCommand cmd = null;
            List<entTipoHabitacion.TipoHabitacion> lista = new List<entTipoHabitacion.TipoHabitacion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("ListarTiposHabitacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoHabitacion.TipoHabitacion tip = new entTipoHabitacion.TipoHabitacion();
                    tip.idTipoHabitacion = Convert.ToInt32(dr["idTipoHabitacion"]);
                    tip.nombTipoHabitacion = dr["nombTipoHabitacion"].ToString();
                    tip.precTipoHabitacion = Convert.ToDouble(dr["precTipoHabitacion"]);
                    tip.detalle = dr["detalle"].ToString();
                    lista.Add(tip);
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
       
        public Boolean EditarTipoHabitacion(entTipoHabitacion.TipoHabitacion tip)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EditarTipoHabitacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idTipoHabitacion", tip.idTipoHabitacion);
                cmd.Parameters.AddWithValue("@nombTipoHabitacion", tip.nombTipoHabitacion);
                cmd.Parameters.AddWithValue("@precTipoHabitacion", tip.precTipoHabitacion);
                cmd.Parameters.AddWithValue("@detalle", tip.detalle);

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
        public TipoHabitacion BuscarTipoHabitacionId(int t)
        {
            SqlCommand cmd = null;
            TipoHabitacion tha = new TipoHabitacion();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("BuscarTipoHabitacionPorID", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idTipoHabitacion", t);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tha.idTipoHabitacion = Convert.ToInt32(dr["idTipoHabitacion"]);
                    tha.nombTipoHabitacion = dr["nombTipoHabitacion"].ToString();
                    tha.precTipoHabitacion = Convert.ToDouble(dr["precTipoHabitacion"]);
                    tha.detalle = dr["detalle"].ToString();

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
            return tha;
        }

        #endregion metodos
    }
}
