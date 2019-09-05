
using Microsoft.AspNetCore.Mvc;
using Circles_API.Models;

namespace Circles_API.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}