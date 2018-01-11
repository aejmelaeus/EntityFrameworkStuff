using System;

namespace Database.Entitites
{
    public class Product
    {
        public int Id { get; set; }
        public Guid ExternalId { get; set; }

        public string Name { get; set; }
    }
}
