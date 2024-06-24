using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class dReservas
    {
        Database db = new Database();

        public String Insertar(eReserva extra)
        {
            Console.WriteLine($"nADA:{extra.codigo_U}");

            Console.ReadLine();
            SqlConnection con = db.ConectaDb();
            String query = "INSERT INTO Reserva(tiempo_hospedaje,fecha,codigo_U,pago_id,ha_id) VALUES(@tiempo, @fecha, @codigo_U, @pago_id, @ha_id)";

            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@tiempo", extra.tiempo_hospedaje);
            command.Parameters.AddWithValue("@fecha", extra.fecha);

            Console.WriteLine($"nADA:{extra.codigo_U}");
            command.Parameters.AddWithValue("@codigo_U", extra.codigo_U);
            command.Parameters.AddWithValue("@pago_id", extra.pago_id);
            command.Parameters.AddWithValue("@ha_id", extra.ha_id);
            command.ExecuteNonQuery();
            db.DesconectaDb();

            return "Inserto";

            

        }

        public eReserva getReservaActual(string correo)
        {
            eReserva reserva = null;
          

            Console.ReadLine();
            SqlConnection con = db.ConectaDb();
            String query = @"SELECT tiempo_hospedaje,fecha,codigo_U,pago_id,ha_id FROM Reserva 
                           WHERE codigo_reserva=(SELECT MAX(codigo_reserva) AS UltimaR FROM Reserva)
                           and codigo_U=(SELECT codigo_U FROM Usuario WHERE correo=@correo)";

            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@correo", correo);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                reserva = new eReserva();

                reserva.pago_id = (int)reader["pago_id"];
                reserva.ha_id = (int)reader["ha_id"];
                reserva.codigo_U = (int)reader["codigo_U"];
                reserva.fecha = (DateTime)reader["fecha"];
                reserva.tiempo_hospedaje = (int)reader["tiempo_hospedaje"];
            }

                db.DesconectaDb();

            return reserva;

        }


        public List<eRU>listarReserva(string correo)
        {
            List<eRU> lista = new List<eRU>();

            eRU reserva = null;
            SqlConnection con = db.ConectaDb();
            string query = @"SELECT tipo_habitacion,fecha,tipo_servicio,tiempo_hospedaje,codigo_reserva FROM Reserva
                                INNER JOIN Usuario ON Usuario.codigo_U=Reserva.codigo_U
                                INNER JOIN Habitacion ON Reserva.ha_id=Habitacion.ha_id
                                INNER JOIN Tipo_de_habitaciones ON Tipo_de_habitaciones.t_h_id=Habitacion.t_h_id
                                LEFT JOIN  Servicios_adicionales ON Servicios_adicionales.servicio_A_id=Reserva.servicio_A_id
                                LEFT JOIN Tipo_de_servicio ON Tipo_de_servicio.tipo_ser_id=Servicios_adicionales.tipo_ser_id
                                WHERE correo='alexisquisperamos567@gmail.com'";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@correo", correo);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                reserva = new eRU();

                reserva.Tipo_de_habitacion = (string)reader["tipo_habitacion"];
                reserva.Fecha = (DateTime)reader["fecha"];
                reserva.Nombre_Servicio = reader["tipo_servicio"] != DBNull.Value ? (String)reader["tipo_servicio"] : null; ;
                reserva.Tiempo_hospedaje = (int)reader["tiempo_hospedaje"];
                reserva.Orden = (int)reader["codigo_reserva"];

                lista.Add(reserva);
            }

            reader.Close();

            return lista;
        }

    }
}
