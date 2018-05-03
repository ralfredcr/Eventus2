using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Eventus
{
    public class ReservaDetalleBE
    {
        public int reservaid { get; set; }
        public string zona { get; set; }
        public int cantidad { get; set; }
        public decimal precioUnit { get; set; }
        public decimal subTotal { get; set; }
    }
}
