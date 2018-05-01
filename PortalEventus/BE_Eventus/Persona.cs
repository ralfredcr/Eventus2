using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Eventus
{
    class Persona
    {
        public String nombrePersona { get; set; }
        public String apePersona { get; set; }
        public int sexo { get; set; }
        public String correo { get; set; }
        public int nacionalidad { get; set; }
        public int tipoDocumento { get; set; }
        public String nroDocumento { get; set; }
        public String telefono { get; set; }
        public String celular { get; set; }
        public String fechaNacimiento { get; set; }
        public int pais { get; set; }
        public int departamento { get; set; }
        public int provincia { get; set; }
        public int distrito { get; set; }
    }
    class Ususario
    {
        public String nombreUsuario { get; set; }
        public String contrasena { get; set; }
    }
}
