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
            var group = await _context.Groups
                .Include(_ => _.Members)
                .Include(_ => _.CreatedBy)
                .SingleOrDefaultAsync(_ => _.ExternalId == externalId);

            if (group == default(Group))
            {
                return null;
            }

            return new GroupQueryItem
            {
                CreatedByUserDisplayName = group.CreatedBy.DisplayName,
                Name = group.Name,
                CreatedByUserId = group.CreatedBy.ExternalId,
                Id = group.ExternalId,
                Members = null // TODO!
            };
        }
    }
}
