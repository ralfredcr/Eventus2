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
    public class ReservaDetalleDAO
    {
        static readonly string cadena = ConfigurationManager.ConnectionStrings["cnnEventus"].ConnectionString;

        public int InsertReservaDetalle(ReservaDetalleBE obj)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("pr_InsertDetalleReservas", connection))
                    {
                        cmd.Parameters.AddWithValue("@reservaid", obj.reservaid);
                        cmd.Parameters.AddWithValue("@zona", obj.zona);
                        cmd.Parameters.AddWithValue("@cantidad", obj.cantidad);
                        cmd.Parameters.AddWithValue("@precioUnit", obj.precioUnit);
                        cmd.Parameters.AddWithValue("@subTotal", obj.subTotal);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.ExecuteNonQuery();
                        connection.Close();

                        return 1;
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
