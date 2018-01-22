using System;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface IAggregateRepository<T> 
    {
        Task<T> FindByExternalId(Guid externalId);
        Task Add(T aggregate);
        Task Commit();
    }
}