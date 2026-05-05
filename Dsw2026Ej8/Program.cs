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
            var problema2 = new Problema2();
            Console.WriteLine(problema2.CrearResumenVenta(1, "Teclado mecánico RGB", 1, 100000));

        }
    }
}
