using System;
using System.Collections.Generic;
using System.IO;

namespace DomainModel
{
    public interface IRepository<T> where T:Entity
    {
       

        void Add(T ob);
        void Remove(T ob);
        void Remove(int id);
        T Get(int id);
        IEnumerable<T> Find(Func<T, bool> predicate);
        IEnumerable<T> Find(Func<T, bool> func, params string[] included);
        void Atached(T ob);
        IEnumerable<T> Find(Func<T, int,bool> predicate, params string[] included);
    }
   
}
