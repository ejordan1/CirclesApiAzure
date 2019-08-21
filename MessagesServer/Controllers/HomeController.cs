
using Microsoft.AspNetCore.Mvc;
using MessagesServer.Models;

namespace MessagesServer.Controllers
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