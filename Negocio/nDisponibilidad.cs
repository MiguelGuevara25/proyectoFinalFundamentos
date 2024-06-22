using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
namespace Negocio
{
    public class nDisponibilidad
    {
        dDisponibilidad dispon;

        public nDisponibilidad()
        {
            dispon = new dDisponibilidad();
        }

        public string ActualizarInicio()
        {
            return dispon.ActualizarfechaInicio();
        }

        public string ActualizarReserva(int dias, int id)
        {
            return dispon.ActualizafechaReserva(dias,id);
        }

        public string Liberar()
        {
            return dispon.LiberarReserva();
        }
    }
}
