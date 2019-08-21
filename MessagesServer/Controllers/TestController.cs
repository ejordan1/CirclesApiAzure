
using Microsoft.AspNetCore.Mvc;
using MessagesServer.Models;

namespace MessagesServer.Controllers
{
    public class TestController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult TestPage()
        {
            return View();
        }
    }
}