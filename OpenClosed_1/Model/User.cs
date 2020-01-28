using System.Collections.Generic;
using OpenClosed_1.Data.Services;

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

        public decimal GetTotalSum(IOrderCalculator calculator)
        {
            decimal sum = 0;
            foreach (var order in _orders)
            {
                sum += calculator.CalculateSum(order);
            }
            return sum;
        }
    }
}
