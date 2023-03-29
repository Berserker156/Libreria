using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;

namespace DAL
{
    public static class autorDAL
    {
        public static int InsertAutor(autor Entidad)
        {
            using (SqlConnection bd = new SqlConnection(conexion.ConexionString()))
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("InsertAutor", bd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", Entidad.Nombre);
                cmd.Parameters.AddWithValue("@apellido", Entidad.apellido);
                cmd.Parameters.AddWithValue("@edad", Entidad.edad);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }


        }

        public static int UpdateAutor(autor Entidad)
        {
            using (SqlConnection bd = new SqlConnection(conexion.ConexionString()))
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("UpdateAutor", bd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", Entidad.Nombre);
                cmd.Parameters.AddWithValue("@apellido", Entidad.apellido);
                cmd.Parameters.AddWithValue("@edad", Entidad.edad);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }


        }

        public static int DeleteAutor(autor Entidad)
        {
            using (SqlConnection bd = new SqlConnection(conexion.ConexionString()))
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("DeleteAutor", bd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", Entidad.Nombre);
                cmd.Parameters.AddWithValue("@apellido", Entidad.apellido);
                cmd.Parameters.AddWithValue("@edad", Entidad.edad);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }


        }

    }
}
