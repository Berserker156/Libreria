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
    public static class editorialDAL
    {
        public static int InsertEditorial(editorial Entidad)
        {
            using (SqlConnection bd = new SqlConnection(conexion.ConexionString()))
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("InsertEditorial", bd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", Entidad.Nombre);
                cmd.Parameters.AddWithValue("@fecha_de_publicación", Entidad.fecha_de_publicación);
                cmd.Parameters.AddWithValue("@locacion", Entidad.locacion);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }


        }

        public static int UpdateEditorial(editorial Entidad)
        {
            using (SqlConnection bd = new SqlConnection(conexion.ConexionString()))
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("UpdateEditorial", bd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@@Nombre", Entidad.Nombre);
                cmd.Parameters.AddWithValue("@fecha_de_publicación", Entidad.fecha_de_publicación);
                cmd.Parameters.AddWithValue("@locacion", Entidad.locacion);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }


        }

        public static int DeleteEditorial(editorial Entidad)
        {
            using (SqlConnection bd = new SqlConnection(conexion.ConexionString()))
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("DeleteEditorial", bd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@@Nombre", Entidad.Nombre);
                cmd.Parameters.AddWithValue("@fecha_de_publicación", Entidad.fecha_de_publicación);
                cmd.Parameters.AddWithValue("@locacion", Entidad.locacion);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }


        }
    }
}
