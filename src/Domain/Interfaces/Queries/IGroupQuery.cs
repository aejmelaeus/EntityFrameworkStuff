using System;
using System.Threading.Tasks;
using Contracts.Queries;

namespace Interfaces.Queries
{
    public interface IGroupQuery
    {
        Task<GroupQueryItem> Execute(Guid groupId);
    }
}
