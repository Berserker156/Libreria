using System.Data;
using System.Linq;

namespace DAL
{
    public static class DAL_usuariosBase
    {
        public static bool ExisteUserName(string UserName)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                return bd.Usuarios.Where(a => a.UserName.ToLower() == UserName.ToLower()).Count() > 0;
            }
        }


        public static bool ExisteUserName(string UserName)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                return bd.Usuarios.Where(a => a.UserName.ToLower() == UserName.ToLower()).Count() > 0;
            }
        }
    }
}