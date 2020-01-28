using OpenClosed_1.Data.Model;

namespace OpenClosed_1.Data.Services
{
    public interface IOrder
    {
        int Quantity { get; }

        decimal Price { get; }

        OrderType Type { get; }
    }
}