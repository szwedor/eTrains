using System;
using System.Data.Entity;
using System.Threading;
using System.Threading.Tasks;
using DomainModel;
using DomainModel.Models;

namespace Domain
{

    public class UnitOfWork : IUnitOfWork
    {
        private bool inner;
        private readonly Context _context;
        private DbContextTransaction transaction;
        public UnitOfWork()
        {   _context = new Context();


         ConnectionsRepository =new Repository<Connection>(_context);
         ConnectionDefinitionRepository =new Repository<ConnectionDefinition>(_context);
         StationsRepository =new Repository<Station>(_context);
         TrainsRepository =new Repository<Train>(_context);
         UsersRepository=new Repository<User>(_context);
         TicketsRepository =new Repository<Ticket>(_context);
           
            
        }

        public void Supress(Entity e)
        {
            _context.Entry(e).State = EntityState.Modified;
        }

        
        public void Rollback()
        {
            transaction.Rollback();
            transaction = null;
        }

       
        public int EndTransaction()
        {
           
            if (inner==false&&transaction != null)
            {
                var x = _context.SaveChanges();
                transaction.Commit();
                return x;
            }
            if (inner==true)
                inner = false;
            return _context.SaveChanges();
        }

        public void StartTransaction()
        {
            if (transaction!=null) inner = true;
            else
            {
                transaction = _context.Database.BeginTransaction();
            }
        }


        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    this._context.Dispose();
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
}
