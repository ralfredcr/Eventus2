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
    public class ZonaEventoDAO
    {
        static readonly string cadena = ConfigurationManager.ConnectionStrings["cnnEventus"].ConnectionString;

        public int InsertEventoZona(ZonaEventoBE obj)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("pr_InsertEventoZona", connection))
                    {
                        cmd.Parameters.AddWithValue("@eventoid", obj.eventoid);
                        cmd.Parameters.AddWithValue("@zona", obj.zona);
                        cmd.Parameters.AddWithValue("@precio", obj.precio);
                        cmd.Parameters.AddWithValue("@cantidadMax", obj.cantidadMax);
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
