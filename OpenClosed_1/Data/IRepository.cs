using OpenClosed_1.Data.Model;

namespace OpenClosed_1.Data.Data
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        void Add(TEntity contact);

        void Remove(TEntity contact);

        TEntity GetById(long id);

        TEntity[] GetAll();
    }
}
