
using Microsoft.AspNetCore.Mvc;
using Circles_API.Models;

namespace Circles_API.Controllers
{
    // [ApiController]
    public class TestController : Controller
    {

        public int Index()
        {
           return 555;
        }


        public ActionResult TestPage()
        {
            return View();
        }
    }
}