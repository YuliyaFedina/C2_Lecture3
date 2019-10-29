namespace OpenClosed_3.Data.Model
{
    public class DiscountOrder : Order
    {
        public override decimal GetSum()
        {
            return (Price * Quantity) * (decimal)0.9;
        }
    }
}
