using System;

namespace Contracts.Messages.Events.SingleLicense
{
    public class SingleLicenseAssigned : Event
    {
        public Guid TenantId { get; set; }
        public Guid UserId { get; set; }
        public Guid LicenseId { get; set; }
        public Guid ProductId { get; set; }
    }
}
