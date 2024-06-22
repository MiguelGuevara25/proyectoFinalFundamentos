using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eCombinacion
    {
        public int Orden { get; set; }
        public string Tipo { get; set; }
        public int Precio { get; set; }
        public DateTime Disponibilidad { get; set; }
        public DateTime Fecha_Fin { get; set; }
        public int Espacios { get; set; }

        public string Estado { get; set; }
    }
}
