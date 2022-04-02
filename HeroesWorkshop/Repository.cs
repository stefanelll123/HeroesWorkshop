using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroesWorkshop
{
    public class Repository<T> where T: Base
    {
        private IList<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public IList<T> Get()
        {
            return items;
        }

        public T GetById(Guid id)
        {
            return items.FirstOrDefault(x => x.Id == id);
        }

        public void Delete(Guid id)
        {
            items.Remove(GetById(id));
        }
    }
}
