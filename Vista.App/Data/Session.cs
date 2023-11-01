using System.ComponentModel.DataAnnotations;

namespace Vista.App.Data
{
    public class Session
    {
        // Properties for Session entity
        public int SessionId { get; set; }
        public int TrainerId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime SessionDate { get; set; }
        [MaxLength(40)]
        public string? BookingReference { get; set; }


        public Trainer? Trainer { get; set; }   // Establishing Many-one relationship with Trainer class

    }
}
