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
    public class MessagesController2 : Controller
    {

        private readonly MessagesServerContext _db;
        // = new MessagesServerContext();

        public MessagesController2(MessagesServerContext db)
        {
            _db = db;
        }

        // GET api/animals
        [HttpGet]
        public ActionResult<IEnumerable<Message2>> Get()
        {
            
            // Message newMessage = new Message();
            // Random ran = new Random();
            // newMessage.MessageId = ran.Next(0, 10000);
            // newMessage.MessageNote = "test";
            // newMessage.MessageText = "auto generated";
            // newMessage.MessageNumber = 1;

            // _db.MessagesTest1.Add(newMessage);
            // _db.SaveChangesAsync();

            return _db.MessagesTest2.ToList();
            //return View();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Message2 message2)
        {
            _db.MessagesTest2.Add(message2);
            _db.SaveChanges();
        }


        public ActionResult Index()
        {
            return View();
        }
    }
}