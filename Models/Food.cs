using System.ComponentModel.DataAnnotations;

namespace FoodRegistryApp1.Models
{
    public class Food
    {
        public int Id { get; set; }

        [Required]
        public string FoodName { get; set; }

        [Required]
        public int Calories { get; set; }

        public int Protein { get; set; } // Legg til proteiner
        public int Fat { get; set; } // Legg til fett
        public int Carbs { get; set; } // Legg til karbohydrater
        public int Fiber { get; set; } // Legg til fiber
        public int Sugar { get; set; } // Legg til sukker

        public string Category { get; set; } // Kategorier kan være f.eks. 'Frukt', 'Grønnsaker', etc.
    }
}
