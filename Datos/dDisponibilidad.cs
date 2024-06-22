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

        public String ActualizarfechaInicio()
        {
            SqlConnection con = db.ConectaDb();
            String query = "UPDATE Disponibilidad SET fecha_inicio = GETDATE()  WHERE fecha_inicio < GETDATE() AND estado='LIBRE'";

            SqlCommand command = new SqlCommand(query,con);

            command.ExecuteNonQuery();

            db.DesconectaDb();
            return "Actuactualizado";


        }

        public String ActualizafechaReserva(int dias,int id)
        {
            SqlConnection con = db.ConectaDb();
            String query = "UPDATE Disponibilidad SET fecha_inicio = GETDATE(), fecha_fin=@fecha, estado=@estado  WHERE dispon_id=@id";

            SqlCommand command = new SqlCommand(query, con);
            DateTime fechaActual = DateTime.Now;
            DateTime fechaFutura = fechaActual.AddDays(dias);
            command.Parameters.AddWithValue("@fecha",fechaFutura);
            command.Parameters.AddWithValue("@id",id);
            command.Parameters.AddWithValue("@estado","RESERVADO");

            command.ExecuteNonQuery();

            return "Actuactualizado";
        }

        public String LiberarReserva()
        {
            SqlConnection con = db.ConectaDb();
            String query = "UPDATE Disponibilidad SET estado='LIBRE' WHERE fecha_fin<GETDATE()";
            SqlCommand command = new SqlCommand(query, con);

            command.ExecuteNonQuery();

            return "Liberado";
        }

    }
}
