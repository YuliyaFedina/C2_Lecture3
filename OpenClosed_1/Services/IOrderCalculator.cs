namespace OpenClosed_1.Data.Services
{
    public interface IOrderCalculator
    {
        decimal CalculateSum(IOrder order);
    }
}