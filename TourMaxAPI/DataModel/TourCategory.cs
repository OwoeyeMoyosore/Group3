using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TourMaxAPI.DataModel
{
    public class TourCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string? Description { get; set; }
        public List<Tour> tours { get; set; }
        public List<TourImage> tourImages { get; set; }
    }
}
