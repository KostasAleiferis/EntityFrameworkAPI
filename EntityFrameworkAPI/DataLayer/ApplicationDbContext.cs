using EntityFrameworkAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkAPI.DataLayer
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<PortalUser> PortalUsers { get; set; }
    }
}
