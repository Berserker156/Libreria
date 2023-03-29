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

    public static class LibrosD_escargados_DAL
    {
        public static int InsertLibroDescargado(librosDes Entidad)
        {
            using (SqlConnection bd = new SqlConnection(conexion.ConexionString()))
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("InsertLibroDescargado", bd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@@nombre_del_libro", Entidad.@nombre_del_libro);
                cmd.Parameters.AddWithValue("@id_usuario", Entidad.id_usuario);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }


        }

        public static int UpdateLibrosDescargados(librosDes Entidad)
        {
            using (SqlConnection bd = new SqlConnection(conexion.ConexionString()))
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("UpdateLibrosDescargados", bd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@@nombre_del_libro", Entidad.@nombre_del_libro);
                cmd.Parameters.AddWithValue("@id_usuario", Entidad.id_usuario);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }


        }
        public static int DeleteLibrosDescargado(librosDes Entidad)
        {
            using (SqlConnection bd = new SqlConnection(conexion.ConexionString()))
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("DeleteLibrosDescargado", bd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@@nombre_del_libro", Entidad.@nombre_del_libro);
                cmd.Parameters.AddWithValue("@id_usuario", Entidad.id_usuario);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }


        }

    }
}
