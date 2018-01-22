using System;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class AggregateRepository<T> : IAggregateRepository<T> where T : Aggretate
    {
        private readonly DatabaseContext _databaseContext;

        internal AggregateRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<T> FindByExternalId(Guid externalId)
        {
            return await _databaseContext.Set<T>().SingleOrDefaultAsync(_ => _.ExternalId == externalId);
        }

        public async Task Add(T aggregate)
        {
            await _databaseContext.Set<T>().AddAsync(aggregate);
        }

        public async Task Commit()
        {
            await _databaseContext.SaveChangesAsync();
        }
    }
}