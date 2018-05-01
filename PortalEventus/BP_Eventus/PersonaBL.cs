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
    }
}
