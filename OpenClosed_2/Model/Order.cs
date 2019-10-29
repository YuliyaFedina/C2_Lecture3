using System;

namespace OpenClosed_2.Data.Model
{
    public class Order : IEntity
    {
        public long Id { get; set; }

        public int OrderNumber { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public long UserId { get; set; }

        public OrderType Type { get; set; }

        public decimal GetSum()
        {
            switch (Type)
            {
                case OrderType.Normal:
                    return Price * Quantity;
                case OrderType.Discount:
                    return (Price * Quantity) * (decimal)0.9;
                case OrderType.Urgent:
                    return (Price * Quantity) * (decimal)1.2;
            }
            throw new NotSupportedException();
        }
    }
}
