using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class LibroEL
    {
        public int ID { set; get; }
        public string nombre { set; get; }

        public string Area { set; get; }

        public string Autor { set; get; }

        public string Idioma { set; get; }

        public string editorial { set; get; }

        public DateTime? fecha_publicación { set; get; }

        public int paginas { set; get; }

    }
}
