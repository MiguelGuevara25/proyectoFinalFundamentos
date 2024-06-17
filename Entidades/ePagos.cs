using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ePagos
    {
        public int pago_id { get; set; }
        public float monto { get; set; }
        public DateTime tiempo_pago { get; set; }
        public String estado { get; set; }
        public int codigo_tipo { get; set; }
        public int id_promociones { get; set; }
    }
}
