using Microsoft.EntityFrameworkCore;


namespace ChatApp.Models
{
    public class messageContext : DbContext
    {
        public messageContext( DbContextOptions<messageContext> options )
            : base( options )
        {
        }

        public DbSet<Message> MessageItems { get; set; }
    }
}

