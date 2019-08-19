using Microsoft.EntityFrameworkCore;

namespace MessagesServer.Models
{
    public class MessagesServerContext : DbContext
    {

        public DbSet<Message> Messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"server=localhost;user id=root;password=epicodus;port=3306;database=MessagesServer;");

        public MessagesServerContext(DbContextOptions options) : base(options)
        {

        }
        public MessagesServerContext()
        {

        }

    }
}