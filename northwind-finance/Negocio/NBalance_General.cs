﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using northwind_finance.datos;
using System.Data;


namespace northwind_finance.Negocio
{
    class NBalance_General
    {
        public static DataTable BG()
        {
            return new DBalance_General().BG();
        }
    }
}
