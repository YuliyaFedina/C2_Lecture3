namespace Liskov_1.Model
{
    public class PlaсedOrder : Order
    {
        public virtual decimal GetSum()
        {
            return Price * Quantity;
        }
    }
}