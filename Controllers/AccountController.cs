using Microsoft.AspNetCore.Mvc;

namespace carnage.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        public IActionResult LoginEnterEmail()
        {
            return View();
        }

        public IActionResult CodeVerification()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Orders()
        {
            return View();
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginEnterEmail(string email)
        {
            // Add your email validation logic here
            if (string.IsNullOrEmpty(email))
            {
                ModelState.AddModelError("", "Email is required");
                return View();
            }

            // For now, redirect to code verification
            // In a real app, you'd send the verification code here
            TempData["Email"] = email;
            return RedirectToAction("CodeVerification");
        }

        [HttpPost]
        public IActionResult CodeVerification(string code)
        {
            // Add your code verification logic here
            if (string.IsNullOrEmpty(code))
            {
                ModelState.AddModelError("", "Verification code is required");
                return View();
            }

            // For now, redirect to a success page or home
            // In a real app, you'd verify the code and sign in the user
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            // Add logout logic here
            return RedirectToAction("Index", "Home");
        }
    }
}