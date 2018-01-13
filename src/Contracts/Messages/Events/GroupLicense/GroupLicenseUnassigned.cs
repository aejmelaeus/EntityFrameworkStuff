using System;

namespace Contracts.Messages.Events.GroupLicense
{
    public class GroupLicenseUnassigned : Event
    {
        public Guid TenantId { get; set; }
        public Guid GroupId { get; set; }
        public Guid LicenseId { get; set; }
        public Guid ProductId { get; set; }
    }
}
