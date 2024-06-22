using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
namespace Negocio
{
    public class nPagos
    {

        dPagos pago;

        public nPagos()
        {
            pago = new dPagos();
        }

        public string RegistrarPago(int codigo_pago, float monto, DateTime tiempo_pago, string estado, int codigo_tipo,int id_promociones)
        {
            ePagos reserva = new ePagos()
            {
               pago_id=codigo_pago,
               codigo_tipo=codigo_tipo,
               monto=monto,
               tiempo_pago=tiempo_pago,
               estado=estado,
               id_promociones=id_promociones,
            };

            return pago.Insertar(reserva);
        }

        public int idMayor()
        {
            return pago.MayorId();
        }
    }
}
