using System.Collections.Generic;
using System.Linq;
using HomeWork.Infrastructure;
using HomeWork.Model;

namespace HomeWork.Data
{
    internal class EntityRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly List<TEntity> _storage = new List<TEntity>();

        public void Add(TEntity contact)
        {
            _storage.Add(contact);
        }

        public void Remove(TEntity contact)
        {
            _storage.Remove(contact);
        }

        public TEntity GetById(long id)
        {
            return _storage.First(o => o.Id == id);
        }

        public TEntity[] GetAll()
        {
            return _storage.ToArray();
        }
    }
}
