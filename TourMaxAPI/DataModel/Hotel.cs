using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TourMaxAPI.DataModel
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string? Name { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string? Description { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string? Location { get; set; }

        [ForeignKey("Tour")]
        public int TourId { get; set; }
        public Tour Tour { get; set; }
    }
}
