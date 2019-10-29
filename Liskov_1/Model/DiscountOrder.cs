namespace Liskov_1.Model
{
    public class DiscountOrder : Order
    {
        public override decimal GetSum()
        {
            return (Price * Quantity) * (decimal)0.9;
        }
    }
}
