using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
namespace Negocio
{
    public class nHabitacion
    {
        dHabitacion ha;
        public nHabitacion()
        {
            ha = new dHabitacion();
        }

        public List<eCombinacion>listarDipon(string tipo, DateTime fecha)
        {
            return ha.listartodo(tipo,fecha);
        }

        public int getId(int orden)
        {
            int b=ha.getId(orden);

            return b;
        }
        
    }
}
