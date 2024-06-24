using Microsoft.EntityFrameworkCore;
using ContactMgr.Models;

namespace ContactMgr.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
        {
        }
        public DbSet<Note> Contacts { get; set; }
    }
}
