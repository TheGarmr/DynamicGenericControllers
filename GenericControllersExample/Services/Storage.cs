using System;
using System.Collections.Generic;
using System.Linq;
using GenericControllersExample.Models;

namespace GenericControllersExample.Services
{
    public class Storage<T> where T : Entity
    {
        private readonly Dictionary<Guid, T> _storage = new Dictionary<Guid, T>();

        public IEnumerable<T> GetAll() => _storage.Values;

        public T GetById(Guid id)
        {
            return _storage.FirstOrDefault(x => x.Key == id).Value;
        }

        public void Create(T item)
        {
            if (!_storage.ContainsKey(item.Id))
            {
                var id = Guid.NewGuid();
                item.Id = id;
            }

            _storage[item.Id] = item;
        }

        public void Delete(Guid id)
        {
            if (!_storage.ContainsKey(id))
            {
                _storage.Remove(id);
            }
        }
    }
}
