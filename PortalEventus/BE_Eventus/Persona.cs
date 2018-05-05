using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Eventus
{
    public class Persona
    {
        public String nombrePersona { get; set; }
        public String apePaterno { get; set; }
        public String apeMaterno { get; set; }
        public int sexo { get; set; }
        public String correo { get; set; }
        public String direccion { get; set; }
        public String ciudad { get; set; }
        public int nacionalidad { get; set; }
        public int tipoDocumento { get; set; }
        public String nroDocumento { get; set; }
        public String telefono { get; set; }
        public String celular { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public int idubigeo { get; set; }
        public String pais { get; set; }
        public String codDepartamento { get; set; }
        public String codProvincia { get; set; }
        public String codDistrito { get; set; }
        public String nombreUsuario { get; set; }
        public String contrasena { get; set; }

        public int usuarioid { get; set; }
        public int PerfilId { get; set; }
        public String DescPerfil { get; set; }
    }
    public class Usuario
    {
        public String nombreUsuario { get; set; }
        public String contrasena { get; set; }
    }

    public class TipoDocumento
    {
        public int codiDocumento { get; set; }
        public String descripcion { get; set; }
    }
}
