using System.ComponentModel.DataAnnotations;

namespace Vista.App.Data
{
    public class Trainer
    {
        // Properties for Trainer entity
        public int TrainerId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = null!;
        [MaxLength(50)]
        public string Location { get; set; } = null!;


        public List<TrainerCategory>? TrainerCategories { get; set; }   // establishing One-many relationship with TrainerCategory class
        public List<Session>? Sessions { get; set; }    // establishing establishing One-many relationship with Session class

    }
}
