namespace Liskov_1.Model
{
    public interface ITemplateOrder : IEntity
    {
        int OrderNumber { get; set; }
        int Quantity { get; set; }
        decimal Price { get; set; }
        long UserId { get; set; }
    }
}