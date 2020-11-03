using System.ComponentModel.DataAnnotations;

namespace hotchocolatedemo.Data
{
    public class Manufacturer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }
    }
}