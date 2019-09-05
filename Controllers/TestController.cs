
using Microsoft.AspNetCore.Mvc;
using Circles_API.Models;

namespace Circles_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public ActionResult<int> Index()
        {
           return 555;
        }

        
        // public ActionResult TestPage()
        // {
        //     return View();
        // }
    }
}