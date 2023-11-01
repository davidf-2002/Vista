using System.ComponentModel.DataAnnotations;

namespace Vista.App.Data
{
    public class TrainerCategory
    {
        // Properties for TrainerCategory entity
        [Required]
        public int TrainerId { get; set; }
        [Required]
        [MaxLength(15)]
        public string CategoryCode { get; set; } = null!;


        public Trainer? Trainer { get; set; }   // Establishing Many-one relationship with Trainer class
        public Category? Category { get; set; } // Establishing Many-one relationship with Category class

    }
}
