using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Eventus
{
    public class EventoBE
    {
        public int eventoid { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public string descripcionAdicional { get; set; }
        public int categoriaid { get; set; }
        public int cantidadMax { get; set; }
        public byte[] RutaImagen { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public int estado { get; set; }
        public bool activo { get; set; }
        public int usuarioCreacion { get; set; }
        public int usuarioActualiza { get; set; }
        public DateTime fechaRegistro { get; set; }
        public DateTime fechaActualiza { get; set; }
        public string descripcionCateg { get; set; }
        public string descripcionEvento { get; set; }

    }
}
