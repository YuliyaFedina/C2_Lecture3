namespace OpenClosed_1.Data.Model.Order
{
    public class DiscountOrder : OrderBase
    {
        public override decimal GetSum()
        {
            return Price * Quantity * (decimal) 0.9;
        }
    }
}

