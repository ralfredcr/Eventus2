﻿using BA_Eventus;
using BE_Eventus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP_Eventus
{
    public class ReservaBL
    {
        ReservaDAO interfac = new ReservaDAO();

        public int InsertReserva(ReservaBE obj)
        {
            return interfac.InsertReserva(obj);
        }
    }
}
