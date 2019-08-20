using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MessagesServer.Models;

namespace MessagesServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private MessagesServerContext _db = new MessagesServerContext();

        // GET api/animals
        [HttpGet]
        public ActionResult<IEnumerable<Message>> Get()
        {
            return _db.Messages.ToList();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Message message)
        {
            _db.Messages.Add(message);
            _db.SaveChanges();
        }
    }
}