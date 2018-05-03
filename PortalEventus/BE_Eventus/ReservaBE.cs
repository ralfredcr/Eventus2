using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Eventus
{
    public class ReservaBE
    {
        public int reservaid { get; set; }
        public int eventoid { get; set; }
        public string importeTotal { get; set; }
        public string usuarioid { get; set; }
        public int estado { get; set; }
        public int usuarioCreacion { get; set; }
        public int usuarioActualiza { get; set; }
        public DateTime fechaRegistro { get; set; }
        public DateTime fechaActualiza { get; set; }
    }
}
