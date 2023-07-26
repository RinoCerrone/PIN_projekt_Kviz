using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Kviz.Models;


namespace Kviz.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        
        public DbSet<QuizResult> QuizResults { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}