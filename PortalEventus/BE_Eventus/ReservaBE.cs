using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Eventus
{
    public class ReservaBE
    {
        public int eventoid { get; set; }
        public string titulo { get; set; }
        public string descripcionEvento { get; set; }
        public int categoriaid { get; set; }
        public int cantidadMax { get; set; }
        public int TipoClienteId { get; set; }
        public byte[] RutaImagen { get; set; }
        public string descripcionCategoria { get; set; }

    }
}
