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
    public class EventoDAO
    {

        static readonly string cadena = ConfigurationManager.ConnectionStrings["cnnEventus"].ConnectionString;

        public int InsertEvento(EventoBE obj)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("pr_InsertEvento", connection))
                    {
                        cmd.Parameters.AddWithValue("@titulo", obj.titulo);
                        cmd.Parameters.AddWithValue("@descripcion", obj.descripcion);
                        cmd.Parameters.AddWithValue("@descripcionAdicional", obj.descripcionAdicional);
                        cmd.Parameters.AddWithValue("@categoriaid", obj.categoriaid);
                        cmd.Parameters.AddWithValue("@RutaImagen", obj.RutaImagen);
                        cmd.Parameters.AddWithValue("@fechaInicio", obj.fechaInicio);
                        cmd.Parameters.AddWithValue("@fechaFin", obj.fechaFin);
                        cmd.Parameters.AddWithValue("@estado", obj.estado);
                        cmd.Parameters.AddWithValue("@usuarioCreacion", obj.usuarioCreacion);
                        cmd.Parameters.AddWithValue("@usuarioActualiza", obj.usuarioActualiza);
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

        public List<EventoBE> LstEvento(string descripcion)
        {
            try
            {
                List<EventoBE> resultado = new List<EventoBE>();


                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("pr_LstEvento", connection))
                    {
                        cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = descripcion;                   
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    EventoBE entidad = new EventoBE();
                                    entidad.eventoid = dr.GetInt32(0);
                                    entidad.titulo = dr.GetString(1);
                                    entidad.descripcion = dr.GetString(2);
                                    entidad.descripcionAdicional = dr.GetString(3);
                                    entidad.categoriaid = dr.GetInt32(4);
                                    entidad.descripcionCateg = dr.GetString(5);
                                    if (dr["RutaImagen"] != DBNull.Value)
                                        entidad.RutaImagen = (byte[])dr["RutaImagen"];
                                    else
                                    {
                                        entidad.RutaImagen = null;
                                    }
                                    entidad.fechaInicio = dr.GetDateTime(7);
                                    entidad.fechaFin = dr.GetDateTime(8);
                                    entidad.estado = dr.GetInt32(9);
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
