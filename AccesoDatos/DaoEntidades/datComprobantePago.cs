using AccesoDatos.DataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entCliente;
using entComprobantePago;
using System.Collections;

namespace AccesoDatos.DaoEntidades
{
    public class datComprobantePago
    {
        #region sigleton
        private static readonly datComprobantePago _instancia = new datComprobantePago();
        public static datComprobantePago Instancia
        {
            get
            {
                return datComprobantePago._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entComprobantePago.ComprobanteDePago> ListarComprobanteDePago()
        {
            SqlCommand cmd = null;
            List<entComprobantePago.ComprobanteDePago> lista = new List<entComprobantePago.ComprobanteDePago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("ListarComprobantesDePago", cn);           //agregar sp
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entComprobantePago.ComprobanteDePago c = new entComprobantePago.ComprobanteDePago();

                    c.id_Comprobante = Convert.ToInt32(dr["id_Comprobante"]);
                    c.Fecreg_comprobante = Convert.ToDateTime(dr["Fecreg_comprobante"]);
                    c.Monpag_comprobante = (float)Convert.ToDecimal(dr["Monpag_comprobante"]);
                    c.Detalle = dr["Detalle"].ToString();
                    c.Forpago_comprobante = dr["Forpago_comprobante"].ToString();
                    c.Est_comprobante = Convert.ToBoolean(dr["Est_comprobante"]);
                    c.id_Reserva = new entReserva.Reserva();
                    c.id_Reserva.id_Reserva = Convert.ToInt32(dr["id_Reserva"]);


                    lista.Add(c);
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

        public int InsertarComprobanteDePago(entComprobantePago.ComprobanteDePago c)
        {
            SqlCommand cmd = null;
            int nuevoID = 0; // Variable para almacenar el nuevo ID generado
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarComprobanteDePago", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Fecreg_comprobante", c.Fecreg_comprobante);
                cmd.Parameters.AddWithValue("@Monpag_comprobante", c.Monpag_comprobante);
                cmd.Parameters.AddWithValue("@Detalle", c.Detalle);
                cmd.Parameters.AddWithValue("@Forpago_comprobante", c.Forpago_comprobante);
                cmd.Parameters.AddWithValue("@Est_comprobante", c.Est_comprobante);
                //cmd.Parameters.AddWithValue("@id_Hospedaje", null);
                cmd.Parameters.AddWithValue("@id_Reserva", c.id_Reserva.id_Reserva);
                //cmd.Parameters.AddWithValue("@id_Tarjeta", c.id_Tarjeta.idTarjeta);

                // Configura el parámetro de salida para recibir el nuevo ID
                SqlParameter nuevoIDParam = new SqlParameter("@nuevoID", SqlDbType.Int);
                nuevoIDParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(nuevoIDParam);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    nuevoID = (int)nuevoIDParam.Value; // Obtiene el nuevo ID generado automáticamente
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return nuevoID;
        }



        public Boolean EditarComprobanteDePago(entComprobantePago.ComprobanteDePago c)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EditarComprobanteDePago", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_Comprobante", c.id_Comprobante);
                cmd.Parameters.AddWithValue("@Fecreg_comprobante", c.Fecreg_comprobante);
                cmd.Parameters.AddWithValue("@Monpag_comprobante", c.Monpag_comprobante);
                cmd.Parameters.AddWithValue("@Detalle", c.Detalle);
                cmd.Parameters.AddWithValue("@Forpago_comprobante", c.Forpago_comprobante);
                cmd.Parameters.AddWithValue("@Est_comprobante", c.Est_comprobante);
                //cmd.Parameters.AddWithValue("@id_Hospedaje", c.id_Hospedaje);
                //cmd.Parameters.AddWithValue("@id_Reserva", c.id_Reserva);
                //cmd.Parameters.AddWithValue("@id_Tarjeta", c.id_Tarjeta);

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

        
        public ComprobanteDePago BuscarComprobantePorReserva(int id_reserva)
        {
            SqlCommand cmd = null;
            entComprobantePago.ComprobanteDePago c = new entComprobantePago.ComprobanteDePago();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("BuscarComprobanteDePagoPorIdReserva", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_Reserva", id_reserva);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    
                    c.id_Comprobante = Convert.ToInt32(dr["id_Comprobante"]);
                    c.Fecreg_comprobante = Convert.ToDateTime(dr["Fecreg_comprobante"]);
                    c.Monpag_comprobante = (float)Convert.ToDecimal( dr["Monpag_comprobante"]);
                    c.Detalle = dr["Detalle"].ToString();
                    c.Forpago_comprobante = dr["Forpago_comprobante"].ToString();
                    c.Est_comprobante = Convert.ToBoolean(dr["Est_comprobante"]);
                    //c.id_Hospedaje = new entHospedaje.Hospedaje();
                    //c.id_Hospedaje.id_Hospedaje = Convert.ToInt32(dr["id_Hospedaje"]);
                    c.id_Reserva = new entReserva.Reserva();
                    c.id_Reserva.id_Reserva = Convert.ToInt32(dr["id_Reserva"]);
                    //c.id_Tarjeta = new entTarjeta.Tarjeta();
                    //c.id_Tarjeta.idTarjeta = Convert.ToInt32(dr["id_Tarjeta"]);

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
            return c;
        }

        #endregion metodos
    }
}
