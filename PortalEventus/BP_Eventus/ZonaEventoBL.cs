using BA_Eventus;
using BE_Eventus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP_Eventus
{
    public class ZonaEventoBL
    {

        ZonaEventoDAO interfac = new ZonaEventoDAO();
        public int InsertEventoZona(ZonaEventoBE obj)
        {
            return interfac.InsertEventoZona(obj);
        }

        public int UpdateEventoZona(ZonaEventoBE obj)
        {
            return interfac.UpdateEventoZona(obj);
        }

        public List<ZonaEventoBE> ObtenerEventoZona(int eventoid)
        {
            return interfac.ObtenerEventoZona(eventoid);
        }
    }
}
