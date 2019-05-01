using System;
using System.ComponentModel.DataAnnotations;

namespace BullSheepFood.Models
{
    public class Diet
    {
        [Key]
        public int DietId { get; set; }
        public DateTime Date { get; set; }
        public double WeightGram { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }

        public int? ProductId { get; set; }
        public Product Product { get; set; }

        public int? TypeMealId { get; set; }
        public TypeMeal TypeMeal { get; set; }
    }
}
