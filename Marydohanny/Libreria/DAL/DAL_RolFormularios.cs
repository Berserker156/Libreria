using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class DAL_RolFormularios
    {
        public static RolFormularios Insert(RolFormularios Entidad)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                Entidad.FechaRegistro = DateTime.Now;
                Entidad.Activo = true;
                bd.RolFormularios.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }
        public static bool Update(RolFormularios Entidad)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                var Registro = bd.RolFormularios.Find(Entidad.IdRolFormulario);
                Registro.IdFormulario = Entidad.IdFormulario;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
        public static bool Delete(RolFormularios Entidad)
        {
            using (BDDinamitaWeb bd = new BDDinamitaWeb())
            {
                var Registro = bd.RolFormularios.Find(Entidad.IdRolFormulario);
                Registro.Activo = false;
                Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
                Registro.FechaActualizacion = DateTime.Now;
                return bd.SaveChanges() > 0;
            }
        }
    }
}
