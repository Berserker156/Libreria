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
    public static class comentariosDAL
    {
        public static int Insertcomentarios(comentarios Entidad)
        {
            using (SqlConnection bd = new SqlConnection(conexion.ConexionString()))
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("Insertcomentarios", bd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Correo", Entidad.Correo);
                cmd.Parameters.AddWithValue("@comentario", Entidad.comentario);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }


        }

        public static int updadtecomentarios(comentarios Entidad)
        {
            using (SqlConnection bd = new SqlConnection(conexion.ConexionString()))
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("updadtecomentarios", bd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Correo", Entidad.Correo);
                cmd.Parameters.AddWithValue("@comentario", Entidad.comentario);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }


        }

        public static int deletecomentarios(comentarios Entidad)
        {
            using (SqlConnection bd = new SqlConnection(conexion.ConexionString()))
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("deletecomentarios", bd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Correo", Entidad.Correo);
                cmd.Parameters.AddWithValue("@comentario", Entidad.comentario);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }


        }

    }
}
