using System;
using OpenClosed_1.Data.Model;

namespace OpenClosed_1.Data.Services
{
    public class OrderCalculator: IOrderCalculator
    {
        public decimal CalculateSum(IOrder order)
        {
            switch (order.Type)
            {
                case OrderType.Normal:
                    return  order.Price * order.Quantity;
                case OrderType.Discount:
                    return (order.Price * order.Quantity) * (decimal)0.9;
                case OrderType.Urgent:
                    return (order.Price * order.Quantity) * (decimal)1.2;
                default: throw new ArgumentOutOfRangeException(nameof(order), "Order must have existing OrderType");
            }
        }
    }
}