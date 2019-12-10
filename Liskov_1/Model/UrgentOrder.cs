namespace Liskov_1.Model
{
    public class UrgentOrder : PlacedOrder
    {
        public override decimal GetSum()
        {
            return (Price * Quantity) * (decimal)1.2;
        }
    }
}
