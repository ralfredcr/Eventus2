using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_Eventus
{
    class PersonaDAO
    {
        static readonly string cadena = ConfigurationManager.ConnectionStrings["cnEventus"].ConnectionString;
    }
}
