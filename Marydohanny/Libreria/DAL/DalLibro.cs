using EL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DalLibro
    {
        public static int InsertLibros(LibroEL Entidad)
        {
            using (SqlConnection bd = new SqlConnection(conexion.ConexionString()))
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("InsertLibros", bd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", Entidad.ID);
                cmd.Parameters.AddWithValue("@nombre", Entidad.nombre);
                cmd.Parameters.AddWithValue("@Area", Entidad.Area);
                cmd.Parameters.AddWithValue("@Autor", Entidad.Autor);
                cmd.Parameters.AddWithValue("@Idioma", Entidad.Idioma);
                cmd.Parameters.AddWithValue("@editorial", Entidad.editorial);
                cmd.Parameters.AddWithValue("@fecha_publicación", Entidad.fecha_publicación);
                cmd.Parameters.AddWithValue("@paginas", Entidad.paginas);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }


        }

        public static int UpdateLibros(LibroEL Entidad)
        {
            using (SqlConnection bd = new SqlConnection(conexion.ConexionString()))
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("UpdateLibros", bd);
                cmd.Parameters.AddWithValue("@ID", Entidad.ID);
                cmd.Parameters.AddWithValue("@nombre", Entidad.nombre);
                cmd.Parameters.AddWithValue("@Area", Entidad.Area);
                cmd.Parameters.AddWithValue("@Autor", Entidad.Autor);
                cmd.Parameters.AddWithValue("@Idioma", Entidad.Idioma);
                cmd.Parameters.AddWithValue("@editorial", Entidad.editorial);
                cmd.Parameters.AddWithValue("@fecha_publicación", Entidad.fecha_publicación);
                cmd.Parameters.AddWithValue("@paginas", Entidad.paginas);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static int DeleteLibros(LibroEL Entidad)
        {
            using (SqlConnection bd = new SqlConnection(conexion.ConexionString()))
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("DeleteLibros", bd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", Entidad.ID);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }




    }
}
