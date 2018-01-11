namespace Database.Entitites
{
    public class TenantUser
    {
        public int Id { get; set; }

        public Tenant Tenant { get; set; }
        public User User { get; set; }
        public Role Role { get; set; }
    }
}
