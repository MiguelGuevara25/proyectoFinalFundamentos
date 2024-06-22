using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
namespace Negocio
{
    public class nExtra
    {
        dExtra extra;

        public nExtra()
        {
            extra = new dExtra();
        }

        public string RegistrarUser(string nombre, string apellido_P, string apellido_M, string correo, string nacionalidad, string genero, int telefono, int edad)
        {
            eExtra ex = new eExtra()
            {
                nombre = nombre,
                apellido_P = apellido_P,
                apellido_M = apellido_M,
                correo = correo,
                nacionalidad = nacionalidad,
                genero = genero,
                edad = edad,
                telefono = telefono,
            };

            return extra.Insertar(ex);

        }

    }
}
