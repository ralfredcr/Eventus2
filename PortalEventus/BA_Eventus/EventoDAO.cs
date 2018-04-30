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
                        cmd.Parameters.Add("@titulo", SqlDbType.VarChar).Value = obj.titulo;
                        cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = obj.descripcion;
                        cmd.Parameters.Add("@descripcionAdicional", SqlDbType.VarChar).Value = obj.descripcionAdicional;
                        cmd.Parameters.Add("@categoriaid", SqlDbType.Int).Value = obj.categoriaid;
                        cmd.Parameters.Add("@cantidadMax", SqlDbType.Int).Value = obj.cantidadMax;
                        cmd.Parameters.Add("@RutaImagen", SqlDbType.Binary).Value = obj.RutaImagen;
                        cmd.Parameters.Add("@fechaInicio", SqlDbType.DateTime).Value = obj.fechaInicio;
                        cmd.Parameters.Add("@fechaFin", SqlDbType.DateTime).Value = obj.fechaFin;
                        cmd.Parameters.Add("@estado", SqlDbType.Int).Value = obj.estado;
                        cmd.Parameters.Add("@activo", SqlDbType.Bit).Value = obj.activo;
                        cmd.Parameters.Add("@usuarioCreacion", SqlDbType.Int).Value = obj.usuarioCreacion;
                        cmd.Parameters.Add("@usuarioActualiza", SqlDbType.Int).Value = obj.usuarioActualiza;
                        cmd.Parameters.Add("@fechaRegistro", SqlDbType.DateTime).Value = obj.fechaRegistro;
                        cmd.Parameters.Add("@fechaActualiza", SqlDbType.DateTime).Value = obj.fechaActualiza;
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
