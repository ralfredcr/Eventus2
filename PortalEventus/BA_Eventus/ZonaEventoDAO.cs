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

        public int UpdateEventoZona(ZonaEventoBE obj)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("pr_UpdateEventoZona", connection))
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

        public List<ZonaEventoBE> ObtenerEventoZona(int eventoid)
        {
            try
            {
                List<ZonaEventoBE> resultado = new List<ZonaEventoBE>();


                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("pr_ObtenerEventoZona", connection))
                    {
                        cmd.Parameters.Add("@eventoid", SqlDbType.VarChar).Value = eventoid;
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    ZonaEventoBE entidad = new ZonaEventoBE();
                                    entidad.num = dr.GetInt32(0);
                                    entidad.zona = dr.GetString(1);
                                    entidad.precio = dr.GetDecimal(2);
                                    entidad.cantidadMax = dr.GetInt32(3);                            
                                    resultado.Add(entidad);

                                }
                            }
                            dr.Dispose();
                        }
                    }
                    connection.Close();
                    return resultado;
                }
            }
            catch (Exception ex)
            {


            }
            return null;
        }


    }
}
