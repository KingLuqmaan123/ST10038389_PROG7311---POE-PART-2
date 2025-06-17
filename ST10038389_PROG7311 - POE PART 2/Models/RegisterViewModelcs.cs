using System.ComponentModel.DataAnnotations;

namespace ST10038389_PROG7311_PART_2_OF_POE.ViewModels
{
    //Added a new Model called Register View.
    //This models action is to collect the users Register details and to be displayed via the DB.
    public class RegisterViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        [Range(18, 65, ErrorMessage = "Age must be between 18 and 65.")]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
//---------------------------------- END OF FILE ----------------------------------------------------------------------------------
