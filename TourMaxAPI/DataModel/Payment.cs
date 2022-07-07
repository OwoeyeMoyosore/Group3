using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TourMaxAPI.DataModel
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        public int BookingId { get; set;}
        public int UserId { get; set; }
        [Column(TypeName = "Decimal(18,0)")]
        public decimal Amount { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
