using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RadicalGamingForum.Models;

namespace RadicalGamingForum.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Questions> Questions { get; set; }

        public DbSet<Answers> Answers { get; set; }
    }
}
