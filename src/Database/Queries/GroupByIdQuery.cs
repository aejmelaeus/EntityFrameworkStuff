using System;
using System.Threading.Tasks;
using Contracts.Queries;
using Domain.Models;
using Interfaces.Queries;
using Microsoft.EntityFrameworkCore;

namespace Database.Queries
{
    public class GroupByIdQuery : IGroupQuery
    {
        private readonly DatabaseContext _context;

        internal GroupByIdQuery(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<GroupQueryItem> Execute(Guid externalId)
        {
            return null;
        }
    }
}
