using System;
using Common;

namespace Groups
{
    public class TenantUser
    {
        // TODO: Ska den vara där?
        public Guid TenantId { get; set; }
        public Guid UserId { get; set; }
        public TenantRole Role { get; set; }
    }
}
