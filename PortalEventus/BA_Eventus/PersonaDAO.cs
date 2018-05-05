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

        public List<Distrito> distritoListar(String codDepartamento, String codProvincia)
        {
            try
            {
                List<Distrito> lista = new List<Distrito>();
                using (SqlConnection cone = new SqlConnection(cadena))
                {
                    cone.Open();
                    using (SqlCommand cmd = new SqlCommand("up_distritoListar", cone))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@codigoDepartamento", SqlDbType.VarChar).Value = codDepartamento;
                        cmd.Parameters.Add("@codigoProvincia", SqlDbType.VarChar).Value = codProvincia;
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    Distrito obj = new Distrito();
                                    obj.codigoDistrito = dr.GetString(0);
                                    obj.nombreDistrito = dr.GetString(1);
                                    lista.Add(obj);
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
        public List<TipoDocumento> tipoDocListar()
        {
            try
            {
                List<TipoDocumento> lista = new List<TipoDocumento>();
                using (SqlConnection cone = new SqlConnection(cadena))
                {
                    cone.Open();
                    using (SqlCommand cmd = new SqlCommand("up_tipoDocumentoListar", cone))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    TipoDocumento obj = new TipoDocumento();
                                    obj.codiDocumento = dr.GetInt16(0);
                                    obj.descripcion = dr.GetString(1);
                                    lista.Add(obj);
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
            }
        }

        public Boolean usuarioRegistrar(Persona obj)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("up_UsuarioRegistrar", connection))
                    {
                        cmd.Parameters.AddWithValue("@nombre", obj.nombrePersona);
                        cmd.Parameters.AddWithValue("@apePaterno", obj.apePaterno);
                        cmd.Parameters.AddWithValue("@apeMaterno", obj.apeMaterno);
                        cmd.Parameters.AddWithValue("@nacionalidad", obj.nacionalidad);
                        cmd.Parameters.AddWithValue("@tipoDocumento", obj.tipoDocumento);
                        cmd.Parameters.AddWithValue("@numeroDocumento", obj.nroDocumento);
                        cmd.Parameters.AddWithValue("@sexo", obj.sexo);
                        cmd.Parameters.AddWithValue("@fechaNacimiento", obj.fechaNacimiento);
                        cmd.Parameters.AddWithValue("@email", obj.correo);
                        //cmd.Parameters.AddWithValue("@telefono", obj.telefono);
                        //cmd.Parameters.AddWithValue("@celular", obj.celular);
                        //cmd.Parameters.AddWithValue("@direccion", obj.direccion);
                        //cmd.Parameters.AddWithValue("@pais", obj.pais);
                        //cmd.Parameters.AddWithValue("@ciudad", obj.ciudad);
                        //cmd.Parameters.AddWithValue("@codDepartamento", obj.codDepartamento);
                        //cmd.Parameters.AddWithValue("@codProvincia", obj.codProvincia);
                        //cmd.Parameters.AddWithValue("@codDistrito", obj.codDistrito);
                        //cmd.Parameters.AddWithValue("@ubigeoId", obj.idubigeo);
                        cmd.Parameters.AddWithValue("@nombreususario", obj.nombreUsuario);
                        cmd.Parameters.AddWithValue("@contrasena", obj.contrasena);

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Boolean usuarioExisteValidar(String usuario)
        {
            try
            {
                Boolean resultado = false;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("up_validarUsuario", connection))
                    {
                        cmd.Parameters.AddWithValue("@nomUsuario", usuario);
                        cmd.CommandType = CommandType.StoredProcedure;
                        resultado = (Boolean)cmd.ExecuteScalar();
                        connection.Close();
                        return resultado;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public Boolean documentoExisteValidar(String documento)
        {
            try
            {
                Boolean resultado = false;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("up_documentoExisteValidar", connection))
                    {
                        cmd.Parameters.AddWithValue("@nroDocumento", documento);
                        cmd.CommandType = CommandType.StoredProcedure;
                        resultado = (Boolean)cmd.ExecuteScalar();
                        connection.Close();
                        return resultado;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<Persona> usuarioConsultar(String usuario)
        {
            try
            {
                List<Persona> lista = new List<Persona>();
                using (SqlConnection cone = new SqlConnection(cadena))
                {
                    cone.Open();
                    using (SqlCommand cmd = new SqlCommand("up_usuarioConsultar", cone))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    Persona obj = new Persona();
                                    obj.nombreUsuario = dr.GetString(0);
                                    obj.nombrePersona = dr.GetString(1);
                                    obj.apePaterno = dr.GetString(2);
                                    obj.apeMaterno = dr.GetString(3);
                                    obj.contrasena = dr.GetString(4);
                                    obj.correo = dr.GetString(5);
                                    obj.sexo = dr.GetInt16(6);
                                    obj.nacionalidad = dr.GetInt16(7);
                                    obj.tipoDocumento = dr.GetInt16(8);
                                    obj.nroDocumento = dr.GetString(9);
                                    obj.telefono = dr.GetString(10);
                                    obj.celular = dr.GetString(11);
                                    obj.fechaNacimiento = dr.GetDateTime(12);
                                    obj.pais = dr.GetString(13);
                                    obj.codDepartamento = dr.GetString(14);
                                    obj.codProvincia = dr.GetString(15);
                                    obj.codDepartamento = dr.GetString(16);
                                    obj.ciudad = dr.GetString(17);
                                    obj.direccion = dr.GetString(18);
                                    lista.Add(obj);
                                }
                            }
                            dr.Dispose();
                        }
                    }
                    cone.Close();
                    return lista;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        // EGV
        public Persona Login(string usuario, string contrasena)
        {
            try
            {
                Persona login = new Persona();
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("dbo.pr_Login", connection))
                    {
                        cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                        cmd.Parameters.Add("@contrasena", SqlDbType.VarChar).Value = contrasena;
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    login.usuarioid = dr.GetInt32(0);
                                    login.nombreUsuario = dr.GetString(1);
                                    login.nombrePersona = dr.GetString(2);
                                    login.apePaterno = dr.GetString(3);
                                    login.PerfilId = dr.GetInt32(4);
                                    login.DescPerfil = dr.GetString(5);

                                    break;
                                }
                            }
                            dr.Dispose();
                        }
                    }
                    connection.Close();
                    return login;
                }
            }
            catch (Exception ex)
            {


            }
            return null;
        }

        public int habilitarCliente(string usuario)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("pr_habilitarCliente", connection))
                    {
                        cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
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
