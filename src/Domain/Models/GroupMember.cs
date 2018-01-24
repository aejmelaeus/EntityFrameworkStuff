namespace Domain.Models
{
    public class GroupMember
    {
        public int Id { get; private set; }
        public int GroupId { get; private set; }
        public int UserId { get; private set; }
    }
}