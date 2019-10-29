using DependencyInversion_2.Model;

namespace DependencyInversion_2.Data
{
    internal interface IRepository<TEntity> where TEntity : IEntity
    {
        void Add(TEntity contact);

        void Remove(TEntity contact);

        TEntity GetById(long id);

        TEntity[] GetAll();
    }
}
