using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Article { get; set; }  
        public string? Name { get; set; }
        public string? Brand { get; set; }
        public string? Type { get; set; }
        public decimal? Price { get; set; }
        public decimal? Weight { get; set; }
        public int? Count { get; set; }

    }
}
