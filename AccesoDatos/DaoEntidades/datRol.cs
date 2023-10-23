using AccesoDatos.DataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entRol;

namespace AccesoDatos.DaoEntidades
{
    public class datRol
    {
        #region sigleton
        private static readonly datRol _instancia = new datRol();
        public static datRol Instancia
        {
            get
            {
                return datRol._instancia;
            }
        }
        #endregion singleton

        #region Métodos
        public List<Rol> listarRol()
        {
            SqlCommand cmd = null;
            List<Rol> lista = new List<Rol>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton

                cmd = new SqlCommand("ps_listarRol", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Rol rol = new Rol();

                    rol.id_rol = Convert.ToInt32(dr["id_rol"]);
                    rol.nombre = Convert.ToString(dr["nombre_rol"]);

                    lista.Add(rol);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { cmd.Connection.Close(); }

            return lista;
        }

        public Rol buscarRolId(int id_rol)
        {
            SqlCommand cmd = null;
            Rol rol = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); // Singleton

                cmd = new SqlCommand("ps_buscarRol", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_rol", id_rol);

                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    rol = new Rol();

                    rol.id_rol = Convert.ToInt32(dr["id_rol"]);
                    rol.nombre = Convert.ToString(dr["nombre_rol"]);
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

            return rol;
        }

        public Rol buscarRolNombre(string name_rol)
        {
            SqlCommand cmd = null;
            Rol rol = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); // Singleton

                cmd = new SqlCommand("ps_buscarRolName", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre_rol", name_rol);

                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    rol = new Rol();

                    rol.id_rol = Convert.ToInt32(dr["id_rol"]);
                    rol.nombre = Convert.ToString(dr["nombre_rol"]);
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

            return rol;
        }
        #endregion
    }
}
