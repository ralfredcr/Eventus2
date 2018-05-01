using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Eventus
{
    public class Pais
    {
        public int codigoPais { get; set; }
        public String nombrePais { get; set; }
    }
    public class Departamento
    {
        public String codigoDepartamento { get; set; }
        public String nombreDepartamento { get; set; }
    }
    public class Provincia
    {
        public String codigoProvincia { get; set; }
        public String nombreProvincia { get; set; }
    }
    public class Distrito
    {
        public String codigoDistrito { get; set; }
        public String nombreDistrito { get; set; }
    }
}
