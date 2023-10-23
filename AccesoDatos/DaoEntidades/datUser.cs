using AccesoDatos.DataBase;
using AccesoDatos.DaoEntidades;
using entUser;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.DaoEntidades
{
    public class datUser
    {
        #region Singleton
        private static readonly datUser _instancia = new datUser();
        public static datUser Instancia
        {
            get
            {
                return datUser._instancia;
            }
        }
        #endregion

        #region Métodos
        public int ValidarSesion(string user, string password)
        {
            SqlCommand cmd = null;
            int estado = 0;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();

                cmd = new SqlCommand("ValidarInicioSesion", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre_usuario", user);
                cmd.Parameters.AddWithValue("@contraseña", password);

                SqlParameter outputParameter = new SqlParameter("@InicioSesionValido", SqlDbType.Int);
                outputParameter.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outputParameter);

                cn.Open();

                cmd.ExecuteNonQuery();

                if (outputParameter.Value != DBNull.Value)
                {
                    estado = Convert.ToInt32(outputParameter.Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Connection.Close();
                }
            }

            return estado;
        }

        public List<User> listarUsuarios()
        {
            SqlCommand cmd = null;
            List<User> lista = new List<User>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton

                cmd = new SqlCommand("ps_listarUsuarios", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    User usuario = new User();

                    usuario.id_usuario = Convert.ToInt32(dr["id_usuario"]);
                    usuario.userName = Convert.ToString(dr["nombre_usuario"]);
                    usuario.password = Convert.ToString(dr["contraseña"]);
                    usuario.id_rol = Convert.ToInt32(dr["id_rol"]);
                    usuario.estado = Convert.ToBoolean(dr["estado"]);

                    lista.Add(usuario);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { cmd.Connection.Close(); }

            return lista;
        }

        public User buscarUsuario(int id_usuario)
        {
            SqlCommand cmd = null;
            User usuario = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); // Singleton

                cmd = new SqlCommand("ps_obtenerUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_usuario", id_usuario);

                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    usuario = new User();

                    usuario.id_usuario = Convert.ToInt32(dr["id_usuario"]);
                    usuario.userName = Convert.ToString(dr["nombre_usuario"]);
                    usuario.password = Convert.ToString(dr["contraseña"]);
                    usuario.id_rol = Convert.ToInt32(dr["id_rol"]);
                    usuario.estado = Convert.ToBoolean(dr["estado"]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Connection.Close();
                    cmd.Dispose();
                }
            }

            return usuario;
        }

        public int insertarUsuario(User usuario)
        {
            SqlCommand cmd = null;
            int nuevoID = 0;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton

                cmd = new SqlCommand("ps_insertarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre_usuario", usuario.userName);
                cmd.Parameters.AddWithValue("@contraseña", usuario.password);
                cmd.Parameters.AddWithValue("@id_rol", usuario.id_rol);

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
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { cmd.Connection.Close(); }

            return nuevoID;
        }

        public bool editarUsuario(User usuario)
        {
            SqlCommand cmd = null;
            bool edita = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();

                cmd = new SqlCommand("ps_modificarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_usuario", usuario.id_usuario);
                cmd.Parameters.AddWithValue("@nombre_usuario", usuario.userName);
                cmd.Parameters.AddWithValue("@contraseña", usuario.password);
                cmd.Parameters.AddWithValue("@id_rol", usuario.id_rol);

                cn.Open();

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { cmd.Connection.Close(); }

            return edita;
        }

        public bool deshabilitarUsuario(User usuario)
        {
            SqlCommand cmd = null;
            bool seElimino = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ps_deshabilitarUsuario", cn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_usuario", usuario.id_usuario);

                cn.Open();

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    seElimino = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { cmd.Connection.Close(); }

            return seElimino;
        }

        #endregion Métodos
    }
}
