using Microsoft.AspNetCore.Mvc;

namespace ST10038389_PROG7311_PART_2_OF_POE.Controllers
{
    public class AccountController : Controller
    {
        //Login Action that directs the user to the Login Page.
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }       
        [HttpPost]
        //Post credit of the Login function working.
        public IActionResult Login(string FullName, string Email, string Password)
        {
            if (!string.IsNullOrEmpty(FullName) && !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Password))
            {
            //Login Success
                TempData["LoginSuccess"] = "You have successfully logged into your account.";
                return RedirectToAction("Login");
            }
            //Login Failure
            TempData["LoginError"] = "Login failed. Please try again.";
            return RedirectToAction("Login");
        }

        //Register Action that directs the user to the Register Page.
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        //Register Function and Error Handling Checks for Authentication system.
        [HttpPost]
        public IActionResult Register(string Name, string Surname, int Age, string Email, string Password)
        {
            if (!string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Surname) && Age > 0 &&
                !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Password))
            {
                // Simulate successful registration
                TempData["RegisterSuccess"] = "Registration successful. You can now log in.";
                return RedirectToAction("Register");
            }

            TempData["RegisterError"] = "Registration failed. Please check your input.";
            return RedirectToAction("Register");
        }
    }
}
//------------------------------ END OF FILE -------------------------------------------------------------------------------------
