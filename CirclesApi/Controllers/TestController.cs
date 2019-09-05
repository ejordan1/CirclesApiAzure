
using Microsoft.AspNetCore.Mvc;
using Circles_API.Models;

namespace Circles_API.Controllers
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