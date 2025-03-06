using System.ComponentModel.DataAnnotations.Schema;

namespace Entity_Framework_Core.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
    }

}
