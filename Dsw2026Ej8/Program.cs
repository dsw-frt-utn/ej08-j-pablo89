using System.ComponentModel;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // OPRUEBA EJERCICIO 1.
            //ProductHelper ph = new ProductHelper();
            //Console.WriteLine(ph.ObtenerEtiquetaProducto(1, "Coca Zero 2.5", 4500));

            // PRUEBA EJERCICIO 2.
            //var problema2 = new Problema2();
            //Console.WriteLine(problema2.CrearResumenVenta(1, "Teclado mecánico RGB", 1, 100000));

            // PRUEBA EJERCICIo 3.
            //var problema3 = new Problema3();
            //Console.WriteLine(problema3.CompararCopias(1, new Product { Description = "Primera Descripcion" }));

            // PRUEBA EJERCICIO 4.
            //var problema4 = new Problema4();
            //Console.WriteLine(problema4.CalcularPromedio(null, 8, 9));

            // PRUEBA EJERCICIO 5.
            var problema5 = new Problema5();
            Sale s = new WholesaleSale { monto = 1000 };
            Sale s2 = new RetailSale { monto = 1000 };
            Console.WriteLine(problema5.ObtenerImporteFinal(s));
            Console.WriteLine(problema5.ObtenerImporteFinal(s2));







        }
    }
}
