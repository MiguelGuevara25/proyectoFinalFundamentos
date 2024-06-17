using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class dUsuario
    {
        Database db = new Database();

        public String Insertar(eUsuario user)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                
                String query = "INSERT INTO Usuario(nombre,apellido_P,apellido_M,edad,genero,correo,nacionalidad,telefono,contrasena) VALUES(@nombre, @apellido_P, @apellido_M,@edad, @genero, @correo, @nacionalidad,@telefono,@contrasena)";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@nombre", user.nombre);
                command.Parameters.AddWithValue("@apellido_P", user.apellido_P);
                command.Parameters.AddWithValue("@apellido_M", user.apellido_M);
                command.Parameters.AddWithValue("@edad", user.edad);
                command.Parameters.AddWithValue("@genero", user.genero);
                command.Parameters.AddWithValue("@correo", user.correo);
                command.Parameters.AddWithValue("@nacionalidad", user.nacionalidad);
                command.Parameters.AddWithValue("@telefono", user.telefono);
                command.Parameters.AddWithValue("@contrasena", user.contrasena);

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

        public List<eUsuario> ListarTodo()
        {
            try
            {
                //TODO
                List<eUsuario> lsUsuario = new List<eUsuario>();
                eUsuario usuario = null;
                SqlConnection con = db.ConectaDb();
                SqlCommand cmd = new SqlCommand("select codigo_U,nombre,apellido_P,apellido_M,edad,correo,nacionalidad,genero,contrasena from Usuario", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    usuario = new eUsuario();
                    usuario.codigo_U = (int)reader["codigo_U"];
                    usuario.nombre = (string)reader["nombre"];
                    usuario.apellido_P =(string)reader["apellido_P"];
                    usuario.apellido_M =(string)reader["apellido_M"];
                    usuario.edad =(int)reader["edad"];
                    usuario.correo =(string)reader["correo"];
                    usuario.nacionalidad = (string)reader["nacionalidad"];
                    usuario.genero =(string)reader["genero"];
                    usuario.contrasena =(string)reader["contrasena"];

                    lsUsuario.Add(usuario);
                }
                reader.Close();
                return lsUsuario;

            }
            catch (Exception ex)
            {
                return null;


            }
            finally
            {
                db.DesconectaDb();
            }
        }
    }
}
