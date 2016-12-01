using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
using DomainModel.Models;

namespace Domain
{

    public class UnitMoq : IUnitOfWork
    {


        public UnitMoq()
        {
          


            ConnectionsRepository = new RepositoryMoq<Connection>();
            ConnectionDefinitionRepository = new RepositoryMoq<ConnectionDefinition>();
            StationsRepository = new RepositoryMoq<Station>();
            TrainsRepository = new RepositoryMoq<Train>();
            UsersRepository = new RepositoryMoq<User>();
            TicketsRepository = new RepositoryMoq<Ticket>();
   
            
        }

        public void Supress(Entity e)
        {
        
        }


        public int EndTransaction()
        {
          
            return 4;
        }

        public void StartTransaction()
        {
           
        }

     
        public void Rollback()
        {
           
        }

        
        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                   // this._context.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
        }

     

        public IRepository<Connection> ConnectionsRepository { get; }
        public IRepository<ConnectionDefinition> ConnectionDefinitionRepository { get; }
        public IRepository<Station> StationsRepository { get; }
        public IRepository<Train> TrainsRepository { get; }
        public IRepository<User> UsersRepository { get; }
        public IRepository<Ticket> TicketsRepository { get; }
    }

    public class RepositoryMoq<T> : IRepository<T> where T : Entity
    {
        private List<T> list=new List<T>();
       
        public void Add(T ob)
        { 
           list.Add(ob);
        }

        public void Atached(T ob)
        {
            
        }

        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
           return list.Where(predicate);
        }

        public IEnumerable<T> Find(Func<T, int, bool> predicate, params string[] included)
        {
           return Find
            (predicate);
        }

        public IEnumerable<T> Find(Func<T, bool> func, params string[] included)
        {
            return Find(func);
        }

        public T Get(int id)
        {
            return list.FirstOrDefault(p => p.Id == id);
        }

        public void Remove(int id)
        {
            list.Remove(Get(id));
        }

        public void Remove(T ob)
        {
            list.Remove(ob);
        }
    }
}
