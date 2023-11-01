using System.ComponentModel.DataAnnotations;

namespace Vista.App.Data
{
    public class Category
    {
        // Properties for Category entity
        [Key]
        [MaxLength(15)]
        public string CategoryCode { get; set; } = null!;
        [Required]
        [MaxLength(30)]
        public string CategoryName { get; set; } = null!;


        public List<TrainerCategory>? TrainerCategories { get; set; }   // establishing One-many relationship to TrainerCategory

    }
}
