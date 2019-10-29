using System.Collections.Generic;

namespace OpenClosed_1.Data.Model
{
    public class User : IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }

        private readonly ICollection<Order> _orders;

        public User()
        {
            _orders = new HashSet<Order>();
        }

        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }

        public decimal GetTotalSum()
        {
            decimal sum = 0;
            foreach (var order in _orders)
            {
                switch (order.Type)
                {
                    case OrderType.Normal:
                        sum += order.Price * order.Quantity;
                        break;
                    case OrderType.Discount:
                        sum += (order.Price * order.Quantity) * (decimal)0.9;
                        break;
                    case OrderType.Urgent:
                        sum += (order.Price * order.Quantity) * (decimal)1.2;
                        break;
                }
            }
            return sum;
        }
    }
}
