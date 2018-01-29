using AspCoreServer.Models;
using Microsoft.EntityFrameworkCore;

namespace AspCoreServer.Data
{
    public class AwsContext : DbContext
    {
        public AwsContext(DbContextOptions<AwsContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        //List of DB Models - Add your DB models here
        public DbSet<User> User { get; set; }
        public DbSet<SearchResult> SearchResults { get; set; }
  }
}
