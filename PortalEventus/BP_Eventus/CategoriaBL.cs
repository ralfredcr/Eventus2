using BA_Eventus;
using BE_Eventus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP_Eventus
{
    public class CategoriaBL
    {
        CategoriaDAO interfac = new CategoriaDAO();
        public List<CategoriaBE> LstCategoria()
        {
            return interfac.LstCategoria();
        }

    }
}
