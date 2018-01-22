//using System;
//using System.Threading.Tasks;
//using Contracts.Queries;
//using Interfaces.Queries;

//namespace Database.Queries
//{
//    public class GroupByIdQuery : IGroupQuery
//    {
//        private readonly DatabaseContext _context;

//        public GroupByIdQuery(DatabaseContext context)
//        {
//            _context = context;
//        }

//        public async Task<GroupQueryItem> Execute(Guid groupId)
//        {
//            var group = await _context.Groups
//                .Include(_ => _.Members)
//                .SingleOrDefaultAsync(_ => _.Id == groupId);

//            if (group == default(Group))
//            {
//                return null;
//            }

//            return new GroupQueryItem
//            {
//                CreatedByUserDisplayName = group.CreatedByUserDisplayName,
//                Name = group.Name,
//                CreatedByUserId = group.CreatedByUserId,
//                Id = group.Id,
//                Members = null // TODO!
//            };
//        }
//    }
//}
