
using Microsoft.AspNetCore.Mvc;
using MessagesServer.Models;

namespace MessagesServer.Controllers
{
    public class TestController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("/")]
        public ActionResult TestPage()
        {
            return View();
        }
    }
}