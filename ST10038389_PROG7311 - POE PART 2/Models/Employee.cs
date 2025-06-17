using System.ComponentModel.DataAnnotations;

namespace ST10038389_PROG7311_PART_2_OF_POE.Models
{
    //Employee Model Class
    //Getters and Setters for Employee Model Class
    //Stores the data into the DataBase.
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required, Range(18, 65)]
        public int Age { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Position { get; set; }
    }
}
//---------------------------------------------------------- END OF FILE ---------------------------------------------------------------
