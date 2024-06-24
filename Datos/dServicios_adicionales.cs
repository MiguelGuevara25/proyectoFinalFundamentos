using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Datos
{
    public class dServicios_adicionales
    {
        Database db = new Database();

        public List<eServicios_adicionales>listar(string tipo)
        {
            List<eServicios_adicionales> lista = new List<eServicios_adicionales>();
            SqlConnection con = db.ConectaDb();

            eServicios_adicionales servicio = null;
            String query = @"SELECT servicio_A_id,fechas_inicio,fechas_fin,tiempo,Tipo_de_servicio.tipo_servicio,precio,descripción,n_servicio,estado FROM Servicios_adicionales
                             INNER JOIN Tipo_de_servicio ON Tipo_de_servicio.tipo_ser_id=Servicios_adicionales.tipo_ser_id
                           WHERE Tipo_de_servicio.tipo_servicio=@tipo";

            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@tipo", tipo);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                servicio = new eServicios_adicionales();

                servicio.Descripcion = (string)reader["Descripción"];
                servicio.Fechas_inicio = (DateTime)reader["fechas_inicio"];
                servicio.Fechas_fin = (DateTime)reader["fechas_fin"];
                servicio.Tiempo = (int)reader["tiempo"];
                servicio.Tipo_servicio = (String)reader["tipo_servicio"];
                servicio.Descripcion = (string)reader["descripción"];
                servicio.estado = (string)reader["estado"];
                servicio.Orden = (int)reader["servicio_A_id"];
                servicio.Precio = (int)reader["precio"];

                lista.Add(servicio);
            }
            reader.Close();

            return lista;
        }

        public string insertar(eReserva reserva,int servicio)
        {
            SqlConnection con = db.ConectaDb();
            String query = "INSERT INTO Reserva(tiempo_hospedaje,fecha,codigo_U,pago_id,ha_id,servicio_A_id) VALUES(@tiempo, @fecha, @codigo_U, @pago_id, @ha_id,@servicio)";

            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@tiempo", reserva.tiempo_hospedaje);
            command.Parameters.AddWithValue("@fecha", reserva.fecha);
            
            command.Parameters.AddWithValue("@codigo_U", reserva.codigo_U);
            command.Parameters.AddWithValue("@pago_id", reserva.pago_id);
            command.Parameters.AddWithValue("@ha_id", reserva.ha_id);
            command.Parameters.AddWithValue("servicio",servicio);
            command.ExecuteNonQuery();
            db.DesconectaDb();

            return "Inserto";
        }

        public string ActualizarServicioEstado(int orden)
        {
            SqlConnection con = db.ConectaDb();

            string query = "UPDATE Servicios_adicionales SET estado='RESERVADO' WHERE servicio_A_id=@orden";

            SqlCommand command = new SqlCommand(query,con);

            command.Parameters.AddWithValue("@orden", orden);
            command.ExecuteNonQuery();

            db.DesconectaDb();
            return "Actualizar";

        }
    }
}
