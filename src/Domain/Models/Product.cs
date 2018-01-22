using System;

namespace Domain.Models
{
    public class Product
    {
        public int Id { get; private set; }
        public Guid ExternalId { get; private set; }
        public string Name { get; private set; }
        public string Url { get; private set; }
    }
}
