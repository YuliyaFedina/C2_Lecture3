using Interface_1.Model;

namespace Interface_1.Data
{
    internal interface IReadOnlyRepository<out TEntity> where TEntity : IEntity
    {
        TEntity GetById(long id);
        TEntity[] GetAll();
    }
}
