using Microsoft.EntityFrameworkCore;

namespace Studia.Data
{
    public class StudiaContext : DbContext
    {
        public StudiaContext(DbContextOptions<StudiaContext> options)
                : base(options)
        {
        }

        public DbSet<Studia.Models.Task> Task { get; set; } = default!;
    }
}