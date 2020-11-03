using System;
using System.ComponentModel.DataAnnotations;

namespace hotchocolatedemo.Data
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public DateTime LastUpdated { get; set; }
        public Manufacturer? PrimaryManufacturer { get; set; }
    }
}