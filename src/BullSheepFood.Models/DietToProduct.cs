using System.ComponentModel.DataAnnotations;

namespace BullSheepFood.Models
{
    public class DietToProduct
    {
        [Key]
        public int DietToProductId { get; set; }
        public double WeightGram { get; set; }

        public int? ProductId { get; set; }
        public Product Product {  get; set;  }

        public int? DietId { get; set; }
        public Diet Diet { get; set; }
    }
}
