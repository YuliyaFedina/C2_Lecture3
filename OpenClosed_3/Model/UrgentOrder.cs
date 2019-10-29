namespace OpenClosed_3.Data.Model
{
    public class UrgentOrder : Order
    {
        public override decimal GetSum()
        {
            return (Price * Quantity) * (decimal)1.2;
        }
    }
}
