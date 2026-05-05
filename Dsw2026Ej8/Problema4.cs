using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            double promedio = 0;
            int contadorNotas = 0;
            if (nota1 == null && nota2 == null && nota3 == null)
            {
                return 0;
            }

            if (nota1.HasValue && nota1 >= 0)
            {
                promedio += nota1.Value;
                contadorNotas++;
            }
            if (nota2.HasValue && nota2 >= 0)
            {
                promedio += nota2.Value;
                contadorNotas++;
            }
            if (nota3.HasValue && nota3 >= 0)
            {
                promedio += nota3.Value;
                contadorNotas++;
            }

            return contadorNotas > 0 ? promedio / contadorNotas : 0;

        }

    }
}
