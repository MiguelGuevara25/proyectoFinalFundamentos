using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class dHabitacion
    {
        Database db = new Database();

        public String Insertar(eHabitacion hab)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                String query = "INSERT INTO Habitacion(cantidad_camas,descripcion,t_h_id,dispon_id,numero_h) VALUES(@cantidad_camas, @descripcion, @t_h_id,@dispon_id,@numero_h)";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("cantidad_camas", hab.cantidad_camas);
                command.Parameters.AddWithValue("@descripcion", hab.descripcion);
                command.Parameters.AddWithValue("@t_h_id", hab.t_h_id);
                command.Parameters.AddWithValue("@dispon_id", hab.dispon_id);
                command.Parameters.AddWithValue("@numero_h",hab.numero_h);
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

  
        public List<eCombinacion>listarTodo()
        {
            List<eCombinacion> lista = new List<eCombinacion>();
            eCombinacion comba = null;

            SqlConnection con = db.ConectaDb();
            string query = @"
                SELECT Disponibilidad.dispon_id,fecha_inicio,espacios,Tipo_de_habitaciones.tipo_habitacion,precio,fecha_fin,estado
                FROM Habitacion
                INNER JOIN Disponibilidad ON Disponibilidad.dispon_id = Habitacion.dispon_id
                INNER JOIN Tipo_de_habitaciones ON Habitacion.t_h_id = Tipo_de_habitaciones.t_h_id
                WHERE estado='LIBRE'
                
            ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comba = new eCombinacion();
                comba.Orden = (int)reader["dispon_id"];
                comba.Tipo = (string)reader["tipo_habitacion"];
                comba.Precio = (int)reader["precio"];
                comba.Disponibilidad = (DateTime)reader["fecha_inicio"];
                comba.Espacios = (int)reader["espacios"];
                comba.Fecha_Fin = (DateTime)reader["fecha_fin"];
                comba.Estado = (string)reader["estado"];

                lista.Add(comba);
            }
            reader.Close();
            return lista;
        }

        public List<eCombinacion>listartodo(string tipo,DateTime fecha)
        {
            List<eCombinacion> lista = new List<eCombinacion>();
            eCombinacion comba = null;

            SqlConnection con = db.ConectaDb();
            string query = @"
                SELECT Disponibilidad.dispon_id,fecha_inicio,espacios,Tipo_de_habitaciones.tipo_habitacion,precio,fecha_fin,estado
                FROM Habitacion
                INNER JOIN Disponibilidad ON Disponibilidad.dispon_id = Habitacion.dispon_id
                INNER JOIN Tipo_de_habitaciones ON Habitacion.t_h_id = Tipo_de_habitaciones.t_h_id
                WHERE Tipo_de_habitaciones.tipo_habitacion=@tipo AND estado='LIBRE';
            ";
            SqlCommand cmd = new SqlCommand(query, con);

           
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@fecha", fecha);
            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                comba = new eCombinacion();
                comba.Orden = (int)reader["dispon_id"];
                comba.Tipo = (string)reader["tipo_habitacion"];
                comba.Precio = (int)reader["precio"];
                comba.Disponibilidad = (DateTime)reader["fecha_inicio"];
                comba.Espacios = (int)reader["espacios"];
                comba.Fecha_Fin = (DateTime)reader["fecha_fin"];
                comba.Estado = (string)reader["estado"];

                lista.Add(comba);
            }
            reader.Close();
            return lista;

        }

        public int getId(int orden)
        {
            SqlConnection con = db.ConectaDb();
            string query = @"SELECT ha_id
                FROM Habitacion
                INNER JOIN Disponibilidad ON Disponibilidad.dispon_id = Habitacion.dispon_id
                WHERE Disponibilidad.dispon_id=@orden";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@orden", orden);

            SqlDataReader reader = cmd.ExecuteReader();

            int id = 0;
            while (reader.Read())
            {
                id = (int)reader["ha_id"];
            }

            return id;
        }
    }


}
