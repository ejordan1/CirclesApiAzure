using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MessagesServer.Models
{
    public class MessagesServerContext : DbContext
    {
        public MessagesServerContext(DbContextOptions<MessagesServerContext> options)
            : base(options)
        {
        }

        public DbSet<MessagesServer.Models.Message> MessagesTest1 { get; set; }
        public DbSet<MessagesServer.Models.Message2> MessagesTest2 { get; set; }
    }
}
