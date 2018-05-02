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
                int resultado = 0;
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

        public int UpdateEvento(EventoBE obj)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("pr_UpdateEvento", connection))
                    {
                        cmd.Parameters.AddWithValue("@eventoid", obj.eventoid);
                        cmd.Parameters.AddWithValue("@titulo", obj.titulo);
                        cmd.Parameters.AddWithValue("@descripcion", obj.descripcion);
                        cmd.Parameters.AddWithValue("@descripcionAdicional", obj.descripcionAdicional);
                        cmd.Parameters.AddWithValue("@categoriaid", obj.categoriaid);
                        cmd.Parameters.AddWithValue("@RutaImagen", obj.RutaImagen);
                        cmd.Parameters.AddWithValue("@fechaInicio", obj.fechaInicio);
                        cmd.Parameters.AddWithValue("@fechaFin", obj.fechaFin);
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


        public EventoBE ObtenerEvento(int eventoid)
        {
            try
            {
                EventoBE obj = new EventoBE();
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("pr_ObtenerEvento", connection))
                    {
                        cmd.Parameters.Add("@eventoid", SqlDbType.Int).Value = eventoid;
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    obj.eventoid = dr.GetInt32(0);
                                    obj.titulo = dr.GetString(1);
                                    obj.descripcionEvento = dr.GetString(2);
                                    obj.descripcionAdicional = dr.GetString(3);
                                    obj.categoriaid = dr.GetInt32(4);
                                    if (dr["RutaImagen"] != DBNull.Value)
                                        obj.RutaImagen = (byte[])dr["RutaImagen"];
                                    else
                                    {
                                        obj.RutaImagen = null;
                                    }
                                    obj.fechaInicio = dr.GetDateTime(6);
                                    obj.fechaFin = dr.GetDateTime(7);
                                    obj.estado = dr.GetInt32(8);
                                    obj.descripcionCateg = dr.GetString(9);
                                    break;
                                }
                            }
                            dr.Dispose();
                        }
                    }
                    connection.Close();
                    return obj;
                }
            }
            catch (Exception ex)
            {


            }
            return null;
        }



    }
}
