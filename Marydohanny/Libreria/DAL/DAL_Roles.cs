using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_Roles
    {
        //Insert
        public static EL.Roles InsertRoles(EL.Roles Entidad)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                Entidad.Activo = true;
                Entidad.FechaRegsitro = DateTime.Now;
                bd.Roles.Add(Entidad);
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
        public static bool Delete(EL.Roles Entidad)
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

        public static Roles InsertarRoles(Roles entidad)
        {
            throw new NotImplementedException();
        }

        public static bool Actualizar(Roles entidad)
        {
            throw new NotImplementedException();
        }

        public static bool Eliminar(Roles entidad)
        {
            throw new NotImplementedException();
        }

        public static List<Roles> List(bool activo)
        {
            throw new NotImplementedException();
        }

        public static List<Roles> Lista(bool activo)
        {
            throw new NotImplementedException();
        }

        public static Roles Registro_(int idRegistro)
        {
            throw new NotImplementedException();
        }

        public static Roles Registro___(int idRegistro)
        {
            throw new NotImplementedException();
        }

        public static List<Roles> Buscar(string palabra)
        {
            throw new NotImplementedException();
        }

        public static List<Roles> Buscar_(string palabra)
        {
            throw new NotImplementedException();
        }
    }
}
