using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using EL;

namespace DAL
{
    public class BDDinamitaWeb : DbContext
    {
        public BDDinamitaWeb() : base(conexion.ConexionString())
        {

        }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<usuario> Usuarios { get; set; }
        public virtual DbSet<Formularios> Formularios { get; set; }
        public virtual DbSet<Permisos> Permisos { get; set; }
        public virtual DbSet<RolFormularios> RolFormularios { get; set; }
        public virtual DbSet<RolPermisos> RolPermisos { get; set; }

    }
}
