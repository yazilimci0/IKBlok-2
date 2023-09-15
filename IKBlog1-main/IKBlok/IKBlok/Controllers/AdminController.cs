using DataAccessLayer.Repostory;
using Microsoft.AspNetCore.Mvc;

namespace IKBlok.Controllers
{
    public class AdminController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
    }
}
