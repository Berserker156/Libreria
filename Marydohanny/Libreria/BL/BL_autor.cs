using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;

namespace BL
{
    public static class BL_autor
    {
        public static int Insert( autor Entidad)
        {
            return autorDAL.InsertAutor( Entidad );
        }
        public static int Update(autor Entidad)
        {
            return autorDAL.UpdateAutor(Entidad);
        }
        public static int Delete(autor Entidad)
        {
            return autorDAL.DeleteAutor(Entidad);
        }
    }
}
