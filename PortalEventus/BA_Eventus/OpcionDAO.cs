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
    public class OpcionDAO
    {
        static readonly string cadena = ConfigurationManager.ConnectionStrings["cnnEventus"].ConnectionString;

        public List<OpcionBE> AccesoPerfil(int PerfilId)
        {
            try
            {
                List<OpcionBE> resultado = new List<OpcionBE>();

                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("pr_AccesoPerfil", connection))
                    {
                        cmd.Parameters.Add("@PerfilId", SqlDbType.Int).Value = PerfilId;
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    OpcionBE entidad = new OpcionBE();
                                    entidad.OpcionesId = dr.GetInt32(0);
                                    entidad.DescOpciones = dr.GetString(1);
                                    entidad.URL = dr.GetString(2);
                                    entidad.PadreId = dr.GetString(3);
                                    entidad.Orden = dr.GetInt32(4);
                                    entidad.Icono = dr.GetString(5);
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
