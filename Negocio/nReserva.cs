using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using Datos;
namespace Negocio
{
    public class nReserva
    {

        dReservas reservas;

        public nReserva()
        {
            reservas = new dReservas();
        }

        public string RegistrarReserva(int tiempo_hospedaje,DateTime fecha,int codigo_usuario,int pago_id,int ha_id)
        {
            eReserva reserva = new eReserva()
            {
                tiempo_hospedaje = tiempo_hospedaje,
                fecha = fecha,
                codigo_U=codigo_usuario,
                pago_id=pago_id,
                ha_id=ha_id,
            };

            return reservas.Insertar(reserva);
        }

        public List<eRU>MostrarResera(string correo)
        {

            return reservas.listarReserva(correo); 
        }

        public eReserva UltimaReserva(string correo)
        {
            return reservas.getReservaActual(correo);
        }
    }
}
