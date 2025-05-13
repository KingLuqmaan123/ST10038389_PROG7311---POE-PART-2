using Microsoft.AspNetCore.Identity;

namespace ST10038389_PROG7311___POE_PART_2.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Role { get; set; }
    }
}
//----------------------------------------------------- END OF FILE -----------------------------------------------------------------