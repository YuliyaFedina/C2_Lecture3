namespace Liskov_1.Model
{
    public class DiscountOrder : PlaсedOrder
    {
        public override decimal GetSum()
        {
            return (Price * Quantity) * (decimal)0.9;
        }
    }
}
