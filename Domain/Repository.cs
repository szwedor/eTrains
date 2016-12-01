using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Sockets;
using DomainModel;

namespace Domain
{

    public class Repository<T>:IRepository<T> where T : Entity
    {
       
        protected readonly IDbSet<T> Set;

        public Repository(DbContext context)
        {
            this.Set = context.Set<T>();
         
        }

        
        public void Atached(T ob)
        {
            Set.Attach(ob);
        }
        public void Add(T ob)
        {
            Set.Add(ob);
        }

        public void Remove(T ob)
        {
            Set.Remove(ob);
        }

        public void Remove(int id)
        {
            Set.Remove((Set.Find(id)));
        }


        public T Get(int id)
        {
            return Set.Find(id);
        }

        public IEnumerable<T> Find(Func<T, bool> func)
        {
            return Set.Where(func).ToList();
        }

        public IEnumerable<T> Find(Func<T,int, bool> func, params string[] included)
        {
            IQueryable<T> s = Set;
            foreach (string str in included)
                s = s.Include(str);

            return s.Where(func);
        }
        public IEnumerable<T> Find(Func<T, bool> func,params string[] included)
        {
            IQueryable<T> s = Set;
            foreach (string str in included)
                s=s.Include(str);

            return s.Where(func);
        }
    }
}
