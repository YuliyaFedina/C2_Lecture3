namespace Liskov_1.Model
{
    public class Order : PlacedOrder
    {
        public override decimal GetSum()
        {
            return Price * Quantity;
        }
    }
}
