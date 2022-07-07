using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TourMaxAPI.ViewModel;

namespace TourMaxAPI.DataModel
{
    public class Tour
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public int TourUserId { get; set; }
        public TourUser TourUser { get; set; }

        [Required]
        [Column(TypeName="nvarchar(50)")]
        public string? Name { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public string? Address { get; set; }
        public int StateId { get; set; }

        [ForeignKey("TourCategoryId")]
        public int TourCategoryId { get; set; }
        public TourCategory TourCategory { get; set; }

        [ForeignKey("TourImageId")]
        public int TourImageId { get; set; }
        public TourImage TourImage { get; set; }

        [ForeignKey("BookingId")]
        public int BookingId { get; set; }
        public Booking Booking { get; set; }



    }
}