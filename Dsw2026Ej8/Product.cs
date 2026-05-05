namespace Dsw2026Ej8
{
    public class Product
    {
        public string Description;

        public void CambiarDescripcion(string newDescripcion)
        {
            Description = newDescripcion;
        }

        public string getDescription()
        {
            return Description;
        }

        public void setDescription(string newDescripcion)
        {
            Description = newDescripcion;
        }

    }
}