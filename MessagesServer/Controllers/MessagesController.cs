using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MessagesServer.Models;



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
            return _db.Messages.ToList();
        }

        // // POST api/values
        // [HttpPost]
        // public void Post([FromBody] Message message)
        // {
        //     _db.Messages.Add(message);
        //     _db.SaveChanges();
        // }


        public ActionResult Index()
        {
            return View();
        }
    }
}