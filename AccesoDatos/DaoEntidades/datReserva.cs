using AccesoDatos.DataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entCliente;
using entReserva;

namespace AccesoDatos.DaoEntidades
{
    public class datReserva
    {
        #region sigleton
        private static readonly datReserva _instancia = new datReserva();
        public static datReserva Instancia
        {
            get
            {
                return datReserva._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entReserva.Reserva> ListarReserva()
        {
            SqlCommand cmd = null;
            List<entReserva.Reserva> lista = new List<entReserva.Reserva>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("ListarReservas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entReserva.Reserva r = new entReserva.Reserva();
                    entCliente.Cliente c = new entCliente.Cliente();
                    entHabitacion.Habitacion h = new entHabitacion.Habitacion();

                    r.id_Reserva = Convert.ToInt32(dr["idRserva"]);
                    r.Fecing_Reserva = Convert.ToDateTime(dr["fecIngReseva"]);
                    r.Fecsal_Reserva = Convert.ToDateTime(dr["fecSalReserva"]);
                    r.Est_Reserva = Convert.ToBoolean(dr["estRserva"]);
                    c.idCliente = Convert.ToInt32(dr["id_Cliente"]);
                    c.nombCliente = Convert.ToString(dr["nombCliente"]);
                    c.apelCliente = Convert.ToString(dr["apelCliente"]);

                    r.id_Cliente = c;
                    h.idHabitacion = Convert.ToInt32(dr["idHabitacion"]);
                    h.numHabitacion = Convert.ToInt16(dr["numHabitacion"]);
                    r.id_Habitacion = h;

                    lista.Add(r);
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
        public int InsertarReserva(entReserva.Reserva r)
        {
            SqlCommand cmd = null;
            int nuevoID = -1;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarReserva", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@fecIngReseva", r.Fecing_Reserva);
                cmd.Parameters.AddWithValue("@fecSalReserva", r.Fecsal_Reserva);
                cmd.Parameters.AddWithValue("@estRserva", r.Est_Reserva);
                cmd.Parameters.AddWithValue("@id_Cliente", r.id_Cliente.idCliente);
                cmd.Parameters.AddWithValue("@idHabitacion", r.id_Habitacion.idHabitacion);

                SqlParameter outputParameter = new SqlParameter("@NuevoID", SqlDbType.Int);
                outputParameter.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outputParameter);

                cn.Open();

                int i = cmd.ExecuteNonQuery();

                // Verificar si se insertó correctamente y si se obtuvo un nuevo ID
                if (i > 0 && outputParameter.Value != DBNull.Value)
                {
                    nuevoID = Convert.ToInt32(outputParameter.Value);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return nuevoID;
        }


        public Boolean EditarReserva(entReserva.Reserva r)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EditarReserva", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idRserva", r.id_Reserva);
                cmd.Parameters.AddWithValue("@fecIngReseva", r.Fecing_Reserva);
                cmd.Parameters.AddWithValue("@fecSalReserva", r.Fecsal_Reserva);
                cmd.Parameters.AddWithValue("@estRserva", r.Est_Reserva);
                //cmd.Parameters.AddWithValue("@id_Cliente", r.id_Cliente.idCliente);
                //cmd.Parameters.AddWithValue("@idHabitacion", r.id_Cliente.idCliente);

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

        public Reserva BuscarReservaPorId(int id)
        {
            SqlCommand cmd = null;
            Reserva r = new Reserva(); 
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("BuscarReservaPorId", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", id);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    r.id_Reserva = Convert.ToInt32(dr["idRserva"]);
                    r.Fecing_Reserva = Convert.ToDateTime(dr["fecIngReseva"]);
                    r.Fecsal_Reserva = Convert.ToDateTime(dr["fecSalReserva"]);
                    r.Est_Reserva = Convert.ToBoolean(dr["estRserva"]);
                    r.id_Cliente = new Cliente();
                    r.id_Cliente.idCliente = Convert.ToInt16(dr["id_Cliente"]);
                    r.id_Habitacion = new entHabitacion.Habitacion();
                    r.id_Habitacion.idHabitacion = Convert.ToInt16(dr["idHabitacion"]);

                    
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
            return r;
        }

        public int validarReserva(int id, DateTime inicio, DateTime fin)
        {
            SqlCommand cmd = null;
            int resultado = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ValidarReservaSinFechas", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idHabitacion", id);
                cmd.Parameters.AddWithValue("@fecIngReserva", inicio);
                cmd.Parameters.AddWithValue("@fecSalReserva", fin);
                cmd.Parameters.Add("@resultado", SqlDbType.Int).Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();

                // Capturar el valor de retorno del procedimiento almacenado
                resultado = (int)cmd.Parameters["@resultado"].Value;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return resultado;
        }



        #endregion metodos
    }
}
