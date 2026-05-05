using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema3
    {
        public string CompararCopias(int originalValue,Product product)
        {
            int copiaValorLocal = originalValue;
            copiaValorLocal++;

            Product copiaDeProductLocal = product;

            copiaDeProductLocal.CambiarDescripcion("descripcion nueva");

            return $"{originalValue}-{copiaValorLocal}-{copiaDeProductLocal.Description}";

        }
    }
}
