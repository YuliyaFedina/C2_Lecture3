namespace Liskov_1.Model
{
    public interface IPlacedOrder : ITemplateOrder
    {
        decimal GetSum();
    }
}