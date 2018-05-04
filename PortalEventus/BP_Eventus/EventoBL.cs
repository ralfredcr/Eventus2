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

        public int UpdateEvento(EventoBE obj)
        {
            return interfac.UpdateEvento(obj);
        }

        public List<EventoBE> LstEvento(string descripcion, string descripcionAdicional, int categoriaid, DateTime fechaInicio)
        {
            return interfac.LstEvento(descripcion, descripcionAdicional, categoriaid, fechaInicio);
        }

        public EventoBE ObtenerEvento(int eventoid)
        {
            return interfac.ObtenerEvento(eventoid);
        }

    }
}
