using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class dPagos
    {
        Database db = new Database();
        public String Insertar(ePagos pago)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                String query = "INSERT INTO Pagos(pago_id,monto,tiempo_pago,estado,codigo_tipo,id_promociones) VALUES(@pago_id, @monto, @tiempo_pago,@estado, @codigo_tipo, @id_promociones)";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@pago_id", pago.pago_id);
                command.Parameters.AddWithValue("@monto", pago.monto);
                command.Parameters.AddWithValue("@tiempo_pago", pago.tiempo_pago);
                command.Parameters.AddWithValue("@estado", pago.estado);
                command.Parameters.AddWithValue("@codigo_tipo", pago.codigo_tipo);
                command.Parameters.AddWithValue("@id_promociones", pago.id_promociones);
           
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
