using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;

namespace DAL
{
    public static class DAL_RolPermisos
    {
        public static RolPermisos Insert(RolPermisos Entidad)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                Entidad.FechaRegistro = DateTime.Now;
                Entidad.Activo = true;
                bd.RolPermisos.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }
        public static bool Update(RolPermisos Entidad)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                var Registro = bd.RolPermisos.Find(Entidad.IdRolPermiso);
                Registro.IdPermiso = Entidad.IdPermiso;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Delete(RolPermisos Entidad)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                var Registro = bd.RolPermisos.Find(Entidad.IdRolPermiso);
                Registro.Activo = false;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }


    }

}

