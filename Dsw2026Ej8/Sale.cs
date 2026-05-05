namespace Dsw2026Ej8
{
    public class Sale
    {
        public decimal monto;
        public virtual decimal CalculateTotal()
        {
            return monto;
        }

        public decimal getMonto()
        {
            return monto;
        }

        public void setMonto(decimal value)
        {
            monto = value;
        }
    }
}