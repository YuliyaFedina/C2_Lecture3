using System;
using System.Collections.Generic;
using System.Linq;
using SRP_2.Infrastructure;
using SRP_2.Model;

namespace SRP_2.Data
{
    internal class EntityRepository<TEntity> : IRepository<TEntity> where TEntity : IEntity
    {
        private readonly List<TEntity> _storage = new List<TEntity>();
        private readonly FileLogger _logger = new FileLogger();
        public void Add(TEntity contact)
        {
            try
            {
                _storage.Add(contact);
            }
            catch (Exception e)
            {
                _logger.Log(e);
            }
        }

        public void Remove(TEntity contact)
        {
            try
            {
                _storage.Remove(contact);
            }
            catch (Exception e)
            {
                _logger.Log(e);
            }
        }

        public TEntity GetById(long id)
        {
            return _storage.FirstOrDefault(o => o.Id == id);
        }

        public TEntity[] GetAll()
        {
            return _storage.ToArray();
        }
    }
}
