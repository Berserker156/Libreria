

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;

namespace BL
{
    public static class Bl_Usuarios
    {
        public static usuario Insert(usuario entidad)
        {
            return DAL_usuarios.Insert(entidad);
        }

        public static bool Update(usuario entidad) 
        {
            return DAL_usuarios.Update(entidad);
        }

        public static bool Delete(usuario entidad) 
        {
            return DAL_usuarios.Delete(entidad);
        }
    }
}
