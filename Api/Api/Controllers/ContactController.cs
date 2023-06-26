using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
