using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BullSheepFood.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public ICollection<Diet> Diet { get; set; }

    }
}
