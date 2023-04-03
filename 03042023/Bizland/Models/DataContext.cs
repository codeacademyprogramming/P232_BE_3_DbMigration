using Microsoft.EntityFrameworkCore;

namespace Bizland.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }

        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
