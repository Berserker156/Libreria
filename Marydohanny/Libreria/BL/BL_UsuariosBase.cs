using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class BL_UsuariosBase
    {
        public static bool ExisteUserName(string UserName)
        {
            return DAL_usuarios.ExisteUserName(UserName);
        }
    }
}

