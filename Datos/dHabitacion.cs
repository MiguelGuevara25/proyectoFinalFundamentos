using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
    }
}
