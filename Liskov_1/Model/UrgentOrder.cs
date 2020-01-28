namespace Liskov_1.Model
{
    public class UrgentOrder : PlaсedOrder
    {
        public override decimal GetSum()
        {
            return (Price * Quantity) * (decimal)1.2;
        }
    }
}
