using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class eReserva
    {
        public int codigo_reserva { get; set; }
        public int tiempo_hospedaje { get; set; }
        public DateTime fecha { get; set; }
        public int codigo_U { get; set; }
        public int servicio_A_id { get; set; }
        public int pago_id { get; set; }
        public int ha_id { get; set; }
    }
}
