using BA_Eventus;
using BE_Eventus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP_Eventus
{
    class ReservaDetalleBL
    {
        ReservaDetalleDAO interfac = new ReservaDetalleDAO();
        public int InsertReservaDetalle(ReservaDetalleBE obj)
        {
            return interfac.InsertReservaDetalle(obj);
        }

    }
}
