using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using Datos;

namespace Negocio
{
    public class nUsuario
    {

        dUsuario usuario;

        public nUsuario()
        {
            usuario = new dUsuario();
        }

        public string RegistrarUser(string nombre, string apellido_P,string apellido_M,string correo,string nacionalidad, string genero,string contrasena,int telefono,int edad)
        {
            eUsuario user = new eUsuario()
            {
                nombre = nombre,
                apellido_P = apellido_P,
                apellido_M = apellido_M,
                correo = correo,
                nacionalidad = nacionalidad,
                genero = genero,
                edad = edad,
                telefono=telefono,
                contrasena=contrasena
            };

            return usuario.Insertar(user);

        }



        public List<eUsuario>ListaUser()
        {
            return usuario.ListarTodo();
        }
    }
}
