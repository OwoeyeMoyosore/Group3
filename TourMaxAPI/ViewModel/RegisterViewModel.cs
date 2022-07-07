using System.ComponentModel.DataAnnotations;

namespace TourMaxAPI.ViewModel
{
    public class RegisterViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage ="FirstName is Required")]
        [MaxLength(150, ErrorMessage ="Maximum Length Exceeded")]
        [MinLength(2, ErrorMessage ="First Name cannot be less than 2 characters")]
        public string? FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "LastName is Required")]
        [MaxLength(150, ErrorMessage = "Maximum Length Exceeded")]
        [MinLength(2, ErrorMessage = "Last Name cannot be less than 2 characters")]
        public string? LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email is Required")]
        [MaxLength(150, ErrorMessage = "Maximum Length Exceeded")]
        //[MinLength(2, ErrorMessage = "First Name cannot be less than 2 characters")]
        public string? Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "UserName is Required")]
        [MaxLength(150, ErrorMessage = "Maximum Length Exceeded")]
        [MinLength(2, ErrorMessage = "Username cannot be less than 2 characters")]
        public string? UserName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is Required")]
        [MaxLength(150, ErrorMessage = "Maximum Length Exceeded")]
        [MinLength(6, ErrorMessage = "First Name cannot be less than Six(6) characters")]
        public string? Password { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }
    }
}
