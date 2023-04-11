using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class BL_Comentario
    {
        public static int InsertarComentario( comentarios entidad) 
        {
            return comentariosDAL.Insertcomentarios(entidad);   
        }

        public static int updatecomentarios( comentarios entidad) 
        {
            return comentariosDAL.updadtecomentarios(entidad);
        }

        public static int deletecomentarios( comentarios entidad) 
        {
            return comentariosDAL.deletecomentarios(entidad);
        }


    }
}
