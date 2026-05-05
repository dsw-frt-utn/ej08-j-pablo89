using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription,int quantity,decimal unitPrice)
        {
            var resumenAnonimo = new {
                Codigo = productCode,
                Descripcion = productDescription,
                Cantidad = quantity,
                Total = quantity <= 0 ? 0 : quantity*unitPrice
            };

            return $"{resumenAnonimo.Codigo}-{resumenAnonimo.Descripcion}-{resumenAnonimo.Total.ToString("C")}";
        }
    }
}
