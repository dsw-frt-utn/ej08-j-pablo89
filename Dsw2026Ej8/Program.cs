namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductHelper ph = new ProductHelper();
            Console.WriteLine(ph.ObtenerEtiquetaProducto(1, "Coca Zero 2.5", 4500));
        }
    }
}
