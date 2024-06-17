using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eUsuario
    {
        public int codigo_U { get; set; }
        public String nombre { get; set; }
        public String apellido_P { get; set; }
        public String apellido_M { get; set; }
        public int edad { get; set; }
        public String genero { get; set; }
        public String correo { get; set; }
        public String nacionalidad { get; set; }
        public int telefono { get; set; }
        public String contrasena { get; set; }

        public string getNombre()
        {
            return nombre;
        }

        public string getApellidoP()
        {
            return apellido_P;
        }

        public string getApellidoM()
        {
            return apellido_M;
        }

        public int getEdad()
        {
            return edad;
        }

        public string getCorreo()
        {
            return correo;
        }

        public string getContrasena()
        {
            return contrasena;
        }
    }
}
