using BA_Eventus;
using BE_Eventus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP_Eventus
{
    public class OpcionBL
    {
        OpcionDAO interf = new OpcionDAO();

        public List<OpcionBE> AccesoPerfil(int PerfilId)
        {
            return interf.AccesoPerfil(PerfilId);
        }
    }
}
