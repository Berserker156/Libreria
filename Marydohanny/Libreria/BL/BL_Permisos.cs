﻿using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;

namespace BL
{
    public static class BL_Permisos
    {
        public static Permisos Insert(Permisos Entidad)
        {
            return DAL_Permisos.Insert(Entidad);
        }
        public static bool Update(Permisos Entidad)
        {
            return DAL_Permisos.Update(Entidad);
        }

        public static bool Delete(Permisos Entidad)
        {
            return DAL_Permisos.Delete(Entidad);
        }
    }
}
