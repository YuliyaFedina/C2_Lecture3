﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SRP_1.Model;

namespace SRP_1.Data
{
    internal class EntityRepository<TEntity> : IRepository<TEntity> where TEntity : IEntity
    {
        private readonly List<TEntity> _storage = new List<TEntity>();

        public void Add(TEntity contact)
        {
            try
            {
                _storage.Add(contact);
            }
            catch (Exception e)
            {
                File.AppendAllText("log.txt", e.Message);
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
                File.AppendAllText("log.txt", e.Message);
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
