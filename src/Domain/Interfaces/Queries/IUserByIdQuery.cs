using System;
using System.Threading.Tasks;
using Contracts.Queries;

namespace Interfaces.Queries
{
    public interface IUserByIdQuery
    {
        Task<UserQueryItem> Execute(Guid userId);
    }
}