using System;
using System.ComponentModel.DataAnnotations;

namespace BullSheepFood.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public long EnergyKcal { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Carbohydrate { get; set; }
        public string ImageUri { get; set; }
    }
}
