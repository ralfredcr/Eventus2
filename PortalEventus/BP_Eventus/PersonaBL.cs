using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA_Eventus;
using BE_Eventus;

namespace BP_Eventus
{
    public class PersonaBL
    {

        public List<Pais> paisListar()
        {
            try
            {
                PersonaDAO objPersona = new PersonaDAO();
                return objPersona.paisListar();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<Departamento> departamentoListar()
        {
            try
            {
                PersonaDAO objPersona = new PersonaDAO();
                return objPersona.departamentoListar();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<Provincia> provinciaListar(String codDepartamento)
        {
            try
            {
                PersonaDAO objPersona = new PersonaDAO();
                return objPersona.provinciaListar(codDepartamento);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Distrito> distritoListar(String codDepartamento, String codProvincia)
        {
            try
            {
                PersonaDAO objPersona = new PersonaDAO();
                return objPersona.distritoListar(codDepartamento, codProvincia);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<TipoDocumento> tipoDocListar()
        {
            try
            {
                PersonaDAO objPersona = new PersonaDAO();
                return objPersona.tipoDocListar();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public Boolean usuarioRegistrar(Persona obj)
        {
            try
            {
                PersonaDAO objPersona = new PersonaDAO();
                return objPersona.usuarioRegistrar(obj);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public Boolean usuarioExisteValidar(String usuario)
        {
            PersonaDAO objPersona = new PersonaDAO();
            return objPersona.usuarioExisteValidar(usuario);
        }

        public Boolean documentoExisteValidar(String documento)
        {
            PersonaDAO objPersona = new PersonaDAO();
            return objPersona.documentoExisteValidar(documento);
        }

        public List<Persona> usuarioConsultar(String usuario)
        {
            PersonaDAO objPersona = new PersonaDAO();
            return objPersona.usuarioConsultar(usuario);
        }
   }
}
