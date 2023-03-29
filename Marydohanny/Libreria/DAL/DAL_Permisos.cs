using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Permisos
    {
        public static Permisos Insert(Permisos Entidad)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                Entidad.FechaRegistro = DateTime.Now;
                Entidad.Activo = true;
                bd.Permisos.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }
        public static bool Update(Permisos Entidad)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                var Registro = bd.Permisos.Find(Entidad.IdPermiso);
                Registro.Permiso = Entidad.Permiso;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Delete(Permisos Entidad)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                var Registro = bd.Permisos.Find(Entidad.IdPermiso);
                Registro.Activo = false;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
    }
}
