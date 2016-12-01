using System;
using System.Data.Common;
using System.Data.Entity;
using DomainModel.Models;

namespace DomainModel
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Connection> ConnectionsRepository { get; }
        IRepository<ConnectionDefinition> ConnectionDefinitionRepository { get; }
        IRepository<Station> StationsRepository { get; }
        IRepository<Train> TrainsRepository { get; }
        IRepository<User> UsersRepository { get; }
        IRepository<Ticket> TicketsRepository { get; }
        void Rollback();
        
        int EndTransaction();
        void StartTransaction();
    } 
 
}
