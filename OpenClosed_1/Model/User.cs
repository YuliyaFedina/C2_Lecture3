using System.Collections.Generic;
using System.Linq;

namespace OpenClosed_1.Data.Model
{
    public class User : IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }

        private readonly ICollection<Order.OrderBase> _orders;

        public User()
        {
            _orders = new HashSet<Order.OrderBase>();
        }

        public void AddOrder(Order.OrderBase order)
        {
            _orders.Add(order);
        }

        public decimal GetTotalSum()
        {
            return _orders.Sum(order => order.GetSum());
        }
    }
}
