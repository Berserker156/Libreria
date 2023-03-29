using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Formularios
    {
        //Insert
        public static Formularios InsertRoles(Formularios Entidad)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                Entidad.Activo = true;
                Entidad.FechaRegistro = DateTime.Now;
                bd.Formularios.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }

        //Update
        public static bool Update(Roles Entidad)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                var RegistroBD = bd.Roles.Find(Entidad.IdRol);
                RegistroBD.Rol = Entidad.Rol;
                RegistroBD.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                RegistroBD.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }


        //Delete
        public static bool Delete(Roles Entidad)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                var RegistroBD = bd.Roles.Find(Entidad.IdRol);
                RegistroBD.Activo = false;
                RegistroBD.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                RegistroBD.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }

        }
    }
}
