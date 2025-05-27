using Forge.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Forge.Data
{
    public class ForgeDbContext : IdentityDbContext<ApplicationUser>
    {
        public ForgeDbContext(DbContextOptions<ForgeDbContext> options) : base(options)
        {
        }

        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Progress> Progresses { get; set; }
    }
}