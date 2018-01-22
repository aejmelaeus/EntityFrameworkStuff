using System;

namespace Domain.Models
{
    public class Product : Aggretate
    {
        public string Name { get; private set; }
        public string Url { get; private set; }

        public Product(Guid extenrnalId) : base(extenrnalId)
        {
            // TODO!
        }
    }
}
