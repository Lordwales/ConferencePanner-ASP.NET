using Microsoft.EntityFrameworkCore;

namespace Backend.Models
{
    ///<summary>
    ///This is the connection object for our database
    ///</summary>
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Speaker> Speakers { get; set; }
    }
}