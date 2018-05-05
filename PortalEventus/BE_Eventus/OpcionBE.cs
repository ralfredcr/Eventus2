using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Eventus
{
    public class OpcionBE
    {
        public int OpcionesId { get; set; }
        public string DescOpciones { get; set; }
        public string URL { get; set; }
        public string PadreId { get; set; }
        public int Orden { get; set; }
        public string Icono { get; set; }
    }
}
