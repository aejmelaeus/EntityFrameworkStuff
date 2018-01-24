namespace Domain.Models
{
    public class GroupMembership : Entity
    {
        public int GroupId { get; private set; }
        public int UserId { get; private set; }
    }
}