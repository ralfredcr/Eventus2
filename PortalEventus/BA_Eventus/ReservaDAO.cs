using BE_Eventus;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_Eventus
{
    public class ReservaDAO
    {
        static readonly string cadena = ConfigurationManager.ConnectionStrings["cnnEventus"].ConnectionString;

        public int InsertReserva(ReservaBE obj)
        {
            try
            {
                int resultado = 0;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("pr_InsertReservas", connection))
                    {
                        cmd.Parameters.AddWithValue("@eventoid", obj.eventoid);
                        cmd.Parameters.AddWithValue("@importeTotal", obj.importeTotal);
                        cmd.Parameters.AddWithValue("@usuarioid", obj.usuarioid);
                        cmd.Parameters.AddWithValue("@estado", obj.estado);
                        cmd.Parameters.AddWithValue("@usuarioCreacion", obj.usuarioCreacion);
                        cmd.Parameters.AddWithValue("@usuarioActualiza", obj.usuarioActualiza);
                        cmd.Parameters.AddWithValue("@fechaRegistro", obj.fechaRegistro);
                        cmd.Parameters.AddWithValue("@fechaActualiza", obj.fechaActualiza);

                        SqlParameter outparam = cmd.Parameters.Add("@new_identity", SqlDbType.Int);
                        outparam.Direction = ParameterDirection.Output;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();

                        resultado = Convert.ToInt32(cmd.Parameters["@new_identity"].Value);
                        connection.Close();

                        return resultado;
                    }
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

    }
}
