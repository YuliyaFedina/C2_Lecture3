using Interface_1.Model;

namespace Interface_1.Data
{
    internal interface IRepository<TEntity> : IReadOnlyRepository<TEntity> where TEntity : IEntity
    {
        void Add(TEntity contact);

        void Remove(TEntity contact);
    }
}
