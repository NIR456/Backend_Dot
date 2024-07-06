using Microsoft.AspNetCore.Mvc;

namespace API_Login.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
