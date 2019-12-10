namespace OpenClosed_1.Data.Model.Order
{
    public class UrgentOrder : OrderBase
    {
        public override decimal GetSum()
        {
            return Price * Quantity * (decimal) 1.2;
        }
    }
}