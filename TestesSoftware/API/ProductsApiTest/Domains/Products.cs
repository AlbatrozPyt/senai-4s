using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsApiTest.Domains
{

    [Table("Products")]

    public class Products
    {
        [Key]
        public Guid IdProduct { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(255)")]
        public string? Nome { get; set; }

        [Column(TypeName = "DECIMAL")]
        public decimal Price { get; set; }
    }
}
