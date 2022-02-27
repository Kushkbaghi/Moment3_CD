using Microsoft.EntityFrameworkCore;
using Moment3_CD.Models;


// Create ánd setup database by Dbcontext
namespace Moment3_CD.Data
{
    public class ApplicationDbContext :DbContext
    {
        // Configuration to conect DbContext to EF
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
             
        }
        // Create a CD table
        public DbSet<CD> CDs { get; set; }

        // Create a Artisttable
        public DbSet<Artist> Artists { get; set; }
    }
}
