using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ST10038389_PROG7311_PART_2_OF_POE.Models
{
    //ApplicationUser Manages the code functionality from the AccountController actions.
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(50)]
        public string FullName { get; set; }

        [MaxLength(20)]
        public string Role { get; set; }
    }
}
//---------------------------------------------- END OF FILE -----------------------------------------------------------------------