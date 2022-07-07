using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using TourMaxAPI.DataModel;

namespace TourMaxAPI.ViewModel
{
    public class TourUser : IdentityUser
    {
        [Key]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Created { get; set; }
        public List<Tour> Tours { get; set; }
    }
}
