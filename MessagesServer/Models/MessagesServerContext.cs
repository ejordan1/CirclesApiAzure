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

        public DbSet<MessagesServer.Models.Message> Messages { get; set; }
    }
}
