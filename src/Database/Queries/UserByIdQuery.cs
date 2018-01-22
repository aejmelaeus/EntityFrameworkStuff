//using System;
//using System.Linq;
//using System.Threading.Tasks;
//using Contracts.Queries;
//using Interfaces.Queries;
//using Microsoft.EntityFrameworkCore;

//namespace Database.Queries
//{
//    public class UserByIdQuery : IUserByIdQuery
//    {
//        private readonly DatabaseContext _context;

//        public UserByIdQuery(DatabaseContext context)
//        {
//            _context = context;
//        }

//        public async Task<UserQueryItem> Execute(Guid userId)
//        {
//            var user = await _context.Users
//                .Include(_ => _.TenantUsers)
//                .SingleOrDefaultAsync(_ => _.Id == userId);

//            if (user == default(User))
//            {
//                return null;
//            }

//            return new UserQueryItem
//            {
//                DisplayName = user.DisplayName,
//                Email = user.Email,
//                Tenants = user.TenantUsers.Select(_ => new UserQueryItem.Tenant
//                {
//                    Id = _.UserId,
//                    Name = _.Tenant.Name,
//                    Role = _.Role
//                })
//            };
//        }
//    }
//}