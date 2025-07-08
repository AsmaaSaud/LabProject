using Microsoft.AspNetCore.Mvc;

namespace LabProject3.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }
    }
}
