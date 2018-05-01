using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE_Eventus;
using System.Data.SqlClient;
using System.Data;

namespace BA_Eventus
{
    public class PersonaDAO
    {
        static readonly string cadena = ConfigurationManager.ConnectionStrings["cnnEventus"].ConnectionString;
        public List<Pais> paisListar()
        {
            try
            {
                List<Pais> lista = new List<Pais>();
                using (SqlConnection cone = new SqlConnection(cadena))
                {
                    cone.Open();
                    using (SqlCommand cmd = new SqlCommand("up_PaisListar", cone))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    Pais objPais = new Pais();
                                    objPais.codigoPais = dr.GetInt16(0);
                                    objPais.nombrePais = dr.GetString(1);
                                    lista.Add(objPais);
                                }
                            }
                            dr.Dispose();
                        }
                    }
                    cone.Close();
                    return lista;
                }
            }
            catch (Exception ex)
            {
                return null;
                throw;
            }
        }

        public List<Departamento> departamentoListar()
        {
            try
            {
                List<Departamento> lista = new List<Departamento>();
                using (SqlConnection cone = new SqlConnection(cadena))
                {
                    cone.Open();
                    using (SqlCommand cmd = new SqlCommand("up_departamentoListar", cone))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    Departamento objDep = new Departamento();
                                    objDep.codigoDepartamento = dr.GetString(0);
                                    objDep.nombreDepartamento = dr.GetString(1);
                                    lista.Add(objDep);
                                }
                            }
                            dr.Dispose();
                        }
                    }
                    cone.Close();
                    return lista;
                }
            }
            catch (Exception ex)
            {
                return null;
                throw;
            }
        }

        public List<Provincia> provinciaListar(String codDepartamento)
        {
            try
            {
                List<Provincia> lista = new List<Provincia>();
                using (SqlConnection cone = new SqlConnection(cadena))
                {
                    cone.Open();
                    using (SqlCommand cmd = new SqlCommand("up_provinciaListar", cone))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@codigoDepartamento", SqlDbType.VarChar).Value = codDepartamento;
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    Provincia objProv = new Provincia();
                                    objProv.codigoProvincia = dr.GetString(0);
                                    objProv.nombreProvincia = dr.GetString(1);
                                    lista.Add(objProv);
                                }
                            }
                            dr.Dispose();
                        }
                    }
                    cone.Close();
                    return lista;
                }
            }
            catch (Exception ex)
            {
                return null;
                throw;
            }
        }
    }
}
