using Microsoft.EntityFrameworkCore;

namespace MessagesServer.Models
{
    public class MessagesServerContext : DbContext
    {

        public DbSet<Message> Messages { get; set; }



        public MessagesServerContext(DbContextOptions options) : base(options)
        {

        }
        public MessagesServerContext()
        {

        }

    }
}