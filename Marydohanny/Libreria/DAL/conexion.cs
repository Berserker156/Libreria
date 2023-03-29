using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class conexion
    {

        private static string NombreApplicacion = "Sitiowebdinamico";
        private static string Servidor = "MSI";
        private static string Usuario = " ";
        private static string Password = " ";
        private static string BaseDatos = "DinamitaWeb";
        public static string ConexionString(bool SqlAutentication = true)
        {
            SqlConnectionStringBuilder Constructor = new SqlConnectionStringBuilder();
            Constructor.ApplicationName = NombreApplicacion;
            Constructor.DataSource = Servidor;
            Constructor.InitialCatalog = BaseDatos;
            Constructor.IntegratedSecurity = SqlAutentication;

            if (SqlAutentication)
            {
                Constructor.UserID = Usuario;
                Constructor.Password = Password;

            }
            return Constructor.ConnectionString;
        }
    }
}
