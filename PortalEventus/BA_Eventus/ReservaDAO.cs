using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_Eventus
{
    public class ReservaDAO
    {
        static readonly string cadena = ConfigurationManager.ConnectionStrings["cnnEventus"].ConnectionString;

        //public ClienteBE Login(string correo, string ContrasenaCliente, int PerfilId)
        //{
        //    try
        //    {
        //        ClienteBE login = new ClienteBE();
        //        using (SqlConnection connection = new SqlConnection(cadena))
        //        {
        //            connection.Open();
        //            using (SqlCommand cmd = new SqlCommand("pr_Login", connection))
        //            {
        //                cmd.Parameters.Add("@Correo", SqlDbType.VarChar).Value = correo;
        //                cmd.Parameters.Add("@ContrasenaCliente", SqlDbType.VarChar).Value = ContrasenaCliente;
        //                cmd.Parameters.Add("@PerfilId", SqlDbType.Int).Value = PerfilId;
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                using (SqlDataReader dr = cmd.ExecuteReader())
        //                {
        //                    if (dr.HasRows)
        //                    {
        //                        while (dr.Read())
        //                        {
        //                            login.ClienteId = dr.GetInt32(0);
        //                            login.NombreCompleto_RazonSocial = dr.GetString(1);
        //                            login.Nombres = dr.GetString(2);
        //                            login.Apellidos = dr.GetString(3);
        //                            login.Correo = dr.GetString(4);
        //                            login.PerfilId = dr.GetInt32(5);
        //                            login.DescPerfil = dr.GetString(6);
        //                            break;
        //                        }
        //                    }
        //                    dr.Dispose();
        //                }
        //            }
        //            connection.Close();
        //            return login;
        //        }
        //    }
        //    catch (Exception ex)
        //    {


        //    }
        //    return null;
        //}

    }
}
