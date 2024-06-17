using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class dDisponibilidad
    {
        Database db = new Database();
        public String Actualizar(int espacios, String clave, eHabitacion hat)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                String query = "UPDATE Disponibilidad SET espacios = @espacio , estado=@estado  WHERE dispon_id = @Orden";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@espacio", espacios-1);
                command.Parameters.AddWithValue("@estado", clave);
                command.Parameters.AddWithValue("@Orden",hat.ha_id);
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
