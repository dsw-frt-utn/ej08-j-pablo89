using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class WholesaleSale: Sale
    {
        public override decimal CalculateTotal()
        {
            decimal descuento = monto * 0.1m;
            decimal total = monto - descuento;
            return total;
        }
    }
}
