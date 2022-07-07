using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TourMaxAPI.DataModel
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        public DateTime BookingDate { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string? Duration { get; set; }
        public List<Tour> tours { get; set; }
    }
}
