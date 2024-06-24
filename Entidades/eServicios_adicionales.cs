using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eServicios_adicionales
    {
        public int Orden { get; set; }
        public DateTime Fechas_inicio { get; set; }
        public DateTime Fechas_fin { get; set; }

        public int Tiempo { get; set; }
       
        public string Tipo_servicio { get; set; }

        public string Descripcion { get; set; }

        public string estado { get; set; }

        public float Precio { get; set; }


    }
}
