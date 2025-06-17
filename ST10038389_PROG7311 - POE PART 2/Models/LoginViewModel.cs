using System.ComponentModel.DataAnnotations;

namespace ST10038389_PROG7311_PART_2_OF_POE.ViewModels
{
    //Added a new Model called Login View.
    //The Login View model collects the users login details.
    //The user is required to fill in 2 required details before he can add a farmer or product.
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
//--------------------------------------------------- END OF FILE ------------------------------------------------------------
