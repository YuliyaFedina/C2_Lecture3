﻿using Liskov_1.Model;

namespace Liskov_1.Data
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        void Add(TEntity contact);

        void Remove(TEntity contact);

        TEntity GetById(long id);

        TEntity[] GetAll();
    }
}
