using BA_Eventus;
using BE_Eventus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP_Eventus
{
    public class EventoBL
    {
        EventoDAO interfac = new EventoDAO();

        public int InsertEvento(EventoBE obj)
        {
            return interfac.InsertEvento(obj);
        }

        public List<EventoBE> LstEvento(string descripcion)
        {
            return interfac.LstEvento(descripcion);
        }

    }
}
