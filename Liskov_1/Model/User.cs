using System.Collections.Generic;
using System.Linq;

namespace Liskov_1.Model
{
    public class User : IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }

        private readonly ICollection<PlacedOrder> _orders;

        public User()
        {
            _orders = new HashSet<PlacedOrder>();
        }

        public void AddOrder(PlacedOrder order)
        {
            _orders.Add(order);
        }

        public decimal GetTotalSum()
        {
            return _orders.Sum(order => order.GetSum());
        }
    }
}
