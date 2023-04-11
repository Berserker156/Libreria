using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;

namespace BL
{
    public static class BL_Formularios
    {
        public static Formularios InsertRoles(Formularios Entidad) 
        {
            return DAL_Formularios.InsertRoles(Entidad);    
        }

        public static bool Update(Roles Entidad) 
        {
            return DAL_Formularios.Update(Entidad);
        }

        public static bool Delete(Roles Entidad) 
        {
            return DAL_Roles.Delete(Entidad);
        }
    }
}
