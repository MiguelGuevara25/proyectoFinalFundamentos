using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class dExtra
    {
        Database db = new Database();
        public String Insertar(eExtra extra)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                String query = "INSERT INTO Extra(nombre,apellido_P,apellido_M,edad,genero,correo,nacionalidad,telefono,codigo_U) VALUES(@nombre, @apellido_P, @apellido_M,@edad, @genero, @correo, @nacionalidad,@telefono,@codigo_U)";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@nombre", extra.nombre);
                command.Parameters.AddWithValue("@apellido_P", extra.apellido_P);
                command.Parameters.AddWithValue("@apellido_M", extra.apellido_M);
                command.Parameters.AddWithValue("@edad", extra.edad);
                command.Parameters.AddWithValue("@genero", extra.genero);
                command.Parameters.AddWithValue("@correo", extra.correo);
                command.Parameters.AddWithValue("@nacionalidad", extra.nacionalidad);
                command.Parameters.AddWithValue("@telefono", extra.telefono);
                command.Parameters.AddWithValue("@codigo_U", extra.codigo_U);

                command.ExecuteNonQuery();
                return "Inserto";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
    }
}
