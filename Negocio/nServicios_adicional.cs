using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Negocio
{
    public class nServicios_adicional
    {
        dServicios_adicionales server;

        public nServicios_adicional()
        {
            server = new dServicios_adicionales();
        }

        public List<eServicios_adicionales>listar(string tipo)
        {
            return server.listar(tipo);
        }

        public string InsertarServicioAdicional(eReserva reserva,int a)
        {


            return server.insertar(reserva,a);
        }
    }
}
