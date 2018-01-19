using System;
using System.ComponentModel.DataAnnotations;

namespace Database.Entitites
{
    internal class Product
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(128)]
        public string Name { get; set; }
    }
}
