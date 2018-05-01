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
    public class CategoriaDAO
    {
        static readonly string cadena = ConfigurationManager.ConnectionStrings["cnnEventus"].ConnectionString;

        public List<CategoriaBE> LstCategoria()
        {
            try
            {
                List<CategoriaBE> resultado = new List<CategoriaBE>();


                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("pr_LstCategoria", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    CategoriaBE entidad = new CategoriaBE();
                                    entidad.categoriaid = dr.GetInt32(0);
                                    entidad.descripcion = dr.GetString(1);
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
