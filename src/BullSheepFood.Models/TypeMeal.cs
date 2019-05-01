using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BullSheepFood.Models
{
    public class TypeMeal
    {
        [Key]
        public int TypeMealId { get; set; }
        public string Name { get; set; }

        public ICollection<Diet> Diet { get; set; }

    }
}
