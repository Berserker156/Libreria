using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using EL;


namespace DAL
{
     public class DAL_CLIENTE
    {
        public bool Insertar(cliente entidad)
        {
            cliente cliente = new cliente();
            cliente.ID = entidad.ID;
            cliente.Nombre = entidad.Nombre;

            return true;
        
        }
    }
}
