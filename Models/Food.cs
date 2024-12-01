using System.ComponentModel.DataAnnotations;

namespace FoodRegistryApp1.Models
{
    public class Food
    {
        public int Id { get; set; }  // Primærnøkkel og AutoIncrement (Identity)

        [Required]
        public required string FoodName { get; set; }  // Navn på maten

        public int Calories { get; set; }  // Kalorier per porsjon

        public required string Category { get; set; }  // Matkategori (f.eks. Frukt, Grønnsaker, etc.)
    }
}
