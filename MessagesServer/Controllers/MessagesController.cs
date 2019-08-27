using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MessagesServer.Models;

using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.Rendering;



namespace MessagesServer.Controllers
{

    // [ApiController]
    //make it ControllerBase again
    public class MessagesController : Controller
    {

        private readonly MessagesServerContext _db;
        // = new MessagesServerContext();

        public MessagesController(MessagesServerContext db)
        {
            _db = db;
        }


        // GET api/animals
        [HttpGet]
        public ActionResult<IEnumerable<Message>> Get()
        {
            
            // Message newMessage = new Message();
            // Random ran = new Random();
            // newMessage.MessageId = ran.Next(0, 10000);
            // newMessage.MessageNote = "test";
            // newMessage.MessageText = "auto generated";
            // newMessage.MessageNumber = 1;

            // _db.MessagesTest1.Add(newMessage);
            // _db.SaveChangesAsync();

            return _db.MessagesTest1.ToList();
            //return View();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Message message)
        {
            _db.MessagesTest1.Add(message);
            _db.SaveChanges();
        }


        public ActionResult Index()
        {
            return View();
        }
    }
}